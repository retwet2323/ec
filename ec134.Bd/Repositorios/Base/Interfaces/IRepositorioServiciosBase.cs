using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioServiciosBase
	{
		/// <summary>
        /// Metodo para obtener todos los Servicios 
        /// </summary>
        /// <returns>IQueryable con todos los Servicios</returns>
		IQueryable<Servicios> GetServicios();
		
        
        /// <summary>
        /// Obtener un Servicios por su clave primaria
        /// </summary>
				/// <param name="idServicio">IdServicio</param>
		        /// <returns>Servicios   seleccionado por su clave primaria</returns>
		Task<Servicios> GetServiciosByPrimaryKeyAsync(int idServicio);
		
        /// <summary>
        /// Obtener un Servicios por su clave primaria
        /// </summary>
				/// <param name="idServicio">IdServicio</param>
		        /// <returns>Servicios  seleccionado por su clave primaria</returns>
		Servicios GetServiciosByPrimaryKey(int idServicio);


        


		/// <summary>
        /// Crea una instancia de Servicios en la base de datos
        /// </summary>
        /// <param name="source">Servicios a crear</param>
        /// <returns>Servicios creado</returns>
		Task<Servicios> CreateServiciosAsync(Servicios source);

		/// <summary>
        /// Crea una instancia de Servicios en la base de datos
        /// </summary>
        /// <param name="source">Servicios a crear</param>
        /// <returns>Servicios creado</returns>
		Servicios CreateServicios(Servicios source);


		/// <summary>
        /// Modifica una instancia de Servicios en la base de datos
        /// </summary>
        /// <param name="source">Servicios a modificar</param>
        /// <returns>Número de Servicios modificados</returns>
		Task<int> UpdateServiciosAsync(Servicios source);
		

		/// <summary>
        /// Modifica una instancia de Servicios en la base de datos
        /// </summary>
        /// <param name="source">Servicios a modificar</param>
        /// <returns>Número de Servicios modificados</returns>
		int UpdateServicios(Servicios source);

		/// <summary>
        /// Borra una instancia de Servicios en la base de datos
        /// </summary>
        /// <param name="source">Servicios a borrar</param>
        /// <returns>Número de Servicios borrados</returns>
		Task<int> DeleteServiciosAsync(Servicios source);
		
		/// <summary>
        /// Borra una instancia de Servicios en la base de datos
        /// </summary>
        /// <param name="source">Servicios a borrar</param>
        /// <returns>Número de Servicios borrados</returns>
		int DeleteServicios(Servicios source);
    }
}
