namespace ProcurementDev
{
    partial class Invoice
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
            panel1 = new Panel();
            textBox2 = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label11 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 46);
            label2.Name = "label2";
            label2.Size = new Size(368, 17);
            label2.TabIndex = 10;
            label2.Text = "Record the invoice and match it to the PO and delivery";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 14);
            label1.Name = "label1";
            label1.Size = new Size(83, 23);
            label1.TabIndex = 9;
            label1.Text = "Invoice";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(20, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 490);
            panel1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(139, 315);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 26);
            textBox2.TabIndex = 21;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Location = new Point(138, 275);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 26);
            dateTimePicker2.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(138, 233);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 26);
            dateTimePicker1.TabIndex = 12;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(138, 183);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(250, 28);
            comboBox3.TabIndex = 13;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(138, 134);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 28);
            comboBox2.TabIndex = 19;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(138, 91);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 28);
            comboBox1.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 26);
            textBox1.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(22, 321);
            label10.Name = "label10";
            label10.Size = new Size(111, 17);
            label10.TabIndex = 18;
            label10.Text = "Invoice amount";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(22, 284);
            label9.Name = "label9";
            label9.Size = new Size(69, 17);
            label9.TabIndex = 17;
            label9.Text = "Due date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(22, 240);
            label8.Name = "label8";
            label8.Size = new Size(90, 17);
            label8.TabIndex = 16;
            label8.Text = "Invoice date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(22, 194);
            label7.Name = "label7";
            label7.Size = new Size(90, 17);
            label7.TabIndex = 15;
            label7.Text = "DR reference";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 145);
            label6.Name = "label6";
            label6.Size = new Size(91, 17);
            label6.TabIndex = 14;
            label6.Text = "PO reference";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 97);
            label5.Name = "label5";
            label5.Size = new Size(58, 17);
            label5.TabIndex = 13;
            label5.Text = "Supplier";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 51);
            label4.Name = "label4";
            label4.Size = new Size(91, 17);
            label4.TabIndex = 12;
            label4.Text = "PO number *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 14);
            label3.Name = "label3";
            label3.Size = new Size(116, 18);
            label3.TabIndex = 12;
            label3.Text = "Invoice Details";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(436, 80);
            label11.Name = "label11";
            label11.Size = new Size(304, 18);
            label11.TabIndex = 22;
            label11.Text = "Three-way match (PO, delivery, invoice)";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(436, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(516, 420);
            dataGridView1.TabIndex = 23;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(436, 632);
            button1.Name = "button1";
            button1.Size = new Size(150, 32);
            button1.TabIndex = 24;
            button1.Text = "Dispute invoice";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.SlateGray;
            button2.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(842, 632);
            button2.Name = "button2";
            button2.Size = new Size(110, 32);
            button2.TabIndex = 25;
            button2.Text = "Verify";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateGray;
            panel2.Location = new Point(436, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(516, 30);
            panel2.TabIndex = 26;
            // 
            // Invoice
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label11);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Invoice";
            Size = new Size(972, 700);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBox1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker2;
        private Label label11;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Panel panel2;
    }
}
