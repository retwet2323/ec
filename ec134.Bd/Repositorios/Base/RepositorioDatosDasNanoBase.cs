using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioDatosDasNanoBase : IRepositorioDatosDasNanoBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase DatosDasNano 
        /// </summary>
		public RepositorioDatosDasNanoBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los DatosDasNano 
        /// </summary>
        /// <returns>IQueryable con todos los DatosDasNano</returns>
		public IQueryable<DatosDasNano> GetDatosDasNano()
		{
			return _efRepository.All<DatosDasNano>();
		}

        
        /// <summary>
        /// Obtener un DatosDasNano por su clave primaria
        /// </summary>
		/// <param name="idDatosDasNano">IdDatosDasNano</param>
        /// <returns>DatosDasNano   seleccionado por su clave primaria</returns>
		public async Task<DatosDasNano> GetDatosDasNanoByPrimaryKeyAsync(int idDatosDasNano)
		{
			return await _efRepository.FindAsync<DatosDasNano>(x=>x.IdDatosDasNano == idDatosDasNano);
		}

        /// <summary>
        /// Obtener un DatosDasNano por su clave primaria
        /// </summary>
		/// <param name="idDatosDasNano">IdDatosDasNano</param>
        /// <returns>DatosDasNano  seleccionado por su clave primaria</returns>
		public DatosDasNano GetDatosDasNanoByPrimaryKey(int idDatosDasNano)
		{
			return _efRepository.Find<DatosDasNano>(x=>x.IdDatosDasNano == idDatosDasNano);
		}


        /// <summary>
        /// Obtener un IQueryable<DatosDasNano> por su IdTransaccionDasNano 
        /// </summary>
		/// <param name="idTransaccionDasNano">IdTransaccionDasNano</param>
        /// <returns>IQueryable con los DatosDasNano seleccionado por su IdTransaccionDasNano </returns>
		public IQueryable<DatosDasNano> GetDatosDasNanoByIdTransaccionDasNano(int idTransaccionDasNano)
		{
			return _efRepository.Filter<DatosDasNano>(x=> x.IdTransaccionDasNano == idTransaccionDasNano);
		}


		/// <summary>
        /// Crea una instancia de DatosDasNano en la base de datos
        /// </summary>
        /// <param name="source">DatosDasNano a crear</param>
        /// <returns>DatosDasNano creado</returns>
		public virtual async Task<DatosDasNano> CreateDatosDasNanoAsync(DatosDasNano source)
		{
			return await _efRepository.CreateAsync<DatosDasNano>(source);
		}

		/// <summary>
        /// Crea una instancia de DatosDasNano en la base de datos
        /// </summary>
        /// <param name="source">DatosDasNano a crear</param>
        /// <returns>DatosDasNano creado</returns>
		public virtual DatosDasNano CreateDatosDasNano(DatosDasNano source)
		{
			return _efRepository.Create<DatosDasNano>(source);
		}


		/// <summary>
        /// Modifica una instancia de DatosDasNano en la base de datos
        /// </summary>
        /// <param name="source">DatosDasNano a modificar</param>
        /// <returns>Número de DatosDasNano modificados</returns>
		public async Task<int> UpdateDatosDasNanoAsync(DatosDasNano source)
		{
			return await _efRepository.UpdateAsync<DatosDasNano>(source);
		}

		/// <summary>
        /// Modifica una instancia de DatosDasNano en la base de datos
        /// </summary>
        /// <param name="source">DatosDasNano a modificar</param>
        /// <returns>Número de DatosDasNano modificados</returns>
		public int UpdateDatosDasNano(DatosDasNano source)
		{
			return _efRepository.Update<DatosDasNano>(source);
		}

		/// <summary>
        /// Borra una instancia de DatosDasNano en la base de datos
        /// </summary>
        /// <param name="source">DatosDasNano a borrar</param>
        /// <returns>Número de DatosDasNano borrados</returns>
		public async Task<int> DeleteDatosDasNanoAsync(DatosDasNano source)
		{
			return await _efRepository.DeleteAsync<DatosDasNano>(source);
		}

		/// <summary>
        /// Borra una instancia de DatosDasNano en la base de datos
        /// </summary>
        /// <param name="source">DatosDasNano a borrar</param>
        /// <returns>Número de DatosDasNano borrados</returns>
		public int DeleteDatosDasNano(DatosDasNano source)
		{
			return _efRepository.Delete<DatosDasNano>(source);
		}
    }
}
