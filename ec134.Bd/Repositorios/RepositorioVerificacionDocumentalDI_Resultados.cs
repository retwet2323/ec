using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public class RepositorioVerificacionDocumentalDI_Resultados : RepositorioVerificacionDocumentalDI_ResultadosBase, IRepositorioVerificacionDocumentalDI_Resultados
	{
		public RepositorioVerificacionDocumentalDI_Resultados (ec134Context dbContext) : base(dbContext)
		{

		}
    }
}
