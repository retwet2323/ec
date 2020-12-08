using System;
using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;
using System.Collections.Generic;

namespace ec134.Bd.Repositorios
{
    public class RepositorioVersionesProductos : RepositorioVersionesProductosBase, IRepositorioVersionesProductos
	{
		public RepositorioVersionesProductos (ec134Context dbContext) : base(dbContext)
		{

		}

        public VersionesProductos GetUltimaVersionProductoPorIdProducto(int idProducto)
        {
            return GetVersionesProductosPorIdProducto(idProducto).OrderBy(x => x.Fecha).FirstOrDefault();
        }

        public IQueryable<VersionesProductos> GetVersionesProductosPorIdProducto(int idProducto)
        {
            return GetVersionesProductos().Where(x => x.IdProducto == idProducto);
        }
    }
}
