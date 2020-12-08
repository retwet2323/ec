namespace ec134.Bd.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DatosDasNano")]
    public partial class DatosDasNano
    {
        [Key]
        public int IdDatosDasNano { get; set; }

        [ForeignKey("TransaccionesDasNano")]
        public int IdTransaccionDasNano { get; set; }

        [StringLength(15)]
        public string Identificador { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public DateTime? FechaCaducidad { get; set; }

        [StringLength(10)]
        public string Soporte { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(100)]
        public string Apellidos { get; set; }

        [StringLength(3)]
        public string PaisEmisor { get; set; }

        [StringLength(1)]
        public string Sexo { get; set; }

        [StringLength(3)]
        public string Nacionalidad { get; set; }

        [StringLength(50)]
        public string Mrz1 { get; set; }

        [StringLength(50)]
        public string Mrz2 { get; set; }

        [StringLength(50)]
        public string Mrz3 { get; set; }

        [StringLength(50)]
        public string Provincia { get; set; }

        [StringLength(50)]
        public string Ciudad { get; set; }

        [StringLength(50)]
        public string ProvinciaNacimiento { get; set; }

        [StringLength(50)]
        public string CiudadNacimiento { get; set; }

        public bool? ControlIdentificador { get; set; }

        public bool? ControlDcSoporte { get; set; }

        public bool? ControlDcIdentificador { get; set; }

        public bool? ControlDcFechaNacimiento { get; set; }

        public bool? ControlDcFechaCaducidad { get; set; }

        public bool? ControlDcMrz { get; set; }

        public bool? ControlDcMrzOpcional { get; set; }

        public bool? ControlCaducado { get; set; }

        public bool? ControlLimiteEdad { get; set; }

        public int Edad { get; set; }

        public string Domicilio { get; set; }

        public string CAN { get; set; }

        public string Padres { get; set; }

        public TransaccionesDasNano TransaccionesDasNano { get; set; }

    }
}
