namespace ProcurementDev.Views.Admin
{
    partial class FinanceSidebar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinanceSidebar));
            btnReports = new Button();
            btnPayment = new Button();
            btnInvoice = new Button();
            btnDashboard = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.FromArgb(70, 92, 89);
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Century Gothic", 9F);
            btnReports.ForeColor = Color.White;
            btnReports.Image = (Image)resources.GetObject("btnReports.Image");
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(16, 235);
            btnReports.Margin = new Padding(3, 2, 3, 2);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(200, 36);
            btnReports.TabIndex = 35;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReturns_Click;
            // 
            // btnPayment
            // 
            btnPayment.BackColor = Color.FromArgb(70, 92, 89);
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Century Gothic", 9F);
            btnPayment.ForeColor = Color.White;
            btnPayment.Image = (Image)resources.GetObject("btnPayment.Image");
            btnPayment.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayment.Location = new Point(16, 190);
            btnPayment.Margin = new Padding(3, 2, 3, 2);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(200, 36);
            btnPayment.TabIndex = 34;
            btnPayment.Text = "Payment";
            btnPayment.UseVisualStyleBackColor = false;
            btnPayment.Click += btnPurchReq_Click;
            // 
            // btnInvoice
            // 
            btnInvoice.BackColor = Color.FromArgb(70, 92, 89);
            btnInvoice.FlatAppearance.BorderSize = 0;
            btnInvoice.FlatStyle = FlatStyle.Flat;
            btnInvoice.ForeColor = Color.White;
            btnInvoice.Image = (Image)resources.GetObject("btnInvoice.Image");
            btnInvoice.ImageAlign = ContentAlignment.MiddleLeft;
            btnInvoice.Location = new Point(16, 145);
            btnInvoice.Margin = new Padding(3, 2, 3, 2);
            btnInvoice.Name = "btnInvoice";
            btnInvoice.Size = new Size(200, 36);
            btnInvoice.TabIndex = 33;
            btnInvoice.Text = "Invoice";
            btnInvoice.UseVisualStyleBackColor = false;
            btnInvoice.Click += btnSupplier_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(70, 92, 89);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Century Gothic", 9F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(16, 100);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(200, 36);
            btnDashboard.TabIndex = 32;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(70, 92, 89);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 700);
            panel1.TabIndex = 37;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(53, 70, 66);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 586);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 115);
            panel2.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 8F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(72, 40);
            label5.Name = "label5";
            label5.Size = new Size(50, 16);
            label5.TabIndex = 15;
            label5.Text = "Finance";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(72, 21);
            label4.Name = "label4";
            label4.Size = new Size(94, 17);
            label4.TabIndex = 14;
            label4.Text = "Finance Staff";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(21, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 8F);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(18, 72);
            button1.Name = "button1";
            button1.Size = new Size(196, 32);
            button1.TabIndex = 0;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 8.25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(83, 59);
            label3.Name = "label3";
            label3.Size = new Size(88, 16);
            label3.TabIndex = 13;
            label3.Text = "Walk Your Style";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(80, 37);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 13;
            label1.Text = "SNEAKERHUB";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // FinanceSidebar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnReports);
            Controls.Add(btnPayment);
            Controls.Add(btnInvoice);
            Controls.Add(btnDashboard);
            Controls.Add(panel1);
            Name = "FinanceSidebar";
            Size = new Size(972, 700);
            Load += FinanceSidebar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnReports;
        private Button btnPayment;
        private Button btnInvoice;
        private Button btnDashboard;
        private Panel panel1;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox2;
        private Button button1;
    }
}
