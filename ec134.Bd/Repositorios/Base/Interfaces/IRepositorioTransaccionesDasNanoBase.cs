using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioTransaccionesDasNanoBase
	{
		/// <summary>
        /// Metodo para obtener todos los TransaccionesDasNano 
        /// </summary>
        /// <returns>IQueryable con todos los TransaccionesDasNano</returns>
		IQueryable<TransaccionesDasNano> GetTransaccionesDasNano();
		
        
        /// <summary>
        /// Obtener un TransaccionesDasNano por su clave primaria
        /// </summary>
				/// <param name="idTransaccionDasNano">IdTransaccionDasNano</param>
		        /// <returns>TransaccionesDasNano   seleccionado por su clave primaria</returns>
		Task<TransaccionesDasNano> GetTransaccionesDasNanoByPrimaryKeyAsync(int idTransaccionDasNano);
		
        /// <summary>
        /// Obtener un TransaccionesDasNano por su clave primaria
        /// </summary>
				/// <param name="idTransaccionDasNano">IdTransaccionDasNano</param>
		        /// <returns>TransaccionesDasNano  seleccionado por su clave primaria</returns>
		TransaccionesDasNano GetTransaccionesDasNanoByPrimaryKey(int idTransaccionDasNano);


        /// <summary>
        /// Obtener Listado TransaccionesDasNano por idOperacion
        /// </summary>
        /// <param name="idOperacion">IdOperacion</param>
        /// <returns>IQueryableTransaccionesDasNano por operación</returns>
        IQueryable<TransaccionesDasNano> GetTransaccionesDasNanoByIdOperacion(int idOperacion);

        

        /// <summary>
        /// Obtener un TransaccionesDasNano por su clave unica GuidDasNano
        /// </summary>
        /// <param name="guidDasNano">GuidDasNano</param>
        /// <returns>TransaccionesDasNano   seleccionado por su clave única</returns>
        Task<TransaccionesDasNano> GetTransaccionesDasNanoByGuidDasNanoAsync(string guidDasNano);

        /// <summary>
        /// Obtener un TransaccionesDasNano por su clave unica GuidDasNano
        /// </summary>
		/// <param name="guidDasNano">GuidDasNano</param>
        /// <returns>TransaccionesDasNano   seleccionado por su clave única</returns>
		TransaccionesDasNano GetTransaccionesDasNanoByGuidDasNano(string guidDasNano);



		/// <summary>
        /// Crea una instancia de TransaccionesDasNano en la base de datos
        /// </summary>
        /// <param name="source">TransaccionesDasNano a crear</param>
        /// <returns>TransaccionesDasNano creado</returns>
		Task<TransaccionesDasNano> CreateTransaccionesDasNanoAsync(TransaccionesDasNano source);

		/// <summary>
        /// Crea una instancia de TransaccionesDasNano en la base de datos
        /// </summary>
        /// <param name="source">TransaccionesDasNano a crear</param>
        /// <returns>TransaccionesDasNano creado</returns>
		TransaccionesDasNano CreateTransaccionesDasNano(TransaccionesDasNano source);


		/// <summary>
        /// Modifica una instancia de TransaccionesDasNano en la base de datos
        /// </summary>
        /// <param name="source">TransaccionesDasNano a modificar</param>
        /// <returns>Número de TransaccionesDasNano modificados</returns>
		Task<int> UpdateTransaccionesDasNanoAsync(TransaccionesDasNano source);
		

		/// <summary>
        /// Modifica una instancia de TransaccionesDasNano en la base de datos
        /// </summary>
        /// <param name="source">TransaccionesDasNano a modificar</param>
        /// <returns>Número de TransaccionesDasNano modificados</returns>
		int UpdateTransaccionesDasNano(TransaccionesDasNano source);

		/// <summary>
        /// Borra una instancia de TransaccionesDasNano en la base de datos
        /// </summary>
        /// <param name="source">TransaccionesDasNano a borrar</param>
        /// <returns>Número de TransaccionesDasNano borrados</returns>
		Task<int> DeleteTransaccionesDasNanoAsync(TransaccionesDasNano source);
		
		/// <summary>
        /// Borra una instancia de TransaccionesDasNano en la base de datos
        /// </summary>
        /// <param name="source">TransaccionesDasNano a borrar</param>
        /// <returns>Número de TransaccionesDasNano borrados</returns>
		int DeleteTransaccionesDasNano(TransaccionesDasNano source);
    }
}
