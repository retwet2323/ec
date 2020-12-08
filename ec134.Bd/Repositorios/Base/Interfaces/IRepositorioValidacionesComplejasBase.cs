using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioValidacionesComplejasBase
	{
		/// <summary>
        /// Metodo para obtener todos los ValidacionesComplejas 
        /// </summary>
        /// <returns>IQueryable con todos los ValidacionesComplejas</returns>
		IQueryable<ValidacionesComplejas> GetValidacionesComplejas();
		
        
        /// <summary>
        /// Obtener un ValidacionesComplejas por su clave primaria
        /// </summary>
				/// <param name="idValidacionCompleja">IdValidacionCompleja</param>
		        /// <returns>ValidacionesComplejas   seleccionado por su clave primaria</returns>
		Task<ValidacionesComplejas> GetValidacionesComplejasByPrimaryKeyAsync(int idValidacionCompleja);
		
        /// <summary>
        /// Obtener un ValidacionesComplejas por su clave primaria
        /// </summary>
				/// <param name="idValidacionCompleja">IdValidacionCompleja</param>
		        /// <returns>ValidacionesComplejas  seleccionado por su clave primaria</returns>
		ValidacionesComplejas GetValidacionesComplejasByPrimaryKey(int idValidacionCompleja);


        


		/// <summary>
        /// Crea una instancia de ValidacionesComplejas en la base de datos
        /// </summary>
        /// <param name="source">ValidacionesComplejas a crear</param>
        /// <returns>ValidacionesComplejas creado</returns>
		Task<ValidacionesComplejas> CreateValidacionesComplejasAsync(ValidacionesComplejas source);

		/// <summary>
        /// Crea una instancia de ValidacionesComplejas en la base de datos
        /// </summary>
        /// <param name="source">ValidacionesComplejas a crear</param>
        /// <returns>ValidacionesComplejas creado</returns>
		ValidacionesComplejas CreateValidacionesComplejas(ValidacionesComplejas source);


		/// <summary>
        /// Modifica una instancia de ValidacionesComplejas en la base de datos
        /// </summary>
        /// <param name="source">ValidacionesComplejas a modificar</param>
        /// <returns>Número de ValidacionesComplejas modificados</returns>
		Task<int> UpdateValidacionesComplejasAsync(ValidacionesComplejas source);
		

		/// <summary>
        /// Modifica una instancia de ValidacionesComplejas en la base de datos
        /// </summary>
        /// <param name="source">ValidacionesComplejas a modificar</param>
        /// <returns>Número de ValidacionesComplejas modificados</returns>
		int UpdateValidacionesComplejas(ValidacionesComplejas source);

		/// <summary>
        /// Borra una instancia de ValidacionesComplejas en la base de datos
        /// </summary>
        /// <param name="source">ValidacionesComplejas a borrar</param>
        /// <returns>Número de ValidacionesComplejas borrados</returns>
		Task<int> DeleteValidacionesComplejasAsync(ValidacionesComplejas source);
		
		/// <summary>
        /// Borra una instancia de ValidacionesComplejas en la base de datos
        /// </summary>
        /// <param name="source">ValidacionesComplejas a borrar</param>
        /// <returns>Número de ValidacionesComplejas borrados</returns>
		int DeleteValidacionesComplejas(ValidacionesComplejas source);
    }
}
