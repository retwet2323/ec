using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioEventoAccionBase : IRepositorioEventoAccionBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase EventoAccion 
        /// </summary>
		public RepositorioEventoAccionBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los EventoAccion 
        /// </summary>
        /// <returns>IQueryable con todos los EventoAccion</returns>
		public IQueryable<EventoAccion> GetEventoAccion()
		{
			return _efRepository.All<EventoAccion>();
		}

        
        /// <summary>
        /// Obtener un EventoAccion por su clave primaria
        /// </summary>
		/// <param name="idEvento">IdEvento</param>
		/// <param name="idAccion">IdAccion</param>
        /// <returns>EventoAccion   seleccionado por su clave primaria</returns>
		public async Task<EventoAccion> GetEventoAccionByPrimaryKeyAsync(int idEvento, int idAccion)
		{
			return await _efRepository.FindAsync<EventoAccion>(x=>x.IdEvento == idEvento && x.IdAccion == idAccion);
		}

        /// <summary>
        /// Obtener un EventoAccion por su clave primaria
        /// </summary>
		/// <param name="idEvento">IdEvento</param>
		/// <param name="idAccion">IdAccion</param>
        /// <returns>EventoAccion  seleccionado por su clave primaria</returns>
		public EventoAccion GetEventoAccionByPrimaryKey(int idEvento, int idAccion)
		{
			return _efRepository.Find<EventoAccion>(x=>x.IdEvento == idEvento && x.IdAccion == idAccion);
		}


        /// <summary>
        /// Obtener un IQueryable<EventoAccion> por su IdEvento 
        /// </summary>
		/// <param name="idEvento">IdEvento</param>
        /// <returns>IQueryable con los EventoAccion seleccionado por su IdEvento </returns>
		public IQueryable<EventoAccion> GetEventoAccionByIdEvento(int idEvento)
		{
			return _efRepository.Filter<EventoAccion>(x=> x.IdEvento == idEvento);
		}
        /// <summary>
        /// Obtener un IQueryable<EventoAccion> por su IdAccion 
        /// </summary>
		/// <param name="idAccion">IdAccion</param>
        /// <returns>IQueryable con los EventoAccion seleccionado por su IdAccion </returns>
		public IQueryable<EventoAccion> GetEventoAccionByIdAccion(int idAccion)
		{
			return _efRepository.Filter<EventoAccion>(x=> x.IdAccion == idAccion);
		}


		/// <summary>
        /// Crea una instancia de EventoAccion en la base de datos
        /// </summary>
        /// <param name="source">EventoAccion a crear</param>
        /// <returns>EventoAccion creado</returns>
		public virtual async Task<EventoAccion> CreateEventoAccionAsync(EventoAccion source)
		{
			return await _efRepository.CreateAsync<EventoAccion>(source);
		}

		/// <summary>
        /// Crea una instancia de EventoAccion en la base de datos
        /// </summary>
        /// <param name="source">EventoAccion a crear</param>
        /// <returns>EventoAccion creado</returns>
		public virtual EventoAccion CreateEventoAccion(EventoAccion source)
		{
			return _efRepository.Create<EventoAccion>(source);
		}


		/// <summary>
        /// Modifica una instancia de EventoAccion en la base de datos
        /// </summary>
        /// <param name="source">EventoAccion a modificar</param>
        /// <returns>Número de EventoAccion modificados</returns>
		public async Task<int> UpdateEventoAccionAsync(EventoAccion source)
		{
			return await _efRepository.UpdateAsync<EventoAccion>(source);
		}

		/// <summary>
        /// Modifica una instancia de EventoAccion en la base de datos
        /// </summary>
        /// <param name="source">EventoAccion a modificar</param>
        /// <returns>Número de EventoAccion modificados</returns>
		public int UpdateEventoAccion(EventoAccion source)
		{
			return _efRepository.Update<EventoAccion>(source);
		}

		/// <summary>
        /// Borra una instancia de EventoAccion en la base de datos
        /// </summary>
        /// <param name="source">EventoAccion a borrar</param>
        /// <returns>Número de EventoAccion borrados</returns>
		public async Task<int> DeleteEventoAccionAsync(EventoAccion source)
		{
			return await _efRepository.DeleteAsync<EventoAccion>(source);
		}

		/// <summary>
        /// Borra una instancia de EventoAccion en la base de datos
        /// </summary>
        /// <param name="source">EventoAccion a borrar</param>
        /// <returns>Número de EventoAccion borrados</returns>
		public int DeleteEventoAccion(EventoAccion source)
		{
			return _efRepository.Delete<EventoAccion>(source);
		}
    }
}
