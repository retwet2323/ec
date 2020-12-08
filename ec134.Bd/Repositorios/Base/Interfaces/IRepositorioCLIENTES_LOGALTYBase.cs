
using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioCLIENTES_LOGALTYBase
	{
		/// <summary>
        /// Metodo para obtener todos los CLIENTES_LOGALTY 
        /// </summary>
        /// <returns>IQueryable con todos los CLIENTES_LOGALTY</returns>
		IQueryable<CLIENTES_LOGALTY> GetCLIENTES_LOGALTY();
		
        
        /// <summary>
        /// Obtener un CLIENTES_LOGALTY por su clave primaria
        /// </summary>
				/// <param name="idAccion">IdAccion</param>
		        /// <returns>CLIENTES_LOGALTY   seleccionado por su clave primaria</returns>
		Task<CLIENTES_LOGALTY> GetCLIENTES_LOGALTYByPrimaryKeyAsync(int idAccion);
		
        /// <summary>
        /// Obtener un CLIENTES_LOGALTY por su clave primaria
        /// </summary>
				/// <param name="idAccion">IdAccion</param>
		        /// <returns>CLIENTES_LOGALTY  seleccionado por su clave primaria</returns>
		CLIENTES_LOGALTY GetCLIENTES_LOGALTYByPrimaryKey(int idAccion);


        


		/// <summary>
        /// Crea una instancia de CLIENTES_LOGALTY en la base de datos
        /// </summary>
        /// <param name="source">CLIENTES_LOGALTY a crear</param>
        /// <returns>CLIENTES_LOGALTY creado</returns>
		Task<CLIENTES_LOGALTY> CreateCLIENTES_LOGALTYAsync(CLIENTES_LOGALTY source);

		/// <summary>
        /// Crea una instancia de CLIENTES_LOGALTY en la base de datos
        /// </summary>
        /// <param name="source">CLIENTES_LOGALTY a crear</param>
        /// <returns>CLIENTES_LOGALTY creado</returns>
		CLIENTES_LOGALTY CreateCLIENTES_LOGALTY(CLIENTES_LOGALTY source);


		/// <summary>
        /// Modifica una instancia de CLIENTES_LOGALTY en la base de datos
        /// </summary>
        /// <param name="source">CLIENTES_LOGALTY a modificar</param>
        /// <returns>Número de CLIENTES_LOGALTY modificados</returns>
		Task<int> UpdateCLIENTES_LOGALTYAsync(CLIENTES_LOGALTY source);
		

		/// <summary>
        /// Modifica una instancia de CLIENTES_LOGALTY en la base de datos
        /// </summary>
        /// <param name="source">CLIENTES_LOGALTY a modificar</param>
        /// <returns>Número de CLIENTES_LOGALTY modificados</returns>
		int UpdateCLIENTES_LOGALTY(CLIENTES_LOGALTY source);

		/// <summary>
        /// Borra una instancia de CLIENTES_LOGALTY en la base de datos
        /// </summary>
        /// <param name="source">CLIENTES_LOGALTY a borrar</param>
        /// <returns>Número de CLIENTES_LOGALTY borrados</returns>
		Task<int> DeleteCLIENTES_LOGALTYAsync(CLIENTES_LOGALTY source);
		
		/// <summary>
        /// Borra una instancia de CLIENTES_LOGALTY en la base de datos
        /// </summary>
        /// <param name="source">CLIENTES_LOGALTY a borrar</param>
        /// <returns>Número de CLIENTES_LOGALTY borrados</returns>
		int DeleteCLIENTES_LOGALTY(CLIENTES_LOGALTY source);
    }
}
