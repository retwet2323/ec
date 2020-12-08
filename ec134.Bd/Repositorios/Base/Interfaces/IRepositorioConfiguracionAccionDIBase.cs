using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioConfiguracionAccionDIBase
	{
		/// <summary>
        /// Metodo para obtener todos los ConfiguracionAccionDI 
        /// </summary>
        /// <returns>IQueryable con todos los ConfiguracionAccionDI</returns>
		IQueryable<ConfiguracionAccionDI> GetConfiguracionAccionDI();
		
        
        /// <summary>
        /// Obtener un ConfiguracionAccionDI por su clave primaria
        /// </summary>
				/// <param name="idConfiguracionAccionDI">IdConfiguracionAccionDI</param>
		        /// <returns>ConfiguracionAccionDI   seleccionado por su clave primaria</returns>
		Task<ConfiguracionAccionDI> GetConfiguracionAccionDIByPrimaryKeyAsync(int idConfiguracionAccionDI);
		
        /// <summary>
        /// Obtener un ConfiguracionAccionDI por su clave primaria
        /// </summary>
				/// <param name="idConfiguracionAccionDI">IdConfiguracionAccionDI</param>
		        /// <returns>ConfiguracionAccionDI  seleccionado por su clave primaria</returns>
		ConfiguracionAccionDI GetConfiguracionAccionDIByPrimaryKey(int idConfiguracionAccionDI);


        


		/// <summary>
        /// Crea una instancia de ConfiguracionAccionDI en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionAccionDI a crear</param>
        /// <returns>ConfiguracionAccionDI creado</returns>
		Task<ConfiguracionAccionDI> CreateConfiguracionAccionDIAsync(ConfiguracionAccionDI source);

		/// <summary>
        /// Crea una instancia de ConfiguracionAccionDI en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionAccionDI a crear</param>
        /// <returns>ConfiguracionAccionDI creado</returns>
		ConfiguracionAccionDI CreateConfiguracionAccionDI(ConfiguracionAccionDI source);


		/// <summary>
        /// Modifica una instancia de ConfiguracionAccionDI en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionAccionDI a modificar</param>
        /// <returns>Número de ConfiguracionAccionDI modificados</returns>
		Task<int> UpdateConfiguracionAccionDIAsync(ConfiguracionAccionDI source);
		

		/// <summary>
        /// Modifica una instancia de ConfiguracionAccionDI en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionAccionDI a modificar</param>
        /// <returns>Número de ConfiguracionAccionDI modificados</returns>
		int UpdateConfiguracionAccionDI(ConfiguracionAccionDI source);

		/// <summary>
        /// Borra una instancia de ConfiguracionAccionDI en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionAccionDI a borrar</param>
        /// <returns>Número de ConfiguracionAccionDI borrados</returns>
		Task<int> DeleteConfiguracionAccionDIAsync(ConfiguracionAccionDI source);
		
		/// <summary>
        /// Borra una instancia de ConfiguracionAccionDI en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionAccionDI a borrar</param>
        /// <returns>Número de ConfiguracionAccionDI borrados</returns>
		int DeleteConfiguracionAccionDI(ConfiguracionAccionDI source);
    }
}
