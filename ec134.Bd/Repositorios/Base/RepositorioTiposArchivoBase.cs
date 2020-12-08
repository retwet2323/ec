using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioTiposArchivoBase : IRepositorioTiposArchivoBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase TiposArchivo 
        /// </summary>
		public RepositorioTiposArchivoBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los TiposArchivo 
        /// </summary>
        /// <returns>IQueryable con todos los TiposArchivo</returns>
		public IQueryable<TiposArchivo> GetTiposArchivo()
		{
			return _efRepository.All<TiposArchivo>();
		}

        
        /// <summary>
        /// Obtener un TiposArchivo por su clave primaria
        /// </summary>
		/// <param name="idTipoArchivo">IdTipoArchivo</param>
        /// <returns>TiposArchivo   seleccionado por su clave primaria</returns>
		public async Task<TiposArchivo> GetTiposArchivoByPrimaryKeyAsync(int idTipoArchivo)
		{
			return await _efRepository.FindAsync<TiposArchivo>(x=>x.IdTipoArchivo == idTipoArchivo);
		}

        /// <summary>
        /// Obtener un TiposArchivo por su clave primaria
        /// </summary>
		/// <param name="idTipoArchivo">IdTipoArchivo</param>
        /// <returns>TiposArchivo  seleccionado por su clave primaria</returns>
		public TiposArchivo GetTiposArchivoByPrimaryKey(int idTipoArchivo)
		{
			return _efRepository.Find<TiposArchivo>(x=>x.IdTipoArchivo == idTipoArchivo);
		}




		/// <summary>
        /// Crea una instancia de TiposArchivo en la base de datos
        /// </summary>
        /// <param name="source">TiposArchivo a crear</param>
        /// <returns>TiposArchivo creado</returns>
		public virtual async Task<TiposArchivo> CreateTiposArchivoAsync(TiposArchivo source)
		{
			return await _efRepository.CreateAsync<TiposArchivo>(source);
		}

		/// <summary>
        /// Crea una instancia de TiposArchivo en la base de datos
        /// </summary>
        /// <param name="source">TiposArchivo a crear</param>
        /// <returns>TiposArchivo creado</returns>
		public virtual TiposArchivo CreateTiposArchivo(TiposArchivo source)
		{
			return _efRepository.Create<TiposArchivo>(source);
		}


		/// <summary>
        /// Modifica una instancia de TiposArchivo en la base de datos
        /// </summary>
        /// <param name="source">TiposArchivo a modificar</param>
        /// <returns>Número de TiposArchivo modificados</returns>
		public async Task<int> UpdateTiposArchivoAsync(TiposArchivo source)
		{
			return await _efRepository.UpdateAsync<TiposArchivo>(source);
		}

		/// <summary>
        /// Modifica una instancia de TiposArchivo en la base de datos
        /// </summary>
        /// <param name="source">TiposArchivo a modificar</param>
        /// <returns>Número de TiposArchivo modificados</returns>
		public int UpdateTiposArchivo(TiposArchivo source)
		{
			return _efRepository.Update<TiposArchivo>(source);
		}

		/// <summary>
        /// Borra una instancia de TiposArchivo en la base de datos
        /// </summary>
        /// <param name="source">TiposArchivo a borrar</param>
        /// <returns>Número de TiposArchivo borrados</returns>
		public async Task<int> DeleteTiposArchivoAsync(TiposArchivo source)
		{
			return await _efRepository.DeleteAsync<TiposArchivo>(source);
		}

		/// <summary>
        /// Borra una instancia de TiposArchivo en la base de datos
        /// </summary>
        /// <param name="source">TiposArchivo a borrar</param>
        /// <returns>Número de TiposArchivo borrados</returns>
		public int DeleteTiposArchivo(TiposArchivo source)
		{
			return _efRepository.Delete<TiposArchivo>(source);
		}
    }
}
