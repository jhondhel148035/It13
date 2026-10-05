namespace ProcurementDev.Views.Finance
{
    partial class FinancialReports
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
            listBox1 = new ListBox();
            panel1 = new Panel();
            button2 = new Button();
            label6 = new Label();
            button1 = new Button();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 8F);
            label2.Location = new Point(20, 46);
            label2.Name = "label2";
            label2.Size = new Size(235, 16);
            label2.TabIndex = 20;
            label2.Text = "Payments, balances and expenses reports";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 14);
            label1.Name = "label1";
            label1.Size = new Size(140, 19);
            label1.TabIndex = 19;
            label1.Text = "Financial Reports";
            // 
            // listBox1
            // 
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Font = new Font("Century Gothic", 8F);
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Payments and balances", "Expense summary", "accounts payable aging", "Supplier payment history", "Overdue invoices", "Cash outflow by month" });
            listBox1.Location = new Point(9, 47);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(220, 162);
            listBox1.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(listBox1);
            panel1.Location = new Point(20, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 580);
            panel1.TabIndex = 23;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 8F);
            button2.Location = new Point(9, 492);
            button2.Name = "button2";
            button2.Size = new Size(220, 32);
            button2.TabIndex = 28;
            button2.Text = "Reset filters";
            button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 8F);
            label6.Location = new Point(9, 379);
            label6.Name = "label6";
            label6.Size = new Size(50, 16);
            label6.TabIndex = 26;
            label6.Text = "Supplier";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(207, 161, 44);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 8F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(9, 450);
            button1.Name = "button1";
            button1.Size = new Size(220, 36);
            button1.TabIndex = 27;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 8F);
            label5.Location = new Point(9, 312);
            label5.Name = "label5";
            label5.Size = new Size(19, 16);
            label5.TabIndex = 25;
            label5.Text = "To";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(9, 399);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(220, 23);
            comboBox1.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 8F);
            label4.Location = new Point(9, 253);
            label4.Name = "label4";
            label4.Size = new Size(32, 16);
            label4.TabIndex = 24;
            label4.Text = "From";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 15);
            label3.Name = "label3";
            label3.Size = new Size(90, 16);
            label3.TabIndex = 23;
            label3.Text = "Choose report";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Century Gothic", 8F);
            dateTimePicker2.Location = new Point(9, 333);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(220, 21);
            dateTimePicker2.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Century Gothic", 8F);
            dateTimePicker1.Location = new Point(9, 273);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(220, 21);
            dateTimePicker1.TabIndex = 24;
            // 
            // FinancialReports
            // 
            AutoScaleDimensions = new SizeF(6F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FinancialReports";
            Size = new Size(970, 698);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
