using HospitalSystemManagement.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HospitalSystemManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public void btnLogin_Click(object sender, EventArgs e)
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
                        Profile.Username = txtUsername.Text;
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

       public void LoginTestFun() {
            DataContext context = new DataContext();
            lblError.Visible = false;
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                lblError.Visible = true;
            }
            else
            {
                var Users = context.Users.Select(user => user);
                foreach (var item in Users)
                {
                    if (item.Username == txtUsername.Text && item.Password == txtPassword.Text)
                    {
                        Profile.Username = txtUsername.Text;
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
    }
}
