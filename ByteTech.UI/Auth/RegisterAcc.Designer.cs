namespace ByteTech.UI.Auth
{
    partial class RegisterAcc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RegisterBtn = new Button();
            label4 = new Label();
            UserTypeRegTxt = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            PasswordRegTxt = new TextBox();
            UsernameRegTxt = new TextBox();
            panel1 = new Panel();
            EmailRegTxt = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // RegisterBtn
            // 
            RegisterBtn.Location = new Point(542, 414);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(57, 23);
            RegisterBtn.TabIndex = 16;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(470, 343);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 15;
            label4.Text = "User Type";
            // 
            // UserTypeRegTxt
            // 
            UserTypeRegTxt.FormattingEnabled = true;
            UserTypeRegTxt.Location = new Point(470, 361);
            UserTypeRegTxt.Name = "UserTypeRegTxt";
            UserTypeRegTxt.Size = new Size(198, 23);
            UserTypeRegTxt.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(503, 95);
            label3.Name = "label3";
            label3.Size = new Size(165, 32);
            label3.TabIndex = 13;
            label3.Text = "User Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(470, 227);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 12;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(470, 173);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 11;
            label1.Text = "UserName";
            // 
            // PasswordRegTxt
            // 
            PasswordRegTxt.Location = new Point(470, 245);
            PasswordRegTxt.Name = "PasswordRegTxt";
            PasswordRegTxt.Size = new Size(198, 23);
            PasswordRegTxt.TabIndex = 10;
            // 
            // UsernameRegTxt
            // 
            UsernameRegTxt.Location = new Point(470, 191);
            UsernameRegTxt.Name = "UsernameRegTxt";
            UsernameRegTxt.Size = new Size(198, 23);
            UsernameRegTxt.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 586);
            panel1.TabIndex = 9;
            // 
            // EmailRegTxt
            // 
            EmailRegTxt.Location = new Point(470, 305);
            EmailRegTxt.Name = "EmailRegTxt";
            EmailRegTxt.Size = new Size(198, 23);
            EmailRegTxt.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(470, 287);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 18;
            label5.Text = "Email";
            // 
            // RegisterAcc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EmailRegTxt);
            Controls.Add(RegisterBtn);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(UserTypeRegTxt);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(PasswordRegTxt);
            Controls.Add(UsernameRegTxt);
            Controls.Add(label2);
            Name = "RegisterAcc";
            Size = new Size(759, 548);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegisterBtn;
        private Label label4;
        private ComboBox UserTypeRegTxt;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox PasswordRegTxt;
        private TextBox UsernameRegTxt;
        private Panel panel1;
        private TextBox EmailRegTxt;
        private Label label5;
    }
}
