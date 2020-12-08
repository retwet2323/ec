namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentosSolicitud")]
    public partial class DocumentosSolicitud
    {

        [Key]
        public int IdDocumentoSolicitud { get; set; }

        public int IdDocumento { get; set; }

        public bool? ExistenIngresos { get; set; }

        public bool? CheckCorrecto { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string Apellido1 { get; set; }

        [StringLength(50)]
        public string Apellido2 { get; set; }

        [StringLength(1)]
        public string NIF1 { get; set; }

        [StringLength(8)]
        public string NIF2 { get; set; }

        [StringLength(1)]
        public string NIF3 { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(4)]
        public string IBAN { get; set; }

        [StringLength(4)]
        public string Entidad { get; set; }

        [StringLength(4)]
        public string Oficina { get; set; }

        [StringLength(2)]
        public string DC { get; set; }

        public int? IdTipoSolicitud { get; set; }

        public int? IdTipoEstado { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FxFirma { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FxContratacion { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FxUltimoEstado { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FxAnonimiza { get; set; }

        [StringLength(80)]
        public string Notas { get; set; }

        [StringLength(10)]
        public string NumCuenta { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FxRegistroOperacion { get; set; }

        public string PAN { get; set; }

        [StringLength(500)]
        public string Genero { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaNacimiento { get; set; }

        [StringLength(500)]
        public string CiudadNacimiento { get; set; }

        [StringLength(500)]
        public string PaisNacimiento { get; set; }

        [StringLength(500)]
        public string Nacionalidad { get; set; }

        [StringLength(500)]
        public string EstadoCivil { get; set; }

        public int? PersonasCargo { get; set; }

        [StringLength(500)]
        public string Via { get; set; }

        [StringLength(500)]
        public string NombreVia { get; set; }

        [StringLength(500)]
        public string Numero { get; set; }

        [StringLength(500)]
        public string Portal { get; set; }

        [StringLength(500)]
        public string Bloque { get; set; }

        [StringLength(500)]
        public string Escalera { get; set; }

        [StringLength(500)]
        public string Piso { get; set; }

        [StringLength(500)]
        public string Puerta { get; set; }

        [StringLength(500)]
        public string RestoDomicilio { get; set; }

        [StringLength(500)]
        public string CodigoPostal { get; set; }

        [StringLength(500)]
        public string Localidad { get; set; }

        [StringLength(500)]
        public string CPProvincia { get; set; }

        [StringLength(500)]
        public string Provincia { get; set; }

        [StringLength(500)]
        public string Telefono { get; set; }

        [StringLength(500)]
        public string Ocupacion { get; set; }

        [StringLength(500)]
        public string TipoContrato { get; set; }

        [StringLength(500)]
        public string Profesion { get; set; }

        [StringLength(500)]
        public string Organismo { get; set; }

        [StringLength(500)]
        public string NombreEmpresa { get; set; }

        [StringLength(500)]
        public string NombreOrganismo { get; set; }

        [StringLength(500)]
        public string ActividadEmpresa { get; set; }

        [StringLength(500)]
        public string ActividadOrganismo { get; set; }

        public int? Antiguedad { get; set; }

        public int? AntiguedadOrganismo { get; set; }

        [StringLength(500)]
        public string DireccionEmpresa { get; set; }

        [StringLength(500)]
        public string DireccionOrganismo { get; set; }

        [StringLength(500)]
        public string PoblacionEmpresa { get; set; }

        [StringLength(500)]
        public string PoblacionOrganismo { get; set; }

        [StringLength(500)]
        public string ProvinciaEmpresa { get; set; }

        [StringLength(500)]
        public string ProvinciaOrganismo { get; set; }

        [StringLength(500)]
        public string TelefonoEmpresa { get; set; }

        [StringLength(500)]
        public string TelefonoOrganismo { get; set; }

        [StringLength(500)]
        public string CausaPension { get; set; }

        [StringLength(500)]
        public string TipoRenta { get; set; }

        [StringLength(500)]
        public string OcupacionConyuge { get; set; }

        [StringLength(500)]
        public string IngresosMensuales { get; set; }

        [StringLength(500)]
        public string ModalidadPago { get; set; }

        [StringLength(500)]
        public string Iban0 { get; set; }

        [StringLength(500)]
        public string Iban1 { get; set; }

        [StringLength(500)]
        public string Iban2 { get; set; }

        [StringLength(500)]
        public string Iban3 { get; set; }

        [StringLength(500)]
        public string Iban4 { get; set; }

        [StringLength(500)]
        public string Iban5 { get; set; }

        [StringLength(500)]
        public string Marcas_AceptoSeguro { get; set; }

        public bool? Marca_AceptaCondiciones { get; set; }

        public bool? Marcas_GestionarSolicitudTarjeta { get; set; }

        public bool? Marca_INE { get; set; }

        public bool? Marca_PoliticaProteccionDatosPersonales { get; set; }

        public bool? Marca_TratarDatosBBVA { get; set; }

        public bool? Marca_ComunicarDatosBBVA { get; set; }

        public bool? Marca_TratarDatosCalidadBBVA { get; set; }

        public bool? Marca_TratarDatosPatner { get; set; }

        public bool? Marca_ComunicarDatosPArtner { get; set; }

        public bool? Marca_DatosCalidadPartner { get; set; }

        public bool? Marca_CondicionesGenerales { get; set; }

        public bool? Marca_DeclaracionActividad { get; set; }

        public bool? Marcas_AceptoVideoIdentificacion { get; set; }

        [StringLength(500)]
        public string CodigoCliente { get; set; }

        [StringLength(500)]
        public string CodigoSAE { get; set; }

        [StringLength(500)]
        public string CodigoCaptador { get; set; }

        [StringLength(500)]
        public string CodigoEmpleado { get; set; }

        [StringLength(500)]
        public string AceptoPrepago { get; set; }

        public int? CNAE { get; set; }

        public int? CNO { get; set; }

        public int? IdMotivoDenegada { get; set; }

        public virtual Documentos Documentos { get; set; }

        public virtual TiposEstadosSolicitud TiposEstadosSolicitud { get; set; }
    }
}
