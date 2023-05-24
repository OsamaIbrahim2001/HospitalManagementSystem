using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project.Model
{
    internal class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
public ICollection<Room> Rooms { set; get; }
        public ICollection<Doctor> Doctors { set; get; }
    }
}
