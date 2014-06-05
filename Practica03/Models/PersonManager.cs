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
        public Person Get(int ID)
        {
            try
            {
                Person p = new Person();

                using (School bd = new School())
                {
                    var resultado = from persona in bd.People
                                    where persona.PersonID == ID
                                    select persona;
                    p = resultado.First();
                }
                return p;
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
        /// Añade una persona a la base de datos.
        /// </summary>
        /// <param name="p">La persona que se quiere añadir.</param>
        /// <returns>True o false si se ha podido añadir o no</returns>
        public bool Add(Person p)
        {
            try
            {
                using (School bd = new School())
                {
                    bd.People.Add(p);
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
        /// Elimina una persona de la base de datos.
        /// </summary>
        /// <param name="id">ID de la persona que se desea eliminar.</param>
        /// <returns>True o false si se ha podido eliminar o no.</returns>
        public bool Remove(int id)
        {
            try
            {
                using (School bd = new School())
                {
                    var resultado = from persona in bd.People
                                    where persona.PersonID == id
                                    select persona;
                    Person p = resultado.First();
                    bd.People.Remove(p);
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