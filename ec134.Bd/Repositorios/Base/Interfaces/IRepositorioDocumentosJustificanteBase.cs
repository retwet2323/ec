using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioDocumentosJustificanteBase
	{
		/// <summary>
        /// Metodo para obtener todos los DocumentosJustificante 
        /// </summary>
        /// <returns>IQueryable con todos los DocumentosJustificante</returns>
		IQueryable<DocumentosJustificante> GetDocumentosJustificante();
		
        
        /// <summary>
        /// Obtener un DocumentosJustificante por su clave primaria
        /// </summary>
				/// <param name="idDocumento">IdDocumento</param>
		        /// <returns>DocumentosJustificante   seleccionado por su clave primaria</returns>
		Task<DocumentosJustificante> GetDocumentosJustificanteByPrimaryKeyAsync(int idDocumento);
		
        /// <summary>
        /// Obtener un DocumentosJustificante por su clave primaria
        /// </summary>
				/// <param name="idDocumento">IdDocumento</param>
		        /// <returns>DocumentosJustificante  seleccionado por su clave primaria</returns>
		DocumentosJustificante GetDocumentosJustificanteByPrimaryKey(int idDocumento);


		/// <summary>
        /// Crea una instancia de DocumentosJustificante en la base de datos
        /// </summary>
        /// <param name="source">DocumentosJustificante a crear</param>
        /// <returns>DocumentosJustificante creado</returns>
		Task<DocumentosJustificante> CreateDocumentosJustificanteAsync(DocumentosJustificante source);

		/// <summary>
        /// Crea una instancia de DocumentosJustificante en la base de datos
        /// </summary>
        /// <param name="source">DocumentosJustificante a crear</param>
        /// <returns>DocumentosJustificante creado</returns>
		DocumentosJustificante CreateDocumentosJustificante(DocumentosJustificante source);


		/// <summary>
        /// Modifica una instancia de DocumentosJustificante en la base de datos
        /// </summary>
        /// <param name="source">DocumentosJustificante a modificar</param>
        /// <returns>Número de DocumentosJustificante modificados</returns>
		Task<int> UpdateDocumentosJustificanteAsync(DocumentosJustificante source);
		

		/// <summary>
        /// Modifica una instancia de DocumentosJustificante en la base de datos
        /// </summary>
        /// <param name="source">DocumentosJustificante a modificar</param>
        /// <returns>Número de DocumentosJustificante modificados</returns>
		int UpdateDocumentosJustificante(DocumentosJustificante source);

		/// <summary>
        /// Borra una instancia de DocumentosJustificante en la base de datos
        /// </summary>
        /// <param name="source">DocumentosJustificante a borrar</param>
        /// <returns>Número de DocumentosJustificante borrados</returns>
		Task<int> DeleteDocumentosJustificanteAsync(DocumentosJustificante source);
		
		/// <summary>
        /// Borra una instancia de DocumentosJustificante en la base de datos
        /// </summary>
        /// <param name="source">DocumentosJustificante a borrar</param>
        /// <returns>Número de DocumentosJustificante borrados</returns>
		int DeleteDocumentosJustificante(DocumentosJustificante source);
    }
}
