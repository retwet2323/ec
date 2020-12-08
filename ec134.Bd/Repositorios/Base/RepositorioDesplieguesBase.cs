using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioDesplieguesBase : IRepositorioDesplieguesBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase Despliegues 
        /// </summary>
		public RepositorioDesplieguesBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los Despliegues 
        /// </summary>
        /// <returns>IQueryable con todos los Despliegues</returns>
		public IQueryable<Despliegues> GetDespliegues()
		{
			return _efRepository.All<Despliegues>();
		}

        
        /// <summary>
        /// Obtener un Despliegues por su clave primaria
        /// </summary>
		/// <param name="idDespliegue">IdDespliegue</param>
        /// <returns>Despliegues   seleccionado por su clave primaria</returns>
		public async Task<Despliegues> GetDesplieguesByPrimaryKeyAsync(int idDespliegue)
		{
			return await _efRepository.FindAsync<Despliegues>(x=>x.IdDespliegue == idDespliegue);
		}

        /// <summary>
        /// Obtener un Despliegues por su clave primaria
        /// </summary>
		/// <param name="idDespliegue">IdDespliegue</param>
        /// <returns>Despliegues  seleccionado por su clave primaria</returns>
		public Despliegues GetDesplieguesByPrimaryKey(int idDespliegue)
		{
			return _efRepository.Find<Despliegues>(x=>x.IdDespliegue == idDespliegue);
		}




		/// <summary>
        /// Crea una instancia de Despliegues en la base de datos
        /// </summary>
        /// <param name="source">Despliegues a crear</param>
        /// <returns>Despliegues creado</returns>
		public virtual async Task<Despliegues> CreateDesplieguesAsync(Despliegues source)
		{
			return await _efRepository.CreateAsync<Despliegues>(source);
		}

		/// <summary>
        /// Crea una instancia de Despliegues en la base de datos
        /// </summary>
        /// <param name="source">Despliegues a crear</param>
        /// <returns>Despliegues creado</returns>
		public virtual Despliegues CreateDespliegues(Despliegues source)
		{
			return _efRepository.Create<Despliegues>(source);
		}


		/// <summary>
        /// Modifica una instancia de Despliegues en la base de datos
        /// </summary>
        /// <param name="source">Despliegues a modificar</param>
        /// <returns>Número de Despliegues modificados</returns>
		public async Task<int> UpdateDesplieguesAsync(Despliegues source)
		{
			return await _efRepository.UpdateAsync<Despliegues>(source);
		}

		/// <summary>
        /// Modifica una instancia de Despliegues en la base de datos
        /// </summary>
        /// <param name="source">Despliegues a modificar</param>
        /// <returns>Número de Despliegues modificados</returns>
		public int UpdateDespliegues(Despliegues source)
		{
			return _efRepository.Update<Despliegues>(source);
		}

		/// <summary>
        /// Borra una instancia de Despliegues en la base de datos
        /// </summary>
        /// <param name="source">Despliegues a borrar</param>
        /// <returns>Número de Despliegues borrados</returns>
		public async Task<int> DeleteDesplieguesAsync(Despliegues source)
		{
			return await _efRepository.DeleteAsync<Despliegues>(source);
		}

		/// <summary>
        /// Borra una instancia de Despliegues en la base de datos
        /// </summary>
        /// <param name="source">Despliegues a borrar</param>
        /// <returns>Número de Despliegues borrados</returns>
		public int DeleteDespliegues(Despliegues source)
		{
			return _efRepository.Delete<Despliegues>(source);
		}
    }
}
