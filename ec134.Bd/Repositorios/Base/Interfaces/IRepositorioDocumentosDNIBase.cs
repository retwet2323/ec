using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioDocumentosDNIBase
	{
		/// <summary>
        /// Metodo para obtener todos los DocumentosDNI 
        /// </summary>
        /// <returns>IQueryable con todos los DocumentosDNI</returns>
		IQueryable<DocumentosDNI> GetDocumentosDNI();
		
        
        /// <summary>
        /// Obtener un DocumentosDNI por su clave primaria
        /// </summary>
				/// <param name="idDocumento">IdDocumento</param>
		        /// <returns>DocumentosDNI   seleccionado por su clave primaria</returns>
		Task<DocumentosDNI> GetDocumentosDNIByPrimaryKeyAsync(int idDocumento);
		
        /// <summary>
        /// Obtener un DocumentosDNI por su clave primaria
        /// </summary>
				/// <param name="idDocumento">IdDocumento</param>
		        /// <returns>DocumentosDNI  seleccionado por su clave primaria</returns>
		DocumentosDNI GetDocumentosDNIByPrimaryKey(int idDocumento);


		/// <summary>
        /// Crea una instancia de DocumentosDNI en la base de datos
        /// </summary>
        /// <param name="source">DocumentosDNI a crear</param>
        /// <returns>DocumentosDNI creado</returns>
		Task<DocumentosDNI> CreateDocumentosDNIAsync(DocumentosDNI source);

		/// <summary>
        /// Crea una instancia de DocumentosDNI en la base de datos
        /// </summary>
        /// <param name="source">DocumentosDNI a crear</param>
        /// <returns>DocumentosDNI creado</returns>
		DocumentosDNI CreateDocumentosDNI(DocumentosDNI source);


		/// <summary>
        /// Modifica una instancia de DocumentosDNI en la base de datos
        /// </summary>
        /// <param name="source">DocumentosDNI a modificar</param>
        /// <returns>Número de DocumentosDNI modificados</returns>
		Task<int> UpdateDocumentosDNIAsync(DocumentosDNI source);
		

		/// <summary>
        /// Modifica una instancia de DocumentosDNI en la base de datos
        /// </summary>
        /// <param name="source">DocumentosDNI a modificar</param>
        /// <returns>Número de DocumentosDNI modificados</returns>
		int UpdateDocumentosDNI(DocumentosDNI source);

		/// <summary>
        /// Borra una instancia de DocumentosDNI en la base de datos
        /// </summary>
        /// <param name="source">DocumentosDNI a borrar</param>
        /// <returns>Número de DocumentosDNI borrados</returns>
		Task<int> DeleteDocumentosDNIAsync(DocumentosDNI source);
		
		/// <summary>
        /// Borra una instancia de DocumentosDNI en la base de datos
        /// </summary>
        /// <param name="source">DocumentosDNI a borrar</param>
        /// <returns>Número de DocumentosDNI borrados</returns>
		int DeleteDocumentosDNI(DocumentosDNI source);
    }
}
