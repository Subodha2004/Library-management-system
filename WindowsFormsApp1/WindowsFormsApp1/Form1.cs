using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SarasaviLibrarySystem
{
    public partial class FormInquiry : Form
    {
        public FormInquiry()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter a book title or publisher name.");
                return;
            }

            try
            {
                string connectionString = @"Data Source=DESKTOP-B7C25O4\SQLEXPRESS03;Initial Catalog=LibraryDB;Integrated Security=True;";
                // Search by Title or Publisher (partial match)
                string qry = @"SELECT Id, Classification, Number, Title, Publisher, 
                                      CASE WHEN IsReference = 1 THEN 'Yes' ELSE 'No' END AS Reference, 
                                      Copies 
                               FROM Books 
                               WHERE Title LIKE @keyword OR Publisher LIKE @keyword";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmnd = new SqlCommand(qry, conn);
                    cmnd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmnd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvResults.DataSource = dt;
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}