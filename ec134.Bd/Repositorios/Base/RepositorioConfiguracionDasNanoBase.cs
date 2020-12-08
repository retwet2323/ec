using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioConfiguracionDasNanoBase : IRepositorioConfiguracionDasNanoBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase ConfiguracionDasNano 
        /// </summary>
		public RepositorioConfiguracionDasNanoBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los ConfiguracionDasNano 
        /// </summary>
        /// <returns>IQueryable con todos los ConfiguracionDasNano</returns>
		public IQueryable<ConfiguracionDasNano> GetConfiguracionDasNano()
		{
			return _efRepository.All<ConfiguracionDasNano>();
		}

        
        /// <summary>
        /// Obtener un ConfiguracionDasNano por su clave primaria
        /// </summary>
		/// <param name="idConfiguracionDasNano">IdConfiguracionDasNano</param>
        /// <returns>ConfiguracionDasNano   seleccionado por su clave primaria</returns>
		public async Task<ConfiguracionDasNano> GetConfiguracionDasNanoByPrimaryKeyAsync(int idConfiguracionDasNano)
		{
			return await _efRepository.FindAsync<ConfiguracionDasNano>(x=>x.IdConfiguracionDasNano == idConfiguracionDasNano);
		}

        /// <summary>
        /// Obtener un ConfiguracionDasNano por su clave primaria
        /// </summary>
		/// <param name="idConfiguracionDasNano">IdConfiguracionDasNano</param>
        /// <returns>ConfiguracionDasNano  seleccionado por su clave primaria</returns>
		public ConfiguracionDasNano GetConfiguracionDasNanoByPrimaryKey(int idConfiguracionDasNano)
		{
			return _efRepository.Find<ConfiguracionDasNano>(x=>x.IdConfiguracionDasNano == idConfiguracionDasNano);
		}




		/// <summary>
        /// Crea una instancia de ConfiguracionDasNano en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionDasNano a crear</param>
        /// <returns>ConfiguracionDasNano creado</returns>
		public virtual async Task<ConfiguracionDasNano> CreateConfiguracionDasNanoAsync(ConfiguracionDasNano source)
		{
			return await _efRepository.CreateAsync<ConfiguracionDasNano>(source);
		}

		/// <summary>
        /// Crea una instancia de ConfiguracionDasNano en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionDasNano a crear</param>
        /// <returns>ConfiguracionDasNano creado</returns>
		public virtual ConfiguracionDasNano CreateConfiguracionDasNano(ConfiguracionDasNano source)
		{
			return _efRepository.Create<ConfiguracionDasNano>(source);
		}


		/// <summary>
        /// Modifica una instancia de ConfiguracionDasNano en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionDasNano a modificar</param>
        /// <returns>Número de ConfiguracionDasNano modificados</returns>
		public async Task<int> UpdateConfiguracionDasNanoAsync(ConfiguracionDasNano source)
		{
			return await _efRepository.UpdateAsync<ConfiguracionDasNano>(source);
		}

		/// <summary>
        /// Modifica una instancia de ConfiguracionDasNano en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionDasNano a modificar</param>
        /// <returns>Número de ConfiguracionDasNano modificados</returns>
		public int UpdateConfiguracionDasNano(ConfiguracionDasNano source)
		{
			return _efRepository.Update<ConfiguracionDasNano>(source);
		}

		/// <summary>
        /// Borra una instancia de ConfiguracionDasNano en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionDasNano a borrar</param>
        /// <returns>Número de ConfiguracionDasNano borrados</returns>
		public async Task<int> DeleteConfiguracionDasNanoAsync(ConfiguracionDasNano source)
		{
			return await _efRepository.DeleteAsync<ConfiguracionDasNano>(source);
		}

		/// <summary>
        /// Borra una instancia de ConfiguracionDasNano en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionDasNano a borrar</param>
        /// <returns>Número de ConfiguracionDasNano borrados</returns>
		public int DeleteConfiguracionDasNano(ConfiguracionDasNano source)
		{
			return _efRepository.Delete<ConfiguracionDasNano>(source);
		}
    }
}
