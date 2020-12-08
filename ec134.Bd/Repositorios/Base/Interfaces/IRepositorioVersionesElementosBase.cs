using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioVersionesElementosBase
	{
		/// <summary>
        /// Metodo para obtener todos los VersionesElementos 
        /// </summary>
        /// <returns>IQueryable con todos los VersionesElementos</returns>
		IQueryable<VersionesElementos> GetVersionesElementos();
		
        
        /// <summary>
        /// Obtener un VersionesElementos por su clave primaria
        /// </summary>
				/// <param name="idVersionElemento">IdVersionElemento</param>
		        /// <returns>VersionesElementos   seleccionado por su clave primaria</returns>
		Task<VersionesElementos> GetVersionesElementosByPrimaryKeyAsync(int idVersionElemento);
		
        /// <summary>
        /// Obtener un VersionesElementos por su clave primaria
        /// </summary>
				/// <param name="idVersionElemento">IdVersionElemento</param>
		        /// <returns>VersionesElementos  seleccionado por su clave primaria</returns>
		VersionesElementos GetVersionesElementosByPrimaryKey(int idVersionElemento);


        

        /// <summary>
        /// Obtener un IQueryable<VersionesElementos> por su IdElementoVersionable 
        /// </summary>
		/// <param name="idElementoVersionable">IdElementoVersionable</param>
        /// <returns>IQueryable con los VersionesElementos seleccionado por su IdElementoVersionable </returns>
        IQueryable<VersionesElementos> GetVersionesElementosByIdElementoVersionable(int? idElementoVersionable);


		/// <summary>
        /// Crea una instancia de VersionesElementos en la base de datos
        /// </summary>
        /// <param name="source">VersionesElementos a crear</param>
        /// <returns>VersionesElementos creado</returns>
		Task<VersionesElementos> CreateVersionesElementosAsync(VersionesElementos source);

		/// <summary>
        /// Crea una instancia de VersionesElementos en la base de datos
        /// </summary>
        /// <param name="source">VersionesElementos a crear</param>
        /// <returns>VersionesElementos creado</returns>
		VersionesElementos CreateVersionesElementos(VersionesElementos source);


		/// <summary>
        /// Modifica una instancia de VersionesElementos en la base de datos
        /// </summary>
        /// <param name="source">VersionesElementos a modificar</param>
        /// <returns>Número de VersionesElementos modificados</returns>
		Task<int> UpdateVersionesElementosAsync(VersionesElementos source);
		

		/// <summary>
        /// Modifica una instancia de VersionesElementos en la base de datos
        /// </summary>
        /// <param name="source">VersionesElementos a modificar</param>
        /// <returns>Número de VersionesElementos modificados</returns>
		int UpdateVersionesElementos(VersionesElementos source);

		/// <summary>
        /// Borra una instancia de VersionesElementos en la base de datos
        /// </summary>
        /// <param name="source">VersionesElementos a borrar</param>
        /// <returns>Número de VersionesElementos borrados</returns>
		Task<int> DeleteVersionesElementosAsync(VersionesElementos source);
		
		/// <summary>
        /// Borra una instancia de VersionesElementos en la base de datos
        /// </summary>
        /// <param name="source">VersionesElementos a borrar</param>
        /// <returns>Número de VersionesElementos borrados</returns>
		int DeleteVersionesElementos(VersionesElementos source);
    }
}
