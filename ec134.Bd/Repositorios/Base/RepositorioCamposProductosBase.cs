using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioCamposProductosBase : IRepositorioCamposProductosBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase CamposProductos 
        /// </summary>
		public RepositorioCamposProductosBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los CamposProductos 
        /// </summary>
        /// <returns>IQueryable con todos los CamposProductos</returns>
		public IQueryable<CamposProductos> GetCamposProductos()
		{
			return _efRepository.All<CamposProductos>();
		}

        
        /// <summary>
        /// Obtener un CamposProductos por su clave primaria
        /// </summary>
		/// <param name="idCampoProducto">IdCampoProducto</param>
        /// <returns>CamposProductos   seleccionado por su clave primaria</returns>
		public async Task<CamposProductos> GetCamposProductosByPrimaryKeyAsync(int idCampoProducto)
		{
			return await _efRepository.FindAsync<CamposProductos>(x=>x.IdCampoProducto == idCampoProducto);
		}

        /// <summary>
        /// Obtener un CamposProductos por su clave primaria
        /// </summary>
		/// <param name="idCampoProducto">IdCampoProducto</param>
        /// <returns>CamposProductos  seleccionado por su clave primaria</returns>
		public CamposProductos GetCamposProductosByPrimaryKey(int idCampoProducto)
		{
			return _efRepository.Find<CamposProductos>(x=>x.IdCampoProducto == idCampoProducto);
		}


        /// <summary>
        /// Obtener un IQueryable<CamposProductos> por su IdProducto 
        /// </summary>
		/// <param name="idProducto">IdProducto</param>
        /// <returns>IQueryable con los CamposProductos seleccionado por su IdProducto </returns>
		public IQueryable<CamposProductos> GetCamposProductosByIdProducto(int? idProducto)
		{
			return _efRepository.Filter<CamposProductos>(x=> x.IdProducto == idProducto);
		}


		/// <summary>
        /// Crea una instancia de CamposProductos en la base de datos
        /// </summary>
        /// <param name="source">CamposProductos a crear</param>
        /// <returns>CamposProductos creado</returns>
		public virtual async Task<CamposProductos> CreateCamposProductosAsync(CamposProductos source)
		{
			return await _efRepository.CreateAsync<CamposProductos>(source);
		}

		/// <summary>
        /// Crea una instancia de CamposProductos en la base de datos
        /// </summary>
        /// <param name="source">CamposProductos a crear</param>
        /// <returns>CamposProductos creado</returns>
		public virtual CamposProductos CreateCamposProductos(CamposProductos source)
		{
			return _efRepository.Create<CamposProductos>(source);
		}


		/// <summary>
        /// Modifica una instancia de CamposProductos en la base de datos
        /// </summary>
        /// <param name="source">CamposProductos a modificar</param>
        /// <returns>Número de CamposProductos modificados</returns>
		public async Task<int> UpdateCamposProductosAsync(CamposProductos source)
		{
			return await _efRepository.UpdateAsync<CamposProductos>(source);
		}

		/// <summary>
        /// Modifica una instancia de CamposProductos en la base de datos
        /// </summary>
        /// <param name="source">CamposProductos a modificar</param>
        /// <returns>Número de CamposProductos modificados</returns>
		public int UpdateCamposProductos(CamposProductos source)
		{
			return _efRepository.Update<CamposProductos>(source);
		}

		/// <summary>
        /// Borra una instancia de CamposProductos en la base de datos
        /// </summary>
        /// <param name="source">CamposProductos a borrar</param>
        /// <returns>Número de CamposProductos borrados</returns>
		public async Task<int> DeleteCamposProductosAsync(CamposProductos source)
		{
			return await _efRepository.DeleteAsync<CamposProductos>(source);
		}

		/// <summary>
        /// Borra una instancia de CamposProductos en la base de datos
        /// </summary>
        /// <param name="source">CamposProductos a borrar</param>
        /// <returns>Número de CamposProductos borrados</returns>
		public int DeleteCamposProductos(CamposProductos source)
		{
			return _efRepository.Delete<CamposProductos>(source);
		}
    }
}
