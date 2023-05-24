using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project.Model
{
    internal class DataContext:DbContext
    {
        public DataContext():base("HospitalManagementSystem") { }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<UserAdmin> Users { get; set; }
    }
}
