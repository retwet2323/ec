namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VersionesProductos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VersionesProductos()
        {
            Operaciones = new HashSet<Operaciones>();
            VersionesElementos = new HashSet<VersionesElementos>();
        }

        [Key]
        public int IdVersionProducto { get; set; }

        public int? IdProducto { get; set; }

        public DateTime Fecha { get; set; }

        public int? Mayor { get; set; }

        public int? Menor { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        public DateTime? Obsoleta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operaciones> Operaciones { get; set; }

        public virtual Productos Productos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VersionesElementos> VersionesElementos { get; set; }
    }
}
