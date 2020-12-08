namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VerificacionDocumentalDI_Ilegibles
    {
        [Key]
        public int IdIlegible { get; set; }

        public int IdRespuesta { get; set; }

        public Guid? GuidRespuesta { get; set; }

        public int? IdPagina { get; set; }

        public string RutaImagen { get; set; }

        [StringLength(4000)]
        public string NombreImagen { get; set; }

        public int? IdCara { get; set; }

        public int? IdError { get; set; }

        public string DescripcionError { get; set; }

        public int? IdDocumento { get; set; }

        public string TextoCompleto { get; set; }

        public string DatosAdicionales { get; set; }

        public virtual VerificacionDocumentalDI VerificacionDocumentalDI { get; set; }
    }
}
