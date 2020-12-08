
using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioAccionesBase
	{
		/// <summary>
        /// Metodo para obtener todos los Acciones 
        /// </summary>
        /// <returns>IQueryable con todos los Acciones</returns>
		IQueryable<Acciones> GetAcciones();
		
        
        /// <summary>
        /// Obtener un Acciones por su clave primaria
        /// </summary>
				/// <param name="idAccion">IdAccion</param>
		        /// <returns>Acciones   seleccionado por su clave primaria</returns>
		Task<Acciones> GetAccionesByPrimaryKeyAsync(int idAccion);
		
        /// <summary>
        /// Obtener un Acciones por su clave primaria
        /// </summary>
				/// <param name="idAccion">IdAccion</param>
		        /// <returns>Acciones  seleccionado por su clave primaria</returns>
		Acciones GetAccionesByPrimaryKey(int idAccion);


        


		/// <summary>
        /// Crea una instancia de Acciones en la base de datos
        /// </summary>
        /// <param name="source">Acciones a crear</param>
        /// <returns>Acciones creado</returns>
		Task<Acciones> CreateAccionesAsync(Acciones source);

		/// <summary>
        /// Crea una instancia de Acciones en la base de datos
        /// </summary>
        /// <param name="source">Acciones a crear</param>
        /// <returns>Acciones creado</returns>
		Acciones CreateAcciones(Acciones source);


		/// <summary>
        /// Modifica una instancia de Acciones en la base de datos
        /// </summary>
        /// <param name="source">Acciones a modificar</param>
        /// <returns>Número de Acciones modificados</returns>
		Task<int> UpdateAccionesAsync(Acciones source);
		

		/// <summary>
        /// Modifica una instancia de Acciones en la base de datos
        /// </summary>
        /// <param name="source">Acciones a modificar</param>
        /// <returns>Número de Acciones modificados</returns>
		int UpdateAcciones(Acciones source);

		/// <summary>
        /// Borra una instancia de Acciones en la base de datos
        /// </summary>
        /// <param name="source">Acciones a borrar</param>
        /// <returns>Número de Acciones borrados</returns>
		Task<int> DeleteAccionesAsync(Acciones source);
		
		/// <summary>
        /// Borra una instancia de Acciones en la base de datos
        /// </summary>
        /// <param name="source">Acciones a borrar</param>
        /// <returns>Número de Acciones borrados</returns>
		int DeleteAcciones(Acciones source);
    }
}
