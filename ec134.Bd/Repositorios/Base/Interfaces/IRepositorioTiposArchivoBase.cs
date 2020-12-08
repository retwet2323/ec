using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioTiposArchivoBase
	{
		/// <summary>
        /// Metodo para obtener todos los TiposArchivo 
        /// </summary>
        /// <returns>IQueryable con todos los TiposArchivo</returns>
		IQueryable<TiposArchivo> GetTiposArchivo();
		
        
        /// <summary>
        /// Obtener un TiposArchivo por su clave primaria
        /// </summary>
				/// <param name="idTipoArchivo">IdTipoArchivo</param>
		        /// <returns>TiposArchivo   seleccionado por su clave primaria</returns>
		Task<TiposArchivo> GetTiposArchivoByPrimaryKeyAsync(int idTipoArchivo);
		
        /// <summary>
        /// Obtener un TiposArchivo por su clave primaria
        /// </summary>
				/// <param name="idTipoArchivo">IdTipoArchivo</param>
		        /// <returns>TiposArchivo  seleccionado por su clave primaria</returns>
		TiposArchivo GetTiposArchivoByPrimaryKey(int idTipoArchivo);


        


		/// <summary>
        /// Crea una instancia de TiposArchivo en la base de datos
        /// </summary>
        /// <param name="source">TiposArchivo a crear</param>
        /// <returns>TiposArchivo creado</returns>
		Task<TiposArchivo> CreateTiposArchivoAsync(TiposArchivo source);

		/// <summary>
        /// Crea una instancia de TiposArchivo en la base de datos
        /// </summary>
        /// <param name="source">TiposArchivo a crear</param>
        /// <returns>TiposArchivo creado</returns>
		TiposArchivo CreateTiposArchivo(TiposArchivo source);


		/// <summary>
        /// Modifica una instancia de TiposArchivo en la base de datos
        /// </summary>
        /// <param name="source">TiposArchivo a modificar</param>
        /// <returns>Número de TiposArchivo modificados</returns>
		Task<int> UpdateTiposArchivoAsync(TiposArchivo source);
		

		/// <summary>
        /// Modifica una instancia de TiposArchivo en la base de datos
        /// </summary>
        /// <param name="source">TiposArchivo a modificar</param>
        /// <returns>Número de TiposArchivo modificados</returns>
		int UpdateTiposArchivo(TiposArchivo source);

		/// <summary>
        /// Borra una instancia de TiposArchivo en la base de datos
        /// </summary>
        /// <param name="source">TiposArchivo a borrar</param>
        /// <returns>Número de TiposArchivo borrados</returns>
		Task<int> DeleteTiposArchivoAsync(TiposArchivo source);
		
		/// <summary>
        /// Borra una instancia de TiposArchivo en la base de datos
        /// </summary>
        /// <param name="source">TiposArchivo a borrar</param>
        /// <returns>Número de TiposArchivo borrados</returns>
		int DeleteTiposArchivo(TiposArchivo source);
    }
}
