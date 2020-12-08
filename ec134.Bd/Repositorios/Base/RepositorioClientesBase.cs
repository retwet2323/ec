using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioClientesBase : IRepositorioClientesBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase Clientes 
        /// </summary>
		public RepositorioClientesBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los Clientes 
        /// </summary>
        /// <returns>IQueryable con todos los Clientes</returns>
		public IQueryable<Clientes> GetClientes()
		{
			return _efRepository.All<Clientes>();
		}

        
        /// <summary>
        /// Obtener un Clientes por su clave primaria
        /// </summary>
		/// <param name="idCliente">IdCliente</param>
        /// <returns>Clientes   seleccionado por su clave primaria</returns>
		public async Task<Clientes> GetClientesByPrimaryKeyAsync(int idCliente)
		{
			return await _efRepository.FindAsync<Clientes>(x=>x.IdCliente == idCliente);
		}

        /// <summary>
        /// Obtener un Clientes por su clave primaria
        /// </summary>
		/// <param name="idCliente">IdCliente</param>
        /// <returns>Clientes  seleccionado por su clave primaria</returns>
		public Clientes GetClientesByPrimaryKey(int idCliente)
		{
			return _efRepository.Find<Clientes>(x=>x.IdCliente == idCliente);
		}




		/// <summary>
        /// Crea una instancia de Clientes en la base de datos
        /// </summary>
        /// <param name="source">Clientes a crear</param>
        /// <returns>Clientes creado</returns>
		public virtual async Task<Clientes> CreateClientesAsync(Clientes source)
		{
			return await _efRepository.CreateAsync<Clientes>(source);
		}

		/// <summary>
        /// Crea una instancia de Clientes en la base de datos
        /// </summary>
        /// <param name="source">Clientes a crear</param>
        /// <returns>Clientes creado</returns>
		public virtual Clientes CreateClientes(Clientes source)
		{
			return _efRepository.Create<Clientes>(source);
		}


		/// <summary>
        /// Modifica una instancia de Clientes en la base de datos
        /// </summary>
        /// <param name="source">Clientes a modificar</param>
        /// <returns>Número de Clientes modificados</returns>
		public async Task<int> UpdateClientesAsync(Clientes source)
		{
			return await _efRepository.UpdateAsync<Clientes>(source);
		}

		/// <summary>
        /// Modifica una instancia de Clientes en la base de datos
        /// </summary>
        /// <param name="source">Clientes a modificar</param>
        /// <returns>Número de Clientes modificados</returns>
		public int UpdateClientes(Clientes source)
		{
			return _efRepository.Update<Clientes>(source);
		}

		/// <summary>
        /// Borra una instancia de Clientes en la base de datos
        /// </summary>
        /// <param name="source">Clientes a borrar</param>
        /// <returns>Número de Clientes borrados</returns>
		public async Task<int> DeleteClientesAsync(Clientes source)
		{
			return await _efRepository.DeleteAsync<Clientes>(source);
		}

		/// <summary>
        /// Borra una instancia de Clientes en la base de datos
        /// </summary>
        /// <param name="source">Clientes a borrar</param>
        /// <returns>Número de Clientes borrados</returns>
		public int DeleteClientes(Clientes source)
		{
			return _efRepository.Delete<Clientes>(source);
		}
    }
}
