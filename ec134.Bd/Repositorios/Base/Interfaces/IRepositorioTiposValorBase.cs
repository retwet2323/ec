using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioTiposValorBase
	{
		/// <summary>
        /// Metodo para obtener todos los TiposValor 
        /// </summary>
        /// <returns>IQueryable con todos los TiposValor</returns>
		IQueryable<TiposValor> GetTiposValor();
		
        
        /// <summary>
        /// Obtener un TiposValor por su clave primaria
        /// </summary>
				/// <param name="idTipoValor">IdTipoValor</param>
		        /// <returns>TiposValor   seleccionado por su clave primaria</returns>
		Task<TiposValor> GetTiposValorByPrimaryKeyAsync(int idTipoValor);
		
        /// <summary>
        /// Obtener un TiposValor por su clave primaria
        /// </summary>
				/// <param name="idTipoValor">IdTipoValor</param>
		        /// <returns>TiposValor  seleccionado por su clave primaria</returns>
		TiposValor GetTiposValorByPrimaryKey(int idTipoValor);


        


		/// <summary>
        /// Crea una instancia de TiposValor en la base de datos
        /// </summary>
        /// <param name="source">TiposValor a crear</param>
        /// <returns>TiposValor creado</returns>
		Task<TiposValor> CreateTiposValorAsync(TiposValor source);

		/// <summary>
        /// Crea una instancia de TiposValor en la base de datos
        /// </summary>
        /// <param name="source">TiposValor a crear</param>
        /// <returns>TiposValor creado</returns>
		TiposValor CreateTiposValor(TiposValor source);


		/// <summary>
        /// Modifica una instancia de TiposValor en la base de datos
        /// </summary>
        /// <param name="source">TiposValor a modificar</param>
        /// <returns>Número de TiposValor modificados</returns>
		Task<int> UpdateTiposValorAsync(TiposValor source);
		

		/// <summary>
        /// Modifica una instancia de TiposValor en la base de datos
        /// </summary>
        /// <param name="source">TiposValor a modificar</param>
        /// <returns>Número de TiposValor modificados</returns>
		int UpdateTiposValor(TiposValor source);

		/// <summary>
        /// Borra una instancia de TiposValor en la base de datos
        /// </summary>
        /// <param name="source">TiposValor a borrar</param>
        /// <returns>Número de TiposValor borrados</returns>
		Task<int> DeleteTiposValorAsync(TiposValor source);
		
		/// <summary>
        /// Borra una instancia de TiposValor en la base de datos
        /// </summary>
        /// <param name="source">TiposValor a borrar</param>
        /// <returns>Número de TiposValor borrados</returns>
		int DeleteTiposValor(TiposValor source);
    }
}
