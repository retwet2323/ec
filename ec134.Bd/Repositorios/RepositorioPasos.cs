using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public class RepositorioPasos : RepositorioPasosBase, IRepositorioPasos
	{
		public RepositorioPasos (ec134Context dbContext) : base(dbContext)
		{

		}
    }
}
