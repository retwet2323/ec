namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConfiguracionDasNano")]
    public partial class ConfiguracionDasNano
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdConfiguracionDasNano { get; set; }

        public int IdCampoIdDasNano { get; set; }

        public int IdCampoAnverso { get; set; }

        public int IdCampoReverso { get; set; }

        public int IdCampoSelfie { get; set; }

        public int IdCampoPruebaVida { get; set; }

        public int IdCampoAnversoRecortado { get; set; }

        public int IdCampoReversoRecortado { get; set; }

        public int IdCampoSelfieProcesado { get; set; }

        public int IdCampoCaraDocumento { get; set; }

        public int IdCampoFirmaDocumento { get; set; }

        [Required]
        [StringLength(100)]
        public string Url { get; set; }

        [Required]
        [StringLength(50)]
        public string ApiKey { get; set; }
    }
}
