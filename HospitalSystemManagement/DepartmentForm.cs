using HospitalSystemManagement.Model;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
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
            var departments = dataContext.Departments.Select(dept => new { dept.ID, dept.Name, dept.Description,Doctors=dept.Doctors.Count,Rooms=dept.Rooms.Count}).ToList();
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
                int id = int.Parse(dgvDepartment.CurrentRow.Cells[0].Value.ToString());
                var dept = dataContext.Departments.Where(d => d.ID == id).First();
                AddDepartmentForm addDepartmentForm = new AddDepartmentForm(dept);
                addDepartmentForm.ShowDialog();
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
                if (MessageBox.Show("Do you want to delete this field", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int x = int.Parse((dgvDepartment.CurrentRow.Cells[0].Value).ToString());
                    var dept = dataContext.Departments.Where(d => d.ID == x).First();
                    dataContext.Departments.Remove(dept);
                    dataContext.SaveChanges();
                    fillData();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var depts = dataContext.Departments.Where(d=>d.Name.Contains(txtSearch.Text)||d.Description.Contains(txtSearch.Text)).Select(dept => new { dept.ID, dept.Name, dept.Description, Doctors = dept.Doctors.Count, Rooms = dept.Rooms.Count }).ToList();
            dgvDepartment.DataSource = depts;
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            fillData();
            txtSearch.Clear();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearch.Text)) lblCancel.Visible = false;
            else lblCancel.Visible = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
