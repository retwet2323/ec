namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Formularios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Formularios()
        {
            Contenedores = new HashSet<Contenedores>();
            Eventos = new HashSet<Eventos>();
            Eventos1 = new HashSet<Eventos>();
        }

        [Key]
        public int IdFormulario { get; set; }

        public int? IdTipoFormulario { get; set; }

        [StringLength(250)]
        public string Nombre { get; set; }

        [StringLength(500)]
        public string Titulo { get; set; }

        public int? IdProducto { get; set; }

        public bool? Inicial { get; set; }

        public bool? InicialSMTP { get; set; }

        public int? IdPaso { get; set; }

        public bool? OcultarSiguiente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contenedores> Contenedores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Eventos> Eventos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Eventos> Eventos1 { get; set; }

        public virtual Pasos Pasos { get; set; }

        public virtual Productos Productos { get; set; }

        public virtual TiposFormularios TiposFormularios { get; set; }
    }
}
