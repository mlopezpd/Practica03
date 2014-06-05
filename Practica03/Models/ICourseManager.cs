using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica03.Models
{
    interface ICourseManager
    {
        /// <summary>
        /// Devuelve una lista con todos los cursos de la base de datos.
        /// </summary>
        /// <returns>Lista con todos los cursos.</returns>
        List<Course> GetAll();

        /// <summary>
        /// Devuelve el curso que coindice con el ID especificado.
        /// </summary>
        /// <param name="ID">ID del curso a buscar.</param>
        /// <returns>El curso buscado.</returns>
        Course Get(int ID);

        /// <summary>
        /// Añade un curso a la base de datos.
        /// </summary>
        /// <param name="c">El curso que se quiere añadir.</param>
        /// <returns>True o false si se ha podido añadir o no</returns>
        bool Add(Course c);

        /// <summary>
        /// Elimina un curso de la base de datos.
        /// </summary>
        /// <param name="id">ID del curso que se desea eliminar.</param>
        /// <returns>True o false si se ha podido eliminar o no.</returns>
        bool Remove(int id);
    }
}
