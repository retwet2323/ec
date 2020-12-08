using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioContenedoresBase : IRepositorioContenedoresBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase Contenedores 
        /// </summary>
		public RepositorioContenedoresBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los Contenedores 
        /// </summary>
        /// <returns>IQueryable con todos los Contenedores</returns>
		public IQueryable<Contenedores> GetContenedores()
		{
			return _efRepository.All<Contenedores>();
		}

        
        /// <summary>
        /// Obtener un Contenedores por su clave primaria
        /// </summary>
		/// <param name="idContenedor">IdContenedor</param>
        /// <returns>Contenedores   seleccionado por su clave primaria</returns>
		public async Task<Contenedores> GetContenedoresByPrimaryKeyAsync(int idContenedor)
		{
			return await _efRepository.FindAsync<Contenedores>(x=>x.IdContenedor == idContenedor);
		}

        /// <summary>
        /// Obtener un Contenedores por su clave primaria
        /// </summary>
		/// <param name="idContenedor">IdContenedor</param>
        /// <returns>Contenedores  seleccionado por su clave primaria</returns>
		public Contenedores GetContenedoresByPrimaryKey(int idContenedor)
		{
			return _efRepository.Find<Contenedores>(x=>x.IdContenedor == idContenedor);
		}


        /// <summary>
        /// Obtener un IQueryable<Contenedores> por su IdContenedorSuperior 
        /// </summary>
		/// <param name="idContenedorSuperior">IdContenedorSuperior</param>
        /// <returns>IQueryable con los Contenedores seleccionado por su IdContenedorSuperior </returns>
		public IQueryable<Contenedores> GetContenedoresByIdContenedorSuperior(int? idContenedorSuperior)
		{
			return _efRepository.Filter<Contenedores>(x=> x.IdContenedorSuperior == idContenedorSuperior);
		}
        /// <summary>
        /// Obtener un IQueryable<Contenedores> por su IdFormulario 
        /// </summary>
		/// <param name="idFormulario">IdFormulario</param>
        /// <returns>IQueryable con los Contenedores seleccionado por su IdFormulario </returns>
		public IQueryable<Contenedores> GetContenedoresByIdFormulario(int? idFormulario)
		{
			return _efRepository.Filter<Contenedores>(x=> x.IdFormulario == idFormulario);
		}


		/// <summary>
        /// Crea una instancia de Contenedores en la base de datos
        /// </summary>
        /// <param name="source">Contenedores a crear</param>
        /// <returns>Contenedores creado</returns>
		public virtual async Task<Contenedores> CreateContenedoresAsync(Contenedores source)
		{
			return await _efRepository.CreateAsync<Contenedores>(source);
		}

		/// <summary>
        /// Crea una instancia de Contenedores en la base de datos
        /// </summary>
        /// <param name="source">Contenedores a crear</param>
        /// <returns>Contenedores creado</returns>
		public virtual Contenedores CreateContenedores(Contenedores source)
		{
			return _efRepository.Create<Contenedores>(source);
		}


		/// <summary>
        /// Modifica una instancia de Contenedores en la base de datos
        /// </summary>
        /// <param name="source">Contenedores a modificar</param>
        /// <returns>Número de Contenedores modificados</returns>
		public async Task<int> UpdateContenedoresAsync(Contenedores source)
		{
			return await _efRepository.UpdateAsync<Contenedores>(source);
		}

		/// <summary>
        /// Modifica una instancia de Contenedores en la base de datos
        /// </summary>
        /// <param name="source">Contenedores a modificar</param>
        /// <returns>Número de Contenedores modificados</returns>
		public int UpdateContenedores(Contenedores source)
		{
			return _efRepository.Update<Contenedores>(source);
		}

		/// <summary>
        /// Borra una instancia de Contenedores en la base de datos
        /// </summary>
        /// <param name="source">Contenedores a borrar</param>
        /// <returns>Número de Contenedores borrados</returns>
		public async Task<int> DeleteContenedoresAsync(Contenedores source)
		{
			return await _efRepository.DeleteAsync<Contenedores>(source);
		}

		/// <summary>
        /// Borra una instancia de Contenedores en la base de datos
        /// </summary>
        /// <param name="source">Contenedores a borrar</param>
        /// <returns>Número de Contenedores borrados</returns>
		public int DeleteContenedores(Contenedores source)
		{
			return _efRepository.Delete<Contenedores>(source);
		}
    }
}
