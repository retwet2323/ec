using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioCofiguracionAccionCambioEstadoBase
	{
		/// <summary>
        /// Metodo para obtener todos los CofiguracionAccionCambioEstado 
        /// </summary>
        /// <returns>IQueryable con todos los CofiguracionAccionCambioEstado</returns>
		IQueryable<CofiguracionAccionCambioEstado> GetCofiguracionAccionCambioEstado();
		
        
        /// <summary>
        /// Obtener un CofiguracionAccionCambioEstado por su clave primaria
        /// </summary>
				/// <param name="idConfiguracioAccionCambioEstado">IdConfiguracioAccionCambioEstado</param>
		        /// <returns>CofiguracionAccionCambioEstado   seleccionado por su clave primaria</returns>
		Task<CofiguracionAccionCambioEstado> GetCofiguracionAccionCambioEstadoByPrimaryKeyAsync(int idConfiguracioAccionCambioEstado);
		
        /// <summary>
        /// Obtener un CofiguracionAccionCambioEstado por su clave primaria
        /// </summary>
				/// <param name="idConfiguracioAccionCambioEstado">IdConfiguracioAccionCambioEstado</param>
		        /// <returns>CofiguracionAccionCambioEstado  seleccionado por su clave primaria</returns>
		CofiguracionAccionCambioEstado GetCofiguracionAccionCambioEstadoByPrimaryKey(int idConfiguracioAccionCambioEstado);


        


		/// <summary>
        /// Crea una instancia de CofiguracionAccionCambioEstado en la base de datos
        /// </summary>
        /// <param name="source">CofiguracionAccionCambioEstado a crear</param>
        /// <returns>CofiguracionAccionCambioEstado creado</returns>
		Task<CofiguracionAccionCambioEstado> CreateCofiguracionAccionCambioEstadoAsync(CofiguracionAccionCambioEstado source);

		/// <summary>
        /// Crea una instancia de CofiguracionAccionCambioEstado en la base de datos
        /// </summary>
        /// <param name="source">CofiguracionAccionCambioEstado a crear</param>
        /// <returns>CofiguracionAccionCambioEstado creado</returns>
		CofiguracionAccionCambioEstado CreateCofiguracionAccionCambioEstado(CofiguracionAccionCambioEstado source);


		/// <summary>
        /// Modifica una instancia de CofiguracionAccionCambioEstado en la base de datos
        /// </summary>
        /// <param name="source">CofiguracionAccionCambioEstado a modificar</param>
        /// <returns>Número de CofiguracionAccionCambioEstado modificados</returns>
		Task<int> UpdateCofiguracionAccionCambioEstadoAsync(CofiguracionAccionCambioEstado source);
		

		/// <summary>
        /// Modifica una instancia de CofiguracionAccionCambioEstado en la base de datos
        /// </summary>
        /// <param name="source">CofiguracionAccionCambioEstado a modificar</param>
        /// <returns>Número de CofiguracionAccionCambioEstado modificados</returns>
		int UpdateCofiguracionAccionCambioEstado(CofiguracionAccionCambioEstado source);

		/// <summary>
        /// Borra una instancia de CofiguracionAccionCambioEstado en la base de datos
        /// </summary>
        /// <param name="source">CofiguracionAccionCambioEstado a borrar</param>
        /// <returns>Número de CofiguracionAccionCambioEstado borrados</returns>
		Task<int> DeleteCofiguracionAccionCambioEstadoAsync(CofiguracionAccionCambioEstado source);
		
		/// <summary>
        /// Borra una instancia de CofiguracionAccionCambioEstado en la base de datos
        /// </summary>
        /// <param name="source">CofiguracionAccionCambioEstado a borrar</param>
        /// <returns>Número de CofiguracionAccionCambioEstado borrados</returns>
		int DeleteCofiguracionAccionCambioEstado(CofiguracionAccionCambioEstado source);
    }
}
