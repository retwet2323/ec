using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioServiciosBase : IRepositorioServiciosBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase Servicios 
        /// </summary>
		public RepositorioServiciosBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los Servicios 
        /// </summary>
        /// <returns>IQueryable con todos los Servicios</returns>
		public IQueryable<Servicios> GetServicios()
		{
			return _efRepository.All<Servicios>();
		}

        
        /// <summary>
        /// Obtener un Servicios por su clave primaria
        /// </summary>
		/// <param name="idServicio">IdServicio</param>
        /// <returns>Servicios   seleccionado por su clave primaria</returns>
		public async Task<Servicios> GetServiciosByPrimaryKeyAsync(int idServicio)
		{
			return await _efRepository.FindAsync<Servicios>(x=>x.IdServicio == idServicio);
		}

        /// <summary>
        /// Obtener un Servicios por su clave primaria
        /// </summary>
		/// <param name="idServicio">IdServicio</param>
        /// <returns>Servicios  seleccionado por su clave primaria</returns>
		public Servicios GetServiciosByPrimaryKey(int idServicio)
		{
			return _efRepository.Find<Servicios>(x=>x.IdServicio == idServicio);
		}




		/// <summary>
        /// Crea una instancia de Servicios en la base de datos
        /// </summary>
        /// <param name="source">Servicios a crear</param>
        /// <returns>Servicios creado</returns>
		public virtual async Task<Servicios> CreateServiciosAsync(Servicios source)
		{
			return await _efRepository.CreateAsync<Servicios>(source);
		}

		/// <summary>
        /// Crea una instancia de Servicios en la base de datos
        /// </summary>
        /// <param name="source">Servicios a crear</param>
        /// <returns>Servicios creado</returns>
		public virtual Servicios CreateServicios(Servicios source)
		{
			return _efRepository.Create<Servicios>(source);
		}


		/// <summary>
        /// Modifica una instancia de Servicios en la base de datos
        /// </summary>
        /// <param name="source">Servicios a modificar</param>
        /// <returns>Número de Servicios modificados</returns>
		public async Task<int> UpdateServiciosAsync(Servicios source)
		{
			return await _efRepository.UpdateAsync<Servicios>(source);
		}

		/// <summary>
        /// Modifica una instancia de Servicios en la base de datos
        /// </summary>
        /// <param name="source">Servicios a modificar</param>
        /// <returns>Número de Servicios modificados</returns>
		public int UpdateServicios(Servicios source)
		{
			return _efRepository.Update<Servicios>(source);
		}

		/// <summary>
        /// Borra una instancia de Servicios en la base de datos
        /// </summary>
        /// <param name="source">Servicios a borrar</param>
        /// <returns>Número de Servicios borrados</returns>
		public async Task<int> DeleteServiciosAsync(Servicios source)
		{
			return await _efRepository.DeleteAsync<Servicios>(source);
		}

		/// <summary>
        /// Borra una instancia de Servicios en la base de datos
        /// </summary>
        /// <param name="source">Servicios a borrar</param>
        /// <returns>Número de Servicios borrados</returns>
		public int DeleteServicios(Servicios source)
		{
			return _efRepository.Delete<Servicios>(source);
		}
    }
}
