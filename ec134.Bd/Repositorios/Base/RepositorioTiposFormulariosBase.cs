using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioTiposFormulariosBase : IRepositorioTiposFormulariosBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase TiposFormularios 
        /// </summary>
		public RepositorioTiposFormulariosBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los TiposFormularios 
        /// </summary>
        /// <returns>IQueryable con todos los TiposFormularios</returns>
		public IQueryable<TiposFormularios> GetTiposFormularios()
		{
			return _efRepository.All<TiposFormularios>();
		}

        
        /// <summary>
        /// Obtener un TiposFormularios por su clave primaria
        /// </summary>
		/// <param name="idTipoFormulario">IdTipoFormulario</param>
        /// <returns>TiposFormularios   seleccionado por su clave primaria</returns>
		public async Task<TiposFormularios> GetTiposFormulariosByPrimaryKeyAsync(int idTipoFormulario)
		{
			return await _efRepository.FindAsync<TiposFormularios>(x=>x.IdTipoFormulario == idTipoFormulario);
		}

        /// <summary>
        /// Obtener un TiposFormularios por su clave primaria
        /// </summary>
		/// <param name="idTipoFormulario">IdTipoFormulario</param>
        /// <returns>TiposFormularios  seleccionado por su clave primaria</returns>
		public TiposFormularios GetTiposFormulariosByPrimaryKey(int idTipoFormulario)
		{
			return _efRepository.Find<TiposFormularios>(x=>x.IdTipoFormulario == idTipoFormulario);
		}




		/// <summary>
        /// Crea una instancia de TiposFormularios en la base de datos
        /// </summary>
        /// <param name="source">TiposFormularios a crear</param>
        /// <returns>TiposFormularios creado</returns>
		public virtual async Task<TiposFormularios> CreateTiposFormulariosAsync(TiposFormularios source)
		{
			return await _efRepository.CreateAsync<TiposFormularios>(source);
		}

		/// <summary>
        /// Crea una instancia de TiposFormularios en la base de datos
        /// </summary>
        /// <param name="source">TiposFormularios a crear</param>
        /// <returns>TiposFormularios creado</returns>
		public virtual TiposFormularios CreateTiposFormularios(TiposFormularios source)
		{
			return _efRepository.Create<TiposFormularios>(source);
		}


		/// <summary>
        /// Modifica una instancia de TiposFormularios en la base de datos
        /// </summary>
        /// <param name="source">TiposFormularios a modificar</param>
        /// <returns>Número de TiposFormularios modificados</returns>
		public async Task<int> UpdateTiposFormulariosAsync(TiposFormularios source)
		{
			return await _efRepository.UpdateAsync<TiposFormularios>(source);
		}

		/// <summary>
        /// Modifica una instancia de TiposFormularios en la base de datos
        /// </summary>
        /// <param name="source">TiposFormularios a modificar</param>
        /// <returns>Número de TiposFormularios modificados</returns>
		public int UpdateTiposFormularios(TiposFormularios source)
		{
			return _efRepository.Update<TiposFormularios>(source);
		}

		/// <summary>
        /// Borra una instancia de TiposFormularios en la base de datos
        /// </summary>
        /// <param name="source">TiposFormularios a borrar</param>
        /// <returns>Número de TiposFormularios borrados</returns>
		public async Task<int> DeleteTiposFormulariosAsync(TiposFormularios source)
		{
			return await _efRepository.DeleteAsync<TiposFormularios>(source);
		}

		/// <summary>
        /// Borra una instancia de TiposFormularios en la base de datos
        /// </summary>
        /// <param name="source">TiposFormularios a borrar</param>
        /// <returns>Número de TiposFormularios borrados</returns>
		public int DeleteTiposFormularios(TiposFormularios source)
		{
			return _efRepository.Delete<TiposFormularios>(source);
		}
    }
}
