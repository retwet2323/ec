using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioTiposEventosBase
	{
		/// <summary>
        /// Metodo para obtener todos los TiposEventos 
        /// </summary>
        /// <returns>IQueryable con todos los TiposEventos</returns>
		IQueryable<TiposEventos> GetTiposEventos();
		
        
        /// <summary>
        /// Obtener un TiposEventos por su clave primaria
        /// </summary>
				/// <param name="idTipoEvento">IdTipoEvento</param>
		        /// <returns>TiposEventos   seleccionado por su clave primaria</returns>
		Task<TiposEventos> GetTiposEventosByPrimaryKeyAsync(int idTipoEvento);
		
        /// <summary>
        /// Obtener un TiposEventos por su clave primaria
        /// </summary>
				/// <param name="idTipoEvento">IdTipoEvento</param>
		        /// <returns>TiposEventos  seleccionado por su clave primaria</returns>
		TiposEventos GetTiposEventosByPrimaryKey(int idTipoEvento);


        


		/// <summary>
        /// Crea una instancia de TiposEventos en la base de datos
        /// </summary>
        /// <param name="source">TiposEventos a crear</param>
        /// <returns>TiposEventos creado</returns>
		Task<TiposEventos> CreateTiposEventosAsync(TiposEventos source);

		/// <summary>
        /// Crea una instancia de TiposEventos en la base de datos
        /// </summary>
        /// <param name="source">TiposEventos a crear</param>
        /// <returns>TiposEventos creado</returns>
		TiposEventos CreateTiposEventos(TiposEventos source);


		/// <summary>
        /// Modifica una instancia de TiposEventos en la base de datos
        /// </summary>
        /// <param name="source">TiposEventos a modificar</param>
        /// <returns>Número de TiposEventos modificados</returns>
		Task<int> UpdateTiposEventosAsync(TiposEventos source);
		

		/// <summary>
        /// Modifica una instancia de TiposEventos en la base de datos
        /// </summary>
        /// <param name="source">TiposEventos a modificar</param>
        /// <returns>Número de TiposEventos modificados</returns>
		int UpdateTiposEventos(TiposEventos source);

		/// <summary>
        /// Borra una instancia de TiposEventos en la base de datos
        /// </summary>
        /// <param name="source">TiposEventos a borrar</param>
        /// <returns>Número de TiposEventos borrados</returns>
		Task<int> DeleteTiposEventosAsync(TiposEventos source);
		
		/// <summary>
        /// Borra una instancia de TiposEventos en la base de datos
        /// </summary>
        /// <param name="source">TiposEventos a borrar</param>
        /// <returns>Número de TiposEventos borrados</returns>
		int DeleteTiposEventos(TiposEventos source);
    }
}
