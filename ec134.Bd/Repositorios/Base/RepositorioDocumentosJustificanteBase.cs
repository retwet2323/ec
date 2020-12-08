using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioDocumentosJustificanteBase : IRepositorioDocumentosJustificanteBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase DocumentosJustificante 
        /// </summary>
		public RepositorioDocumentosJustificanteBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los DocumentosJustificante 
        /// </summary>
        /// <returns>IQueryable con todos los DocumentosJustificante</returns>
		public IQueryable<DocumentosJustificante> GetDocumentosJustificante()
		{
			return _efRepository.All<DocumentosJustificante>();
		}

        
        /// <summary>
        /// Obtener un DocumentosJustificante por su clave primaria
        /// </summary>
		/// <param name="idDocumento">IdDocumento</param>
        /// <returns>DocumentosJustificante   seleccionado por su clave primaria</returns>
		public async Task<DocumentosJustificante> GetDocumentosJustificanteByPrimaryKeyAsync(int idDocumento)
		{
			return await _efRepository.FindAsync<DocumentosJustificante>(x=>x.IdDocumento == idDocumento);
		}

        /// <summary>
        /// Obtener un DocumentosJustificante por su clave primaria
        /// </summary>
		/// <param name="idDocumento">IdDocumento</param>
        /// <returns>DocumentosJustificante  seleccionado por su clave primaria</returns>
		public DocumentosJustificante GetDocumentosJustificanteByPrimaryKey(int idDocumento)
		{
			return _efRepository.Find<DocumentosJustificante>(x=>x.IdDocumento == idDocumento);
		}


		/// <summary>
        /// Crea una instancia de DocumentosJustificante en la base de datos
        /// </summary>
        /// <param name="source">DocumentosJustificante a crear</param>
        /// <returns>DocumentosJustificante creado</returns>
		public virtual async Task<DocumentosJustificante> CreateDocumentosJustificanteAsync(DocumentosJustificante source)
		{
			return await _efRepository.CreateAsync<DocumentosJustificante>(source);
		}

		/// <summary>
        /// Crea una instancia de DocumentosJustificante en la base de datos
        /// </summary>
        /// <param name="source">DocumentosJustificante a crear</param>
        /// <returns>DocumentosJustificante creado</returns>
		public virtual DocumentosJustificante CreateDocumentosJustificante(DocumentosJustificante source)
		{
			return _efRepository.Create<DocumentosJustificante>(source);
		}


		/// <summary>
        /// Modifica una instancia de DocumentosJustificante en la base de datos
        /// </summary>
        /// <param name="source">DocumentosJustificante a modificar</param>
        /// <returns>Número de DocumentosJustificante modificados</returns>
		public async Task<int> UpdateDocumentosJustificanteAsync(DocumentosJustificante source)
		{
			return await _efRepository.UpdateAsync<DocumentosJustificante>(source);
		}

		/// <summary>
        /// Modifica una instancia de DocumentosJustificante en la base de datos
        /// </summary>
        /// <param name="source">DocumentosJustificante a modificar</param>
        /// <returns>Número de DocumentosJustificante modificados</returns>
		public int UpdateDocumentosJustificante(DocumentosJustificante source)
		{
			return _efRepository.Update<DocumentosJustificante>(source);
		}

		/// <summary>
        /// Borra una instancia de DocumentosJustificante en la base de datos
        /// </summary>
        /// <param name="source">DocumentosJustificante a borrar</param>
        /// <returns>Número de DocumentosJustificante borrados</returns>
		public async Task<int> DeleteDocumentosJustificanteAsync(DocumentosJustificante source)
		{
			return await _efRepository.DeleteAsync<DocumentosJustificante>(source);
		}

		/// <summary>
        /// Borra una instancia de DocumentosJustificante en la base de datos
        /// </summary>
        /// <param name="source">DocumentosJustificante a borrar</param>
        /// <returns>Número de DocumentosJustificante borrados</returns>
		public int DeleteDocumentosJustificante(DocumentosJustificante source)
		{
			return _efRepository.Delete<DocumentosJustificante>(source);
		}
    }
}
