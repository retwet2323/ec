using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioRegistrosOperacionesBase : IRepositorioRegistrosOperacionesBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase RegistrosOperaciones 
        /// </summary>
		public RepositorioRegistrosOperacionesBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los RegistrosOperaciones 
        /// </summary>
        /// <returns>IQueryable con todos los RegistrosOperaciones</returns>
		public IQueryable<RegistrosOperaciones> GetRegistrosOperaciones()
		{
			return _efRepository.All<RegistrosOperaciones>();
		}

        
        /// <summary>
        /// Obtener un RegistrosOperaciones por su clave primaria
        /// </summary>
		/// <param name="idRegistroOperacion">IdRegistroOperacion</param>
        /// <returns>RegistrosOperaciones   seleccionado por su clave primaria</returns>
		public async Task<RegistrosOperaciones> GetRegistrosOperacionesByPrimaryKeyAsync(int idRegistroOperacion)
		{
			return await _efRepository.FindAsync<RegistrosOperaciones>(x=>x.IdRegistroOperacion == idRegistroOperacion);
		}

        /// <summary>
        /// Obtener un RegistrosOperaciones por su clave primaria
        /// </summary>
		/// <param name="idRegistroOperacion">IdRegistroOperacion</param>
        /// <returns>RegistrosOperaciones  seleccionado por su clave primaria</returns>
		public RegistrosOperaciones GetRegistrosOperacionesByPrimaryKey(int idRegistroOperacion)
		{
			return _efRepository.Find<RegistrosOperaciones>(x=>x.IdRegistroOperacion == idRegistroOperacion);
		}




		/// <summary>
        /// Crea una instancia de RegistrosOperaciones en la base de datos
        /// </summary>
        /// <param name="source">RegistrosOperaciones a crear</param>
        /// <returns>RegistrosOperaciones creado</returns>
		public virtual async Task<RegistrosOperaciones> CreateRegistrosOperacionesAsync(RegistrosOperaciones source)
		{
			return await _efRepository.CreateAsync<RegistrosOperaciones>(source);
		}

		/// <summary>
        /// Crea una instancia de RegistrosOperaciones en la base de datos
        /// </summary>
        /// <param name="source">RegistrosOperaciones a crear</param>
        /// <returns>RegistrosOperaciones creado</returns>
		public virtual RegistrosOperaciones CreateRegistrosOperaciones(RegistrosOperaciones source)
		{
			return _efRepository.Create<RegistrosOperaciones>(source);
		}


		/// <summary>
        /// Modifica una instancia de RegistrosOperaciones en la base de datos
        /// </summary>
        /// <param name="source">RegistrosOperaciones a modificar</param>
        /// <returns>Número de RegistrosOperaciones modificados</returns>
		public async Task<int> UpdateRegistrosOperacionesAsync(RegistrosOperaciones source)
		{
			return await _efRepository.UpdateAsync<RegistrosOperaciones>(source);
		}

		/// <summary>
        /// Modifica una instancia de RegistrosOperaciones en la base de datos
        /// </summary>
        /// <param name="source">RegistrosOperaciones a modificar</param>
        /// <returns>Número de RegistrosOperaciones modificados</returns>
		public int UpdateRegistrosOperaciones(RegistrosOperaciones source)
		{
			return _efRepository.Update<RegistrosOperaciones>(source);
		}

		/// <summary>
        /// Borra una instancia de RegistrosOperaciones en la base de datos
        /// </summary>
        /// <param name="source">RegistrosOperaciones a borrar</param>
        /// <returns>Número de RegistrosOperaciones borrados</returns>
		public async Task<int> DeleteRegistrosOperacionesAsync(RegistrosOperaciones source)
		{
			return await _efRepository.DeleteAsync<RegistrosOperaciones>(source);
		}

		/// <summary>
        /// Borra una instancia de RegistrosOperaciones en la base de datos
        /// </summary>
        /// <param name="source">RegistrosOperaciones a borrar</param>
        /// <returns>Número de RegistrosOperaciones borrados</returns>
		public int DeleteRegistrosOperaciones(RegistrosOperaciones source)
		{
			return _efRepository.Delete<RegistrosOperaciones>(source);
		}
    }
}
