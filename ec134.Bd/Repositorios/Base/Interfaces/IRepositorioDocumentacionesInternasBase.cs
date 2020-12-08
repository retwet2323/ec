using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioDocumentacionesInternasBase
	{
		/// <summary>
        /// Metodo para obtener todos los DocumentacionesInternas 
        /// </summary>
        /// <returns>IQueryable con todos los DocumentacionesInternas</returns>
		IQueryable<DocumentacionesInternas> GetDocumentacionesInternas();
		
        
        /// <summary>
        /// Obtener un DocumentacionesInternas por su clave primaria
        /// </summary>
				/// <param name="idDocumentacionInterna">IdDocumentacionInterna</param>
		        /// <returns>DocumentacionesInternas   seleccionado por su clave primaria</returns>
		Task<DocumentacionesInternas> GetDocumentacionesInternasByPrimaryKeyAsync(int idDocumentacionInterna);
		
        /// <summary>
        /// Obtener un DocumentacionesInternas por su clave primaria
        /// </summary>
				/// <param name="idDocumentacionInterna">IdDocumentacionInterna</param>
		        /// <returns>DocumentacionesInternas  seleccionado por su clave primaria</returns>
		DocumentacionesInternas GetDocumentacionesInternasByPrimaryKey(int idDocumentacionInterna);


        


		/// <summary>
        /// Crea una instancia de DocumentacionesInternas en la base de datos
        /// </summary>
        /// <param name="source">DocumentacionesInternas a crear</param>
        /// <returns>DocumentacionesInternas creado</returns>
		Task<DocumentacionesInternas> CreateDocumentacionesInternasAsync(DocumentacionesInternas source);

		/// <summary>
        /// Crea una instancia de DocumentacionesInternas en la base de datos
        /// </summary>
        /// <param name="source">DocumentacionesInternas a crear</param>
        /// <returns>DocumentacionesInternas creado</returns>
		DocumentacionesInternas CreateDocumentacionesInternas(DocumentacionesInternas source);


		/// <summary>
        /// Modifica una instancia de DocumentacionesInternas en la base de datos
        /// </summary>
        /// <param name="source">DocumentacionesInternas a modificar</param>
        /// <returns>Número de DocumentacionesInternas modificados</returns>
		Task<int> UpdateDocumentacionesInternasAsync(DocumentacionesInternas source);
		

		/// <summary>
        /// Modifica una instancia de DocumentacionesInternas en la base de datos
        /// </summary>
        /// <param name="source">DocumentacionesInternas a modificar</param>
        /// <returns>Número de DocumentacionesInternas modificados</returns>
		int UpdateDocumentacionesInternas(DocumentacionesInternas source);

		/// <summary>
        /// Borra una instancia de DocumentacionesInternas en la base de datos
        /// </summary>
        /// <param name="source">DocumentacionesInternas a borrar</param>
        /// <returns>Número de DocumentacionesInternas borrados</returns>
		Task<int> DeleteDocumentacionesInternasAsync(DocumentacionesInternas source);
		
		/// <summary>
        /// Borra una instancia de DocumentacionesInternas en la base de datos
        /// </summary>
        /// <param name="source">DocumentacionesInternas a borrar</param>
        /// <returns>Número de DocumentacionesInternas borrados</returns>
		int DeleteDocumentacionesInternas(DocumentacionesInternas source);
    }
}
