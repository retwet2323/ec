using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public class RepositorioDocumentosCUE : RepositorioDocumentosCUEBase, IRepositorioDocumentosCUE
    {
		public RepositorioDocumentosCUE (ec134Context dbContext) : base(dbContext)
		{

		}

        public DocumentosCUE GetDocumentoCUEByDocumento(int idDocumento)
        {
            return
                GetDocumentosCUE()
                .Where(d => d.IdDocumento == idDocumento)
                .FirstOrDefault();
        }

    }
}
