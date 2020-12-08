using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioExtensionesBase
	{
		/// <summary>
        /// Metodo para obtener todos los Extensiones 
        /// </summary>
        /// <returns>IQueryable con todos los Extensiones</returns>
		IQueryable<Extensiones> GetExtensiones();
		
        
        /// <summary>
        /// Obtener un Extensiones por su clave primaria
        /// </summary>
				/// <param name="idExtension">IdExtension</param>
		        /// <returns>Extensiones   seleccionado por su clave primaria</returns>
		Task<Extensiones> GetExtensionesByPrimaryKeyAsync(int idExtension);
		
        /// <summary>
        /// Obtener un Extensiones por su clave primaria
        /// </summary>
				/// <param name="idExtension">IdExtension</param>
		        /// <returns>Extensiones  seleccionado por su clave primaria</returns>
		Extensiones GetExtensionesByPrimaryKey(int idExtension);


        

        /// <summary>
        /// Obtener un IQueryable<Extensiones> por su IdTipoArchivo 
        /// </summary>
		/// <param name="idTipoArchivo">IdTipoArchivo</param>
        /// <returns>IQueryable con los Extensiones seleccionado por su IdTipoArchivo </returns>
        IQueryable<Extensiones> GetExtensionesByIdTipoArchivo(int? idTipoArchivo);


		/// <summary>
        /// Crea una instancia de Extensiones en la base de datos
        /// </summary>
        /// <param name="source">Extensiones a crear</param>
        /// <returns>Extensiones creado</returns>
		Task<Extensiones> CreateExtensionesAsync(Extensiones source);

		/// <summary>
        /// Crea una instancia de Extensiones en la base de datos
        /// </summary>
        /// <param name="source">Extensiones a crear</param>
        /// <returns>Extensiones creado</returns>
		Extensiones CreateExtensiones(Extensiones source);


		/// <summary>
        /// Modifica una instancia de Extensiones en la base de datos
        /// </summary>
        /// <param name="source">Extensiones a modificar</param>
        /// <returns>Número de Extensiones modificados</returns>
		Task<int> UpdateExtensionesAsync(Extensiones source);
		

		/// <summary>
        /// Modifica una instancia de Extensiones en la base de datos
        /// </summary>
        /// <param name="source">Extensiones a modificar</param>
        /// <returns>Número de Extensiones modificados</returns>
		int UpdateExtensiones(Extensiones source);

		/// <summary>
        /// Borra una instancia de Extensiones en la base de datos
        /// </summary>
        /// <param name="source">Extensiones a borrar</param>
        /// <returns>Número de Extensiones borrados</returns>
		Task<int> DeleteExtensionesAsync(Extensiones source);
		
		/// <summary>
        /// Borra una instancia de Extensiones en la base de datos
        /// </summary>
        /// <param name="source">Extensiones a borrar</param>
        /// <returns>Número de Extensiones borrados</returns>
		int DeleteExtensiones(Extensiones source);
    }
}
