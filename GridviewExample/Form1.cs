using System;
using System.Windows.Forms;    // Librarys 
using System.Data.SqlClient;
using System.Data;// Step-1
using System.Configuration;

namespace GridviewExample   // ProjectName
{
    public partial class Form1 : Form   // All windows forms are inherited from Form Class.
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString);  // step-2
        DataSet ds = new DataSet();
        public Form1()   // Constructor 
        {
            InitializeComponent();  // Method which contains design specic code 
        }

        private void btnGet_Click(object sender, EventArgs e) //Event 
        {
            //Logic          

            SqlDataAdapter da = new SqlDataAdapter("select * from customers", con);   ///step-3

            con.Open(); //step-4

            da.Fill(ds);

            dgvCustomers.DataSource = ds;
            dgvCustomers.DataMember = ds.Tables[0].ToString();
            con.Close();

        }
    }
}
