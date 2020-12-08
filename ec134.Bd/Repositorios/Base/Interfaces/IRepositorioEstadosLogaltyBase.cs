using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioEstadosLogaltyBase
	{
		/// <summary>
        /// Metodo para obtener todos los EstadosLogalty 
        /// </summary>
        /// <returns>IQueryable con todos los EstadosLogalty</returns>
		IQueryable<EstadosLogalty> GetEstadosLogalty();
		
        
        /// <summary>
        /// Obtener un EstadosLogalty por su clave primaria
        /// </summary>
				/// <param name="idEstadoLogalty">IdEstadoLogalty</param>
		        /// <returns>EstadosLogalty   seleccionado por su clave primaria</returns>
		Task<EstadosLogalty> GetEstadosLogaltyByPrimaryKeyAsync(int idEstadoLogalty);
		
        /// <summary>
        /// Obtener un EstadosLogalty por su clave primaria
        /// </summary>
				/// <param name="idEstadoLogalty">IdEstadoLogalty</param>
		        /// <returns>EstadosLogalty  seleccionado por su clave primaria</returns>
		EstadosLogalty GetEstadosLogaltyByPrimaryKey(int idEstadoLogalty);


        


		/// <summary>
        /// Crea una instancia de EstadosLogalty en la base de datos
        /// </summary>
        /// <param name="source">EstadosLogalty a crear</param>
        /// <returns>EstadosLogalty creado</returns>
		Task<EstadosLogalty> CreateEstadosLogaltyAsync(EstadosLogalty source);

		/// <summary>
        /// Crea una instancia de EstadosLogalty en la base de datos
        /// </summary>
        /// <param name="source">EstadosLogalty a crear</param>
        /// <returns>EstadosLogalty creado</returns>
		EstadosLogalty CreateEstadosLogalty(EstadosLogalty source);


		/// <summary>
        /// Modifica una instancia de EstadosLogalty en la base de datos
        /// </summary>
        /// <param name="source">EstadosLogalty a modificar</param>
        /// <returns>Número de EstadosLogalty modificados</returns>
		Task<int> UpdateEstadosLogaltyAsync(EstadosLogalty source);
		

		/// <summary>
        /// Modifica una instancia de EstadosLogalty en la base de datos
        /// </summary>
        /// <param name="source">EstadosLogalty a modificar</param>
        /// <returns>Número de EstadosLogalty modificados</returns>
		int UpdateEstadosLogalty(EstadosLogalty source);

		/// <summary>
        /// Borra una instancia de EstadosLogalty en la base de datos
        /// </summary>
        /// <param name="source">EstadosLogalty a borrar</param>
        /// <returns>Número de EstadosLogalty borrados</returns>
		Task<int> DeleteEstadosLogaltyAsync(EstadosLogalty source);
		
		/// <summary>
        /// Borra una instancia de EstadosLogalty en la base de datos
        /// </summary>
        /// <param name="source">EstadosLogalty a borrar</param>
        /// <returns>Número de EstadosLogalty borrados</returns>
		int DeleteEstadosLogalty(EstadosLogalty source);
    }
}
