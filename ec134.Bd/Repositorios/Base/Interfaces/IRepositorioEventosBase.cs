using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioEventosBase
	{
		/// <summary>
        /// Metodo para obtener todos los Eventos 
        /// </summary>
        /// <returns>IQueryable con todos los Eventos</returns>
		IQueryable<Eventos> GetEventos();
		
        
        /// <summary>
        /// Obtener un Eventos por su clave primaria
        /// </summary>
				/// <param name="idEvento">IdEvento</param>
		        /// <returns>Eventos   seleccionado por su clave primaria</returns>
		Task<Eventos> GetEventosByPrimaryKeyAsync(int idEvento);
		
        /// <summary>
        /// Obtener un Eventos por su clave primaria
        /// </summary>
				/// <param name="idEvento">IdEvento</param>
		        /// <returns>Eventos  seleccionado por su clave primaria</returns>
		Eventos GetEventosByPrimaryKey(int idEvento);


        

        /// <summary>
        /// Obtener un IQueryable<Eventos> por su IdFormularioPrecedente 
        /// </summary>
		/// <param name="idFormularioPrecedente">IdFormularioPrecedente</param>
        /// <returns>IQueryable con los Eventos seleccionado por su IdFormularioPrecedente </returns>
        IQueryable<Eventos> GetEventosByIdFormularioPrecedente(int idFormularioPrecedente);


		/// <summary>
        /// Crea una instancia de Eventos en la base de datos
        /// </summary>
        /// <param name="source">Eventos a crear</param>
        /// <returns>Eventos creado</returns>
		Task<Eventos> CreateEventosAsync(Eventos source);

		/// <summary>
        /// Crea una instancia de Eventos en la base de datos
        /// </summary>
        /// <param name="source">Eventos a crear</param>
        /// <returns>Eventos creado</returns>
		Eventos CreateEventos(Eventos source);


		/// <summary>
        /// Modifica una instancia de Eventos en la base de datos
        /// </summary>
        /// <param name="source">Eventos a modificar</param>
        /// <returns>Número de Eventos modificados</returns>
		Task<int> UpdateEventosAsync(Eventos source);
		

		/// <summary>
        /// Modifica una instancia de Eventos en la base de datos
        /// </summary>
        /// <param name="source">Eventos a modificar</param>
        /// <returns>Número de Eventos modificados</returns>
		int UpdateEventos(Eventos source);

		/// <summary>
        /// Borra una instancia de Eventos en la base de datos
        /// </summary>
        /// <param name="source">Eventos a borrar</param>
        /// <returns>Número de Eventos borrados</returns>
		Task<int> DeleteEventosAsync(Eventos source);
		
		/// <summary>
        /// Borra una instancia de Eventos en la base de datos
        /// </summary>
        /// <param name="source">Eventos a borrar</param>
        /// <returns>Número de Eventos borrados</returns>
		int DeleteEventos(Eventos source);
    }
}
