using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioPasosBase : IRepositorioPasosBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase Pasos 
        /// </summary>
		public RepositorioPasosBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los Pasos 
        /// </summary>
        /// <returns>IQueryable con todos los Pasos</returns>
		public IQueryable<Pasos> GetPasos()
		{
			return _efRepository.All<Pasos>();
		}

        
        /// <summary>
        /// Obtener un Pasos por su clave primaria
        /// </summary>
		/// <param name="idPaso">IdPaso</param>
        /// <returns>Pasos   seleccionado por su clave primaria</returns>
		public async Task<Pasos> GetPasosByPrimaryKeyAsync(int idPaso)
		{
			return await _efRepository.FindAsync<Pasos>(x=>x.IdPaso == idPaso);
		}

        /// <summary>
        /// Obtener un Pasos por su clave primaria
        /// </summary>
		/// <param name="idPaso">IdPaso</param>
        /// <returns>Pasos  seleccionado por su clave primaria</returns>
		public Pasos GetPasosByPrimaryKey(int idPaso)
		{
			return _efRepository.Find<Pasos>(x=>x.IdPaso == idPaso);
		}


        /// <summary>
        /// Obtener un IQueryable<Pasos> por su IdProducto 
        /// </summary>
		/// <param name="idProducto">IdProducto</param>
        /// <returns>IQueryable con los Pasos seleccionado por su IdProducto </returns>
		public IQueryable<Pasos> GetPasosByIdProducto(int? idProducto)
		{
			return _efRepository.Filter<Pasos>(x=> x.IdProducto == idProducto);
		}


		/// <summary>
        /// Crea una instancia de Pasos en la base de datos
        /// </summary>
        /// <param name="source">Pasos a crear</param>
        /// <returns>Pasos creado</returns>
		public virtual async Task<Pasos> CreatePasosAsync(Pasos source)
		{
			return await _efRepository.CreateAsync<Pasos>(source);
		}

		/// <summary>
        /// Crea una instancia de Pasos en la base de datos
        /// </summary>
        /// <param name="source">Pasos a crear</param>
        /// <returns>Pasos creado</returns>
		public virtual Pasos CreatePasos(Pasos source)
		{
			return _efRepository.Create<Pasos>(source);
		}


		/// <summary>
        /// Modifica una instancia de Pasos en la base de datos
        /// </summary>
        /// <param name="source">Pasos a modificar</param>
        /// <returns>Número de Pasos modificados</returns>
		public async Task<int> UpdatePasosAsync(Pasos source)
		{
			return await _efRepository.UpdateAsync<Pasos>(source);
		}

		/// <summary>
        /// Modifica una instancia de Pasos en la base de datos
        /// </summary>
        /// <param name="source">Pasos a modificar</param>
        /// <returns>Número de Pasos modificados</returns>
		public int UpdatePasos(Pasos source)
		{
			return _efRepository.Update<Pasos>(source);
		}

		/// <summary>
        /// Borra una instancia de Pasos en la base de datos
        /// </summary>
        /// <param name="source">Pasos a borrar</param>
        /// <returns>Número de Pasos borrados</returns>
		public async Task<int> DeletePasosAsync(Pasos source)
		{
			return await _efRepository.DeleteAsync<Pasos>(source);
		}

		/// <summary>
        /// Borra una instancia de Pasos en la base de datos
        /// </summary>
        /// <param name="source">Pasos a borrar</param>
        /// <returns>Número de Pasos borrados</returns>
		public int DeletePasos(Pasos source)
		{
			return _efRepository.Delete<Pasos>(source);
		}
    }
}
