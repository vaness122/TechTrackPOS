namespace ByteTech.UI.Dashboard
{
    partial class CustomerForms
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
            groupBox2 = new GroupBox();
            dgvCustomers = new DataGridView();
            btnRefresh = new Button();
            txtSearch = new TextBox();
            label12 = new Label();
            panel5 = new Panel();
            btnAdd = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            panel2 = new Panel();
            label11 = new Label();
            groupBox1 = new GroupBox();
            chkIsInactive = new CheckBox();
            label13 = new Label();
            txtAvailableCredit = new TextBox();
            panel4 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            btnBrowse = new Button();
            panel1 = new Panel();
            btnSave = new Button();
            btnNew = new Button();
            pbPicture = new PictureBox();
            numBalance = new NumericUpDown();
            numCreditLimit = new NumericUpDown();
            cmbPriceLevel = new ComboBox();
            txtRemarks = new TextBox();
            txtAddress = new TextBox();
            txtBusinessStyle = new TextBox();
            txtTIN = new TextBox();
            txtName = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBalance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCreditLimit).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvCustomers);
            groupBox2.Controls.Add(btnRefresh);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(panel5);
            groupBox2.Controls.Add(panel2);
            groupBox2.Location = new Point(378, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(489, 603);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(6, 119);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(477, 288);
            dgvCustomers.TabIndex = 26;
        
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(294, 63);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 25;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(60, 63);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(212, 23);
            txtSearch.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 66);
            label12.Name = "label12";
            label12.Size = new Size(48, 15);
            label12.TabIndex = 23;
            label12.Text = "Search :";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnAdd);
            panel5.Controls.Add(btnDelete);
            panel5.Controls.Add(btnEdit);
            panel5.Location = new Point(6, 540);
            panel5.Name = "panel5";
            panel5.Size = new Size(477, 57);
            panel5.TabIndex = 22;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(197, 25);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(386, 25);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(294, 25);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label11);
            panel2.Location = new Point(6, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(477, 32);
            panel2.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 9);
            label11.Name = "label11";
            label11.Size = new Size(85, 15);
            label11.TabIndex = 1;
            label11.Text = "Customers List";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkIsInactive);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtAvailableCredit);
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(btnBrowse);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(pbPicture);
            groupBox1.Controls.Add(numBalance);
            groupBox1.Controls.Add(numCreditLimit);
            groupBox1.Controls.Add(cmbPriceLevel);
            groupBox1.Controls.Add(txtRemarks);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtBusinessStyle);
            groupBox1.Controls.Add(txtTIN);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(8, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 603);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // chkIsInactive
            // 
            chkIsInactive.AutoSize = true;
            chkIsInactive.Location = new Point(192, 426);
            chkIsInactive.Name = "chkIsInactive";
            chkIsInactive.Size = new Size(78, 19);
            chkIsInactive.TabIndex = 24;
            chkIsInactive.Text = "Is Inactive";
            chkIsInactive.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(132, 426);
            label13.Name = "label13";
            label13.Size = new Size(54, 15);
            label13.TabIndex = 23;
            label13.Text = "IsActive :";
            // 
            // txtAvailableCredit
            // 
            txtAvailableCredit.BackColor = SystemColors.Window;
            txtAvailableCredit.Location = new Point(115, 343);
            txtAvailableCredit.Name = "txtAvailableCredit";
            txtAvailableCredit.ReadOnly = true;
            txtAvailableCredit.Size = new Size(187, 23);
            txtAvailableCredit.TabIndex = 22;
            // 
            // panel4
            // 
            panel4.Controls.Add(label1);
            panel4.Location = new Point(6, 19);
            panel4.Name = "panel4";
            panel4.Size = new Size(352, 32);
            panel4.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Customer Entry";
            // 
            // panel3
            // 
            panel3.Location = new Point(364, 119);
            panel3.Name = "panel3";
            panel3.Size = new Size(529, 41);
            panel3.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(35, 511);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 20;
            btnBrowse.Text = "Picture Box";
            btnBrowse.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnNew);
            panel1.Location = new Point(6, 540);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 57);
            panel1.TabIndex = 21;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(271, 25);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(172, 25);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 0;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // pbPicture
            // 
            pbPicture.Location = new Point(15, 426);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(111, 79);
            pbPicture.SizeMode = PictureBoxSizeMode.Zoom;
            pbPicture.TabIndex = 19;
            pbPicture.TabStop = false;
            // 
            // numBalance
            // 
            numBalance.DecimalPlaces = 2;
            numBalance.Location = new Point(115, 305);
            numBalance.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numBalance.Name = "numBalance";
            numBalance.Size = new Size(187, 23);
            numBalance.TabIndex = 17;
            // 
            // numCreditLimit
            // 
            numCreditLimit.DecimalPlaces = 2;
            numCreditLimit.Location = new Point(115, 261);
            numCreditLimit.Maximum = new decimal(new int[] { 1316134911, 2328, 0, 0 });
            numCreditLimit.Name = "numCreditLimit";
            numCreditLimit.Size = new Size(187, 23);
            numCreditLimit.TabIndex = 16;
            // 
            // cmbPriceLevel
            // 
            cmbPriceLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriceLevel.FormattingEnabled = true;
            cmbPriceLevel.Location = new Point(115, 220);
            cmbPriceLevel.Name = "cmbPriceLevel";
            cmbPriceLevel.Size = new Size(187, 23);
            cmbPriceLevel.TabIndex = 15;
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(115, 384);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(187, 23);
            txtRemarks.TabIndex = 14;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(115, 181);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(187, 23);
            txtAddress.TabIndex = 13;
            // 
            // txtBusinessStyle
            // 
            txtBusinessStyle.Location = new Point(115, 137);
            txtBusinessStyle.Multiline = true;
            txtBusinessStyle.Name = "txtBusinessStyle";
            txtBusinessStyle.Size = new Size(187, 23);
            txtBusinessStyle.TabIndex = 12;
            // 
            // txtTIN
            // 
            txtTIN.Location = new Point(115, 93);
            txtTIN.Multiline = true;
            txtTIN.Name = "txtTIN";
            txtTIN.Size = new Size(187, 23);
            txtTIN.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Location = new Point(115, 58);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(187, 23);
            txtName.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 351);
            label10.Name = "label10";
            label10.Size = new Size(96, 15);
            label10.TabIndex = 9;
            label10.Text = "Available Credit :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 392);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 8;
            label9.Text = "Remarks :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 313);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 7;
            label8.Text = "Balance :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 269);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 6;
            label7.Text = "Credit Limit :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 228);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 5;
            label6.Text = "Price Level :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 189);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 4;
            label5.Text = "Address :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 145);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 3;
            label4.Text = "Business Style :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 101);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "TI N :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 66);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Name :";
            // 
            // CustomerForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 696);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "CustomerForms";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBalance).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCreditLimit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dgvCustomers;
        private Button btnRefresh;
        private TextBox txtSearch;
        private Label label12;
        private Panel panel5;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnEdit;
        private Panel panel2;
        private Label label11;
        private GroupBox groupBox1;
        private CheckBox chkIsInactive;
        private Label label13;
        private TextBox txtAvailableCredit;
        private Panel panel4;
        private Label label1;
        private Panel panel3;
        private Button btnBrowse;
        private Panel panel1;
        private Button btnSave;
        private Button btnNew;
        private PictureBox pbPicture;
        private NumericUpDown numBalance;
        private NumericUpDown numCreditLimit;
        private ComboBox cmbPriceLevel;
        private TextBox txtRemarks;
        private TextBox txtAddress;
        private TextBox txtBusinessStyle;
        private TextBox txtTIN;
        private TextBox txtName;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}