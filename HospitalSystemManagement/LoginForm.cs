using C_Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalSystemManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataContext context = new DataContext();
            lblError.Visible = false;
            if(txtUsername.Text=="" || txtPassword.Text == "")
            {
                lblError.Visible = true;
            }
            else
            {
                var Users = context.Users.Select(user => user);
                foreach(var item in Users)
                {
                    if(item.Username==txtUsername.Text && item.Password == txtPassword.Text)
                    {
                        Hide();
                        Main main = new Main();
                        main.Show();
                        return;
                    }
                }
                txtUsername.Clear();
                txtPassword.Clear();
                lblError.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
