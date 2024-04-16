using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;  // step-1
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridviewExample
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            btnLogin.Enabled = false;

        }
        private void textUserName_TextChanged(object sender, EventArgs e)
        {
            textUserName.TextChanged += textUserName_TextChanged;
            btnLogin.Visible = !string.IsNullOrWhiteSpace(textUserName.Text) && !string.IsNullOrWhiteSpace(textPassword.Text);
        }
        private void textPassword_TextChanged(object sender, EventArgs e)
        {


            textPassword.TextChanged += textPassword_TextChanged;
            btnLogin.Visible = !string.IsNullOrWhiteSpace(textUserName.Text) && !string.IsNullOrWhiteSpace(textPassword.Text);
        }
        private void lnkNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new NewUser();
            f.ShowDialog();

        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new ForgotPassword();
            f.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textUserName.Text) || String.IsNullOrEmpty(textPassword.Text))
            {
                MessageBox.Show("Please enter both username and password.");
                return;

            }

            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TrainingDbConn"].ConnectionString))   // Step-2  Memory Managemnt
                {
                    string query = "SELECT COUNT(*) FROM NewUser WHERE Username = @Username AND Password = @Password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", textUserName.Text.Trim());
                    command.Parameters.AddWithValue("@Password", textPassword.Text.Trim());

                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //  successful login
                            Form f = new ChangePassword();
                            f.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                    }
                }
            }


        }
    }
}

