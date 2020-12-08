using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioFormulariosBase : IRepositorioFormulariosBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase Formularios 
        /// </summary>
		public RepositorioFormulariosBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los Formularios 
        /// </summary>
        /// <returns>IQueryable con todos los Formularios</returns>
		public IQueryable<Formularios> GetFormularios()
		{
			return _efRepository.All<Formularios>();
		}

        
        /// <summary>
        /// Obtener un Formularios por su clave primaria
        /// </summary>
		/// <param name="idFormulario">IdFormulario</param>
        /// <returns>Formularios   seleccionado por su clave primaria</returns>
		public async Task<Formularios> GetFormulariosByPrimaryKeyAsync(int idFormulario)
		{
			return await _efRepository.FindAsync<Formularios>(x=>x.IdFormulario == idFormulario);
		}

        /// <summary>
        /// Obtener un Formularios por su clave primaria
        /// </summary>
		/// <param name="idFormulario">IdFormulario</param>
        /// <returns>Formularios  seleccionado por su clave primaria</returns>
		public Formularios GetFormulariosByPrimaryKey(int idFormulario)
		{
			return _efRepository.Find<Formularios>(x=>x.IdFormulario == idFormulario);
		}




		/// <summary>
        /// Crea una instancia de Formularios en la base de datos
        /// </summary>
        /// <param name="source">Formularios a crear</param>
        /// <returns>Formularios creado</returns>
		public virtual async Task<Formularios> CreateFormulariosAsync(Formularios source)
		{
			return await _efRepository.CreateAsync<Formularios>(source);
		}

		/// <summary>
        /// Crea una instancia de Formularios en la base de datos
        /// </summary>
        /// <param name="source">Formularios a crear</param>
        /// <returns>Formularios creado</returns>
		public virtual Formularios CreateFormularios(Formularios source)
		{
			return _efRepository.Create<Formularios>(source);
		}


		/// <summary>
        /// Modifica una instancia de Formularios en la base de datos
        /// </summary>
        /// <param name="source">Formularios a modificar</param>
        /// <returns>Número de Formularios modificados</returns>
		public async Task<int> UpdateFormulariosAsync(Formularios source)
		{
			return await _efRepository.UpdateAsync<Formularios>(source);
		}

		/// <summary>
        /// Modifica una instancia de Formularios en la base de datos
        /// </summary>
        /// <param name="source">Formularios a modificar</param>
        /// <returns>Número de Formularios modificados</returns>
		public int UpdateFormularios(Formularios source)
		{
			return _efRepository.Update<Formularios>(source);
		}

		/// <summary>
        /// Borra una instancia de Formularios en la base de datos
        /// </summary>
        /// <param name="source">Formularios a borrar</param>
        /// <returns>Número de Formularios borrados</returns>
		public async Task<int> DeleteFormulariosAsync(Formularios source)
		{
			return await _efRepository.DeleteAsync<Formularios>(source);
		}

		/// <summary>
        /// Borra una instancia de Formularios en la base de datos
        /// </summary>
        /// <param name="source">Formularios a borrar</param>
        /// <returns>Número de Formularios borrados</returns>
		public int DeleteFormularios(Formularios source)
		{
			return _efRepository.Delete<Formularios>(source);
		}
    }
}
