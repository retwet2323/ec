namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ElementosVersionables
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ElementosVersionables()
        {
            DocumentosPlantillas = new HashSet<DocumentosPlantillas>();
            VersionesElementos = new HashSet<VersionesElementos>();
        }

        [Key]
        public int IdElementoVersionable { get; set; }

        public int? IdTipoElementoVersionable { get; set; }

        public int? IdProducto { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentosPlantillas> DocumentosPlantillas { get; set; }

        public virtual Productos Productos { get; set; }

        public virtual TipoElementoVersionable TipoElementoVersionable { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VersionesElementos> VersionesElementos { get; set; }
    }
}
