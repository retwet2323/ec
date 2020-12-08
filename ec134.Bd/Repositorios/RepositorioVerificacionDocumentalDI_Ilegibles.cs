using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public class RepositorioVerificacionDocumentalDI_Ilegibles : RepositorioVerificacionDocumentalDI_IlegiblesBase, IRepositorioVerificacionDocumentalDI_Ilegibles
	{
		public RepositorioVerificacionDocumentalDI_Ilegibles (ec134Context dbContext) : base(dbContext)
		{

		}
    }
}
