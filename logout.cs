using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Banking
{
    public partial class logout : Form
    {
        public logout()
        {
            InitializeComponent();
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
            Admin_page admin_Page = new Admin_page();
            admin_Page.Close();
            Admin_login admin_Login = new Admin_login();
            admin_Login.Close();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
