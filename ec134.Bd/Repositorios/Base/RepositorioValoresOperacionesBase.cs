using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioValoresOperacionesBase : IRepositorioValoresOperacionesBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase ValoresOperaciones 
        /// </summary>
		public RepositorioValoresOperacionesBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los ValoresOperaciones 
        /// </summary>
        /// <returns>IQueryable con todos los ValoresOperaciones</returns>
		public IQueryable<ValoresOperaciones> GetValoresOperaciones()
		{
			return _efRepository.All<ValoresOperaciones>();
		}

        
        /// <summary>
        /// Obtener un ValoresOperaciones por su clave primaria
        /// </summary>
		/// <param name="idValorOperacion">IdValorOperacion</param>
        /// <returns>ValoresOperaciones   seleccionado por su clave primaria</returns>
		public async Task<ValoresOperaciones> GetValoresOperacionesByPrimaryKeyAsync(int idValorOperacion)
		{
			return await _efRepository.FindAsync<ValoresOperaciones>(x=>x.IdValorOperacion == idValorOperacion);
		}

        /// <summary>
        /// Obtener un ValoresOperaciones por su clave primaria
        /// </summary>
		/// <param name="idValorOperacion">IdValorOperacion</param>
        /// <returns>ValoresOperaciones  seleccionado por su clave primaria</returns>
		public ValoresOperaciones GetValoresOperacionesByPrimaryKey(int idValorOperacion)
		{
			return _efRepository.Find<ValoresOperaciones>(x=>x.IdValorOperacion == idValorOperacion);
		}


        /// <summary>
        /// Obtener un IQueryable<ValoresOperaciones> por su IdOperacion 
        /// </summary>
		/// <param name="idOperacion">IdOperacion</param>
        /// <returns>IQueryable con los ValoresOperaciones seleccionado por su IdOperacion </returns>
		public IQueryable<ValoresOperaciones> GetValoresOperacionesByIdOperacion(int idOperacion)
		{
			return _efRepository.Filter<ValoresOperaciones>(x=> x.IdOperacion == idOperacion);
		}


		/// <summary>
        /// Crea una instancia de ValoresOperaciones en la base de datos
        /// </summary>
        /// <param name="source">ValoresOperaciones a crear</param>
        /// <returns>ValoresOperaciones creado</returns>
		public virtual async Task<ValoresOperaciones> CreateValoresOperacionesAsync(ValoresOperaciones source)
		{
			return await _efRepository.CreateAsync<ValoresOperaciones>(source);
		}

		/// <summary>
        /// Crea una instancia de ValoresOperaciones en la base de datos
        /// </summary>
        /// <param name="source">ValoresOperaciones a crear</param>
        /// <returns>ValoresOperaciones creado</returns>
		public virtual ValoresOperaciones CreateValoresOperaciones(ValoresOperaciones source)
		{
			return _efRepository.Create<ValoresOperaciones>(source);
		}


		/// <summary>
        /// Modifica una instancia de ValoresOperaciones en la base de datos
        /// </summary>
        /// <param name="source">ValoresOperaciones a modificar</param>
        /// <returns>Número de ValoresOperaciones modificados</returns>
		public async Task<int> UpdateValoresOperacionesAsync(ValoresOperaciones source)
		{
			return await _efRepository.UpdateAsync<ValoresOperaciones>(source);
		}

		/// <summary>
        /// Modifica una instancia de ValoresOperaciones en la base de datos
        /// </summary>
        /// <param name="source">ValoresOperaciones a modificar</param>
        /// <returns>Número de ValoresOperaciones modificados</returns>
		public int UpdateValoresOperaciones(ValoresOperaciones source)
		{
			return _efRepository.Update<ValoresOperaciones>(source);
		}

		/// <summary>
        /// Borra una instancia de ValoresOperaciones en la base de datos
        /// </summary>
        /// <param name="source">ValoresOperaciones a borrar</param>
        /// <returns>Número de ValoresOperaciones borrados</returns>
		public async Task<int> DeleteValoresOperacionesAsync(ValoresOperaciones source)
		{
			return await _efRepository.DeleteAsync<ValoresOperaciones>(source);
		}

		/// <summary>
        /// Borra una instancia de ValoresOperaciones en la base de datos
        /// </summary>
        /// <param name="source">ValoresOperaciones a borrar</param>
        /// <returns>Número de ValoresOperaciones borrados</returns>
		public int DeleteValoresOperaciones(ValoresOperaciones source)
		{
			return _efRepository.Delete<ValoresOperaciones>(source);
		}
    }
}
