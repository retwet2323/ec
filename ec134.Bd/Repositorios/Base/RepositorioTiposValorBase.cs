using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioTiposValorBase : IRepositorioTiposValorBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase TiposValor 
        /// </summary>
		public RepositorioTiposValorBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los TiposValor 
        /// </summary>
        /// <returns>IQueryable con todos los TiposValor</returns>
		public IQueryable<TiposValor> GetTiposValor()
		{
			return _efRepository.All<TiposValor>();
		}

        
        /// <summary>
        /// Obtener un TiposValor por su clave primaria
        /// </summary>
		/// <param name="idTipoValor">IdTipoValor</param>
        /// <returns>TiposValor   seleccionado por su clave primaria</returns>
		public async Task<TiposValor> GetTiposValorByPrimaryKeyAsync(int idTipoValor)
		{
			return await _efRepository.FindAsync<TiposValor>(x=>x.IdTipoValor == idTipoValor);
		}

        /// <summary>
        /// Obtener un TiposValor por su clave primaria
        /// </summary>
		/// <param name="idTipoValor">IdTipoValor</param>
        /// <returns>TiposValor  seleccionado por su clave primaria</returns>
		public TiposValor GetTiposValorByPrimaryKey(int idTipoValor)
		{
			return _efRepository.Find<TiposValor>(x=>x.IdTipoValor == idTipoValor);
		}




		/// <summary>
        /// Crea una instancia de TiposValor en la base de datos
        /// </summary>
        /// <param name="source">TiposValor a crear</param>
        /// <returns>TiposValor creado</returns>
		public virtual async Task<TiposValor> CreateTiposValorAsync(TiposValor source)
		{
			return await _efRepository.CreateAsync<TiposValor>(source);
		}

		/// <summary>
        /// Crea una instancia de TiposValor en la base de datos
        /// </summary>
        /// <param name="source">TiposValor a crear</param>
        /// <returns>TiposValor creado</returns>
		public virtual TiposValor CreateTiposValor(TiposValor source)
		{
			return _efRepository.Create<TiposValor>(source);
		}


		/// <summary>
        /// Modifica una instancia de TiposValor en la base de datos
        /// </summary>
        /// <param name="source">TiposValor a modificar</param>
        /// <returns>Número de TiposValor modificados</returns>
		public async Task<int> UpdateTiposValorAsync(TiposValor source)
		{
			return await _efRepository.UpdateAsync<TiposValor>(source);
		}

		/// <summary>
        /// Modifica una instancia de TiposValor en la base de datos
        /// </summary>
        /// <param name="source">TiposValor a modificar</param>
        /// <returns>Número de TiposValor modificados</returns>
		public int UpdateTiposValor(TiposValor source)
		{
			return _efRepository.Update<TiposValor>(source);
		}

		/// <summary>
        /// Borra una instancia de TiposValor en la base de datos
        /// </summary>
        /// <param name="source">TiposValor a borrar</param>
        /// <returns>Número de TiposValor borrados</returns>
		public async Task<int> DeleteTiposValorAsync(TiposValor source)
		{
			return await _efRepository.DeleteAsync<TiposValor>(source);
		}

		/// <summary>
        /// Borra una instancia de TiposValor en la base de datos
        /// </summary>
        /// <param name="source">TiposValor a borrar</param>
        /// <returns>Número de TiposValor borrados</returns>
		public int DeleteTiposValor(TiposValor source)
		{
			return _efRepository.Delete<TiposValor>(source);
		}
    }
}
