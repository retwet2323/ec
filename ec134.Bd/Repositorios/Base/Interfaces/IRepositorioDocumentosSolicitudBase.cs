using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioDocumentosSolicitudBase
	{
		/// <summary>
        /// Metodo para obtener todos los DocumentosSolicitud 
        /// </summary>
        /// <returns>IQueryable con todos los DocumentosSolicitud</returns>
		IQueryable<DocumentosSolicitud> GetDocumentosSolicitud();


        /// <summary>
        /// Obtener un DocumentosSolicitud por su clave primaria
        /// </summary>
        /// <param name="idDocumentoSolicitud">idDocumentoSolicitud</param>
        /// <returns>DocumentosSolicitud   seleccionado por su clave primaria</returns>
        Task<DocumentosSolicitud> GetDocumentosSolicitudByPrimaryKeyAsync(int idDocumentoSolicitud);

        /// <summary>
        /// Obtener un DocumentosSolicitud por su clave primaria
        /// </summary>
        /// <param name="idDocumentoSolicitud">idDocumentoSolicitud</param>
        /// <returns>DocumentosSolicitud  seleccionado por su clave primaria</returns>
        DocumentosSolicitud GetDocumentosSolicitudByPrimaryKey(int idDocumentoSolicitud);


		/// <summary>
        /// Crea una instancia de DocumentosSolicitud en la base de datos
        /// </summary>
        /// <param name="source">DocumentosSolicitud a crear</param>
        /// <returns>DocumentosSolicitud creado</returns>
		Task<DocumentosSolicitud> CreateDocumentosSolicitudAsync(DocumentosSolicitud source);

		/// <summary>
        /// Crea una instancia de DocumentosSolicitud en la base de datos
        /// </summary>
        /// <param name="source">DocumentosSolicitud a crear</param>
        /// <returns>DocumentosSolicitud creado</returns>
		DocumentosSolicitud CreateDocumentosSolicitud(DocumentosSolicitud source);


		/// <summary>
        /// Modifica una instancia de DocumentosSolicitud en la base de datos
        /// </summary>
        /// <param name="source">DocumentosSolicitud a modificar</param>
        /// <returns>Número de DocumentosSolicitud modificados</returns>
		Task<int> UpdateDocumentosSolicitudAsync(DocumentosSolicitud source);
		

		/// <summary>
        /// Modifica una instancia de DocumentosSolicitud en la base de datos
        /// </summary>
        /// <param name="source">DocumentosSolicitud a modificar</param>
        /// <returns>Número de DocumentosSolicitud modificados</returns>
		int UpdateDocumentosSolicitud(DocumentosSolicitud source);

		/// <summary>
        /// Borra una instancia de DocumentosSolicitud en la base de datos
        /// </summary>
        /// <param name="source">DocumentosSolicitud a borrar</param>
        /// <returns>Número de DocumentosSolicitud borrados</returns>
		Task<int> DeleteDocumentosSolicitudAsync(DocumentosSolicitud source);
		
		/// <summary>
        /// Borra una instancia de DocumentosSolicitud en la base de datos
        /// </summary>
        /// <param name="source">DocumentosSolicitud a borrar</param>
        /// <returns>Número de DocumentosSolicitud borrados</returns>
		int DeleteDocumentosSolicitud(DocumentosSolicitud source);
    }
}
