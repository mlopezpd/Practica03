using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica03.Models;
using Practica03;
using System.Data.SqlClient;
using System.ServiceModel;

namespace Pruebas
{
    /// <summary>
    /// Summary description for CourseManagerTest
    /// </summary>
    [TestClass]
    public class CourseManagerTest
    {
        [TestMethod]
        public void GetAllTest()
        {
            int elementos = CourseManager.GetAll().Count;
            Course c = new Course();
            c.CourseID = 345;
            c.Title = "Titulo";
            c.Credits = 1;
            c.DepartmentID = 1;
            CourseManager.Add(c);
            int elementos2 = CourseManager.GetAll().Count;
            Assert.AreEqual(elementos+1, elementos2);

            CourseManager.Remove(345);
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException))]
        public void GetTest()
        {
            Course c = new Course();
             c = CourseManager.Get(1);
             Assert.IsNull(c);
            

            int id = 1045;
            c = CourseManager.Get(id);

            Assert.IsNotNull(c);
            Assert.AreEqual(c.CourseID, id);
        }
        [TestMethod]
        public void AddTest()
        {
            Course c = new Course();
            c.CourseID = 345;
            c.Title = "Titulo";
            c.Credits = 1;
            c.DepartmentID = 1;
            bool resultado = CourseManager.Add(c);

            Assert.IsTrue(resultado);
            CourseManager.Remove(345);
        }
        [TestMethod]
        public void RemoveTest()
        {
            Course c = new Course();
            c.CourseID = 345;
            c.Title = "Titulo";
            c.Credits = 1;
            c.DepartmentID = 1;
            CourseManager.Add(c);

            bool resultado = CourseManager.Remove(345);
            Assert.IsTrue(resultado);
        }
    }
}
