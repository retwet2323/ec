namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CofiguracionAccionCambioEstado")]
    public partial class CofiguracionAccionCambioEstado
    {
        [Key]
        public int IdConfiguracioAccionCambioEstado { get; set; }

        public int? IdEstadoOperacion { get; set; }

        public virtual EstadosOperaciones EstadosOperaciones { get; set; }
    }
}
