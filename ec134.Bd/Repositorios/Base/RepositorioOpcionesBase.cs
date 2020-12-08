using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioOpcionesBase : IRepositorioOpcionesBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase Opciones 
        /// </summary>
		public RepositorioOpcionesBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los Opciones 
        /// </summary>
        /// <returns>IQueryable con todos los Opciones</returns>
		public IQueryable<Opciones> GetOpciones()
		{
			return _efRepository.All<Opciones>();
		}

        
        /// <summary>
        /// Obtener un Opciones por su clave primaria
        /// </summary>
		/// <param name="idOpcion">IdOpcion</param>
        /// <returns>Opciones   seleccionado por su clave primaria</returns>
		public async Task<Opciones> GetOpcionesByPrimaryKeyAsync(int idOpcion)
		{
			return await _efRepository.FindAsync<Opciones>(x=>x.IdOpcion == idOpcion);
		}

        /// <summary>
        /// Obtener un Opciones por su clave primaria
        /// </summary>
		/// <param name="idOpcion">IdOpcion</param>
        /// <returns>Opciones  seleccionado por su clave primaria</returns>
		public Opciones GetOpcionesByPrimaryKey(int idOpcion)
		{
			return _efRepository.Find<Opciones>(x=>x.IdOpcion == idOpcion);
		}


        /// <summary>
        /// Obtener un IQueryable<Opciones> por su IdGrupoOpciones 
        /// </summary>
		/// <param name="idGrupoOpciones">IdGrupoOpciones</param>
        /// <returns>IQueryable con los Opciones seleccionado por su IdGrupoOpciones </returns>
		public IQueryable<Opciones> GetOpcionesByIdGrupoOpciones(int idGrupoOpciones)
		{
			return _efRepository.Filter<Opciones>(x=> x.IdGrupoOpciones == idGrupoOpciones);
		}


		/// <summary>
        /// Crea una instancia de Opciones en la base de datos
        /// </summary>
        /// <param name="source">Opciones a crear</param>
        /// <returns>Opciones creado</returns>
		public virtual async Task<Opciones> CreateOpcionesAsync(Opciones source)
		{
			return await _efRepository.CreateAsync<Opciones>(source);
		}

		/// <summary>
        /// Crea una instancia de Opciones en la base de datos
        /// </summary>
        /// <param name="source">Opciones a crear</param>
        /// <returns>Opciones creado</returns>
		public virtual Opciones CreateOpciones(Opciones source)
		{
			return _efRepository.Create<Opciones>(source);
		}


		/// <summary>
        /// Modifica una instancia de Opciones en la base de datos
        /// </summary>
        /// <param name="source">Opciones a modificar</param>
        /// <returns>Número de Opciones modificados</returns>
		public async Task<int> UpdateOpcionesAsync(Opciones source)
		{
			return await _efRepository.UpdateAsync<Opciones>(source);
		}

		/// <summary>
        /// Modifica una instancia de Opciones en la base de datos
        /// </summary>
        /// <param name="source">Opciones a modificar</param>
        /// <returns>Número de Opciones modificados</returns>
		public int UpdateOpciones(Opciones source)
		{
			return _efRepository.Update<Opciones>(source);
		}

		/// <summary>
        /// Borra una instancia de Opciones en la base de datos
        /// </summary>
        /// <param name="source">Opciones a borrar</param>
        /// <returns>Número de Opciones borrados</returns>
		public async Task<int> DeleteOpcionesAsync(Opciones source)
		{
			return await _efRepository.DeleteAsync<Opciones>(source);
		}

		/// <summary>
        /// Borra una instancia de Opciones en la base de datos
        /// </summary>
        /// <param name="source">Opciones a borrar</param>
        /// <returns>Número de Opciones borrados</returns>
		public int DeleteOpciones(Opciones source)
		{
			return _efRepository.Delete<Opciones>(source);
		}
    }
}
