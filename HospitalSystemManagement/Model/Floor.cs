using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project.Model
{
    internal class Floor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int NumberOfRooms { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }
}
