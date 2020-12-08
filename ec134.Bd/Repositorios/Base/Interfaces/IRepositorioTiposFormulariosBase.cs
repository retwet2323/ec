using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioTiposFormulariosBase
	{
		/// <summary>
        /// Metodo para obtener todos los TiposFormularios 
        /// </summary>
        /// <returns>IQueryable con todos los TiposFormularios</returns>
		IQueryable<TiposFormularios> GetTiposFormularios();
		
        
        /// <summary>
        /// Obtener un TiposFormularios por su clave primaria
        /// </summary>
				/// <param name="idTipoFormulario">IdTipoFormulario</param>
		        /// <returns>TiposFormularios   seleccionado por su clave primaria</returns>
		Task<TiposFormularios> GetTiposFormulariosByPrimaryKeyAsync(int idTipoFormulario);
		
        /// <summary>
        /// Obtener un TiposFormularios por su clave primaria
        /// </summary>
				/// <param name="idTipoFormulario">IdTipoFormulario</param>
		        /// <returns>TiposFormularios  seleccionado por su clave primaria</returns>
		TiposFormularios GetTiposFormulariosByPrimaryKey(int idTipoFormulario);


        


		/// <summary>
        /// Crea una instancia de TiposFormularios en la base de datos
        /// </summary>
        /// <param name="source">TiposFormularios a crear</param>
        /// <returns>TiposFormularios creado</returns>
		Task<TiposFormularios> CreateTiposFormulariosAsync(TiposFormularios source);

		/// <summary>
        /// Crea una instancia de TiposFormularios en la base de datos
        /// </summary>
        /// <param name="source">TiposFormularios a crear</param>
        /// <returns>TiposFormularios creado</returns>
		TiposFormularios CreateTiposFormularios(TiposFormularios source);


		/// <summary>
        /// Modifica una instancia de TiposFormularios en la base de datos
        /// </summary>
        /// <param name="source">TiposFormularios a modificar</param>
        /// <returns>Número de TiposFormularios modificados</returns>
		Task<int> UpdateTiposFormulariosAsync(TiposFormularios source);
		

		/// <summary>
        /// Modifica una instancia de TiposFormularios en la base de datos
        /// </summary>
        /// <param name="source">TiposFormularios a modificar</param>
        /// <returns>Número de TiposFormularios modificados</returns>
		int UpdateTiposFormularios(TiposFormularios source);

		/// <summary>
        /// Borra una instancia de TiposFormularios en la base de datos
        /// </summary>
        /// <param name="source">TiposFormularios a borrar</param>
        /// <returns>Número de TiposFormularios borrados</returns>
		Task<int> DeleteTiposFormulariosAsync(TiposFormularios source);
		
		/// <summary>
        /// Borra una instancia de TiposFormularios en la base de datos
        /// </summary>
        /// <param name="source">TiposFormularios a borrar</param>
        /// <returns>Número de TiposFormularios borrados</returns>
		int DeleteTiposFormularios(TiposFormularios source);
    }
}
