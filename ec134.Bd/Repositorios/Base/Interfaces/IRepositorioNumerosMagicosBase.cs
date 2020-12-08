using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioNumerosMagicosBase
	{
		/// <summary>
        /// Metodo para obtener todos los NumerosMagicos 
        /// </summary>
        /// <returns>IQueryable con todos los NumerosMagicos</returns>
		IQueryable<NumerosMagicos> GetNumerosMagicos();
		
        
        /// <summary>
        /// Obtener un NumerosMagicos por su clave primaria
        /// </summary>
				/// <param name="idNumeroMagico">IdNumeroMagico</param>
		        /// <returns>NumerosMagicos   seleccionado por su clave primaria</returns>
		Task<NumerosMagicos> GetNumerosMagicosByPrimaryKeyAsync(int idNumeroMagico);
		
        /// <summary>
        /// Obtener un NumerosMagicos por su clave primaria
        /// </summary>
				/// <param name="idNumeroMagico">IdNumeroMagico</param>
		        /// <returns>NumerosMagicos  seleccionado por su clave primaria</returns>
		NumerosMagicos GetNumerosMagicosByPrimaryKey(int idNumeroMagico);


        

        /// <summary>
        /// Obtener un IQueryable<NumerosMagicos> por su IdTipoArchivo 
        /// </summary>
		/// <param name="idTipoArchivo">IdTipoArchivo</param>
        /// <returns>IQueryable con los NumerosMagicos seleccionado por su IdTipoArchivo </returns>
        IQueryable<NumerosMagicos> GetNumerosMagicosByIdTipoArchivo(int idTipoArchivo);


		/// <summary>
        /// Crea una instancia de NumerosMagicos en la base de datos
        /// </summary>
        /// <param name="source">NumerosMagicos a crear</param>
        /// <returns>NumerosMagicos creado</returns>
		Task<NumerosMagicos> CreateNumerosMagicosAsync(NumerosMagicos source);

		/// <summary>
        /// Crea una instancia de NumerosMagicos en la base de datos
        /// </summary>
        /// <param name="source">NumerosMagicos a crear</param>
        /// <returns>NumerosMagicos creado</returns>
		NumerosMagicos CreateNumerosMagicos(NumerosMagicos source);


		/// <summary>
        /// Modifica una instancia de NumerosMagicos en la base de datos
        /// </summary>
        /// <param name="source">NumerosMagicos a modificar</param>
        /// <returns>Número de NumerosMagicos modificados</returns>
		Task<int> UpdateNumerosMagicosAsync(NumerosMagicos source);
		

		/// <summary>
        /// Modifica una instancia de NumerosMagicos en la base de datos
        /// </summary>
        /// <param name="source">NumerosMagicos a modificar</param>
        /// <returns>Número de NumerosMagicos modificados</returns>
		int UpdateNumerosMagicos(NumerosMagicos source);

		/// <summary>
        /// Borra una instancia de NumerosMagicos en la base de datos
        /// </summary>
        /// <param name="source">NumerosMagicos a borrar</param>
        /// <returns>Número de NumerosMagicos borrados</returns>
		Task<int> DeleteNumerosMagicosAsync(NumerosMagicos source);
		
		/// <summary>
        /// Borra una instancia de NumerosMagicos en la base de datos
        /// </summary>
        /// <param name="source">NumerosMagicos a borrar</param>
        /// <returns>Número de NumerosMagicos borrados</returns>
		int DeleteNumerosMagicos(NumerosMagicos source);
    }
}
