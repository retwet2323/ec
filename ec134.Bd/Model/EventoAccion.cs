namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EventoAccion")]
    public partial class EventoAccion
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ForeignKey("Eventos")]
        public int IdEvento { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ForeignKey("Acciones")]
        public int IdAccion { get; set; }

        public int? Orden { get; set; }

        public virtual Acciones Acciones { get; set; }

        public virtual Eventos Eventos { get; set; }
    }
}
