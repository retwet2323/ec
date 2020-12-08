using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioValidacionesDasNanoBase : IRepositorioValidacionesDasNanoBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase ValidacionesDasNano 
        /// </summary>
		public RepositorioValidacionesDasNanoBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los ValidacionesDasNano 
        /// </summary>
        /// <returns>IQueryable con todos los ValidacionesDasNano</returns>
		public IQueryable<ValidacionesDasNano> GetValidacionesDasNano()
		{
			return _efRepository.All<ValidacionesDasNano>();
		}

        
        /// <summary>
        /// Obtener un ValidacionesDasNano por su clave primaria
        /// </summary>
		/// <param name="idValidacionDasNano">IdValidacionDasNano</param>
        /// <returns>ValidacionesDasNano   seleccionado por su clave primaria</returns>
		public async Task<ValidacionesDasNano> GetValidacionesDasNanoByPrimaryKeyAsync(int idValidacionDasNano)
		{
			return await _efRepository.FindAsync<ValidacionesDasNano>(x=>x.IdValidacionDasNano == idValidacionDasNano);
		}

        /// <summary>
        /// Obtener un ValidacionesDasNano por su clave primaria
        /// </summary>
		/// <param name="idValidacionDasNano">IdValidacionDasNano</param>
        /// <returns>ValidacionesDasNano  seleccionado por su clave primaria</returns>
		public ValidacionesDasNano GetValidacionesDasNanoByPrimaryKey(int idValidacionDasNano)
		{
			return _efRepository.Find<ValidacionesDasNano>(x=>x.IdValidacionDasNano == idValidacionDasNano);
		}


        /// <summary>
        /// Obtener un IQueryable<ValidacionesDasNano> por su IdTransaccionDasNano 
        /// </summary>
		/// <param name="idTransaccionDasNano">IdTransaccionDasNano</param>
        /// <returns>IQueryable con los ValidacionesDasNano seleccionado por su IdTransaccionDasNano </returns>
		public IQueryable<ValidacionesDasNano> GetValidacionesDasNanoByIdTransaccionDasNano(int idTransaccionDasNano)
		{
			return _efRepository.Filter<ValidacionesDasNano>(x=> x.IdTransaccionDasNano == idTransaccionDasNano);
		}


		/// <summary>
        /// Crea una instancia de ValidacionesDasNano en la base de datos
        /// </summary>
        /// <param name="source">ValidacionesDasNano a crear</param>
        /// <returns>ValidacionesDasNano creado</returns>
		public virtual async Task<ValidacionesDasNano> CreateValidacionesDasNanoAsync(ValidacionesDasNano source)
		{
			return await _efRepository.CreateAsync<ValidacionesDasNano>(source);
		}

		/// <summary>
        /// Crea una instancia de ValidacionesDasNano en la base de datos
        /// </summary>
        /// <param name="source">ValidacionesDasNano a crear</param>
        /// <returns>ValidacionesDasNano creado</returns>
		public virtual ValidacionesDasNano CreateValidacionesDasNano(ValidacionesDasNano source)
		{
			return _efRepository.Create<ValidacionesDasNano>(source);
		}


		/// <summary>
        /// Modifica una instancia de ValidacionesDasNano en la base de datos
        /// </summary>
        /// <param name="source">ValidacionesDasNano a modificar</param>
        /// <returns>Número de ValidacionesDasNano modificados</returns>
		public async Task<int> UpdateValidacionesDasNanoAsync(ValidacionesDasNano source)
		{
			return await _efRepository.UpdateAsync<ValidacionesDasNano>(source);
		}

		/// <summary>
        /// Modifica una instancia de ValidacionesDasNano en la base de datos
        /// </summary>
        /// <param name="source">ValidacionesDasNano a modificar</param>
        /// <returns>Número de ValidacionesDasNano modificados</returns>
		public int UpdateValidacionesDasNano(ValidacionesDasNano source)
		{
			return _efRepository.Update<ValidacionesDasNano>(source);
		}

		/// <summary>
        /// Borra una instancia de ValidacionesDasNano en la base de datos
        /// </summary>
        /// <param name="source">ValidacionesDasNano a borrar</param>
        /// <returns>Número de ValidacionesDasNano borrados</returns>
		public async Task<int> DeleteValidacionesDasNanoAsync(ValidacionesDasNano source)
		{
			return await _efRepository.DeleteAsync<ValidacionesDasNano>(source);
		}

		/// <summary>
        /// Borra una instancia de ValidacionesDasNano en la base de datos
        /// </summary>
        /// <param name="source">ValidacionesDasNano a borrar</param>
        /// <returns>Número de ValidacionesDasNano borrados</returns>
		public int DeleteValidacionesDasNano(ValidacionesDasNano source)
		{
			return _efRepository.Delete<ValidacionesDasNano>(source);
		}
    }
}
