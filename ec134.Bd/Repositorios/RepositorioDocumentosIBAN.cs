using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public class RepositorioDocumentosIBAN : RepositorioDocumentosIBANBase, IRepositorioDocumentosIBAN
	{
		public RepositorioDocumentosIBAN (ec134Context dbContext) : base(dbContext)
		{

		}

        public DocumentosIBAN GetDocumentoIBANByDocumento(int idDocumento)
        {
            return
                GetDocumentosIBAN()
                .Where(d => d.IdDocumento == idDocumento)
                .FirstOrDefault();
        }


    }
}
