using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioTiposContenedoresBase : IRepositorioTiposContenedoresBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase TiposContenedores 
        /// </summary>
		public RepositorioTiposContenedoresBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los TiposContenedores 
        /// </summary>
        /// <returns>IQueryable con todos los TiposContenedores</returns>
		public IQueryable<TiposContenedores> GetTiposContenedores()
		{
			return _efRepository.All<TiposContenedores>();
		}

        
        /// <summary>
        /// Obtener un TiposContenedores por su clave primaria
        /// </summary>
		/// <param name="idTipoContenedor">IdTipoContenedor</param>
        /// <returns>TiposContenedores   seleccionado por su clave primaria</returns>
		public async Task<TiposContenedores> GetTiposContenedoresByPrimaryKeyAsync(int idTipoContenedor)
		{
			return await _efRepository.FindAsync<TiposContenedores>(x=>x.IdTipoContenedor == idTipoContenedor);
		}

        /// <summary>
        /// Obtener un TiposContenedores por su clave primaria
        /// </summary>
		/// <param name="idTipoContenedor">IdTipoContenedor</param>
        /// <returns>TiposContenedores  seleccionado por su clave primaria</returns>
		public TiposContenedores GetTiposContenedoresByPrimaryKey(int idTipoContenedor)
		{
			return _efRepository.Find<TiposContenedores>(x=>x.IdTipoContenedor == idTipoContenedor);
		}




		/// <summary>
        /// Crea una instancia de TiposContenedores en la base de datos
        /// </summary>
        /// <param name="source">TiposContenedores a crear</param>
        /// <returns>TiposContenedores creado</returns>
		public virtual async Task<TiposContenedores> CreateTiposContenedoresAsync(TiposContenedores source)
		{
			return await _efRepository.CreateAsync<TiposContenedores>(source);
		}

		/// <summary>
        /// Crea una instancia de TiposContenedores en la base de datos
        /// </summary>
        /// <param name="source">TiposContenedores a crear</param>
        /// <returns>TiposContenedores creado</returns>
		public virtual TiposContenedores CreateTiposContenedores(TiposContenedores source)
		{
			return _efRepository.Create<TiposContenedores>(source);
		}


		/// <summary>
        /// Modifica una instancia de TiposContenedores en la base de datos
        /// </summary>
        /// <param name="source">TiposContenedores a modificar</param>
        /// <returns>Número de TiposContenedores modificados</returns>
		public async Task<int> UpdateTiposContenedoresAsync(TiposContenedores source)
		{
			return await _efRepository.UpdateAsync<TiposContenedores>(source);
		}

		/// <summary>
        /// Modifica una instancia de TiposContenedores en la base de datos
        /// </summary>
        /// <param name="source">TiposContenedores a modificar</param>
        /// <returns>Número de TiposContenedores modificados</returns>
		public int UpdateTiposContenedores(TiposContenedores source)
		{
			return _efRepository.Update<TiposContenedores>(source);
		}

		/// <summary>
        /// Borra una instancia de TiposContenedores en la base de datos
        /// </summary>
        /// <param name="source">TiposContenedores a borrar</param>
        /// <returns>Número de TiposContenedores borrados</returns>
		public async Task<int> DeleteTiposContenedoresAsync(TiposContenedores source)
		{
			return await _efRepository.DeleteAsync<TiposContenedores>(source);
		}

		/// <summary>
        /// Borra una instancia de TiposContenedores en la base de datos
        /// </summary>
        /// <param name="source">TiposContenedores a borrar</param>
        /// <returns>Número de TiposContenedores borrados</returns>
		public int DeleteTiposContenedores(TiposContenedores source)
		{
			return _efRepository.Delete<TiposContenedores>(source);
		}
    }
}
