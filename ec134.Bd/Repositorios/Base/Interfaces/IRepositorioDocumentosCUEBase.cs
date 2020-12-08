using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioDocumentosCUEBase
	{
		/// <summary>
        /// Metodo para obtener todos los DocumentosCUE 
        /// </summary>
        /// <returns>IQueryable con todos los DocumentosCUE</returns>
		IQueryable<DocumentosCUE> GetDocumentosCUE();
		
        
        /// <summary>
        /// Obtener un DocumentosCUE por su clave primaria
        /// </summary>
				/// <param name="idDocumento">IdDocumento</param>
		        /// <returns>DocumentosCUE   seleccionado por su clave primaria</returns>
		Task<DocumentosCUE> GetDocumentosCUEByPrimaryKeyAsync(int idDocumento);
		
        /// <summary>
        /// Obtener un DocumentosCUE por su clave primaria
        /// </summary>
				/// <param name="idDocumento">IdDocumento</param>
		        /// <returns>DocumentosCUE  seleccionado por su clave primaria</returns>
		DocumentosCUE GetDocumentosCUEByPrimaryKey(int idDocumento);


		/// <summary>
        /// Crea una instancia de DocumentosCUE en la base de datos
        /// </summary>
        /// <param name="source">DocumentosCUE a crear</param>
        /// <returns>DocumentosCUE creado</returns>
		Task<DocumentosCUE> CreateDocumentosCUEAsync(DocumentosCUE source);

		/// <summary>
        /// Crea una instancia de DocumentosCUE en la base de datos
        /// </summary>
        /// <param name="source">DocumentosCUE a crear</param>
        /// <returns>DocumentosCUE creado</returns>
		DocumentosCUE CreateDocumentosCUE(DocumentosCUE source);


		/// <summary>
        /// Modifica una instancia de DocumentosCUE en la base de datos
        /// </summary>
        /// <param name="source">DocumentosCUE a modificar</param>
        /// <returns>Número de DocumentosCUE modificados</returns>
		Task<int> UpdateDocumentosCUEAsync(DocumentosCUE source);
		

		/// <summary>
        /// Modifica una instancia de DocumentosCUE en la base de datos
        /// </summary>
        /// <param name="source">DocumentosCUE a modificar</param>
        /// <returns>Número de DocumentosCUE modificados</returns>
		int UpdateDocumentosCUE(DocumentosCUE source);

		/// <summary>
        /// Borra una instancia de DocumentosCUE en la base de datos
        /// </summary>
        /// <param name="source">DocumentosCUE a borrar</param>
        /// <returns>Número de DocumentosCUE borrados</returns>
		Task<int> DeleteDocumentosCUEAsync(DocumentosCUE source);
		
		/// <summary>
        /// Borra una instancia de DocumentosCUE en la base de datos
        /// </summary>
        /// <param name="source">DocumentosCUE a borrar</param>
        /// <returns>Número de DocumentosCUE borrados</returns>
		int DeleteDocumentosCUE(DocumentosCUE source);
    }
}
