using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace Practica03.Models
{
    public class PersonManager: IPersonManager
    {
        /// <summary>
        /// Devuelve una lista con todos las personas de la base de datos.
        /// </summary>
        /// <returns>Lista con todos las personas.</returns>
        public List<Person> GetAll()
        {
            try
            {
                List<Person> lista = new List<Person>();

                using (School bd = new School())
                {
                    var resultado = from persona in bd.People
                                    select persona;
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
        /// Devuelve la persona que coindice con el ID especificado.
        /// </summary>
        /// <param name="ID">ID de la persona a buscar.</param>
        /// <returns>La persona buscada.</returns>
        public Course Get(int ID)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Añade una persona a la base de datos.
        /// </summary>
        /// <param name="c">La persona que se quiere añadir.</param>
        /// <returns>True o false si se ha podido añadir o no</returns>
        public bool Add(Person c)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Elimina una persona de la base de datos.
        /// </summary>
        /// <param name="id">ID de la persona que se desea eliminar.</param>
        /// <returns>True o false si se ha podido eliminar o no.</returns>
        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}