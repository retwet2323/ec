using System;
using Graddo.Common.Db;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;

namespace ec134.Bd.Repositorios.Base
{
    public interface IRepositorioVerificacionDocumentalDI_ResultadosBase
	{
		/// <summary>
        /// Metodo para obtener todos los VerificacionDocumentalDI_Resultados 
        /// </summary>
        /// <returns>IQueryable con todos los VerificacionDocumentalDI_Resultados</returns>
		IQueryable<VerificacionDocumentalDI_Resultados> GetVerificacionDocumentalDI_Resultados();
		
        
        /// <summary>
        /// Obtener un VerificacionDocumentalDI_Resultados por su clave primaria
        /// </summary>
				/// <param name="idResultado">IdResultado</param>
		        /// <returns>VerificacionDocumentalDI_Resultados   seleccionado por su clave primaria</returns>
		Task<VerificacionDocumentalDI_Resultados> GetVerificacionDocumentalDI_ResultadosByPrimaryKeyAsync(int idResultado);
		
        /// <summary>
        /// Obtener un VerificacionDocumentalDI_Resultados por su clave primaria
        /// </summary>
				/// <param name="idResultado">IdResultado</param>
		        /// <returns>VerificacionDocumentalDI_Resultados  seleccionado por su clave primaria</returns>
		VerificacionDocumentalDI_Resultados GetVerificacionDocumentalDI_ResultadosByPrimaryKey(int idResultado);


        


		/// <summary>
        /// Crea una instancia de VerificacionDocumentalDI_Resultados en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI_Resultados a crear</param>
        /// <returns>VerificacionDocumentalDI_Resultados creado</returns>
		Task<VerificacionDocumentalDI_Resultados> CreateVerificacionDocumentalDI_ResultadosAsync(VerificacionDocumentalDI_Resultados source);

		/// <summary>
        /// Crea una instancia de VerificacionDocumentalDI_Resultados en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI_Resultados a crear</param>
        /// <returns>VerificacionDocumentalDI_Resultados creado</returns>
		VerificacionDocumentalDI_Resultados CreateVerificacionDocumentalDI_Resultados(VerificacionDocumentalDI_Resultados source);


		/// <summary>
        /// Modifica una instancia de VerificacionDocumentalDI_Resultados en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI_Resultados a modificar</param>
        /// <returns>Número de VerificacionDocumentalDI_Resultados modificados</returns>
		Task<int> UpdateVerificacionDocumentalDI_ResultadosAsync(VerificacionDocumentalDI_Resultados source);
		

		/// <summary>
        /// Modifica una instancia de VerificacionDocumentalDI_Resultados en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI_Resultados a modificar</param>
        /// <returns>Número de VerificacionDocumentalDI_Resultados modificados</returns>
		int UpdateVerificacionDocumentalDI_Resultados(VerificacionDocumentalDI_Resultados source);

		/// <summary>
        /// Borra una instancia de VerificacionDocumentalDI_Resultados en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI_Resultados a borrar</param>
        /// <returns>Número de VerificacionDocumentalDI_Resultados borrados</returns>
		Task<int> DeleteVerificacionDocumentalDI_ResultadosAsync(VerificacionDocumentalDI_Resultados source);
		
		/// <summary>
        /// Borra una instancia de VerificacionDocumentalDI_Resultados en la base de datos
        /// </summary>
        /// <param name="source">VerificacionDocumentalDI_Resultados a borrar</param>
        /// <returns>Número de VerificacionDocumentalDI_Resultados borrados</returns>
		int DeleteVerificacionDocumentalDI_Resultados(VerificacionDocumentalDI_Resultados source);
    }
}
