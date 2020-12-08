using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public interface IRepositorioDocumentosDNI : IRepositorioDocumentosDNIBase
	{
        DocumentosDNI GetDocumentoDNIByDocumento(int idDocumento);
    }
}
