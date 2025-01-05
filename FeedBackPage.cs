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

namespace ATM_Banking
{
    public partial class FeedBackPage : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HI0EHL6C\SQLEXPRESS;Initial Catalog=loan_info;Integrated Security=True;Encrypt=False");

        public FeedBackPage()
        {
            InitializeComponent();
        }

        private void FeedBackPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string query = "INSERT INTO feedback_table (Name, Email, Liked_Disliked, Explained) VALUES (@Name, @Email, @LikedDisliked, @Explained)";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Name", fdName.Text);
            cmd.Parameters.AddWithValue("@Email", fdEmail.Text);
            cmd.Parameters.AddWithValue("@LikedDisliked", fdLikedDisliked.Text);
            cmd.Parameters.AddWithValue("@Explained", fdExplain.Text);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Thank You For Your Valuable Response");
        }

        private void fdBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
