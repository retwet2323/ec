using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioConfiguracionDasNanoBase
	{
		/// <summary>
        /// Metodo para obtener todos los ConfiguracionDasNano 
        /// </summary>
        /// <returns>IQueryable con todos los ConfiguracionDasNano</returns>
		IQueryable<ConfiguracionDasNano> GetConfiguracionDasNano();
		
        
        /// <summary>
        /// Obtener un ConfiguracionDasNano por su clave primaria
        /// </summary>
				/// <param name="idConfiguracionDasNano">IdConfiguracionDasNano</param>
		        /// <returns>ConfiguracionDasNano   seleccionado por su clave primaria</returns>
		Task<ConfiguracionDasNano> GetConfiguracionDasNanoByPrimaryKeyAsync(int idConfiguracionDasNano);
		
        /// <summary>
        /// Obtener un ConfiguracionDasNano por su clave primaria
        /// </summary>
				/// <param name="idConfiguracionDasNano">IdConfiguracionDasNano</param>
		        /// <returns>ConfiguracionDasNano  seleccionado por su clave primaria</returns>
		ConfiguracionDasNano GetConfiguracionDasNanoByPrimaryKey(int idConfiguracionDasNano);


        


		/// <summary>
        /// Crea una instancia de ConfiguracionDasNano en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionDasNano a crear</param>
        /// <returns>ConfiguracionDasNano creado</returns>
		Task<ConfiguracionDasNano> CreateConfiguracionDasNanoAsync(ConfiguracionDasNano source);

		/// <summary>
        /// Crea una instancia de ConfiguracionDasNano en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionDasNano a crear</param>
        /// <returns>ConfiguracionDasNano creado</returns>
		ConfiguracionDasNano CreateConfiguracionDasNano(ConfiguracionDasNano source);


		/// <summary>
        /// Modifica una instancia de ConfiguracionDasNano en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionDasNano a modificar</param>
        /// <returns>Número de ConfiguracionDasNano modificados</returns>
		Task<int> UpdateConfiguracionDasNanoAsync(ConfiguracionDasNano source);
		

		/// <summary>
        /// Modifica una instancia de ConfiguracionDasNano en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionDasNano a modificar</param>
        /// <returns>Número de ConfiguracionDasNano modificados</returns>
		int UpdateConfiguracionDasNano(ConfiguracionDasNano source);

		/// <summary>
        /// Borra una instancia de ConfiguracionDasNano en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionDasNano a borrar</param>
        /// <returns>Número de ConfiguracionDasNano borrados</returns>
		Task<int> DeleteConfiguracionDasNanoAsync(ConfiguracionDasNano source);
		
		/// <summary>
        /// Borra una instancia de ConfiguracionDasNano en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionDasNano a borrar</param>
        /// <returns>Número de ConfiguracionDasNano borrados</returns>
		int DeleteConfiguracionDasNano(ConfiguracionDasNano source);
    }
}
