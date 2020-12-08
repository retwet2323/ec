using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioPasosBase
	{
		/// <summary>
        /// Metodo para obtener todos los Pasos 
        /// </summary>
        /// <returns>IQueryable con todos los Pasos</returns>
		IQueryable<Pasos> GetPasos();
		
        
        /// <summary>
        /// Obtener un Pasos por su clave primaria
        /// </summary>
				/// <param name="idPaso">IdPaso</param>
		        /// <returns>Pasos   seleccionado por su clave primaria</returns>
		Task<Pasos> GetPasosByPrimaryKeyAsync(int idPaso);
		
        /// <summary>
        /// Obtener un Pasos por su clave primaria
        /// </summary>
				/// <param name="idPaso">IdPaso</param>
		        /// <returns>Pasos  seleccionado por su clave primaria</returns>
		Pasos GetPasosByPrimaryKey(int idPaso);


        

        /// <summary>
        /// Obtener un IQueryable<Pasos> por su IdProducto 
        /// </summary>
		/// <param name="idProducto">IdProducto</param>
        /// <returns>IQueryable con los Pasos seleccionado por su IdProducto </returns>
        IQueryable<Pasos> GetPasosByIdProducto(int? idProducto);


		/// <summary>
        /// Crea una instancia de Pasos en la base de datos
        /// </summary>
        /// <param name="source">Pasos a crear</param>
        /// <returns>Pasos creado</returns>
		Task<Pasos> CreatePasosAsync(Pasos source);

		/// <summary>
        /// Crea una instancia de Pasos en la base de datos
        /// </summary>
        /// <param name="source">Pasos a crear</param>
        /// <returns>Pasos creado</returns>
		Pasos CreatePasos(Pasos source);


		/// <summary>
        /// Modifica una instancia de Pasos en la base de datos
        /// </summary>
        /// <param name="source">Pasos a modificar</param>
        /// <returns>Número de Pasos modificados</returns>
		Task<int> UpdatePasosAsync(Pasos source);
		

		/// <summary>
        /// Modifica una instancia de Pasos en la base de datos
        /// </summary>
        /// <param name="source">Pasos a modificar</param>
        /// <returns>Número de Pasos modificados</returns>
		int UpdatePasos(Pasos source);

		/// <summary>
        /// Borra una instancia de Pasos en la base de datos
        /// </summary>
        /// <param name="source">Pasos a borrar</param>
        /// <returns>Número de Pasos borrados</returns>
		Task<int> DeletePasosAsync(Pasos source);
		
		/// <summary>
        /// Borra una instancia de Pasos en la base de datos
        /// </summary>
        /// <param name="source">Pasos a borrar</param>
        /// <returns>Número de Pasos borrados</returns>
		int DeletePasos(Pasos source);
    }
}
