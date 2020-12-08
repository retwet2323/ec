using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioOperacionesBase : IRepositorioOperacionesBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase Operaciones 
        /// </summary>
		public RepositorioOperacionesBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los Operaciones 
        /// </summary>
        /// <returns>IQueryable con todos los Operaciones</returns>
		public IQueryable<Operaciones> GetOperaciones()
		{
			return _efRepository.All<Operaciones>();
		}

        
        /// <summary>
        /// Obtener un Operaciones por su clave primaria
        /// </summary>
		/// <param name="idOperacion">IdOperacion</param>
        /// <returns>Operaciones   seleccionado por su clave primaria</returns>
		public async Task<Operaciones> GetOperacionesByPrimaryKeyAsync(int idOperacion)
		{
			return await _efRepository.FindAsync<Operaciones>(x=>x.IdOperacion == idOperacion);
		}

        /// <summary>
        /// Obtener un Operaciones por su clave primaria
        /// </summary>
		/// <param name="idOperacion">IdOperacion</param>
        /// <returns>Operaciones  seleccionado por su clave primaria</returns>
		public Operaciones GetOperacionesByPrimaryKey(int idOperacion)
		{
			return _efRepository.Find<Operaciones>(x=>x.IdOperacion == idOperacion);
		}




		/// <summary>
        /// Crea una instancia de Operaciones en la base de datos
        /// </summary>
        /// <param name="source">Operaciones a crear</param>
        /// <returns>Operaciones creado</returns>
		public virtual async Task<Operaciones> CreateOperacionesAsync(Operaciones source)
		{
			return await _efRepository.CreateAsync<Operaciones>(source);
		}

		/// <summary>
        /// Crea una instancia de Operaciones en la base de datos
        /// </summary>
        /// <param name="source">Operaciones a crear</param>
        /// <returns>Operaciones creado</returns>
		public virtual Operaciones CreateOperaciones(Operaciones source)
		{
			return _efRepository.Create<Operaciones>(source);
		}


		/// <summary>
        /// Modifica una instancia de Operaciones en la base de datos
        /// </summary>
        /// <param name="source">Operaciones a modificar</param>
        /// <returns>Número de Operaciones modificados</returns>
		public async Task<int> UpdateOperacionesAsync(Operaciones source)
		{
			return await _efRepository.UpdateAsync<Operaciones>(source);
		}

		/// <summary>
        /// Modifica una instancia de Operaciones en la base de datos
        /// </summary>
        /// <param name="source">Operaciones a modificar</param>
        /// <returns>Número de Operaciones modificados</returns>
		public int UpdateOperaciones(Operaciones source)
		{
			return _efRepository.Update<Operaciones>(source);
		}

		/// <summary>
        /// Borra una instancia de Operaciones en la base de datos
        /// </summary>
        /// <param name="source">Operaciones a borrar</param>
        /// <returns>Número de Operaciones borrados</returns>
		public async Task<int> DeleteOperacionesAsync(Operaciones source)
		{
			return await _efRepository.DeleteAsync<Operaciones>(source);
		}

		/// <summary>
        /// Borra una instancia de Operaciones en la base de datos
        /// </summary>
        /// <param name="source">Operaciones a borrar</param>
        /// <returns>Número de Operaciones borrados</returns>
		public int DeleteOperaciones(Operaciones source)
		{
			return _efRepository.Delete<Operaciones>(source);
		}
    }
}
