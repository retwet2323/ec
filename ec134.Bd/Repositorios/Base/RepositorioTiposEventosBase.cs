using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioTiposEventosBase : IRepositorioTiposEventosBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase TiposEventos 
        /// </summary>
		public RepositorioTiposEventosBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los TiposEventos 
        /// </summary>
        /// <returns>IQueryable con todos los TiposEventos</returns>
		public IQueryable<TiposEventos> GetTiposEventos()
		{
			return _efRepository.All<TiposEventos>();
		}

        
        /// <summary>
        /// Obtener un TiposEventos por su clave primaria
        /// </summary>
		/// <param name="idTipoEvento">IdTipoEvento</param>
        /// <returns>TiposEventos   seleccionado por su clave primaria</returns>
		public async Task<TiposEventos> GetTiposEventosByPrimaryKeyAsync(int idTipoEvento)
		{
			return await _efRepository.FindAsync<TiposEventos>(x=>x.IdTipoEvento == idTipoEvento);
		}

        /// <summary>
        /// Obtener un TiposEventos por su clave primaria
        /// </summary>
		/// <param name="idTipoEvento">IdTipoEvento</param>
        /// <returns>TiposEventos  seleccionado por su clave primaria</returns>
		public TiposEventos GetTiposEventosByPrimaryKey(int idTipoEvento)
		{
			return _efRepository.Find<TiposEventos>(x=>x.IdTipoEvento == idTipoEvento);
		}




		/// <summary>
        /// Crea una instancia de TiposEventos en la base de datos
        /// </summary>
        /// <param name="source">TiposEventos a crear</param>
        /// <returns>TiposEventos creado</returns>
		public virtual async Task<TiposEventos> CreateTiposEventosAsync(TiposEventos source)
		{
			return await _efRepository.CreateAsync<TiposEventos>(source);
		}

		/// <summary>
        /// Crea una instancia de TiposEventos en la base de datos
        /// </summary>
        /// <param name="source">TiposEventos a crear</param>
        /// <returns>TiposEventos creado</returns>
		public virtual TiposEventos CreateTiposEventos(TiposEventos source)
		{
			return _efRepository.Create<TiposEventos>(source);
		}


		/// <summary>
        /// Modifica una instancia de TiposEventos en la base de datos
        /// </summary>
        /// <param name="source">TiposEventos a modificar</param>
        /// <returns>Número de TiposEventos modificados</returns>
		public async Task<int> UpdateTiposEventosAsync(TiposEventos source)
		{
			return await _efRepository.UpdateAsync<TiposEventos>(source);
		}

		/// <summary>
        /// Modifica una instancia de TiposEventos en la base de datos
        /// </summary>
        /// <param name="source">TiposEventos a modificar</param>
        /// <returns>Número de TiposEventos modificados</returns>
		public int UpdateTiposEventos(TiposEventos source)
		{
			return _efRepository.Update<TiposEventos>(source);
		}

		/// <summary>
        /// Borra una instancia de TiposEventos en la base de datos
        /// </summary>
        /// <param name="source">TiposEventos a borrar</param>
        /// <returns>Número de TiposEventos borrados</returns>
		public async Task<int> DeleteTiposEventosAsync(TiposEventos source)
		{
			return await _efRepository.DeleteAsync<TiposEventos>(source);
		}

		/// <summary>
        /// Borra una instancia de TiposEventos en la base de datos
        /// </summary>
        /// <param name="source">TiposEventos a borrar</param>
        /// <returns>Número de TiposEventos borrados</returns>
		public int DeleteTiposEventos(TiposEventos source)
		{
			return _efRepository.Delete<TiposEventos>(source);
		}
    }
}
