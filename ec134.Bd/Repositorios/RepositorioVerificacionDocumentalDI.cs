using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public class RepositorioVerificacionDocumentalDI : RepositorioVerificacionDocumentalDIBase, IRepositorioVerificacionDocumentalDI
	{
		public RepositorioVerificacionDocumentalDI (ec134Context dbContext) : base(dbContext)
		{

		}
    }
}
