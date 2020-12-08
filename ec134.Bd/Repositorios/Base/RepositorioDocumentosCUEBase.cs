using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioDocumentosCUEBase : IRepositorioDocumentosCUEBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase DocumentosCUE 
        /// </summary>
		public RepositorioDocumentosCUEBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los DocumentosCUE 
        /// </summary>
        /// <returns>IQueryable con todos los DocumentosCUE</returns>
		public IQueryable<DocumentosCUE> GetDocumentosCUE()
		{
			return _efRepository.All<DocumentosCUE>();
		}

        
        /// <summary>
        /// Obtener un DocumentosCUE por su clave primaria
        /// </summary>
		/// <param name="idDocumento">IdDocumento</param>
        /// <returns>DocumentosCUE   seleccionado por su clave primaria</returns>
		public async Task<DocumentosCUE> GetDocumentosCUEByPrimaryKeyAsync(int idDocumento)
		{
			return await _efRepository.FindAsync<DocumentosCUE>(x=>x.IdDocumento == idDocumento);
		}

        /// <summary>
        /// Obtener un DocumentosCUE por su clave primaria
        /// </summary>
		/// <param name="idDocumento">IdDocumento</param>
        /// <returns>DocumentosCUE  seleccionado por su clave primaria</returns>
		public DocumentosCUE GetDocumentosCUEByPrimaryKey(int idDocumento)
		{
			return _efRepository.Find<DocumentosCUE>(x=>x.IdDocumento == idDocumento);
		}


		/// <summary>
        /// Crea una instancia de DocumentosCUE en la base de datos
        /// </summary>
        /// <param name="source">DocumentosCUE a crear</param>
        /// <returns>DocumentosCUE creado</returns>
		public virtual async Task<DocumentosCUE> CreateDocumentosCUEAsync(DocumentosCUE source)
		{
			return await _efRepository.CreateAsync<DocumentosCUE>(source);
		}

		/// <summary>
        /// Crea una instancia de DocumentosCUE en la base de datos
        /// </summary>
        /// <param name="source">DocumentosCUE a crear</param>
        /// <returns>DocumentosCUE creado</returns>
		public virtual DocumentosCUE CreateDocumentosCUE(DocumentosCUE source)
		{
			return _efRepository.Create<DocumentosCUE>(source);
		}


		/// <summary>
        /// Modifica una instancia de DocumentosCUE en la base de datos
        /// </summary>
        /// <param name="source">DocumentosCUE a modificar</param>
        /// <returns>Número de DocumentosCUE modificados</returns>
		public async Task<int> UpdateDocumentosCUEAsync(DocumentosCUE source)
		{
			return await _efRepository.UpdateAsync<DocumentosCUE>(source);
		}

		/// <summary>
        /// Modifica una instancia de DocumentosCUE en la base de datos
        /// </summary>
        /// <param name="source">DocumentosCUE a modificar</param>
        /// <returns>Número de DocumentosCUE modificados</returns>
		public int UpdateDocumentosCUE(DocumentosCUE source)
		{
			return _efRepository.Update<DocumentosCUE>(source);
		}

		/// <summary>
        /// Borra una instancia de DocumentosCUE en la base de datos
        /// </summary>
        /// <param name="source">DocumentosCUE a borrar</param>
        /// <returns>Número de DocumentosCUE borrados</returns>
		public async Task<int> DeleteDocumentosCUEAsync(DocumentosCUE source)
		{
			return await _efRepository.DeleteAsync<DocumentosCUE>(source);
		}

		/// <summary>
        /// Borra una instancia de DocumentosCUE en la base de datos
        /// </summary>
        /// <param name="source">DocumentosCUE a borrar</param>
        /// <returns>Número de DocumentosCUE borrados</returns>
		public int DeleteDocumentosCUE(DocumentosCUE source)
		{
			return _efRepository.Delete<DocumentosCUE>(source);
		}
    }
}
