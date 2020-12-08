using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioElementosVersionablesBase : IRepositorioElementosVersionablesBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase ElementosVersionables 
        /// </summary>
		public RepositorioElementosVersionablesBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los ElementosVersionables 
        /// </summary>
        /// <returns>IQueryable con todos los ElementosVersionables</returns>
		public IQueryable<ElementosVersionables> GetElementosVersionables()
		{
			return _efRepository.All<ElementosVersionables>();
		}

        
        /// <summary>
        /// Obtener un ElementosVersionables por su clave primaria
        /// </summary>
		/// <param name="idElementoVersionable">IdElementoVersionable</param>
        /// <returns>ElementosVersionables   seleccionado por su clave primaria</returns>
		public async Task<ElementosVersionables> GetElementosVersionablesByPrimaryKeyAsync(int idElementoVersionable)
		{
			return await _efRepository.FindAsync<ElementosVersionables>(x=>x.IdElementoVersionable == idElementoVersionable);
		}

        /// <summary>
        /// Obtener un ElementosVersionables por su clave primaria
        /// </summary>
		/// <param name="idElementoVersionable">IdElementoVersionable</param>
        /// <returns>ElementosVersionables  seleccionado por su clave primaria</returns>
		public ElementosVersionables GetElementosVersionablesByPrimaryKey(int idElementoVersionable)
		{
			return _efRepository.Find<ElementosVersionables>(x=>x.IdElementoVersionable == idElementoVersionable);
		}




		/// <summary>
        /// Crea una instancia de ElementosVersionables en la base de datos
        /// </summary>
        /// <param name="source">ElementosVersionables a crear</param>
        /// <returns>ElementosVersionables creado</returns>
		public virtual async Task<ElementosVersionables> CreateElementosVersionablesAsync(ElementosVersionables source)
		{
			return await _efRepository.CreateAsync<ElementosVersionables>(source);
		}

		/// <summary>
        /// Crea una instancia de ElementosVersionables en la base de datos
        /// </summary>
        /// <param name="source">ElementosVersionables a crear</param>
        /// <returns>ElementosVersionables creado</returns>
		public virtual ElementosVersionables CreateElementosVersionables(ElementosVersionables source)
		{
			return _efRepository.Create<ElementosVersionables>(source);
		}


		/// <summary>
        /// Modifica una instancia de ElementosVersionables en la base de datos
        /// </summary>
        /// <param name="source">ElementosVersionables a modificar</param>
        /// <returns>Número de ElementosVersionables modificados</returns>
		public async Task<int> UpdateElementosVersionablesAsync(ElementosVersionables source)
		{
			return await _efRepository.UpdateAsync<ElementosVersionables>(source);
		}

		/// <summary>
        /// Modifica una instancia de ElementosVersionables en la base de datos
        /// </summary>
        /// <param name="source">ElementosVersionables a modificar</param>
        /// <returns>Número de ElementosVersionables modificados</returns>
		public int UpdateElementosVersionables(ElementosVersionables source)
		{
			return _efRepository.Update<ElementosVersionables>(source);
		}

		/// <summary>
        /// Borra una instancia de ElementosVersionables en la base de datos
        /// </summary>
        /// <param name="source">ElementosVersionables a borrar</param>
        /// <returns>Número de ElementosVersionables borrados</returns>
		public async Task<int> DeleteElementosVersionablesAsync(ElementosVersionables source)
		{
			return await _efRepository.DeleteAsync<ElementosVersionables>(source);
		}

		/// <summary>
        /// Borra una instancia de ElementosVersionables en la base de datos
        /// </summary>
        /// <param name="source">ElementosVersionables a borrar</param>
        /// <returns>Número de ElementosVersionables borrados</returns>
		public int DeleteElementosVersionables(ElementosVersionables source)
		{
			return _efRepository.Delete<ElementosVersionables>(source);
		}
    }
}
