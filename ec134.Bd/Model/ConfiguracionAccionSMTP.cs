namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConfiguracionAccionSMTP")]
    public partial class ConfiguracionAccionSMTP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdConfiguracionaAccionSMTP { get; set; }

        [Required]
        [StringLength(500)]
        public string Asunto { get; set; }

        [Required]
        public string Mensaje { get; set; }

        [Required]
        [StringLength(500)]
        public string Destinatario { get; set; }

        [StringLength(500)]
        public string Origen { get; set; }
       
        [StringLength(4000)]
        public string Adjuntos { get; set; }
    }
}
