using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioMimeTypesBase : IRepositorioMimeTypesBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase MimeTypes 
        /// </summary>
		public RepositorioMimeTypesBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los MimeTypes 
        /// </summary>
        /// <returns>IQueryable con todos los MimeTypes</returns>
		public IQueryable<MimeTypes> GetMimeTypes()
		{
			return _efRepository.All<MimeTypes>();
		}

        
        /// <summary>
        /// Obtener un MimeTypes por su clave primaria
        /// </summary>
		/// <param name="idMimeType">IdMimeType</param>
        /// <returns>MimeTypes   seleccionado por su clave primaria</returns>
		public async Task<MimeTypes> GetMimeTypesByPrimaryKeyAsync(int idMimeType)
		{
			return await _efRepository.FindAsync<MimeTypes>(x=>x.IdMimeType == idMimeType);
		}

        /// <summary>
        /// Obtener un MimeTypes por su clave primaria
        /// </summary>
		/// <param name="idMimeType">IdMimeType</param>
        /// <returns>MimeTypes  seleccionado por su clave primaria</returns>
		public MimeTypes GetMimeTypesByPrimaryKey(int idMimeType)
		{
			return _efRepository.Find<MimeTypes>(x=>x.IdMimeType == idMimeType);
		}


        /// <summary>
        /// Obtener un IQueryable<MimeTypes> por su IdTipoArchivo 
        /// </summary>
		/// <param name="idTipoArchivo">IdTipoArchivo</param>
        /// <returns>IQueryable con los MimeTypes seleccionado por su IdTipoArchivo </returns>
		public IQueryable<MimeTypes> GetMimeTypesByIdTipoArchivo(int? idTipoArchivo)
		{
			return _efRepository.Filter<MimeTypes>(x=> x.IdTipoArchivo == idTipoArchivo);
		}


		/// <summary>
        /// Crea una instancia de MimeTypes en la base de datos
        /// </summary>
        /// <param name="source">MimeTypes a crear</param>
        /// <returns>MimeTypes creado</returns>
		public virtual async Task<MimeTypes> CreateMimeTypesAsync(MimeTypes source)
		{
			return await _efRepository.CreateAsync<MimeTypes>(source);
		}

		/// <summary>
        /// Crea una instancia de MimeTypes en la base de datos
        /// </summary>
        /// <param name="source">MimeTypes a crear</param>
        /// <returns>MimeTypes creado</returns>
		public virtual MimeTypes CreateMimeTypes(MimeTypes source)
		{
			return _efRepository.Create<MimeTypes>(source);
		}


		/// <summary>
        /// Modifica una instancia de MimeTypes en la base de datos
        /// </summary>
        /// <param name="source">MimeTypes a modificar</param>
        /// <returns>Número de MimeTypes modificados</returns>
		public async Task<int> UpdateMimeTypesAsync(MimeTypes source)
		{
			return await _efRepository.UpdateAsync<MimeTypes>(source);
		}

		/// <summary>
        /// Modifica una instancia de MimeTypes en la base de datos
        /// </summary>
        /// <param name="source">MimeTypes a modificar</param>
        /// <returns>Número de MimeTypes modificados</returns>
		public int UpdateMimeTypes(MimeTypes source)
		{
			return _efRepository.Update<MimeTypes>(source);
		}

		/// <summary>
        /// Borra una instancia de MimeTypes en la base de datos
        /// </summary>
        /// <param name="source">MimeTypes a borrar</param>
        /// <returns>Número de MimeTypes borrados</returns>
		public async Task<int> DeleteMimeTypesAsync(MimeTypes source)
		{
			return await _efRepository.DeleteAsync<MimeTypes>(source);
		}

		/// <summary>
        /// Borra una instancia de MimeTypes en la base de datos
        /// </summary>
        /// <param name="source">MimeTypes a borrar</param>
        /// <returns>Número de MimeTypes borrados</returns>
		public int DeleteMimeTypes(MimeTypes source)
		{
			return _efRepository.Delete<MimeTypes>(source);
		}
    }
}
