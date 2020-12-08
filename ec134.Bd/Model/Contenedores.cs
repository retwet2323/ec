namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contenedores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contenedores()
        {
            Contenedores1 = new HashSet<Contenedores>();
            Controles = new HashSet<Controles>();
        }

        [Key]
        public int IdContenedor { get; set; }

        [ForeignKey("Contenedores2")]
        public int? IdContenedorSuperior { get; set; }
        
        public int? IdTipoContenedor { get; set; }

        [ForeignKey("Formularios")]
        public int? IdFormulario { get; set; }

        public int? Orden { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contenedores> Contenedores1 { get; set; }
        
        public virtual Contenedores Contenedores2 { get; set; }

        public virtual TiposContenedores TiposContenedores { get; set; }

        public virtual Formularios Formularios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Controles> Controles { get; set; }
    }
}
