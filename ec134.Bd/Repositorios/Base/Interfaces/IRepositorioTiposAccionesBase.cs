using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioTiposAccionesBase
	{
		/// <summary>
        /// Metodo para obtener todos los TiposAcciones 
        /// </summary>
        /// <returns>IQueryable con todos los TiposAcciones</returns>
		IQueryable<TiposAcciones> GetTiposAcciones();
		
        
        /// <summary>
        /// Obtener un TiposAcciones por su clave primaria
        /// </summary>
				/// <param name="idTipoAccion">IdTipoAccion</param>
		        /// <returns>TiposAcciones   seleccionado por su clave primaria</returns>
		Task<TiposAcciones> GetTiposAccionesByPrimaryKeyAsync(int idTipoAccion);
		
        /// <summary>
        /// Obtener un TiposAcciones por su clave primaria
        /// </summary>
				/// <param name="idTipoAccion">IdTipoAccion</param>
		        /// <returns>TiposAcciones  seleccionado por su clave primaria</returns>
		TiposAcciones GetTiposAccionesByPrimaryKey(int idTipoAccion);


        


		/// <summary>
        /// Crea una instancia de TiposAcciones en la base de datos
        /// </summary>
        /// <param name="source">TiposAcciones a crear</param>
        /// <returns>TiposAcciones creado</returns>
		Task<TiposAcciones> CreateTiposAccionesAsync(TiposAcciones source);

		/// <summary>
        /// Crea una instancia de TiposAcciones en la base de datos
        /// </summary>
        /// <param name="source">TiposAcciones a crear</param>
        /// <returns>TiposAcciones creado</returns>
		TiposAcciones CreateTiposAcciones(TiposAcciones source);


		/// <summary>
        /// Modifica una instancia de TiposAcciones en la base de datos
        /// </summary>
        /// <param name="source">TiposAcciones a modificar</param>
        /// <returns>Número de TiposAcciones modificados</returns>
		Task<int> UpdateTiposAccionesAsync(TiposAcciones source);
		

		/// <summary>
        /// Modifica una instancia de TiposAcciones en la base de datos
        /// </summary>
        /// <param name="source">TiposAcciones a modificar</param>
        /// <returns>Número de TiposAcciones modificados</returns>
		int UpdateTiposAcciones(TiposAcciones source);

		/// <summary>
        /// Borra una instancia de TiposAcciones en la base de datos
        /// </summary>
        /// <param name="source">TiposAcciones a borrar</param>
        /// <returns>Número de TiposAcciones borrados</returns>
		Task<int> DeleteTiposAccionesAsync(TiposAcciones source);
		
		/// <summary>
        /// Borra una instancia de TiposAcciones en la base de datos
        /// </summary>
        /// <param name="source">TiposAcciones a borrar</param>
        /// <returns>Número de TiposAcciones borrados</returns>
		int DeleteTiposAcciones(TiposAcciones source);
    }
}
