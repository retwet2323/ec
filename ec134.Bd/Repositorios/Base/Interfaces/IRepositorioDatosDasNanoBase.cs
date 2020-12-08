using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioDatosDasNanoBase
	{
		/// <summary>
        /// Metodo para obtener todos los DatosDasNano 
        /// </summary>
        /// <returns>IQueryable con todos los DatosDasNano</returns>
		IQueryable<DatosDasNano> GetDatosDasNano();
		
        
        /// <summary>
        /// Obtener un DatosDasNano por su clave primaria
        /// </summary>
				/// <param name="idDatosDasNano">IdDatosDasNano</param>
		        /// <returns>DatosDasNano   seleccionado por su clave primaria</returns>
		Task<DatosDasNano> GetDatosDasNanoByPrimaryKeyAsync(int idDatosDasNano);
		
        /// <summary>
        /// Obtener un DatosDasNano por su clave primaria
        /// </summary>
				/// <param name="idDatosDasNano">IdDatosDasNano</param>
		        /// <returns>DatosDasNano  seleccionado por su clave primaria</returns>
		DatosDasNano GetDatosDasNanoByPrimaryKey(int idDatosDasNano);


        

        /// <summary>
        /// Obtener un IQueryable<DatosDasNano> por su IdTransaccionDasNano 
        /// </summary>
		/// <param name="idTransaccionDasNano">IdTransaccionDasNano</param>
        /// <returns>IQueryable con los DatosDasNano seleccionado por su IdTransaccionDasNano </returns>
        IQueryable<DatosDasNano> GetDatosDasNanoByIdTransaccionDasNano(int idTransaccionDasNano);


		/// <summary>
        /// Crea una instancia de DatosDasNano en la base de datos
        /// </summary>
        /// <param name="source">DatosDasNano a crear</param>
        /// <returns>DatosDasNano creado</returns>
		Task<DatosDasNano> CreateDatosDasNanoAsync(DatosDasNano source);

		/// <summary>
        /// Crea una instancia de DatosDasNano en la base de datos
        /// </summary>
        /// <param name="source">DatosDasNano a crear</param>
        /// <returns>DatosDasNano creado</returns>
		DatosDasNano CreateDatosDasNano(DatosDasNano source);


		/// <summary>
        /// Modifica una instancia de DatosDasNano en la base de datos
        /// </summary>
        /// <param name="source">DatosDasNano a modificar</param>
        /// <returns>Número de DatosDasNano modificados</returns>
		Task<int> UpdateDatosDasNanoAsync(DatosDasNano source);
		

		/// <summary>
        /// Modifica una instancia de DatosDasNano en la base de datos
        /// </summary>
        /// <param name="source">DatosDasNano a modificar</param>
        /// <returns>Número de DatosDasNano modificados</returns>
		int UpdateDatosDasNano(DatosDasNano source);

		/// <summary>
        /// Borra una instancia de DatosDasNano en la base de datos
        /// </summary>
        /// <param name="source">DatosDasNano a borrar</param>
        /// <returns>Número de DatosDasNano borrados</returns>
		Task<int> DeleteDatosDasNanoAsync(DatosDasNano source);
		
		/// <summary>
        /// Borra una instancia de DatosDasNano en la base de datos
        /// </summary>
        /// <param name="source">DatosDasNano a borrar</param>
        /// <returns>Número de DatosDasNano borrados</returns>
		int DeleteDatosDasNano(DatosDasNano source);
    }
}
