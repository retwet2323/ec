using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioConfiguracionAccionDIBase : IRepositorioConfiguracionAccionDIBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase ConfiguracionAccionDI 
        /// </summary>
		public RepositorioConfiguracionAccionDIBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los ConfiguracionAccionDI 
        /// </summary>
        /// <returns>IQueryable con todos los ConfiguracionAccionDI</returns>
		public IQueryable<ConfiguracionAccionDI> GetConfiguracionAccionDI()
		{
			return _efRepository.All<ConfiguracionAccionDI>();
		}

        
        /// <summary>
        /// Obtener un ConfiguracionAccionDI por su clave primaria
        /// </summary>
		/// <param name="idConfiguracionAccionDI">IdConfiguracionAccionDI</param>
        /// <returns>ConfiguracionAccionDI   seleccionado por su clave primaria</returns>
		public async Task<ConfiguracionAccionDI> GetConfiguracionAccionDIByPrimaryKeyAsync(int idConfiguracionAccionDI)
		{
			return await _efRepository.FindAsync<ConfiguracionAccionDI>(x=>x.IdConfiguracionAccionDI == idConfiguracionAccionDI);
		}

        /// <summary>
        /// Obtener un ConfiguracionAccionDI por su clave primaria
        /// </summary>
		/// <param name="idConfiguracionAccionDI">IdConfiguracionAccionDI</param>
        /// <returns>ConfiguracionAccionDI  seleccionado por su clave primaria</returns>
		public ConfiguracionAccionDI GetConfiguracionAccionDIByPrimaryKey(int idConfiguracionAccionDI)
		{
			return _efRepository.Find<ConfiguracionAccionDI>(x=>x.IdConfiguracionAccionDI == idConfiguracionAccionDI);
		}




		/// <summary>
        /// Crea una instancia de ConfiguracionAccionDI en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionAccionDI a crear</param>
        /// <returns>ConfiguracionAccionDI creado</returns>
		public virtual async Task<ConfiguracionAccionDI> CreateConfiguracionAccionDIAsync(ConfiguracionAccionDI source)
		{
			return await _efRepository.CreateAsync<ConfiguracionAccionDI>(source);
		}

		/// <summary>
        /// Crea una instancia de ConfiguracionAccionDI en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionAccionDI a crear</param>
        /// <returns>ConfiguracionAccionDI creado</returns>
		public virtual ConfiguracionAccionDI CreateConfiguracionAccionDI(ConfiguracionAccionDI source)
		{
			return _efRepository.Create<ConfiguracionAccionDI>(source);
		}


		/// <summary>
        /// Modifica una instancia de ConfiguracionAccionDI en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionAccionDI a modificar</param>
        /// <returns>Número de ConfiguracionAccionDI modificados</returns>
		public async Task<int> UpdateConfiguracionAccionDIAsync(ConfiguracionAccionDI source)
		{
			return await _efRepository.UpdateAsync<ConfiguracionAccionDI>(source);
		}

		/// <summary>
        /// Modifica una instancia de ConfiguracionAccionDI en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionAccionDI a modificar</param>
        /// <returns>Número de ConfiguracionAccionDI modificados</returns>
		public int UpdateConfiguracionAccionDI(ConfiguracionAccionDI source)
		{
			return _efRepository.Update<ConfiguracionAccionDI>(source);
		}

		/// <summary>
        /// Borra una instancia de ConfiguracionAccionDI en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionAccionDI a borrar</param>
        /// <returns>Número de ConfiguracionAccionDI borrados</returns>
		public async Task<int> DeleteConfiguracionAccionDIAsync(ConfiguracionAccionDI source)
		{
			return await _efRepository.DeleteAsync<ConfiguracionAccionDI>(source);
		}

		/// <summary>
        /// Borra una instancia de ConfiguracionAccionDI en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionAccionDI a borrar</param>
        /// <returns>Número de ConfiguracionAccionDI borrados</returns>
		public int DeleteConfiguracionAccionDI(ConfiguracionAccionDI source)
		{
			return _efRepository.Delete<ConfiguracionAccionDI>(source);
		}
    }
}
