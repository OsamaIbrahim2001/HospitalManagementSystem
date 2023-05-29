using HospitalSystemManagement.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HospitalSystemManagement
{
    public partial class AddRoom : Form
    {
        DataContext dataContext;
        Room room1;
        public AddRoom()
        {
            InitializeComponent();
            dataContext = new DataContext();
            cmBoxLocation.DataSource=dataContext.Floors.ToList();
            cmBoxLocation.DisplayMember = "Name";
            cmBoxDept.DataSource = dataContext.Departments.ToList();
            cmBoxDept.DisplayMember = "Name";
            btnUpdate.Visible = false;
        }
        internal AddRoom(Room room)
        {
            InitializeComponent();
            dataContext = new DataContext();
            this.room1 = room;
            cmBoxLocation.DataSource = dataContext.Floors.ToList();
            cmBoxLocation.DisplayMember = "Name";
            cmBoxDept.DataSource = dataContext.Departments.ToList();
            cmBoxDept.DisplayMember = "Name";
            btnSave.Visible = false;
        }

        private void btnSaveFllower_Click(object sender, EventArgs e)
        {
            Department dept =(Department)cmBoxDept.SelectedItem;
            Floor floor = (Floor)cmBoxLocation.SelectedItem;
            int count = dataContext.Rooms.Count(r => r.Floor.ID == floor.ID);
            if (count < floor.NumberOfRooms)
            {
             Room room = new Room() { Department = dept, Floor = floor };
             dataContext.Rooms.Add(room);
             dataContext.SaveChanges();
             Close();
            }
            else {
                MessageBox.Show("This Floor is Completed !!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Department dept = (Department)cmBoxDept.SelectedItem;
            Floor floor = (Floor)cmBoxLocation.SelectedItem;
            int count = dataContext.Rooms.Count(r => r.Floor.ID == floor.ID);
            if (count < floor.NumberOfRooms)
            {
                Room room = dataContext.Rooms.First(r=>r.ID==room1.ID);
                room.Department = dept;
                room.Floor = floor;
                dataContext.SaveChanges();
                Close();
            }
            else
            {
                MessageBox.Show("This Floor is Completed !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
