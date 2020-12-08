using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public class RepositorioCamposProductos : RepositorioCamposProductosBase, IRepositorioCamposProductos
	{
		public RepositorioCamposProductos (ec134Context dbContext) : base(dbContext)
		{

		}
        
        public CamposProductos GetCampoPorductoPorIdProductoYNombreCampo(int idProducto, string nombreCampoProducto)
        {
            return GetCamposProductos().Where(valor => valor.IdProducto == idProducto && valor.Nombre == nombreCampoProducto).FirstOrDefault();
        }

        public IQueryable<CamposProductos> GetCamposProductosEscritosPorParametro(int idProducto)
        {
            return GetCamposProductosByIdProducto(idProducto).Where(camposProducto => camposProducto.EscribirPorParametro);
        }
    }
}
