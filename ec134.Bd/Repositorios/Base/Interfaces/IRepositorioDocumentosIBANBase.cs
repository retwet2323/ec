using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioDocumentosIBANBase
	{
		/// <summary>
        /// Metodo para obtener todos los DocumentosIBAN 
        /// </summary>
        /// <returns>IQueryable con todos los DocumentosIBAN</returns>
		IQueryable<DocumentosIBAN> GetDocumentosIBAN();
		
        
        /// <summary>
        /// Obtener un DocumentosIBAN por su clave primaria
        /// </summary>
				/// <param name="idDocumento">IdDocumento</param>
		        /// <returns>DocumentosIBAN   seleccionado por su clave primaria</returns>
		Task<DocumentosIBAN> GetDocumentosIBANByPrimaryKeyAsync(int idDocumento);
		
        /// <summary>
        /// Obtener un DocumentosIBAN por su clave primaria
        /// </summary>
				/// <param name="idDocumento">IdDocumento</param>
		        /// <returns>DocumentosIBAN  seleccionado por su clave primaria</returns>
		DocumentosIBAN GetDocumentosIBANByPrimaryKey(int idDocumento);


		/// <summary>
        /// Crea una instancia de DocumentosIBAN en la base de datos
        /// </summary>
        /// <param name="source">DocumentosIBAN a crear</param>
        /// <returns>DocumentosIBAN creado</returns>
		Task<DocumentosIBAN> CreateDocumentosIBANAsync(DocumentosIBAN source);

		/// <summary>
        /// Crea una instancia de DocumentosIBAN en la base de datos
        /// </summary>
        /// <param name="source">DocumentosIBAN a crear</param>
        /// <returns>DocumentosIBAN creado</returns>
		DocumentosIBAN CreateDocumentosIBAN(DocumentosIBAN source);


		/// <summary>
        /// Modifica una instancia de DocumentosIBAN en la base de datos
        /// </summary>
        /// <param name="source">DocumentosIBAN a modificar</param>
        /// <returns>Número de DocumentosIBAN modificados</returns>
		Task<int> UpdateDocumentosIBANAsync(DocumentosIBAN source);
		

		/// <summary>
        /// Modifica una instancia de DocumentosIBAN en la base de datos
        /// </summary>
        /// <param name="source">DocumentosIBAN a modificar</param>
        /// <returns>Número de DocumentosIBAN modificados</returns>
		int UpdateDocumentosIBAN(DocumentosIBAN source);

		/// <summary>
        /// Borra una instancia de DocumentosIBAN en la base de datos
        /// </summary>
        /// <param name="source">DocumentosIBAN a borrar</param>
        /// <returns>Número de DocumentosIBAN borrados</returns>
		Task<int> DeleteDocumentosIBANAsync(DocumentosIBAN source);
		
		/// <summary>
        /// Borra una instancia de DocumentosIBAN en la base de datos
        /// </summary>
        /// <param name="source">DocumentosIBAN a borrar</param>
        /// <returns>Número de DocumentosIBAN borrados</returns>
		int DeleteDocumentosIBAN(DocumentosIBAN source);
    }
}
