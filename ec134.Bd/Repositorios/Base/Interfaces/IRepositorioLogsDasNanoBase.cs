using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioLogsDasNanoBase
	{
		/// <summary>
        /// Metodo para obtener todos los LogsDasNano 
        /// </summary>
        /// <returns>IQueryable con todos los LogsDasNano</returns>
		IQueryable<LogsDasNano> GetLogsDasNano();
		
        
        /// <summary>
        /// Obtener un LogsDasNano por su clave primaria
        /// </summary>
				/// <param name="idLogsDasNano">IdLogsDasNano</param>
		        /// <returns>LogsDasNano   seleccionado por su clave primaria</returns>
		Task<LogsDasNano> GetLogsDasNanoByPrimaryKeyAsync(int idLogsDasNano);
		
        /// <summary>
        /// Obtener un LogsDasNano por su clave primaria
        /// </summary>
				/// <param name="idLogsDasNano">IdLogsDasNano</param>
		        /// <returns>LogsDasNano  seleccionado por su clave primaria</returns>
		LogsDasNano GetLogsDasNanoByPrimaryKey(int idLogsDasNano);


        

        /// <summary>
        /// Obtener un IQueryable<LogsDasNano> por su IdTransaccionDasNano 
        /// </summary>
		/// <param name="idTransaccionDasNano">IdTransaccionDasNano</param>
        /// <returns>IQueryable con los LogsDasNano seleccionado por su IdTransaccionDasNano </returns>
        IQueryable<LogsDasNano> GetLogsDasNanoByIdTransaccionDasNano(int idTransaccionDasNano);


		/// <summary>
        /// Crea una instancia de LogsDasNano en la base de datos
        /// </summary>
        /// <param name="source">LogsDasNano a crear</param>
        /// <returns>LogsDasNano creado</returns>
		Task<LogsDasNano> CreateLogsDasNanoAsync(LogsDasNano source);

		/// <summary>
        /// Crea una instancia de LogsDasNano en la base de datos
        /// </summary>
        /// <param name="source">LogsDasNano a crear</param>
        /// <returns>LogsDasNano creado</returns>
		LogsDasNano CreateLogsDasNano(LogsDasNano source);


		/// <summary>
        /// Modifica una instancia de LogsDasNano en la base de datos
        /// </summary>
        /// <param name="source">LogsDasNano a modificar</param>
        /// <returns>Número de LogsDasNano modificados</returns>
		Task<int> UpdateLogsDasNanoAsync(LogsDasNano source);
		

		/// <summary>
        /// Modifica una instancia de LogsDasNano en la base de datos
        /// </summary>
        /// <param name="source">LogsDasNano a modificar</param>
        /// <returns>Número de LogsDasNano modificados</returns>
		int UpdateLogsDasNano(LogsDasNano source);

		/// <summary>
        /// Borra una instancia de LogsDasNano en la base de datos
        /// </summary>
        /// <param name="source">LogsDasNano a borrar</param>
        /// <returns>Número de LogsDasNano borrados</returns>
		Task<int> DeleteLogsDasNanoAsync(LogsDasNano source);
		
		/// <summary>
        /// Borra una instancia de LogsDasNano en la base de datos
        /// </summary>
        /// <param name="source">LogsDasNano a borrar</param>
        /// <returns>Número de LogsDasNano borrados</returns>
		int DeleteLogsDasNano(LogsDasNano source);
    }
}
