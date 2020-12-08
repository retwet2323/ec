using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public class RepositorioDocumentosPlantillas : RepositorioDocumentosPlantillasBase, IRepositorioDocumentosPlantillas
	{
		public RepositorioDocumentosPlantillas (ec134Context dbContext) : base(dbContext)
		{

		}
    }
}
