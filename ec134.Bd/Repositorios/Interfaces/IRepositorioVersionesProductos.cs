using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public interface IRepositorioVersionesProductos : IRepositorioVersionesProductosBase
    {
        IQueryable<VersionesProductos> GetVersionesProductosPorIdProducto(int idProducto);
        VersionesProductos GetUltimaVersionProductoPorIdProducto(int idProducto);
    }
}
