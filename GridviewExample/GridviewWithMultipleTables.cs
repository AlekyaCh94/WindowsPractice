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
    public partial class GridviewWithMultipleTables : Form
    {
        public GridviewWithMultipleTables()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string connectionString = ("Data Source=ALEKYAVAMSEE;Initial Catalog=Training;Integrated Security=True;");
            string query = "SELECT Employee.Empid, Employee.EmpName " +
                           "FROM Employee " +
                           "INNER JOIN EmployeeManager ON Employee.Empid = EmployeeManager.Empid";

            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataGridView dataGridView = new DataGridView();


            }
        }
    }
}
