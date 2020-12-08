using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioDocumentosSolicitudBase : IRepositorioDocumentosSolicitudBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase DocumentosSolicitud 
        /// </summary>
		public RepositorioDocumentosSolicitudBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los DocumentosSolicitud 
        /// </summary>
        /// <returns>IQueryable con todos los DocumentosSolicitud</returns>
		public IQueryable<DocumentosSolicitud> GetDocumentosSolicitud()
		{
			return _efRepository.All<DocumentosSolicitud>();
		}


        /// <summary>
        /// Obtener un DocumentosSolicitud por su clave primaria
        /// </summary>
        /// <param name="idDocumentoSolicitud">idDocumentoSolicitud</param>
        /// <returns>DocumentosSolicitud   seleccionado por su clave primaria</returns>
        public async Task<DocumentosSolicitud> GetDocumentosSolicitudByPrimaryKeyAsync(int idDocumentoSolicitud)
		{
			return await _efRepository.FindAsync<DocumentosSolicitud>(x=>x.IdDocumentoSolicitud == idDocumentoSolicitud);
		}

        /// <summary>
        /// Obtener un DocumentosSolicitud por su clave primaria
        /// </summary>
		/// <param name="idDocumentoSolicitud">idDocumentoSolicitud</param>
        /// <returns>DocumentosSolicitud  seleccionado por su clave primaria</returns>
		public DocumentosSolicitud GetDocumentosSolicitudByPrimaryKey(int idDocumentoSolicitud)
		{
			return _efRepository.Find<DocumentosSolicitud>(x=>x.IdDocumentoSolicitud == idDocumentoSolicitud);
		}


		/// <summary>
        /// Crea una instancia de DocumentosSolicitud en la base de datos
        /// </summary>
        /// <param name="source">DocumentosSolicitud a crear</param>
        /// <returns>DocumentosSolicitud creado</returns>
		public virtual async Task<DocumentosSolicitud> CreateDocumentosSolicitudAsync(DocumentosSolicitud source)
		{
			return await _efRepository.CreateAsync<DocumentosSolicitud>(source);
		}

		/// <summary>
        /// Crea una instancia de DocumentosSolicitud en la base de datos
        /// </summary>
        /// <param name="source">DocumentosSolicitud a crear</param>
        /// <returns>DocumentosSolicitud creado</returns>
		public virtual DocumentosSolicitud CreateDocumentosSolicitud(DocumentosSolicitud source)
		{
			return _efRepository.Create<DocumentosSolicitud>(source);
		}


		/// <summary>
        /// Modifica una instancia de DocumentosSolicitud en la base de datos
        /// </summary>
        /// <param name="source">DocumentosSolicitud a modificar</param>
        /// <returns>Número de DocumentosSolicitud modificados</returns>
		public async Task<int> UpdateDocumentosSolicitudAsync(DocumentosSolicitud source)
		{
			return await _efRepository.UpdateAsync<DocumentosSolicitud>(source);
		}

		/// <summary>
        /// Modifica una instancia de DocumentosSolicitud en la base de datos
        /// </summary>
        /// <param name="source">DocumentosSolicitud a modificar</param>
        /// <returns>Número de DocumentosSolicitud modificados</returns>
		public int UpdateDocumentosSolicitud(DocumentosSolicitud source)
		{
			return _efRepository.Update<DocumentosSolicitud>(source);
		}

		/// <summary>
        /// Borra una instancia de DocumentosSolicitud en la base de datos
        /// </summary>
        /// <param name="source">DocumentosSolicitud a borrar</param>
        /// <returns>Número de DocumentosSolicitud borrados</returns>
		public async Task<int> DeleteDocumentosSolicitudAsync(DocumentosSolicitud source)
		{
			return await _efRepository.DeleteAsync<DocumentosSolicitud>(source);
		}

		/// <summary>
        /// Borra una instancia de DocumentosSolicitud en la base de datos
        /// </summary>
        /// <param name="source">DocumentosSolicitud a borrar</param>
        /// <returns>Número de DocumentosSolicitud borrados</returns>
		public int DeleteDocumentosSolicitud(DocumentosSolicitud source)
		{
			return _efRepository.Delete<DocumentosSolicitud>(source);
		}
    }
}
