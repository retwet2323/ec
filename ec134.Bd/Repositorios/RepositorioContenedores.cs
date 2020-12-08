using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public class RepositorioContenedores : RepositorioContenedoresBase, IRepositorioContenedores
	{
		public RepositorioContenedores (ec134Context dbContext) : base(dbContext)
		{

		}
    }
}
