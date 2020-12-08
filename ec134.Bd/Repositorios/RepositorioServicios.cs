using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;
using System.Collections.Generic;

namespace ec134.Bd.Repositorios
{
    public class RepositorioServicios : RepositorioServiciosBase, IRepositorioServicios
	{
		public RepositorioServicios (ec134Context dbContext) : base(dbContext)
		{
           
		}

        public Servicios GetServicioByIdProductoEIdTipoServicio(int idProducto, int idTipoServicio, string tipoTarjeta)
        {

            var servicios = GetServicios()
                .Where(servicio =>
                    servicio.IdTipoServicio == idTipoServicio
                    && servicio.Productos.Any(producto => producto.IdProducto == idProducto));

            if (!string.IsNullOrEmpty(tipoTarjeta))
                return servicios.Where(s=> s.Descripcion.EndsWith(tipoTarjeta)).FirstOrDefault();
            else
                return servicios.FirstOrDefault();
            

        }



    }
}
