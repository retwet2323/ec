namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Despliegues
    {
        [Key]
        public int IdDespliegue { get; set; }

        public int? IdProducto { get; set; }

        [StringLength(500)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(500)]
        public string URL { get; set; }

        public DateTime Fecha { get; set; }

        [StringLength(50)]
        public string Entorno { get; set; }

        [Required]
        [StringLength(36)]
        public string Code { get; set; }

        public virtual Productos Productos { get; set; }
    }
}
