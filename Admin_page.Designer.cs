namespace ATM_Banking
{
    partial class Admin_page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.loanRequests = new System.Windows.Forms.Button();
            this.feedBack = new System.Windows.Forms.Button();
            this.LoanPanel = new System.Windows.Forms.Panel();
            this.loanSts = new System.Windows.Forms.ComboBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.whereToChange = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.feedBackPanel = new System.Windows.Forms.Panel();
            this.feedBackDetails = new System.Windows.Forms.DataGridView();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.form1Return = new System.Windows.Forms.Button();
            this.loan_infoDataSet = new ATM_Banking.loan_infoDataSet();
            this.loaninfodetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loan_info_detailsTableAdapter = new ATM_Banking.loan_infoDataSetTableAdapters.loan_info_detailsTableAdapter();
            this.LoanPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.feedBackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedBackDetails)).BeginInit();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loan_infoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaninfodetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // loanRequests
            // 
            this.loanRequests.BackColor = System.Drawing.Color.Yellow;
            this.loanRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanRequests.Location = new System.Drawing.Point(0, 164);
            this.loanRequests.Name = "loanRequests";
            this.loanRequests.Size = new System.Drawing.Size(128, 41);
            this.loanRequests.TabIndex = 0;
            this.loanRequests.Text = "Loan Requests";
            this.loanRequests.UseVisualStyleBackColor = false;
            this.loanRequests.Click += new System.EventHandler(this.loanRequests_Click);
            // 
            // feedBack
            // 
            this.feedBack.BackColor = System.Drawing.Color.Yellow;
            this.feedBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedBack.Location = new System.Drawing.Point(0, 223);
            this.feedBack.Name = "feedBack";
            this.feedBack.Size = new System.Drawing.Size(128, 47);
            this.feedBack.TabIndex = 1;
            this.feedBack.Text = "Feed Back\r\nResponse";
            this.feedBack.UseVisualStyleBackColor = false;
            this.feedBack.Click += new System.EventHandler(this.feedBack_Click);
            // 
            // LoanPanel
            // 
            this.LoanPanel.BackColor = System.Drawing.Color.Salmon;
            this.LoanPanel.Controls.Add(this.loanSts);
            this.LoanPanel.Controls.Add(this.updateBtn);
            this.LoanPanel.Controls.Add(this.label2);
            this.LoanPanel.Controls.Add(this.label1);
            this.LoanPanel.Controls.Add(this.whereToChange);
            this.LoanPanel.Controls.Add(this.dataGridView1);
            this.LoanPanel.Location = new System.Drawing.Point(146, 9);
            this.LoanPanel.Name = "LoanPanel";
            this.LoanPanel.Size = new System.Drawing.Size(648, 437);
            this.LoanPanel.TabIndex = 1;
            // 
            // loanSts
            // 
            this.loanSts.BackColor = System.Drawing.Color.DarkGray;
            this.loanSts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanSts.FormattingEnabled = true;
            this.loanSts.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Denied"});
            this.loanSts.Location = new System.Drawing.Point(222, 304);
            this.loanSts.Name = "loanSts";
            this.loanSts.Size = new System.Drawing.Size(187, 37);
            this.loanSts.TabIndex = 6;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Cyan;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(243, 365);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(144, 49);
            this.updateBtn.TabIndex = 5;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Request Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Account No.";
            // 
            // whereToChange
            // 
            this.whereToChange.BackColor = System.Drawing.Color.DarkGray;
            this.whereToChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whereToChange.Location = new System.Drawing.Point(222, 263);
            this.whereToChange.Name = "whereToChange";
            this.whereToChange.Size = new System.Drawing.Size(221, 26);
            this.whereToChange.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 232);
            this.dataGridView1.TabIndex = 0;
            // 
            // feedBackPanel
            // 
            this.feedBackPanel.BackColor = System.Drawing.Color.Orange;
            this.feedBackPanel.Controls.Add(this.feedBackDetails);
            this.feedBackPanel.Location = new System.Drawing.Point(148, 4);
            this.feedBackPanel.Name = "feedBackPanel";
            this.feedBackPanel.Size = new System.Drawing.Size(649, 445);
            this.feedBackPanel.TabIndex = 2;
            // 
            // feedBackDetails
            // 
            this.feedBackDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feedBackDetails.Location = new System.Drawing.Point(44, 33);
            this.feedBackDetails.Name = "feedBackDetails";
            this.feedBackDetails.Size = new System.Drawing.Size(564, 382);
            this.feedBackDetails.TabIndex = 0;
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.Green;
            this.buttonPanel.Controls.Add(this.logoutBtn);
            this.buttonPanel.Controls.Add(this.form1Return);
            this.buttonPanel.Controls.Add(this.feedBack);
            this.buttonPanel.Controls.Add(this.loanRequests);
            this.buttonPanel.Location = new System.Drawing.Point(2, 1);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(140, 448);
            this.buttonPanel.TabIndex = 3;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(20, 338);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(90, 34);
            this.logoutBtn.TabIndex = 4;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // form1Return
            // 
            this.form1Return.BackColor = System.Drawing.Color.Yellow;
            this.form1Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form1Return.Location = new System.Drawing.Point(10, 290);
            this.form1Return.Name = "form1Return";
            this.form1Return.Size = new System.Drawing.Size(117, 32);
            this.form1Return.TabIndex = 3;
            this.form1Return.Text = "Loan Details";
            this.form1Return.UseVisualStyleBackColor = false;
            this.form1Return.Click += new System.EventHandler(this.form1Return_Click);
            // 
            // loan_infoDataSet
            // 
            this.loan_infoDataSet.DataSetName = "loan_infoDataSet";
            this.loan_infoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaninfodetailsBindingSource
            // 
            this.loaninfodetailsBindingSource.DataMember = "loan_info_details";
            this.loaninfodetailsBindingSource.DataSource = this.loan_infoDataSet;
            // 
            // loan_info_detailsTableAdapter
            // 
            this.loan_info_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // Admin_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoanPanel);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.feedBackPanel);
            this.Name = "Admin_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_page";
            this.Load += new System.EventHandler(this.Admin_page_Load);
            this.LoanPanel.ResumeLayout(false);
            this.LoanPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.feedBackPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.feedBackDetails)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loan_infoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaninfodetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button feedBack;
        private System.Windows.Forms.Button loanRequests;
        private System.Windows.Forms.Panel LoanPanel;
        private System.Windows.Forms.Panel feedBackPanel;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private loan_infoDataSet loan_infoDataSet;
        private System.Windows.Forms.BindingSource loaninfodetailsBindingSource;
        private loan_infoDataSetTableAdapters.loan_info_detailsTableAdapter loan_info_detailsTableAdapter;
        private System.Windows.Forms.Button form1Return;
        private System.Windows.Forms.TextBox whereToChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.ComboBox loanSts;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.DataGridView feedBackDetails;
    }
}