namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CamposProductos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CamposProductos()
        {
   
            Controles = new HashSet<Controles>();
            ValoresOperaciones = new HashSet<ValoresOperaciones>();
        }

        [Key]
        public int IdCampoProducto { get; set; }
        [ForeignKey("Productos")]
        public int? IdProducto { get; set; }

        public int? IdTipoValor { get; set; }

        [StringLength(250)]
        public string ValorMaximo { get; set; }

        [StringLength(250)]
        public string ValorMinimo { get; set; }

        [StringLength(500)]
        public string ExpresionRegular { get; set; }

        [StringLength(250)]
        public string Nombre { get; set; }

        public int? IdValidacionCompleja { get; set; }

        [StringLength(250)]
        public string Formato { get; set; }

        public bool EscribirPorParametro { get; set; }

        public virtual Productos Productos { get; set; }

        public virtual TiposValor TiposValor { get; set; }

        public virtual ValidacionesComplejas ValidacionesComplejas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Controles> Controles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValoresOperaciones> ValoresOperaciones { get; set; }
    }
}
