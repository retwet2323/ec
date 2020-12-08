using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioDocumentosPlantillasBase : IRepositorioDocumentosPlantillasBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase DocumentosPlantillas 
        /// </summary>
		public RepositorioDocumentosPlantillasBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los DocumentosPlantillas 
        /// </summary>
        /// <returns>IQueryable con todos los DocumentosPlantillas</returns>
		public IQueryable<DocumentosPlantillas> GetDocumentosPlantillas()
		{
			return _efRepository.All<DocumentosPlantillas>();
		}

        
        /// <summary>
        /// Obtener un DocumentosPlantillas por su clave primaria
        /// </summary>
		/// <param name="idDocumentoPlantilla">IdDocumentoPlantilla</param>
        /// <returns>DocumentosPlantillas   seleccionado por su clave primaria</returns>
		public async Task<DocumentosPlantillas> GetDocumentosPlantillasByPrimaryKeyAsync(int idDocumentoPlantilla)
		{
			return await _efRepository.FindAsync<DocumentosPlantillas>(x=>x.IdDocumentoPlantilla == idDocumentoPlantilla);
		}

        /// <summary>
        /// Obtener un DocumentosPlantillas por su clave primaria
        /// </summary>
		/// <param name="idDocumentoPlantilla">IdDocumentoPlantilla</param>
        /// <returns>DocumentosPlantillas  seleccionado por su clave primaria</returns>
		public DocumentosPlantillas GetDocumentosPlantillasByPrimaryKey(int idDocumentoPlantilla)
		{
			return _efRepository.Find<DocumentosPlantillas>(x=>x.IdDocumentoPlantilla == idDocumentoPlantilla);
		}


        /// <summary>
        /// Obtener un IQueryable<DocumentosPlantillas> por su IdDocumentoPrincipal 
        /// </summary>
		/// <param name="idDocumentoPrincipal">IdDocumentoPrincipal</param>
        /// <returns>IQueryable con los DocumentosPlantillas seleccionado por su IdDocumentoPrincipal </returns>
		public IQueryable<DocumentosPlantillas> GetDocumentosPlantillasByIdDocumentoPrincipal(int? idDocumentoPrincipal)
		{
			return _efRepository.Filter<DocumentosPlantillas>(x=> x.IdDocumentoPrincipal == idDocumentoPrincipal);
		}
        /// <summary>
        /// Obtener un IQueryable<DocumentosPlantillas> por su IdElemento 
        /// </summary>
		/// <param name="idElemento">IdElemento</param>
        /// <returns>IQueryable con los DocumentosPlantillas seleccionado por su IdElemento </returns>
		public IQueryable<DocumentosPlantillas> GetDocumentosPlantillasByIdElemento(int? idElemento)
		{
			return _efRepository.Filter<DocumentosPlantillas>(x=> x.IdElemento == idElemento);
		}


		/// <summary>
        /// Crea una instancia de DocumentosPlantillas en la base de datos
        /// </summary>
        /// <param name="source">DocumentosPlantillas a crear</param>
        /// <returns>DocumentosPlantillas creado</returns>
		public virtual async Task<DocumentosPlantillas> CreateDocumentosPlantillasAsync(DocumentosPlantillas source)
		{
			return await _efRepository.CreateAsync<DocumentosPlantillas>(source);
		}

		/// <summary>
        /// Crea una instancia de DocumentosPlantillas en la base de datos
        /// </summary>
        /// <param name="source">DocumentosPlantillas a crear</param>
        /// <returns>DocumentosPlantillas creado</returns>
		public virtual DocumentosPlantillas CreateDocumentosPlantillas(DocumentosPlantillas source)
		{
			return _efRepository.Create<DocumentosPlantillas>(source);
		}


		/// <summary>
        /// Modifica una instancia de DocumentosPlantillas en la base de datos
        /// </summary>
        /// <param name="source">DocumentosPlantillas a modificar</param>
        /// <returns>Número de DocumentosPlantillas modificados</returns>
		public async Task<int> UpdateDocumentosPlantillasAsync(DocumentosPlantillas source)
		{
			return await _efRepository.UpdateAsync<DocumentosPlantillas>(source);
		}

		/// <summary>
        /// Modifica una instancia de DocumentosPlantillas en la base de datos
        /// </summary>
        /// <param name="source">DocumentosPlantillas a modificar</param>
        /// <returns>Número de DocumentosPlantillas modificados</returns>
		public int UpdateDocumentosPlantillas(DocumentosPlantillas source)
		{
			return _efRepository.Update<DocumentosPlantillas>(source);
		}

		/// <summary>
        /// Borra una instancia de DocumentosPlantillas en la base de datos
        /// </summary>
        /// <param name="source">DocumentosPlantillas a borrar</param>
        /// <returns>Número de DocumentosPlantillas borrados</returns>
		public async Task<int> DeleteDocumentosPlantillasAsync(DocumentosPlantillas source)
		{
			return await _efRepository.DeleteAsync<DocumentosPlantillas>(source);
		}

		/// <summary>
        /// Borra una instancia de DocumentosPlantillas en la base de datos
        /// </summary>
        /// <param name="source">DocumentosPlantillas a borrar</param>
        /// <returns>Número de DocumentosPlantillas borrados</returns>
		public int DeleteDocumentosPlantillas(DocumentosPlantillas source)
		{
			return _efRepository.Delete<DocumentosPlantillas>(source);
		}
    }
}
