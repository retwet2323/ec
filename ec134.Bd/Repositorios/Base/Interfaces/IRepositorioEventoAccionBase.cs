using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioEventoAccionBase
	{
		/// <summary>
        /// Metodo para obtener todos los EventoAccion 
        /// </summary>
        /// <returns>IQueryable con todos los EventoAccion</returns>
		IQueryable<EventoAccion> GetEventoAccion();
		
        
        /// <summary>
        /// Obtener un EventoAccion por su clave primaria
        /// </summary>
				/// <param name="idEvento">IdEvento</param>
				/// <param name="idAccion">IdAccion</param>
		        /// <returns>EventoAccion   seleccionado por su clave primaria</returns>
		Task<EventoAccion> GetEventoAccionByPrimaryKeyAsync(int idEvento,int idAccion);
		
        /// <summary>
        /// Obtener un EventoAccion por su clave primaria
        /// </summary>
				/// <param name="idEvento">IdEvento</param>
				/// <param name="idAccion">IdAccion</param>
		        /// <returns>EventoAccion  seleccionado por su clave primaria</returns>
		EventoAccion GetEventoAccionByPrimaryKey(int idEvento,int idAccion);


        

        /// <summary>
        /// Obtener un IQueryable<EventoAccion> por su IdEvento 
        /// </summary>
		/// <param name="idEvento">IdEvento</param>
        /// <returns>IQueryable con los EventoAccion seleccionado por su IdEvento </returns>
        IQueryable<EventoAccion> GetEventoAccionByIdEvento(int idEvento);

        /// <summary>
        /// Obtener un IQueryable<EventoAccion> por su IdAccion 
        /// </summary>
		/// <param name="idAccion">IdAccion</param>
        /// <returns>IQueryable con los EventoAccion seleccionado por su IdAccion </returns>
        IQueryable<EventoAccion> GetEventoAccionByIdAccion(int idAccion);


		/// <summary>
        /// Crea una instancia de EventoAccion en la base de datos
        /// </summary>
        /// <param name="source">EventoAccion a crear</param>
        /// <returns>EventoAccion creado</returns>
		Task<EventoAccion> CreateEventoAccionAsync(EventoAccion source);

		/// <summary>
        /// Crea una instancia de EventoAccion en la base de datos
        /// </summary>
        /// <param name="source">EventoAccion a crear</param>
        /// <returns>EventoAccion creado</returns>
		EventoAccion CreateEventoAccion(EventoAccion source);


		/// <summary>
        /// Modifica una instancia de EventoAccion en la base de datos
        /// </summary>
        /// <param name="source">EventoAccion a modificar</param>
        /// <returns>Número de EventoAccion modificados</returns>
		Task<int> UpdateEventoAccionAsync(EventoAccion source);
		

		/// <summary>
        /// Modifica una instancia de EventoAccion en la base de datos
        /// </summary>
        /// <param name="source">EventoAccion a modificar</param>
        /// <returns>Número de EventoAccion modificados</returns>
		int UpdateEventoAccion(EventoAccion source);

		/// <summary>
        /// Borra una instancia de EventoAccion en la base de datos
        /// </summary>
        /// <param name="source">EventoAccion a borrar</param>
        /// <returns>Número de EventoAccion borrados</returns>
		Task<int> DeleteEventoAccionAsync(EventoAccion source);
		
		/// <summary>
        /// Borra una instancia de EventoAccion en la base de datos
        /// </summary>
        /// <param name="source">EventoAccion a borrar</param>
        /// <returns>Número de EventoAccion borrados</returns>
		int DeleteEventoAccion(EventoAccion source);
    }
}
