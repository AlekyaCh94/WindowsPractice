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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnGetAnswer_Click(object sender, EventArgs e)
        {

            {
                string username = textUserName.Text.Trim();
                string securityQuestion = comboBoxSecurityQuestion.SelectedItem.ToString();
                string answer = textAnswer.Text.Trim();

                string connectionString = ("Data Source=ALEKYAVAMSEE;Initial Catalog=Training;Integrated Security=True;");
                string query = "SELECT Password FROM NewUser WHERE Username = @Username AND SecurityQuestion = @SecurityQuestion AND Answer = @Answer";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@SecurityQuestion", securityQuestion);
                    command.Parameters.AddWithValue("@Answer", answer);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            string password = result.ToString();
                            MessageBox.Show($"Your password is: {password}", "Password Retrieved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Invalid credentials. Please check your inputs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}

