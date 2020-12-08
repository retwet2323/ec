using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioClientesBase
	{
		/// <summary>
        /// Metodo para obtener todos los Clientes 
        /// </summary>
        /// <returns>IQueryable con todos los Clientes</returns>
		IQueryable<Clientes> GetClientes();
		
        
        /// <summary>
        /// Obtener un Clientes por su clave primaria
        /// </summary>
				/// <param name="idCliente">IdCliente</param>
		        /// <returns>Clientes   seleccionado por su clave primaria</returns>
		Task<Clientes> GetClientesByPrimaryKeyAsync(int idCliente);
		
        /// <summary>
        /// Obtener un Clientes por su clave primaria
        /// </summary>
				/// <param name="idCliente">IdCliente</param>
		        /// <returns>Clientes  seleccionado por su clave primaria</returns>
		Clientes GetClientesByPrimaryKey(int idCliente);


        


		/// <summary>
        /// Crea una instancia de Clientes en la base de datos
        /// </summary>
        /// <param name="source">Clientes a crear</param>
        /// <returns>Clientes creado</returns>
		Task<Clientes> CreateClientesAsync(Clientes source);

		/// <summary>
        /// Crea una instancia de Clientes en la base de datos
        /// </summary>
        /// <param name="source">Clientes a crear</param>
        /// <returns>Clientes creado</returns>
		Clientes CreateClientes(Clientes source);


		/// <summary>
        /// Modifica una instancia de Clientes en la base de datos
        /// </summary>
        /// <param name="source">Clientes a modificar</param>
        /// <returns>Número de Clientes modificados</returns>
		Task<int> UpdateClientesAsync(Clientes source);
		

		/// <summary>
        /// Modifica una instancia de Clientes en la base de datos
        /// </summary>
        /// <param name="source">Clientes a modificar</param>
        /// <returns>Número de Clientes modificados</returns>
		int UpdateClientes(Clientes source);

		/// <summary>
        /// Borra una instancia de Clientes en la base de datos
        /// </summary>
        /// <param name="source">Clientes a borrar</param>
        /// <returns>Número de Clientes borrados</returns>
		Task<int> DeleteClientesAsync(Clientes source);
		
		/// <summary>
        /// Borra una instancia de Clientes en la base de datos
        /// </summary>
        /// <param name="source">Clientes a borrar</param>
        /// <returns>Número de Clientes borrados</returns>
		int DeleteClientes(Clientes source);
    }
}
