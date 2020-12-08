using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioConfiguracionDenegadasBase
	{
		/// <summary>
        /// Metodo para obtener todos los ConfiguracionDenegadas 
        /// </summary>
        /// <returns>IQueryable con todos los ConfiguracionDenegadas</returns>
		IQueryable<ConfiguracionDenegadas> GetConfiguracionDenegadas();
		
        
        /// <summary>
        /// Obtener un ConfiguracionDenegadas por su clave primaria
        /// </summary>
				/// <param name="idConfiguracionDenegada">IdConfiguracionDenegada</param>
		        /// <returns>ConfiguracionDenegadas   seleccionado por su clave primaria</returns>
		Task<ConfiguracionDenegadas> GetConfiguracionDenegadasByPrimaryKeyAsync(int idConfiguracionDenegada);
		
        /// <summary>
        /// Obtener un ConfiguracionDenegadas por su clave primaria
        /// </summary>
				/// <param name="idConfiguracionDenegada">IdConfiguracionDenegada</param>
		        /// <returns>ConfiguracionDenegadas  seleccionado por su clave primaria</returns>
		ConfiguracionDenegadas GetConfiguracionDenegadasByPrimaryKey(int idConfiguracionDenegada);


        


		/// <summary>
        /// Crea una instancia de ConfiguracionDenegadas en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionDenegadas a crear</param>
        /// <returns>ConfiguracionDenegadas creado</returns>
		Task<ConfiguracionDenegadas> CreateConfiguracionDenegadasAsync(ConfiguracionDenegadas source);

		/// <summary>
        /// Crea una instancia de ConfiguracionDenegadas en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionDenegadas a crear</param>
        /// <returns>ConfiguracionDenegadas creado</returns>
		ConfiguracionDenegadas CreateConfiguracionDenegadas(ConfiguracionDenegadas source);


		/// <summary>
        /// Modifica una instancia de ConfiguracionDenegadas en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionDenegadas a modificar</param>
        /// <returns>Número de ConfiguracionDenegadas modificados</returns>
		Task<int> UpdateConfiguracionDenegadasAsync(ConfiguracionDenegadas source);
		

		/// <summary>
        /// Modifica una instancia de ConfiguracionDenegadas en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionDenegadas a modificar</param>
        /// <returns>Número de ConfiguracionDenegadas modificados</returns>
		int UpdateConfiguracionDenegadas(ConfiguracionDenegadas source);

		/// <summary>
        /// Borra una instancia de ConfiguracionDenegadas en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionDenegadas a borrar</param>
        /// <returns>Número de ConfiguracionDenegadas borrados</returns>
		Task<int> DeleteConfiguracionDenegadasAsync(ConfiguracionDenegadas source);
		
		/// <summary>
        /// Borra una instancia de ConfiguracionDenegadas en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionDenegadas a borrar</param>
        /// <returns>Número de ConfiguracionDenegadas borrados</returns>
		int DeleteConfiguracionDenegadas(ConfiguracionDenegadas source);
    }
}
