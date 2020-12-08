using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioNumerosMagicosBase : IRepositorioNumerosMagicosBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase NumerosMagicos 
        /// </summary>
		public RepositorioNumerosMagicosBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los NumerosMagicos 
        /// </summary>
        /// <returns>IQueryable con todos los NumerosMagicos</returns>
		public IQueryable<NumerosMagicos> GetNumerosMagicos()
		{
			return _efRepository.All<NumerosMagicos>();
		}

        
        /// <summary>
        /// Obtener un NumerosMagicos por su clave primaria
        /// </summary>
		/// <param name="idNumeroMagico">IdNumeroMagico</param>
        /// <returns>NumerosMagicos   seleccionado por su clave primaria</returns>
		public async Task<NumerosMagicos> GetNumerosMagicosByPrimaryKeyAsync(int idNumeroMagico)
		{
			return await _efRepository.FindAsync<NumerosMagicos>(x=>x.IdNumeroMagico == idNumeroMagico);
		}

        /// <summary>
        /// Obtener un NumerosMagicos por su clave primaria
        /// </summary>
		/// <param name="idNumeroMagico">IdNumeroMagico</param>
        /// <returns>NumerosMagicos  seleccionado por su clave primaria</returns>
		public NumerosMagicos GetNumerosMagicosByPrimaryKey(int idNumeroMagico)
		{
			return _efRepository.Find<NumerosMagicos>(x=>x.IdNumeroMagico == idNumeroMagico);
		}


        /// <summary>
        /// Obtener un IQueryable<NumerosMagicos> por su IdTipoArchivo 
        /// </summary>
		/// <param name="idTipoArchivo">IdTipoArchivo</param>
        /// <returns>IQueryable con los NumerosMagicos seleccionado por su IdTipoArchivo </returns>
		public IQueryable<NumerosMagicos> GetNumerosMagicosByIdTipoArchivo(int idTipoArchivo)
		{
			return _efRepository.Filter<NumerosMagicos>(x=> x.IdTipoArchivo == idTipoArchivo);
		}


		/// <summary>
        /// Crea una instancia de NumerosMagicos en la base de datos
        /// </summary>
        /// <param name="source">NumerosMagicos a crear</param>
        /// <returns>NumerosMagicos creado</returns>
		public virtual async Task<NumerosMagicos> CreateNumerosMagicosAsync(NumerosMagicos source)
		{
			return await _efRepository.CreateAsync<NumerosMagicos>(source);
		}

		/// <summary>
        /// Crea una instancia de NumerosMagicos en la base de datos
        /// </summary>
        /// <param name="source">NumerosMagicos a crear</param>
        /// <returns>NumerosMagicos creado</returns>
		public virtual NumerosMagicos CreateNumerosMagicos(NumerosMagicos source)
		{
			return _efRepository.Create<NumerosMagicos>(source);
		}


		/// <summary>
        /// Modifica una instancia de NumerosMagicos en la base de datos
        /// </summary>
        /// <param name="source">NumerosMagicos a modificar</param>
        /// <returns>Número de NumerosMagicos modificados</returns>
		public async Task<int> UpdateNumerosMagicosAsync(NumerosMagicos source)
		{
			return await _efRepository.UpdateAsync<NumerosMagicos>(source);
		}

		/// <summary>
        /// Modifica una instancia de NumerosMagicos en la base de datos
        /// </summary>
        /// <param name="source">NumerosMagicos a modificar</param>
        /// <returns>Número de NumerosMagicos modificados</returns>
		public int UpdateNumerosMagicos(NumerosMagicos source)
		{
			return _efRepository.Update<NumerosMagicos>(source);
		}

		/// <summary>
        /// Borra una instancia de NumerosMagicos en la base de datos
        /// </summary>
        /// <param name="source">NumerosMagicos a borrar</param>
        /// <returns>Número de NumerosMagicos borrados</returns>
		public async Task<int> DeleteNumerosMagicosAsync(NumerosMagicos source)
		{
			return await _efRepository.DeleteAsync<NumerosMagicos>(source);
		}

		/// <summary>
        /// Borra una instancia de NumerosMagicos en la base de datos
        /// </summary>
        /// <param name="source">NumerosMagicos a borrar</param>
        /// <returns>Número de NumerosMagicos borrados</returns>
		public int DeleteNumerosMagicos(NumerosMagicos source)
		{
			return _efRepository.Delete<NumerosMagicos>(source);
		}
    }
}
