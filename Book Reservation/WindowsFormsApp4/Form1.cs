using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=DESKTOP-B7C25O4\SQLEXPRESS03;Initial Catalog=LibraryDB;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnReservationSearch_Click(object sender, EventArgs e)
        {
            string accessionNoText = txtAccessionNo.Text.Trim();
            if (string.IsNullOrEmpty(accessionNoText))
            {
                lblReservationStatus.Text = "Please enter Book Id (Accession No).";
                lblReservationStatus.ForeColor = System.Drawing.Color.Red;
                dgvReservationResults.DataSource = null;
                return;
            }

            if (!int.TryParse(accessionNoText, out int accessionNo))
            {
                lblReservationStatus.Text = "Accession No must be a number.";
                lblReservationStatus.ForeColor = System.Drawing.Color.Red;
                dgvReservationResults.DataSource = null;
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Id, Title, CASE WHEN IsReference = 1 THEN 'Reference' ELSE (CASE WHEN Copies > 0 THEN 'Available' ELSE 'Unavailable' END) END AS Status FROM Books WHERE Id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", accessionNo);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        lblReservationStatus.Text = "Book not found.";
                        lblReservationStatus.ForeColor = System.Drawing.Color.Red;
                        dgvReservationResults.DataSource = null;
                    }
                    else
                    {
                        dgvReservationResults.DataSource = dt;
                        lblReservationStatus.Text = "Book availability shown below.";
                        lblReservationStatus.ForeColor = System.Drawing.Color.Black;
                    }
                }
                catch (Exception ex)
                {
                    lblReservationStatus.Text = "Database error: " + ex.Message;
                    lblReservationStatus.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void btnConfirmReservation_Click(object sender, EventArgs e)
        {
            string borrowerId = txtBorrowerId.Text.Trim();
            if (string.IsNullOrEmpty(borrowerId))
            {
                lblReservationStatus.Text = "Please enter Borrower ID.";
                lblReservationStatus.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Please enter Borrower ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvReservationResults.Rows.Count == 0 || dgvReservationResults.CurrentRow == null)
            {
                lblReservationStatus.Text = "No book selected for reservation.";
                lblReservationStatus.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("No book selected for reservation.", "Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int accessionNo = Convert.ToInt32(dgvReservationResults.CurrentRow.Cells["Id"].Value);
            string status = dgvReservationResults.CurrentRow.Cells["Status"].Value.ToString();

            if (status != "Available")
            {
                lblReservationStatus.Text = "Book is not available for reservation.";
                lblReservationStatus.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Book is not available for reservation.", "Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Insert reservation
                    SqlCommand insertCmd = new SqlCommand(
                        "INSERT INTO Reservations (AccessionNo, BorrowerID, ReservationDate) VALUES (@accessionNo, @borrowerId, @date)", conn);
                    insertCmd.Parameters.AddWithValue("@accessionNo", accessionNo);
                    insertCmd.Parameters.AddWithValue("@borrowerId", borrowerId);
                    insertCmd.Parameters.AddWithValue("@date", DateTime.Now);

                    int rows = insertCmd.ExecuteNonQuery();

                    // Optionally, decrement Copies count
                    SqlCommand updateCmd = new SqlCommand(
                        "UPDATE Books SET Copies = Copies - 1 WHERE Id = @id AND Copies > 0", conn);
                    updateCmd.Parameters.AddWithValue("@id", accessionNo);
                    updateCmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        lblReservationStatus.ForeColor = System.Drawing.Color.Green;
                        lblReservationStatus.Text = $"Book reserved successfully for Borrower ID: {borrowerId}";
                        MessageBox.Show($"Book reserved successfully for Borrower ID: {borrowerId}", "Reservation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Refresh the grid to show updated status
                        btnReservationSearch_Click(null, null);
                    }
                    else
                    {
                        lblReservationStatus.ForeColor = System.Drawing.Color.Red;
                        lblReservationStatus.Text = "Reservation failed.";
                        MessageBox.Show("Reservation failed.", "Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    lblReservationStatus.Text = "Database error: " + ex.Message;
                    lblReservationStatus.ForeColor = System.Drawing.Color.Red;
                    MessageBox.Show("Database error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}