using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioTiposControlesBase : IRepositorioTiposControlesBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase TiposControles 
        /// </summary>
		public RepositorioTiposControlesBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los TiposControles 
        /// </summary>
        /// <returns>IQueryable con todos los TiposControles</returns>
		public IQueryable<TiposControles> GetTiposControles()
		{
			return _efRepository.All<TiposControles>();
		}

        
        /// <summary>
        /// Obtener un TiposControles por su clave primaria
        /// </summary>
		/// <param name="idTipoControl">IdTipoControl</param>
        /// <returns>TiposControles   seleccionado por su clave primaria</returns>
		public async Task<TiposControles> GetTiposControlesByPrimaryKeyAsync(int idTipoControl)
		{
			return await _efRepository.FindAsync<TiposControles>(x=>x.IdTipoControl == idTipoControl);
		}

        /// <summary>
        /// Obtener un TiposControles por su clave primaria
        /// </summary>
		/// <param name="idTipoControl">IdTipoControl</param>
        /// <returns>TiposControles  seleccionado por su clave primaria</returns>
		public TiposControles GetTiposControlesByPrimaryKey(int idTipoControl)
		{
			return _efRepository.Find<TiposControles>(x=>x.IdTipoControl == idTipoControl);
		}




		/// <summary>
        /// Crea una instancia de TiposControles en la base de datos
        /// </summary>
        /// <param name="source">TiposControles a crear</param>
        /// <returns>TiposControles creado</returns>
		public virtual async Task<TiposControles> CreateTiposControlesAsync(TiposControles source)
		{
			return await _efRepository.CreateAsync<TiposControles>(source);
		}

		/// <summary>
        /// Crea una instancia de TiposControles en la base de datos
        /// </summary>
        /// <param name="source">TiposControles a crear</param>
        /// <returns>TiposControles creado</returns>
		public virtual TiposControles CreateTiposControles(TiposControles source)
		{
			return _efRepository.Create<TiposControles>(source);
		}


		/// <summary>
        /// Modifica una instancia de TiposControles en la base de datos
        /// </summary>
        /// <param name="source">TiposControles a modificar</param>
        /// <returns>Número de TiposControles modificados</returns>
		public async Task<int> UpdateTiposControlesAsync(TiposControles source)
		{
			return await _efRepository.UpdateAsync<TiposControles>(source);
		}

		/// <summary>
        /// Modifica una instancia de TiposControles en la base de datos
        /// </summary>
        /// <param name="source">TiposControles a modificar</param>
        /// <returns>Número de TiposControles modificados</returns>
		public int UpdateTiposControles(TiposControles source)
		{
			return _efRepository.Update<TiposControles>(source);
		}

		/// <summary>
        /// Borra una instancia de TiposControles en la base de datos
        /// </summary>
        /// <param name="source">TiposControles a borrar</param>
        /// <returns>Número de TiposControles borrados</returns>
		public async Task<int> DeleteTiposControlesAsync(TiposControles source)
		{
			return await _efRepository.DeleteAsync<TiposControles>(source);
		}

		/// <summary>
        /// Borra una instancia de TiposControles en la base de datos
        /// </summary>
        /// <param name="source">TiposControles a borrar</param>
        /// <returns>Número de TiposControles borrados</returns>
		public int DeleteTiposControles(TiposControles source)
		{
			return _efRepository.Delete<TiposControles>(source);
		}
    }
}
