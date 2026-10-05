using System;
using System.Windows.Forms;
using ProcurementDev;

namespace ProcurementDev.Views.Admin
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();

            // wire sidebar events
            adminSidebar.DashboardClicked += (s, e) => ShowInContent(new A_Dashboard());
            adminSidebar.UserClicked += (s, e) => ShowInContent(new A_User());
            adminSidebar.SupplierClicked += (s, e) => ShowInContent(new Supplier());
            adminSidebar.PurchReqClicked += (s, e) => ShowInContent(new ProcurementDev.PurchaseRequisition());
            adminSidebar.PurchOrdClicked += (s, e) => ShowInContent(new ProcurementDev.PurchaseOrder());
            adminSidebar.ReceivingClicked += (s, e) => ShowInContent(new ProcurementDev.Receiving());
            adminSidebar.InvoiceClicked += (s, e) => ShowInContent(new ProcurementDev.Invoice());
            adminSidebar.ReturnsClicked += (s, e) => ShowInContent(new ProcurementDev.Returns());
            adminSidebar.ReportsClicked += (s, e) => ShowInContent(new ProcurementDev.Reports());
            adminSidebar.ApprovalClicked += (s, e) => ShowInContent(new Approval());

            // show dashboard by default
            ShowInContent(new A_Dashboard());
        }

        private void ShowInContent(Control control)
        {
            contentPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(control);
        }
    }
}
