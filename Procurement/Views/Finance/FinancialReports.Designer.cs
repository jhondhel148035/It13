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
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            listBox1 = new System.Windows.Forms.ListBox();
            panel1 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            comboBox1 = new System.Windows.Forms.ComboBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(20, 46);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(276, 17);
            label2.TabIndex = 20;
            label2.Text = "Payments, balances and expenses reports";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(20, 14);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(176, 23);
            label1.TabIndex = 19;
            label1.Text = "Financial Reports";
            // 
            // listBox1
            // 
            listBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Payments and balances", "Expense summary", "accounts payable aging", "Supplier payment history", "Overdue invoices", "Cash outflow by month" });
            listBox1.Location = new System.Drawing.Point(9, 47);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(220, 184);
            listBox1.TabIndex = 22;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Location = new System.Drawing.Point(20, 80);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(240, 580);
            panel1.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(9, 15);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(113, 18);
            label3.TabIndex = 23;
            label3.Text = "Choose report";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(9, 273);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(220, 22);
            dateTimePicker1.TabIndex = 24;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new System.Drawing.Point(9, 333);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(220, 22);
            dateTimePicker2.TabIndex = 25;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(9, 399);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(220, 25);
            comboBox1.TabIndex = 26;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.SlateGray;
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(9, 450);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(220, 36);
            button1.TabIndex = 27;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(9, 492);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(220, 32);
            button2.TabIndex = 28;
            button2.Text = "Reset filters";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(9, 253);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(40, 17);
            label4.TabIndex = 24;
            label4.Text = "From";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(9, 312);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(22, 17);
            label5.TabIndex = 25;
            label5.Text = "To";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(9, 379);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(58, 17);
            label6.TabIndex = 26;
            label6.Text = "Supplier";
            // 
            // FinancialReports
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Century Gothic", 7.20000029F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Name = "FinancialReports";
            Size = new System.Drawing.Size(972, 700);
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
