using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioDocumentosBase : IRepositorioDocumentosBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase Documentos 
        /// </summary>
		public RepositorioDocumentosBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los Documentos 
        /// </summary>
        /// <returns>IQueryable con todos los Documentos</returns>
		public IQueryable<Documentos> GetDocumentos()
		{
			return _efRepository.All<Documentos>();
		}

        
        /// <summary>
        /// Obtener un Documentos por su clave primaria
        /// </summary>
		/// <param name="idDocumento">IdDocumento</param>
        /// <returns>Documentos   seleccionado por su clave primaria</returns>
		public async Task<Documentos> GetDocumentosByPrimaryKeyAsync(int idDocumento)
		{
			return await _efRepository.FindAsync<Documentos>(x=>x.IdDocumento == idDocumento);
		}

        /// <summary>
        /// Obtener un Documentos por su clave primaria
        /// </summary>
		/// <param name="idDocumento">IdDocumento</param>
        /// <returns>Documentos  seleccionado por su clave primaria</returns>
		public Documentos GetDocumentosByPrimaryKey(int idDocumento)
		{
			return _efRepository.Find<Documentos>(x=>x.IdDocumento == idDocumento);
		}


		/// <summary>
        /// Crea una instancia de Documentos en la base de datos
        /// </summary>
        /// <param name="source">Documentos a crear</param>
        /// <returns>Documentos creado</returns>
		public virtual async Task<Documentos> CreateDocumentosAsync(Documentos source)
		{
			return await _efRepository.CreateAsync<Documentos>(source);
		}

		/// <summary>
        /// Crea una instancia de Documentos en la base de datos
        /// </summary>
        /// <param name="source">Documentos a crear</param>
        /// <returns>Documentos creado</returns>
		public virtual Documentos CreateDocumentos(Documentos source)
		{
			return _efRepository.Create<Documentos>(source);
		}


		/// <summary>
        /// Modifica una instancia de Documentos en la base de datos
        /// </summary>
        /// <param name="source">Documentos a modificar</param>
        /// <returns>Número de Documentos modificados</returns>
		public async Task<int> UpdateDocumentosAsync(Documentos source)
		{
			return await _efRepository.UpdateAsync<Documentos>(source);
		}

		/// <summary>
        /// Modifica una instancia de Documentos en la base de datos
        /// </summary>
        /// <param name="source">Documentos a modificar</param>
        /// <returns>Número de Documentos modificados</returns>
		public int UpdateDocumentos(Documentos source)
		{
			return _efRepository.Update<Documentos>(source);
		}

		/// <summary>
        /// Borra una instancia de Documentos en la base de datos
        /// </summary>
        /// <param name="source">Documentos a borrar</param>
        /// <returns>Número de Documentos borrados</returns>
		public async Task<int> DeleteDocumentosAsync(Documentos source)
		{
			return await _efRepository.DeleteAsync<Documentos>(source);
		}

		/// <summary>
        /// Borra una instancia de Documentos en la base de datos
        /// </summary>
        /// <param name="source">Documentos a borrar</param>
        /// <returns>Número de Documentos borrados</returns>
		public int DeleteDocumentos(Documentos source)
		{
			return _efRepository.Delete<Documentos>(source);
		}
    }
}
