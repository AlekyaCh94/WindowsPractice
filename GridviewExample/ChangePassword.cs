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

namespace GridviewExample
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = textUserName.Text.Trim();
            string currentPassword = textCurrentPassword.Text.Trim();
            string newPassword = textNewPassword.Text.Trim();
            string confirmPassword = textConfirmedPassword.Text.Trim();

            // Check if new password and confirm password match
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = ("Data Source=ALEKYAVAMSEE;Initial Catalog=Training;Integrated Security=True;");
            string query = "SELECT COUNT(*) FROM NewUser WHERE Username = @Username AND Password = @Password";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", currentPassword);

            try
            {
                connection.Open();
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                {
                    // Update password if username and current password match
                    string updateQuery = "UPDATE NewUser SET Password = @NewPassword WHERE Username = @Username";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@NewPassword", newPassword);
                    updateCommand.Parameters.AddWithValue("@Username", username);
                    updateCommand.ExecuteNonQuery();

                    MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid username or current password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();

        }

        private void lnkLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}

