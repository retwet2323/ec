namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Extensiones
    {
        [ForeignKey("TiposArchivo")]
        public int? IdTipoArchivo { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdExtension { get; set; }

        [StringLength(5)]
        public string Valor { get; set; }

        public virtual TiposArchivo TiposArchivo { get; set; }
    }
}
