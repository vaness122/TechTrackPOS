namespace ByteTech.UI
{
    partial class Login
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
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox2 = new TextBox();
            UsernameText = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 21);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.OldLace;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(UsernameText);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(251, 202);
            panel2.Name = "panel2";
            panel2.Size = new Size(451, 345);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 311);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 2;
            label2.Text = "Create Account..";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(175, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 71);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 208);
            label1.Name = "label1";
            label1.Size = new Size(81, 14);
            label1.TabIndex = 4;
            label1.Text = "Password :";
          
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 226);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // UsernameText
            // 
            UsernameText.AutoSize = true;
            UsernameText.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsernameText.Location = new Point(100, 135);
            UsernameText.Name = "UsernameText";
            UsernameText.Size = new Size(83, 14);
            UsernameText.TabIndex = 3;
            UsernameText.Text = "Username :";
           
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(100, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 23);
            textBox1.TabIndex = 2;
           
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 311);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 5;
            label3.Text = "Login As..";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Login";
            Size = new Size(950, 750);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label UsernameText;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
    }
}
