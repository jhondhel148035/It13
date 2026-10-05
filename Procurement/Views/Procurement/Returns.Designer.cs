namespace ProcurementDev
{
    partial class Returns
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
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dataGridView2 = new DataGridView();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            label2.Size = new Size(369, 16);
            label2.TabIndex = 12;
            label2.Text = "Send damaged, wrong or unautheticate items back to the supplier";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 14);
            label1.Name = "label1";
            label1.Size = new Size(63, 19);
            label1.TabIndex = 11;
            label1.Text = "Returns";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 8F);
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(22, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 21);
            textBox1.TabIndex = 13;
            textBox1.Text = "Search return number PO";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Century Gothic", 8F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(315, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 24);
            comboBox1.TabIndex = 14;
            comboBox1.Text = "All status";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(480, 512);
            dataGridView1.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(20, 644);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 16;
            label3.Text = "0 returns found";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(70, 92, 89);
            panel1.Location = new Point(20, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 30);
            panel1.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 12);
            label4.Name = "label4";
            label4.Size = new Size(120, 16);
            label4.TabIndex = 19;
            label4.Text = "New purchase item";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(comboBox4);
            panel2.Controls.Add(comboBox3);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(516, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(436, 512);
            panel2.TabIndex = 20;
            panel2.Paint += panel2_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(207, 161, 44);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 8F);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(314, 474);
            button2.Name = "button2";
            button2.Size = new Size(90, 32);
            button2.TabIndex = 31;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 8F);
            button1.Location = new Point(216, 474);
            button1.Name = "button1";
            button1.Size = new Size(90, 32);
            button1.TabIndex = 21;
            button1.Text = "Print slip";
            button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(70, 92, 89);
            flowLayoutPanel1.Location = new Point(16, 218);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(404, 30);
            flowLayoutPanel1.TabIndex = 21;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(16, 218);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(404, 250);
            dataGridView2.TabIndex = 30;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(134, 175);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(290, 25);
            comboBox4.TabIndex = 29;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(134, 141);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(290, 25);
            comboBox3.TabIndex = 28;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(134, 75);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(290, 25);
            comboBox2.TabIndex = 27;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(134, 109);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(290, 22);
            textBox3.TabIndex = 26;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 8F);
            textBox2.Location = new Point(134, 43);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(290, 21);
            textBox2.TabIndex = 25;
            textBox2.Text = "auto-generated";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 8F);
            label9.Location = new Point(25, 181);
            label9.Name = "label9";
            label9.Size = new Size(41, 16);
            label9.TabIndex = 24;
            label9.Text = "Action";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 8F);
            label8.Location = new Point(25, 147);
            label8.Name = "label8";
            label8.Size = new Size(56, 16);
            label8.TabIndex = 23;
            label8.Text = "Reason *";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 8F);
            label7.Location = new Point(25, 114);
            label7.Name = "label7";
            label7.Size = new Size(50, 16);
            label7.TabIndex = 22;
            label7.Text = "Supplier";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 8F);
            label6.Location = new Point(25, 80);
            label6.Name = "label6";
            label6.Size = new Size(87, 16);
            label6.TabIndex = 21;
            label6.Text = "PO reference *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 8F);
            label5.Location = new Point(25, 49);
            label5.Name = "label5";
            label5.Size = new Size(62, 16);
            label5.TabIndex = 20;
            label5.Text = "Return no.";
            // 
            // Returns
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Returns";
            Size = new Size(972, 700);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private Panel panel2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private TextBox textBox3;
        private TextBox textBox2;
        private DataGridView dataGridView2;
        private Button button2;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
