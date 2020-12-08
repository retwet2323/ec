using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioInfoOrigenesBase : IRepositorioInfoOrigenesBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase InfoOrigenes 
        /// </summary>
		public RepositorioInfoOrigenesBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los InfoOrigenes 
        /// </summary>
        /// <returns>IQueryable con todos los InfoOrigenes</returns>
		public IQueryable<InfoOrigenes> GetInfoOrigenes()
		{
			return _efRepository.All<InfoOrigenes>();
		}

        
        /// <summary>
        /// Obtener un InfoOrigenes por su clave primaria
        /// </summary>
		/// <param name="idInfoOrigen">IdInfoOrigen</param>
        /// <returns>InfoOrigenes   seleccionado por su clave primaria</returns>
		public async Task<InfoOrigenes> GetInfoOrigenesByPrimaryKeyAsync(int idInfoOrigen)
		{
			return await _efRepository.FindAsync<InfoOrigenes>(x=>x.IdInfoOrigen == idInfoOrigen);
		}

        /// <summary>
        /// Obtener un InfoOrigenes por su clave primaria
        /// </summary>
		/// <param name="idInfoOrigen">IdInfoOrigen</param>
        /// <returns>InfoOrigenes  seleccionado por su clave primaria</returns>
		public InfoOrigenes GetInfoOrigenesByPrimaryKey(int idInfoOrigen)
		{
			return _efRepository.Find<InfoOrigenes>(x=>x.IdInfoOrigen == idInfoOrigen);
		}




		/// <summary>
        /// Crea una instancia de InfoOrigenes en la base de datos
        /// </summary>
        /// <param name="source">InfoOrigenes a crear</param>
        /// <returns>InfoOrigenes creado</returns>
		public virtual async Task<InfoOrigenes> CreateInfoOrigenesAsync(InfoOrigenes source)
		{
			return await _efRepository.CreateAsync<InfoOrigenes>(source);
		}

		/// <summary>
        /// Crea una instancia de InfoOrigenes en la base de datos
        /// </summary>
        /// <param name="source">InfoOrigenes a crear</param>
        /// <returns>InfoOrigenes creado</returns>
		public virtual InfoOrigenes CreateInfoOrigenes(InfoOrigenes source)
		{
			return _efRepository.Create<InfoOrigenes>(source);
		}


		/// <summary>
        /// Modifica una instancia de InfoOrigenes en la base de datos
        /// </summary>
        /// <param name="source">InfoOrigenes a modificar</param>
        /// <returns>Número de InfoOrigenes modificados</returns>
		public async Task<int> UpdateInfoOrigenesAsync(InfoOrigenes source)
		{
			return await _efRepository.UpdateAsync<InfoOrigenes>(source);
		}

		/// <summary>
        /// Modifica una instancia de InfoOrigenes en la base de datos
        /// </summary>
        /// <param name="source">InfoOrigenes a modificar</param>
        /// <returns>Número de InfoOrigenes modificados</returns>
		public int UpdateInfoOrigenes(InfoOrigenes source)
		{
			return _efRepository.Update<InfoOrigenes>(source);
		}

		/// <summary>
        /// Borra una instancia de InfoOrigenes en la base de datos
        /// </summary>
        /// <param name="source">InfoOrigenes a borrar</param>
        /// <returns>Número de InfoOrigenes borrados</returns>
		public async Task<int> DeleteInfoOrigenesAsync(InfoOrigenes source)
		{
			return await _efRepository.DeleteAsync<InfoOrigenes>(source);
		}

		/// <summary>
        /// Borra una instancia de InfoOrigenes en la base de datos
        /// </summary>
        /// <param name="source">InfoOrigenes a borrar</param>
        /// <returns>Número de InfoOrigenes borrados</returns>
		public int DeleteInfoOrigenes(InfoOrigenes source)
		{
			return _efRepository.Delete<InfoOrigenes>(source);
		}
    }
}
