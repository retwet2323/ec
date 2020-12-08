namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransaccionesDasNano")]
    public partial class TransaccionesDasNano
    {
        [Key]
        public int IdTransaccionDasNano { get; set; }

        public int IdOperacion { get; set; }

        [Required]
        [StringLength(50)]
        [Index(IsUnique = true)]
        public string GuidDasNano { get; set; }

        public bool Cancelada { get; set; }

        [Column(TypeName = "text")]
        public string ResultadoOCR { get; set; }

        [Column(TypeName = "text")]
        public string ResultadoScores { get; set; }

        public DateTime FechaRegistro { get; set; }

        public bool Recovery  { get; set; }

        public ICollection<ValidacionesDasNano> ValidacionesDasNano { get; set; } 
        public ICollection<DatosDasNano> DatosDasNano { get; set; }
        public ICollection<LogsDasNano> LogsDasNano { get; set; }
    }
}
