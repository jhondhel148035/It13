namespace ProcurementDev
{
    partial class Supplier
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            panel1 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            comboBox5 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 13);
            label1.Name = "label1";
            label1.Size = new Size(72, 19);
            label1.TabIndex = 0;
            label1.Text = "Supplier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 43);
            label2.Name = "label2";
            label2.Size = new Size(172, 16);
            label2.TabIndex = 1;
            label2.Text = "Add, edit, and delete suppliers";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(20, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 21);
            textBox1.TabIndex = 2;
            textBox1.Text = "Search name, contact or code";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Century Gothic", 8F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(280, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(120, 24);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "All status";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(410, 75);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(140, 24);
            comboBox2.TabIndex = 4;
            comboBox2.Text = "All authenticity";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(560, 73);
            button1.Name = "button1";
            button1.Size = new Size(90, 30);
            button1.TabIndex = 5;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(560, 482);
            dataGridView1.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(70, 92, 89);
            flowLayoutPanel1.Location = new Point(20, 118);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(560, 28);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(20, 606);
            label3.Name = "label3";
            label3.Size = new Size(96, 16);
            label3.TabIndex = 8;
            label3.Text = "0 suppliers found";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(comboBox5);
            panel1.Controls.Add(comboBox4);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(596, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 508);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(207, 161, 44);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Century Gothic", 8F);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(181, 446);
            button6.Name = "button6";
            button6.Size = new Size(136, 30);
            button6.TabIndex = 33;
            button6.Text = "Save";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 8F);
            button5.Location = new Point(44, 446);
            button5.Name = "button5";
            button5.Size = new Size(136, 30);
            button5.TabIndex = 32;
            button5.Text = "Cancel";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 8F);
            button4.ForeColor = Color.Red;
            button4.Location = new Point(232, 407);
            button4.Name = "button4";
            button4.Size = new Size(88, 30);
            button4.TabIndex = 31;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 8F);
            button3.Location = new Point(138, 407);
            button3.Name = "button3";
            button3.Size = new Size(88, 30);
            button3.TabIndex = 30;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 8F);
            button2.Location = new Point(44, 407);
            button2.Name = "button2";
            button2.Size = new Size(88, 30);
            button2.TabIndex = 29;
            button2.Text = "New";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(128, 292);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(220, 24);
            comboBox5.TabIndex = 28;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(128, 260);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(220, 24);
            comboBox4.TabIndex = 27;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(128, 228);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(220, 24);
            comboBox3.TabIndex = 26;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(128, 198);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(220, 21);
            textBox7.TabIndex = 25;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(128, 168);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(220, 21);
            textBox6.TabIndex = 24;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(128, 136);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(220, 21);
            textBox5.TabIndex = 23;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(128, 106);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(220, 21);
            textBox4.TabIndex = 22;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Century Gothic", 8F);
            textBox3.Location = new Point(128, 76);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(220, 21);
            textBox3.TabIndex = 21;
            textBox3.Text = "Select a row";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 8F);
            textBox2.Location = new Point(128, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 21);
            textBox2.TabIndex = 20;
            textBox2.Text = "Select a row";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 8F);
            label13.Location = new Point(12, 300);
            label13.Name = "label13";
            label13.Size = new Size(40, 16);
            label13.TabIndex = 19;
            label13.Text = "Status";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 8F);
            label12.Location = new Point(12, 266);
            label12.Name = "label12";
            label12.Size = new Size(71, 16);
            label12.TabIndex = 18;
            label12.Text = "Authenticity";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 8F);
            label11.Location = new Point(12, 233);
            label11.Name = "label11";
            label11.Size = new Size(87, 16);
            label11.TabIndex = 17;
            label11.Text = "Payment terms";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 8F);
            label10.Location = new Point(12, 203);
            label10.Name = "label10";
            label10.Size = new Size(23, 16);
            label10.TabIndex = 16;
            label10.Text = "TIN";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 8F);
            label9.Location = new Point(12, 173);
            label9.Name = "label9";
            label9.Size = new Size(48, 16);
            label9.TabIndex = 15;
            label9.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 8F);
            label8.Location = new Point(12, 142);
            label8.Name = "label8";
            label8.Size = new Size(44, 16);
            label8.TabIndex = 14;
            label8.Text = "Email *";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 8F);
            label7.Location = new Point(12, 112);
            label7.Name = "label7";
            label7.Size = new Size(51, 16);
            label7.TabIndex = 13;
            label7.Text = "Phone *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 8F);
            label6.Location = new Point(12, 80);
            label6.Name = "label6";
            label6.Size = new Size(101, 16);
            label6.TabIndex = 12;
            label6.Text = "Contact person *";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 8F);
            label5.Location = new Point(12, 50);
            label5.Name = "label5";
            label5.Size = new Size(94, 16);
            label5.TabIndex = 11;
            label5.Text = "Supplier name *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 12);
            label4.Name = "label4";
            label4.Size = new Size(95, 16);
            label4.TabIndex = 10;
            label4.Text = "Supplier details";
            // 
            // Supplier
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 8F);
            Name = "Supplier";
            Size = new Size(972, 700);
            Load += Supplier_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox4;
        private ComboBox comboBox5;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private TextBox textBox7;
        private TextBox textBox6;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}
