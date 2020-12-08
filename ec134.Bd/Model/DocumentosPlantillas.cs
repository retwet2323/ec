namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DocumentosPlantillas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocumentosPlantillas()
        {
            ConfiguracionLogalty = new HashSet<ConfiguracionLogalty>();
            DocumentosPlantillas1 = new HashSet<DocumentosPlantillas>();
        }

        [Key]
        public int IdDocumentoPlantilla { get; set; }
        [ForeignKey("DocumentosPlantillas2")]
        public int? IdDocumentoPrincipal { get; set; }

        public int? Orden { get; set; }

        [StringLength(250)]
        public string Nombre { get; set; }

        [StringLength(500)]
        public string Descripcion { get; set; }
        [ForeignKey("ElementosVersionables")]
        public int? IdElemento { get; set; }

        public bool? CombinarDatos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConfiguracionLogalty> ConfiguracionLogalty { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentosPlantillas> DocumentosPlantillas1 { get; set; }

        public virtual DocumentosPlantillas DocumentosPlantillas2 { get; set; }

        public virtual ElementosVersionables ElementosVersionables { get; set; }
    }
}
