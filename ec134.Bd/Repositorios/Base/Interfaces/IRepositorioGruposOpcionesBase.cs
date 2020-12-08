using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioGruposOpcionesBase
	{
		/// <summary>
        /// Metodo para obtener todos los GruposOpciones 
        /// </summary>
        /// <returns>IQueryable con todos los GruposOpciones</returns>
		IQueryable<GruposOpciones> GetGruposOpciones();
		
        
        /// <summary>
        /// Obtener un GruposOpciones por su clave primaria
        /// </summary>
				/// <param name="idGrupoOpciones">IdGrupoOpciones</param>
		        /// <returns>GruposOpciones   seleccionado por su clave primaria</returns>
		Task<GruposOpciones> GetGruposOpcionesByPrimaryKeyAsync(int idGrupoOpciones);
		
        /// <summary>
        /// Obtener un GruposOpciones por su clave primaria
        /// </summary>
				/// <param name="idGrupoOpciones">IdGrupoOpciones</param>
		        /// <returns>GruposOpciones  seleccionado por su clave primaria</returns>
		GruposOpciones GetGruposOpcionesByPrimaryKey(int idGrupoOpciones);


        


		/// <summary>
        /// Crea una instancia de GruposOpciones en la base de datos
        /// </summary>
        /// <param name="source">GruposOpciones a crear</param>
        /// <returns>GruposOpciones creado</returns>
		Task<GruposOpciones> CreateGruposOpcionesAsync(GruposOpciones source);

		/// <summary>
        /// Crea una instancia de GruposOpciones en la base de datos
        /// </summary>
        /// <param name="source">GruposOpciones a crear</param>
        /// <returns>GruposOpciones creado</returns>
		GruposOpciones CreateGruposOpciones(GruposOpciones source);


		/// <summary>
        /// Modifica una instancia de GruposOpciones en la base de datos
        /// </summary>
        /// <param name="source">GruposOpciones a modificar</param>
        /// <returns>Número de GruposOpciones modificados</returns>
		Task<int> UpdateGruposOpcionesAsync(GruposOpciones source);
		

		/// <summary>
        /// Modifica una instancia de GruposOpciones en la base de datos
        /// </summary>
        /// <param name="source">GruposOpciones a modificar</param>
        /// <returns>Número de GruposOpciones modificados</returns>
		int UpdateGruposOpciones(GruposOpciones source);

		/// <summary>
        /// Borra una instancia de GruposOpciones en la base de datos
        /// </summary>
        /// <param name="source">GruposOpciones a borrar</param>
        /// <returns>Número de GruposOpciones borrados</returns>
		Task<int> DeleteGruposOpcionesAsync(GruposOpciones source);
		
		/// <summary>
        /// Borra una instancia de GruposOpciones en la base de datos
        /// </summary>
        /// <param name="source">GruposOpciones a borrar</param>
        /// <returns>Número de GruposOpciones borrados</returns>
		int DeleteGruposOpciones(GruposOpciones source);
    }
}
