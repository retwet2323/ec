using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioTiposServicioBase
	{
		/// <summary>
        /// Metodo para obtener todos los TiposServicio 
        /// </summary>
        /// <returns>IQueryable con todos los TiposServicio</returns>
		IQueryable<TiposServicio> GetTiposServicio();
		
        
        /// <summary>
        /// Obtener un TiposServicio por su clave primaria
        /// </summary>
				/// <param name="idTipoServicio">IdTipoServicio</param>
		        /// <returns>TiposServicio   seleccionado por su clave primaria</returns>
		Task<TiposServicio> GetTiposServicioByPrimaryKeyAsync(int idTipoServicio);
		
        /// <summary>
        /// Obtener un TiposServicio por su clave primaria
        /// </summary>
				/// <param name="idTipoServicio">IdTipoServicio</param>
		        /// <returns>TiposServicio  seleccionado por su clave primaria</returns>
		TiposServicio GetTiposServicioByPrimaryKey(int idTipoServicio);


        


		/// <summary>
        /// Crea una instancia de TiposServicio en la base de datos
        /// </summary>
        /// <param name="source">TiposServicio a crear</param>
        /// <returns>TiposServicio creado</returns>
		Task<TiposServicio> CreateTiposServicioAsync(TiposServicio source);

		/// <summary>
        /// Crea una instancia de TiposServicio en la base de datos
        /// </summary>
        /// <param name="source">TiposServicio a crear</param>
        /// <returns>TiposServicio creado</returns>
		TiposServicio CreateTiposServicio(TiposServicio source);


		/// <summary>
        /// Modifica una instancia de TiposServicio en la base de datos
        /// </summary>
        /// <param name="source">TiposServicio a modificar</param>
        /// <returns>Número de TiposServicio modificados</returns>
		Task<int> UpdateTiposServicioAsync(TiposServicio source);
		

		/// <summary>
        /// Modifica una instancia de TiposServicio en la base de datos
        /// </summary>
        /// <param name="source">TiposServicio a modificar</param>
        /// <returns>Número de TiposServicio modificados</returns>
		int UpdateTiposServicio(TiposServicio source);

		/// <summary>
        /// Borra una instancia de TiposServicio en la base de datos
        /// </summary>
        /// <param name="source">TiposServicio a borrar</param>
        /// <returns>Número de TiposServicio borrados</returns>
		Task<int> DeleteTiposServicioAsync(TiposServicio source);
		
		/// <summary>
        /// Borra una instancia de TiposServicio en la base de datos
        /// </summary>
        /// <param name="source">TiposServicio a borrar</param>
        /// <returns>Número de TiposServicio borrados</returns>
		int DeleteTiposServicio(TiposServicio source);
    }
}
