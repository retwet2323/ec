using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioConfiguracionAccionSMTPBase
	{
		/// <summary>
        /// Metodo para obtener todos los ConfiguracionAccionSMTP 
        /// </summary>
        /// <returns>IQueryable con todos los ConfiguracionAccionSMTP</returns>
		IQueryable<ConfiguracionAccionSMTP> GetConfiguracionAccionSMTP();
		
        
        /// <summary>
        /// Obtener un ConfiguracionAccionSMTP por su clave primaria
        /// </summary>
				/// <param name="idConfiguracionaAccionSMTP">IdConfiguracionaAccionSMTP</param>
		        /// <returns>ConfiguracionAccionSMTP   seleccionado por su clave primaria</returns>
		Task<ConfiguracionAccionSMTP> GetConfiguracionAccionSMTPByPrimaryKeyAsync(int idConfiguracionaAccionSMTP);
		
        /// <summary>
        /// Obtener un ConfiguracionAccionSMTP por su clave primaria
        /// </summary>
				/// <param name="idConfiguracionaAccionSMTP">IdConfiguracionaAccionSMTP</param>
		        /// <returns>ConfiguracionAccionSMTP  seleccionado por su clave primaria</returns>
		ConfiguracionAccionSMTP GetConfiguracionAccionSMTPByPrimaryKey(int idConfiguracionaAccionSMTP);


        


		/// <summary>
        /// Crea una instancia de ConfiguracionAccionSMTP en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionAccionSMTP a crear</param>
        /// <returns>ConfiguracionAccionSMTP creado</returns>
		Task<ConfiguracionAccionSMTP> CreateConfiguracionAccionSMTPAsync(ConfiguracionAccionSMTP source);

		/// <summary>
        /// Crea una instancia de ConfiguracionAccionSMTP en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionAccionSMTP a crear</param>
        /// <returns>ConfiguracionAccionSMTP creado</returns>
		ConfiguracionAccionSMTP CreateConfiguracionAccionSMTP(ConfiguracionAccionSMTP source);


		/// <summary>
        /// Modifica una instancia de ConfiguracionAccionSMTP en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionAccionSMTP a modificar</param>
        /// <returns>Número de ConfiguracionAccionSMTP modificados</returns>
		Task<int> UpdateConfiguracionAccionSMTPAsync(ConfiguracionAccionSMTP source);
		

		/// <summary>
        /// Modifica una instancia de ConfiguracionAccionSMTP en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionAccionSMTP a modificar</param>
        /// <returns>Número de ConfiguracionAccionSMTP modificados</returns>
		int UpdateConfiguracionAccionSMTP(ConfiguracionAccionSMTP source);

		/// <summary>
        /// Borra una instancia de ConfiguracionAccionSMTP en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionAccionSMTP a borrar</param>
        /// <returns>Número de ConfiguracionAccionSMTP borrados</returns>
		Task<int> DeleteConfiguracionAccionSMTPAsync(ConfiguracionAccionSMTP source);
		
		/// <summary>
        /// Borra una instancia de ConfiguracionAccionSMTP en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionAccionSMTP a borrar</param>
        /// <returns>Número de ConfiguracionAccionSMTP borrados</returns>
		int DeleteConfiguracionAccionSMTP(ConfiguracionAccionSMTP source);
    }
}
