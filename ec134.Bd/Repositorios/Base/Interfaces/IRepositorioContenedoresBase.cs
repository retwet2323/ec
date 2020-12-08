using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioContenedoresBase
	{
		/// <summary>
        /// Metodo para obtener todos los Contenedores 
        /// </summary>
        /// <returns>IQueryable con todos los Contenedores</returns>
		IQueryable<Contenedores> GetContenedores();
		
        
        /// <summary>
        /// Obtener un Contenedores por su clave primaria
        /// </summary>
				/// <param name="idContenedor">IdContenedor</param>
		        /// <returns>Contenedores   seleccionado por su clave primaria</returns>
		Task<Contenedores> GetContenedoresByPrimaryKeyAsync(int idContenedor);
		
        /// <summary>
        /// Obtener un Contenedores por su clave primaria
        /// </summary>
				/// <param name="idContenedor">IdContenedor</param>
		        /// <returns>Contenedores  seleccionado por su clave primaria</returns>
		Contenedores GetContenedoresByPrimaryKey(int idContenedor);


        

        /// <summary>
        /// Obtener un IQueryable<Contenedores> por su IdContenedorSuperior 
        /// </summary>
		/// <param name="idContenedorSuperior">IdContenedorSuperior</param>
        /// <returns>IQueryable con los Contenedores seleccionado por su IdContenedorSuperior </returns>
        IQueryable<Contenedores> GetContenedoresByIdContenedorSuperior(int? idContenedorSuperior);

        /// <summary>
        /// Obtener un IQueryable<Contenedores> por su IdFormulario 
        /// </summary>
		/// <param name="idFormulario">IdFormulario</param>
        /// <returns>IQueryable con los Contenedores seleccionado por su IdFormulario </returns>
        IQueryable<Contenedores> GetContenedoresByIdFormulario(int? idFormulario);


		/// <summary>
        /// Crea una instancia de Contenedores en la base de datos
        /// </summary>
        /// <param name="source">Contenedores a crear</param>
        /// <returns>Contenedores creado</returns>
		Task<Contenedores> CreateContenedoresAsync(Contenedores source);

		/// <summary>
        /// Crea una instancia de Contenedores en la base de datos
        /// </summary>
        /// <param name="source">Contenedores a crear</param>
        /// <returns>Contenedores creado</returns>
		Contenedores CreateContenedores(Contenedores source);


		/// <summary>
        /// Modifica una instancia de Contenedores en la base de datos
        /// </summary>
        /// <param name="source">Contenedores a modificar</param>
        /// <returns>Número de Contenedores modificados</returns>
		Task<int> UpdateContenedoresAsync(Contenedores source);
		

		/// <summary>
        /// Modifica una instancia de Contenedores en la base de datos
        /// </summary>
        /// <param name="source">Contenedores a modificar</param>
        /// <returns>Número de Contenedores modificados</returns>
		int UpdateContenedores(Contenedores source);

		/// <summary>
        /// Borra una instancia de Contenedores en la base de datos
        /// </summary>
        /// <param name="source">Contenedores a borrar</param>
        /// <returns>Número de Contenedores borrados</returns>
		Task<int> DeleteContenedoresAsync(Contenedores source);
		
		/// <summary>
        /// Borra una instancia de Contenedores en la base de datos
        /// </summary>
        /// <param name="source">Contenedores a borrar</param>
        /// <returns>Número de Contenedores borrados</returns>
		int DeleteContenedores(Contenedores source);
    }
}
