using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioProductosBase : IRepositorioProductosBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase Productos 
        /// </summary>
		public RepositorioProductosBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los Productos 
        /// </summary>
        /// <returns>IQueryable con todos los Productos</returns>
		public IQueryable<Productos> GetProductos()
		{
			return _efRepository.All<Productos>();
		}

        
        /// <summary>
        /// Obtener un Productos por su clave primaria
        /// </summary>
		/// <param name="idProducto">IdProducto</param>
        /// <returns>Productos   seleccionado por su clave primaria</returns>
		public async Task<Productos> GetProductosByPrimaryKeyAsync(int idProducto)
		{
			return await _efRepository.FindAsync<Productos>(x=>x.IdProducto == idProducto);
		}

        /// <summary>
        /// Obtener un Productos por su clave primaria
        /// </summary>
		/// <param name="idProducto">IdProducto</param>
        /// <returns>Productos  seleccionado por su clave primaria</returns>
		public Productos GetProductosByPrimaryKey(int idProducto)
		{
			return _efRepository.Find<Productos>(x=>x.IdProducto == idProducto);
		}




		/// <summary>
        /// Crea una instancia de Productos en la base de datos
        /// </summary>
        /// <param name="source">Productos a crear</param>
        /// <returns>Productos creado</returns>
		public virtual async Task<Productos> CreateProductosAsync(Productos source)
		{
			return await _efRepository.CreateAsync<Productos>(source);
		}

		/// <summary>
        /// Crea una instancia de Productos en la base de datos
        /// </summary>
        /// <param name="source">Productos a crear</param>
        /// <returns>Productos creado</returns>
		public virtual Productos CreateProductos(Productos source)
		{
			return _efRepository.Create<Productos>(source);
		}


		/// <summary>
        /// Modifica una instancia de Productos en la base de datos
        /// </summary>
        /// <param name="source">Productos a modificar</param>
        /// <returns>Número de Productos modificados</returns>
		public async Task<int> UpdateProductosAsync(Productos source)
		{
			return await _efRepository.UpdateAsync<Productos>(source);
		}

		/// <summary>
        /// Modifica una instancia de Productos en la base de datos
        /// </summary>
        /// <param name="source">Productos a modificar</param>
        /// <returns>Número de Productos modificados</returns>
		public int UpdateProductos(Productos source)
		{
			return _efRepository.Update<Productos>(source);
		}

		/// <summary>
        /// Borra una instancia de Productos en la base de datos
        /// </summary>
        /// <param name="source">Productos a borrar</param>
        /// <returns>Número de Productos borrados</returns>
		public async Task<int> DeleteProductosAsync(Productos source)
		{
			return await _efRepository.DeleteAsync<Productos>(source);
		}

		/// <summary>
        /// Borra una instancia de Productos en la base de datos
        /// </summary>
        /// <param name="source">Productos a borrar</param>
        /// <returns>Número de Productos borrados</returns>
		public int DeleteProductos(Productos source)
		{
			return _efRepository.Delete<Productos>(source);
		}
    }
}
