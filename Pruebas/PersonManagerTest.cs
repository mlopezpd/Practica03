using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica03.Models;
using Practica03;
using System.Collections.Generic;

namespace Pruebas
{
    [TestClass]
    public class PersonManagerTest
    {
        [TestMethod]
         public void GetAllTest()
        {
            int elementos = PersonManager.GetAll().Count;

            Person p = new Person();

            p.EnrollmentDate = new DateTime();
            p.HireDate = new DateTime();
            p.FirstName = "Felipe";
            p.LastName = "González";
            PersonManager.Add(p);

            int elementos2 = PersonManager.GetAll().Count;

            Assert.AreEqual(elementos + 1, elementos2);

            PersonManager.Remove(p.PersonID);
        }
    }
}
