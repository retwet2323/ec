using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioDocumentosPlantillasBase
	{
		/// <summary>
        /// Metodo para obtener todos los DocumentosPlantillas 
        /// </summary>
        /// <returns>IQueryable con todos los DocumentosPlantillas</returns>
		IQueryable<DocumentosPlantillas> GetDocumentosPlantillas();
		
        
        /// <summary>
        /// Obtener un DocumentosPlantillas por su clave primaria
        /// </summary>
				/// <param name="idDocumentoPlantilla">IdDocumentoPlantilla</param>
		        /// <returns>DocumentosPlantillas   seleccionado por su clave primaria</returns>
		Task<DocumentosPlantillas> GetDocumentosPlantillasByPrimaryKeyAsync(int idDocumentoPlantilla);
		
        /// <summary>
        /// Obtener un DocumentosPlantillas por su clave primaria
        /// </summary>
				/// <param name="idDocumentoPlantilla">IdDocumentoPlantilla</param>
		        /// <returns>DocumentosPlantillas  seleccionado por su clave primaria</returns>
		DocumentosPlantillas GetDocumentosPlantillasByPrimaryKey(int idDocumentoPlantilla);


        

        /// <summary>
        /// Obtener un IQueryable<DocumentosPlantillas> por su IdDocumentoPrincipal 
        /// </summary>
		/// <param name="idDocumentoPrincipal">IdDocumentoPrincipal</param>
        /// <returns>IQueryable con los DocumentosPlantillas seleccionado por su IdDocumentoPrincipal </returns>
        IQueryable<DocumentosPlantillas> GetDocumentosPlantillasByIdDocumentoPrincipal(int? idDocumentoPrincipal);

        /// <summary>
        /// Obtener un IQueryable<DocumentosPlantillas> por su IdElemento 
        /// </summary>
		/// <param name="idElemento">IdElemento</param>
        /// <returns>IQueryable con los DocumentosPlantillas seleccionado por su IdElemento </returns>
        IQueryable<DocumentosPlantillas> GetDocumentosPlantillasByIdElemento(int? idElemento);


		/// <summary>
        /// Crea una instancia de DocumentosPlantillas en la base de datos
        /// </summary>
        /// <param name="source">DocumentosPlantillas a crear</param>
        /// <returns>DocumentosPlantillas creado</returns>
		Task<DocumentosPlantillas> CreateDocumentosPlantillasAsync(DocumentosPlantillas source);

		/// <summary>
        /// Crea una instancia de DocumentosPlantillas en la base de datos
        /// </summary>
        /// <param name="source">DocumentosPlantillas a crear</param>
        /// <returns>DocumentosPlantillas creado</returns>
		DocumentosPlantillas CreateDocumentosPlantillas(DocumentosPlantillas source);


		/// <summary>
        /// Modifica una instancia de DocumentosPlantillas en la base de datos
        /// </summary>
        /// <param name="source">DocumentosPlantillas a modificar</param>
        /// <returns>Número de DocumentosPlantillas modificados</returns>
		Task<int> UpdateDocumentosPlantillasAsync(DocumentosPlantillas source);
		

		/// <summary>
        /// Modifica una instancia de DocumentosPlantillas en la base de datos
        /// </summary>
        /// <param name="source">DocumentosPlantillas a modificar</param>
        /// <returns>Número de DocumentosPlantillas modificados</returns>
		int UpdateDocumentosPlantillas(DocumentosPlantillas source);

		/// <summary>
        /// Borra una instancia de DocumentosPlantillas en la base de datos
        /// </summary>
        /// <param name="source">DocumentosPlantillas a borrar</param>
        /// <returns>Número de DocumentosPlantillas borrados</returns>
		Task<int> DeleteDocumentosPlantillasAsync(DocumentosPlantillas source);
		
		/// <summary>
        /// Borra una instancia de DocumentosPlantillas en la base de datos
        /// </summary>
        /// <param name="source">DocumentosPlantillas a borrar</param>
        /// <returns>Número de DocumentosPlantillas borrados</returns>
		int DeleteDocumentosPlantillas(DocumentosPlantillas source);
    }
}
