using HospitalSystemManagement.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HospitalSystemManagement
{
    public partial class FloorrsOfHospital : Form
    {
        DataContext dataContext;
        public FloorrsOfHospital()
        {
            InitializeComponent();
            dataContext = new DataContext();
            fillFloor();
        }
       void fillFloor() {
            var floors = dataContext.Floors.Select(f=>new {f.ID,f.Name,f.NumberOfRooms }).ToList();
            dgvFloor.DataSource = floors;
            //return floors;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrEditFloors addOrEditFloors = new AddOrEditFloors();
            addOrEditFloors.ShowDialog();
            fillFloor();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvFloor.CurrentCell == null)
            {
                MessageBox.Show("No Data for make this operator !!!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = int.Parse(dgvFloor.CurrentRow.Cells[0].Value.ToString());
                Floor floor = dataContext.Floors.First(f => f.ID == id);
                AddOrEditFloors addOrEditFloors = new AddOrEditFloors(floor);
                addOrEditFloors.ShowDialog();
                fillFloor();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFloor.CurrentCell == null)
            {
                MessageBox.Show("No Data for make this operator !!!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Do you want to delete this field", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = int.Parse((dgvFloor.CurrentRow.Cells[0].Value).ToString());
                    Floor floor = dataContext.Floors.Where(f => f.ID == id).First();
                    dataContext.Floors.Remove(floor);
                    dataContext.SaveChanges();
                    fillFloor();
                }
            }
        }
    }
}
