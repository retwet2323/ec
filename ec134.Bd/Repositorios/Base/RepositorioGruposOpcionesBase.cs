using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioGruposOpcionesBase : IRepositorioGruposOpcionesBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase GruposOpciones 
        /// </summary>
		public RepositorioGruposOpcionesBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los GruposOpciones 
        /// </summary>
        /// <returns>IQueryable con todos los GruposOpciones</returns>
		public IQueryable<GruposOpciones> GetGruposOpciones()
		{
			return _efRepository.All<GruposOpciones>();
		}

        
        /// <summary>
        /// Obtener un GruposOpciones por su clave primaria
        /// </summary>
		/// <param name="idGrupoOpciones">IdGrupoOpciones</param>
        /// <returns>GruposOpciones   seleccionado por su clave primaria</returns>
		public async Task<GruposOpciones> GetGruposOpcionesByPrimaryKeyAsync(int idGrupoOpciones)
		{
			return await _efRepository.FindAsync<GruposOpciones>(x=>x.IdGrupoOpciones == idGrupoOpciones);
		}

        /// <summary>
        /// Obtener un GruposOpciones por su clave primaria
        /// </summary>
		/// <param name="idGrupoOpciones">IdGrupoOpciones</param>
        /// <returns>GruposOpciones  seleccionado por su clave primaria</returns>
		public GruposOpciones GetGruposOpcionesByPrimaryKey(int idGrupoOpciones)
		{
			return _efRepository.Find<GruposOpciones>(x=>x.IdGrupoOpciones == idGrupoOpciones);
		}




		/// <summary>
        /// Crea una instancia de GruposOpciones en la base de datos
        /// </summary>
        /// <param name="source">GruposOpciones a crear</param>
        /// <returns>GruposOpciones creado</returns>
		public virtual async Task<GruposOpciones> CreateGruposOpcionesAsync(GruposOpciones source)
		{
			return await _efRepository.CreateAsync<GruposOpciones>(source);
		}

		/// <summary>
        /// Crea una instancia de GruposOpciones en la base de datos
        /// </summary>
        /// <param name="source">GruposOpciones a crear</param>
        /// <returns>GruposOpciones creado</returns>
		public virtual GruposOpciones CreateGruposOpciones(GruposOpciones source)
		{
			return _efRepository.Create<GruposOpciones>(source);
		}


		/// <summary>
        /// Modifica una instancia de GruposOpciones en la base de datos
        /// </summary>
        /// <param name="source">GruposOpciones a modificar</param>
        /// <returns>Número de GruposOpciones modificados</returns>
		public async Task<int> UpdateGruposOpcionesAsync(GruposOpciones source)
		{
			return await _efRepository.UpdateAsync<GruposOpciones>(source);
		}

		/// <summary>
        /// Modifica una instancia de GruposOpciones en la base de datos
        /// </summary>
        /// <param name="source">GruposOpciones a modificar</param>
        /// <returns>Número de GruposOpciones modificados</returns>
		public int UpdateGruposOpciones(GruposOpciones source)
		{
			return _efRepository.Update<GruposOpciones>(source);
		}

		/// <summary>
        /// Borra una instancia de GruposOpciones en la base de datos
        /// </summary>
        /// <param name="source">GruposOpciones a borrar</param>
        /// <returns>Número de GruposOpciones borrados</returns>
		public async Task<int> DeleteGruposOpcionesAsync(GruposOpciones source)
		{
			return await _efRepository.DeleteAsync<GruposOpciones>(source);
		}

		/// <summary>
        /// Borra una instancia de GruposOpciones en la base de datos
        /// </summary>
        /// <param name="source">GruposOpciones a borrar</param>
        /// <returns>Número de GruposOpciones borrados</returns>
		public int DeleteGruposOpciones(GruposOpciones source)
		{
			return _efRepository.Delete<GruposOpciones>(source);
		}
    }
}
