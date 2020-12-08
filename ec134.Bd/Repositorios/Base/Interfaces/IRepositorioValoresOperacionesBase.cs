using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioValoresOperacionesBase
	{
		/// <summary>
        /// Metodo para obtener todos los ValoresOperaciones 
        /// </summary>
        /// <returns>IQueryable con todos los ValoresOperaciones</returns>
		IQueryable<ValoresOperaciones> GetValoresOperaciones();
		
        
        /// <summary>
        /// Obtener un ValoresOperaciones por su clave primaria
        /// </summary>
				/// <param name="idValorOperacion">IdValorOperacion</param>
		        /// <returns>ValoresOperaciones   seleccionado por su clave primaria</returns>
		Task<ValoresOperaciones> GetValoresOperacionesByPrimaryKeyAsync(int idValorOperacion);
		
        /// <summary>
        /// Obtener un ValoresOperaciones por su clave primaria
        /// </summary>
				/// <param name="idValorOperacion">IdValorOperacion</param>
		        /// <returns>ValoresOperaciones  seleccionado por su clave primaria</returns>
		ValoresOperaciones GetValoresOperacionesByPrimaryKey(int idValorOperacion);


        

        /// <summary>
        /// Obtener un IQueryable<ValoresOperaciones> por su IdOperacion 
        /// </summary>
		/// <param name="idOperacion">IdOperacion</param>
        /// <returns>IQueryable con los ValoresOperaciones seleccionado por su IdOperacion </returns>
        IQueryable<ValoresOperaciones> GetValoresOperacionesByIdOperacion(int idOperacion);


		/// <summary>
        /// Crea una instancia de ValoresOperaciones en la base de datos
        /// </summary>
        /// <param name="source">ValoresOperaciones a crear</param>
        /// <returns>ValoresOperaciones creado</returns>
		Task<ValoresOperaciones> CreateValoresOperacionesAsync(ValoresOperaciones source);

		/// <summary>
        /// Crea una instancia de ValoresOperaciones en la base de datos
        /// </summary>
        /// <param name="source">ValoresOperaciones a crear</param>
        /// <returns>ValoresOperaciones creado</returns>
		ValoresOperaciones CreateValoresOperaciones(ValoresOperaciones source);


		/// <summary>
        /// Modifica una instancia de ValoresOperaciones en la base de datos
        /// </summary>
        /// <param name="source">ValoresOperaciones a modificar</param>
        /// <returns>Número de ValoresOperaciones modificados</returns>
		Task<int> UpdateValoresOperacionesAsync(ValoresOperaciones source);
		

		/// <summary>
        /// Modifica una instancia de ValoresOperaciones en la base de datos
        /// </summary>
        /// <param name="source">ValoresOperaciones a modificar</param>
        /// <returns>Número de ValoresOperaciones modificados</returns>
		int UpdateValoresOperaciones(ValoresOperaciones source);

		/// <summary>
        /// Borra una instancia de ValoresOperaciones en la base de datos
        /// </summary>
        /// <param name="source">ValoresOperaciones a borrar</param>
        /// <returns>Número de ValoresOperaciones borrados</returns>
		Task<int> DeleteValoresOperacionesAsync(ValoresOperaciones source);
		
		/// <summary>
        /// Borra una instancia de ValoresOperaciones en la base de datos
        /// </summary>
        /// <param name="source">ValoresOperaciones a borrar</param>
        /// <returns>Número de ValoresOperaciones borrados</returns>
		int DeleteValoresOperaciones(ValoresOperaciones source);
    }
}
