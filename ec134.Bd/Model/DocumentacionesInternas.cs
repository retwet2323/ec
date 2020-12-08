namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DocumentacionesInternas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocumentacionesInternas()
        {
            ConfiguracionDenegadas = new HashSet<ConfiguracionDenegadas>();
            VersionesElementos = new HashSet<VersionesElementos>();
        }

        [Key]
        public int IdDocumentacionInterna { get; set; }

        [Required]
        [StringLength(250)]
        public string Ubicacion { get; set; }

        [Required]
        [StringLength(250)]
        public string Nombre { get; set; }

        public int? IdTipoRepositorio { get; set; }

        [StringLength(500)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(150)]
        public string MediaTypeHeaderValue { get; set; }

        public virtual TiposRepositorio TiposRepositorio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VersionesElementos> VersionesElementos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConfiguracionDenegadas> ConfiguracionDenegadas { get; set; }
    }
}
