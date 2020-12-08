using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioEstadosLogaltyBase : IRepositorioEstadosLogaltyBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase EstadosLogalty 
        /// </summary>
		public RepositorioEstadosLogaltyBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los EstadosLogalty 
        /// </summary>
        /// <returns>IQueryable con todos los EstadosLogalty</returns>
		public IQueryable<EstadosLogalty> GetEstadosLogalty()
		{
			return _efRepository.All<EstadosLogalty>();
		}

        
        /// <summary>
        /// Obtener un EstadosLogalty por su clave primaria
        /// </summary>
		/// <param name="idEstadoLogalty">IdEstadoLogalty</param>
        /// <returns>EstadosLogalty   seleccionado por su clave primaria</returns>
		public async Task<EstadosLogalty> GetEstadosLogaltyByPrimaryKeyAsync(int idEstadoLogalty)
		{
			return await _efRepository.FindAsync<EstadosLogalty>(x=>x.IdEstadoLogalty == idEstadoLogalty);
		}

        /// <summary>
        /// Obtener un EstadosLogalty por su clave primaria
        /// </summary>
		/// <param name="idEstadoLogalty">IdEstadoLogalty</param>
        /// <returns>EstadosLogalty  seleccionado por su clave primaria</returns>
		public EstadosLogalty GetEstadosLogaltyByPrimaryKey(int idEstadoLogalty)
		{
			return _efRepository.Find<EstadosLogalty>(x=>x.IdEstadoLogalty == idEstadoLogalty);
		}




		/// <summary>
        /// Crea una instancia de EstadosLogalty en la base de datos
        /// </summary>
        /// <param name="source">EstadosLogalty a crear</param>
        /// <returns>EstadosLogalty creado</returns>
		public virtual async Task<EstadosLogalty> CreateEstadosLogaltyAsync(EstadosLogalty source)
		{
			return await _efRepository.CreateAsync<EstadosLogalty>(source);
		}

		/// <summary>
        /// Crea una instancia de EstadosLogalty en la base de datos
        /// </summary>
        /// <param name="source">EstadosLogalty a crear</param>
        /// <returns>EstadosLogalty creado</returns>
		public virtual EstadosLogalty CreateEstadosLogalty(EstadosLogalty source)
		{
			return _efRepository.Create<EstadosLogalty>(source);
		}


		/// <summary>
        /// Modifica una instancia de EstadosLogalty en la base de datos
        /// </summary>
        /// <param name="source">EstadosLogalty a modificar</param>
        /// <returns>Número de EstadosLogalty modificados</returns>
		public async Task<int> UpdateEstadosLogaltyAsync(EstadosLogalty source)
		{
			return await _efRepository.UpdateAsync<EstadosLogalty>(source);
		}

		/// <summary>
        /// Modifica una instancia de EstadosLogalty en la base de datos
        /// </summary>
        /// <param name="source">EstadosLogalty a modificar</param>
        /// <returns>Número de EstadosLogalty modificados</returns>
		public int UpdateEstadosLogalty(EstadosLogalty source)
		{
			return _efRepository.Update<EstadosLogalty>(source);
		}

		/// <summary>
        /// Borra una instancia de EstadosLogalty en la base de datos
        /// </summary>
        /// <param name="source">EstadosLogalty a borrar</param>
        /// <returns>Número de EstadosLogalty borrados</returns>
		public async Task<int> DeleteEstadosLogaltyAsync(EstadosLogalty source)
		{
			return await _efRepository.DeleteAsync<EstadosLogalty>(source);
		}

		/// <summary>
        /// Borra una instancia de EstadosLogalty en la base de datos
        /// </summary>
        /// <param name="source">EstadosLogalty a borrar</param>
        /// <returns>Número de EstadosLogalty borrados</returns>
		public int DeleteEstadosLogalty(EstadosLogalty source)
		{
			return _efRepository.Delete<EstadosLogalty>(source);
		}
    }
}
