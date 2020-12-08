using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioTiposRepositorioBase : IRepositorioTiposRepositorioBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase TiposRepositorio 
        /// </summary>
		public RepositorioTiposRepositorioBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los TiposRepositorio 
        /// </summary>
        /// <returns>IQueryable con todos los TiposRepositorio</returns>
		public IQueryable<TiposRepositorio> GetTiposRepositorio()
		{
			return _efRepository.All<TiposRepositorio>();
		}

        
        /// <summary>
        /// Obtener un TiposRepositorio por su clave primaria
        /// </summary>
		/// <param name="idTipoRepositorio">IdTipoRepositorio</param>
        /// <returns>TiposRepositorio   seleccionado por su clave primaria</returns>
		public async Task<TiposRepositorio> GetTiposRepositorioByPrimaryKeyAsync(int idTipoRepositorio)
		{
			return await _efRepository.FindAsync<TiposRepositorio>(x=>x.IdTipoRepositorio == idTipoRepositorio);
		}

        /// <summary>
        /// Obtener un TiposRepositorio por su clave primaria
        /// </summary>
		/// <param name="idTipoRepositorio">IdTipoRepositorio</param>
        /// <returns>TiposRepositorio  seleccionado por su clave primaria</returns>
		public TiposRepositorio GetTiposRepositorioByPrimaryKey(int idTipoRepositorio)
		{
			return _efRepository.Find<TiposRepositorio>(x=>x.IdTipoRepositorio == idTipoRepositorio);
		}




		/// <summary>
        /// Crea una instancia de TiposRepositorio en la base de datos
        /// </summary>
        /// <param name="source">TiposRepositorio a crear</param>
        /// <returns>TiposRepositorio creado</returns>
		public virtual async Task<TiposRepositorio> CreateTiposRepositorioAsync(TiposRepositorio source)
		{
			return await _efRepository.CreateAsync<TiposRepositorio>(source);
		}

		/// <summary>
        /// Crea una instancia de TiposRepositorio en la base de datos
        /// </summary>
        /// <param name="source">TiposRepositorio a crear</param>
        /// <returns>TiposRepositorio creado</returns>
		public virtual TiposRepositorio CreateTiposRepositorio(TiposRepositorio source)
		{
			return _efRepository.Create<TiposRepositorio>(source);
		}


		/// <summary>
        /// Modifica una instancia de TiposRepositorio en la base de datos
        /// </summary>
        /// <param name="source">TiposRepositorio a modificar</param>
        /// <returns>Número de TiposRepositorio modificados</returns>
		public async Task<int> UpdateTiposRepositorioAsync(TiposRepositorio source)
		{
			return await _efRepository.UpdateAsync<TiposRepositorio>(source);
		}

		/// <summary>
        /// Modifica una instancia de TiposRepositorio en la base de datos
        /// </summary>
        /// <param name="source">TiposRepositorio a modificar</param>
        /// <returns>Número de TiposRepositorio modificados</returns>
		public int UpdateTiposRepositorio(TiposRepositorio source)
		{
			return _efRepository.Update<TiposRepositorio>(source);
		}

		/// <summary>
        /// Borra una instancia de TiposRepositorio en la base de datos
        /// </summary>
        /// <param name="source">TiposRepositorio a borrar</param>
        /// <returns>Número de TiposRepositorio borrados</returns>
		public async Task<int> DeleteTiposRepositorioAsync(TiposRepositorio source)
		{
			return await _efRepository.DeleteAsync<TiposRepositorio>(source);
		}

		/// <summary>
        /// Borra una instancia de TiposRepositorio en la base de datos
        /// </summary>
        /// <param name="source">TiposRepositorio a borrar</param>
        /// <returns>Número de TiposRepositorio borrados</returns>
		public int DeleteTiposRepositorio(TiposRepositorio source)
		{
			return _efRepository.Delete<TiposRepositorio>(source);
		}
    }
}
