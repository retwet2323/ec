using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioTiposControlesBase
	{
		/// <summary>
        /// Metodo para obtener todos los TiposControles 
        /// </summary>
        /// <returns>IQueryable con todos los TiposControles</returns>
		IQueryable<TiposControles> GetTiposControles();
		
        
        /// <summary>
        /// Obtener un TiposControles por su clave primaria
        /// </summary>
				/// <param name="idTipoControl">IdTipoControl</param>
		        /// <returns>TiposControles   seleccionado por su clave primaria</returns>
		Task<TiposControles> GetTiposControlesByPrimaryKeyAsync(int idTipoControl);
		
        /// <summary>
        /// Obtener un TiposControles por su clave primaria
        /// </summary>
				/// <param name="idTipoControl">IdTipoControl</param>
		        /// <returns>TiposControles  seleccionado por su clave primaria</returns>
		TiposControles GetTiposControlesByPrimaryKey(int idTipoControl);


        


		/// <summary>
        /// Crea una instancia de TiposControles en la base de datos
        /// </summary>
        /// <param name="source">TiposControles a crear</param>
        /// <returns>TiposControles creado</returns>
		Task<TiposControles> CreateTiposControlesAsync(TiposControles source);

		/// <summary>
        /// Crea una instancia de TiposControles en la base de datos
        /// </summary>
        /// <param name="source">TiposControles a crear</param>
        /// <returns>TiposControles creado</returns>
		TiposControles CreateTiposControles(TiposControles source);


		/// <summary>
        /// Modifica una instancia de TiposControles en la base de datos
        /// </summary>
        /// <param name="source">TiposControles a modificar</param>
        /// <returns>Número de TiposControles modificados</returns>
		Task<int> UpdateTiposControlesAsync(TiposControles source);
		

		/// <summary>
        /// Modifica una instancia de TiposControles en la base de datos
        /// </summary>
        /// <param name="source">TiposControles a modificar</param>
        /// <returns>Número de TiposControles modificados</returns>
		int UpdateTiposControles(TiposControles source);

		/// <summary>
        /// Borra una instancia de TiposControles en la base de datos
        /// </summary>
        /// <param name="source">TiposControles a borrar</param>
        /// <returns>Número de TiposControles borrados</returns>
		Task<int> DeleteTiposControlesAsync(TiposControles source);
		
		/// <summary>
        /// Borra una instancia de TiposControles en la base de datos
        /// </summary>
        /// <param name="source">TiposControles a borrar</param>
        /// <returns>Número de TiposControles borrados</returns>
		int DeleteTiposControles(TiposControles source);
    }
}
