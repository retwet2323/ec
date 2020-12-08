using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioTransaccionesLogaltyBase
	{
		/// <summary>
        /// Metodo para obtener todos los TransaccionesLogalty 
        /// </summary>
        /// <returns>IQueryable con todos los TransaccionesLogalty</returns>
		IQueryable<TransaccionesLogalty> GetTransaccionesLogalty();
		
        
        /// <summary>
        /// Obtener un TransaccionesLogalty por su clave primaria
        /// </summary>
				/// <param name="idTransaccionLogalty">IdTransaccionLogalty</param>
		        /// <returns>TransaccionesLogalty   seleccionado por su clave primaria</returns>
		Task<TransaccionesLogalty> GetTransaccionesLogaltyByPrimaryKeyAsync(int idTransaccionLogalty);
		
        /// <summary>
        /// Obtener un TransaccionesLogalty por su clave primaria
        /// </summary>
				/// <param name="idTransaccionLogalty">IdTransaccionLogalty</param>
		        /// <returns>TransaccionesLogalty  seleccionado por su clave primaria</returns>
		TransaccionesLogalty GetTransaccionesLogaltyByPrimaryKey(int idTransaccionLogalty);


        
        /// <summary>
        /// Obtener un TransaccionesLogalty por su clave unica GuidTransaccion
        /// </summary>
		/// <param name="guidTransaccion">GuidTransaccion</param>
        /// <returns>TransaccionesLogalty   seleccionado por su clave única</returns>
        Task<TransaccionesLogalty> GetTransaccionesLogaltyByGuidTransaccionAsync(string guidTransaccion);

        /// <summary>
        /// Obtener un TransaccionesLogalty por su clave unica GuidTransaccion
        /// </summary>
		/// <param name="guidTransaccion">GuidTransaccion</param>
        /// <returns>TransaccionesLogalty   seleccionado por su clave única</returns>
		TransaccionesLogalty GetTransaccionesLogaltyByGuidTransaccion(string guidTransaccion);


        /// <summary>
        /// Obtener un IQueryable<TransaccionesLogalty> por su IdOperacion 
        /// </summary>
		/// <param name="idOperacion">IdOperacion</param>
        /// <returns>IQueryable con los TransaccionesLogalty seleccionado por su IdOperacion </returns>
        IQueryable<TransaccionesLogalty> GetTransaccionesLogaltyByIdOperacion(int? idOperacion);


		/// <summary>
        /// Crea una instancia de TransaccionesLogalty en la base de datos
        /// </summary>
        /// <param name="source">TransaccionesLogalty a crear</param>
        /// <returns>TransaccionesLogalty creado</returns>
		Task<TransaccionesLogalty> CreateTransaccionesLogaltyAsync(TransaccionesLogalty source);

		/// <summary>
        /// Crea una instancia de TransaccionesLogalty en la base de datos
        /// </summary>
        /// <param name="source">TransaccionesLogalty a crear</param>
        /// <returns>TransaccionesLogalty creado</returns>
		TransaccionesLogalty CreateTransaccionesLogalty(TransaccionesLogalty source);


		/// <summary>
        /// Modifica una instancia de TransaccionesLogalty en la base de datos
        /// </summary>
        /// <param name="source">TransaccionesLogalty a modificar</param>
        /// <returns>Número de TransaccionesLogalty modificados</returns>
		Task<int> UpdateTransaccionesLogaltyAsync(TransaccionesLogalty source);
		

		/// <summary>
        /// Modifica una instancia de TransaccionesLogalty en la base de datos
        /// </summary>
        /// <param name="source">TransaccionesLogalty a modificar</param>
        /// <returns>Número de TransaccionesLogalty modificados</returns>
		int UpdateTransaccionesLogalty(TransaccionesLogalty source);

		/// <summary>
        /// Borra una instancia de TransaccionesLogalty en la base de datos
        /// </summary>
        /// <param name="source">TransaccionesLogalty a borrar</param>
        /// <returns>Número de TransaccionesLogalty borrados</returns>
		Task<int> DeleteTransaccionesLogaltyAsync(TransaccionesLogalty source);
		
		/// <summary>
        /// Borra una instancia de TransaccionesLogalty en la base de datos
        /// </summary>
        /// <param name="source">TransaccionesLogalty a borrar</param>
        /// <returns>Número de TransaccionesLogalty borrados</returns>
		int DeleteTransaccionesLogalty(TransaccionesLogalty source);
    }
}
