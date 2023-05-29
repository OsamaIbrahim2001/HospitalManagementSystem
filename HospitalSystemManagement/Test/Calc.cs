using HospitalSystemManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystemManagement.Test
{
    public class Calc
    {
       public int x;
        public int y;

        public int sum() {
        return x + y;
        }

        public int login(string username,string pass)
        {
            DataContext context = new DataContext();
           
            //bool result = false;
            var Users = context.Users.Select(user => user).ToList();
            return Users.Count;
        }
    }
}
