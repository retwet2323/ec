namespace ec134.Bd.Model
{
    using ec134.Bd.Model.Enum;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ValidacionesDasNano")]
    public partial class ValidacionesDasNano
    {
        [Key]
        public int IdValidacionDasNano { get; set; }

        [ForeignKey("TransaccionesDasNano")]
        public int IdTransaccionDasNano { get; set; }

        public bool? MismaPersona { get; set; }

        public bool? ComportamientoSospechoso { get; set; }

        public bool? GrabacionOptima { get; set; }

        public bool? PersonaViva { get; set; }

        public bool? MismoDocumento { get; set; }

        public EstadosTransacciones Estado { get; set; }

        [StringLength(100)]
        public string Motivo { get; set; }

        public TransaccionesDasNano TransaccionesDasNano { get; set; }

        public string IdUsuarioBloqueo { get; set; }

        public string IdUsuarioValidacion { get; set; }

        public DateTime? FechaValidacion { get; set; }

    }
}
