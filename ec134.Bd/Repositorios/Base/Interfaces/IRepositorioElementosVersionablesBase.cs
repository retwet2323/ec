using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioElementosVersionablesBase
	{
		/// <summary>
        /// Metodo para obtener todos los ElementosVersionables 
        /// </summary>
        /// <returns>IQueryable con todos los ElementosVersionables</returns>
		IQueryable<ElementosVersionables> GetElementosVersionables();
		
        
        /// <summary>
        /// Obtener un ElementosVersionables por su clave primaria
        /// </summary>
				/// <param name="idElementoVersionable">IdElementoVersionable</param>
		        /// <returns>ElementosVersionables   seleccionado por su clave primaria</returns>
		Task<ElementosVersionables> GetElementosVersionablesByPrimaryKeyAsync(int idElementoVersionable);
		
        /// <summary>
        /// Obtener un ElementosVersionables por su clave primaria
        /// </summary>
				/// <param name="idElementoVersionable">IdElementoVersionable</param>
		        /// <returns>ElementosVersionables  seleccionado por su clave primaria</returns>
		ElementosVersionables GetElementosVersionablesByPrimaryKey(int idElementoVersionable);


        


		/// <summary>
        /// Crea una instancia de ElementosVersionables en la base de datos
        /// </summary>
        /// <param name="source">ElementosVersionables a crear</param>
        /// <returns>ElementosVersionables creado</returns>
		Task<ElementosVersionables> CreateElementosVersionablesAsync(ElementosVersionables source);

		/// <summary>
        /// Crea una instancia de ElementosVersionables en la base de datos
        /// </summary>
        /// <param name="source">ElementosVersionables a crear</param>
        /// <returns>ElementosVersionables creado</returns>
		ElementosVersionables CreateElementosVersionables(ElementosVersionables source);


		/// <summary>
        /// Modifica una instancia de ElementosVersionables en la base de datos
        /// </summary>
        /// <param name="source">ElementosVersionables a modificar</param>
        /// <returns>Número de ElementosVersionables modificados</returns>
		Task<int> UpdateElementosVersionablesAsync(ElementosVersionables source);
		

		/// <summary>
        /// Modifica una instancia de ElementosVersionables en la base de datos
        /// </summary>
        /// <param name="source">ElementosVersionables a modificar</param>
        /// <returns>Número de ElementosVersionables modificados</returns>
		int UpdateElementosVersionables(ElementosVersionables source);

		/// <summary>
        /// Borra una instancia de ElementosVersionables en la base de datos
        /// </summary>
        /// <param name="source">ElementosVersionables a borrar</param>
        /// <returns>Número de ElementosVersionables borrados</returns>
		Task<int> DeleteElementosVersionablesAsync(ElementosVersionables source);
		
		/// <summary>
        /// Borra una instancia de ElementosVersionables en la base de datos
        /// </summary>
        /// <param name="source">ElementosVersionables a borrar</param>
        /// <returns>Número de ElementosVersionables borrados</returns>
		int DeleteElementosVersionables(ElementosVersionables source);
    }
}
