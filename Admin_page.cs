using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Banking
{
    public partial class Admin_page : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HI0EHL6C\SQLEXPRESS;Initial Catalog=loan_info;Integrated Security=True;Encrypt=False");

        public Admin_page()
        {
            InitializeComponent();
            Load += new EventHandler(Admin_page_Load);
            
        }

        public void hidePanels()
        {
            LoanPanel.Visible = false;
            feedBackPanel.Visible = false;
        }
        private void Admin_page_Load(object sender, EventArgs e)
        {
            
            hidePanels();
        }

        private void loanRequests_Click(object sender, EventArgs e)
        {

            hidePanels();
            LoanPanel.Visible=true;
            LoanPanel.BringToFront();
            con.Open();
            string Query = "SELECT * FROM loan_info_details";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void feedBack_Click(object sender, EventArgs e)
        {
            hidePanels();
            feedBackPanel.Visible=true;
            con.Open();
            string Query = "SELECT * FROM feedback_table";
            SqlCommand cmd = new SqlCommand(Query, con);
            var reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            feedBackDetails.DataSource = dt;
            con.Close();
        }

        private void form1Return_Click(object sender, EventArgs e)
        {
           Form1 fm=new Form1();
            fm.Show();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string Query = "UPDATE loan_info_details SET Status='"+loanSts.SelectedItem+"' WHERE acc_number="+whereToChange.Text+"";
            SqlCommand cmd=new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Has been updated");
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
           
            logout lg = new logout();
            lg.Show();
        }
    }
}
