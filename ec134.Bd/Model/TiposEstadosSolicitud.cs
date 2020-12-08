namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TiposEstadosSolicitud")]
    public partial class TiposEstadosSolicitud
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TiposEstadosSolicitud()
        {
            DocumentosSolicitud = new HashSet<DocumentosSolicitud>();
        }

        [Key]
        public int IdTipoEstado { get; set; }

        [Required]
        [StringLength(50)]
        public string Denominacion { get; set; }

        public int idRol { get; set; }

        [StringLength(1)]
        public string EsFinal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentosSolicitud> DocumentosSolicitud { get; set; }
    }
}
