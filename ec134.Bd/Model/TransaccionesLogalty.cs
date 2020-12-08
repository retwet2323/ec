namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransaccionesLogalty")]
    public partial class TransaccionesLogalty
    {
        [Key]
        public int IdTransaccionLogalty { get; set; }

        [Required]
        [StringLength(50)]
        [Index(IsUnique = true)]
        public string GuidTransaccion { get; set; }

        [Required]
        [StringLength(50)]
        public string ExternalId { get; set; }

        [ForeignKey("Operaciones")]
        public int? IdOperacion { get; set; }

        public int? IdEstadoLogalty { get; set; }

        [StringLength(500)]
        public string SubEstado { get; set; }

        public DateTime? FechaInicioGUI { get; set; }

        public DateTime? FechaFinal { get; set; }

        public int? IdEstadoLogaltyAdicional { get; set; }

        [StringLength(500)]
        public string SubEstadoAdicional { get; set; }

        public DateTime? FechaInicioGUIAdicional { get; set; }

        public DateTime? FechaFinalAdicional { get; set; }

        [StringLength(500)]
        public string CancelCode { get; set; }

        [StringLength(500)]
        public string CancelReason { get; set; }

        public DateTime Insertado { get; set; }

        public DateTime? FechaDescargaContrato { get; set; }

        public bool DescargaContrato { get; set; }

        public DateTime? FechaDescargaCertificado { get; set; }

        public bool DescargaCertificado { get; set; }

        public virtual EstadosLogalty EstadosLogalty { get; set; }

        public virtual Operaciones Operaciones { get; set; }
    }
}
