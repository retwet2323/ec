using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioControlesBase
	{
		/// <summary>
        /// Metodo para obtener todos los Controles 
        /// </summary>
        /// <returns>IQueryable con todos los Controles</returns>
		IQueryable<Controles> GetControles();
		
        
        /// <summary>
        /// Obtener un Controles por su clave primaria
        /// </summary>
				/// <param name="idControl">IdControl</param>
		        /// <returns>Controles   seleccionado por su clave primaria</returns>
		Task<Controles> GetControlesByPrimaryKeyAsync(int idControl);
		
        /// <summary>
        /// Obtener un Controles por su clave primaria
        /// </summary>
				/// <param name="idControl">IdControl</param>
		        /// <returns>Controles  seleccionado por su clave primaria</returns>
		Controles GetControlesByPrimaryKey(int idControl);


        

        /// <summary>
        /// Obtener un IQueryable<Controles> por su IdControlSuperior 
        /// </summary>
		/// <param name="idControlSuperior">IdControlSuperior</param>
        /// <returns>IQueryable con los Controles seleccionado por su IdControlSuperior </returns>
        IQueryable<Controles> GetControlesByIdControlSuperior(int? idControlSuperior);

        /// <summary>
        /// Obtener un IQueryable<Controles> por su IdCampoProducto 
        /// </summary>
		/// <param name="idCampoProducto">IdCampoProducto</param>
        /// <returns>IQueryable con los Controles seleccionado por su IdCampoProducto </returns>
        IQueryable<Controles> GetControlesByIdCampoProducto(int? idCampoProducto);

        /// <summary>
        /// Obtener un IQueryable<Controles> por su IdContenedor 
        /// </summary>
		/// <param name="idContenedor">IdContenedor</param>
        /// <returns>IQueryable con los Controles seleccionado por su IdContenedor </returns>
        IQueryable<Controles> GetControlesByIdContenedor(int? idContenedor);


		/// <summary>
        /// Crea una instancia de Controles en la base de datos
        /// </summary>
        /// <param name="source">Controles a crear</param>
        /// <returns>Controles creado</returns>
		Task<Controles> CreateControlesAsync(Controles source);

		/// <summary>
        /// Crea una instancia de Controles en la base de datos
        /// </summary>
        /// <param name="source">Controles a crear</param>
        /// <returns>Controles creado</returns>
		Controles CreateControles(Controles source);


		/// <summary>
        /// Modifica una instancia de Controles en la base de datos
        /// </summary>
        /// <param name="source">Controles a modificar</param>
        /// <returns>Número de Controles modificados</returns>
		Task<int> UpdateControlesAsync(Controles source);
		

		/// <summary>
        /// Modifica una instancia de Controles en la base de datos
        /// </summary>
        /// <param name="source">Controles a modificar</param>
        /// <returns>Número de Controles modificados</returns>
		int UpdateControles(Controles source);

		/// <summary>
        /// Borra una instancia de Controles en la base de datos
        /// </summary>
        /// <param name="source">Controles a borrar</param>
        /// <returns>Número de Controles borrados</returns>
		Task<int> DeleteControlesAsync(Controles source);
		
		/// <summary>
        /// Borra una instancia de Controles en la base de datos
        /// </summary>
        /// <param name="source">Controles a borrar</param>
        /// <returns>Número de Controles borrados</returns>
		int DeleteControles(Controles source);
    }
}
