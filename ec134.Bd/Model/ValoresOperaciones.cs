namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ValoresOperaciones
    {
        [Key]
        public int IdValorOperacion { get; set; }
        [ForeignKey("Operaciones")]
        public int IdOperacion { get; set; }

        public int IdCampoProducto { get; set; }

        [Required]
        public string Valor { get; set; }

        public DateTime Insertado { get; set; }

        public DateTime? Anulado { get; set; }

        public virtual CamposProductos CamposProductos { get; set; }

        public virtual Operaciones Operaciones { get; set; }

    
    }
}
