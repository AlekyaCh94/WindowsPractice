using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridviewExample
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Logic -to accept only alphabets 

            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Only Alphabets");
            }

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            //Email Validation
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (!reg.IsMatch(txtEmail.Text))
                {
                    MessageBox.Show("Invalid Email");
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Add new user code here
            string userName = txtUserName.Text;
            string password = textPassword.Text;
            string confirmPassword = textConfirmedPassword.Text;
            string gender = radioMale.Checked ? radioMale.Text : radiofemale.Text;   // terinary operater 
            //if (radioMale.Checked)
            //{
            //    gender = "Male";
            //}
            //else if (radiofemale.Checked)
            //{
            //    gender = "Female";
            //}

            List<string> hobbies = new List<string>();
            if (CheckBoxReading.Checked)
            {
                hobbies.Add("Reading");
            }
            else if (checkBoxWriting.Checked)
            {
                hobbies.Add("Writing");
            }
            else if (checkBoxDancing.Checked)
            {
                hobbies.Add("Dancing");
            }
            else if (checkBoxCricket.Checked)
            {
                hobbies.Add("Cricket");
            }

            string securityQuestion = comboboxSecurityQuestion.SelectedItem.ToString();
            string answer = textAnswer.Text;
            string email = txtEmail.Text;

            // Connect to sql

            SqlConnection connection = new SqlConnection("Data Source = ALEKYAVAMSEE; Initial Catalog = Training; Integrated Security = True; ");

            try
            {

                connection.Open();


                string insertQuery = "INSERT INTO NewUser (UserName, Password, Gender, Hobbies, SecurityQuestion, Answer, Email) VALUES (@userName, @password, @gender, @hobbies, @securityQuestion, @answer, @email)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);

                insertCommand.Parameters.AddWithValue("@userName", userName);
                insertCommand.Parameters.AddWithValue("@password", password);
                insertCommand.Parameters.AddWithValue("@gender", gender);
                insertCommand.Parameters.AddWithValue("@hobbies", string.Join(",", hobbies));
                insertCommand.Parameters.AddWithValue("@securityQuestion", securityQuestion);
                insertCommand.Parameters.AddWithValue("@answer", answer);
                insertCommand.Parameters.AddWithValue("@email", email);

                insertCommand.ExecuteNonQuery();

                MessageBox.Show("New user added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtUserName.Text = "";
                textPassword.Text = "";
                textConfirmedPassword.Text = "";
                radioMale.Checked = false;
                radiofemale.Checked = false;
                CheckBoxReading.Checked = false;
                checkBoxWriting.Checked = false;
                checkBoxDancing.Checked = false;
                checkBoxCricket.Checked = false;
                comboboxSecurityQuestion.SelectedIndex = -1;
                textAnswer.Text = "";
                txtEmail.Text = "";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }


            }
        }
    }
}


