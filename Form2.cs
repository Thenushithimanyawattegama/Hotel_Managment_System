using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hotel_managment_system
{
    public partial class Form2 : Form
    {
        // Connection string to your SQL Server
        private string connectionString = "Data Source=DESKTOP-R4KM1VQ;Initial Catalog=HotelManagmentSystem;Integrated Security=True;Encrypt=False";

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.username.Text; // Replace with your username input TextBox name
            string password = this.password.Text; // Replace with your password input TextBox name

            if (ValidateLogin(username, password))
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            // Validate input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(1) FROM users WHERE username = @username AND password = @password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count == 1; // Return true if one match is found
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
