namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VerificacionDocumentalDI_Resultados
    {
        [Key]
        public int IdResultado { get; set; }

        public int IdRespuesta { get; set; }

        public Guid? GuidResultado { get; set; }

        public Guid? GuidRespuesta { get; set; }

        public DateTime? FechaRegistroResultado { get; set; }

        public string RutaImagen { get; set; }

        public int? IdTipoDocumento { get; set; }

        [StringLength(50)]
        public string TipoDocumentoSalida { get; set; }

        public string Identificador { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaNacimientoSalida { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaCaducidadSalida { get; set; }

        [StringLength(50)]
        public string Soporte { get; set; }

        public string Nombre { get; set; }

        public string PrimerApellido { get; set; }

        public string SegundoApellido { get; set; }

        public string Apellidos { get; set; }

        public int? IdPaisEmisor { get; set; }

        [StringLength(3)]
        public string PaisEmisor { get; set; }

        [StringLength(50)]
        public string Sexo { get; set; }

        public int? IdPaisNacionalidad { get; set; }

        [StringLength(3)]
        public string Nacionalidad { get; set; }

        [StringLength(50)]
        public string Comienzo { get; set; }

        public string TextoMrz { get; set; }

        public string Mrz1 { get; set; }

        public string Mrz2 { get; set; }

        public string Mrz3 { get; set; }

        public string TextoCompleto { get; set; }

        public string TextoDelantera { get; set; }

        public string TextoTrasera { get; set; }

        public string TextoSinMrz { get; set; }

        public string TextoTraseraSinMrz { get; set; }

        public string TextoMrzOpcional { get; set; }

        public bool? ControlLetraIdentificador { get; set; }

        public bool? CoincideSoporte { get; set; }

        public bool? CoincideIdentificador { get; set; }

        public bool? CoincideFechaNacimiento { get; set; }

        public bool? CoincideSexo { get; set; }

        public bool? CoincideFechaCaducidad { get; set; }

        public bool? CoincideNombreApellidos { get; set; }

        public bool? ExistePais { get; set; }

        public bool? ExisteNacionalidad { get; set; }

        public bool? ControlDcSoporte { get; set; }

        public bool? ControlDcIdentificador { get; set; }

        public bool? ControlDcFechaNacimiento { get; set; }

        public bool? ControlDcFechaCaducidad { get; set; }

        public bool? ControlDcMrz { get; set; }

        public bool? ControlDcMrzOpcional { get; set; }

        [StringLength(2)]
        public string Dc1 { get; set; }

        [StringLength(2)]
        public string Dc2 { get; set; }

        [StringLength(2)]
        public string Dc3 { get; set; }

        [StringLength(2)]
        public string Dc4 { get; set; }

        [StringLength(2)]
        public string Dc5 { get; set; }

        [StringLength(2)]
        public string Dc1Resultado { get; set; }

        [StringLength(2)]
        public string Dc2Resultado { get; set; }

        [StringLength(2)]
        public string Dc3Resultado { get; set; }

        [StringLength(2)]
        public string Dc4Resultado { get; set; }

        [StringLength(2)]
        public string Dc5Resultado { get; set; }

        public bool? DocumentoNoEsp { get; set; }

        public bool? Dictamen { get; set; }

        public string Error { get; set; }

        public string NombreImagenDelantera { get; set; }

        public string NombreImagenTrasera { get; set; }

        public int? IdCara { get; set; }

        public string Mrz1f { get; set; }

        public string Mrz2f { get; set; }

        public string Mrz3f { get; set; }

        public string Mascara1 { get; set; }

        public string Mascara2 { get; set; }

        public int? Edad { get; set; }

        [StringLength(50)]
        public string IdDocumento { get; set; }

        public bool? DocumentoIncompleto { get; set; }

        public bool? ControlCaducado { get; set; }

        public bool? ControlLimiteEdad { get; set; }

        public virtual VerificacionDocumentalDI VerificacionDocumentalDI { get; set; }
    }
}
