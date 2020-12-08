using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioDesplieguesBase
	{
		/// <summary>
        /// Metodo para obtener todos los Despliegues 
        /// </summary>
        /// <returns>IQueryable con todos los Despliegues</returns>
		IQueryable<Despliegues> GetDespliegues();
		
        
        /// <summary>
        /// Obtener un Despliegues por su clave primaria
        /// </summary>
				/// <param name="idDespliegue">IdDespliegue</param>
		        /// <returns>Despliegues   seleccionado por su clave primaria</returns>
		Task<Despliegues> GetDesplieguesByPrimaryKeyAsync(int idDespliegue);
		
        /// <summary>
        /// Obtener un Despliegues por su clave primaria
        /// </summary>
				/// <param name="idDespliegue">IdDespliegue</param>
		        /// <returns>Despliegues  seleccionado por su clave primaria</returns>
		Despliegues GetDesplieguesByPrimaryKey(int idDespliegue);


        


		/// <summary>
        /// Crea una instancia de Despliegues en la base de datos
        /// </summary>
        /// <param name="source">Despliegues a crear</param>
        /// <returns>Despliegues creado</returns>
		Task<Despliegues> CreateDesplieguesAsync(Despliegues source);

		/// <summary>
        /// Crea una instancia de Despliegues en la base de datos
        /// </summary>
        /// <param name="source">Despliegues a crear</param>
        /// <returns>Despliegues creado</returns>
		Despliegues CreateDespliegues(Despliegues source);


		/// <summary>
        /// Modifica una instancia de Despliegues en la base de datos
        /// </summary>
        /// <param name="source">Despliegues a modificar</param>
        /// <returns>Número de Despliegues modificados</returns>
		Task<int> UpdateDesplieguesAsync(Despliegues source);
		

		/// <summary>
        /// Modifica una instancia de Despliegues en la base de datos
        /// </summary>
        /// <param name="source">Despliegues a modificar</param>
        /// <returns>Número de Despliegues modificados</returns>
		int UpdateDespliegues(Despliegues source);

		/// <summary>
        /// Borra una instancia de Despliegues en la base de datos
        /// </summary>
        /// <param name="source">Despliegues a borrar</param>
        /// <returns>Número de Despliegues borrados</returns>
		Task<int> DeleteDesplieguesAsync(Despliegues source);
		
		/// <summary>
        /// Borra una instancia de Despliegues en la base de datos
        /// </summary>
        /// <param name="source">Despliegues a borrar</param>
        /// <returns>Número de Despliegues borrados</returns>
		int DeleteDespliegues(Despliegues source);
    }
}
