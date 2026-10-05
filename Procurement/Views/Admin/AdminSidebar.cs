
using System;
using System.Drawing;
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

            btnDashboard.Click += (s, e) =>
            {
                SetActiveButton(btnDashboard);
                DashboardClicked?.Invoke(this, EventArgs.Empty);
            };

            btnUser.Click += (s, e) =>
            {
                SetActiveButton(btnUser);
                UserClicked?.Invoke(this, EventArgs.Empty);
            };

            btnSupplier.Click += (s, e) =>
            {
                SetActiveButton(btnSupplier);
                SupplierClicked?.Invoke(this, EventArgs.Empty);
            };

            btnPurchReq.Click += (s, e) =>
            {
                SetActiveButton(btnPurchReq);
                PurchReqClicked?.Invoke(this, EventArgs.Empty);
            };

            btnPurchOrd.Click += (s, e) =>
            {
                SetActiveButton(btnPurchOrd);
                PurchOrdClicked?.Invoke(this, EventArgs.Empty);
            };

            btnReceiving.Click += (s, e) =>
            {
                SetActiveButton(btnReceiving);
                ReceivingClicked?.Invoke(this, EventArgs.Empty);
            };

            Invoice.Click += (s, e) =>
            {
                SetActiveButton(Invoice);
                InvoiceClicked?.Invoke(this, EventArgs.Empty);
            };

            btnReturns.Click += (s, e) =>
            {
                SetActiveButton(btnReturns);
                ReturnsClicked?.Invoke(this, EventArgs.Empty);
            };

            btnReports.Click += (s, e) =>
            {
                SetActiveButton(btnReports);
                ReportsClicked?.Invoke(this, EventArgs.Empty);
            };

            btnApproval.Click += (s, e) =>
            {
                SetActiveButton(btnApproval);
                ApprovalClicked?.Invoke(this, EventArgs.Empty);
            };
        }

        private void SetActiveButton(Button activeButton)
        {
            Button[] buttons =
            {
                btnDashboard,
                btnUser,
                btnSupplier,
                btnPurchReq,
                btnPurchOrd,
                btnReceiving,
                Invoice,
                btnReturns,
                btnReports,
                btnApproval
            };

            foreach (Button button in buttons)
            {
                button.BackColor = Color.FromArgb(21, 21, 27);
                button.ForeColor = Color.White;
            }

            activeButton.BackColor = Color.FromArgb(207, 161, 44);
            activeButton.ForeColor = Color.White;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void AdminSidebar_Load(object sender, EventArgs e)
        {
        }
    }
}