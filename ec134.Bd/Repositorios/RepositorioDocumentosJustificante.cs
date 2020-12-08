using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public class RepositorioDocumentosJustificante : RepositorioDocumentosJustificanteBase, IRepositorioDocumentosJustificante
	{
		public RepositorioDocumentosJustificante (ec134Context dbContext) : base(dbContext)
		{

		}

        public DocumentosJustificante GetDocumentoJustificanteByDocumento(int idDocumento)
        {
            return
                GetDocumentosJustificante()
                .Where(d => d.IdDocumento == idDocumento)
                .FirstOrDefault();
        }

    }
}
