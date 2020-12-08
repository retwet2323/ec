namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Servicios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Servicios()
        {
            Productos = new HashSet<Productos>();
        }

        [Key]
        public int IdServicio { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        public int? IdTipoServicio { get; set; }

        public int? IdConfiguracionServicio { get; set; }

        public virtual ConfiguracionLogalty ConfiguracionLogalty { get; set; }

        public virtual TiposServicio TiposServicio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productos> Productos { get; set; }
    }
}
