using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica03.Models;
using Practica03;

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
    }
}
