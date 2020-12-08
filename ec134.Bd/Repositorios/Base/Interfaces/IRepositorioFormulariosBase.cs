using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioFormulariosBase
	{
		/// <summary>
        /// Metodo para obtener todos los Formularios 
        /// </summary>
        /// <returns>IQueryable con todos los Formularios</returns>
		IQueryable<Formularios> GetFormularios();
		
        
        /// <summary>
        /// Obtener un Formularios por su clave primaria
        /// </summary>
				/// <param name="idFormulario">IdFormulario</param>
		        /// <returns>Formularios   seleccionado por su clave primaria</returns>
		Task<Formularios> GetFormulariosByPrimaryKeyAsync(int idFormulario);
		
        /// <summary>
        /// Obtener un Formularios por su clave primaria
        /// </summary>
				/// <param name="idFormulario">IdFormulario</param>
		        /// <returns>Formularios  seleccionado por su clave primaria</returns>
		Formularios GetFormulariosByPrimaryKey(int idFormulario);


        


		/// <summary>
        /// Crea una instancia de Formularios en la base de datos
        /// </summary>
        /// <param name="source">Formularios a crear</param>
        /// <returns>Formularios creado</returns>
		Task<Formularios> CreateFormulariosAsync(Formularios source);

		/// <summary>
        /// Crea una instancia de Formularios en la base de datos
        /// </summary>
        /// <param name="source">Formularios a crear</param>
        /// <returns>Formularios creado</returns>
		Formularios CreateFormularios(Formularios source);


		/// <summary>
        /// Modifica una instancia de Formularios en la base de datos
        /// </summary>
        /// <param name="source">Formularios a modificar</param>
        /// <returns>Número de Formularios modificados</returns>
		Task<int> UpdateFormulariosAsync(Formularios source);
		

		/// <summary>
        /// Modifica una instancia de Formularios en la base de datos
        /// </summary>
        /// <param name="source">Formularios a modificar</param>
        /// <returns>Número de Formularios modificados</returns>
		int UpdateFormularios(Formularios source);

		/// <summary>
        /// Borra una instancia de Formularios en la base de datos
        /// </summary>
        /// <param name="source">Formularios a borrar</param>
        /// <returns>Número de Formularios borrados</returns>
		Task<int> DeleteFormulariosAsync(Formularios source);
		
		/// <summary>
        /// Borra una instancia de Formularios en la base de datos
        /// </summary>
        /// <param name="source">Formularios a borrar</param>
        /// <returns>Número de Formularios borrados</returns>
		int DeleteFormularios(Formularios source);
    }
}
