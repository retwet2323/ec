using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioConfiguracionLogaltyBase
	{
		/// <summary>
        /// Metodo para obtener todos los ConfiguracionLogalty 
        /// </summary>
        /// <returns>IQueryable con todos los ConfiguracionLogalty</returns>
		IQueryable<ConfiguracionLogalty> GetConfiguracionLogalty();
		
        
        /// <summary>
        /// Obtener un ConfiguracionLogalty por su clave primaria
        /// </summary>
				/// <param name="idConfiguracionLogalty">IdConfiguracionLogalty</param>
		        /// <returns>ConfiguracionLogalty   seleccionado por su clave primaria</returns>
		Task<ConfiguracionLogalty> GetConfiguracionLogaltyByPrimaryKeyAsync(int idConfiguracionLogalty);
		
        /// <summary>
        /// Obtener un ConfiguracionLogalty por su clave primaria
        /// </summary>
				/// <param name="idConfiguracionLogalty">IdConfiguracionLogalty</param>
		        /// <returns>ConfiguracionLogalty  seleccionado por su clave primaria</returns>
		ConfiguracionLogalty GetConfiguracionLogaltyByPrimaryKey(int idConfiguracionLogalty);


        


		/// <summary>
        /// Crea una instancia de ConfiguracionLogalty en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionLogalty a crear</param>
        /// <returns>ConfiguracionLogalty creado</returns>
		Task<ConfiguracionLogalty> CreateConfiguracionLogaltyAsync(ConfiguracionLogalty source);

		/// <summary>
        /// Crea una instancia de ConfiguracionLogalty en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionLogalty a crear</param>
        /// <returns>ConfiguracionLogalty creado</returns>
		ConfiguracionLogalty CreateConfiguracionLogalty(ConfiguracionLogalty source);


		/// <summary>
        /// Modifica una instancia de ConfiguracionLogalty en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionLogalty a modificar</param>
        /// <returns>Número de ConfiguracionLogalty modificados</returns>
		Task<int> UpdateConfiguracionLogaltyAsync(ConfiguracionLogalty source);
		

		/// <summary>
        /// Modifica una instancia de ConfiguracionLogalty en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionLogalty a modificar</param>
        /// <returns>Número de ConfiguracionLogalty modificados</returns>
		int UpdateConfiguracionLogalty(ConfiguracionLogalty source);

		/// <summary>
        /// Borra una instancia de ConfiguracionLogalty en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionLogalty a borrar</param>
        /// <returns>Número de ConfiguracionLogalty borrados</returns>
		Task<int> DeleteConfiguracionLogaltyAsync(ConfiguracionLogalty source);
		
		/// <summary>
        /// Borra una instancia de ConfiguracionLogalty en la base de datos
        /// </summary>
        /// <param name="source">ConfiguracionLogalty a borrar</param>
        /// <returns>Número de ConfiguracionLogalty borrados</returns>
		int DeleteConfiguracionLogalty(ConfiguracionLogalty source);
    }
}
