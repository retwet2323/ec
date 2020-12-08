namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentosDNI")]
    public partial class DocumentosDNI
    {
        [Key]
        public int IdDocumentoDni { get; set; }

        public int IdDocumento { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(100)]
        public string Apellido1 { get; set; }

        [StringLength(100)]
        public string Apellido2 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Caducidad { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaNacimiento { get; set; }

        [StringLength(1)]
        public string Sexo { get; set; }

        [StringLength(50)]
        public string TipoFormulario { get; set; }

        [StringLength(10)]
        public string DNI { get; set; }

        public virtual Documentos Documentos { get; set; }
    }
}
