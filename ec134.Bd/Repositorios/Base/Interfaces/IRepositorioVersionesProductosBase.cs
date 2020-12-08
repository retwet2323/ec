using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioVersionesProductosBase
	{
		/// <summary>
        /// Metodo para obtener todos los VersionesProductos 
        /// </summary>
        /// <returns>IQueryable con todos los VersionesProductos</returns>
		IQueryable<VersionesProductos> GetVersionesProductos();
		
        
        /// <summary>
        /// Obtener un VersionesProductos por su clave primaria
        /// </summary>
				/// <param name="idVersionProducto">IdVersionProducto</param>
		        /// <returns>VersionesProductos   seleccionado por su clave primaria</returns>
		Task<VersionesProductos> GetVersionesProductosByPrimaryKeyAsync(int idVersionProducto);
		
        /// <summary>
        /// Obtener un VersionesProductos por su clave primaria
        /// </summary>
				/// <param name="idVersionProducto">IdVersionProducto</param>
		        /// <returns>VersionesProductos  seleccionado por su clave primaria</returns>
		VersionesProductos GetVersionesProductosByPrimaryKey(int idVersionProducto);


        


		/// <summary>
        /// Crea una instancia de VersionesProductos en la base de datos
        /// </summary>
        /// <param name="source">VersionesProductos a crear</param>
        /// <returns>VersionesProductos creado</returns>
		Task<VersionesProductos> CreateVersionesProductosAsync(VersionesProductos source);

		/// <summary>
        /// Crea una instancia de VersionesProductos en la base de datos
        /// </summary>
        /// <param name="source">VersionesProductos a crear</param>
        /// <returns>VersionesProductos creado</returns>
		VersionesProductos CreateVersionesProductos(VersionesProductos source);


		/// <summary>
        /// Modifica una instancia de VersionesProductos en la base de datos
        /// </summary>
        /// <param name="source">VersionesProductos a modificar</param>
        /// <returns>Número de VersionesProductos modificados</returns>
		Task<int> UpdateVersionesProductosAsync(VersionesProductos source);
		

		/// <summary>
        /// Modifica una instancia de VersionesProductos en la base de datos
        /// </summary>
        /// <param name="source">VersionesProductos a modificar</param>
        /// <returns>Número de VersionesProductos modificados</returns>
		int UpdateVersionesProductos(VersionesProductos source);

		/// <summary>
        /// Borra una instancia de VersionesProductos en la base de datos
        /// </summary>
        /// <param name="source">VersionesProductos a borrar</param>
        /// <returns>Número de VersionesProductos borrados</returns>
		Task<int> DeleteVersionesProductosAsync(VersionesProductos source);
		
		/// <summary>
        /// Borra una instancia de VersionesProductos en la base de datos
        /// </summary>
        /// <param name="source">VersionesProductos a borrar</param>
        /// <returns>Número de VersionesProductos borrados</returns>
		int DeleteVersionesProductos(VersionesProductos source);
    }
}
