using HospitalSystemManagement.Model;
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
        Department dept;
        DataContext context;
        public AddDepartmentForm()
        { 
            InitializeComponent();
            btnUpdate.Visible = false;
            btnSaveFllower.Visible = true;
            context = new DataContext();
        }
        internal AddDepartmentForm(Department dept)
        {
            InitializeComponent();
            btnUpdate.Visible = true;
            btnSaveFllower.Visible = false;
            this.dept=dept;
            context= new DataContext();
            txtNameOfDept.Text = dept.Name;
            txtDescriptionOfDept.Text = dept.Description;

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
                Department department = new Department()
                {Name=txtNameOfDept.Text,Description=txtNameOfDept.Text };
                context.Departments.Add(department);
                context.SaveChanges();
                Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNameOfDept.Text == "" || txtDescriptionOfDept.Text == "")
            {
                lblError.Visible = true;
            }
            else
            {
               Department department = context.Departments.Where(d => d.ID == dept.ID).First();
                department.Name = txtNameOfDept.Text;
                department.Description= txtDescriptionOfDept.Text;
                context.SaveChanges();
                Close();
            }


        }
    }
}
