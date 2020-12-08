using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;
using System.Collections.Generic;

namespace ec134.Bd.Repositorios
{
    public interface IRepositorioDocumentosSolicitud : IRepositorioDocumentosSolicitudBase
	{
        DocumentosSolicitud GetDocumentoSolicitudByDocumento(int idDocumento);
        IEnumerable<DocumentosSolicitud> GetOperacionesWithSignature(int idProducto);
        IEnumerable<DocumentosSolicitud> GetOperacionesWithOutSignature(int idProducto);
    }
}
