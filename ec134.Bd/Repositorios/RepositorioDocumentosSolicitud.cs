using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;
using System;
using ec134.Bd.Model.Enum;
using System.Collections.Generic;

namespace ec134.Bd.Repositorios
{
    public class RepositorioDocumentosSolicitud : RepositorioDocumentosSolicitudBase, IRepositorioDocumentosSolicitud
    {
		public RepositorioDocumentosSolicitud(ec134Context dbContext) : base(dbContext)
		{

		}

        public DocumentosSolicitud GetDocumentoSolicitudByDocumento(int idDocumento)
        {
            return
                GetDocumentosSolicitud()
                .Where(d => d.IdDocumento == idDocumento)
                .FirstOrDefault();
        }

        public IEnumerable<DocumentosSolicitud> GetOperacionesWithSignature(int idProducto)
        {
            var fechaFin = DateTime.Now.AddHours(-30);
            return GetDocumentosSolicitud().Where(ds =>
         (ds.IdTipoEstado == (int)EstadosSolicitud.Denegada ||
          ds.IdTipoEstado == (int)EstadosSolicitud.EnviadoFinanziaNET ||
          ds.IdTipoEstado == (int)EstadosSolicitud.ImposibleProceso ||
          ds.IdTipoEstado == (int)EstadosSolicitud.Desestimada ||
          ds.IdTipoEstado == (int)EstadosSolicitud.Duplicada) &&
          ds.IdTipoSolicitud != (int)TiposSolicitud.Inactiva &&
          ds.Documentos.Operaciones.Firmada &&
          ds.Documentos.Operaciones.IdProducto == idProducto &&
          ds.FxUltimoEstado != null && ds.FxUltimoEstado <= fechaFin);

        }

        public IEnumerable<DocumentosSolicitud> GetOperacionesWithOutSignature(int idProducto)
        {

            return GetDocumentosSolicitud().Where(ds =>
       
          ds.IdTipoSolicitud != (int)TiposSolicitud.Nofirmada &&
          !ds.Documentos.Operaciones.Firmada &&
          ds.Documentos.Operaciones.IdProducto == idProducto &&
          ds.Documentos.Operaciones.FechaCaducidad != null && ds.Documentos.Operaciones.FechaCaducidad >= DateTime.Now);

        }
    }
}
