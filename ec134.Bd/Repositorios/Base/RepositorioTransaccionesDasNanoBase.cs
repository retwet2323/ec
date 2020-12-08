using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioTransaccionesDasNanoBase : IRepositorioTransaccionesDasNanoBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase TransaccionesDasNano 
        /// </summary>
		public RepositorioTransaccionesDasNanoBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los TransaccionesDasNano 
        /// </summary>
        /// <returns>IQueryable con todos los TransaccionesDasNano</returns>
		public IQueryable<TransaccionesDasNano> GetTransaccionesDasNano()
		{
			return _efRepository.All<TransaccionesDasNano>();
		}

        
        /// <summary>
        /// Obtener un TransaccionesDasNano por su clave primaria
        /// </summary>
		/// <param name="idTransaccionDasNano">IdTransaccionDasNano</param>
        /// <returns>TransaccionesDasNano   seleccionado por su clave primaria</returns>
		public async Task<TransaccionesDasNano> GetTransaccionesDasNanoByPrimaryKeyAsync(int idTransaccionDasNano)
		{
			return await _efRepository.FindAsync<TransaccionesDasNano>(x=>x.IdTransaccionDasNano == idTransaccionDasNano);
		}

        /// <summary>
        /// Obtener un TransaccionesDasNano por su clave primaria
        /// </summary>
		/// <param name="idTransaccionDasNano">IdTransaccionDasNano</param>
        /// <returns>TransaccionesDasNano  seleccionado por su clave primaria</returns>
		public TransaccionesDasNano GetTransaccionesDasNanoByPrimaryKey(int idTransaccionDasNano)
		{
			return _efRepository.Find<TransaccionesDasNano>(x=>x.IdTransaccionDasNano == idTransaccionDasNano);
		}

        /// <summary>
        /// Obtener un TransaccionesDasNano por su clave unica GuidDasNano
        /// </summary>
		/// <param name="guidDasNano">GuidDasNano</param>
        /// <returns>TransaccionesDasNano   seleccionado por su clave única</returns>
		public async Task<TransaccionesDasNano> GetTransaccionesDasNanoByGuidDasNanoAsync(string guidDasNano)
		{
			return await _efRepository.FindAsync<TransaccionesDasNano>(x=> x.GuidDasNano == guidDasNano);
		}

        /// <summary>
        /// Obtener un TransaccionesDasNano por su clave unica GuidDasNano
        /// </summary>
		/// <param name="guidDasNano">GuidDasNano</param>
        /// <returns>TransaccionesDasNano   seleccionado por su clave única</returns>
		public TransaccionesDasNano GetTransaccionesDasNanoByGuidDasNano(string guidDasNano)
		{
			return _efRepository.Find<TransaccionesDasNano>(x=> x.GuidDasNano == guidDasNano);
		}



        /// <summary>
        /// Obtener un TransaccionesDasNano por operación
        /// </summary>
		/// <param name="idOperacion">IdOperacion</param>
        /// <returns>TransaccionesDasNano  seleccionado por su clave primaria</returns>
		public IQueryable<TransaccionesDasNano> GetTransaccionesDasNanoByIdOperacion(int idOperacion)
        {
            return _efRepository.All<TransaccionesDasNano>().Where(x => x.IdOperacion == idOperacion);
        }



        /// <summary>
        /// Crea una instancia de TransaccionesDasNano en la base de datos
        /// </summary>
        /// <param name="source">TransaccionesDasNano a crear</param>
        /// <returns>TransaccionesDasNano creado</returns>
        public virtual async Task<TransaccionesDasNano> CreateTransaccionesDasNanoAsync(TransaccionesDasNano source)
		{
			return await _efRepository.CreateAsync<TransaccionesDasNano>(source);
		}

		/// <summary>
        /// Crea una instancia de TransaccionesDasNano en la base de datos
        /// </summary>
        /// <param name="source">TransaccionesDasNano a crear</param>
        /// <returns>TransaccionesDasNano creado</returns>
		public virtual TransaccionesDasNano CreateTransaccionesDasNano(TransaccionesDasNano source)
		{
			return _efRepository.Create<TransaccionesDasNano>(source);
		}


		/// <summary>
        /// Modifica una instancia de TransaccionesDasNano en la base de datos
        /// </summary>
        /// <param name="source">TransaccionesDasNano a modificar</param>
        /// <returns>Número de TransaccionesDasNano modificados</returns>
		public async Task<int> UpdateTransaccionesDasNanoAsync(TransaccionesDasNano source)
		{
			return await _efRepository.UpdateAsync<TransaccionesDasNano>(source);
		}

		/// <summary>
        /// Modifica una instancia de TransaccionesDasNano en la base de datos
        /// </summary>
        /// <param name="source">TransaccionesDasNano a modificar</param>
        /// <returns>Número de TransaccionesDasNano modificados</returns>
		public int UpdateTransaccionesDasNano(TransaccionesDasNano source)
		{
			return _efRepository.Update<TransaccionesDasNano>(source);
		}

		/// <summary>
        /// Borra una instancia de TransaccionesDasNano en la base de datos
        /// </summary>
        /// <param name="source">TransaccionesDasNano a borrar</param>
        /// <returns>Número de TransaccionesDasNano borrados</returns>
		public async Task<int> DeleteTransaccionesDasNanoAsync(TransaccionesDasNano source)
		{
			return await _efRepository.DeleteAsync<TransaccionesDasNano>(source);
		}

		/// <summary>
        /// Borra una instancia de TransaccionesDasNano en la base de datos
        /// </summary>
        /// <param name="source">TransaccionesDasNano a borrar</param>
        /// <returns>Número de TransaccionesDasNano borrados</returns>
		public int DeleteTransaccionesDasNano(TransaccionesDasNano source)
		{
			return _efRepository.Delete<TransaccionesDasNano>(source);
		}
    }
}
