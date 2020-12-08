using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioConfiguracionLogaltyBase : IRepositorioConfiguracionLogaltyBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase ConfiguracionLogalty 
        /// </summary>
		public RepositorioConfiguracionLogaltyBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los ConfiguracionLogalty 
        /// </summary>
        /// <returns>IQueryable con todos los ConfiguracionLogalty</returns>
		public IQueryable<ConfiguracionLogalty> GetConfiguracionLogalty()
		{
			return _efRepository.All<ConfiguracionLogalty>();
		}

        
        /// <summary>
        /// Obtener un ConfiguracionLogalty por su clave primaria
        /// </summary>
		/// <param name="idConfiguracionLogalty">IdConfiguracionLogalty</param>
        /// <returns>ConfiguracionLogalty   seleccionado por su clave primaria</returns>
		public async Task<ConfiguracionLogalty> GetConfiguracionLogaltyByPrimaryKeyAsync(int idConfiguracionLogalty)
		{
			return await _efRepository.FindAsync<ConfiguracionLogalty>(x=>x.IdConfiguracionLogalty == idConfiguracionLogalty);
		}

        /// <summary>
        /// Obtener un ConfiguracionLogalty por su clave primaria
        /// </summary>
		/// <param name="idConfiguracionLogalty">IdConfiguracionLogalty</param>
        /// <returns>ConfiguracionLogalty  seleccionado por su clave primaria</returns>
		public ConfiguracionLogalty GetConfiguracionLogaltyByPrimaryKey(int idConfiguracionLogalty)
		{
			return _efRepository.Find<ConfiguracionLogalty>(x=>x.IdConfiguracionLogalty == idConfiguracionLogalty);
		}




		/// <summary>
        /// Crea una instancia de ConfiguracionLogalty en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionLogalty a crear</param>
        /// <returns>ConfiguracionLogalty creado</returns>
		public virtual async Task<ConfiguracionLogalty> CreateConfiguracionLogaltyAsync(ConfiguracionLogalty source)
		{
			return await _efRepository.CreateAsync<ConfiguracionLogalty>(source);
		}

		/// <summary>
        /// Crea una instancia de ConfiguracionLogalty en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionLogalty a crear</param>
        /// <returns>ConfiguracionLogalty creado</returns>
		public virtual ConfiguracionLogalty CreateConfiguracionLogalty(ConfiguracionLogalty source)
		{
			return _efRepository.Create<ConfiguracionLogalty>(source);
		}


		/// <summary>
        /// Modifica una instancia de ConfiguracionLogalty en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionLogalty a modificar</param>
        /// <returns>Número de ConfiguracionLogalty modificados</returns>
		public async Task<int> UpdateConfiguracionLogaltyAsync(ConfiguracionLogalty source)
		{
			return await _efRepository.UpdateAsync<ConfiguracionLogalty>(source);
		}

		/// <summary>
        /// Modifica una instancia de ConfiguracionLogalty en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionLogalty a modificar</param>
        /// <returns>Número de ConfiguracionLogalty modificados</returns>
		public int UpdateConfiguracionLogalty(ConfiguracionLogalty source)
		{
			return _efRepository.Update<ConfiguracionLogalty>(source);
		}

		/// <summary>
        /// Borra una instancia de ConfiguracionLogalty en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionLogalty a borrar</param>
        /// <returns>Número de ConfiguracionLogalty borrados</returns>
		public async Task<int> DeleteConfiguracionLogaltyAsync(ConfiguracionLogalty source)
		{
			return await _efRepository.DeleteAsync<ConfiguracionLogalty>(source);
		}

		/// <summary>
        /// Borra una instancia de ConfiguracionLogalty en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionLogalty a borrar</param>
        /// <returns>Número de ConfiguracionLogalty borrados</returns>
		public int DeleteConfiguracionLogalty(ConfiguracionLogalty source)
		{
			return _efRepository.Delete<ConfiguracionLogalty>(source);
		}
    }
}
