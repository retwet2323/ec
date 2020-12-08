using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioExtensionesBase : IRepositorioExtensionesBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase Extensiones 
        /// </summary>
		public RepositorioExtensionesBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los Extensiones 
        /// </summary>
        /// <returns>IQueryable con todos los Extensiones</returns>
		public IQueryable<Extensiones> GetExtensiones()
		{
			return _efRepository.All<Extensiones>();
		}

        
        /// <summary>
        /// Obtener un Extensiones por su clave primaria
        /// </summary>
		/// <param name="idExtension">IdExtension</param>
        /// <returns>Extensiones   seleccionado por su clave primaria</returns>
		public async Task<Extensiones> GetExtensionesByPrimaryKeyAsync(int idExtension)
		{
			return await _efRepository.FindAsync<Extensiones>(x=>x.IdExtension == idExtension);
		}

        /// <summary>
        /// Obtener un Extensiones por su clave primaria
        /// </summary>
		/// <param name="idExtension">IdExtension</param>
        /// <returns>Extensiones  seleccionado por su clave primaria</returns>
		public Extensiones GetExtensionesByPrimaryKey(int idExtension)
		{
			return _efRepository.Find<Extensiones>(x=>x.IdExtension == idExtension);
		}


        /// <summary>
        /// Obtener un IQueryable<Extensiones> por su IdTipoArchivo 
        /// </summary>
		/// <param name="idTipoArchivo">IdTipoArchivo</param>
        /// <returns>IQueryable con los Extensiones seleccionado por su IdTipoArchivo </returns>
		public IQueryable<Extensiones> GetExtensionesByIdTipoArchivo(int? idTipoArchivo)
		{
			return _efRepository.Filter<Extensiones>(x=> x.IdTipoArchivo == idTipoArchivo);
		}


		/// <summary>
        /// Crea una instancia de Extensiones en la base de datos
        /// </summary>
        /// <param name="source">Extensiones a crear</param>
        /// <returns>Extensiones creado</returns>
		public virtual async Task<Extensiones> CreateExtensionesAsync(Extensiones source)
		{
			return await _efRepository.CreateAsync<Extensiones>(source);
		}

		/// <summary>
        /// Crea una instancia de Extensiones en la base de datos
        /// </summary>
        /// <param name="source">Extensiones a crear</param>
        /// <returns>Extensiones creado</returns>
		public virtual Extensiones CreateExtensiones(Extensiones source)
		{
			return _efRepository.Create<Extensiones>(source);
		}


		/// <summary>
        /// Modifica una instancia de Extensiones en la base de datos
        /// </summary>
        /// <param name="source">Extensiones a modificar</param>
        /// <returns>Número de Extensiones modificados</returns>
		public async Task<int> UpdateExtensionesAsync(Extensiones source)
		{
			return await _efRepository.UpdateAsync<Extensiones>(source);
		}

		/// <summary>
        /// Modifica una instancia de Extensiones en la base de datos
        /// </summary>
        /// <param name="source">Extensiones a modificar</param>
        /// <returns>Número de Extensiones modificados</returns>
		public int UpdateExtensiones(Extensiones source)
		{
			return _efRepository.Update<Extensiones>(source);
		}

		/// <summary>
        /// Borra una instancia de Extensiones en la base de datos
        /// </summary>
        /// <param name="source">Extensiones a borrar</param>
        /// <returns>Número de Extensiones borrados</returns>
		public async Task<int> DeleteExtensionesAsync(Extensiones source)
		{
			return await _efRepository.DeleteAsync<Extensiones>(source);
		}

		/// <summary>
        /// Borra una instancia de Extensiones en la base de datos
        /// </summary>
        /// <param name="source">Extensiones a borrar</param>
        /// <returns>Número de Extensiones borrados</returns>
		public int DeleteExtensiones(Extensiones source)
		{
			return _efRepository.Delete<Extensiones>(source);
		}
    }
}
