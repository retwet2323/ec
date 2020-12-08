
using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public class RepositorioAcciones : RepositorioAccionesBase, IRepositorioAcciones
	{
		public RepositorioAcciones (ec134Context dbContext) : base(dbContext)
		{

		}
    }
}
