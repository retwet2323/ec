using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public class RepositorioConfiguracionAccionSMTP : RepositorioConfiguracionAccionSMTPBase, IRepositorioConfiguracionAccionSMTP
	{
		public RepositorioConfiguracionAccionSMTP (ec134Context dbContext) : base(dbContext)
		{

		}
    }
}
