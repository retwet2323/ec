using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioCamposProductosBase
	{
		/// <summary>
        /// Metodo para obtener todos los CamposProductos 
        /// </summary>
        /// <returns>IQueryable con todos los CamposProductos</returns>
		IQueryable<CamposProductos> GetCamposProductos();
		
        
        /// <summary>
        /// Obtener un CamposProductos por su clave primaria
        /// </summary>
				/// <param name="idCampoProducto">IdCampoProducto</param>
		        /// <returns>CamposProductos   seleccionado por su clave primaria</returns>
		Task<CamposProductos> GetCamposProductosByPrimaryKeyAsync(int idCampoProducto);
		
        /// <summary>
        /// Obtener un CamposProductos por su clave primaria
        /// </summary>
				/// <param name="idCampoProducto">IdCampoProducto</param>
		        /// <returns>CamposProductos  seleccionado por su clave primaria</returns>
		CamposProductos GetCamposProductosByPrimaryKey(int idCampoProducto);


        

        /// <summary>
        /// Obtener un IQueryable<CamposProductos> por su IdProducto 
        /// </summary>
		/// <param name="idProducto">IdProducto</param>
        /// <returns>IQueryable con los CamposProductos seleccionado por su IdProducto </returns>
        IQueryable<CamposProductos> GetCamposProductosByIdProducto(int? idProducto);


		/// <summary>
        /// Crea una instancia de CamposProductos en la base de datos
        /// </summary>
        /// <param name="source">CamposProductos a crear</param>
        /// <returns>CamposProductos creado</returns>
		Task<CamposProductos> CreateCamposProductosAsync(CamposProductos source);

		/// <summary>
        /// Crea una instancia de CamposProductos en la base de datos
        /// </summary>
        /// <param name="source">CamposProductos a crear</param>
        /// <returns>CamposProductos creado</returns>
		CamposProductos CreateCamposProductos(CamposProductos source);


		/// <summary>
        /// Modifica una instancia de CamposProductos en la base de datos
        /// </summary>
        /// <param name="source">CamposProductos a modificar</param>
        /// <returns>Número de CamposProductos modificados</returns>
		Task<int> UpdateCamposProductosAsync(CamposProductos source);
		

		/// <summary>
        /// Modifica una instancia de CamposProductos en la base de datos
        /// </summary>
        /// <param name="source">CamposProductos a modificar</param>
        /// <returns>Número de CamposProductos modificados</returns>
		int UpdateCamposProductos(CamposProductos source);

		/// <summary>
        /// Borra una instancia de CamposProductos en la base de datos
        /// </summary>
        /// <param name="source">CamposProductos a borrar</param>
        /// <returns>Número de CamposProductos borrados</returns>
		Task<int> DeleteCamposProductosAsync(CamposProductos source);
		
		/// <summary>
        /// Borra una instancia de CamposProductos en la base de datos
        /// </summary>
        /// <param name="source">CamposProductos a borrar</param>
        /// <returns>Número de CamposProductos borrados</returns>
		int DeleteCamposProductos(CamposProductos source);
    }
}
