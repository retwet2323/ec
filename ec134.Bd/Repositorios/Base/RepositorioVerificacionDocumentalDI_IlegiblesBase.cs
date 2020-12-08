using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioVerificacionDocumentalDI_IlegiblesBase : IRepositorioVerificacionDocumentalDI_IlegiblesBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase VerificacionDocumentalDI_Ilegibles 
        /// </summary>
		public RepositorioVerificacionDocumentalDI_IlegiblesBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los VerificacionDocumentalDI_Ilegibles 
        /// </summary>
        /// <returns>IQueryable con todos los VerificacionDocumentalDI_Ilegibles</returns>
		public IQueryable<VerificacionDocumentalDI_Ilegibles> GetVerificacionDocumentalDI_Ilegibles()
		{
			return _efRepository.All<VerificacionDocumentalDI_Ilegibles>();
		}

        
        /// <summary>
        /// Obtener un VerificacionDocumentalDI_Ilegibles por su clave primaria
        /// </summary>
		/// <param name="idIlegible">IdIlegible</param>
        /// <returns>VerificacionDocumentalDI_Ilegibles   seleccionado por su clave primaria</returns>
		public async Task<VerificacionDocumentalDI_Ilegibles> GetVerificacionDocumentalDI_IlegiblesByPrimaryKeyAsync(int idIlegible)
		{
			return await _efRepository.FindAsync<VerificacionDocumentalDI_Ilegibles>(x=>x.IdIlegible == idIlegible);
		}

        /// <summary>
        /// Obtener un VerificacionDocumentalDI_Ilegibles por su clave primaria
        /// </summary>
		/// <param name="idIlegible">IdIlegible</param>
        /// <returns>VerificacionDocumentalDI_Ilegibles  seleccionado por su clave primaria</returns>
		public VerificacionDocumentalDI_Ilegibles GetVerificacionDocumentalDI_IlegiblesByPrimaryKey(int idIlegible)
		{
			return _efRepository.Find<VerificacionDocumentalDI_Ilegibles>(x=>x.IdIlegible == idIlegible);
		}




		/// <summary>
        /// Crea una instancia de VerificacionDocumentalDI_Ilegibles en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI_Ilegibles a crear</param>
        /// <returns>VerificacionDocumentalDI_Ilegibles creado</returns>
		public virtual async Task<VerificacionDocumentalDI_Ilegibles> CreateVerificacionDocumentalDI_IlegiblesAsync(VerificacionDocumentalDI_Ilegibles source)
		{
			return await _efRepository.CreateAsync<VerificacionDocumentalDI_Ilegibles>(source);
		}

		/// <summary>
        /// Crea una instancia de VerificacionDocumentalDI_Ilegibles en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI_Ilegibles a crear</param>
        /// <returns>VerificacionDocumentalDI_Ilegibles creado</returns>
		public virtual VerificacionDocumentalDI_Ilegibles CreateVerificacionDocumentalDI_Ilegibles(VerificacionDocumentalDI_Ilegibles source)
		{
			return _efRepository.Create<VerificacionDocumentalDI_Ilegibles>(source);
		}


		/// <summary>
        /// Modifica una instancia de VerificacionDocumentalDI_Ilegibles en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI_Ilegibles a modificar</param>
        /// <returns>Número de VerificacionDocumentalDI_Ilegibles modificados</returns>
		public async Task<int> UpdateVerificacionDocumentalDI_IlegiblesAsync(VerificacionDocumentalDI_Ilegibles source)
		{
			return await _efRepository.UpdateAsync<VerificacionDocumentalDI_Ilegibles>(source);
		}

		/// <summary>
        /// Modifica una instancia de VerificacionDocumentalDI_Ilegibles en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI_Ilegibles a modificar</param>
        /// <returns>Número de VerificacionDocumentalDI_Ilegibles modificados</returns>
		public int UpdateVerificacionDocumentalDI_Ilegibles(VerificacionDocumentalDI_Ilegibles source)
		{
			return _efRepository.Update<VerificacionDocumentalDI_Ilegibles>(source);
		}

		/// <summary>
        /// Borra una instancia de VerificacionDocumentalDI_Ilegibles en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI_Ilegibles a borrar</param>
        /// <returns>Número de VerificacionDocumentalDI_Ilegibles borrados</returns>
		public async Task<int> DeleteVerificacionDocumentalDI_IlegiblesAsync(VerificacionDocumentalDI_Ilegibles source)
		{
			return await _efRepository.DeleteAsync<VerificacionDocumentalDI_Ilegibles>(source);
		}

		/// <summary>
        /// Borra una instancia de VerificacionDocumentalDI_Ilegibles en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI_Ilegibles a borrar</param>
        /// <returns>Número de VerificacionDocumentalDI_Ilegibles borrados</returns>
		public int DeleteVerificacionDocumentalDI_Ilegibles(VerificacionDocumentalDI_Ilegibles source)
		{
			return _efRepository.Delete<VerificacionDocumentalDI_Ilegibles>(source);
		}
    }
}
