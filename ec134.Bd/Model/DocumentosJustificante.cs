namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentosJustificante")]
    public partial class DocumentosJustificante
    {
        [Key]
        public int IdDocumentoJustificante { get; set; }

        public int IdDocumento { get; set; }

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

        public int? IdTipoJustificante { get; set; }

        [StringLength(1)]
        public string NIF3 { get; set; }

        public virtual Documentos Documentos { get; set; }
    }
}
