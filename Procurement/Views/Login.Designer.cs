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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
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
            pictureBox1 = new PictureBox();
            label7 = new Label();
            panel1.SuspendLayout();
            txtPassword.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.Location = new Point(361, -3);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 416);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // shw_pw
            // 
            shw_pw.AutoSize = true;
            shw_pw.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shw_pw.Location = new Point(32, 239);
            shw_pw.Margin = new Padding(3, 2, 3, 2);
            shw_pw.Name = "shw_pw";
            shw_pw.Size = new Size(111, 20);
            shw_pw.TabIndex = 17;
            shw_pw.Text = "Show password";
            shw_pw.UseVisualStyleBackColor = true;
            shw_pw.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 78);
            label3.Name = "label3";
            label3.Size = new Size(171, 16);
            label3.TabIndex = 16;
            label3.Text = "Use your SneakerHub account";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 53);
            label4.Name = "label4";
            label4.Size = new Size(74, 23);
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
            linkLabel1.Location = new Point(54, 375);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(246, 16);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot your password? Ask your administrator";
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.FromArgb(207, 161, 44);
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.Font = new Font("Century Gothic", 9F);
            btn_Login.ForeColor = Color.Black;
            btn_Login.Location = new Point(32, 284);
            btn_Login.Margin = new Padding(3, 2, 3, 2);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(286, 28);
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
            txtPassword.Location = new Point(32, 201);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(288, 27);
            txtPassword.TabIndex = 12;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(207, 161, 44);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 26);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(288, 1);
            panel5.TabIndex = 4;
            // 
            // login_pw
            // 
            login_pw.BorderStyle = BorderStyle.None;
            login_pw.Location = new Point(3, 5);
            login_pw.Margin = new Padding(3, 2, 3, 2);
            login_pw.Name = "login_pw";
            login_pw.Size = new Size(264, 16);
            login_pw.TabIndex = 0;
            login_pw.UseSystemPasswordChar = true;
            login_pw.TextChanged += login_pw_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 185);
            label6.Name = "label6";
            label6.Size = new Size(58, 16);
            label6.TabIndex = 11;
            label6.Text = "Password";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(login_UN);
            panel2.Location = new Point(32, 136);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 27);
            panel2.TabIndex = 10;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(207, 161, 44);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 26);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(288, 1);
            panel3.TabIndex = 4;
            // 
            // login_UN
            // 
            login_UN.BorderStyle = BorderStyle.None;
            login_UN.Location = new Point(3, 5);
            login_UN.Margin = new Padding(3, 2, 3, 2);
            login_UN.Name = "login_UN";
            login_UN.Size = new Size(264, 16);
            login_UN.TabIndex = 0;
            login_UN.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 121);
            label5.Name = "label5";
            label5.Size = new Size(61, 16);
            label5.TabIndex = 9;
            label5.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(80, 207);
            label1.Name = "label1";
            label1.Size = new Size(181, 32);
            label1.TabIndex = 0;
            label1.Text = "SNEAKERHUB";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 7.8F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(83, 239);
            label2.Name = "label2";
            label2.Size = new Size(88, 16);
            label2.TabIndex = 16;
            label2.Text = "Walk Your Style";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(32, 388);
            label7.Name = "label7";
            label7.Size = new Size(200, 15);
            label7.TabIndex = 18;
            label7.Text = "Procurement Management System";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 92, 89);
            ClientSize = new Size(714, 412);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            txtPassword.ResumeLayout(false);
            txtPassword.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Label label7;
    }
}