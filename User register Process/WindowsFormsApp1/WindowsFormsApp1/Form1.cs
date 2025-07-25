using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Ensure event handler is attached
            btnRegister.Click += BtnRegister_Click;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string sex = cmbSex.SelectedItem?.ToString();
            string nic = txtNIC.Text.Trim();
            string address = txtAddress.Text.Trim();

            // Validation
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(sex) ||
                string.IsNullOrWhiteSpace(nic) ||
                string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nic.Length < 3)
            {
                MessageBox.Show("NIC must have at least 3 characters to generate User Number.", "NIC Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Auto-generate user number
            string userNumber =  nic.Substring(0, 3) + "01";
            txtUserNumber.Text = userNumber;

            // Database insert
            string connectionString = @"Data Source=DESKTOP-B7C25O4\SQLEXPRESS03;Initial Catalog=LibraryDB;Integrated Security=True";
            string insertQuery = "INSERT INTO Users (UserNumber, Name, Sex, NIC, Address) VALUES (@UserNumber, @Name, @Sex, @NIC, @Address)";

            try
            {
                using (var conn = new System.Data.SqlClient.SqlConnection(connectionString))
                using (var cmd = new System.Data.SqlClient.SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@UserNumber", userNumber);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Sex", sex);
                    cmd.Parameters.AddWithValue("@NIC", nic);
                    cmd.Parameters.AddWithValue("@Address", address);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(
                    $"User Registered Successfully!\n\nName: {name}\nSex: {sex}\nNIC: {nic}\nAddress: {address}\nUser Number: {userNumber}",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
