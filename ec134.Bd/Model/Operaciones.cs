namespace ec134.Bd.Model
{
    using ec134.Bd.Model.Enum;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Operaciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Operaciones()
        {
            Documentos = new HashSet<Documentos>();
            InfoOrigenes = new HashSet<InfoOrigenes>();
            RegistrosOperaciones = new HashSet<RegistrosOperaciones>();
            TransaccionesDasNano = new HashSet<TransaccionesDasNano>();
            TransaccionesLogalty = new HashSet<TransaccionesLogalty>();
            ValoresOperaciones = new HashSet<ValoresOperaciones>();
            VerificacionDocumentalDI = new HashSet<VerificacionDocumentalDI>();
        }

        [Key]
        public int IdOperacion { get; set; }

        public int IdProducto { get; set; }

        public int IdEstadoOperacion { get; set; }

        public int IdTipoIdentificador { get; set; }

        [Required]
        [StringLength(100)]
        public string Identificador { get; set; }

        public bool Validada { get; set; }

        public bool Firmada { get; set; }

        public bool Archivada { get; set; }

        [Required]
        [StringLength(500)]
        public string Clave { get; set; }

        public DateTime FechaRegistro { get; set; }

        [StringLength(5)]
        public string CodigoIdioma { get; set; }

        [StringLength(500)]
        public string ClaveSMS { get; set; }

        [StringLength(500)]
        public string ClaveSMTP { get; set; }

        [StringLength(100)]
        public string GuidLogalty { get; set; }

        public int? IdVersionProducto { get; set; }

        public DateTime? FechaCaducidad { get; set; }

        public int? IdDespliegue { get; set; }

        public DateTime? EnvioRecordatorio { get; set; }

        public DateTime? Anonimizado { get; set; }

        public AvisoMail? AvisoMail { get; set; }

        public bool? AvisoDenegada { get; set; }

        public bool? Regularizada { get; set; }

        public int? IdOperacionExpiratus { get; set; }

        public bool VideoAffinity { get; set; }

        [StringLength(250)]
        public string TipoTarjeta { get; set; }

        public virtual EstadosOperaciones EstadosOperaciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoOrigenes> InfoOrigenes { get; set; }

        public virtual Productos Productos { get; set; }

        public virtual TiposIdentificador TiposIdentificador { get; set; }

        public virtual VersionesProductos VersionesProductos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documentos> Documentos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistrosOperaciones> RegistrosOperaciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransaccionesDasNano> TransaccionesDasNano { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransaccionesLogalty> TransaccionesLogalty { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValoresOperaciones> ValoresOperaciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VerificacionDocumentalDI> VerificacionDocumentalDI { get; set; }
    }
}
