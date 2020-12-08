using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioInfoOrigenesBase
	{
		/// <summary>
        /// Metodo para obtener todos los InfoOrigenes 
        /// </summary>
        /// <returns>IQueryable con todos los InfoOrigenes</returns>
		IQueryable<InfoOrigenes> GetInfoOrigenes();
		
        
        /// <summary>
        /// Obtener un InfoOrigenes por su clave primaria
        /// </summary>
				/// <param name="idInfoOrigen">IdInfoOrigen</param>
		        /// <returns>InfoOrigenes   seleccionado por su clave primaria</returns>
		Task<InfoOrigenes> GetInfoOrigenesByPrimaryKeyAsync(int idInfoOrigen);
		
        /// <summary>
        /// Obtener un InfoOrigenes por su clave primaria
        /// </summary>
				/// <param name="idInfoOrigen">IdInfoOrigen</param>
		        /// <returns>InfoOrigenes  seleccionado por su clave primaria</returns>
		InfoOrigenes GetInfoOrigenesByPrimaryKey(int idInfoOrigen);


        


		/// <summary>
        /// Crea una instancia de InfoOrigenes en la base de datos
        /// </summary>
        /// <param name="source">InfoOrigenes a crear</param>
        /// <returns>InfoOrigenes creado</returns>
		Task<InfoOrigenes> CreateInfoOrigenesAsync(InfoOrigenes source);

		/// <summary>
        /// Crea una instancia de InfoOrigenes en la base de datos
        /// </summary>
        /// <param name="source">InfoOrigenes a crear</param>
        /// <returns>InfoOrigenes creado</returns>
		InfoOrigenes CreateInfoOrigenes(InfoOrigenes source);


		/// <summary>
        /// Modifica una instancia de InfoOrigenes en la base de datos
        /// </summary>
        /// <param name="source">InfoOrigenes a modificar</param>
        /// <returns>Número de InfoOrigenes modificados</returns>
		Task<int> UpdateInfoOrigenesAsync(InfoOrigenes source);
		

		/// <summary>
        /// Modifica una instancia de InfoOrigenes en la base de datos
        /// </summary>
        /// <param name="source">InfoOrigenes a modificar</param>
        /// <returns>Número de InfoOrigenes modificados</returns>
		int UpdateInfoOrigenes(InfoOrigenes source);

		/// <summary>
        /// Borra una instancia de InfoOrigenes en la base de datos
        /// </summary>
        /// <param name="source">InfoOrigenes a borrar</param>
        /// <returns>Número de InfoOrigenes borrados</returns>
		Task<int> DeleteInfoOrigenesAsync(InfoOrigenes source);
		
		/// <summary>
        /// Borra una instancia de InfoOrigenes en la base de datos
        /// </summary>
        /// <param name="source">InfoOrigenes a borrar</param>
        /// <returns>Número de InfoOrigenes borrados</returns>
		int DeleteInfoOrigenes(InfoOrigenes source);
    }
}
