namespace ProcurementDev.Views.Admin
{
    partial class Approval
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
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            textBox7 = new TextBox();
            label11 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label10 = new Label();
            dataGridView2 = new DataGridView();
            btn_reject = new Button();
            btn_approve = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 8F);
            label2.Location = new Point(22, 46);
            label2.Name = "label2";
            label2.Size = new Size(301, 16);
            label2.TabIndex = 10;
            label2.Text = "Review and approve requisitions and purchase orders";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 14);
            label1.Name = "label1";
            label1.Size = new Size(82, 19);
            label1.TabIndex = 9;
            label1.Text = "Approval";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(207, 161, 44);
            button1.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 8F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(22, 76);
            button1.Name = "button1";
            button1.Size = new Size(169, 34);
            button1.TabIndex = 11;
            button1.Text = "Requisitions";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 8F);
            button2.Location = new Point(198, 76);
            button2.Name = "button2";
            button2.Size = new Size(169, 34);
            button2.TabIndex = 12;
            button2.Text = "Purchase orders";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Century Gothic", 8F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(637, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 24);
            comboBox1.TabIndex = 13;
            comboBox1.Text = "All status";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 8F);
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(796, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 21);
            textBox1.TabIndex = 14;
            textBox1.Text = "Search reference";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(932, 250);
            dataGridView1.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(22, 390);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 270);
            panel1.TabIndex = 16;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(136, 175);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(250, 22);
            textBox6.TabIndex = 27;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(136, 144);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(250, 22);
            textBox5.TabIndex = 26;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(136, 110);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(250, 22);
            textBox4.TabIndex = 25;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(136, 75);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(250, 22);
            textBox3.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(22, 207);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 8F);
            label8.Location = new Point(22, 179);
            label8.Name = "label8";
            label8.Size = new Size(82, 16);
            label8.TabIndex = 22;
            label8.Text = "Budget check";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 8F);
            textBox2.ForeColor = Color.Gray;
            textBox2.Location = new Point(136, 43);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(250, 21);
            textBox2.TabIndex = 17;
            textBox2.Text = "Select a row";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 8F);
            label7.Location = new Point(22, 148);
            label7.Name = "label7";
            label7.Size = new Size(33, 16);
            label7.TabIndex = 21;
            label7.Text = "Total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 8F);
            label6.Location = new Point(22, 114);
            label6.Name = "label6";
            label6.Size = new Size(50, 16);
            label6.TabIndex = 20;
            label6.Text = "Supplier";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 8F);
            label5.Location = new Point(22, 81);
            label5.Name = "label5";
            label5.Size = new Size(83, 16);
            label5.TabIndex = 19;
            label5.Text = "Requested by";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 8F);
            label4.Location = new Point(22, 48);
            label4.Name = "label4";
            label4.Size = new Size(44, 16);
            label4.TabIndex = 18;
            label4.Text = "Ref no.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(109, 16);
            label3.TabIndex = 17;
            label3.Text = "Request summary";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(dataGridView2);
            panel2.Location = new Point(436, 390);
            panel2.Name = "panel2";
            panel2.Size = new Size(516, 270);
            panel2.TabIndex = 18;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(11, 225);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(496, 22);
            textBox7.TabIndex = 30;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(14, 202);
            label11.Name = "label11";
            label11.Size = new Size(57, 16);
            label11.TabIndex = 29;
            label11.Text = "Remarks";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(70, 92, 89);
            flowLayoutPanel1.Location = new Point(11, 34);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(504, 30);
            flowLayoutPanel1.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(13, 9);
            label10.Name = "label10";
            label10.Size = new Size(38, 16);
            label10.TabIndex = 28;
            label10.Text = "Items";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(11, 33);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(558, 158);
            dataGridView2.TabIndex = 0;
            // 
            // btn_reject
            // 
            btn_reject.BackColor = Color.MistyRose;
            btn_reject.FlatStyle = FlatStyle.Flat;
            btn_reject.Font = new Font("Century Gothic", 8F);
            btn_reject.ForeColor = Color.DarkRed;
            btn_reject.Location = new Point(744, 665);
            btn_reject.Name = "btn_reject";
            btn_reject.Size = new Size(101, 32);
            btn_reject.TabIndex = 19;
            btn_reject.Text = "Reject";
            btn_reject.UseVisualStyleBackColor = false;
            btn_reject.Click += btn_reject_Click;
            // 
            // btn_approve
            // 
            btn_approve.BackColor = Color.FromArgb(207, 161, 44);
            btn_approve.FlatAppearance.BorderSize = 0;
            btn_approve.FlatStyle = FlatStyle.Flat;
            btn_approve.Font = new Font("Century Gothic", 8F);
            btn_approve.ForeColor = Color.Black;
            btn_approve.Location = new Point(851, 666);
            btn_approve.Name = "btn_approve";
            btn_approve.Size = new Size(101, 32);
            btn_approve.TabIndex = 20;
            btn_approve.Text = "Approve";
            btn_approve.UseVisualStyleBackColor = false;
            btn_approve.Click += btn_approve_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(70, 92, 89);
            flowLayoutPanel2.Location = new Point(22, 124);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(932, 30);
            flowLayoutPanel2.TabIndex = 20;
            // 
            // Approval
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(flowLayoutPanel2);
            Controls.Add(btn_approve);
            Controls.Add(btn_reject);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Approval";
            Size = new Size(972, 700);
            Load += Approval_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label9;
        private Label label8;
        private Panel panel2;
        private DataGridView dataGridView2;
        private TextBox textBox7;
        private Label label11;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label10;
        private Button btn_reject;
        private Button btn_approve;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}
