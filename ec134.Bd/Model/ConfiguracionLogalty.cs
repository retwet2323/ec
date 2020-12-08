namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConfiguracionLogalty")]
    public partial class ConfiguracionLogalty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ConfiguracionLogalty()
        {
            Servicios = new HashSet<Servicios>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdConfiguracionLogalty { get; set; }

        public int IdCampoNombre { get; set; }

        public int IdCampoApellido1 { get; set; }

        public int IdCampoApellido2 { get; set; }

        public int IdCampoNumeroDocumento { get; set; }

        public int IdCampoEmail { get; set; }

        public int IdCampoTelefono { get; set; }

        public int IdCampoGUID { get; set; }

        public int IdCampoUUID { get; set; }

        public int IdCampoFirma { get; set; }

        public int? IdCampoNombreAdicional { get; set; }

        public int? IdCampoApellido1Adicional { get; set; }

        public int? IdCampoApellido2Adicional { get; set; }

        public int? IdCampoNumeroDocumentoAdicional { get; set; }

        public int? IdCampoTelefonoAdicional { get; set; }

        public int? IdCampoGUIDAdicional { get; set; }

        public int? IdCampoUUIDAdicional { get; set; }

        public int? IdCampoFirmaAdicional { get; set; }

        [Required]
        [StringLength(500)]
        public string PathArchivoPFX { get; set; }

        [Required]
        [StringLength(500)]
        public string PasswordArchivoPFX { get; set; }

        [Required]
        [StringLength(500)]
        public string Issuer { get; set; }

        [Required]
        [StringLength(500)]
        public string UrlBack { get; set; }

        [Required]
        [StringLength(500)]
        public string UrlLogalty { get; set; }

        [StringLength(500)]
        public string UrlSamlLogin { get; set; }

        public bool AutoRedirect { get; set; }

        public bool DocInFrame { get; set; }

        public int? IdDocumentoPlantilla { get; set; }

        [StringLength(500)]
        public string EmailRespuesta { get; set; }

        public int? IdCampoContratoFirmado { get; set; }

        public int? IdCampoCertificado { get; set; }

        public virtual DocumentosPlantillas DocumentosPlantillas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servicios> Servicios { get; set; }
    }
}
