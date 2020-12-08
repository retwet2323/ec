using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioTiposContenedoresBase
	{
		/// <summary>
        /// Metodo para obtener todos los TiposContenedores 
        /// </summary>
        /// <returns>IQueryable con todos los TiposContenedores</returns>
		IQueryable<TiposContenedores> GetTiposContenedores();
		
        
        /// <summary>
        /// Obtener un TiposContenedores por su clave primaria
        /// </summary>
				/// <param name="idTipoContenedor">IdTipoContenedor</param>
		        /// <returns>TiposContenedores   seleccionado por su clave primaria</returns>
		Task<TiposContenedores> GetTiposContenedoresByPrimaryKeyAsync(int idTipoContenedor);
		
        /// <summary>
        /// Obtener un TiposContenedores por su clave primaria
        /// </summary>
				/// <param name="idTipoContenedor">IdTipoContenedor</param>
		        /// <returns>TiposContenedores  seleccionado por su clave primaria</returns>
		TiposContenedores GetTiposContenedoresByPrimaryKey(int idTipoContenedor);


        


		/// <summary>
        /// Crea una instancia de TiposContenedores en la base de datos
        /// </summary>
        /// <param name="source">TiposContenedores a crear</param>
        /// <returns>TiposContenedores creado</returns>
		Task<TiposContenedores> CreateTiposContenedoresAsync(TiposContenedores source);

		/// <summary>
        /// Crea una instancia de TiposContenedores en la base de datos
        /// </summary>
        /// <param name="source">TiposContenedores a crear</param>
        /// <returns>TiposContenedores creado</returns>
		TiposContenedores CreateTiposContenedores(TiposContenedores source);


		/// <summary>
        /// Modifica una instancia de TiposContenedores en la base de datos
        /// </summary>
        /// <param name="source">TiposContenedores a modificar</param>
        /// <returns>Número de TiposContenedores modificados</returns>
		Task<int> UpdateTiposContenedoresAsync(TiposContenedores source);
		

		/// <summary>
        /// Modifica una instancia de TiposContenedores en la base de datos
        /// </summary>
        /// <param name="source">TiposContenedores a modificar</param>
        /// <returns>Número de TiposContenedores modificados</returns>
		int UpdateTiposContenedores(TiposContenedores source);

		/// <summary>
        /// Borra una instancia de TiposContenedores en la base de datos
        /// </summary>
        /// <param name="source">TiposContenedores a borrar</param>
        /// <returns>Número de TiposContenedores borrados</returns>
		Task<int> DeleteTiposContenedoresAsync(TiposContenedores source);
		
		/// <summary>
        /// Borra una instancia de TiposContenedores en la base de datos
        /// </summary>
        /// <param name="source">TiposContenedores a borrar</param>
        /// <returns>Número de TiposContenedores borrados</returns>
		int DeleteTiposContenedores(TiposContenedores source);
    }
}
