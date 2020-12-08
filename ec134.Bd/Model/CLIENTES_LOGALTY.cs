namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLIENTES_LOGALTY
    {
        [Key]
        public int IdCliente { get; set; }

        [StringLength(255)]
        public string NOMBRE { get; set; }

        [StringLength(255)]
        public string PRIMERAPELLIDO { get; set; }

        [StringLength(255)]
        public string SEGUNDOAPELLIDO { get; set; }

        [StringLength(255)]
        public string DNI { get; set; }

        [StringLength(255)]
        public string EMAIL { get; set; }

        [StringLength(255)]
        public string TELEFONO { get; set; }

        [StringLength(255)]
        public string smtp { get; set; }

     
        public int? IdOperacion { get; set; }

        public DateTime? Creado { get; set; }
    }
}
