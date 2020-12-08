using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioOpcionesBase
	{
		/// <summary>
        /// Metodo para obtener todos los Opciones 
        /// </summary>
        /// <returns>IQueryable con todos los Opciones</returns>
		IQueryable<Opciones> GetOpciones();
		
        
        /// <summary>
        /// Obtener un Opciones por su clave primaria
        /// </summary>
				/// <param name="idOpcion">IdOpcion</param>
		        /// <returns>Opciones   seleccionado por su clave primaria</returns>
		Task<Opciones> GetOpcionesByPrimaryKeyAsync(int idOpcion);
		
        /// <summary>
        /// Obtener un Opciones por su clave primaria
        /// </summary>
				/// <param name="idOpcion">IdOpcion</param>
		        /// <returns>Opciones  seleccionado por su clave primaria</returns>
		Opciones GetOpcionesByPrimaryKey(int idOpcion);


        

        /// <summary>
        /// Obtener un IQueryable<Opciones> por su IdGrupoOpciones 
        /// </summary>
		/// <param name="idGrupoOpciones">IdGrupoOpciones</param>
        /// <returns>IQueryable con los Opciones seleccionado por su IdGrupoOpciones </returns>
        IQueryable<Opciones> GetOpcionesByIdGrupoOpciones(int idGrupoOpciones);


		/// <summary>
        /// Crea una instancia de Opciones en la base de datos
        /// </summary>
        /// <param name="source">Opciones a crear</param>
        /// <returns>Opciones creado</returns>
		Task<Opciones> CreateOpcionesAsync(Opciones source);

		/// <summary>
        /// Crea una instancia de Opciones en la base de datos
        /// </summary>
        /// <param name="source">Opciones a crear</param>
        /// <returns>Opciones creado</returns>
		Opciones CreateOpciones(Opciones source);


		/// <summary>
        /// Modifica una instancia de Opciones en la base de datos
        /// </summary>
        /// <param name="source">Opciones a modificar</param>
        /// <returns>Número de Opciones modificados</returns>
		Task<int> UpdateOpcionesAsync(Opciones source);
		

		/// <summary>
        /// Modifica una instancia de Opciones en la base de datos
        /// </summary>
        /// <param name="source">Opciones a modificar</param>
        /// <returns>Número de Opciones modificados</returns>
		int UpdateOpciones(Opciones source);

		/// <summary>
        /// Borra una instancia de Opciones en la base de datos
        /// </summary>
        /// <param name="source">Opciones a borrar</param>
        /// <returns>Número de Opciones borrados</returns>
		Task<int> DeleteOpcionesAsync(Opciones source);
		
		/// <summary>
        /// Borra una instancia de Opciones en la base de datos
        /// </summary>
        /// <param name="source">Opciones a borrar</param>
        /// <returns>Número de Opciones borrados</returns>
		int DeleteOpciones(Opciones source);
    }
}
