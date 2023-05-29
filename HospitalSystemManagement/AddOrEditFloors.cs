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
    public partial class AddOrEditFloors : Form
    {
        DataContext dataContext;
        Floor floorOfHospital;
        public AddOrEditFloors()
        {
            InitializeComponent();
            btnSave.Enabled=false;
           btnUpdate.Visible=false;
            dataContext = new DataContext();
        }
        internal AddOrEditFloors(Floor floorOfHospital)
        {
            InitializeComponent();
            btnSave.Visible = false;
            btnUpdate.Visible = true;
            dataContext = new DataContext();
            this.floorOfHospital = floorOfHospital;
            txtNameOfFloor.Text = floorOfHospital.Name;
            txtNumOfRoom.Text = floorOfHospital.NumberOfRooms.ToString();
        }

        private void txtNameOfFloower_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.White;
        }

        private void txtNameOfFloower_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtNumOfRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            { e.Handled = true; }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void txtNumOfRoom_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNumOfRoom.Text) || int.Parse(txtNumOfRoom.Text) == 0)
            { txtNumOfRoom.Text = "0"; btnSave.Enabled = false; btnUpdate.Enabled = false; }
            else
            {
                btnUpdate.Enabled = true;
                btnSave.Enabled = true;
            }
        }
        private void btnSaveFllower_Click(object sender, EventArgs e)
        {
            if (!checkName())
            {
                Floor floor = new Floor() {Name=txtNameOfFloor.Text,NumberOfRooms=int.Parse(txtNumOfRoom.Text) };
                dataContext.Floors.Add(floor);
                dataContext.SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show("This name is already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }


        bool checkName() {
            IEnumerable<string> namesOfFloor = dataContext.Floors.Select(d => d.Name).ToList();
            foreach(string item in namesOfFloor)
            {
                if (item == txtNameOfFloor.Text) return true;
                
            }
            return false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(floorOfHospital.Name);
            MessageBox.Show(txtNameOfFloor.Text);
            if (!checkName() || txtNameOfFloor.Text==floorOfHospital.Name)
            {
                Floor f = dataContext.Floors.First(fl => fl.ID == floorOfHospital.ID);
                f.Name = txtNameOfFloor.Text;
                f.NumberOfRooms = int.Parse(txtNumOfRoom.Text);
                dataContext.SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show("This name is already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
