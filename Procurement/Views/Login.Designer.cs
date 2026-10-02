namespace ProcurementDev
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            shw_pw = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            btn_Login = new Button();
            txtPassword = new Panel();
            panel5 = new Panel();
            login_pw = new TextBox();
            label6 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            login_UN = new TextBox();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            txtPassword.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(shw_pw);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(btn_Login);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(413, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 555);
            panel1.TabIndex = 0;
            // 
            // shw_pw
            // 
            shw_pw.AutoSize = true;
            shw_pw.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shw_pw.Location = new Point(37, 319);
            shw_pw.Name = "shw_pw";
            shw_pw.Size = new Size(131, 21);
            shw_pw.TabIndex = 17;
            shw_pw.Text = "Show password";
            shw_pw.UseVisualStyleBackColor = true;
            shw_pw.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 104);
            label3.Name = "label3";
            label3.Size = new Size(199, 17);
            label3.TabIndex = 16;
            label3.Text = "Use your SneakerHub account";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 71);
            label4.Name = "label4";
            label4.Size = new Size(93, 29);
            label4.TabIndex = 15;
            label4.Text = "Sign In";
            label4.Click += label4_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = SystemColors.GrayText;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(41, 501);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(301, 17);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot your password? Ask your administrator";
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.LightSlateGray;
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.ForeColor = Color.FromArgb(224, 224, 224);
            btn_Login.Location = new Point(37, 378);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(327, 37);
            btn_Login.TabIndex = 13;
            btn_Login.Text = "LOGIN";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Loginclick_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.Controls.Add(panel5);
            txtPassword.Controls.Add(login_pw);
            txtPassword.Location = new Point(37, 268);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(329, 36);
            txtPassword.TabIndex = 12;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Maroon;
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 35);
            panel5.Name = "panel5";
            panel5.Size = new Size(329, 1);
            panel5.TabIndex = 4;
            // 
            // login_pw
            // 
            login_pw.BorderStyle = BorderStyle.None;
            login_pw.Location = new Point(3, 7);
            login_pw.Name = "login_pw";
            login_pw.Size = new Size(302, 20);
            login_pw.TabIndex = 0;
            login_pw.UseSystemPasswordChar = true;
            login_pw.TextChanged += login_pw_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(37, 247);
            label6.Name = "label6";
            label6.Size = new Size(69, 17);
            label6.TabIndex = 11;
            label6.Text = "Password";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(login_UN);
            panel2.Location = new Point(37, 182);
            panel2.Name = "panel2";
            panel2.Size = new Size(329, 36);
            panel2.TabIndex = 10;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Maroon;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(329, 1);
            panel3.TabIndex = 4;
            // 
            // login_UN
            // 
            login_UN.BorderStyle = BorderStyle.None;
            login_UN.Location = new Point(3, 7);
            login_UN.Name = "login_UN";
            login_UN.Size = new Size(302, 20);
            login_UN.TabIndex = 0;
            login_UN.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 161);
            label5.Name = "label5";
            label5.Size = new Size(71, 17);
            label5.TabIndex = 9;
            label5.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 138);
            label1.Name = "label1";
            label1.Size = new Size(223, 40);
            label1.TabIndex = 0;
            label1.Text = "SNEAKERHUB";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 178);
            label2.Name = "label2";
            label2.Size = new Size(103, 16);
            label2.TabIndex = 16;
            label2.Text = "Walk Your Style";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(816, 550);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            txtPassword.ResumeLayout(false);
            txtPassword.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private LinkLabel linkLabel1;
        private Button btn_Login;
        private Panel txtPassword;
        private Panel panel5;
        private TextBox login_pw;
        private Label label6;
        private Panel panel2;
        private Panel panel3;
        private TextBox login_UN;
        private Label label5;
        private Label label4;
        private Label label2;
        private CheckBox shw_pw;
        private Label label3;
    }
}