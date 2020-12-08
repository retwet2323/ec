using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public class RepositorioConfiguracionDasNano : RepositorioConfiguracionDasNanoBase, IRepositorioConfiguracionDasNano
	{
        private readonly IRepositorioServicios _repositorioServicios;
        
		public RepositorioConfiguracionDasNano (ec134Context dbContext) : base(dbContext)
		{
            _repositorioServicios = new RepositorioServicios(dbContext);

        }

        public ConfiguracionDasNano GetConfiguracionDasNanoPorIdProducto(int idProducto)
        {
            var servicio = _repositorioServicios.GetServicioByIdProductoEIdTipoServicio(idProducto, 8, string.Empty);
            if (servicio?.IdConfiguracionServicio != null)
                return GetConfiguracionDasNanoByPrimaryKey(servicio.IdConfiguracionServicio.Value);
            else
                return null;
        }
    }
}
