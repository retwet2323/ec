using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioTiposIdentificadorBase
	{
		/// <summary>
        /// Metodo para obtener todos los TiposIdentificador 
        /// </summary>
        /// <returns>IQueryable con todos los TiposIdentificador</returns>
		IQueryable<TiposIdentificador> GetTiposIdentificador();
		
        
        /// <summary>
        /// Obtener un TiposIdentificador por su clave primaria
        /// </summary>
				/// <param name="idTipoIdentificador">IdTipoIdentificador</param>
		        /// <returns>TiposIdentificador   seleccionado por su clave primaria</returns>
		Task<TiposIdentificador> GetTiposIdentificadorByPrimaryKeyAsync(int idTipoIdentificador);
		
        /// <summary>
        /// Obtener un TiposIdentificador por su clave primaria
        /// </summary>
				/// <param name="idTipoIdentificador">IdTipoIdentificador</param>
		        /// <returns>TiposIdentificador  seleccionado por su clave primaria</returns>
		TiposIdentificador GetTiposIdentificadorByPrimaryKey(int idTipoIdentificador);


        


		/// <summary>
        /// Crea una instancia de TiposIdentificador en la base de datos
        /// </summary>
        /// <param name="source">TiposIdentificador a crear</param>
        /// <returns>TiposIdentificador creado</returns>
		Task<TiposIdentificador> CreateTiposIdentificadorAsync(TiposIdentificador source);

		/// <summary>
        /// Crea una instancia de TiposIdentificador en la base de datos
        /// </summary>
        /// <param name="source">TiposIdentificador a crear</param>
        /// <returns>TiposIdentificador creado</returns>
		TiposIdentificador CreateTiposIdentificador(TiposIdentificador source);


		/// <summary>
        /// Modifica una instancia de TiposIdentificador en la base de datos
        /// </summary>
        /// <param name="source">TiposIdentificador a modificar</param>
        /// <returns>Número de TiposIdentificador modificados</returns>
		Task<int> UpdateTiposIdentificadorAsync(TiposIdentificador source);
		

		/// <summary>
        /// Modifica una instancia de TiposIdentificador en la base de datos
        /// </summary>
        /// <param name="source">TiposIdentificador a modificar</param>
        /// <returns>Número de TiposIdentificador modificados</returns>
		int UpdateTiposIdentificador(TiposIdentificador source);

		/// <summary>
        /// Borra una instancia de TiposIdentificador en la base de datos
        /// </summary>
        /// <param name="source">TiposIdentificador a borrar</param>
        /// <returns>Número de TiposIdentificador borrados</returns>
		Task<int> DeleteTiposIdentificadorAsync(TiposIdentificador source);
		
		/// <summary>
        /// Borra una instancia de TiposIdentificador en la base de datos
        /// </summary>
        /// <param name="source">TiposIdentificador a borrar</param>
        /// <returns>Número de TiposIdentificador borrados</returns>
		int DeleteTiposIdentificador(TiposIdentificador source);
    }
}
