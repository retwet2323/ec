namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NumerosMagicos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdNumeroMagico { get; set; }

        [ForeignKey("TiposArchivo")]
        public int IdTipoArchivo { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(250)]
        public string Hexadecimal { get; set; }

        public virtual TiposArchivo TiposArchivo { get; set; }
    }
}
