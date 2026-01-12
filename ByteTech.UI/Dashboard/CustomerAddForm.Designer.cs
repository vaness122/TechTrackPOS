namespace ByteTech.UI.Dashboard
{
    partial class CustomerAddForm
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
            groupBox1 = new GroupBox();
            btnSaves = new Button();
            btnCancel = new Button();
            chkIsInactive = new CheckBox();
            label13 = new Label();
            txtAvailableCredit = new TextBox();
            btnBrowse = new Button();
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBalance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCreditLimit).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSaves);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(chkIsInactive);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtAvailableCredit);
            groupBox1.Controls.Add(btnBrowse);
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
            groupBox1.Location = new Point(144, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 636);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // btnSaves
            // 
            btnSaves.Location = new Point(51, 581);
            btnSaves.Name = "btnSaves";
            btnSaves.Size = new Size(75, 23);
            btnSaves.TabIndex = 0;
            btnSaves.Text = "Save";
            btnSaves.UseVisualStyleBackColor = true;
            btnSaves.Click += btnSaves_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(195, 581);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // chkIsInactive
            // 
            chkIsInactive.AutoSize = true;
            chkIsInactive.Location = new Point(183, 513);
            chkIsInactive.Name = "chkIsInactive";
            chkIsInactive.Size = new Size(78, 19);
            chkIsInactive.TabIndex = 24;
            chkIsInactive.Text = "Is Inactive";
            chkIsInactive.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(123, 513);
            label13.Name = "label13";
            label13.Size = new Size(54, 15);
            label13.TabIndex = 23;
            label13.Text = "IsActive :";
            // 
            // txtAvailableCredit
            // 
            txtAvailableCredit.BackColor = SystemColors.Window;
            txtAvailableCredit.Location = new Point(106, 430);
            txtAvailableCredit.Name = "txtAvailableCredit";
            txtAvailableCredit.ReadOnly = true;
            txtAvailableCredit.Size = new Size(187, 23);
            txtAvailableCredit.TabIndex = 22;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(25, 98);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 20;
            btnBrowse.Text = "Picture Box";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click_1;
            // 
            // pbPicture
            // 
            pbPicture.Location = new Point(15, 13);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(111, 79);
            pbPicture.SizeMode = PictureBoxSizeMode.Zoom;
            pbPicture.TabIndex = 19;
            pbPicture.TabStop = false;
            // 
            // numBalance
            // 
            numBalance.DecimalPlaces = 2;
            numBalance.Location = new Point(106, 392);
            numBalance.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numBalance.Name = "numBalance";
            numBalance.Size = new Size(187, 23);
            numBalance.TabIndex = 17;
            // 
            // numCreditLimit
            // 
            numCreditLimit.DecimalPlaces = 2;
            numCreditLimit.Location = new Point(106, 348);
            numCreditLimit.Maximum = new decimal(new int[] { 1316134911, 2328, 0, 0 });
            numCreditLimit.Name = "numCreditLimit";
            numCreditLimit.Size = new Size(187, 23);
            numCreditLimit.TabIndex = 16;
            // 
            // cmbPriceLevel
            // 
            cmbPriceLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriceLevel.FormattingEnabled = true;
            cmbPriceLevel.Location = new Point(106, 307);
            cmbPriceLevel.Name = "cmbPriceLevel";
            cmbPriceLevel.Size = new Size(187, 23);
            cmbPriceLevel.TabIndex = 15;
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(106, 471);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(187, 23);
            txtRemarks.TabIndex = 14;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(106, 268);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(187, 23);
            txtAddress.TabIndex = 13;
            // 
            // txtBusinessStyle
            // 
            txtBusinessStyle.Location = new Point(106, 224);
            txtBusinessStyle.Multiline = true;
            txtBusinessStyle.Name = "txtBusinessStyle";
            txtBusinessStyle.Size = new Size(187, 23);
            txtBusinessStyle.TabIndex = 12;
            // 
            // txtTIN
            // 
            txtTIN.Location = new Point(106, 180);
            txtTIN.Multiline = true;
            txtTIN.Name = "txtTIN";
            txtTIN.Size = new Size(187, 23);
            txtTIN.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Location = new Point(106, 145);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(187, 23);
            txtName.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(4, 438);
            label10.Name = "label10";
            label10.Size = new Size(96, 15);
            label10.TabIndex = 9;
            label10.Text = "Available Credit :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 479);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 8;
            label9.Text = "Remarks :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 400);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 7;
            label8.Text = "Balance :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 356);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 6;
            label7.Text = "Credit Limit :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 315);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 5;
            label6.Text = "Price Level :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 276);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 4;
            label5.Text = "Address :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 232);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 3;
            label4.Text = "Business Style :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 188);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "TI N :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 153);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Name :";
            // 
            // CustomerAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 686);
            Controls.Add(groupBox1);
            Name = "CustomerAddForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBalance).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCreditLimit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSaves;
        private Button btnCancel;
        private CheckBox chkIsInactive;
        private Label label13;
        private TextBox txtAvailableCredit;
        private Button btnBrowse;
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