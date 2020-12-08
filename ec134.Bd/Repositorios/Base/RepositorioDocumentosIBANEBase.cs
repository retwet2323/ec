using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioDocumentosIBANBase : IRepositorioDocumentosIBANBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase DocumentosIBAN 
        /// </summary>
		public RepositorioDocumentosIBANBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los DocumentosIBAN 
        /// </summary>
        /// <returns>IQueryable con todos los DocumentosIBAN</returns>
		public IQueryable<DocumentosIBAN> GetDocumentosIBAN()
		{
			return _efRepository.All<DocumentosIBAN>();
		}

        
        /// <summary>
        /// Obtener un DocumentosIBAN por su clave primaria
        /// </summary>
		/// <param name="idDocumento">IdDocumento</param>
        /// <returns>DocumentosIBAN   seleccionado por su clave primaria</returns>
		public async Task<DocumentosIBAN> GetDocumentosIBANByPrimaryKeyAsync(int idDocumento)
		{
			return await _efRepository.FindAsync<DocumentosIBAN>(x=>x.IdDocumento == idDocumento);
		}

        /// <summary>
        /// Obtener un DocumentosIBAN por su clave primaria
        /// </summary>
		/// <param name="idDocumento">IdDocumento</param>
        /// <returns>DocumentosIBAN  seleccionado por su clave primaria</returns>
		public DocumentosIBAN GetDocumentosIBANByPrimaryKey(int idDocumento)
		{
			return _efRepository.Find<DocumentosIBAN>(x=>x.IdDocumento == idDocumento);
		}


		/// <summary>
        /// Crea una instancia de DocumentosIBAN en la base de datos
        /// </summary>
        /// <param name="source">DocumentosIBAN a crear</param>
        /// <returns>DocumentosIBAN creado</returns>
		public virtual async Task<DocumentosIBAN> CreateDocumentosIBANAsync(DocumentosIBAN source)
		{
			return await _efRepository.CreateAsync<DocumentosIBAN>(source);
		}

		/// <summary>
        /// Crea una instancia de DocumentosIBAN en la base de datos
        /// </summary>
        /// <param name="source">DocumentosIBAN a crear</param>
        /// <returns>DocumentosIBAN creado</returns>
		public virtual DocumentosIBAN CreateDocumentosIBAN(DocumentosIBAN source)
		{
			return _efRepository.Create<DocumentosIBAN>(source);
		}


		/// <summary>
        /// Modifica una instancia de DocumentosIBAN en la base de datos
        /// </summary>
        /// <param name="source">DocumentosIBAN a modificar</param>
        /// <returns>Número de DocumentosIBAN modificados</returns>
		public async Task<int> UpdateDocumentosIBANAsync(DocumentosIBAN source)
		{
			return await _efRepository.UpdateAsync<DocumentosIBAN>(source);
		}

		/// <summary>
        /// Modifica una instancia de DocumentosIBAN en la base de datos
        /// </summary>
        /// <param name="source">DocumentosIBAN a modificar</param>
        /// <returns>Número de DocumentosIBAN modificados</returns>
		public int UpdateDocumentosIBAN(DocumentosIBAN source)
		{
			return _efRepository.Update<DocumentosIBAN>(source);
		}

		/// <summary>
        /// Borra una instancia de DocumentosIBAN en la base de datos
        /// </summary>
        /// <param name="source">DocumentosIBAN a borrar</param>
        /// <returns>Número de DocumentosIBAN borrados</returns>
		public async Task<int> DeleteDocumentosIBANAsync(DocumentosIBAN source)
		{
			return await _efRepository.DeleteAsync<DocumentosIBAN>(source);
		}

		/// <summary>
        /// Borra una instancia de DocumentosIBAN en la base de datos
        /// </summary>
        /// <param name="source">DocumentosIBAN a borrar</param>
        /// <returns>Número de DocumentosIBAN borrados</returns>
		public int DeleteDocumentosIBAN(DocumentosIBAN source)
		{
			return _efRepository.Delete<DocumentosIBAN>(source);
		}
    }
}
