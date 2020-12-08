using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioConfiguracionAccionSMTPBase : IRepositorioConfiguracionAccionSMTPBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase ConfiguracionAccionSMTP 
        /// </summary>
		public RepositorioConfiguracionAccionSMTPBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los ConfiguracionAccionSMTP 
        /// </summary>
        /// <returns>IQueryable con todos los ConfiguracionAccionSMTP</returns>
		public IQueryable<ConfiguracionAccionSMTP> GetConfiguracionAccionSMTP()
		{
			return _efRepository.All<ConfiguracionAccionSMTP>();
		}

        
        /// <summary>
        /// Obtener un ConfiguracionAccionSMTP por su clave primaria
        /// </summary>
		/// <param name="idConfiguracionaAccionSMTP">IdConfiguracionaAccionSMTP</param>
        /// <returns>ConfiguracionAccionSMTP   seleccionado por su clave primaria</returns>
		public async Task<ConfiguracionAccionSMTP> GetConfiguracionAccionSMTPByPrimaryKeyAsync(int idConfiguracionaAccionSMTP)
		{
			return await _efRepository.FindAsync<ConfiguracionAccionSMTP>(x=>x.IdConfiguracionaAccionSMTP == idConfiguracionaAccionSMTP);
		}

        /// <summary>
        /// Obtener un ConfiguracionAccionSMTP por su clave primaria
        /// </summary>
		/// <param name="idConfiguracionaAccionSMTP">IdConfiguracionaAccionSMTP</param>
        /// <returns>ConfiguracionAccionSMTP  seleccionado por su clave primaria</returns>
		public ConfiguracionAccionSMTP GetConfiguracionAccionSMTPByPrimaryKey(int idConfiguracionaAccionSMTP)
		{
			return _efRepository.Find<ConfiguracionAccionSMTP>(x=>x.IdConfiguracionaAccionSMTP == idConfiguracionaAccionSMTP);
		}




		/// <summary>
        /// Crea una instancia de ConfiguracionAccionSMTP en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionAccionSMTP a crear</param>
        /// <returns>ConfiguracionAccionSMTP creado</returns>
		public virtual async Task<ConfiguracionAccionSMTP> CreateConfiguracionAccionSMTPAsync(ConfiguracionAccionSMTP source)
		{
			return await _efRepository.CreateAsync<ConfiguracionAccionSMTP>(source);
		}

		/// <summary>
        /// Crea una instancia de ConfiguracionAccionSMTP en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionAccionSMTP a crear</param>
        /// <returns>ConfiguracionAccionSMTP creado</returns>
		public virtual ConfiguracionAccionSMTP CreateConfiguracionAccionSMTP(ConfiguracionAccionSMTP source)
		{
			return _efRepository.Create<ConfiguracionAccionSMTP>(source);
		}


		/// <summary>
        /// Modifica una instancia de ConfiguracionAccionSMTP en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionAccionSMTP a modificar</param>
        /// <returns>Número de ConfiguracionAccionSMTP modificados</returns>
		public async Task<int> UpdateConfiguracionAccionSMTPAsync(ConfiguracionAccionSMTP source)
		{
			return await _efRepository.UpdateAsync<ConfiguracionAccionSMTP>(source);
		}

		/// <summary>
        /// Modifica una instancia de ConfiguracionAccionSMTP en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionAccionSMTP a modificar</param>
        /// <returns>Número de ConfiguracionAccionSMTP modificados</returns>
		public int UpdateConfiguracionAccionSMTP(ConfiguracionAccionSMTP source)
		{
			return _efRepository.Update<ConfiguracionAccionSMTP>(source);
		}

		/// <summary>
        /// Borra una instancia de ConfiguracionAccionSMTP en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionAccionSMTP a borrar</param>
        /// <returns>Número de ConfiguracionAccionSMTP borrados</returns>
		public async Task<int> DeleteConfiguracionAccionSMTPAsync(ConfiguracionAccionSMTP source)
		{
			return await _efRepository.DeleteAsync<ConfiguracionAccionSMTP>(source);
		}

		/// <summary>
        /// Borra una instancia de ConfiguracionAccionSMTP en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionAccionSMTP a borrar</param>
        /// <returns>Número de ConfiguracionAccionSMTP borrados</returns>
		public int DeleteConfiguracionAccionSMTP(ConfiguracionAccionSMTP source)
		{
			return _efRepository.Delete<ConfiguracionAccionSMTP>(source);
		}
    }
}
