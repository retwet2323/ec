namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InfoOrigenes
    {
        [Key]
        public int IdInfoOrigen { get; set; }

        public int? IdOperacion { get; set; }

        [StringLength(500)]
        public string Navegador { get; set; }

        [StringLength(500)]
        public string EcmaScriptVersion { get; set; }

        public bool? AdmiteFrames { get; set; }

        [StringLength(500)]
        public string IdBrowser { get; set; }

        public bool? IsMobileDevice { get; set; }

        [StringLength(500)]
        public string MobileDeviceManufacturer { get; set; }

        [StringLength(500)]
        public string MobileDeviceModel { get; set; }

        [StringLength(500)]
        public string Platform { get; set; }

        public int? ScreenBitDepth { get; set; }

        public int? ScreenCharactersHeight { get; set; }

        public int? ScreenCharactersWidth { get; set; }

        public int? ScreenPixelsHeight { get; set; }

        public int? ScreenPixelsWidth { get; set; }

        [StringLength(500)]
        public string Type { get; set; }

        [StringLength(500)]
        public string BrowserVersion { get; set; }

        [StringLength(500)]
        public string W3CDomVersion { get; set; }

        [StringLength(500)]
        public string UserLanguages { get; set; }

        [StringLength(500)]
        public string UserAgent { get; set; }

        [StringLength(500)]
        public string UserHostAddress { get; set; }

        public virtual Operaciones Operaciones { get; set; }
    }
}
