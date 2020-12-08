using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioTiposRepositorioBase
	{
		/// <summary>
        /// Metodo para obtener todos los TiposRepositorio 
        /// </summary>
        /// <returns>IQueryable con todos los TiposRepositorio</returns>
		IQueryable<TiposRepositorio> GetTiposRepositorio();
		
        
        /// <summary>
        /// Obtener un TiposRepositorio por su clave primaria
        /// </summary>
				/// <param name="idTipoRepositorio">IdTipoRepositorio</param>
		        /// <returns>TiposRepositorio   seleccionado por su clave primaria</returns>
		Task<TiposRepositorio> GetTiposRepositorioByPrimaryKeyAsync(int idTipoRepositorio);
		
        /// <summary>
        /// Obtener un TiposRepositorio por su clave primaria
        /// </summary>
				/// <param name="idTipoRepositorio">IdTipoRepositorio</param>
		        /// <returns>TiposRepositorio  seleccionado por su clave primaria</returns>
		TiposRepositorio GetTiposRepositorioByPrimaryKey(int idTipoRepositorio);


        


		/// <summary>
        /// Crea una instancia de TiposRepositorio en la base de datos
        /// </summary>
        /// <param name="source">TiposRepositorio a crear</param>
        /// <returns>TiposRepositorio creado</returns>
		Task<TiposRepositorio> CreateTiposRepositorioAsync(TiposRepositorio source);

		/// <summary>
        /// Crea una instancia de TiposRepositorio en la base de datos
        /// </summary>
        /// <param name="source">TiposRepositorio a crear</param>
        /// <returns>TiposRepositorio creado</returns>
		TiposRepositorio CreateTiposRepositorio(TiposRepositorio source);


		/// <summary>
        /// Modifica una instancia de TiposRepositorio en la base de datos
        /// </summary>
        /// <param name="source">TiposRepositorio a modificar</param>
        /// <returns>Número de TiposRepositorio modificados</returns>
		Task<int> UpdateTiposRepositorioAsync(TiposRepositorio source);
		

		/// <summary>
        /// Modifica una instancia de TiposRepositorio en la base de datos
        /// </summary>
        /// <param name="source">TiposRepositorio a modificar</param>
        /// <returns>Número de TiposRepositorio modificados</returns>
		int UpdateTiposRepositorio(TiposRepositorio source);

		/// <summary>
        /// Borra una instancia de TiposRepositorio en la base de datos
        /// </summary>
        /// <param name="source">TiposRepositorio a borrar</param>
        /// <returns>Número de TiposRepositorio borrados</returns>
		Task<int> DeleteTiposRepositorioAsync(TiposRepositorio source);
		
		/// <summary>
        /// Borra una instancia de TiposRepositorio en la base de datos
        /// </summary>
        /// <param name="source">TiposRepositorio a borrar</param>
        /// <returns>Número de TiposRepositorio borrados</returns>
		int DeleteTiposRepositorio(TiposRepositorio source);
    }
}
