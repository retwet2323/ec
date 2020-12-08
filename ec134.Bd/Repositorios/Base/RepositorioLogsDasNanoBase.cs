using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioLogsDasNanoBase : IRepositorioLogsDasNanoBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase LogsDasNano 
        /// </summary>
		public RepositorioLogsDasNanoBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los LogsDasNano 
        /// </summary>
        /// <returns>IQueryable con todos los LogsDasNano</returns>
		public IQueryable<LogsDasNano> GetLogsDasNano()
		{
			return _efRepository.All<LogsDasNano>();
		}

        
        /// <summary>
        /// Obtener un LogsDasNano por su clave primaria
        /// </summary>
		/// <param name="idLogsDasNano">IdLogsDasNano</param>
        /// <returns>LogsDasNano   seleccionado por su clave primaria</returns>
		public async Task<LogsDasNano> GetLogsDasNanoByPrimaryKeyAsync(int idLogsDasNano)
		{
			return await _efRepository.FindAsync<LogsDasNano>(x=>x.IdLogsDasNano == idLogsDasNano);
		}

        /// <summary>
        /// Obtener un LogsDasNano por su clave primaria
        /// </summary>
		/// <param name="idLogsDasNano">IdLogsDasNano</param>
        /// <returns>LogsDasNano  seleccionado por su clave primaria</returns>
		public LogsDasNano GetLogsDasNanoByPrimaryKey(int idLogsDasNano)
		{
			return _efRepository.Find<LogsDasNano>(x=>x.IdLogsDasNano == idLogsDasNano);
		}


        /// <summary>
        /// Obtener un IQueryable<LogsDasNano> por su IdTransaccionDasNano 
        /// </summary>
		/// <param name="idTransaccionDasNano">IdTransaccionDasNano</param>
        /// <returns>IQueryable con los LogsDasNano seleccionado por su IdTransaccionDasNano </returns>
		public IQueryable<LogsDasNano> GetLogsDasNanoByIdTransaccionDasNano(int idTransaccionDasNano)
		{
			return _efRepository.Filter<LogsDasNano>(x=> x.IdTransaccionDasNano == idTransaccionDasNano);
		}


		/// <summary>
        /// Crea una instancia de LogsDasNano en la base de datos
        /// </summary>
        /// <param name="source">LogsDasNano a crear</param>
        /// <returns>LogsDasNano creado</returns>
		public virtual async Task<LogsDasNano> CreateLogsDasNanoAsync(LogsDasNano source)
		{
			return await _efRepository.CreateAsync<LogsDasNano>(source);
		}

		/// <summary>
        /// Crea una instancia de LogsDasNano en la base de Datos
        /// </summary>
        /// <param name="source">LogsDasNano a crear</param>
        /// <returns>LogsDasNano creado</returns>
		public virtual LogsDasNano CreateLogsDasNano(LogsDasNano source)
		{
			return _efRepository.Create<LogsDasNano>(source);
		}


		/// <summary>
        /// Modifica una instancia de LogsDasNano en la base de datos
        /// </summary>
        /// <param name="source">LogsDasNano a modificar</param>
        /// <returns>Número de LogsDasNano modificados</returns>
		public async Task<int> UpdateLogsDasNanoAsync(LogsDasNano source)
		{
			return await _efRepository.UpdateAsync<LogsDasNano>(source);
		}

		/// <summary>
        /// Modifica una instancia de LogsDasNano en la base de datos
        /// </summary>
        /// <param name="source">LogsDasNano a modificar</param>
        /// <returns>Número de LogsDasNano modificados</returns>
		public int UpdateLogsDasNano(LogsDasNano source)
		{
			return _efRepository.Update<LogsDasNano>(source);
		}

		/// <summary>
        /// Borra una instancia de LogsDasNano en la base de datos
        /// </summary>
        /// <param name="source">LogsDasNano a borrar</param>
        /// <returns>Número de LogsDasNano borrados</returns>
		public async Task<int> DeleteLogsDasNanoAsync(LogsDasNano source)
		{
			return await _efRepository.DeleteAsync<LogsDasNano>(source);
		}

		/// <summary>
        /// Borra una instancia de LogsDasNano en la base de datos
        /// </summary>
        /// <param name="source">LogsDasNano a borrar</param>
        /// <returns>Número de LogsDasNano borrados</returns>
		public int DeleteLogsDasNano(LogsDasNano source)
		{
			return _efRepository.Delete<LogsDasNano>(source);
		}
    }
}
