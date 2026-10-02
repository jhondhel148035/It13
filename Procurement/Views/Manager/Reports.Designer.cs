namespace ProcurementDev
{
    partial class Reports
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
            button2 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label6 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 46);
            label2.Name = "label2";
            label2.Size = new Size(277, 17);
            label2.TabIndex = 12;
            label2.Text = "Pick a report, set the filter and generate it";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 14);
            label1.Name = "label1";
            label1.Size = new Size(82, 23);
            label1.TabIndex = 11;
            label1.Text = "Reports";
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(listBox1);
            panel1.Location = new Point(22, 80);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 580);
            panel1.TabIndex = 13;
            // 
            // button2
            // 
            button2.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(10, 512);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(220, 32);
            button2.TabIndex = 14;
            button2.Text = "Reset filters";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.SlateGray;
            button1.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(10, 471);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(220, 35);
            button1.TabIndex = 14;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(10, 425);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(220, 28);
            comboBox1.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 402);
            label6.Name = "label6";
            label6.Size = new Size(58, 17);
            label6.TabIndex = 18;
            label6.Text = "Supplier";
            label6.Click += label6_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarFont = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Location = new Point(10, 362);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(220, 26);
            dateTimePicker2.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 339);
            label5.Name = "label5";
            label5.Size = new Size(22, 17);
            label5.TabIndex = 16;
            label5.Text = "To";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(10, 302);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(220, 26);
            dateTimePicker1.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 281);
            label4.Name = "label4";
            label4.Size = new Size(40, 17);
            label4.TabIndex = 15;
            label4.Text = "From";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 12);
            label3.Name = "label3";
            label3.Size = new Size(113, 18);
            label3.TabIndex = 14;
            label3.Text = "Choose report";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Purchase summary", "Purchase order by supplier", "Inventory stock", "Low-stock items", "Supplier performace", "Payments and balances", "Expense summary" });
            listBox1.Location = new Point(10, 42);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(220, 224);
            listBox1.TabIndex = 14;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Reports";
            Size = new Size(972, 700);
            Load += Reports_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Panel panel1;
        private ListBox listBox1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private ComboBox comboBox1;
        private Label label6;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private Button button2;
        private Button button1;
    }
}
