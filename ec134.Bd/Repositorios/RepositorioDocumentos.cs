using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public class RepositorioDocumentos : RepositorioDocumentosBase, IRepositorioDocumentos
	{
		public RepositorioDocumentos (ec134Context dbContext) : base(dbContext)
		{

		}

        public Documentos GetDocumentoByOperacionSolicitudes(int idOperacion)
        {
            return
                GetDocumentos()
                .Where(d => d.IdOperacion == idOperacion &&  d.IdTipoDocumento == 9001)
                .FirstOrDefault();
        }
    }
}
