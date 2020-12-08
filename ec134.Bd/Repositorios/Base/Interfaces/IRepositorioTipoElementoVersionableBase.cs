using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioTipoElementoVersionableBase
	{
		/// <summary>
        /// Metodo para obtener todos los TipoElementoVersionable 
        /// </summary>
        /// <returns>IQueryable con todos los TipoElementoVersionable</returns>
		IQueryable<TipoElementoVersionable> GetTipoElementoVersionable();
		
        
        /// <summary>
        /// Obtener un TipoElementoVersionable por su clave primaria
        /// </summary>
				/// <param name="idTipoElementoVersionable">IdTipoElementoVersionable</param>
		        /// <returns>TipoElementoVersionable   seleccionado por su clave primaria</returns>
		Task<TipoElementoVersionable> GetTipoElementoVersionableByPrimaryKeyAsync(int idTipoElementoVersionable);
		
        /// <summary>
        /// Obtener un TipoElementoVersionable por su clave primaria
        /// </summary>
				/// <param name="idTipoElementoVersionable">IdTipoElementoVersionable</param>
		        /// <returns>TipoElementoVersionable  seleccionado por su clave primaria</returns>
		TipoElementoVersionable GetTipoElementoVersionableByPrimaryKey(int idTipoElementoVersionable);


        


		/// <summary>
        /// Crea una instancia de TipoElementoVersionable en la base de datos
        /// </summary>
        /// <param name="source">TipoElementoVersionable a crear</param>
        /// <returns>TipoElementoVersionable creado</returns>
		Task<TipoElementoVersionable> CreateTipoElementoVersionableAsync(TipoElementoVersionable source);

		/// <summary>
        /// Crea una instancia de TipoElementoVersionable en la base de datos
        /// </summary>
        /// <param name="source">TipoElementoVersionable a crear</param>
        /// <returns>TipoElementoVersionable creado</returns>
		TipoElementoVersionable CreateTipoElementoVersionable(TipoElementoVersionable source);


		/// <summary>
        /// Modifica una instancia de TipoElementoVersionable en la base de datos
        /// </summary>
        /// <param name="source">TipoElementoVersionable a modificar</param>
        /// <returns>Número de TipoElementoVersionable modificados</returns>
		Task<int> UpdateTipoElementoVersionableAsync(TipoElementoVersionable source);
		

		/// <summary>
        /// Modifica una instancia de TipoElementoVersionable en la base de datos
        /// </summary>
        /// <param name="source">TipoElementoVersionable a modificar</param>
        /// <returns>Número de TipoElementoVersionable modificados</returns>
		int UpdateTipoElementoVersionable(TipoElementoVersionable source);

		/// <summary>
        /// Borra una instancia de TipoElementoVersionable en la base de datos
        /// </summary>
        /// <param name="source">TipoElementoVersionable a borrar</param>
        /// <returns>Número de TipoElementoVersionable borrados</returns>
		Task<int> DeleteTipoElementoVersionableAsync(TipoElementoVersionable source);
		
		/// <summary>
        /// Borra una instancia de TipoElementoVersionable en la base de datos
        /// </summary>
        /// <param name="source">TipoElementoVersionable a borrar</param>
        /// <returns>Número de TipoElementoVersionable borrados</returns>
		int DeleteTipoElementoVersionable(TipoElementoVersionable source);
    }
}
