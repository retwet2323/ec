using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioVerificacionDocumentalDI_IlegiblesBase
	{
		/// <summary>
        /// Metodo para obtener todos los VerificacionDocumentalDI_Ilegibles 
        /// </summary>
        /// <returns>IQueryable con todos los VerificacionDocumentalDI_Ilegibles</returns>
		IQueryable<VerificacionDocumentalDI_Ilegibles> GetVerificacionDocumentalDI_Ilegibles();
		
        
        /// <summary>
        /// Obtener un VerificacionDocumentalDI_Ilegibles por su clave primaria
        /// </summary>
				/// <param name="idIlegible">IdIlegible</param>
		        /// <returns>VerificacionDocumentalDI_Ilegibles   seleccionado por su clave primaria</returns>
		Task<VerificacionDocumentalDI_Ilegibles> GetVerificacionDocumentalDI_IlegiblesByPrimaryKeyAsync(int idIlegible);
		
        /// <summary>
        /// Obtener un VerificacionDocumentalDI_Ilegibles por su clave primaria
        /// </summary>
				/// <param name="idIlegible">IdIlegible</param>
		        /// <returns>VerificacionDocumentalDI_Ilegibles  seleccionado por su clave primaria</returns>
		VerificacionDocumentalDI_Ilegibles GetVerificacionDocumentalDI_IlegiblesByPrimaryKey(int idIlegible);


        


		/// <summary>
        /// Crea una instancia de VerificacionDocumentalDI_Ilegibles en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI_Ilegibles a crear</param>
        /// <returns>VerificacionDocumentalDI_Ilegibles creado</returns>
		Task<VerificacionDocumentalDI_Ilegibles> CreateVerificacionDocumentalDI_IlegiblesAsync(VerificacionDocumentalDI_Ilegibles source);

		/// <summary>
        /// Crea una instancia de VerificacionDocumentalDI_Ilegibles en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI_Ilegibles a crear</param>
        /// <returns>VerificacionDocumentalDI_Ilegibles creado</returns>
		VerificacionDocumentalDI_Ilegibles CreateVerificacionDocumentalDI_Ilegibles(VerificacionDocumentalDI_Ilegibles source);


		/// <summary>
        /// Modifica una instancia de VerificacionDocumentalDI_Ilegibles en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI_Ilegibles a modificar</param>
        /// <returns>Número de VerificacionDocumentalDI_Ilegibles modificados</returns>
		Task<int> UpdateVerificacionDocumentalDI_IlegiblesAsync(VerificacionDocumentalDI_Ilegibles source);
		

		/// <summary>
        /// Modifica una instancia de VerificacionDocumentalDI_Ilegibles en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI_Ilegibles a modificar</param>
        /// <returns>Número de VerificacionDocumentalDI_Ilegibles modificados</returns>
		int UpdateVerificacionDocumentalDI_Ilegibles(VerificacionDocumentalDI_Ilegibles source);

		/// <summary>
        /// Borra una instancia de VerificacionDocumentalDI_Ilegibles en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI_Ilegibles a borrar</param>
        /// <returns>Número de VerificacionDocumentalDI_Ilegibles borrados</returns>
		Task<int> DeleteVerificacionDocumentalDI_IlegiblesAsync(VerificacionDocumentalDI_Ilegibles source);
		
		/// <summary>
        /// Borra una instancia de VerificacionDocumentalDI_Ilegibles en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI_Ilegibles a borrar</param>
        /// <returns>Número de VerificacionDocumentalDI_Ilegibles borrados</returns>
		int DeleteVerificacionDocumentalDI_Ilegibles(VerificacionDocumentalDI_Ilegibles source);
    }
}
