using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioRegistrosOperacionesBase
	{
		/// <summary>
        /// Metodo para obtener todos los RegistrosOperaciones 
        /// </summary>
        /// <returns>IQueryable con todos los RegistrosOperaciones</returns>
		IQueryable<RegistrosOperaciones> GetRegistrosOperaciones();
		
        
        /// <summary>
        /// Obtener un RegistrosOperaciones por su clave primaria
        /// </summary>
				/// <param name="idRegistroOperacion">IdRegistroOperacion</param>
		        /// <returns>RegistrosOperaciones   seleccionado por su clave primaria</returns>
		Task<RegistrosOperaciones> GetRegistrosOperacionesByPrimaryKeyAsync(int idRegistroOperacion);
		
        /// <summary>
        /// Obtener un RegistrosOperaciones por su clave primaria
        /// </summary>
				/// <param name="idRegistroOperacion">IdRegistroOperacion</param>
		        /// <returns>RegistrosOperaciones  seleccionado por su clave primaria</returns>
		RegistrosOperaciones GetRegistrosOperacionesByPrimaryKey(int idRegistroOperacion);


        


		/// <summary>
        /// Crea una instancia de RegistrosOperaciones en la base de datos
        /// </summary>
        /// <param name="source">RegistrosOperaciones a crear</param>
        /// <returns>RegistrosOperaciones creado</returns>
		Task<RegistrosOperaciones> CreateRegistrosOperacionesAsync(RegistrosOperaciones source);

		/// <summary>
        /// Crea una instancia de RegistrosOperaciones en la base de datos
        /// </summary>
        /// <param name="source">RegistrosOperaciones a crear</param>
        /// <returns>RegistrosOperaciones creado</returns>
		RegistrosOperaciones CreateRegistrosOperaciones(RegistrosOperaciones source);


		/// <summary>
        /// Modifica una instancia de RegistrosOperaciones en la base de datos
        /// </summary>
        /// <param name="source">RegistrosOperaciones a modificar</param>
        /// <returns>Número de RegistrosOperaciones modificados</returns>
		Task<int> UpdateRegistrosOperacionesAsync(RegistrosOperaciones source);
		

		/// <summary>
        /// Modifica una instancia de RegistrosOperaciones en la base de datos
        /// </summary>
        /// <param name="source">RegistrosOperaciones a modificar</param>
        /// <returns>Número de RegistrosOperaciones modificados</returns>
		int UpdateRegistrosOperaciones(RegistrosOperaciones source);

		/// <summary>
        /// Borra una instancia de RegistrosOperaciones en la base de datos
        /// </summary>
        /// <param name="source">RegistrosOperaciones a borrar</param>
        /// <returns>Número de RegistrosOperaciones borrados</returns>
		Task<int> DeleteRegistrosOperacionesAsync(RegistrosOperaciones source);
		
		/// <summary>
        /// Borra una instancia de RegistrosOperaciones en la base de datos
        /// </summary>
        /// <param name="source">RegistrosOperaciones a borrar</param>
        /// <returns>Número de RegistrosOperaciones borrados</returns>
		int DeleteRegistrosOperaciones(RegistrosOperaciones source);
    }
}
