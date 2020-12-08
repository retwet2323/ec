using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioEventosBase : IRepositorioEventosBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase Eventos 
        /// </summary>
		public RepositorioEventosBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los Eventos 
        /// </summary>
        /// <returns>IQueryable con todos los Eventos</returns>
		public IQueryable<Eventos> GetEventos()
		{
			return _efRepository.All<Eventos>();
		}

        
        /// <summary>
        /// Obtener un Eventos por su clave primaria
        /// </summary>
		/// <param name="idEvento">IdEvento</param>
        /// <returns>Eventos   seleccionado por su clave primaria</returns>
		public async Task<Eventos> GetEventosByPrimaryKeyAsync(int idEvento)
		{
			return await _efRepository.FindAsync<Eventos>(x=>x.IdEvento == idEvento);
		}

        /// <summary>
        /// Obtener un Eventos por su clave primaria
        /// </summary>
		/// <param name="idEvento">IdEvento</param>
        /// <returns>Eventos  seleccionado por su clave primaria</returns>
		public Eventos GetEventosByPrimaryKey(int idEvento)
		{
			return _efRepository.Find<Eventos>(x=>x.IdEvento == idEvento);
		}


        /// <summary>
        /// Obtener un IQueryable<Eventos> por su IdFormularioPrecedente 
        /// </summary>
		/// <param name="idFormularioPrecedente">IdFormularioPrecedente</param>
        /// <returns>IQueryable con los Eventos seleccionado por su IdFormularioPrecedente </returns>
		public IQueryable<Eventos> GetEventosByIdFormularioPrecedente(int idFormularioPrecedente)
		{
			return _efRepository.Filter<Eventos>(x=> x.IdFormularioPrecedente == idFormularioPrecedente);
		}


		/// <summary>
        /// Crea una instancia de Eventos en la base de datos
        /// </summary>
        /// <param name="source">Eventos a crear</param>
        /// <returns>Eventos creado</returns>
		public virtual async Task<Eventos> CreateEventosAsync(Eventos source)
		{
			return await _efRepository.CreateAsync<Eventos>(source);
		}

		/// <summary>
        /// Crea una instancia de Eventos en la base de datos
        /// </summary>
        /// <param name="source">Eventos a crear</param>
        /// <returns>Eventos creado</returns>
		public virtual Eventos CreateEventos(Eventos source)
		{
			return _efRepository.Create<Eventos>(source);
		}


		/// <summary>
        /// Modifica una instancia de Eventos en la base de datos
        /// </summary>
        /// <param name="source">Eventos a modificar</param>
        /// <returns>Número de Eventos modificados</returns>
		public async Task<int> UpdateEventosAsync(Eventos source)
		{
			return await _efRepository.UpdateAsync<Eventos>(source);
		}

		/// <summary>
        /// Modifica una instancia de Eventos en la base de datos
        /// </summary>
        /// <param name="source">Eventos a modificar</param>
        /// <returns>Número de Eventos modificados</returns>
		public int UpdateEventos(Eventos source)
		{
			return _efRepository.Update<Eventos>(source);
		}

		/// <summary>
        /// Borra una instancia de Eventos en la base de datos
        /// </summary>
        /// <param name="source">Eventos a borrar</param>
        /// <returns>Número de Eventos borrados</returns>
		public async Task<int> DeleteEventosAsync(Eventos source)
		{
			return await _efRepository.DeleteAsync<Eventos>(source);
		}

		/// <summary>
        /// Borra una instancia de Eventos en la base de datos
        /// </summary>
        /// <param name="source">Eventos a borrar</param>
        /// <returns>Número de Eventos borrados</returns>
		public int DeleteEventos(Eventos source)
		{
			return _efRepository.Delete<Eventos>(source);
		}
    }
}
