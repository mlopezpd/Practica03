using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica03.Models;
using Practica03;
using System.Collections.Generic;
using System.ServiceModel;

namespace Pruebas
{
    [TestClass]
    public class PersonManagerTest
    {
        [TestMethod]
        [ExpectedException(typeof(FaultException))]
         public void GetAllTest()
        {
            int elementos = PersonManager.GetAll().Count;

            Person p = new Person();

            p.EnrollmentDate = null;
            p.HireDate = null;
            p.FirstName = "Felipe";
            p.LastName = "González";
            PersonManager.Add(p);

            int elementos2 = PersonManager.GetAll().Count;

            Assert.AreEqual(elementos + 1, elementos2);

            PersonManager.Remove(p.PersonID);
        }
        [TestMethod]
        [ExpectedException(typeof(FaultException))]
        public void GetTest()
        {
            Person p = null;
            try
            {
                p = PersonManager.Get(444);
            }
            catch
            {
                Assert.IsNull(p);
            }

            int id = 1;
            p = PersonManager.Get(id);

            Assert.IsNotNull(p);
            Assert.AreEqual(p.PersonID, id);
        }
        [TestMethod]
        [ExpectedException(typeof(FaultException))]
        public void AddTest()
        {
            Person p = new Person();

            p.EnrollmentDate = null;
            p.HireDate = null;
            p.FirstName = "Felipe";
            p.LastName = "González";
            bool resultado = PersonManager.Add(p);

            Assert.IsTrue(resultado);
            PersonManager.Remove(p.PersonID);
        }
        [TestMethod]
        [ExpectedException(typeof(FaultException))]
        public void RemoveTest()
        {
            Person p = new Person();

            p.EnrollmentDate = null;
            p.HireDate = null;
            p.FirstName = "Felipe";
            p.LastName = "González";
            PersonManager.Add(p);

            bool resultado = PersonManager.Remove(p.PersonID);
            Assert.IsTrue(resultado);
        }
    }
}