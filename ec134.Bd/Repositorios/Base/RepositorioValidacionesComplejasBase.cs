using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioValidacionesComplejasBase : IRepositorioValidacionesComplejasBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase ValidacionesComplejas 
        /// </summary>
		public RepositorioValidacionesComplejasBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los ValidacionesComplejas 
        /// </summary>
        /// <returns>IQueryable con todos los ValidacionesComplejas</returns>
		public IQueryable<ValidacionesComplejas> GetValidacionesComplejas()
		{
			return _efRepository.All<ValidacionesComplejas>();
		}

        
        /// <summary>
        /// Obtener un ValidacionesComplejas por su clave primaria
        /// </summary>
		/// <param name="idValidacionCompleja">IdValidacionCompleja</param>
        /// <returns>ValidacionesComplejas   seleccionado por su clave primaria</returns>
		public async Task<ValidacionesComplejas> GetValidacionesComplejasByPrimaryKeyAsync(int idValidacionCompleja)
		{
			return await _efRepository.FindAsync<ValidacionesComplejas>(x=>x.IdValidacionCompleja == idValidacionCompleja);
		}

        /// <summary>
        /// Obtener un ValidacionesComplejas por su clave primaria
        /// </summary>
		/// <param name="idValidacionCompleja">IdValidacionCompleja</param>
        /// <returns>ValidacionesComplejas  seleccionado por su clave primaria</returns>
		public ValidacionesComplejas GetValidacionesComplejasByPrimaryKey(int idValidacionCompleja)
		{
			return _efRepository.Find<ValidacionesComplejas>(x=>x.IdValidacionCompleja == idValidacionCompleja);
		}




		/// <summary>
        /// Crea una instancia de ValidacionesComplejas en la base de datos
        /// </summary>
        /// <param name="source">ValidacionesComplejas a crear</param>
        /// <returns>ValidacionesComplejas creado</returns>
		public virtual async Task<ValidacionesComplejas> CreateValidacionesComplejasAsync(ValidacionesComplejas source)
		{
			return await _efRepository.CreateAsync<ValidacionesComplejas>(source);
		}

		/// <summary>
        /// Crea una instancia de ValidacionesComplejas en la base de datos
        /// </summary>
        /// <param name="source">ValidacionesComplejas a crear</param>
        /// <returns>ValidacionesComplejas creado</returns>
		public virtual ValidacionesComplejas CreateValidacionesComplejas(ValidacionesComplejas source)
		{
			return _efRepository.Create<ValidacionesComplejas>(source);
		}


		/// <summary>
        /// Modifica una instancia de ValidacionesComplejas en la base de datos
        /// </summary>
        /// <param name="source">ValidacionesComplejas a modificar</param>
        /// <returns>Número de ValidacionesComplejas modificados</returns>
		public async Task<int> UpdateValidacionesComplejasAsync(ValidacionesComplejas source)
		{
			return await _efRepository.UpdateAsync<ValidacionesComplejas>(source);
		}

		/// <summary>
        /// Modifica una instancia de ValidacionesComplejas en la base de datos
        /// </summary>
        /// <param name="source">ValidacionesComplejas a modificar</param>
        /// <returns>Número de ValidacionesComplejas modificados</returns>
		public int UpdateValidacionesComplejas(ValidacionesComplejas source)
		{
			return _efRepository.Update<ValidacionesComplejas>(source);
		}

		/// <summary>
        /// Borra una instancia de ValidacionesComplejas en la base de datos
        /// </summary>
        /// <param name="source">ValidacionesComplejas a borrar</param>
        /// <returns>Número de ValidacionesComplejas borrados</returns>
		public async Task<int> DeleteValidacionesComplejasAsync(ValidacionesComplejas source)
		{
			return await _efRepository.DeleteAsync<ValidacionesComplejas>(source);
		}

		/// <summary>
        /// Borra una instancia de ValidacionesComplejas en la base de datos
        /// </summary>
        /// <param name="source">ValidacionesComplejas a borrar</param>
        /// <returns>Número de ValidacionesComplejas borrados</returns>
		public int DeleteValidacionesComplejas(ValidacionesComplejas source)
		{
			return _efRepository.Delete<ValidacionesComplejas>(source);
		}
    }
}
