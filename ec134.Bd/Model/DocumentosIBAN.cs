namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentosIBAN")]
    public partial class DocumentosIBAN
    {
        [Key]
        public int IdDocumentoIban { get; set; }

        public int IdDocumento { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string Apellido1 { get; set; }

        [StringLength(50)]
        public string Apellido2 { get; set; }

        [StringLength(4)]
        public string IBAN { get; set; }

        [StringLength(4)]
        public string Entidad { get; set; }

        [StringLength(4)]
        public string Oficina { get; set; }

        [StringLength(2)]
        public string DC { get; set; }

        [StringLength(10)]
        public string NumCuenta { get; set; }

        public virtual Documentos Documentos { get; set; }
    }
}
