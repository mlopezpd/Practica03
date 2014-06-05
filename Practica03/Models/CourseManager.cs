using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.ServiceModel;

namespace Practica03.Models
{
    public class CourseManager:ICourseManager
    {
        /// <summary>
        /// Devuelve una lista con todos los cursos de la base de datos.
        /// </summary>
        /// <returns>Lista con todos los cursos.</returns>
        public List<Course> GetAll()
        {
            try
            {
                List<Course> lista = new List<Course>();
                
                using (School bd = new School())
                {
                    var resultado = from curso in bd.Courses
                                    select curso;
                    lista = resultado.ToList();
                }
                return lista;
            }
            catch (SqlException err)
            {
                FaultException fault = new FaultException("Error SQL: " + err.Message, new FaultCode("SQL"));
                throw fault;
            }
            catch (Exception err)
            {
                FaultException fault = new FaultException("Error SQL: " + err.Message, new FaultCode("SQL"));
                throw fault;
            }
        }

        /// <summary>
        /// Devuelve el curso que coindice con el ID especificado.
        /// </summary>
        /// <param name="ID">ID del curso a buscar.</param>
        /// <returns>El curso buscado.</returns>
        public Course Get(int ID)
        {
            try
            {
                Course c = new Course();

                using (School bd = new School())
                {
                    var resultado = from curso in bd.Courses
                                    where curso.CourseID == ID
                                    select curso;
                }
                return c;
            }
            catch (SqlException err)
            {
                FaultException fault = new FaultException("Error SQL: " + err.Message, new FaultCode("SQL"));
                throw fault;
            }
            catch (Exception err)
            {
                FaultException fault = new FaultException("Error SQL: " + err.Message, new FaultCode("SQL"));
                throw fault;
            }
        }

        /// <summary>
        /// Añade un curso a la base de datos.
        /// </summary>
        /// <param name="c">El curso que se quiere añadir.</param>
        /// <returns>True o false si se ha podido añadir o no</returns>
        public bool Add(Course c)
        {
            try
            {
                using (School bd = new School())
                {
                    bd.Courses.Add(c);
                    bd.SaveChanges();
                }
                return true;
            }
            catch (SqlException err)
            {
                FaultException fault = new FaultException("Error SQL: " + err.Message, new FaultCode("SQL"));
                throw fault;
            }
            catch (Exception err)
            {
                FaultException fault = new FaultException("Error SQL: " + err.Message, new FaultCode("SQL"));
                throw fault;
            }
        }

        /// <summary>
        /// Elimina un curso de la base de datos.
        /// </summary>
        /// <param name="id">ID del curso que se desea eliminar.</param>
        /// <returns>True o false si se ha podido eliminar o no.</returns>
        public bool Remove(int id)
        {
            try
            {
                using (School bd = new School())
                {
                    var resultado = from curso in bd.Courses
                                    where curso.CourseID == id
                                    select curso;
                    Course c = resultado.First();
                    bd.Courses.Remove(c);
                    bd.SaveChanges();
                }
                return true;
            }
            catch (SqlException err)
            {
                FaultException fault = new FaultException("Error SQL: " + err.Message, new FaultCode("SQL"));
                throw fault;
            }
            catch (Exception err)
            {
                FaultException fault = new FaultException("Error SQL: " + err.Message, new FaultCode("SQL"));
                throw fault;
            }
        }
    }
}