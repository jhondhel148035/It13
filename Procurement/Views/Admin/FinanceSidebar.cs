
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProcurementDev.Views.Admin
{
    public partial class FinanceSidebar : UserControl
    {
        public FinanceSidebar()
        {
            InitializeComponent();
        }

        private void FinanceSidebar_Load(object sender, EventArgs e)
        {

        }

        private void SetActiveButton(Button activeButton)
        {
            Button[] buttons =
            {
                btnDashboard,
                btnInvoice,
                btnPayment,
                btnReports
            };

            foreach (Button button in buttons)
            {
                button.BackColor = Color.FromArgb(21, 21, 27);
                button.ForeColor = Color.White;
            }

            activeButton.BackColor = Color.FromArgb(207, 161, 44);
            activeButton.ForeColor = Color.White;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnDashboard);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnInvoice);
        }

        private void btnPurchReq_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnPayment);
        }

        private void btnReturns_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnReports);
        }

        }
    }


