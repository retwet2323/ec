using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public class RepositorioFormularios : RepositorioFormulariosBase, IRepositorioFormularios
	{
		public RepositorioFormularios (ec134Context dbContext) : base(dbContext)
		{
            
        }

        public Formularios GetPrimerFormularioProductoPorIdProducto(int idProducto)
        {
            return 
                GetFormulariosPorIdProducto(idProducto)
                .Where(x => (x.Inicial ?? false))
                .FirstOrDefault();
        }

        public Formularios GetPrimerFormularioSMTPProductoPorIdProducto(int idProducto)
        {
            return
                GetFormulariosPorIdProducto(idProducto)
                .Where(x => (x.InicialSMTP?? false))
                .FirstOrDefault();
        }

        public IQueryable<Formularios> GetFormulariosPorIdProducto(int idProducto)
        {
            return 
                GetFormularios()
                .Where(x => x.IdProducto == idProducto);
        }
    }
}
