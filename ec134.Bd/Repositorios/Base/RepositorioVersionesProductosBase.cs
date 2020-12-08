using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioVersionesProductosBase : IRepositorioVersionesProductosBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase VersionesProductos 
        /// </summary>
		public RepositorioVersionesProductosBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los VersionesProductos 
        /// </summary>
        /// <returns>IQueryable con todos los VersionesProductos</returns>
		public IQueryable<VersionesProductos> GetVersionesProductos()
		{
			return _efRepository.All<VersionesProductos>();
		}

        
        /// <summary>
        /// Obtener un VersionesProductos por su clave primaria
        /// </summary>
		/// <param name="idVersionProducto">IdVersionProducto</param>
        /// <returns>VersionesProductos   seleccionado por su clave primaria</returns>
		public async Task<VersionesProductos> GetVersionesProductosByPrimaryKeyAsync(int idVersionProducto)
		{
			return await _efRepository.FindAsync<VersionesProductos>(x=>x.IdVersionProducto == idVersionProducto);
		}

        /// <summary>
        /// Obtener un VersionesProductos por su clave primaria
        /// </summary>
		/// <param name="idVersionProducto">IdVersionProducto</param>
        /// <returns>VersionesProductos  seleccionado por su clave primaria</returns>
		public VersionesProductos GetVersionesProductosByPrimaryKey(int idVersionProducto)
		{
			return _efRepository.Find<VersionesProductos>(x=>x.IdVersionProducto == idVersionProducto);
		}




		/// <summary>
        /// Crea una instancia de VersionesProductos en la base de datos
        /// </summary>
        /// <param name="source">VersionesProductos a crear</param>
        /// <returns>VersionesProductos creado</returns>
		public virtual async Task<VersionesProductos> CreateVersionesProductosAsync(VersionesProductos source)
		{
			return await _efRepository.CreateAsync<VersionesProductos>(source);
		}

		/// <summary>
        /// Crea una instancia de VersionesProductos en la base de datos
        /// </summary>
        /// <param name="source">VersionesProductos a crear</param>
        /// <returns>VersionesProductos creado</returns>
		public virtual VersionesProductos CreateVersionesProductos(VersionesProductos source)
		{
			return _efRepository.Create<VersionesProductos>(source);
		}


		/// <summary>
        /// Modifica una instancia de VersionesProductos en la base de datos
        /// </summary>
        /// <param name="source">VersionesProductos a modificar</param>
        /// <returns>Número de VersionesProductos modificados</returns>
		public async Task<int> UpdateVersionesProductosAsync(VersionesProductos source)
		{
			return await _efRepository.UpdateAsync<VersionesProductos>(source);
		}

		/// <summary>
        /// Modifica una instancia de VersionesProductos en la base de datos
        /// </summary>
        /// <param name="source">VersionesProductos a modificar</param>
        /// <returns>Número de VersionesProductos modificados</returns>
		public int UpdateVersionesProductos(VersionesProductos source)
		{
			return _efRepository.Update<VersionesProductos>(source);
		}

		/// <summary>
        /// Borra una instancia de VersionesProductos en la base de datos
        /// </summary>
        /// <param name="source">VersionesProductos a borrar</param>
        /// <returns>Número de VersionesProductos borrados</returns>
		public async Task<int> DeleteVersionesProductosAsync(VersionesProductos source)
		{
			return await _efRepository.DeleteAsync<VersionesProductos>(source);
		}

		/// <summary>
        /// Borra una instancia de VersionesProductos en la base de datos
        /// </summary>
        /// <param name="source">VersionesProductos a borrar</param>
        /// <returns>Número de VersionesProductos borrados</returns>
		public int DeleteVersionesProductos(VersionesProductos source)
		{
			return _efRepository.Delete<VersionesProductos>(source);
		}
    }
}
