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
            throw new NotImplementedException();
        }

        public bool Add(Course c)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}