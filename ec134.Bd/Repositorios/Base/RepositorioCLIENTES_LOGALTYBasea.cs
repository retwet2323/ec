
using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public class RepositorioCLIENTES_LOGALTYBase : IRepositorioCLIENTES_LOGALTYBase
	{
		protected readonly EFRepository _efRepository;

		/// <summary>
        /// Constructor de la clase CLIENTES_LOGALTY 
        /// </summary>
		public RepositorioCLIENTES_LOGALTYBase(ec134Context dbContext)
		{
			_efRepository = new EFRepository(dbContext);
		}

		/// <summary>
        /// Metodo para obtener todos los CLIENTES_LOGALTY 
        /// </summary>
        /// <returns>IQueryable con todos los CLIENTES_LOGALTY</returns>
		public IQueryable<CLIENTES_LOGALTY> GetCLIENTES_LOGALTY()
		{
			return _efRepository.All<CLIENTES_LOGALTY>();
		}


        /// <summary>
        /// Obtener un CLIENTES_LOGALTY por su clave primaria
        /// </summary>
        /// <param name="idCliente">IdCliente</param>
        /// <returns>CLIENTES_LOGALTY   seleccionado por su clave primaria</returns>
        public async Task<CLIENTES_LOGALTY> GetCLIENTES_LOGALTYByPrimaryKeyAsync(int idCliente)
		{
			return await _efRepository.FindAsync<CLIENTES_LOGALTY>(x=>x.IdCliente == idCliente);
		}

        /// <summary>
        /// Obtener un CLIENTES_LOGALTY por su clave primaria
        /// </summary>
		/// <param name="idCliente">idCliente</param>
        /// <returns>CLIENTES_LOGALTY  seleccionado por su clave primaria</returns>
		public CLIENTES_LOGALTY GetCLIENTES_LOGALTYByPrimaryKey(int idCliente)
		{
			return _efRepository.Find<CLIENTES_LOGALTY>(x=>x.IdCliente == idCliente);
		}




		/// <summary>
        /// Crea una instancia de CLIENTES_LOGALTY en la base de datos
        /// </summary>
        /// <param name="source">CLIENTES_LOGALTY a crear</param>
        /// <returns>CLIENTES_LOGALTY creado</returns>
		public virtual async Task<CLIENTES_LOGALTY> CreateCLIENTES_LOGALTYAsync(CLIENTES_LOGALTY source)
		{
			return await _efRepository.CreateAsync<CLIENTES_LOGALTY>(source);
		}

		/// <summary>
        /// Crea una instancia de CLIENTES_LOGALTY en la base de datos
        /// </summary>
        /// <param name="source">CLIENTES_LOGALTY a crear</param>
        /// <returns>CLIENTES_LOGALTY creado</returns>
		public virtual CLIENTES_LOGALTY CreateCLIENTES_LOGALTY(CLIENTES_LOGALTY source)
		{
			return _efRepository.Create<CLIENTES_LOGALTY>(source);
		}


		/// <summary>
        /// Modifica una instancia de CLIENTES_LOGALTY en la base de datos
        /// </summary>
        /// <param name="source">CLIENTES_LOGALTY a modificar</param>
        /// <returns>Número de CLIENTES_LOGALTY modificados</returns>
		public async Task<int> UpdateCLIENTES_LOGALTYAsync(CLIENTES_LOGALTY source)
		{
			return await _efRepository.UpdateAsync<CLIENTES_LOGALTY>(source);
		}

		/// <summary>
        /// Modifica una instancia de CLIENTES_LOGALTY en la base de datos
        /// </summary>
        /// <param name="source">CLIENTES_LOGALTY a modificar</param>
        /// <returns>Número de CLIENTES_LOGALTY modificados</returns>
		public int UpdateCLIENTES_LOGALTY(CLIENTES_LOGALTY source)
		{
			return _efRepository.Update<CLIENTES_LOGALTY>(source);
		}

		/// <summary>
        /// Borra una instancia de CLIENTES_LOGALTY en la base de datos
        /// </summary>
        /// <param name="source">CLIENTES_LOGALTY a borrar</param>
        /// <returns>Número de CLIENTES_LOGALTY borrados</returns>
		public async Task<int> DeleteCLIENTES_LOGALTYAsync(CLIENTES_LOGALTY source)
		{
			return await _efRepository.DeleteAsync<CLIENTES_LOGALTY>(source);
		}

		/// <summary>
        /// Borra una instancia de CLIENTES_LOGALTY en la base de datos
        /// </summary>
        /// <param name="source">CLIENTES_LOGALTY a borrar</param>
        /// <returns>Número de CLIENTES_LOGALTY borrados</returns>
		public int DeleteCLIENTES_LOGALTY(CLIENTES_LOGALTY source)
		{
			return _efRepository.Delete<CLIENTES_LOGALTY>(source);
		}
    }
}
