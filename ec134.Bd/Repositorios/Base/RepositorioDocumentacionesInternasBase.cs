using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioDocumentacionesInternasBase : IRepositorioDocumentacionesInternasBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase DocumentacionesInternas 
        /// </summary>
		public RepositorioDocumentacionesInternasBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los DocumentacionesInternas 
        /// </summary>
        /// <returns>IQueryable con todos los DocumentacionesInternas</returns>
		public IQueryable<DocumentacionesInternas> GetDocumentacionesInternas()
		{
			return _efRepository.All<DocumentacionesInternas>();
		}

        
        /// <summary>
        /// Obtener un DocumentacionesInternas por su clave primaria
        /// </summary>
		/// <param name="idDocumentacionInterna">IdDocumentacionInterna</param>
        /// <returns>DocumentacionesInternas   seleccionado por su clave primaria</returns>
		public async Task<DocumentacionesInternas> GetDocumentacionesInternasByPrimaryKeyAsync(int idDocumentacionInterna)
		{
			return await _efRepository.FindAsync<DocumentacionesInternas>(x=>x.IdDocumentacionInterna == idDocumentacionInterna);
		}

        /// <summary>
        /// Obtener un DocumentacionesInternas por su clave primaria
        /// </summary>
		/// <param name="idDocumentacionInterna">IdDocumentacionInterna</param>
        /// <returns>DocumentacionesInternas  seleccionado por su clave primaria</returns>
		public DocumentacionesInternas GetDocumentacionesInternasByPrimaryKey(int idDocumentacionInterna)
		{
			return _efRepository.Find<DocumentacionesInternas>(x=>x.IdDocumentacionInterna == idDocumentacionInterna);
		}




		/// <summary>
        /// Crea una instancia de DocumentacionesInternas en la base de datos
        /// </summary>
        /// <param name="source">DocumentacionesInternas a crear</param>
        /// <returns>DocumentacionesInternas creado</returns>
		public virtual async Task<DocumentacionesInternas> CreateDocumentacionesInternasAsync(DocumentacionesInternas source)
		{
			return await _efRepository.CreateAsync<DocumentacionesInternas>(source);
		}

		/// <summary>
        /// Crea una instancia de DocumentacionesInternas en la base de datos
        /// </summary>
        /// <param name="source">DocumentacionesInternas a crear</param>
        /// <returns>DocumentacionesInternas creado</returns>
		public virtual DocumentacionesInternas CreateDocumentacionesInternas(DocumentacionesInternas source)
		{
			return _efRepository.Create<DocumentacionesInternas>(source);
		}


		/// <summary>
        /// Modifica una instancia de DocumentacionesInternas en la base de datos
        /// </summary>
        /// <param name="source">DocumentacionesInternas a modificar</param>
        /// <returns>Número de DocumentacionesInternas modificados</returns>
		public async Task<int> UpdateDocumentacionesInternasAsync(DocumentacionesInternas source)
		{
			return await _efRepository.UpdateAsync<DocumentacionesInternas>(source);
		}

		/// <summary>
        /// Modifica una instancia de DocumentacionesInternas en la base de datos
        /// </summary>
        /// <param name="source">DocumentacionesInternas a modificar</param>
        /// <returns>Número de DocumentacionesInternas modificados</returns>
		public int UpdateDocumentacionesInternas(DocumentacionesInternas source)
		{
			return _efRepository.Update<DocumentacionesInternas>(source);
		}

		/// <summary>
        /// Borra una instancia de DocumentacionesInternas en la base de datos
        /// </summary>
        /// <param name="source">DocumentacionesInternas a borrar</param>
        /// <returns>Número de DocumentacionesInternas borrados</returns>
		public async Task<int> DeleteDocumentacionesInternasAsync(DocumentacionesInternas source)
		{
			return await _efRepository.DeleteAsync<DocumentacionesInternas>(source);
		}

		/// <summary>
        /// Borra una instancia de DocumentacionesInternas en la base de datos
        /// </summary>
        /// <param name="source">DocumentacionesInternas a borrar</param>
        /// <returns>Número de DocumentacionesInternas borrados</returns>
		public int DeleteDocumentacionesInternas(DocumentacionesInternas source)
		{
			return _efRepository.Delete<DocumentacionesInternas>(source);
		}
    }
}
