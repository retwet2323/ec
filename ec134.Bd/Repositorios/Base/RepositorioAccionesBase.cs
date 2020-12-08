
using System;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;
using Graddo.Common.Db;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioAccionesBase : IRepositorioAccionesBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase Acciones 
        /// </summary>
		public RepositorioAccionesBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los Acciones 
        /// </summary>
        /// <returns>IQueryable con todos los Acciones</returns>
		public IQueryable<Acciones> GetAcciones()
		{
			return _efRepository.All<Acciones>();
		}

        
        /// <summary>
        /// Obtener un Acciones por su clave primaria
        /// </summary>
		/// <param name="idAccion">IdAccion</param>
        /// <returns>Acciones   seleccionado por su clave primaria</returns>
		public async Task<Acciones> GetAccionesByPrimaryKeyAsync(int idAccion)
		{
			return await _efRepository.FindAsync<Acciones>(x=>x.IdAccion == idAccion);
		}

        /// <summary>
        /// Obtener un Acciones por su clave primaria
        /// </summary>
		/// <param name="idAccion">IdAccion</param>
        /// <returns>Acciones  seleccionado por su clave primaria</returns>
		public Acciones GetAccionesByPrimaryKey(int idAccion)
		{
			return _efRepository.Find<Acciones>(x=>x.IdAccion == idAccion);
		}




		/// <summary>
        /// Crea una instancia de Acciones en la base de datos
        /// </summary>
        /// <param name="source">Acciones a crear</param>
        /// <returns>Acciones creado</returns>
		public virtual async Task<Acciones> CreateAccionesAsync(Acciones source)
		{
			return await _efRepository.CreateAsync<Acciones>(source);
		}

		/// <summary>
        /// Crea una instancia de Acciones en la base de datos
        /// </summary>
        /// <param name="source">Acciones a crear</param>
        /// <returns>Acciones creado</returns>
		public virtual Acciones CreateAcciones(Acciones source)
		{
			return _efRepository.Create<Acciones>(source);
		}


		/// <summary>
        /// Modifica una instancia de Acciones en la base de datos
        /// </summary>
        /// <param name="source">Acciones a modificar</param>
        /// <returns>Número de Acciones modificados</returns>
		public async Task<int> UpdateAccionesAsync(Acciones source)
		{
			return await _efRepository.UpdateAsync<Acciones>(source);
		}

		/// <summary>
        /// Modifica una instancia de Acciones en la base de datos
        /// </summary>
        /// <param name="source">Acciones a modificar</param>
        /// <returns>Número de Acciones modificados</returns>
		public int UpdateAcciones(Acciones source)
		{
			return _efRepository.Update<Acciones>(source);
		}

		/// <summary>
        /// Borra una instancia de Acciones en la base de datos
        /// </summary>
        /// <param name="source">Acciones a borrar</param>
        /// <returns>Número de Acciones borrados</returns>
		public async Task<int> DeleteAccionesAsync(Acciones source)
		{
			return await _efRepository.DeleteAsync<Acciones>(source);
		}

		/// <summary>
        /// Borra una instancia de Acciones en la base de datos
        /// </summary>
        /// <param name="source">Acciones a borrar</param>
        /// <returns>Número de Acciones borrados</returns>
		public int DeleteAcciones(Acciones source)
		{
			return _efRepository.Delete<Acciones>(source);
		}
    }
}
