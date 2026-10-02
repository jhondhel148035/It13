using System;
using System.Windows.Forms;

namespace ProcurementDev.Views.Admin
{
    public partial class AdminSidebar : UserControl
    {
        public event EventHandler? DashboardClicked;
        public event EventHandler? UserClicked;
        public event EventHandler? SupplierClicked;
        public event EventHandler? PurchReqClicked;
        public event EventHandler? PurchOrdClicked;
        public event EventHandler? ReceivingClicked;
        public event EventHandler? InvoiceClicked;
        public event EventHandler? ReturnsClicked;
        public event EventHandler? ReportsClicked;
        public event EventHandler? ApprovalClicked;

        public AdminSidebar()
        {
            InitializeComponent();
            btnDashboard.Click += (s, e) => DashboardClicked?.Invoke(this, EventArgs.Empty);
            btnUser.Click += (s, e) => UserClicked?.Invoke(this, EventArgs.Empty);
            btnSupplier.Click += (s, e) => SupplierClicked?.Invoke(this, EventArgs.Empty);
            btnPurchReq.Click += (s, e) => PurchReqClicked?.Invoke(this, EventArgs.Empty);
            btnPurchOrd.Click += (s, e) => PurchOrdClicked?.Invoke(this, EventArgs.Empty);
            btnReceiving.Click += (s, e) => ReceivingClicked?.Invoke(this, EventArgs.Empty);
            Invoice.Click += (s, e) => InvoiceClicked?.Invoke(this, EventArgs.Empty);
            btnReturns.Click += (s, e) => ReturnsClicked?.Invoke(this, EventArgs.Empty);
            btnReports.Click += (s, e) => ReportsClicked?.Invoke(this, EventArgs.Empty);
            btnApproval.Click += (s, e) => ApprovalClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
