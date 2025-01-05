using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Banking
{
    public partial class Admin_login : Form
    {
        public Admin_login()
        {
            InitializeComponent();
        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string password = txtPassword.Text;

            if (id == "rahul" && password == "28682749")
            {
                MessageBox.Show("Login successful!");

                using (StreamWriter writer = new StreamWriter("log.txt", true))
                {
                    writer.WriteLine($"Login successful for user: {id}");
                }

                Admin_page ad1 = new Admin_page();
                ad1.Show();
                this.Hide();
                Form1 form1 = new Form1();
                form1.Hide();
            }
            
            else if (id == "")
            {
                MessageBox.Show("Please Enter ID");
            }
            else if (password == "")
            {
                MessageBox.Show("Please Enter Password");
            }
            else if (id == "" && password == "")
            {
                MessageBox.Show(" Please enter both ID and Password!");
            }
            else if (id != "rahul" && password != "28682749")
            {
                MessageBox.Show("Both ID and Password are incorrect!");
            }
            else if (id != "rahul")
            {
                MessageBox.Show("ID is incorrect!");
            }
            else if (password != "28682749")
            {
                MessageBox.Show("Password is incorrect!");
            }
            else if (id =="rahul" && password != "28682749")
            {
                MessageBox.Show(" Incorrect Password!");
            }
            else if (id != "rahul" && password == "28682749")
            {
                MessageBox.Show("Invalid ID!");
            }
        }

        private void ExitLoginBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

