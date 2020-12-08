using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public interface IRepositorioProductos : IRepositorioProductosBase
	{
        Task<Productos> GetProductosByPrimaryKeyAndVersionProducto(int idProducto, int idVersionProducto);
	}
}
