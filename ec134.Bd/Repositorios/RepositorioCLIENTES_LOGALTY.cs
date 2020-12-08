
using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public class RepositorioCLIENTES_LOGALTY : RepositorioCLIENTES_LOGALTYBase, IRepositorioCLIENTES_LOGALTY
	{
		public RepositorioCLIENTES_LOGALTY (ec134Context dbContext) : base(dbContext)
		{

		}
    }
}
