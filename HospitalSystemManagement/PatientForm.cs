using HospitalSystemManagement.Model;
using HospitalSystemManagement.PrinterReports;
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
    public partial class PatientForm : Form
    {
        DataContext dataContext;
        public PatientForm()
        {
            InitializeComponent();
            dataContext = new DataContext();
            fillPatients();
        }
        void fillPatients() {
            dgvPatient.DataSource = dataContext.Patients.Select(p => new
            {
                p.ID,
                Name = p.Name,
                p.NationalID,
                p.Phone,
                p.Address,
                DName=p.Doctor.Name,
                p.BloodType,
                RoomID = p.Room.ID
            }).ToList();
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
            AddPatientForm addPatientForm = new AddPatientForm();
            addPatientForm.ShowDialog();
            fillPatients();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var patients=dataContext.Patients.Select(p => new
            {
                p.ID,
                p.Name,
                p.NationalID,
                p.Phone,
                p.Address,
                DName=p.Doctor.Name,
                p.BloodType,
                RoomID = p.Room.ID
            }).ToList();
            PrintReports.print("Patients Report", patients);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearch.Text))
            { lblCancel.Visible = false; fillPatients(); }
            else lblCancel.Visible = true;
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPatient.CurrentCell == null)
            {
                MessageBox.Show("No Data for make this operator !!!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = int.Parse(dgvPatient.CurrentRow.Cells[0].Value.ToString());
                Patient patient = dataContext.Patients.Select(pa=>pa).First(p=>p.ID==id);
                int roomID = int.Parse(dgvPatient.CurrentRow.Cells[7].Value.ToString());
                Room room = dataContext.Rooms.First(r=>r.ID==roomID);
                
                AddPatientForm addPatientForm = new AddPatientForm(patient,room);
                addPatientForm.ShowDialog();
                fillPatients();
            }
            }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPatient.CurrentCell == null)
            {
                MessageBox.Show("No Data for make this operator !!!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Do you want to delete this field", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = int.Parse(dgvPatient.CurrentRow.Cells[0].Value.ToString());
                    int roomId = int.Parse(dgvPatient.CurrentRow.Cells[7].Value.ToString());
                    Room room = dataContext.Rooms.First(r => r.ID == roomId);
                    room.Status = false;

                    History history = dataContext.Histories.First(h => h.PatientId == id);
                    history.EndDate = DateTime.Now;

                    dataContext.SaveChanges();
                    dataContext.Patients.Remove(dataContext.Patients.First(p => p.ID == id));
                    dataContext.SaveChanges();
                    fillPatients();

                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvPatient.DataSource = dataContext.Patients.Where(p=>p.Name.Contains(txtSearch.Text)||p.NationalID.Contains(txtSearch.Text)||
            p.Address.Contains(txtSearch.Text)||p.BloodType==txtSearch.Text||p.Doctor.Name.Contains(txtSearch.Text)).Select(p => new
            {
                p.ID,
                p.Name,
                p.NationalID,
                p.Phone,
                p.Address,
                DName = p.Doctor.Name,
                p.BloodType,
                RoomID = p.Room.ID
            }).ToList();
        }
    }
}
