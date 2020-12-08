using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioConfiguracionDenegadasBase : IRepositorioConfiguracionDenegadasBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase ConfiguracionDenegadas 
        /// </summary>
		public RepositorioConfiguracionDenegadasBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los ConfiguracionDenegadas 
        /// </summary>
        /// <returns>IQueryable con todos los ConfiguracionDenegadas</returns>
		public IQueryable<ConfiguracionDenegadas> GetConfiguracionDenegadas()
		{
			return _efRepository.All<ConfiguracionDenegadas>();
		}

        
        /// <summary>
        /// Obtener un ConfiguracionDenegadas por su clave primaria
        /// </summary>
		/// <param name="idConfiguracionDenegada">IdConfiguracionDenegada</param>
        /// <returns>ConfiguracionDenegadas   seleccionado por su clave primaria</returns>
		public async Task<ConfiguracionDenegadas> GetConfiguracionDenegadasByPrimaryKeyAsync(int idConfiguracionDenegada)
		{
			return await _efRepository.FindAsync<ConfiguracionDenegadas>(x=>x.IdConfiguracionDenegada == idConfiguracionDenegada);
		}

        /// <summary>
        /// Obtener un ConfiguracionDenegadas por su clave primaria
        /// </summary>
		/// <param name="idConfiguracionDenegada">IdConfiguracionDenegada</param>
        /// <returns>ConfiguracionDenegadas  seleccionado por su clave primaria</returns>
		public ConfiguracionDenegadas GetConfiguracionDenegadasByPrimaryKey(int idConfiguracionDenegada)
		{
			return _efRepository.Find<ConfiguracionDenegadas>(x=>x.IdConfiguracionDenegada == idConfiguracionDenegada);
		}




		/// <summary>
        /// Crea una instancia de ConfiguracionDenegadas en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionDenegadas a crear</param>
        /// <returns>ConfiguracionDenegadas creado</returns>
		public virtual async Task<ConfiguracionDenegadas> CreateConfiguracionDenegadasAsync(ConfiguracionDenegadas source)
		{
			return await _efRepository.CreateAsync<ConfiguracionDenegadas>(source);
		}

		/// <summary>
        /// Crea una instancia de ConfiguracionDenegadas en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionDenegadas a crear</param>
        /// <returns>ConfiguracionDenegadas creado</returns>
		public virtual ConfiguracionDenegadas CreateConfiguracionDenegadas(ConfiguracionDenegadas source)
		{
			return _efRepository.Create<ConfiguracionDenegadas>(source);
		}


		/// <summary>
        /// Modifica una instancia de ConfiguracionDenegadas en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionDenegadas a modificar</param>
        /// <returns>Número de ConfiguracionDenegadas modificados</returns>
		public async Task<int> UpdateConfiguracionDenegadasAsync(ConfiguracionDenegadas source)
		{
			return await _efRepository.UpdateAsync<ConfiguracionDenegadas>(source);
		}

		/// <summary>
        /// Modifica una instancia de ConfiguracionDenegadas en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionDenegadas a modificar</param>
        /// <returns>Número de ConfiguracionDenegadas modificados</returns>
		public int UpdateConfiguracionDenegadas(ConfiguracionDenegadas source)
		{
			return _efRepository.Update<ConfiguracionDenegadas>(source);
		}

		/// <summary>
        /// Borra una instancia de ConfiguracionDenegadas en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionDenegadas a borrar</param>
        /// <returns>Número de ConfiguracionDenegadas borrados</returns>
		public async Task<int> DeleteConfiguracionDenegadasAsync(ConfiguracionDenegadas source)
		{
			return await _efRepository.DeleteAsync<ConfiguracionDenegadas>(source);
		}

		/// <summary>
        /// Borra una instancia de ConfiguracionDenegadas en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionDenegadas a borrar</param>
        /// <returns>Número de ConfiguracionDenegadas borrados</returns>
		public int DeleteConfiguracionDenegadas(ConfiguracionDenegadas source)
		{
			return _efRepository.Delete<ConfiguracionDenegadas>(source);
		}
    }
}
