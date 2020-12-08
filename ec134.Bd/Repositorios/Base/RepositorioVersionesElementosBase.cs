using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioVersionesElementosBase : IRepositorioVersionesElementosBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase VersionesElementos 
        /// </summary>
		public RepositorioVersionesElementosBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los VersionesElementos 
        /// </summary>
        /// <returns>IQueryable con todos los VersionesElementos</returns>
		public IQueryable<VersionesElementos> GetVersionesElementos()
		{
			return _efRepository.All<VersionesElementos>();
		}

        
        /// <summary>
        /// Obtener un VersionesElementos por su clave primaria
        /// </summary>
		/// <param name="idVersionElemento">IdVersionElemento</param>
        /// <returns>VersionesElementos   seleccionado por su clave primaria</returns>
		public async Task<VersionesElementos> GetVersionesElementosByPrimaryKeyAsync(int idVersionElemento)
		{
			return await _efRepository.FindAsync<VersionesElementos>(x=>x.IdVersionElemento == idVersionElemento);
		}

        /// <summary>
        /// Obtener un VersionesElementos por su clave primaria
        /// </summary>
		/// <param name="idVersionElemento">IdVersionElemento</param>
        /// <returns>VersionesElementos  seleccionado por su clave primaria</returns>
		public VersionesElementos GetVersionesElementosByPrimaryKey(int idVersionElemento)
		{
			return _efRepository.Find<VersionesElementos>(x=>x.IdVersionElemento == idVersionElemento);
		}


        /// <summary>
        /// Obtener un IQueryable<VersionesElementos> por su IdElementoVersionable 
        /// </summary>
		/// <param name="idElementoVersionable">IdElementoVersionable</param>
        /// <returns>IQueryable con los VersionesElementos seleccionado por su IdElementoVersionable </returns>
		public IQueryable<VersionesElementos> GetVersionesElementosByIdElementoVersionable(int? idElementoVersionable)
		{
			return _efRepository.Filter<VersionesElementos>(x=> x.IdElementoVersionable == idElementoVersionable);
		}


		/// <summary>
        /// Crea una instancia de VersionesElementos en la base de datos
        /// </summary>
        /// <param name="source">VersionesElementos a crear</param>
        /// <returns>VersionesElementos creado</returns>
		public virtual async Task<VersionesElementos> CreateVersionesElementosAsync(VersionesElementos source)
		{
			return await _efRepository.CreateAsync<VersionesElementos>(source);
		}

		/// <summary>
        /// Crea una instancia de VersionesElementos en la base de datos
        /// </summary>
        /// <param name="source">VersionesElementos a crear</param>
        /// <returns>VersionesElementos creado</returns>
		public virtual VersionesElementos CreateVersionesElementos(VersionesElementos source)
		{
			return _efRepository.Create<VersionesElementos>(source);
		}


		/// <summary>
        /// Modifica una instancia de VersionesElementos en la base de datos
        /// </summary>
        /// <param name="source">VersionesElementos a modificar</param>
        /// <returns>Número de VersionesElementos modificados</returns>
		public async Task<int> UpdateVersionesElementosAsync(VersionesElementos source)
		{
			return await _efRepository.UpdateAsync<VersionesElementos>(source);
		}

		/// <summary>
        /// Modifica una instancia de VersionesElementos en la base de datos
        /// </summary>
        /// <param name="source">VersionesElementos a modificar</param>
        /// <returns>Número de VersionesElementos modificados</returns>
		public int UpdateVersionesElementos(VersionesElementos source)
		{
			return _efRepository.Update<VersionesElementos>(source);
		}

		/// <summary>
        /// Borra una instancia de VersionesElementos en la base de datos
        /// </summary>
        /// <param name="source">VersionesElementos a borrar</param>
        /// <returns>Número de VersionesElementos borrados</returns>
		public async Task<int> DeleteVersionesElementosAsync(VersionesElementos source)
		{
			return await _efRepository.DeleteAsync<VersionesElementos>(source);
		}

		/// <summary>
        /// Borra una instancia de VersionesElementos en la base de datos
        /// </summary>
        /// <param name="source">VersionesElementos a borrar</param>
        /// <returns>Número de VersionesElementos borrados</returns>
		public int DeleteVersionesElementos(VersionesElementos source)
		{
			return _efRepository.Delete<VersionesElementos>(source);
		}
    }
}
