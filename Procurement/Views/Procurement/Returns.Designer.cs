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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            dataGridView2 = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 46);
            label2.Name = "label2";
            label2.Size = new Size(443, 17);
            label2.TabIndex = 12;
            label2.Text = "Send damaged, wrong or unautheticate items back to the supplier";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 14);
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 11;
            label1.Text = "Returns";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(22, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 22);
            textBox1.TabIndex = 13;
            textBox1.Text = "Search return number PO";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(315, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 25);
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
            label3.Size = new Size(103, 17);
            label3.TabIndex = 16;
            label3.Text = "0 returns found";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
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
            label4.Size = new Size(150, 18);
            label4.TabIndex = 19;
            label4.Text = "New purchase item";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 49);
            label5.Name = "label5";
            label5.Size = new Size(74, 17);
            label5.TabIndex = 20;
            label5.Text = "Return no.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 84);
            label6.Name = "label6";
            label6.Size = new Size(101, 17);
            label6.TabIndex = 21;
            label6.Text = "PO reference *";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(25, 118);
            label7.Name = "label7";
            label7.Size = new Size(58, 17);
            label7.TabIndex = 22;
            label7.Text = "Supplier";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(25, 152);
            label8.Name = "label8";
            label8.Size = new Size(65, 17);
            label8.TabIndex = 23;
            label8.Text = "Reason *";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(25, 186);
            label9.Name = "label9";
            label9.Size = new Size(50, 17);
            label9.TabIndex = 24;
            label9.Text = "Action";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(134, 43);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(290, 22);
            textBox2.TabIndex = 25;
            textBox2.Text = "auto-generated";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(134, 109);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(290, 26);
            textBox3.TabIndex = 26;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(134, 75);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(290, 28);
            comboBox2.TabIndex = 27;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(134, 141);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(290, 28);
            comboBox3.TabIndex = 28;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(134, 175);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(290, 28);
            comboBox4.TabIndex = 29;
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.SlateGray;
            flowLayoutPanel1.Location = new Point(16, 218);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(404, 30);
            flowLayoutPanel1.TabIndex = 21;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(216, 474);
            button1.Name = "button1";
            button1.Size = new Size(90, 32);
            button1.TabIndex = 21;
            button1.Text = "Print slip";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.SlateGray;
            button2.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(314, 474);
            button2.Name = "button2";
            button2.Size = new Size(90, 32);
            button2.TabIndex = 31;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = false;
            // 
            // Returns
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
