namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Opciones
    {
        [Key]
        public int IdOpcion { get; set; }

        [Required]
        [StringLength(250)]
        public string Valor { get; set; }

        [Required]
        [StringLength(500)]
        public string Descripcion { get; set; }

        [ForeignKey("GruposOpciones")]
        public int IdGrupoOpciones { get; set; }

        public virtual GruposOpciones GruposOpciones { get; set; }
    }
}
