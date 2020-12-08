using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioValidacionesDasNanoBase
	{
		/// <summary>
        /// Metodo para obtener todos los ValidacionesDasNano 
        /// </summary>
        /// <returns>IQueryable con todos los ValidacionesDasNano</returns>
		IQueryable<ValidacionesDasNano> GetValidacionesDasNano();
		
        
        /// <summary>
        /// Obtener un ValidacionesDasNano por su clave primaria
        /// </summary>
				/// <param name="idValidacionDasNano">IdValidacionDasNano</param>
		        /// <returns>ValidacionesDasNano   seleccionado por su clave primaria</returns>
		Task<ValidacionesDasNano> GetValidacionesDasNanoByPrimaryKeyAsync(int idValidacionDasNano);
		
        /// <summary>
        /// Obtener un ValidacionesDasNano por su clave primaria
        /// </summary>
				/// <param name="idValidacionDasNano">IdValidacionDasNano</param>
		        /// <returns>ValidacionesDasNano  seleccionado por su clave primaria</returns>
		ValidacionesDasNano GetValidacionesDasNanoByPrimaryKey(int idValidacionDasNano);


        

        /// <summary>
        /// Obtener un IQueryable<ValidacionesDasNano> por su IdTransaccionDasNano 
        /// </summary>
		/// <param name="idTransaccionDasNano">IdTransaccionDasNano</param>
        /// <returns>IQueryable con los ValidacionesDasNano seleccionado por su IdTransaccionDasNano </returns>
        IQueryable<ValidacionesDasNano> GetValidacionesDasNanoByIdTransaccionDasNano(int idTransaccionDasNano);


		/// <summary>
        /// Crea una instancia de ValidacionesDasNano en la base de datos
        /// </summary>
        /// <param name="source">ValidacionesDasNano a crear</param>
        /// <returns>ValidacionesDasNano creado</returns>
		Task<ValidacionesDasNano> CreateValidacionesDasNanoAsync(ValidacionesDasNano source);

		/// <summary>
        /// Crea una instancia de ValidacionesDasNano en la base de datos
        /// </summary>
        /// <param name="source">ValidacionesDasNano a crear</param>
        /// <returns>ValidacionesDasNano creado</returns>
		ValidacionesDasNano CreateValidacionesDasNano(ValidacionesDasNano source);


		/// <summary>
        /// Modifica una instancia de ValidacionesDasNano en la base de datos
        /// </summary>
        /// <param name="source">ValidacionesDasNano a modificar</param>
        /// <returns>Número de ValidacionesDasNano modificados</returns>
		Task<int> UpdateValidacionesDasNanoAsync(ValidacionesDasNano source);
		

		/// <summary>
        /// Modifica una instancia de ValidacionesDasNano en la base de datos
        /// </summary>
        /// <param name="source">ValidacionesDasNano a modificar</param>
        /// <returns>Número de ValidacionesDasNano modificados</returns>
		int UpdateValidacionesDasNano(ValidacionesDasNano source);

		/// <summary>
        /// Borra una instancia de ValidacionesDasNano en la base de datos
        /// </summary>
        /// <param name="source">ValidacionesDasNano a borrar</param>
        /// <returns>Número de ValidacionesDasNano borrados</returns>
		Task<int> DeleteValidacionesDasNanoAsync(ValidacionesDasNano source);
		
		/// <summary>
        /// Borra una instancia de ValidacionesDasNano en la base de datos
        /// </summary>
        /// <param name="source">ValidacionesDasNano a borrar</param>
        /// <returns>Número de ValidacionesDasNano borrados</returns>
		int DeleteValidacionesDasNano(ValidacionesDasNano source);
    }
}
