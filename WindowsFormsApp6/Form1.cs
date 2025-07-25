using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=DESKTOP-B7C25O4\SQLEXPRESS03;Initial Catalog=LibraryDB;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            this.btnCheckEligibility.Click += new System.EventHandler(this.btnCheckEligibility_Click);
        }

        private void lblCopyStatus_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpLoanDate.Value = DateTime.Today;
            dtpReturnDate.Value = DateTime.Today.AddDays(14);

            //Optionally, load data from the database to populate controls
            // Example: Load all users or available copies
            // LoadUsers();
            //LoadAvailableCopies();
        }

        private void btnCheckEligibility_Click(object sender, EventArgs e)
        {
            string userID = txtUserID.Text.Trim();
            string copyID = txtCopyID.Text.Trim();

            if (string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(copyID))
            {
                lblMessage.Text = "Please enter both User ID and Copy ID.";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if User exists
                    SqlCommand userCheck = new SqlCommand("SELECT COUNT(*) FROM Users WHERE UserNumber = @userNumber", conn);
                    userCheck.Parameters.AddWithValue("@userNumber", userID);
                    int userExists = (int)userCheck.ExecuteScalar();
                    if (userExists == 0)
                    {
                        lblMessage.Text = "❌ User ID not found.";
                        lblMessage.ForeColor = Color.Red;
                        return;
                    }

                    // Check if Copy exists and get status
                    SqlCommand statusCmd = new SqlCommand("SELECT Status FROM BookCopies WHERE CopyID = @copyID", conn);
                    statusCmd.Parameters.AddWithValue("@copyID", copyID);
                    object statusResult = statusCmd.ExecuteScalar();

                    if (statusResult == null)
                    {
                        lblMessage.Text = "❌ Copy ID not found.";
                        lblMessage.ForeColor = Color.Red;
                        return;
                    }

                    string copyStatus = statusResult.ToString();
                    if (copyStatus == "Reference")
                    {
                        lblMessage.Text = "❌ This copy is for reference only and cannot be borrowed.";
                        lblMessage.ForeColor = Color.Red;
                        return;
                    }

                    // Check if copy is already loaned
                    SqlCommand loanedCmd = new SqlCommand("SELECT COUNT(*) FROM BookLoans WHERE CopyID = @copyID AND ReturnDate >= GETDATE()", conn);
                    loanedCmd.Parameters.AddWithValue("@copyID", copyID);
                    int alreadyLoaned = (int)loanedCmd.ExecuteScalar();
                    if (alreadyLoaned > 0)
                    {
                        lblMessage.Text = "❌ This copy is already loaned to another user.";
                        lblMessage.ForeColor = Color.Red;
                        return;
                    }

                    // Check if user has 5 or more active loans
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM BookLoans WHERE UserNumber = @userNumber AND ReturnDate >= GETDATE()", conn);
                    checkCmd.Parameters.AddWithValue("@userNumber", userID);
                    int activeLoans = (int)checkCmd.ExecuteScalar();
                    if (activeLoans >= 5)
                    {
                        lblMessage.Text = "❌ You cannot borrow more than 5 books at once.";
                        lblMessage.ForeColor = Color.Red;
                        return;
                    }

                    lblMessage.Text = "✅ Eligible for loan.";
                    lblMessage.ForeColor = Color.Green;
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Database error: " + ex.Message;
                    lblMessage.ForeColor = Color.Red;
                }
            }
        }

        private void grpMemberDetails_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmLoan_Click(object sender, EventArgs e)
        {
            string userID = txtUserID.Text.Trim();
            string copyID = txtCopyID.Text.Trim();
            DateTime loanDate = dtpLoanDate.Value;
            DateTime returnDate = dtpReturnDate.Value;

            if (string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(copyID))
            {
                lblMessage.Text = "Please enter both User ID and Copy ID.";
                lblMessage.ForeColor = Color.Red;
                MessageBox.Show("Please enter both User ID and Copy ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // 1. Check if User exists
                    SqlCommand userCheck = new SqlCommand("SELECT COUNT(*) FROM Users WHERE UserNumber = @userNumber", conn);
                    userCheck.Parameters.AddWithValue("@userNumber", userID);
                    int userExists = (int)userCheck.ExecuteScalar();
                    if (userExists == 0)
                    {
                        lblMessage.Text = "❌ User ID not found.";
                        lblMessage.ForeColor = Color.Red;
                        MessageBox.Show("User ID not found.", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 2. Check if Copy exists and get status
                    SqlCommand statusCmd = new SqlCommand("SELECT Status FROM BookCopies WHERE CopyID = @copyID", conn);
                    statusCmd.Parameters.AddWithValue("@copyID", copyID);
                    object statusResult = statusCmd.ExecuteScalar();

                    if (statusResult == null)
                    {
                        lblMessage.Text = "❌ Copy ID not found.";
                        lblMessage.ForeColor = Color.Red;
                        MessageBox.Show("Copy ID not found.", "Copy Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string copyStatus = statusResult.ToString();
                    if (copyStatus == "Reference")
                    {
                        lblMessage.Text = "❌ This copy is for reference only and cannot be borrowed.";
                        lblMessage.ForeColor = Color.Red;
                        MessageBox.Show("This copy is for reference only and cannot be borrowed.", "Reference Copy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 3. Check if copy is already loaned
                    SqlCommand loanedCmd = new SqlCommand("SELECT COUNT(*) FROM BookLoans WHERE CopyID = @copyID AND ReturnDate >= GETDATE()", conn);
                    loanedCmd.Parameters.AddWithValue("@copyID", copyID);
                    int alreadyLoaned = (int)loanedCmd.ExecuteScalar();
                    if (alreadyLoaned > 0)
                    {
                        lblMessage.Text = "❌ This copy is already loaned to another user.";
                        lblMessage.ForeColor = Color.Red;
                        MessageBox.Show("This copy is already loaned to another user.", "Loan Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 4. Check if user has 5 or more active loans
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM BookLoans WHERE UserNumber = @userNumber AND ReturnDate >= GETDATE()", conn);
                    checkCmd.Parameters.AddWithValue("@userNumber", userID);
                    int activeLoans = (int)checkCmd.ExecuteScalar();
                    if (activeLoans >= 5)
                    {
                        lblMessage.Text = "❌ You cannot borrow more than 5 books at once.";
                        lblMessage.ForeColor = Color.Red;
                        MessageBox.Show("You cannot borrow more than 5 books at once.", "Loan Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 5. Insert the loan
                    SqlCommand insertCmd = new SqlCommand(
                        "INSERT INTO BookLoans (UserNumber, CopyID, LoanDate, ReturnDate) VALUES (@userNumber, @copyID, @loanDate, @returnDate)",
                        conn
                    );
                    insertCmd.Parameters.AddWithValue("@userNumber", userID); // userID is actually UserNumber
                    insertCmd.Parameters.AddWithValue("@copyID", copyID);
                    insertCmd.Parameters.AddWithValue("@loanDate", loanDate);
                    insertCmd.Parameters.AddWithValue("@returnDate", returnDate);

                    int rowsAffected = insertCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        lblMessage.Text = "✅ Book successfully loaned.";
                        lblMessage.ForeColor = Color.Green;
                        MessageBox.Show("Book successfully loaned.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        lblMessage.Text = "❌ Loan failed. Please try again.";
                        lblMessage.ForeColor = Color.Red;
                        MessageBox.Show("Loan failed. Please try again.", "Loan Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Database error: " + ex.Message;
                    lblMessage.ForeColor = Color.Red;
                    MessageBox.Show("Database error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}