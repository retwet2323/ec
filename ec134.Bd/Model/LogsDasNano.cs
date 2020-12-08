namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogsDasNano")]
    public partial class LogsDasNano
    {
        [Key]
        public int IdLogsDasNano { get; set; }

        [ForeignKey("TransaccionesDasNano")]
        public int IdTransaccionDasNano { get; set; }


        [Column(TypeName = "text")]
        public string Code { get; set; }

        [StringLength(250)]
        public string HTTPStatus { get; set; }

        [Column(TypeName = "text")]
        public string Message { get; set; }

        [Column(TypeName = "text")]
        public string CallDasNano { get; set; }

        public TransaccionesDasNano TransaccionesDasNano { get; set; }


    }
}
