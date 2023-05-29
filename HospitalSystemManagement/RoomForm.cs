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
    public partial class RoomForm : Form
    {
        DataContext dataContext;
        public RoomForm()
        {
            InitializeComponent();
            dataContext = new DataContext();
            fillRooms();
        }
        void fillRooms() {
            var rooms = dataContext.Rooms.Select(r => new { RoomID = r.ID, Location = r.Floor.Name, Department = r.Department.Name, r.Status }).ToList();
            dgvRoom.DataSource = rooms;
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
            AddRoom addRoom = new AddRoom();
            addRoom.ShowDialog();
            fillRooms();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearch.Text))
                lblCancel.Visible = false;
            else lblCancel.Visible = true;
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvRoom.CurrentCell == null)
            {
                MessageBox.Show("No Data for make this operator !!!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = int.Parse(dgvRoom.CurrentRow.Cells[0].Value.ToString());
                AddRoom addRoom = new AddRoom(dataContext.Rooms.First(r => r.ID == id));
                addRoom.ShowDialog();
                fillRooms();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRoom.CurrentCell == null)
            {
                MessageBox.Show("No Data for make this operator !!!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Do you want to delete this field", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int x = int.Parse((dgvRoom.CurrentRow.Cells[0].Value).ToString());
                    var room = dataContext.Rooms.Where(d => d.ID == x).First();
                    dataContext.Rooms.Remove(room);
                    dataContext.SaveChanges();
                    fillRooms();
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var rooms = dataContext.Rooms.Select(r => new { RoomID = r.ID, Location = r.Floor.Name, Department = r.Department.Name, r.Status }).ToList();
            PrintReports.print("Rooms Report", rooms);
        }
        
    }
}
