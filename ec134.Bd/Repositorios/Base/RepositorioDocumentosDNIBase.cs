using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioDocumentosDNIBase : IRepositorioDocumentosDNIBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase DocumentosDNI 
        /// </summary>
		public RepositorioDocumentosDNIBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los DocumentosDNI 
        /// </summary>
        /// <returns>IQueryable con todos los DocumentosDNI</returns>
		public IQueryable<DocumentosDNI> GetDocumentosDNI()
		{
			return _efRepository.All<DocumentosDNI>();
		}

        
        /// <summary>
        /// Obtener un DocumentosDNI por su clave primaria
        /// </summary>
		/// <param name="idDocumento">IdDocumento</param>
        /// <returns>DocumentosDNI   seleccionado por su clave primaria</returns>
		public async Task<DocumentosDNI> GetDocumentosDNIByPrimaryKeyAsync(int idDocumento)
		{
			return await _efRepository.FindAsync<DocumentosDNI>(x=>x.IdDocumento == idDocumento);
		}

        /// <summary>
        /// Obtener un DocumentosDNI por su clave primaria
        /// </summary>
		/// <param name="idDocumento">IdDocumento</param>
        /// <returns>DocumentosDNI  seleccionado por su clave primaria</returns>
		public DocumentosDNI GetDocumentosDNIByPrimaryKey(int idDocumento)
		{
			return _efRepository.Find<DocumentosDNI>(x=>x.IdDocumento == idDocumento);
		}


		/// <summary>
        /// Crea una instancia de DocumentosDNI en la base de datos
        /// </summary>
        /// <param name="source">DocumentosDNI a crear</param>
        /// <returns>DocumentosDNI creado</returns>
		public virtual async Task<DocumentosDNI> CreateDocumentosDNIAsync(DocumentosDNI source)
		{
			return await _efRepository.CreateAsync<DocumentosDNI>(source);
		}

		/// <summary>
        /// Crea una instancia de DocumentosDNI en la base de datos
        /// </summary>
        /// <param name="source">DocumentosDNI a crear</param>
        /// <returns>DocumentosDNI creado</returns>
		public virtual DocumentosDNI CreateDocumentosDNI(DocumentosDNI source)
		{
			return _efRepository.Create<DocumentosDNI>(source);
		}


		/// <summary>
        /// Modifica una instancia de DocumentosDNI en la base de datos
        /// </summary>
        /// <param name="source">DocumentosDNI a modificar</param>
        /// <returns>Número de DocumentosDNI modificados</returns>
		public async Task<int> UpdateDocumentosDNIAsync(DocumentosDNI source)
		{
			return await _efRepository.UpdateAsync<DocumentosDNI>(source);
		}

		/// <summary>
        /// Modifica una instancia de DocumentosDNI en la base de datos
        /// </summary>
        /// <param name="source">DocumentosDNI a modificar</param>
        /// <returns>Número de DocumentosDNI modificados</returns>
		public int UpdateDocumentosDNI(DocumentosDNI source)
		{
			return _efRepository.Update<DocumentosDNI>(source);
		}

		/// <summary>
        /// Borra una instancia de DocumentosDNI en la base de datos
        /// </summary>
        /// <param name="source">DocumentosDNI a borrar</param>
        /// <returns>Número de DocumentosDNI borrados</returns>
		public async Task<int> DeleteDocumentosDNIAsync(DocumentosDNI source)
		{
			return await _efRepository.DeleteAsync<DocumentosDNI>(source);
		}

		/// <summary>
        /// Borra una instancia de DocumentosDNI en la base de datos
        /// </summary>
        /// <param name="source">DocumentosDNI a borrar</param>
        /// <returns>Número de DocumentosDNI borrados</returns>
		public int DeleteDocumentosDNI(DocumentosDNI source)
		{
			return _efRepository.Delete<DocumentosDNI>(source);
		}
    }
}
