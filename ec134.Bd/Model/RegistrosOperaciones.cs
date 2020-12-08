namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RegistrosOperaciones
    {
        [Key]
        public int IdRegistroOperacion { get; set; }

        public int IdOperacion { get; set; }

        public int? IdEstadoAnterior { get; set; }

        public int IdEstadoNuevo { get; set; }

        public DateTime FechaRegistro { get; set; }

        [StringLength(200)]
        public string Observaciones { get; set; }

        [Required]
        [StringLength(100)]
        public string Identificador { get; set; }

        public int IdTipoIdentificador { get; set; }

        public virtual EstadosOperaciones EstadosOperaciones { get; set; }

        public virtual EstadosOperaciones EstadosOperaciones1 { get; set; }

        public virtual Operaciones Operaciones { get; set; }

        public virtual TiposIdentificador TiposIdentificador { get; set; }
    }
}
