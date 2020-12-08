using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;
using System.Collections;

namespace ec134.Bd.Repositorios
{
    public class RepositorioConfiguracionLogalty : RepositorioConfiguracionLogaltyBase, IRepositorioConfiguracionLogalty
    {
        private readonly RepositorioServicios _repositorioServicios;
        public RepositorioConfiguracionLogalty(ec134Context dbContext) : base(dbContext)
        {
            _repositorioServicios = new RepositorioServicios(dbContext);
        }

        public ConfiguracionLogalty GetConfiguracionLogaltyPorIdProducto(int idProducto, string tipoTarjeta)
        {
            var servicio = _repositorioServicios.GetServicioByIdProductoEIdTipoServicio(idProducto, 4, tipoTarjeta);
            if (servicio?.IdConfiguracionServicio != null)
                return GetConfiguracionLogaltyByPrimaryKey(servicio.IdConfiguracionServicio.Value);
            else
                return null;
        }
    }
}
