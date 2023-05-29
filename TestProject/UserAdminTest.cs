using HospitalSystemManagement;
using HospitalSystemManagement.Model;
using HospitalSystemManagement.Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace TestProject
{
    [TestClass]
    public class UserAdminTest
    {
        [TestMethod]
        public void Login()
        {
            Calc calc=new Calc();
            bool res = calc.login("Osama","123")>0?true:false;
            Assert.AreEqual(res,false);
        }
    }
}
