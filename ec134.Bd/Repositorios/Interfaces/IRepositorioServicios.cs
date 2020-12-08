using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;
using System.Collections.Generic;

namespace ec134.Bd.Repositorios
{
    public interface IRepositorioServicios : IRepositorioServiciosBase
	{
        Servicios GetServicioByIdProductoEIdTipoServicio(int idProducto, int idTipoServicio, string tipoTarjeta);
    }
}
