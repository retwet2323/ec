namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VerificacionDocumentalDI")]
    public partial class VerificacionDocumentalDI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VerificacionDocumentalDI()
        {
            VerificacionDocumentalDI_Ilegibles = new HashSet<VerificacionDocumentalDI_Ilegibles>();
            VerificacionDocumentalDI_Resultados = new HashSet<VerificacionDocumentalDI_Resultados>();
        }

        [Key]
        public int IdRespuesta { get; set; }

        public Guid? GuidRespuesta { get; set; }

        public DateTime? FechaRegistroRespuesta { get; set; }

        public DateTime? FechaProcesadoRespuesta { get; set; }

        public int? NumeroDocumentosSalida { get; set; }

        public int? NumeroPaginasProcesadas { get; set; }

        public int? NumeroPaginasValidas { get; set; }

        public string DatosAdicionales { get; set; }

        public string Observaciones { get; set; }

        [StringLength(50)]
        public string Proyecto { get; set; }

        [StringLength(50)]
        public string Proceso { get; set; }

        [StringLength(50)]
        public string Lote { get; set; }

        [StringLength(50)]
        public string VersionDni { get; set; }

        [StringLength(50)]
        public string IdConfiguracion { get; set; }

        public int? IdOrigen { get; set; }

        [StringLength(50)]
        public string VersionOcr { get; set; }

        public int? IdConfiguracionEngine { get; set; }

        [StringLength(50)]
        public string ConfiguracionEngine { get; set; }

        public int? NumeroLineasMinimoDeterminaPaginaValida { get; set; }

        public int? PorcentajeMaximoDeterminaPaginaVacia { get; set; }

        public int? PorcentajeMinimoDeterminaDeteccionDelantera { get; set; }

        public bool? IncluirIncompletosEnResultados { get; set; }

        [StringLength(1000)]
        public string DirectorioTrabajoOcr { get; set; }

        [StringLength(1000)]
        public string DirectorioTrabajoOcrTemporal { get; set; }

        [StringLength(1000)]
        public string DirectorioTrabajoDni { get; set; }

        public int? IdOperacion { get; set; }

        public virtual Operaciones Operaciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VerificacionDocumentalDI_Ilegibles> VerificacionDocumentalDI_Ilegibles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VerificacionDocumentalDI_Resultados> VerificacionDocumentalDI_Resultados { get; set; }
    }
}
