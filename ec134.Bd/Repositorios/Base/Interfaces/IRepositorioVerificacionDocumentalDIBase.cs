using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioVerificacionDocumentalDIBase
	{
		/// <summary>
        /// Metodo para obtener todos los VerificacionDocumentalDI 
        /// </summary>
        /// <returns>IQueryable con todos los VerificacionDocumentalDI</returns>
		IQueryable<VerificacionDocumentalDI> GetVerificacionDocumentalDI();
		
        
        /// <summary>
        /// Obtener un VerificacionDocumentalDI por su clave primaria
        /// </summary>
				/// <param name="idRespuesta">IdRespuesta</param>
		        /// <returns>VerificacionDocumentalDI   seleccionado por su clave primaria</returns>
		Task<VerificacionDocumentalDI> GetVerificacionDocumentalDIByPrimaryKeyAsync(int idRespuesta);
		
        /// <summary>
        /// Obtener un VerificacionDocumentalDI por su clave primaria
        /// </summary>
				/// <param name="idRespuesta">IdRespuesta</param>
		        /// <returns>VerificacionDocumentalDI  seleccionado por su clave primaria</returns>
		VerificacionDocumentalDI GetVerificacionDocumentalDIByPrimaryKey(int idRespuesta);


        


		/// <summary>
        /// Crea una instancia de VerificacionDocumentalDI en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI a crear</param>
        /// <returns>VerificacionDocumentalDI creado</returns>
		Task<VerificacionDocumentalDI> CreateVerificacionDocumentalDIAsync(VerificacionDocumentalDI source);

		/// <summary>
        /// Crea una instancia de VerificacionDocumentalDI en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI a crear</param>
        /// <returns>VerificacionDocumentalDI creado</returns>
		VerificacionDocumentalDI CreateVerificacionDocumentalDI(VerificacionDocumentalDI source);


		/// <summary>
        /// Modifica una instancia de VerificacionDocumentalDI en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI a modificar</param>
        /// <returns>Número de VerificacionDocumentalDI modificados</returns>
		Task<int> UpdateVerificacionDocumentalDIAsync(VerificacionDocumentalDI source);
		

		/// <summary>
        /// Modifica una instancia de VerificacionDocumentalDI en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI a modificar</param>
        /// <returns>Número de VerificacionDocumentalDI modificados</returns>
		int UpdateVerificacionDocumentalDI(VerificacionDocumentalDI source);

		/// <summary>
        /// Borra una instancia de VerificacionDocumentalDI en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI a borrar</param>
        /// <returns>Número de VerificacionDocumentalDI borrados</returns>
		Task<int> DeleteVerificacionDocumentalDIAsync(VerificacionDocumentalDI source);
		
		/// <summary>
        /// Borra una instancia de VerificacionDocumentalDI en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI a borrar</param>
        /// <returns>Número de VerificacionDocumentalDI borrados</returns>
		int DeleteVerificacionDocumentalDI(VerificacionDocumentalDI source);
    }
}
