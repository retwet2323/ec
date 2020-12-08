namespace ec134.Bd.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ec134Context : DbContext
    {
        public ec134Context()
            : base("name=ec134Context")
        {
        }

        public virtual DbSet<Acciones> Acciones { get; set; }
        public virtual DbSet<CamposProductos> CamposProductos { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<CofiguracionAccionCambioEstado> CofiguracionAccionCambioEstado { get; set; }
        public virtual DbSet<ConfiguracionAccionDI> ConfiguracionAccionDI { get; set; }
        public virtual DbSet<ConfiguracionAccionSMTP> ConfiguracionAccionSMTP { get; set; }
        public virtual DbSet<ConfiguracionDasNano> ConfiguracionDasNano { get; set; }
        public virtual DbSet<ConfiguracionDenegadas> ConfiguracionDenegadas { get; set; }
        public virtual DbSet<ConfiguracionLogalty> ConfiguracionLogalty { get; set; }
        public virtual DbSet<Contenedores> Contenedores { get; set; }
        public virtual DbSet<Controles> Controles { get; set; }
        public virtual DbSet<Despliegues> Despliegues { get; set; }
        public virtual DbSet<DocumentacionesInternas> DocumentacionesInternas { get; set; }
        public virtual DbSet<Documentos> Documentos { get; set; }
        public virtual DbSet<DocumentosPlantillas> DocumentosPlantillas { get; set; }
        public virtual DbSet<DocumentosSolicitud> DocumentosSolicitud { get; set; }
        public virtual DbSet<ElementosVersionables> ElementosVersionables { get; set; }
        public virtual DbSet<EstadosLogalty> EstadosLogalty { get; set; }
        public virtual DbSet<EstadosOperaciones> EstadosOperaciones { get; set; }
        public virtual DbSet<EventoAccion> EventoAccion { get; set; }
        public virtual DbSet<Eventos> Eventos { get; set; }
        public virtual DbSet<Extensiones> Extensiones { get; set; }
        public virtual DbSet<Formularios> Formularios { get; set; }
        public virtual DbSet<GruposOpciones> GruposOpciones { get; set; }
        public virtual DbSet<InfoOrigenes> InfoOrigenes { get; set; }
        public virtual DbSet<MimeTypes> MimeTypes { get; set; }
        public virtual DbSet<NumerosMagicos> NumerosMagicos { get; set; }
        public virtual DbSet<Opciones> Opciones { get; set; }
        public virtual DbSet<Operaciones> Operaciones { get; set; }
        public virtual DbSet<Pasos> Pasos { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<RegistrosOperaciones> RegistrosOperaciones { get; set; }
        public virtual DbSet<Servicios> Servicios { get; set; }
        public virtual DbSet<TipoElementoVersionable> TipoElementoVersionable { get; set; }
        public virtual DbSet<TiposAcciones> TiposAcciones { get; set; }
        public virtual DbSet<TiposArchivo> TiposArchivo { get; set; }
        public virtual DbSet<TiposContenedores> TiposContenedores { get; set; }
        public virtual DbSet<TiposControles> TiposControles { get; set; }
        public virtual DbSet<TiposEstadosSolicitud> TiposEstadosSolicitud { get; set; }
        public virtual DbSet<TiposEventos> TiposEventos { get; set; }
        public virtual DbSet<TiposFormularios> TiposFormularios { get; set; }
        public virtual DbSet<TiposIdentificador> TiposIdentificador { get; set; }
        public virtual DbSet<TiposRepositorio> TiposRepositorio { get; set; }
        public virtual DbSet<TiposServicio> TiposServicio { get; set; }
        public virtual DbSet<TiposValor> TiposValor { get; set; }
        public virtual DbSet<TransaccionesDasNano> TransaccionesDasNano { get; set; }
        public virtual DbSet<TransaccionesLogalty> TransaccionesLogalty { get; set; }
        public virtual DbSet<ValidacionesComplejas> ValidacionesComplejas { get; set; }
        public virtual DbSet<ValoresOperaciones> ValoresOperaciones { get; set; }
        public virtual DbSet<VerificacionDocumentalDI> VerificacionDocumentalDI { get; set; }
        public virtual DbSet<VerificacionDocumentalDI_Ilegibles> VerificacionDocumentalDI_Ilegibles { get; set; }
        public virtual DbSet<VerificacionDocumentalDI_Resultados> VerificacionDocumentalDI_Resultados { get; set; }
        public virtual DbSet<VersionesElementos> VersionesElementos { get; set; }
        public virtual DbSet<VersionesProductos> VersionesProductos { get; set; }
        public virtual DbSet<DatosDasNano> DatosDasNano { get; set; }
        public virtual DbSet<ValidacionesDasNano> ValidacionesDasNano { get; set; }
        public virtual DbSet<LogsDasNano> LogsDasNano { get; set; }
        public virtual DbSet<DocumentosCUE> DocumentosCUE { get; set; }
        public virtual DbSet<DocumentosDNI> DocumentosDNI { get; set; }
        public virtual DbSet<DocumentosIBAN> DocumentosIBAN { get; set; }
        public virtual DbSet<DocumentosJustificante> DocumentosJustificante { get; set; }

        public virtual DbSet<CLIENTES_LOGALTY> CLIENTES_LOGALTY { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acciones>()
                .HasMany(e => e.EventoAccion)
                .WithRequired(e => e.Acciones)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CamposProductos>()
                .Property(e => e.ValorMaximo)
                .IsUnicode(false);

            modelBuilder.Entity<CamposProductos>()
                .Property(e => e.ValorMinimo)
                .IsUnicode(false);

            modelBuilder.Entity<CamposProductos>()
                .Property(e => e.ExpresionRegular)
                .IsUnicode(false);

            modelBuilder.Entity<CamposProductos>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CamposProductos>()
                .Property(e => e.Formato)
                .IsUnicode(false);

            modelBuilder.Entity<CamposProductos>()
                .HasMany(e => e.ValoresOperaciones)
                .WithRequired(e => e.CamposProductos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ConfiguracionAccionDI>()
                .Property(e => e.Lote)
                .IsUnicode(false);

            modelBuilder.Entity<ConfiguracionAccionDI>()
                .Property(e => e.Proceso)
                .IsUnicode(false);

            modelBuilder.Entity<ConfiguracionAccionDI>()
                .Property(e => e.Proyecto)
                .IsUnicode(false);

            modelBuilder.Entity<ConfiguracionAccionDI>()
                .Property(e => e.CodApp)
                .IsUnicode(false);

            modelBuilder.Entity<ConfiguracionAccionDI>()
                .Property(e => e.CampoAnverso)
                .IsUnicode(false);

            modelBuilder.Entity<ConfiguracionAccionDI>()
                .Property(e => e.CampoReverso)
                .IsUnicode(false);

            modelBuilder.Entity<ConfiguracionAccionSMTP>()
                .Property(e => e.Asunto)
                .IsUnicode(false);

            modelBuilder.Entity<ConfiguracionAccionSMTP>()
                .Property(e => e.Mensaje)
                .IsUnicode(false);

            modelBuilder.Entity<ConfiguracionAccionSMTP>()
                .Property(e => e.Destinatario)
                .IsUnicode(false);

            modelBuilder.Entity<ConfiguracionAccionSMTP>()
                .Property(e => e.Origen)
                .IsUnicode(false);

            modelBuilder.Entity<ConfiguracionLogalty>()
                .Property(e => e.PathArchivoPFX)
                .IsUnicode(false);

            modelBuilder.Entity<ConfiguracionLogalty>()
                .Property(e => e.PasswordArchivoPFX)
                .IsUnicode(false);

            modelBuilder.Entity<ConfiguracionLogalty>()
                .Property(e => e.Issuer)
                .IsUnicode(false);

            modelBuilder.Entity<ConfiguracionLogalty>()
                .Property(e => e.UrlBack)
                .IsUnicode(false);

            modelBuilder.Entity<ConfiguracionLogalty>()
                .Property(e => e.UrlLogalty)
                .IsUnicode(false);

            modelBuilder.Entity<ConfiguracionLogalty>()
                .Property(e => e.UrlSamlLogin)
                .IsUnicode(false);

            modelBuilder.Entity<ConfiguracionLogalty>()
                .Property(e => e.EmailRespuesta)
                .IsUnicode(false);

            modelBuilder.Entity<ConfiguracionLogalty>()
                .HasMany(e => e.Servicios)
                .WithOptional(e => e.ConfiguracionLogalty)
                .HasForeignKey(e => e.IdConfiguracionServicio);

            modelBuilder.Entity<Contenedores>()
                .HasMany(e => e.Contenedores1)
                .WithOptional(e => e.Contenedores2)
                .HasForeignKey(e => e.IdContenedorSuperior);

            modelBuilder.Entity<Controles>()
                .Property(e => e.Marcador)
                .IsUnicode(false);

            modelBuilder.Entity<Controles>()
                .Property(e => e.Etiqueta)
                .IsUnicode(false);

            modelBuilder.Entity<Controles>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Controles>()
                .Property(e => e.Informacion)
                .IsUnicode(false);

            modelBuilder.Entity<Controles>()
                .Property(e => e.MensajeErrorObligatoria)
                .IsUnicode(false);

            modelBuilder.Entity<Controles>()
                .Property(e => e.MensajeErrorMarcador)
                .IsUnicode(false);

            modelBuilder.Entity<Controles>()
                .Property(e => e.MensajeErrorValorMaximo)
                .IsUnicode(false);

            modelBuilder.Entity<Controles>()
                .Property(e => e.MensajeErrorValorMinimo)
                .IsUnicode(false);

            modelBuilder.Entity<Controles>()
                .Property(e => e.MensajeErrorConversionTipo)
                .IsUnicode(false);

            modelBuilder.Entity<Controles>()
                .HasMany(e => e.Controles1)
                .WithOptional(e => e.Controles2)
                .HasForeignKey(e => e.IdControlSuperior);

            modelBuilder.Entity<Despliegues>()
                .Property(e => e.Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DocumentacionesInternas>()
                .Property(e => e.Ubicacion)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentacionesInternas>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentacionesInternas>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentacionesInternas>()
                .Property(e => e.MediaTypeHeaderValue)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentacionesInternas>()
              .HasMany(e => e.ConfiguracionDenegadas)
              .WithRequired(e => e.DocumentacionesInternas)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<DocumentacionesInternas>()
                .HasMany(e => e.VersionesElementos)
                .WithOptional(e => e.DocumentacionesInternas)
                .HasForeignKey(e => e.IdElemento);

            modelBuilder.Entity<Documentos>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Documentos>()
                .Property(e => e.UsuarioBloqueo)
                .IsUnicode(false);

            modelBuilder.Entity<Documentos>()
              .HasMany(e => e.DocumentosDNI)
              .WithRequired(e => e.Documentos)
              .HasForeignKey(e => e.IdDocumento)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<Documentos>()
             .HasMany(e => e.DocumentosCUE)
             .WithRequired(e => e.Documentos)
             .HasForeignKey(e => e.IdDocumento)
             .WillCascadeOnDelete(false);

            modelBuilder.Entity<Documentos>()
             .HasMany(e => e.DocumentosIBAN)
             .WithRequired(e => e.Documentos)
             .HasForeignKey(e => e.IdDocumento)
             .WillCascadeOnDelete(false);

            modelBuilder.Entity<Documentos>()
             .HasMany(e => e.DocumentosJustificante)
             .WithRequired(e => e.Documentos)
             .HasForeignKey(e => e.IdDocumento)
             .WillCascadeOnDelete(false);

            modelBuilder.Entity<Documentos>()
              .HasMany(e => e.DocumentosSolicitud)
              .WithRequired(e => e.Documentos)
              .HasForeignKey(e => e.IdDocumento)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<Documentos>()
              .HasMany(e => e.DocumentosSolicitud)
              .WithRequired(e => e.Documentos)
              .HasForeignKey(e => e.IdDocumento)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<Documentos>()
              .HasMany(e => e.DocumentosSolicitud)
              .WithRequired(e => e.Documentos)
              .HasForeignKey(e => e.IdDocumento)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<Documentos>()
              .HasMany(e => e.DocumentosSolicitud)
              .WithRequired(e => e.Documentos)
              .HasForeignKey(e => e.IdDocumento)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<DocumentosPlantillas>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentosPlantillas>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentosPlantillas>()
                .HasMany(e => e.DocumentosPlantillas1)
                .WithOptional(e => e.DocumentosPlantillas2)
                .HasForeignKey(e => e.IdDocumentoPrincipal);

            modelBuilder.Entity<DocumentosSolicitud>()
              .Property(e => e.NIF1)
              .IsFixedLength()
              .IsUnicode(false);

            modelBuilder.Entity<DocumentosSolicitud>()
                .Property(e => e.NIF2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DocumentosSolicitud>()
                .Property(e => e.NIF3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DocumentosSolicitud>()
                .Property(e => e.Notas)
                .IsFixedLength();

        

            modelBuilder.Entity<DocumentosDNI>()
               .Property(e => e.Nombre)
               .IsUnicode(false);

            modelBuilder.Entity<DocumentosDNI>()
                .Property(e => e.Apellido1)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentosDNI>()
                .Property(e => e.Apellido2)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentosDNI>()
                .Property(e => e.Sexo)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentosDNI>()
                .Property(e => e.TipoFormulario)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentosDNI>()
                .Property(e => e.DNI)
                .IsUnicode(false);

           
            

            modelBuilder.Entity<DocumentosJustificante>()
                .Property(e => e.NIF1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DocumentosJustificante>()
                .Property(e => e.NIF2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DocumentosJustificante>()
                .Property(e => e.NIF3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ElementosVersionables>()
                .HasMany(e => e.DocumentosPlantillas)
                .WithOptional(e => e.ElementosVersionables)
                .HasForeignKey(e => e.IdElemento);

            modelBuilder.Entity<EstadosOperaciones>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<EstadosOperaciones>()
                .HasMany(e => e.Operaciones)
                .WithRequired(e => e.EstadosOperaciones)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EstadosOperaciones>()
                .HasMany(e => e.RegistrosOperaciones)
                .WithOptional(e => e.EstadosOperaciones)
                .HasForeignKey(e => e.IdEstadoAnterior);

            modelBuilder.Entity<EstadosOperaciones>()
                .HasMany(e => e.RegistrosOperaciones1)
                .WithRequired(e => e.EstadosOperaciones1)
                .HasForeignKey(e => e.IdEstadoNuevo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Eventos>()
                .Property(e => e.Condicion)
                .IsUnicode(false);

            modelBuilder.Entity<Eventos>()
                .HasMany(e => e.EventoAccion)
                .WithRequired(e => e.Eventos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Formularios>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Formularios>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<Formularios>()
                .HasMany(e => e.Eventos)
                .WithOptional(e => e.Formularios)
                .HasForeignKey(e => e.IdFormularioConsecuente);

            modelBuilder.Entity<Formularios>()
                .HasMany(e => e.Eventos1)
                .WithRequired(e => e.Formularios1)
                .HasForeignKey(e => e.IdFormularioPrecedente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GruposOpciones>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<GruposOpciones>()
                .HasMany(e => e.Opciones)
                .WithRequired(e => e.GruposOpciones)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InfoOrigenes>()
                .Property(e => e.Navegador)
                .IsUnicode(false);

            modelBuilder.Entity<InfoOrigenes>()
                .Property(e => e.EcmaScriptVersion)
                .IsUnicode(false);

            modelBuilder.Entity<InfoOrigenes>()
                .Property(e => e.IdBrowser)
                .IsUnicode(false);

            modelBuilder.Entity<InfoOrigenes>()
                .Property(e => e.MobileDeviceManufacturer)
                .IsUnicode(false);

            modelBuilder.Entity<InfoOrigenes>()
                .Property(e => e.MobileDeviceModel)
                .IsUnicode(false);

            modelBuilder.Entity<InfoOrigenes>()
                .Property(e => e.Platform)
                .IsUnicode(false);

            modelBuilder.Entity<InfoOrigenes>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<InfoOrigenes>()
                .Property(e => e.BrowserVersion)
                .IsUnicode(false);

            modelBuilder.Entity<InfoOrigenes>()
                .Property(e => e.W3CDomVersion)
                .IsUnicode(false);

            modelBuilder.Entity<InfoOrigenes>()
                .Property(e => e.UserLanguages)
                .IsUnicode(false);

            modelBuilder.Entity<InfoOrigenes>()
                .Property(e => e.UserAgent)
                .IsUnicode(false);

            modelBuilder.Entity<InfoOrigenes>()
                .Property(e => e.UserHostAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Opciones>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<Opciones>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Operaciones>()
                .Property(e => e.Identificador)
                .IsUnicode(false);

            modelBuilder.Entity<Operaciones>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<Operaciones>()
                .HasMany(e => e.Documentos)
                .WithRequired(e => e.Operaciones)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Operaciones>()
                .HasMany(e => e.RegistrosOperaciones)
                .WithRequired(e => e.Operaciones)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Operaciones>()
                .HasMany(e => e.TransaccionesDasNano);

            modelBuilder.Entity<Operaciones>()
                .HasMany(e => e.ValoresOperaciones)
                .WithRequired(e => e.Operaciones)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pasos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Productos>()
                .Property(e => e.DescripcionProducto)
                .IsUnicode(false);

            modelBuilder.Entity<Productos>()
                .Property(e => e.CodigoProyecto)
                .IsUnicode(false);

            modelBuilder.Entity<Productos>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Productos>()
                .Property(e => e.Icono)
                .IsUnicode(false);

            modelBuilder.Entity<Productos>()
                .HasMany(e => e.ConfiguracionDenegadas)
                .WithRequired(e => e.Productos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Productos>()
                .HasMany(e => e.Operaciones)
                .WithRequired(e => e.Productos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Productos>()
                .HasMany(e => e.Productos1)
                .WithOptional(e => e.Productos2)
                .HasForeignKey(e => e.IdProductoSuperior);

            modelBuilder.Entity<Productos>()
                .HasMany(e => e.Servicios)
                .WithMany(e => e.Productos)
                .Map(m => m.ToTable("ServiciosProductos").MapLeftKey("IdProducto").MapRightKey("IdServicio"));

            modelBuilder.Entity<RegistrosOperaciones>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<RegistrosOperaciones>()
                .Property(e => e.Identificador)
                .IsUnicode(false);

            modelBuilder.Entity<Servicios>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TiposAcciones>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TiposArchivo>()
                .HasMany(e => e.NumerosMagicos)
                .WithRequired(e => e.TiposArchivo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TiposContenedores>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TiposEstadosSolicitud>()
                .Property(e => e.Denominacion)
                .IsFixedLength();

            modelBuilder.Entity<TiposEstadosSolicitud>()
                .Property(e => e.EsFinal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TiposEventos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TiposFormularios>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TiposIdentificador>()
                .Property(e => e.DescripcionIdentificador)
                .IsUnicode(false);

            modelBuilder.Entity<TiposIdentificador>()
                .HasMany(e => e.Operaciones)
                .WithRequired(e => e.TiposIdentificador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TiposIdentificador>()
                .HasMany(e => e.RegistrosOperaciones)
                .WithRequired(e => e.TiposIdentificador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TiposValor>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TiposValor>()
                .Property(e => e.TipoSQL)
                .IsUnicode(false);

            modelBuilder.Entity<TiposValor>()
                .Property(e => e.TipoNet)
                .IsUnicode(false);

            modelBuilder.Entity<TransaccionesDasNano>()
                .Property(e => e.ResultadoOCR)
                .IsUnicode(false);

            modelBuilder.Entity<TransaccionesDasNano>()
                .Property(e => e.ResultadoScores)
                .IsUnicode(false);

            modelBuilder.Entity<ValidacionesComplejas>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ValidacionesComplejas>()
                .Property(e => e.CodeNameJs)
                .IsUnicode(false);

            modelBuilder.Entity<ValoresOperaciones>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI>()
                .Property(e => e.DatosAdicionales)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI>()
                .Property(e => e.Proyecto)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI>()
                .Property(e => e.Proceso)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI>()
                .Property(e => e.Lote)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI>()
                .Property(e => e.VersionDni)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI>()
                .Property(e => e.IdConfiguracion)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI>()
                .Property(e => e.VersionOcr)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI>()
                .Property(e => e.ConfiguracionEngine)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI>()
                .Property(e => e.DirectorioTrabajoOcr)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI>()
                .Property(e => e.DirectorioTrabajoOcrTemporal)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI>()
                .Property(e => e.DirectorioTrabajoDni)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI>()
                .HasMany(e => e.VerificacionDocumentalDI_Ilegibles)
                .WithRequired(e => e.VerificacionDocumentalDI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VerificacionDocumentalDI>()
                .HasMany(e => e.VerificacionDocumentalDI_Resultados)
                .WithRequired(e => e.VerificacionDocumentalDI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Ilegibles>()
                .Property(e => e.RutaImagen)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Ilegibles>()
                .Property(e => e.NombreImagen)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Ilegibles>()
                .Property(e => e.DescripcionError)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Ilegibles>()
                .Property(e => e.TextoCompleto)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Ilegibles>()
                .Property(e => e.DatosAdicionales)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.RutaImagen)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.TipoDocumentoSalida)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.Identificador)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.Soporte)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.PrimerApellido)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.SegundoApellido)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.Apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.PaisEmisor)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.Sexo)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.Nacionalidad)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.Comienzo)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.TextoMrz)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.Mrz1)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.Mrz2)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.Mrz3)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.TextoCompleto)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.TextoDelantera)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.TextoTrasera)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.TextoSinMrz)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.TextoTraseraSinMrz)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.TextoMrzOpcional)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.Dc1)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.Dc2)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.Dc3)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.Dc4)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.Dc5)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.Dc1Resultado)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.Dc2Resultado)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.Dc3Resultado)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.Dc4Resultado)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.Dc5Resultado)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.Error)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.NombreImagenDelantera)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.NombreImagenTrasera)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.Mrz1f)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.Mrz2f)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.Mrz3f)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.Mascara1)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.Mascara2)
                .IsUnicode(false);

            modelBuilder.Entity<VerificacionDocumentalDI_Resultados>()
                .Property(e => e.IdDocumento)
                .IsUnicode(false);

            modelBuilder.Entity<VersionesElementos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<VersionesElementos>()
                .HasMany(e => e.VersionesProductos)
                .WithMany(e => e.VersionesElementos)
                .Map(m => m.ToTable("VersionesElementosVersionesProductos").MapLeftKey("IdVersionElemento").MapRightKey("IdVersionProducto"));
        }
    }
}
