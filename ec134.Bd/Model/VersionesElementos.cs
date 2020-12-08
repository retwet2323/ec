namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VersionesElementos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VersionesElementos()
        {
            VersionesProductos = new HashSet<VersionesProductos>();
        }

        [Key]
        public int IdVersionElemento { get; set; }

        public int? IdVersionProducto { get; set; }

        [ForeignKey("ElementosVersionables")]
        public int? IdElementoVersionable { get; set; }

        public int? IdElemento { get; set; }

        public DateTime Fecha { get; set; }

        public int Mayor { get; set; }

        public int Menor { get; set; }

        [StringLength(500)]
        public string Descripcion { get; set; }

        public DateTime? Obsoleta { get; set; }

        public virtual DocumentacionesInternas DocumentacionesInternas { get; set; }

        public virtual ElementosVersionables ElementosVersionables { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VersionesProductos> VersionesProductos { get; set; }
    }
}
