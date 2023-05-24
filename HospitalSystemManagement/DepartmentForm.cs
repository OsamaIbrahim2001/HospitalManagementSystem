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
    public partial class DepartmentForm : Form
    {
        DataContext dataContext;
        public DepartmentForm()
        {
            InitializeComponent();
           dataContext = new DataContext();
            fillData();
        }
       public void fillData() {
            var departments = dataContext.Departments.Select(dept => new { dept.ID, dept.Name, dept.Description }).ToList();
            dgvDepartment.DataSource = departments;
        }
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.White;
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.FromArgb(224,224,224);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddDepartmentForm addDepartmentForm = new AddDepartmentForm();
            addDepartmentForm.ShowDialog();
        }

        private void DepartmentForm_Activated(object sender, EventArgs e)
        {
            if (dgvDepartment.CurrentCell == null)
            {
                label2.Visible = true;
            }
            else
            {
                label2.Visible = false;
            }
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDepartment.CurrentCell == null)
            {
                MessageBox.Show("No Data for make this operator !!!! ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                var dept = dataContext.Departments.Where(d => d.ID == int.Parse(dgvDepartment.CurrentRow.Cells[0].Value.ToString())).First();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDepartment.CurrentCell == null)
            {
                MessageBox.Show("No Data for make this operator !!!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               int x = int.Parse((dgvDepartment.CurrentRow.Cells[0].Value).ToString());
                var dept = dataContext.Departments.Where(d => d.ID ==x ).First();
                dataContext.Departments.Remove(dept);
                dataContext.SaveChanges();
                fillData();
            }
        }
    }
}
