using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioTransaccionesLogaltyBase : IRepositorioTransaccionesLogaltyBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase TransaccionesLogalty 
        /// </summary>
		public RepositorioTransaccionesLogaltyBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los TransaccionesLogalty 
        /// </summary>
        /// <returns>IQueryable con todos los TransaccionesLogalty</returns>
		public IQueryable<TransaccionesLogalty> GetTransaccionesLogalty()
		{
			return _efRepository.All<TransaccionesLogalty>();
		}

        
        /// <summary>
        /// Obtener un TransaccionesLogalty por su clave primaria
        /// </summary>
		/// <param name="idTransaccionLogalty">IdTransaccionLogalty</param>
        /// <returns>TransaccionesLogalty   seleccionado por su clave primaria</returns>
		public async Task<TransaccionesLogalty> GetTransaccionesLogaltyByPrimaryKeyAsync(int idTransaccionLogalty)
		{
			return await _efRepository.FindAsync<TransaccionesLogalty>(x=>x.IdTransaccionLogalty == idTransaccionLogalty);
		}

        /// <summary>
        /// Obtener un TransaccionesLogalty por su clave primaria
        /// </summary>
		/// <param name="idTransaccionLogalty">IdTransaccionLogalty</param>
        /// <returns>TransaccionesLogalty  seleccionado por su clave primaria</returns>
		public TransaccionesLogalty GetTransaccionesLogaltyByPrimaryKey(int idTransaccionLogalty)
		{
			return _efRepository.Find<TransaccionesLogalty>(x=>x.IdTransaccionLogalty == idTransaccionLogalty);
		}

        /// <summary>
        /// Obtener un TransaccionesLogalty por su clave unica GuidTransaccion
        /// </summary>
		/// <param name="guidTransaccion">GuidTransaccion</param>
        /// <returns>TransaccionesLogalty   seleccionado por su clave única</returns>
		public async Task<TransaccionesLogalty> GetTransaccionesLogaltyByGuidTransaccionAsync(string guidTransaccion)
		{
			return await _efRepository.FindAsync<TransaccionesLogalty>(x=> x.GuidTransaccion == guidTransaccion);
		}

        /// <summary>
        /// Obtener un TransaccionesLogalty por su clave unica GuidTransaccion
        /// </summary>
		/// <param name="guidTransaccion">GuidTransaccion</param>
        /// <returns>TransaccionesLogalty   seleccionado por su clave única</returns>
		public TransaccionesLogalty GetTransaccionesLogaltyByGuidTransaccion(string guidTransaccion)
		{
			return _efRepository.Find<TransaccionesLogalty>(x=> x.GuidTransaccion == guidTransaccion);
		}

        /// <summary>
        /// Obtener un IQueryable<TransaccionesLogalty> por su IdOperacion 
        /// </summary>
		/// <param name="idOperacion">IdOperacion</param>
        /// <returns>IQueryable con los TransaccionesLogalty seleccionado por su IdOperacion </returns>
		public IQueryable<TransaccionesLogalty> GetTransaccionesLogaltyByIdOperacion(int? idOperacion)
		{
			return _efRepository.Filter<TransaccionesLogalty>(x=> x.IdOperacion == idOperacion);
		}


		/// <summary>
        /// Crea una instancia de TransaccionesLogalty en la base de datos
        /// </summary>
        /// <param name="source">TransaccionesLogalty a crear</param>
        /// <returns>TransaccionesLogalty creado</returns>
		public virtual async Task<TransaccionesLogalty> CreateTransaccionesLogaltyAsync(TransaccionesLogalty source)
		{
			return await _efRepository.CreateAsync<TransaccionesLogalty>(source);
		}

		/// <summary>
        /// Crea una instancia de TransaccionesLogalty en la base de datos
        /// </summary>
        /// <param name="source">TransaccionesLogalty a crear</param>
        /// <returns>TransaccionesLogalty creado</returns>
		public virtual TransaccionesLogalty CreateTransaccionesLogalty(TransaccionesLogalty source)
		{
			return _efRepository.Create<TransaccionesLogalty>(source);
		}


		/// <summary>
        /// Modifica una instancia de TransaccionesLogalty en la base de datos
        /// </summary>
        /// <param name="source">TransaccionesLogalty a modificar</param>
        /// <returns>Número de TransaccionesLogalty modificados</returns>
		public async Task<int> UpdateTransaccionesLogaltyAsync(TransaccionesLogalty source)
		{
			return await _efRepository.UpdateAsync<TransaccionesLogalty>(source);
		}

		/// <summary>
        /// Modifica una instancia de TransaccionesLogalty en la base de datos
        /// </summary>
        /// <param name="source">TransaccionesLogalty a modificar</param>
        /// <returns>Número de TransaccionesLogalty modificados</returns>
		public int UpdateTransaccionesLogalty(TransaccionesLogalty source)
		{
			return _efRepository.Update<TransaccionesLogalty>(source);
		}

		/// <summary>
        /// Borra una instancia de TransaccionesLogalty en la base de datos
        /// </summary>
        /// <param name="source">TransaccionesLogalty a borrar</param>
        /// <returns>Número de TransaccionesLogalty borrados</returns>
		public async Task<int> DeleteTransaccionesLogaltyAsync(TransaccionesLogalty source)
		{
			return await _efRepository.DeleteAsync<TransaccionesLogalty>(source);
		}

		/// <summary>
        /// Borra una instancia de TransaccionesLogalty en la base de datos
        /// </summary>
        /// <param name="source">TransaccionesLogalty a borrar</param>
        /// <returns>Número de TransaccionesLogalty borrados</returns>
		public int DeleteTransaccionesLogalty(TransaccionesLogalty source)
		{
			return _efRepository.Delete<TransaccionesLogalty>(source);
		}
    }
}
