using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioEstadosOperacionesBase : IRepositorioEstadosOperacionesBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase EstadosOperaciones 
        /// </summary>
		public RepositorioEstadosOperacionesBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los EstadosOperaciones 
        /// </summary>
        /// <returns>IQueryable con todos los EstadosOperaciones</returns>
		public IQueryable<EstadosOperaciones> GetEstadosOperaciones()
		{
			return _efRepository.All<EstadosOperaciones>();
		}

        
        /// <summary>
        /// Obtener un EstadosOperaciones por su clave primaria
        /// </summary>
		/// <param name="idEstadoOperacion">IdEstadoOperacion</param>
        /// <returns>EstadosOperaciones   seleccionado por su clave primaria</returns>
		public async Task<EstadosOperaciones> GetEstadosOperacionesByPrimaryKeyAsync(int idEstadoOperacion)
		{
			return await _efRepository.FindAsync<EstadosOperaciones>(x=>x.IdEstadoOperacion == idEstadoOperacion);
		}

        /// <summary>
        /// Obtener un EstadosOperaciones por su clave primaria
        /// </summary>
		/// <param name="idEstadoOperacion">IdEstadoOperacion</param>
        /// <returns>EstadosOperaciones  seleccionado por su clave primaria</returns>
		public EstadosOperaciones GetEstadosOperacionesByPrimaryKey(int idEstadoOperacion)
		{
			return _efRepository.Find<EstadosOperaciones>(x=>x.IdEstadoOperacion == idEstadoOperacion);
		}




		/// <summary>
        /// Crea una instancia de EstadosOperaciones en la base de datos
        /// </summary>
        /// <param name="source">EstadosOperaciones a crear</param>
        /// <returns>EstadosOperaciones creado</returns>
		public virtual async Task<EstadosOperaciones> CreateEstadosOperacionesAsync(EstadosOperaciones source)
		{
			return await _efRepository.CreateAsync<EstadosOperaciones>(source);
		}

		/// <summary>
        /// Crea una instancia de EstadosOperaciones en la base de datos
        /// </summary>
        /// <param name="source">EstadosOperaciones a crear</param>
        /// <returns>EstadosOperaciones creado</returns>
		public virtual EstadosOperaciones CreateEstadosOperaciones(EstadosOperaciones source)
		{
			return _efRepository.Create<EstadosOperaciones>(source);
		}


		/// <summary>
        /// Modifica una instancia de EstadosOperaciones en la base de datos
        /// </summary>
        /// <param name="source">EstadosOperaciones a modificar</param>
        /// <returns>Número de EstadosOperaciones modificados</returns>
		public async Task<int> UpdateEstadosOperacionesAsync(EstadosOperaciones source)
		{
			return await _efRepository.UpdateAsync<EstadosOperaciones>(source);
		}

		/// <summary>
        /// Modifica una instancia de EstadosOperaciones en la base de datos
        /// </summary>
        /// <param name="source">EstadosOperaciones a modificar</param>
        /// <returns>Número de EstadosOperaciones modificados</returns>
		public int UpdateEstadosOperaciones(EstadosOperaciones source)
		{
			return _efRepository.Update<EstadosOperaciones>(source);
		}

		/// <summary>
        /// Borra una instancia de EstadosOperaciones en la base de datos
        /// </summary>
        /// <param name="source">EstadosOperaciones a borrar</param>
        /// <returns>Número de EstadosOperaciones borrados</returns>
		public async Task<int> DeleteEstadosOperacionesAsync(EstadosOperaciones source)
		{
			return await _efRepository.DeleteAsync<EstadosOperaciones>(source);
		}

		/// <summary>
        /// Borra una instancia de EstadosOperaciones en la base de datos
        /// </summary>
        /// <param name="source">EstadosOperaciones a borrar</param>
        /// <returns>Número de EstadosOperaciones borrados</returns>
		public int DeleteEstadosOperaciones(EstadosOperaciones source)
		{
			return _efRepository.Delete<EstadosOperaciones>(source);
		}
    }
}
