using System;
using System.Windows.Forms;

namespace ProcurementDev.Views.Admin
{
    partial class A_Dashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> x`
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_Dashboard));
            label1 = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            panel4 = new Panel();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            process1 = new System.Diagnostics.Process();
            label10 = new Label();
            dataGridView1 = new DataGridView();
            label11 = new Label();
            dataGridView2 = new DataGridView();
            panel6 = new Panel();
            panel7 = new Panel();
            label12 = new Label();
            button3 = new Button();
            panel8 = new Panel();
            panel5 = new Panel();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 19);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 8F);
            label2.Location = new Point(20, 46);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(234, 16);
            label2.TabIndex = 1;
            label2.Text = "Purchasing inventory and supplier activity";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Location = new Point(20, 80);
            flowLayoutPanel1.Margin = new Padding(4, 2, 4, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(174, 90);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 8F);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(13, 8);
            label3.Margin = new Padding(13, 8, 0, 0);
            label3.Name = "label3";
            label3.Size = new Size(90, 16);
            label3.TabIndex = 0;
            label3.Text = "Total Purchases";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(226, 237, 237);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label4);
            panel1.Font = new Font("Century Gothic", 8F);
            panel1.Location = new Point(210, 80);
            panel1.Margin = new Padding(4, 2, 4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(174, 90);
            panel1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 8F);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(10, 8);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 16);
            label4.TabIndex = 0;
            label4.Text = "Pending POs";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label5);
            panel2.Location = new Point(400, 80);
            panel2.Margin = new Padding(4, 2, 4, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(174, 90);
            panel2.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 8F);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(15, 8);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(119, 16);
            label5.TabIndex = 1;
            label5.Text = "Supplier Transactions";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(190, 208, 206);
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label6);
            panel3.Location = new Point(590, 80);
            panel3.Margin = new Padding(4, 2, 4, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(174, 90);
            panel3.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 8F);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(18, 8);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(93, 16);
            label6.TabIndex = 2;
            label6.Text = "Inventory Value";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label7);
            panel4.Location = new Point(780, 80);
            panel4.Margin = new Padding(4, 2, 4, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(174, 90);
            panel4.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 8F);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(10, 8);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(56, 16);
            label7.TabIndex = 7;
            label7.Text = "Expenses";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(232, 230);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(0, 16);
            label8.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label9.Location = new Point(20, 186);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(128, 16);
            label9.TabIndex = 7;
            label9.Text = "Purchases per month";
            // 
            // process1
            // 
            process1.StartInfo.CreateNewProcessGroup = false;
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UseCredentialsForNetworkingOnly = false;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label10.Location = new Point(596, 186);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(117, 16);
            label10.TabIndex = 9;
            label10.Text = "Pending approvals";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(596, 210);
            dataGridView1.Margin = new Padding(4, 2, 4, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.SlateGray;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Size = new Size(356, 220);
            dataGridView1.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label11.Location = new Point(20, 447);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(146, 16);
            label11.TabIndex = 11;
            label11.Text = "Recent purchase orders";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(20, 470);
            dataGridView2.Margin = new Padding(4, 2, 4, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(932, 190);
            dataGridView2.TabIndex = 12;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(70, 92, 89);
            panel6.Location = new Point(596, 210);
            panel6.Margin = new Padding(4, 2, 4, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(356, 30);
            panel6.TabIndex = 13;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(70, 92, 89);
            panel7.Location = new Point(20, 470);
            panel7.Margin = new Padding(4, 2, 4, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(932, 30);
            panel7.TabIndex = 14;
            panel7.Paint += panel7_Paint;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(696, 29);
            label12.Name = "label12";
            label12.Size = new Size(133, 15);
            label12.TabIndex = 45;
            label12.Text = "Welcome, Administrator";
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 8F);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(851, 20);
            button3.Name = "button3";
            button3.Size = new Size(100, 32);
            button3.TabIndex = 44;
            button3.Text = "      Refresh";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(70, 92, 89);
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(4, 2, 4, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(559, 30);
            panel8.TabIndex = 14;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(panel8);
            panel5.Location = new Point(20, 210);
            panel5.Margin = new Padding(4, 2, 4, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(560, 220);
            panel5.TabIndex = 8;
            // 
            // A_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label12);
            Controls.Add(button3);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(dataGridView2);
            Controls.Add(label11);
            Controls.Add(dataGridView1);
            Controls.Add(label10);
            Controls.Add(panel5);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "A_Dashboard";
            Size = new Size(972, 700);
            Load += A_Dashboard_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label3;
        private Label label9;
        private System.Diagnostics.Process process1;
        private Label label10;
        private DataGridView dataGridView2;
        private Label label11;
        private DataGridView dataGridView1;
        private Panel panel6;
        private Panel panel7;
        private Label label12;
        private Button button3;
        private Panel panel5;
        private Panel panel8;
    }
}
