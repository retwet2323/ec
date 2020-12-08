namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pasos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pasos()
        {
            Formularios = new HashSet<Formularios>();
        }

        [Key]
        public int IdPaso { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        public int? Orden { get; set; }

        [ForeignKey("Productos")]
        public int? IdProducto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Formularios> Formularios { get; set; }

        public virtual Productos Productos { get; set; }
    }
}
