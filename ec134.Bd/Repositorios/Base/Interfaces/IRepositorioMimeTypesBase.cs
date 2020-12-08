using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioMimeTypesBase
	{
		/// <summary>
        /// Metodo para obtener todos los MimeTypes 
        /// </summary>
        /// <returns>IQueryable con todos los MimeTypes</returns>
		IQueryable<MimeTypes> GetMimeTypes();
		
        
        /// <summary>
        /// Obtener un MimeTypes por su clave primaria
        /// </summary>
				/// <param name="idMimeType">IdMimeType</param>
		        /// <returns>MimeTypes   seleccionado por su clave primaria</returns>
		Task<MimeTypes> GetMimeTypesByPrimaryKeyAsync(int idMimeType);
		
        /// <summary>
        /// Obtener un MimeTypes por su clave primaria
        /// </summary>
				/// <param name="idMimeType">IdMimeType</param>
		        /// <returns>MimeTypes  seleccionado por su clave primaria</returns>
		MimeTypes GetMimeTypesByPrimaryKey(int idMimeType);


        

        /// <summary>
        /// Obtener un IQueryable<MimeTypes> por su IdTipoArchivo 
        /// </summary>
		/// <param name="idTipoArchivo">IdTipoArchivo</param>
        /// <returns>IQueryable con los MimeTypes seleccionado por su IdTipoArchivo </returns>
        IQueryable<MimeTypes> GetMimeTypesByIdTipoArchivo(int? idTipoArchivo);


		/// <summary>
        /// Crea una instancia de MimeTypes en la base de datos
        /// </summary>
        /// <param name="source">MimeTypes a crear</param>
        /// <returns>MimeTypes creado</returns>
		Task<MimeTypes> CreateMimeTypesAsync(MimeTypes source);

		/// <summary>
        /// Crea una instancia de MimeTypes en la base de datos
        /// </summary>
        /// <param name="source">MimeTypes a crear</param>
        /// <returns>MimeTypes creado</returns>
		MimeTypes CreateMimeTypes(MimeTypes source);


		/// <summary>
        /// Modifica una instancia de MimeTypes en la base de datos
        /// </summary>
        /// <param name="source">MimeTypes a modificar</param>
        /// <returns>Número de MimeTypes modificados</returns>
		Task<int> UpdateMimeTypesAsync(MimeTypes source);
		

		/// <summary>
        /// Modifica una instancia de MimeTypes en la base de datos
        /// </summary>
        /// <param name="source">MimeTypes a modificar</param>
        /// <returns>Número de MimeTypes modificados</returns>
		int UpdateMimeTypes(MimeTypes source);

		/// <summary>
        /// Borra una instancia de MimeTypes en la base de datos
        /// </summary>
        /// <param name="source">MimeTypes a borrar</param>
        /// <returns>Número de MimeTypes borrados</returns>
		Task<int> DeleteMimeTypesAsync(MimeTypes source);
		
		/// <summary>
        /// Borra una instancia de MimeTypes en la base de datos
        /// </summary>
        /// <param name="source">MimeTypes a borrar</param>
        /// <returns>Número de MimeTypes borrados</returns>
		int DeleteMimeTypes(MimeTypes source);
    }
}
