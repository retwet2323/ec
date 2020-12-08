namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentosCUE")]
    public partial class DocumentosCUE
    {
        [Key]
        public int IdDocumentoCUE { get; set; }

        public int IdDocumento { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string Apellido1 { get; set; }

        [StringLength(50)]
        public string Apellido2 { get; set; }

        [StringLength(50)]
        public string DNI { get; set; }

        public virtual Documentos Documentos { get; set; }
    }
}
