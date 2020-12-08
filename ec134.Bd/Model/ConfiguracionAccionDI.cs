namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConfiguracionAccionDI")]
    public partial class ConfiguracionAccionDI
    {
        [Key]
        public int IdConfiguracionAccionDI { get; set; }

        [StringLength(50)]
        public string Lote { get; set; }

        [StringLength(50)]
        public string Proceso { get; set; }

        [StringLength(50)]
        public string Proyecto { get; set; }

        [StringLength(50)]
        public string CodApp { get; set; }

        [StringLength(50)]
        public string CampoAnverso { get; set; }

        [StringLength(50)]
        public string CampoReverso { get; set; }
    }
}
