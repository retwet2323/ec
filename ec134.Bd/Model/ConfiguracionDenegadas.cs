namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ConfiguracionDenegadas
    {
        [Key]
        public int IdConfiguracionDenegada { get; set; }

        public int IdProducto { get; set; }

        public int IdDocumentacionInterna { get; set; }

        public virtual DocumentacionesInternas DocumentacionesInternas { get; set; }

        public virtual Productos Productos { get; set; }
    }
}
