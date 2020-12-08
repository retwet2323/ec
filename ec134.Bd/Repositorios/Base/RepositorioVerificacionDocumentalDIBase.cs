using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioVerificacionDocumentalDIBase : IRepositorioVerificacionDocumentalDIBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase VerificacionDocumentalDI 
        /// </summary>
		public RepositorioVerificacionDocumentalDIBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los VerificacionDocumentalDI 
        /// </summary>
        /// <returns>IQueryable con todos los VerificacionDocumentalDI</returns>
		public IQueryable<VerificacionDocumentalDI> GetVerificacionDocumentalDI()
		{
			return _efRepository.All<VerificacionDocumentalDI>();
		}

        
        /// <summary>
        /// Obtener un VerificacionDocumentalDI por su clave primaria
        /// </summary>
		/// <param name="idRespuesta">IdRespuesta</param>
        /// <returns>VerificacionDocumentalDI   seleccionado por su clave primaria</returns>
		public async Task<VerificacionDocumentalDI> GetVerificacionDocumentalDIByPrimaryKeyAsync(int idRespuesta)
		{
			return await _efRepository.FindAsync<VerificacionDocumentalDI>(x=>x.IdRespuesta == idRespuesta);
		}

        /// <summary>
        /// Obtener un VerificacionDocumentalDI por su clave primaria
        /// </summary>
		/// <param name="idRespuesta">IdRespuesta</param>
        /// <returns>VerificacionDocumentalDI  seleccionado por su clave primaria</returns>
		public VerificacionDocumentalDI GetVerificacionDocumentalDIByPrimaryKey(int idRespuesta)
		{
			return _efRepository.Find<VerificacionDocumentalDI>(x=>x.IdRespuesta == idRespuesta);
		}




		/// <summary>
        /// Crea una instancia de VerificacionDocumentalDI en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI a crear</param>
        /// <returns>VerificacionDocumentalDI creado</returns>
		public virtual async Task<VerificacionDocumentalDI> CreateVerificacionDocumentalDIAsync(VerificacionDocumentalDI source)
		{
			return await _efRepository.CreateAsync<VerificacionDocumentalDI>(source);
		}

		/// <summary>
        /// Crea una instancia de VerificacionDocumentalDI en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI a crear</param>
        /// <returns>VerificacionDocumentalDI creado</returns>
		public virtual VerificacionDocumentalDI CreateVerificacionDocumentalDI(VerificacionDocumentalDI source)
		{
			return _efRepository.Create<VerificacionDocumentalDI>(source);
		}


		/// <summary>
        /// Modifica una instancia de VerificacionDocumentalDI en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI a modificar</param>
        /// <returns>Número de VerificacionDocumentalDI modificados</returns>
		public async Task<int> UpdateVerificacionDocumentalDIAsync(VerificacionDocumentalDI source)
		{
			return await _efRepository.UpdateAsync<VerificacionDocumentalDI>(source);
		}

		/// <summary>
        /// Modifica una instancia de VerificacionDocumentalDI en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI a modificar</param>
        /// <returns>Número de VerificacionDocumentalDI modificados</returns>
		public int UpdateVerificacionDocumentalDI(VerificacionDocumentalDI source)
		{
			return _efRepository.Update<VerificacionDocumentalDI>(source);
		}

		/// <summary>
        /// Borra una instancia de VerificacionDocumentalDI en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI a borrar</param>
        /// <returns>Número de VerificacionDocumentalDI borrados</returns>
		public async Task<int> DeleteVerificacionDocumentalDIAsync(VerificacionDocumentalDI source)
		{
			return await _efRepository.DeleteAsync<VerificacionDocumentalDI>(source);
		}

		/// <summary>
        /// Borra una instancia de VerificacionDocumentalDI en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI a borrar</param>
        /// <returns>Número de VerificacionDocumentalDI borrados</returns>
		public int DeleteVerificacionDocumentalDI(VerificacionDocumentalDI source)
		{
			return _efRepository.Delete<VerificacionDocumentalDI>(source);
		}
    }
}
