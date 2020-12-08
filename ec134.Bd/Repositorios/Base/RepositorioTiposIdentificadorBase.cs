using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioTiposIdentificadorBase : IRepositorioTiposIdentificadorBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase TiposIdentificador 
        /// </summary>
		public RepositorioTiposIdentificadorBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los TiposIdentificador 
        /// </summary>
        /// <returns>IQueryable con todos los TiposIdentificador</returns>
		public IQueryable<TiposIdentificador> GetTiposIdentificador()
		{
			return _efRepository.All<TiposIdentificador>();
		}

        
        /// <summary>
        /// Obtener un TiposIdentificador por su clave primaria
        /// </summary>
		/// <param name="idTipoIdentificador">IdTipoIdentificador</param>
        /// <returns>TiposIdentificador   seleccionado por su clave primaria</returns>
		public async Task<TiposIdentificador> GetTiposIdentificadorByPrimaryKeyAsync(int idTipoIdentificador)
		{
			return await _efRepository.FindAsync<TiposIdentificador>(x=>x.IdTipoIdentificador == idTipoIdentificador);
		}

        /// <summary>
        /// Obtener un TiposIdentificador por su clave primaria
        /// </summary>
		/// <param name="idTipoIdentificador">IdTipoIdentificador</param>
        /// <returns>TiposIdentificador  seleccionado por su clave primaria</returns>
		public TiposIdentificador GetTiposIdentificadorByPrimaryKey(int idTipoIdentificador)
		{
			return _efRepository.Find<TiposIdentificador>(x=>x.IdTipoIdentificador == idTipoIdentificador);
		}




		/// <summary>
        /// Crea una instancia de TiposIdentificador en la base de datos
        /// </summary>
        /// <param name="source">TiposIdentificador a crear</param>
        /// <returns>TiposIdentificador creado</returns>
		public virtual async Task<TiposIdentificador> CreateTiposIdentificadorAsync(TiposIdentificador source)
		{
			return await _efRepository.CreateAsync<TiposIdentificador>(source);
		}

		/// <summary>
        /// Crea una instancia de TiposIdentificador en la base de datos
        /// </summary>
        /// <param name="source">TiposIdentificador a crear</param>
        /// <returns>TiposIdentificador creado</returns>
		public virtual TiposIdentificador CreateTiposIdentificador(TiposIdentificador source)
		{
			return _efRepository.Create<TiposIdentificador>(source);
		}


		/// <summary>
        /// Modifica una instancia de TiposIdentificador en la base de datos
        /// </summary>
        /// <param name="source">TiposIdentificador a modificar</param>
        /// <returns>Número de TiposIdentificador modificados</returns>
		public async Task<int> UpdateTiposIdentificadorAsync(TiposIdentificador source)
		{
			return await _efRepository.UpdateAsync<TiposIdentificador>(source);
		}

		/// <summary>
        /// Modifica una instancia de TiposIdentificador en la base de datos
        /// </summary>
        /// <param name="source">TiposIdentificador a modificar</param>
        /// <returns>Número de TiposIdentificador modificados</returns>
		public int UpdateTiposIdentificador(TiposIdentificador source)
		{
			return _efRepository.Update<TiposIdentificador>(source);
		}

		/// <summary>
        /// Borra una instancia de TiposIdentificador en la base de datos
        /// </summary>
        /// <param name="source">TiposIdentificador a borrar</param>
        /// <returns>Número de TiposIdentificador borrados</returns>
		public async Task<int> DeleteTiposIdentificadorAsync(TiposIdentificador source)
		{
			return await _efRepository.DeleteAsync<TiposIdentificador>(source);
		}

		/// <summary>
        /// Borra una instancia de TiposIdentificador en la base de datos
        /// </summary>
        /// <param name="source">TiposIdentificador a borrar</param>
        /// <returns>Número de TiposIdentificador borrados</returns>
		public int DeleteTiposIdentificador(TiposIdentificador source)
		{
			return _efRepository.Delete<TiposIdentificador>(source);
		}
    }
}
