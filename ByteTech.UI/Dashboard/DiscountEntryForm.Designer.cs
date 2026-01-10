namespace ByteTech.UI.Dashboard
{
    partial class DiscountEntryForm
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
            txtCode = new TextBox();
            label1 = new Label();
            dtpStart = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            dtpEnd = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            txtDescription = new TextBox();
            label2 = new Label();
            cmbType = new ComboBox();
            label5 = new Label();
            numValue = new NumericUpDown();
            label6 = new Label();
            chkIsActive = new CheckBox();
            label = new Label();
            ((System.ComponentModel.ISupportInitialize)numValue).BeginInit();
            SuspendLayout();
            // 
            // txtCode
            // 
            txtCode.AccessibleRole = AccessibleRole.None;
            txtCode.Location = new Point(107, 19);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(100, 23);
            txtCode.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 22);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Code :";
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(108, 167);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(200, 23);
            dtpStart.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 173);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 5;
            label3.Text = "Start Date :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 213);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 7;
            label4.Text = "End Date :";
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(107, 207);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(200, 23);
            dtpEnd.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(26, 281);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(132, 281);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(107, 59);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 67);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 11;
            label2.Text = "Description :";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(107, 100);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(121, 23);
            cmbType.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 108);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 13;
            label5.Text = "Discount Type :";
            // 
            // numValue
            // 
            numValue.Location = new Point(108, 129);
            numValue.Name = "numValue";
            numValue.Size = new Size(120, 23);
            numValue.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 137);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 15;
            label6.Text = "Value :";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(108, 247);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(59, 19);
            chkIsActive.TabIndex = 16;
            chkIsActive.Text = "Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(20, 251);
            label.Name = "label";
            label.Size = new Size(57, 15);
            label.TabIndex = 17;
            label.Text = "Is Active :";
            // 
            // DiscountEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 372);
            Controls.Add(label);
            Controls.Add(chkIsActive);
            Controls.Add(label6);
            Controls.Add(numValue);
            Controls.Add(label5);
            Controls.Add(cmbType);
            Controls.Add(label2);
            Controls.Add(txtDescription);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(dtpEnd);
            Controls.Add(label3);
            Controls.Add(dtpStart);
            Controls.Add(label1);
            Controls.Add(txtCode);
            Name = "DiscountEntryForm";
            ((System.ComponentModel.ISupportInitialize)numValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCode;
        private Label label1;
        private DateTimePicker dtpStart;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpEnd;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtDescription;
        private Label label2;
        private ComboBox cmbType;
        private Label label5;
        private NumericUpDown numValue;
        private Label label6;
        private CheckBox chkIsActive;
        private Label label;
    }
}