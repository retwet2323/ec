namespace ec134.Bd.Model.Enum
{
    public enum EstadoOperacion:int
    {
        Inicial = 0,
        Nueva = 1,
        Visitada = 2,
        AceptaPolitica = 3,
        Verificando = 5,
        DatosPersonales = 7,
        DatosContacto = 8,
        DatosProfesionales = 9,
        DatosPago = 10,
        DatosBanco = 11,
        Firmando = 12,
        OkDi = 20,
        Firmado = 21,
        Descargado = 22,
        IncidenciaDocumento = 23,
        NokDi = 30,
        NoFirmado = 31,
        Borrada = 99,
        PendienteValidacion = 50,
        PeticionNoValida = 51,
        GoToAffinityRecovery = 48,
        VisitAffinityRecovery = 49
    }
}
