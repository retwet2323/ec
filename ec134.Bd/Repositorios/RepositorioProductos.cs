using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;
using Graddo.Common.Db;

namespace ec134.Bd.Repositorios
{
    public class RepositorioProductos : RepositorioProductosBase, IRepositorioProductos
	{

        public RepositorioProductos (ec134Context dbContext) : base(dbContext)
		{


		}
        
        /// <summary>
        /// Obtener un Productos por su clave primaria y su versión
        /// </summary>
        /// <param name="idProducto">IdProducto</param>
        /// <param name="idVersionProducto">IdVersionProducto</param>
        /// <returns>Productos  seleccionado por su clave primaria</returns>
        public async Task<Productos> GetProductosByPrimaryKeyAndVersionProducto(int idProducto, int idVersionProducto)
        {
            return await _efRepository.Filter<Productos>(x => x.IdProducto == idProducto &&  (x.VersionesProductos != null && x.VersionesProductos.Any(y => y.IdVersionProducto == idVersionProducto))).FirstOrDefaultAsync();
        }
    }
}
