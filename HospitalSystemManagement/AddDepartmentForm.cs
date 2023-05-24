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
    public partial class AddDepartmentForm : Form
    {
        
        public AddDepartmentForm()
        {
            InitializeComponent();
        }

        private void txtNameOfDept_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.White;
        }

        private void txtNameOfDept_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.FromArgb(224,224,224);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveFllower_Click(object sender, EventArgs e)
        {
            if(txtNameOfDept.Text=="" || txtDescriptionOfDept.Text=="")
            {
                lblError.Visible = true;
            }
            else{
                DataContext context = new DataContext();
                Department department = new Department()
                {Name=txtNameOfDept.Text,Description=txtNameOfDept.Text };
                context.Departments.Add(department);
                context.SaveChanges();
                
                Main main = new Main();
                main.btnDept.PerformClick();
                
                Close();
            }
        }
    }
}
