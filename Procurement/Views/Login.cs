using ProcurementDev.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace ProcurementDev
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Loginclick_Click(object sender, EventArgs e)
        {
            string inputUser = login_UN.Text.Trim();
            string inputPass = login_pw.Text.Trim();

            using (var db = new BoutiqueDbContext())
            {
                //  Search for a user that matches the username and password
                var loggedInUser = db.Users.FirstOrDefault(u => u.Username == inputUser && u.Password == inputPass);

                // Checking if exist
                if (loggedInUser != null)
                {
                    //  Route them based on their Role
                    if (loggedInUser.Role == "Admin")
                    {
                        // Open the AdminForm which hosts the sidebar and dashboard/user views
                        var adminForm = new ProcurementDev.Views.Admin.AdminForm();
                        adminForm.Show();
                        this.Hide(); // Hide the login screen
                    }
                    else if (loggedInUser.Role == "Manager")
                    {
                        // Approval was converted to a UserControl; open a form to host it for Manager role
                        var mgrForm = new Form();
                        var approvalControl = new ProcurementDev.Views.Admin.Approval();
                        approvalControl.Dock = DockStyle.Fill;
                        mgrForm.Controls.Add(approvalControl);
                        mgrForm.StartPosition = FormStartPosition.CenterScreen;
                        mgrForm.ClientSize = approvalControl.Size;
                        mgrForm.Show();
                        this.Hide();
                    }
                    else if (loggedInUser.Role == "Staff")
                    {
                        P_Dashboard staffDash = new P_Dashboard();
                        staffDash.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Role not recognized in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (shw_pw.Checked)
            {
                login_pw.UseSystemPasswordChar = false;
            }
            else
            {
                login_pw.UseSystemPasswordChar = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_pw_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
