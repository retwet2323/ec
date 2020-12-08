namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EstadosLogalty")]
    public partial class EstadosLogalty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EstadosLogalty()
        {
            TransaccionesLogalty = new HashSet<TransaccionesLogalty>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdEstadoLogalty { get; set; }

        [Required]
        [StringLength(50)]
        public string CodeLogalty { get; set; }

        [StringLength(500)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransaccionesLogalty> TransaccionesLogalty { get; set; }
    }
}
