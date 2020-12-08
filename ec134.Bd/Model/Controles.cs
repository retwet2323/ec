namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Controles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Controles()
        {
            Controles1 = new HashSet<Controles>();
        }

        [Key]
        public int IdControl { get; set; }
        [ForeignKey("Controles2")]
        public int? IdControlSuperior { get; set; }
        [ForeignKey("CamposProductos")]
        public int? IdCampoProducto { get; set; }

        public bool? Visible { get; set; }

        public bool? Obligatoria { get; set; }

        [StringLength(2500)]
        public string Marcador { get; set; }

        public int Orden { get; set; }

        public int Nivel { get; set; }

        [StringLength(2500)]
        public string Etiqueta { get; set; }

        [StringLength(2500)]
        public string Nombre { get; set; }

        public bool SoloLectura { get; set; }

        public int? IdTipoControl { get; set; }
        [ForeignKey("Contenedores")]
        public int? IdContenedor { get; set; }

        public int? IdGrupoOpciones { get; set; }

        [StringLength(250)]
        public string Informacion { get; set; }

        [StringLength(500)]
        public string MensajeErrorObligatoria { get; set; }

        [StringLength(500)]
        public string MensajeErrorMarcador { get; set; }

        [StringLength(500)]
        public string MensajeErrorValorMaximo { get; set; }

        [StringLength(500)]
        public string MensajeErrorValorMinimo { get; set; }

        [StringLength(500)]
        public string MensajeErrorConversionTipo { get; set; }

        public virtual CamposProductos CamposProductos { get; set; }

        public virtual Contenedores Contenedores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Controles> Controles1 { get; set; }

        public virtual Controles Controles2 { get; set; }

        public virtual GruposOpciones GruposOpciones { get; set; }

        public virtual TiposControles TiposControles { get; set; }
    }
}
