using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioEstadosOperacionesBase
	{
		/// <summary>
        /// Metodo para obtener todos los EstadosOperaciones 
        /// </summary>
        /// <returns>IQueryable con todos los EstadosOperaciones</returns>
		IQueryable<EstadosOperaciones> GetEstadosOperaciones();
		
        
        /// <summary>
        /// Obtener un EstadosOperaciones por su clave primaria
        /// </summary>
				/// <param name="idEstadoOperacion">IdEstadoOperacion</param>
		        /// <returns>EstadosOperaciones   seleccionado por su clave primaria</returns>
		Task<EstadosOperaciones> GetEstadosOperacionesByPrimaryKeyAsync(int idEstadoOperacion);
		
        /// <summary>
        /// Obtener un EstadosOperaciones por su clave primaria
        /// </summary>
				/// <param name="idEstadoOperacion">IdEstadoOperacion</param>
		        /// <returns>EstadosOperaciones  seleccionado por su clave primaria</returns>
		EstadosOperaciones GetEstadosOperacionesByPrimaryKey(int idEstadoOperacion);


        


		/// <summary>
        /// Crea una instancia de EstadosOperaciones en la base de datos
        /// </summary>
        /// <param name="source">EstadosOperaciones a crear</param>
        /// <returns>EstadosOperaciones creado</returns>
		Task<EstadosOperaciones> CreateEstadosOperacionesAsync(EstadosOperaciones source);

		/// <summary>
        /// Crea una instancia de EstadosOperaciones en la base de datos
        /// </summary>
        /// <param name="source">EstadosOperaciones a crear</param>
        /// <returns>EstadosOperaciones creado</returns>
		EstadosOperaciones CreateEstadosOperaciones(EstadosOperaciones source);


		/// <summary>
        /// Modifica una instancia de EstadosOperaciones en la base de datos
        /// </summary>
        /// <param name="source">EstadosOperaciones a modificar</param>
        /// <returns>Número de EstadosOperaciones modificados</returns>
		Task<int> UpdateEstadosOperacionesAsync(EstadosOperaciones source);
		

		/// <summary>
        /// Modifica una instancia de EstadosOperaciones en la base de datos
        /// </summary>
        /// <param name="source">EstadosOperaciones a modificar</param>
        /// <returns>Número de EstadosOperaciones modificados</returns>
		int UpdateEstadosOperaciones(EstadosOperaciones source);

		/// <summary>
        /// Borra una instancia de EstadosOperaciones en la base de datos
        /// </summary>
        /// <param name="source">EstadosOperaciones a borrar</param>
        /// <returns>Número de EstadosOperaciones borrados</returns>
		Task<int> DeleteEstadosOperacionesAsync(EstadosOperaciones source);
		
		/// <summary>
        /// Borra una instancia de EstadosOperaciones en la base de datos
        /// </summary>
        /// <param name="source">EstadosOperaciones a borrar</param>
        /// <returns>Número de EstadosOperaciones borrados</returns>
		int DeleteEstadosOperaciones(EstadosOperaciones source);
    }
}
