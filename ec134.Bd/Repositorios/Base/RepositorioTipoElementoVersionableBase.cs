using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioTipoElementoVersionableBase : IRepositorioTipoElementoVersionableBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase TipoElementoVersionable 
        /// </summary>
		public RepositorioTipoElementoVersionableBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los TipoElementoVersionable 
        /// </summary>
        /// <returns>IQueryable con todos los TipoElementoVersionable</returns>
		public IQueryable<TipoElementoVersionable> GetTipoElementoVersionable()
		{
			return _efRepository.All<TipoElementoVersionable>();
		}

        
        /// <summary>
        /// Obtener un TipoElementoVersionable por su clave primaria
        /// </summary>
		/// <param name="idTipoElementoVersionable">IdTipoElementoVersionable</param>
        /// <returns>TipoElementoVersionable   seleccionado por su clave primaria</returns>
		public async Task<TipoElementoVersionable> GetTipoElementoVersionableByPrimaryKeyAsync(int idTipoElementoVersionable)
		{
			return await _efRepository.FindAsync<TipoElementoVersionable>(x=>x.IdTipoElementoVersionable == idTipoElementoVersionable);
		}

        /// <summary>
        /// Obtener un TipoElementoVersionable por su clave primaria
        /// </summary>
		/// <param name="idTipoElementoVersionable">IdTipoElementoVersionable</param>
        /// <returns>TipoElementoVersionable  seleccionado por su clave primaria</returns>
		public TipoElementoVersionable GetTipoElementoVersionableByPrimaryKey(int idTipoElementoVersionable)
		{
			return _efRepository.Find<TipoElementoVersionable>(x=>x.IdTipoElementoVersionable == idTipoElementoVersionable);
		}




		/// <summary>
        /// Crea una instancia de TipoElementoVersionable en la base de datos
        /// </summary>
        /// <param name="source">TipoElementoVersionable a crear</param>
        /// <returns>TipoElementoVersionable creado</returns>
		public virtual async Task<TipoElementoVersionable> CreateTipoElementoVersionableAsync(TipoElementoVersionable source)
		{
			return await _efRepository.CreateAsync<TipoElementoVersionable>(source);
		}

		/// <summary>
        /// Crea una instancia de TipoElementoVersionable en la base de datos
        /// </summary>
        /// <param name="source">TipoElementoVersionable a crear</param>
        /// <returns>TipoElementoVersionable creado</returns>
		public virtual TipoElementoVersionable CreateTipoElementoVersionable(TipoElementoVersionable source)
		{
			return _efRepository.Create<TipoElementoVersionable>(source);
		}


		/// <summary>
        /// Modifica una instancia de TipoElementoVersionable en la base de datos
        /// </summary>
        /// <param name="source">TipoElementoVersionable a modificar</param>
        /// <returns>Número de TipoElementoVersionable modificados</returns>
		public async Task<int> UpdateTipoElementoVersionableAsync(TipoElementoVersionable source)
		{
			return await _efRepository.UpdateAsync<TipoElementoVersionable>(source);
		}

		/// <summary>
        /// Modifica una instancia de TipoElementoVersionable en la base de datos
        /// </summary>
        /// <param name="source">TipoElementoVersionable a modificar</param>
        /// <returns>Número de TipoElementoVersionable modificados</returns>
		public int UpdateTipoElementoVersionable(TipoElementoVersionable source)
		{
			return _efRepository.Update<TipoElementoVersionable>(source);
		}

		/// <summary>
        /// Borra una instancia de TipoElementoVersionable en la base de datos
        /// </summary>
        /// <param name="source">TipoElementoVersionable a borrar</param>
        /// <returns>Número de TipoElementoVersionable borrados</returns>
		public async Task<int> DeleteTipoElementoVersionableAsync(TipoElementoVersionable source)
		{
			return await _efRepository.DeleteAsync<TipoElementoVersionable>(source);
		}

		/// <summary>
        /// Borra una instancia de TipoElementoVersionable en la base de datos
        /// </summary>
        /// <param name="source">TipoElementoVersionable a borrar</param>
        /// <returns>Número de TipoElementoVersionable borrados</returns>
		public int DeleteTipoElementoVersionable(TipoElementoVersionable source)
		{
			return _efRepository.Delete<TipoElementoVersionable>(source);
		}
    }
}
