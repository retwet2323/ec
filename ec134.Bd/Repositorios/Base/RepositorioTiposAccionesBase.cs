using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioTiposAccionesBase : IRepositorioTiposAccionesBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase TiposAcciones 
        /// </summary>
		public RepositorioTiposAccionesBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los TiposAcciones 
        /// </summary>
        /// <returns>IQueryable con todos los TiposAcciones</returns>
		public IQueryable<TiposAcciones> GetTiposAcciones()
		{
			return _efRepository.All<TiposAcciones>();
		}

        
        /// <summary>
        /// Obtener un TiposAcciones por su clave primaria
        /// </summary>
		/// <param name="idTipoAccion">IdTipoAccion</param>
        /// <returns>TiposAcciones   seleccionado por su clave primaria</returns>
		public async Task<TiposAcciones> GetTiposAccionesByPrimaryKeyAsync(int idTipoAccion)
		{
			return await _efRepository.FindAsync<TiposAcciones>(x=>x.IdTipoAccion == idTipoAccion);
		}

        /// <summary>
        /// Obtener un TiposAcciones por su clave primaria
        /// </summary>
		/// <param name="idTipoAccion">IdTipoAccion</param>
        /// <returns>TiposAcciones  seleccionado por su clave primaria</returns>
		public TiposAcciones GetTiposAccionesByPrimaryKey(int idTipoAccion)
		{
			return _efRepository.Find<TiposAcciones>(x=>x.IdTipoAccion == idTipoAccion);
		}




		/// <summary>
        /// Crea una instancia de TiposAcciones en la base de datos
        /// </summary>
        /// <param name="source">TiposAcciones a crear</param>
        /// <returns>TiposAcciones creado</returns>
		public virtual async Task<TiposAcciones> CreateTiposAccionesAsync(TiposAcciones source)
		{
			return await _efRepository.CreateAsync<TiposAcciones>(source);
		}

		/// <summary>
        /// Crea una instancia de TiposAcciones en la base de datos
        /// </summary>
        /// <param name="source">TiposAcciones a crear</param>
        /// <returns>TiposAcciones creado</returns>
		public virtual TiposAcciones CreateTiposAcciones(TiposAcciones source)
		{
			return _efRepository.Create<TiposAcciones>(source);
		}


		/// <summary>
        /// Modifica una instancia de TiposAcciones en la base de datos
        /// </summary>
        /// <param name="source">TiposAcciones a modificar</param>
        /// <returns>Número de TiposAcciones modificados</returns>
		public async Task<int> UpdateTiposAccionesAsync(TiposAcciones source)
		{
			return await _efRepository.UpdateAsync<TiposAcciones>(source);
		}

		/// <summary>
        /// Modifica una instancia de TiposAcciones en la base de datos
        /// </summary>
        /// <param name="source">TiposAcciones a modificar</param>
        /// <returns>Número de TiposAcciones modificados</returns>
		public int UpdateTiposAcciones(TiposAcciones source)
		{
			return _efRepository.Update<TiposAcciones>(source);
		}

		/// <summary>
        /// Borra una instancia de TiposAcciones en la base de datos
        /// </summary>
        /// <param name="source">TiposAcciones a borrar</param>
        /// <returns>Número de TiposAcciones borrados</returns>
		public async Task<int> DeleteTiposAccionesAsync(TiposAcciones source)
		{
			return await _efRepository.DeleteAsync<TiposAcciones>(source);
		}

		/// <summary>
        /// Borra una instancia de TiposAcciones en la base de datos
        /// </summary>
        /// <param name="source">TiposAcciones a borrar</param>
        /// <returns>Número de TiposAcciones borrados</returns>
		public int DeleteTiposAcciones(TiposAcciones source)
		{
			return _efRepository.Delete<TiposAcciones>(source);
		}
    }
}
