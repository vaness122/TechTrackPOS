namespace ByteTech.UI.Auth
{
    partial class LoginAcc
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
            panel1 = new Panel();
            UsernameLgnTxt = new TextBox();
            PasswordLgnTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            UserTypeLgnTxt = new ComboBox();
            label4 = new Label();
            LoginBtn = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Location = new Point(391, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 586);
            panel1.TabIndex = 0;
            // 
            // UsernameLgnTxt
            // 
            UsernameLgnTxt.Location = new Point(85, 230);
            UsernameLgnTxt.Name = "UsernameLgnTxt";
            UsernameLgnTxt.Size = new Size(198, 23);
            UsernameLgnTxt.TabIndex = 0;
            // 
            // PasswordLgnTxt
            // 
            PasswordLgnTxt.Location = new Point(85, 284);
            PasswordLgnTxt.Name = "PasswordLgnTxt";
            PasswordLgnTxt.Size = new Size(198, 23);
            PasswordLgnTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 212);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 2;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 266);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(121, 154);
            label3.Name = "label3";
            label3.Size = new Size(136, 32);
            label3.TabIndex = 4;
            label3.Text = "User Login";
            // 
            // UserTypeLgnTxt
            // 
            UserTypeLgnTxt.FormattingEnabled = true;
            UserTypeLgnTxt.Location = new Point(85, 340);
            UserTypeLgnTxt.Name = "UserTypeLgnTxt";
            UserTypeLgnTxt.Size = new Size(198, 23);
            UserTypeLgnTxt.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 322);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 6;
            label4.Text = "User Type";
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(141, 387);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(57, 23);
            LoginBtn.TabIndex = 7;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            // 
            // LoginAcc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LoginBtn);
            Controls.Add(label4);
            Controls.Add(UserTypeLgnTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordLgnTxt);
            Controls.Add(UsernameLgnTxt);
            Controls.Add(panel1);
            Name = "LoginAcc";
            Size = new Size(792, 586);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox UsernameLgnTxt;
        private TextBox PasswordLgnTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox UserTypeLgnTxt;
        private Label label4;
        private Button LoginBtn;
    }
}
