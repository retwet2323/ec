using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioTiposServicioBase : IRepositorioTiposServicioBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase TiposServicio 
        /// </summary>
		public RepositorioTiposServicioBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los TiposServicio 
        /// </summary>
        /// <returns>IQueryable con todos los TiposServicio</returns>
		public IQueryable<TiposServicio> GetTiposServicio()
		{
			return _efRepository.All<TiposServicio>();
		}

        
        /// <summary>
        /// Obtener un TiposServicio por su clave primaria
        /// </summary>
		/// <param name="idTipoServicio">IdTipoServicio</param>
        /// <returns>TiposServicio   seleccionado por su clave primaria</returns>
		public async Task<TiposServicio> GetTiposServicioByPrimaryKeyAsync(int idTipoServicio)
		{
			return await _efRepository.FindAsync<TiposServicio>(x=>x.IdTipoServicio == idTipoServicio);
		}

        /// <summary>
        /// Obtener un TiposServicio por su clave primaria
        /// </summary>
		/// <param name="idTipoServicio">IdTipoServicio</param>
        /// <returns>TiposServicio  seleccionado por su clave primaria</returns>
		public TiposServicio GetTiposServicioByPrimaryKey(int idTipoServicio)
		{
			return _efRepository.Find<TiposServicio>(x=>x.IdTipoServicio == idTipoServicio);
		}




		/// <summary>
        /// Crea una instancia de TiposServicio en la base de datos
        /// </summary>
        /// <param name="source">TiposServicio a crear</param>
        /// <returns>TiposServicio creado</returns>
		public virtual async Task<TiposServicio> CreateTiposServicioAsync(TiposServicio source)
		{
			return await _efRepository.CreateAsync<TiposServicio>(source);
		}

		/// <summary>
        /// Crea una instancia de TiposServicio en la base de datos
        /// </summary>
        /// <param name="source">TiposServicio a crear</param>
        /// <returns>TiposServicio creado</returns>
		public virtual TiposServicio CreateTiposServicio(TiposServicio source)
		{
			return _efRepository.Create<TiposServicio>(source);
		}


		/// <summary>
        /// Modifica una instancia de TiposServicio en la base de datos
        /// </summary>
        /// <param name="source">TiposServicio a modificar</param>
        /// <returns>Número de TiposServicio modificados</returns>
		public async Task<int> UpdateTiposServicioAsync(TiposServicio source)
		{
			return await _efRepository.UpdateAsync<TiposServicio>(source);
		}

		/// <summary>
        /// Modifica una instancia de TiposServicio en la base de datos
        /// </summary>
        /// <param name="source">TiposServicio a modificar</param>
        /// <returns>Número de TiposServicio modificados</returns>
		public int UpdateTiposServicio(TiposServicio source)
		{
			return _efRepository.Update<TiposServicio>(source);
		}

		/// <summary>
        /// Borra una instancia de TiposServicio en la base de datos
        /// </summary>
        /// <param name="source">TiposServicio a borrar</param>
        /// <returns>Número de TiposServicio borrados</returns>
		public async Task<int> DeleteTiposServicioAsync(TiposServicio source)
		{
			return await _efRepository.DeleteAsync<TiposServicio>(source);
		}

		/// <summary>
        /// Borra una instancia de TiposServicio en la base de datos
        /// </summary>
        /// <param name="source">TiposServicio a borrar</param>
        /// <returns>Número de TiposServicio borrados</returns>
		public int DeleteTiposServicio(TiposServicio source)
		{
			return _efRepository.Delete<TiposServicio>(source);
		}
    }
}
