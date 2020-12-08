using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioControlesBase : IRepositorioControlesBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase Controles 
        /// </summary>
		public RepositorioControlesBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los Controles 
        /// </summary>
        /// <returns>IQueryable con todos los Controles</returns>
		public IQueryable<Controles> GetControles()
		{
			return _efRepository.All<Controles>();
		}

        
        /// <summary>
        /// Obtener un Controles por su clave primaria
        /// </summary>
		/// <param name="idControl">IdControl</param>
        /// <returns>Controles   seleccionado por su clave primaria</returns>
		public async Task<Controles> GetControlesByPrimaryKeyAsync(int idControl)
		{
			return await _efRepository.FindAsync<Controles>(x=>x.IdControl == idControl);
		}

        /// <summary>
        /// Obtener un Controles por su clave primaria
        /// </summary>
		/// <param name="idControl">IdControl</param>
        /// <returns>Controles  seleccionado por su clave primaria</returns>
		public Controles GetControlesByPrimaryKey(int idControl)
		{
			return _efRepository.Find<Controles>(x=>x.IdControl == idControl);
		}


        /// <summary>
        /// Obtener un IQueryable<Controles> por su IdControlSuperior 
        /// </summary>
		/// <param name="idControlSuperior">IdControlSuperior</param>
        /// <returns>IQueryable con los Controles seleccionado por su IdControlSuperior </returns>
		public IQueryable<Controles> GetControlesByIdControlSuperior(int? idControlSuperior)
		{
			return _efRepository.Filter<Controles>(x=> x.IdControlSuperior == idControlSuperior);
		}
        /// <summary>
        /// Obtener un IQueryable<Controles> por su IdCampoProducto 
        /// </summary>
		/// <param name="idCampoProducto">IdCampoProducto</param>
        /// <returns>IQueryable con los Controles seleccionado por su IdCampoProducto </returns>
		public IQueryable<Controles> GetControlesByIdCampoProducto(int? idCampoProducto)
		{
			return _efRepository.Filter<Controles>(x=> x.IdCampoProducto == idCampoProducto);
		}
        /// <summary>
        /// Obtener un IQueryable<Controles> por su IdContenedor 
        /// </summary>
		/// <param name="idContenedor">IdContenedor</param>
        /// <returns>IQueryable con los Controles seleccionado por su IdContenedor </returns>
		public IQueryable<Controles> GetControlesByIdContenedor(int? idContenedor)
		{
			return _efRepository.Filter<Controles>(x=> x.IdContenedor == idContenedor);
		}


		/// <summary>
        /// Crea una instancia de Controles en la base de datos
        /// </summary>
        /// <param name="source">Controles a crear</param>
        /// <returns>Controles creado</returns>
		public virtual async Task<Controles> CreateControlesAsync(Controles source)
		{
			return await _efRepository.CreateAsync<Controles>(source);
		}

		/// <summary>
        /// Crea una instancia de Controles en la base de datos
        /// </summary>
        /// <param name="source">Controles a crear</param>
        /// <returns>Controles creado</returns>
		public virtual Controles CreateControles(Controles source)
		{
			return _efRepository.Create<Controles>(source);
		}


		/// <summary>
        /// Modifica una instancia de Controles en la base de datos
        /// </summary>
        /// <param name="source">Controles a modificar</param>
        /// <returns>Número de Controles modificados</returns>
		public async Task<int> UpdateControlesAsync(Controles source)
		{
			return await _efRepository.UpdateAsync<Controles>(source);
		}

		/// <summary>
        /// Modifica una instancia de Controles en la base de datos
        /// </summary>
        /// <param name="source">Controles a modificar</param>
        /// <returns>Número de Controles modificados</returns>
		public int UpdateControles(Controles source)
		{
			return _efRepository.Update<Controles>(source);
		}

		/// <summary>
        /// Borra una instancia de Controles en la base de datos
        /// </summary>
        /// <param name="source">Controles a borrar</param>
        /// <returns>Número de Controles borrados</returns>
		public async Task<int> DeleteControlesAsync(Controles source)
		{
			return await _efRepository.DeleteAsync<Controles>(source);
		}

		/// <summary>
        /// Borra una instancia de Controles en la base de datos
        /// </summary>
        /// <param name="source">Controles a borrar</param>
        /// <returns>Número de Controles borrados</returns>
		public int DeleteControles(Controles source)
		{
			return _efRepository.Delete<Controles>(source);
		}
    }
}
