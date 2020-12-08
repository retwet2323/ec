using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioProductosBase
	{
		/// <summary>
        /// Metodo para obtener todos los Productos 
        /// </summary>
        /// <returns>IQueryable con todos los Productos</returns>
		IQueryable<Productos> GetProductos();
		
        
        /// <summary>
        /// Obtener un Productos por su clave primaria
        /// </summary>
				/// <param name="idProducto">IdProducto</param>
		        /// <returns>Productos   seleccionado por su clave primaria</returns>
		Task<Productos> GetProductosByPrimaryKeyAsync(int idProducto);
		
        /// <summary>
        /// Obtener un Productos por su clave primaria
        /// </summary>
				/// <param name="idProducto">IdProducto</param>
		        /// <returns>Productos  seleccionado por su clave primaria</returns>
		Productos GetProductosByPrimaryKey(int idProducto);


        


		/// <summary>
        /// Crea una instancia de Productos en la base de datos
        /// </summary>
        /// <param name="source">Productos a crear</param>
        /// <returns>Productos creado</returns>
		Task<Productos> CreateProductosAsync(Productos source);

		/// <summary>
        /// Crea una instancia de Productos en la base de datos
        /// </summary>
        /// <param name="source">Productos a crear</param>
        /// <returns>Productos creado</returns>
		Productos CreateProductos(Productos source);


		/// <summary>
        /// Modifica una instancia de Productos en la base de datos
        /// </summary>
        /// <param name="source">Productos a modificar</param>
        /// <returns>Número de Productos modificados</returns>
		Task<int> UpdateProductosAsync(Productos source);
		

		/// <summary>
        /// Modifica una instancia de Productos en la base de datos
        /// </summary>
        /// <param name="source">Productos a modificar</param>
        /// <returns>Número de Productos modificados</returns>
		int UpdateProductos(Productos source);

		/// <summary>
        /// Borra una instancia de Productos en la base de datos
        /// </summary>
        /// <param name="source">Productos a borrar</param>
        /// <returns>Número de Productos borrados</returns>
		Task<int> DeleteProductosAsync(Productos source);
		
		/// <summary>
        /// Borra una instancia de Productos en la base de datos
        /// </summary>
        /// <param name="source">Productos a borrar</param>
        /// <returns>Número de Productos borrados</returns>
		int DeleteProductos(Productos source);
    }
}
