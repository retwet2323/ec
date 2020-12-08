namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TiposAccesos
    {
        [Key]
        public int IdTipoAcceso { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }
    }
}
