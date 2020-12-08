using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ec134.Bd.Model.Enum
{
    enum EstadosLogalty:int
    {
        PeticionCorrecta = 0,
        Aceptado = 7,
        Rechazado = 8,
        DocumentoNoDisponible = 9,
        AceptacionParcial = 16,
        ErrorDocumentoFormatoIncorrecto = 100,
        ErrorGenericoDocumento = 200,
        ErrorFirmaXmlIncorrecta = 300,
        ErrorDocumentoDatosProcesoIncorrecto = 400,
        ErrorTransaccionCerrada = 500,
        ErrorServicioNoDisponible = 600,
        ErrorDireccionRemotaIncorrecta = 700,
        ErrorFirmaYaRalizada = 800,
        ErrorSystemInGlobalSuspend = 900,
        ErrorConexion = 999,
        ErrorFileExtensionMissing = 1000,
        ErrorProcessNotAllowed = 1100,
        ErrorInvalidSignature = 1200,
        ErrorSignatureNotFound = 1300,
        ErrorLogCollectionNotAllowed = 1400,
        ErrorCustodyExpired = 1500,
        ErrorContractDisabled = 1600,
        FirmaNoRealizada = 10006,
        ErrorDatos = 99901,
        ErrorAvisoReceptor = 99903,
        ErrorPin = 99904,
        TiempoExpirado = 99906,
        CerradoPorEmisor = 99932,
        ErrorDatosIncompletos = 99998,
        ErrorSoloUnGuidPermitido = 99999,
    }
}
