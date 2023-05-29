using HospitalSystemManagement.Model;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HospitalSystemManagement
{
    public partial class AddPatientForm : Form
    {
        DataContext dataContext;
        Patient patient;
        Room room1;
        public AddPatientForm()
        {
            InitializeComponent();
            dataContext = new DataContext();
            cmBoxDoctorName.DataSource = dataContext.Doctors.ToList();
            cmBoxDoctorName.DisplayMember = "Name";
            cmBoxRoom.DataSource=dataContext.Rooms.Where(r=>!r.Status).ToList();
            cmBoxRoom.DisplayMember = "ID";
            btnUpdate.Visible = false;
        }
        internal AddPatientForm(Patient patient, Room room1)
        {
            InitializeComponent();
            dataContext = new DataContext();
            this.patient = patient;
            this.room1 = room1;
            cmBoxDoctorName.DataSource = dataContext.Doctors.ToList();
            cmBoxDoctorName.DisplayMember = "Name";
            cmBoxRoom.DataSource = dataContext.Rooms.Where(r => !r.Status).ToList();
            cmBoxRoom.DisplayMember = "ID";
            txtName.Text = patient.Name;
            txtNID.Text = patient.NationalID;
            txtPhone.Text = patient.Phone;
            txtAddress.Text = patient.Address;
            txtDescription.Text = patient.Description;
            cmBoxBlood.Text = patient.BloodType;
            cmBoxDoctorName.SelectedItem = patient.Doctor;
            cmBoxRoom.SelectedItem = room1;
            btnAdd.Visible = false;      
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.White;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Doctor doctor = (Doctor)cmBoxDoctorName.SelectedItem;
            Room room = (Room)cmBoxRoom.SelectedItem;
            Patient p = new Patient
            {
                Name = txtName.Text,
                NationalID = txtNID.Text,
                Phone = txtPhone.Text,
                Address = txtAddress.Text,
                Description = txtDescription.Text,
                Doctor = doctor,
                BloodType = cmBoxBlood.Text,
                Room = room,

            };
            dataContext.Patients.Add(p);
            Room roomStatus = dataContext.Rooms.First(r=>r.ID==room.ID);
            room.Status = true;
            dataContext.SaveChanges();

            var lastPatient = dataContext.Patients.ToList();

            dataContext.Histories.Add(new History
            {
                PatientId = lastPatient.Last().ID,
                PatientName = lastPatient.Last().Name,
                Description = lastPatient.Last().Description,
                Doctor = doctor,
                Room = room,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now
            });
            dataContext.SaveChanges();
            Close();
        }

        private void txtNID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            { e.Handled = true; }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Doctor doctor = (Doctor)cmBoxDoctorName.SelectedItem;
            Room room = (Room)cmBoxRoom.SelectedItem;
            Patient p = dataContext.Patients.First(pa=>pa.ID==patient.ID);
            p.Name = txtName.Text;
            p.NationalID = txtNID.Text;
            p.Phone = txtPhone.Text;
            p.Address = txtAddress.Text;
            p.Description = txtDescription.Text;
            p.Doctor = doctor;
            p.BloodType = cmBoxBlood.Text;
            p.Room = room;

            Room oldRoom = dataContext.Rooms.First(rom=>rom.ID==room1.ID);
            oldRoom.Status = false;

            Room newRoom = dataContext.Rooms.First(r => r.ID == room.ID);
            room.Status = true;

           // History history = dataContext.Histories.First(h=>h.PatientId==patient.ID);
           // history.PatientId = patient.ID;
           // history.PatientName = patient.Name;
         //   history.Description = patient.Description;
          //  history.Doctor = doctor;
         //   history.Room = room;

            dataContext.SaveChanges();
            Close();
        }
    }
}
