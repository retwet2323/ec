using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioVerificacionDocumentalDI_ResultadosBase : IRepositorioVerificacionDocumentalDI_ResultadosBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase VerificacionDocumentalDI_Resultados 
        /// </summary>
		public RepositorioVerificacionDocumentalDI_ResultadosBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los VerificacionDocumentalDI_Resultados 
        /// </summary>
        /// <returns>IQueryable con todos los VerificacionDocumentalDI_Resultados</returns>
		public IQueryable<VerificacionDocumentalDI_Resultados> GetVerificacionDocumentalDI_Resultados()
		{
			return _efRepository.All<VerificacionDocumentalDI_Resultados>();
		}

        
        /// <summary>
        /// Obtener un VerificacionDocumentalDI_Resultados por su clave primaria
        /// </summary>
		/// <param name="idResultado">IdResultado</param>
        /// <returns>VerificacionDocumentalDI_Resultados   seleccionado por su clave primaria</returns>
		public async Task<VerificacionDocumentalDI_Resultados> GetVerificacionDocumentalDI_ResultadosByPrimaryKeyAsync(int idResultado)
		{
			return await _efRepository.FindAsync<VerificacionDocumentalDI_Resultados>(x=>x.IdResultado == idResultado);
		}

        /// <summary>
        /// Obtener un VerificacionDocumentalDI_Resultados por su clave primaria
        /// </summary>
		/// <param name="idResultado">IdResultado</param>
        /// <returns>VerificacionDocumentalDI_Resultados  seleccionado por su clave primaria</returns>
		public VerificacionDocumentalDI_Resultados GetVerificacionDocumentalDI_ResultadosByPrimaryKey(int idResultado)
		{
			return _efRepository.Find<VerificacionDocumentalDI_Resultados>(x=>x.IdResultado == idResultado);
		}




		/// <summary>
        /// Crea una instancia de VerificacionDocumentalDI_Resultados en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI_Resultados a crear</param>
        /// <returns>VerificacionDocumentalDI_Resultados creado</returns>
		public virtual async Task<VerificacionDocumentalDI_Resultados> CreateVerificacionDocumentalDI_ResultadosAsync(VerificacionDocumentalDI_Resultados source)
		{
			return await _efRepository.CreateAsync<VerificacionDocumentalDI_Resultados>(source);
		}

		/// <summary>
        /// Crea una instancia de VerificacionDocumentalDI_Resultados en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI_Resultados a crear</param>
        /// <returns>VerificacionDocumentalDI_Resultados creado</returns>
		public virtual VerificacionDocumentalDI_Resultados CreateVerificacionDocumentalDI_Resultados(VerificacionDocumentalDI_Resultados source)
		{
			return _efRepository.Create<VerificacionDocumentalDI_Resultados>(source);
		}


		/// <summary>
        /// Modifica una instancia de VerificacionDocumentalDI_Resultados en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI_Resultados a modificar</param>
        /// <returns>Número de VerificacionDocumentalDI_Resultados modificados</returns>
		public async Task<int> UpdateVerificacionDocumentalDI_ResultadosAsync(VerificacionDocumentalDI_Resultados source)
		{
			return await _efRepository.UpdateAsync<VerificacionDocumentalDI_Resultados>(source);
		}

		/// <summary>
        /// Modifica una instancia de VerificacionDocumentalDI_Resultados en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI_Resultados a modificar</param>
        /// <returns>Número de VerificacionDocumentalDI_Resultados modificados</returns>
		public int UpdateVerificacionDocumentalDI_Resultados(VerificacionDocumentalDI_Resultados source)
		{
			return _efRepository.Update<VerificacionDocumentalDI_Resultados>(source);
		}

		/// <summary>
        /// Borra una instancia de VerificacionDocumentalDI_Resultados en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI_Resultados a borrar</param>
        /// <returns>Número de VerificacionDocumentalDI_Resultados borrados</returns>
		public async Task<int> DeleteVerificacionDocumentalDI_ResultadosAsync(VerificacionDocumentalDI_Resultados source)
		{
			return await _efRepository.DeleteAsync<VerificacionDocumentalDI_Resultados>(source);
		}

		/// <summary>
        /// Borra una instancia de VerificacionDocumentalDI_Resultados en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI_Resultados a borrar</param>
        /// <returns>Número de VerificacionDocumentalDI_Resultados borrados</returns>
		public int DeleteVerificacionDocumentalDI_Resultados(VerificacionDocumentalDI_Resultados source)
		{
			return _efRepository.Delete<VerificacionDocumentalDI_Resultados>(source);
		}
    }
}
