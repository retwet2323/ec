namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Acciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Acciones()
        {
            EventoAccion = new HashSet<EventoAccion>();
        }

        [Key]
        public int IdAccion { get; set; }

        public int? IdTipoAccion { get; set; }

        public int? IdConfiguracionAccion { get; set; }

        public bool Asincrona { get; set; }

        public virtual TiposAcciones TiposAcciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventoAccion> EventoAccion { get; set; }
    }
}
