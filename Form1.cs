using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Data.SqlClient;

namespace ATM_Banking
{
    public partial class Form1 : Form
    {
         SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HI0EHL6C\SQLEXPRESS;Initial Catalog=loan_info;Integrated Security=True;Encrypt=False");
        string marriage;
        const double USD_RATE = 1.0;
        const double EUR_RATE = 0.86;
        const double GBP_RATE = 0.74;
        const double JPY_RATE = 109.88;
        const double CAD_RATE = 1.27;
        const double INR_RATE = 75.0;
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
            tabControl1.Enabled = false;
            radioButton1.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            loanStatusBtn.Enabled = false;
        }
        private void InitializeComboBox()
        {
            comboBox1.Items.Add("Savings");
            comboBox1.Items.Add("Checking");
            comboBox1.Items.Add("Investment");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                tabControl1.SelectedTab = tabPage5;
            }
        }

        

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                tabControl1.SelectedTab = tabPage3;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                tabControl1.SelectedTab = tabPage2;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                tabControl1.SelectedTab = tabPage1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text += "0";
        }


        private void button15_Click(object sender, EventArgs e)
        {
            string entered_pin = textBox2.Text;
            bool pinMatchFound = false;
            foreach (var item in listBox1.Items)
            {
                if (entered_pin == item.ToString())
                {
                    pinMatchFound = true;
                    break;
                }
            }
            if (pinMatchFound)
            {
                MessageBox.Show("Access Granted");
                // Enable the radio button
                tabControl1.Enabled = true;
                radioButton1.Enabled = true;
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
                radioButton5.Enabled = true;
                loanStatusBtn.Enabled = true;

            }
            else
            {
                textBox2.Text = "";
                // Disable the radio button
                radioButton1.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;
                loanStatusBtn.Enabled=false;

                // Display message box
                MessageBox.Show("Please enter the correct PIN.", "Incorrect PIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                // Remove the last character
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                tabControl1.SelectedTab = tabPage3;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            tabControl1.SelectedTab = tabPage3;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(textBox1.Text);
            string baseCurrency = comboBox3.SelectedItem.ToString();

            // Convert to USD first
            double usdAmount = ConvertToUSD(amount, baseCurrency);

            // Convert to other currencies
            txtUSD.Text = usdAmount.ToString("N2");
            txtEUR.Text = (usdAmount * EUR_RATE).ToString("N2");
            txtGBP.Text = (usdAmount * GBP_RATE).ToString("N2");
            txtJPY.Text = (usdAmount * JPY_RATE).ToString("N2");
            txtCAD.Text = (usdAmount * CAD_RATE).ToString("N2");
            txtINR.Text = (usdAmount * INR_RATE).ToString("N2");
        }
        private double ConvertToUSD(double amount, string baseCurrency)
        {
            double usdAmount = 0;

            switch (baseCurrency)
            {
                case "USD":
                    usdAmount = amount;
                    break;
                case "EUR":
                    usdAmount = amount / EUR_RATE;
                    break;
                case "GBP":
                    usdAmount = amount / GBP_RATE;
                    break;
                case "JPY":
                    usdAmount = amount / JPY_RATE;
                    break;
                case "CAD":
                    usdAmount = amount / CAD_RATE;
                    break;
                case "INR":
                    usdAmount = amount / INR_RATE;
                    break;
                default:
                    break;
            }

            return usdAmount;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";

        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";

        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";

        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";

        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";

        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";

        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";

        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";

        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";

        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";

        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            txtUSD.Text = "";
            txtEUR.Text = "";
            txtGBP.Text = "";
            txtJPY.Text = "";
            txtCAD.Text = "";
            txtINR.Text = "";

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RAHUL GAUTAM PAWAR\nENROLLMENT NO: SM22IF016");
        }
        private Dictionary<string, Dictionary<string, double>> accounts = new Dictionary<string, Dictionary<string, double>>()
        {
            {"Rahul Pawar", new Dictionary<string, double>() { {"Savings", 2000.00}, {"Checking", 5000.00}, {"Investment", 10000.00} }},
            {"Akshat Sharma", new Dictionary<string, double>() { {"Savings", 3000.00}, {"Checking", 6000.00}, {"Investment", 12000.00} }},
            {"Sarthak Puralkar", new Dictionary<string, double>() { {"Savings", 4000.00}, {"Checking", 7000.00}, {"Investment", 15000.00} }}
        };

        private void button36_Click(object sender, EventArgs e)
        {
            string accountName = textBox4.Text;
            if (!accounts.ContainsKey(accountName))
            {
                MessageBox.Show("Account not found.");
                return;
            }

            string accountType = comboBox1.SelectedItem as string;
            if (accountType == null)
            {
                MessageBox.Show("Please select an account type.");
                return;
            }

            double currentBalance = accounts[accountName][accountType];

            if (string.IsNullOrWhiteSpace(textBox14.Text))
            {
                MessageBox.Show("Please provide withdrawal amount.");
                return;
            }

            double withdrawalAmount;
            if (!double.TryParse(textBox14.Text, out withdrawalAmount))
            {
                MessageBox.Show("Invalid withdrawal amount.");
                return;
            }

            if (withdrawalAmount > currentBalance)
            {
                MessageBox.Show("Insufficient balance.");
                return;
            }

            accounts[accountName][accountType] -= withdrawalAmount;
            tabControl1.SelectedTab = tabPage2;

            textBox3.AppendText($"Withdrawal of {withdrawalAmount:C} from {accountType} account of {accountName}.\n New balance: {accounts[accountName][accountType]:C}" + Environment.NewLine);

        }

        private void button17_Click(object sender, EventArgs e)
        {
            string accountName = textBox4.Text;
            if (!accounts.ContainsKey(accountName))
            {
                MessageBox.Show("Account not found.");
                return;
            }
            string accountType = comboBox1.SelectedItem as string;
            if (accountType == null)
            {
                MessageBox.Show("Please select an account type.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox15.Text))
            {
                MessageBox.Show("Please provide deposit amount.");
                return;
            }
            double depositAmount;
            if (!double.TryParse(textBox15.Text, out depositAmount))
            {
                MessageBox.Show("Invalid deposit amount.");
                return;
            }
            accounts[accountName][accountType] += depositAmount;
            tabControl1.SelectedTab = tabPage2;
            textBox3.AppendText("\n"+$"\nDeposit of {depositAmount:C} " +
                $"into {accountType} account of {accountName}.\n" +
                $" New balance: {accounts[accountName][accountType]:C}" 
                + Environment.NewLine+"\n");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            
            Admin_login adv =new Admin_login();
            
                adv.Show();
            

        }

        private void loansub_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;

            if (marrButton2.Checked == true)
            {
                marriage = "Married";
            }
            else if(unmarrButton2.Checked == true)
            {
                marriage = "Unmarried";
            }
            else if(marrothButton2.Checked == true)
            {
                marriage = "Other";
            }


            con.Open();
            string q = "insert into loan_info_details(acc_number,loan_amt,purpose,id_proof,marr_status,phn_num,email_no)values("+acc_nm.Text+","+ln_am.Text+",'"+comboBox_pur.SelectedItem+"','"+comboBoxid.SelectedItem+"','"+marriage+"',"+ph_number.Text+",'"+email.Text+"')";
            SqlCommand cmd = new SqlCommand(q,con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Loan Requested");
            SqlCommand disp=new SqlCommand("select acc_number,phn_num,email_no,Status from loan_info_details",con);
            SqlDataAdapter sqlDataAdapter=new SqlDataAdapter(disp);
            DataTable dt=new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Approval of Loan usually takes 1-2 weeks\nIncase of a large amount it takes less than a Month");
        }

        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            FeedBackPage fdp = new FeedBackPage();
            fdp.Show();
            this.Hide();
        }

        private void btShowData_Click(object sender, EventArgs e)
        {
            con.Open();
            string Query = "SELECT * FROM loan_info_details";
            SqlCommand cmd= new SqlCommand(Query,con);
            var reader =cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource= dt;
            con.Close();

        }

        private void loanStatusBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(loanStatusBtn.Checked)
            {
                tabControl1.SelectedTab = tabPage4;
            }
        }
    }
}
