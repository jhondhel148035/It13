namespace ProcurementDev.Views.Admin
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;
        private AdminSidebar adminSidebar;
        private System.Windows.Forms.Panel contentPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            adminSidebar = new AdminSidebar();
            contentPanel = new System.Windows.Forms.Panel();
            SuspendLayout();
            // 
            // adminSidebar
            // 
            adminSidebar.Location = new System.Drawing.Point(0, 0);
            adminSidebar.Name = "adminSidebar";
            adminSidebar.Size = new System.Drawing.Size(228, 700);
            adminSidebar.TabIndex = 0;
            // 
            // contentPanel
            // 
            contentPanel.Location = new System.Drawing.Point(228, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new System.Drawing.Size(972, 700);
            contentPanel.TabIndex = 1;
            // 
            // AdminForm
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1200, 700);
            Controls.Add(contentPanel);
            Controls.Add(adminSidebar);
            Name = "AdminForm";
            Text = "Admin";
            ResumeLayout(false);
        }

        #endregion
    }
}
