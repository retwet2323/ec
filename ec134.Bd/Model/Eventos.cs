namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Eventos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Eventos()
        {
            EventoAccion = new HashSet<EventoAccion>();
        }

        [Key]
        public int IdEvento { get; set; }
        [ForeignKey("Formularios")]
        public int IdFormularioPrecedente { get; set; }

        [StringLength(500)]
        public string Condicion { get; set; }

        public int? IdFormularioConsecuente { get; set; }

        public int? IdTipoEvento { get; set; }

        public int? OrdenEvaluacion { get; set; }

        public bool? Oculto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventoAccion> EventoAccion { get; set; }

        public virtual TiposEventos TiposEventos { get; set; }

        public virtual Formularios Formularios { get; set; }

        public virtual Formularios Formularios1 { get; set; }
    }
}
