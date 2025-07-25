using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private ClassificationTracker tracker = new ClassificationTracker();

        public Form1()
        {
            InitializeComponent();
            // Ensure the event handler is attached
            btnRegister.Click += btnRegister_Click;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string classification = txtClassification.Text.Trim().ToUpper();
            if (classification.Length != 1)
            {
                MessageBox.Show("Classification must be a single character.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string title = txtTitle.Text.Trim();
            string publisher = txtPublisher.Text.Trim();
            bool isReference = chkReference.Checked;
            int copies = (int)numCopies.Value;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(publisher) || copies < 1)
            {
                MessageBox.Show("Please fill in all fields and ensure copies is at least 1.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int number = tracker.GetNextNumber(classification);
            Book newBook = new Book()
            {
                Classification = classification,
                Number = number,
                Title = title,
                Publisher = publisher,
                IsReference = isReference,
                Copies = copies
            };

            string connectionString = @"Data Source=DESKTOP-B7C25O4\SQLEXPRESS03;Initial Catalog=LibraryDB;Integrated Security=True";
            string insertBookQuery = "INSERT INTO Books (Classification, Number, Title, Publisher, IsReference, Copies) " +
                                     "VALUES (@Classification, @Number, @Title, @Publisher, @IsReference, @Copies); SELECT SCOPE_IDENTITY();";

            try
            {
                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(insertBookQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Classification", newBook.Classification);
                    cmd.Parameters.AddWithValue("@Number", newBook.Number);
                    cmd.Parameters.AddWithValue("@Title", newBook.Title);
                    cmd.Parameters.AddWithValue("@Publisher", newBook.Publisher);
                    cmd.Parameters.AddWithValue("@IsReference", newBook.IsReference);
                    cmd.Parameters.AddWithValue("@Copies", newBook.Copies);

                    conn.Open();
                    // Insert book and get new BookID
                    object result = cmd.ExecuteScalar();
                    int bookId = Convert.ToInt32(result);

                    // Get the current max CopyID
                    int nextCopyId = 1;
                    using (var maxCmd = new SqlCommand("SELECT ISNULL(MAX(CopyID), 0) FROM BookCopies", conn))
                    {
                        object maxResult = maxCmd.ExecuteScalar();
                        nextCopyId = Convert.ToInt32(maxResult) + 1;
                    }

                    // Insert copies with unique CopyID
                    for (int i = 0; i < copies; i++)
                    {
                        using (var copyCmd = new SqlCommand(
                            "INSERT INTO BookCopies (CopyID, BookID, IsAvailable, ReservedBy, Status) VALUES (@CopyID, @BookID, @IsAvailable, NULL, @Status)", conn))
                        {
                            copyCmd.Parameters.AddWithValue("@CopyID", nextCopyId++);
                            copyCmd.Parameters.AddWithValue("@BookID", bookId);
                            copyCmd.Parameters.AddWithValue("@IsAvailable", true);
                            copyCmd.Parameters.AddWithValue("@Status", isReference ? "Reference" : "Available");
                            copyCmd.ExecuteNonQuery();
                        }
                    }

                    List<string> bookNumbers = newBook.GenerateBookNumbers();
                    lstBookNumbers.Items.Clear();
                    foreach (var num in bookNumbers)
                    {
                        lstBookNumbers.Items.Add(num);
                    }
                    MessageBox.Show("Book registered and copies saved to database successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("A database error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}