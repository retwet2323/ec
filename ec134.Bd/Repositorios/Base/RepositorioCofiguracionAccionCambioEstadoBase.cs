using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioCofiguracionAccionCambioEstadoBase : IRepositorioCofiguracionAccionCambioEstadoBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase CofiguracionAccionCambioEstado 
        /// </summary>
		public RepositorioCofiguracionAccionCambioEstadoBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los CofiguracionAccionCambioEstado 
        /// </summary>
        /// <returns>IQueryable con todos los CofiguracionAccionCambioEstado</returns>
		public IQueryable<CofiguracionAccionCambioEstado> GetCofiguracionAccionCambioEstado()
		{
			return _efRepository.All<CofiguracionAccionCambioEstado>();
		}

        
        /// <summary>
        /// Obtener un CofiguracionAccionCambioEstado por su clave primaria
        /// </summary>
		/// <param name="idConfiguracioAccionCambioEstado">IdConfiguracioAccionCambioEstado</param>
        /// <returns>CofiguracionAccionCambioEstado   seleccionado por su clave primaria</returns>
		public async Task<CofiguracionAccionCambioEstado> GetCofiguracionAccionCambioEstadoByPrimaryKeyAsync(int idConfiguracioAccionCambioEstado)
		{
			return await _efRepository.FindAsync<CofiguracionAccionCambioEstado>(x=>x.IdConfiguracioAccionCambioEstado == idConfiguracioAccionCambioEstado);
		}

        /// <summary>
        /// Obtener un CofiguracionAccionCambioEstado por su clave primaria
        /// </summary>
		/// <param name="idConfiguracioAccionCambioEstado">IdConfiguracioAccionCambioEstado</param>
        /// <returns>CofiguracionAccionCambioEstado  seleccionado por su clave primaria</returns>
		public CofiguracionAccionCambioEstado GetCofiguracionAccionCambioEstadoByPrimaryKey(int idConfiguracioAccionCambioEstado)
		{
			return _efRepository.Find<CofiguracionAccionCambioEstado>(x=>x.IdConfiguracioAccionCambioEstado == idConfiguracioAccionCambioEstado);
		}




		/// <summary>
        /// Crea una instancia de CofiguracionAccionCambioEstado en la base de datos
        /// </summary>
        /// <param name="source">CofiguracionAccionCambioEstado a crear</param>
        /// <returns>CofiguracionAccionCambioEstado creado</returns>
		public virtual async Task<CofiguracionAccionCambioEstado> CreateCofiguracionAccionCambioEstadoAsync(CofiguracionAccionCambioEstado source)
		{
			return await _efRepository.CreateAsync<CofiguracionAccionCambioEstado>(source);
		}

		/// <summary>
        /// Crea una instancia de CofiguracionAccionCambioEstado en la base de datos
        /// </summary>
        /// <param name="source">CofiguracionAccionCambioEstado a crear</param>
        /// <returns>CofiguracionAccionCambioEstado creado</returns>
		public virtual CofiguracionAccionCambioEstado CreateCofiguracionAccionCambioEstado(CofiguracionAccionCambioEstado source)
		{
			return _efRepository.Create<CofiguracionAccionCambioEstado>(source);
		}


		/// <summary>
        /// Modifica una instancia de CofiguracionAccionCambioEstado en la base de datos
        /// </summary>
        /// <param name="source">CofiguracionAccionCambioEstado a modificar</param>
        /// <returns>Número de CofiguracionAccionCambioEstado modificados</returns>
		public async Task<int> UpdateCofiguracionAccionCambioEstadoAsync(CofiguracionAccionCambioEstado source)
		{
			return await _efRepository.UpdateAsync<CofiguracionAccionCambioEstado>(source);
		}

		/// <summary>
        /// Modifica una instancia de CofiguracionAccionCambioEstado en la base de datos
        /// </summary>
        /// <param name="source">CofiguracionAccionCambioEstado a modificar</param>
        /// <returns>Número de CofiguracionAccionCambioEstado modificados</returns>
		public int UpdateCofiguracionAccionCambioEstado(CofiguracionAccionCambioEstado source)
		{
			return _efRepository.Update<CofiguracionAccionCambioEstado>(source);
		}

		/// <summary>
        /// Borra una instancia de CofiguracionAccionCambioEstado en la base de datos
        /// </summary>
        /// <param name="source">CofiguracionAccionCambioEstado a borrar</param>
        /// <returns>Número de CofiguracionAccionCambioEstado borrados</returns>
		public async Task<int> DeleteCofiguracionAccionCambioEstadoAsync(CofiguracionAccionCambioEstado source)
		{
			return await _efRepository.DeleteAsync<CofiguracionAccionCambioEstado>(source);
		}

		/// <summary>
        /// Borra una instancia de CofiguracionAccionCambioEstado en la base de datos
        /// </summary>
        /// <param name="source">CofiguracionAccionCambioEstado a borrar</param>
        /// <returns>Número de CofiguracionAccionCambioEstado borrados</returns>
		public int DeleteCofiguracionAccionCambioEstado(CofiguracionAccionCambioEstado source)
		{
			return _efRepository.Delete<CofiguracionAccionCambioEstado>(source);
		}
    }
}
