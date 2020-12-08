using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public class RepositorioTransaccionesDasNano : RepositorioTransaccionesDasNanoBase, IRepositorioTransaccionesDasNano
	{
		public RepositorioTransaccionesDasNano (ec134Context dbContext) : base(dbContext)
		{

		}
    }
}
