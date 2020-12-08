using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioDocumentosBase
	{
		/// <summary>
        /// Metodo para obtener todos los Documentos 
        /// </summary>
        /// <returns>IQueryable con todos los Documentos</returns>
		IQueryable<Documentos> GetDocumentos();
		
        
        /// <summary>
        /// Obtener un Documentos por su clave primaria
        /// </summary>
				/// <param name="idDocumento">IdDocumento</param>
		        /// <returns>Documentos   seleccionado por su clave primaria</returns>
		Task<Documentos> GetDocumentosByPrimaryKeyAsync(int idDocumento);
		
        /// <summary>
        /// Obtener un Documentos por su clave primaria
        /// </summary>
				/// <param name="idDocumento">IdDocumento</param>
		        /// <returns>Documentos  seleccionado por su clave primaria</returns>
		Documentos GetDocumentosByPrimaryKey(int idDocumento);


		/// <summary>
        /// Crea una instancia de Documentos en la base de datos
        /// </summary>
        /// <param name="source">Documentos a crear</param>
        /// <returns>Documentos creado</returns>
		Task<Documentos> CreateDocumentosAsync(Documentos source);

		/// <summary>
        /// Crea una instancia de Documentos en la base de datos
        /// </summary>
        /// <param name="source">Documentos a crear</param>
        /// <returns>Documentos creado</returns>
		Documentos CreateDocumentos(Documentos source);


		/// <summary>
        /// Modifica una instancia de Documentos en la base de datos
        /// </summary>
        /// <param name="source">Documentos a modificar</param>
        /// <returns>Número de Documentos modificados</returns>
		Task<int> UpdateDocumentosAsync(Documentos source);
		

		/// <summary>
        /// Modifica una instancia de Documentos en la base de datos
        /// </summary>
        /// <param name="source">Documentos a modificar</param>
        /// <returns>Número de Documentos modificados</returns>
		int UpdateDocumentos(Documentos source);

		/// <summary>
        /// Borra una instancia de Documentos en la base de datos
        /// </summary>
        /// <param name="source">Documentos a borrar</param>
        /// <returns>Número de Documentos borrados</returns>
		Task<int> DeleteDocumentosAsync(Documentos source);
		
		/// <summary>
        /// Borra una instancia de Documentos en la base de datos
        /// </summary>
        /// <param name="source">Documentos a borrar</param>
        /// <returns>Número de Documentos borrados</returns>
		int DeleteDocumentos(Documentos source);
    }
}
