namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Documentos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Documentos()
        {
           DocumentosSolicitud = new HashSet<DocumentosSolicitud>();
            DocumentosDNI = new HashSet<DocumentosDNI>();
            DocumentosIBAN = new HashSet<DocumentosIBAN>();
            DocumentosCUE = new HashSet<DocumentosCUE>();
            DocumentosJustificante = new HashSet<DocumentosJustificante>();
        }

        [Key]
        public int IdDocumento { get; set; }

        public int IdOperacion { get; set; }

        public int IdDocumentoOrigen { get; set; }

        public int IdTipoDocumento { get; set; }

        public DateTime? Fecha { get; set; }

        [StringLength(200)]
        public string RutaDocumento { get; set; }

        public int? IdEstado { get; set; }

        public int IdOrigen { get; set; }

        public int? IdCanal { get; set; }

        [StringLength(16)]
        public string Usuario { get; set; }

        [StringLength(200)]
        public string RutaDocumentoR { get; set; }

        [StringLength(16)]
        public string UsuarioBloqueo { get; set; }

        public DateTime? FechaBloqueo { get; set; }

        [StringLength(15)]
        public string CodigoOperacionAltaMK { get; set; }

        public virtual Operaciones Operaciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentosSolicitud> DocumentosSolicitud { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentosDNI> DocumentosDNI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentosCUE> DocumentosCUE{ get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentosIBAN> DocumentosIBAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentosJustificante> DocumentosJustificante { get; set; }

    }
}
