using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioOperacionesBase
	{
		/// <summary>
        /// Metodo para obtener todos los Operaciones 
        /// </summary>
        /// <returns>IQueryable con todos los Operaciones</returns>
		IQueryable<Operaciones> GetOperaciones();
		
        
        /// <summary>
        /// Obtener un Operaciones por su clave primaria
        /// </summary>
				/// <param name="idOperacion">IdOperacion</param>
		        /// <returns>Operaciones   seleccionado por su clave primaria</returns>
		Task<Operaciones> GetOperacionesByPrimaryKeyAsync(int idOperacion);
		
        /// <summary>
        /// Obtener un Operaciones por su clave primaria
        /// </summary>
				/// <param name="idOperacion">IdOperacion</param>
		        /// <returns>Operaciones  seleccionado por su clave primaria</returns>
		Operaciones GetOperacionesByPrimaryKey(int idOperacion);


        


		/// <summary>
        /// Crea una instancia de Operaciones en la base de datos
        /// </summary>
        /// <param name="source">Operaciones a crear</param>
        /// <returns>Operaciones creado</returns>
		Task<Operaciones> CreateOperacionesAsync(Operaciones source);

		/// <summary>
        /// Crea una instancia de Operaciones en la base de datos
        /// </summary>
        /// <param name="source">Operaciones a crear</param>
        /// <returns>Operaciones creado</returns>
		Operaciones CreateOperaciones(Operaciones source);


		/// <summary>
        /// Modifica una instancia de Operaciones en la base de datos
        /// </summary>
        /// <param name="source">Operaciones a modificar</param>
        /// <returns>Número de Operaciones modificados</returns>
		Task<int> UpdateOperacionesAsync(Operaciones source);
		

		/// <summary>
        /// Modifica una instancia de Operaciones en la base de datos
        /// </summary>
        /// <param name="source">Operaciones a modificar</param>
        /// <returns>Número de Operaciones modificados</returns>
		int UpdateOperaciones(Operaciones source);

		/// <summary>
        /// Borra una instancia de Operaciones en la base de datos
        /// </summary>
        /// <param name="source">Operaciones a borrar</param>
        /// <returns>Número de Operaciones borrados</returns>
		Task<int> DeleteOperacionesAsync(Operaciones source);
		
		/// <summary>
        /// Borra una instancia de Operaciones en la base de datos
        /// </summary>
        /// <param name="source">Operaciones a borrar</param>
        /// <returns>Número de Operaciones borrados</returns>
		int DeleteOperaciones(Operaciones source);
    }
}
