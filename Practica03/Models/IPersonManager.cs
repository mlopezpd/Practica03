using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica03.Models
{
    interface IPersonManager
    {
        /// <summary>
        /// Devuelve una lista con todos las personas de la base de datos.
        /// </summary>
        /// <returns>Lista con todos las personas.</returns>
        List<Person> GetAll();

        /// <summary>
        /// Devuelve la persona que coindice con el ID especificado.
        /// </summary>
        /// <param name="ID">ID de la persona a buscar.</param>
        /// <returns>La persona buscada.</returns>
        Person Get(int ID);

        /// <summary>
        /// Añade una persona a la base de datos.
        /// </summary>
        /// <param name="c">La persona que se quiere añadir.</param>
        /// <returns>True o false si se ha podido añadir o no</returns>
        bool Add(Person c);

        /// <summary>
        /// Elimina una persona de la base de datos.
        /// </summary>
        /// <param name="id">ID de la persona que se desea eliminar.</param>
        /// <returns>True o false si se ha podido eliminar o no.</returns>
        bool Remove(int id);
    }
}
