using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public class RepositorioDocumentosDNI : RepositorioDocumentosDNIBase, IRepositorioDocumentosDNI
	{
		public RepositorioDocumentosDNI (ec134Context dbContext) : base(dbContext)
		{

		}

        public DocumentosDNI GetDocumentoDNIByDocumento(int idDocumento)
        {
            return
                GetDocumentosDNI()
                .Where(d => d.IdDocumento == idDocumento)
                .FirstOrDefault();
        }

    }
}
