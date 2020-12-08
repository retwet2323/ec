namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MimeTypes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdMimeType { get; set; }

        [ForeignKey("TiposArchivo")]
        public int? IdTipoArchivo { get; set; }

        [StringLength(150)]
        public string Valor { get; set; }

        public virtual TiposArchivo TiposArchivo { get; set; }
    }
}
