using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;
using System;
using System.Collections.Generic;
using ec134.Bd.Model.Enum;

namespace ec134.Bd.Repositorios
{
    public class RepositorioOperaciones : RepositorioOperacionesBase, IRepositorioOperaciones
    {
        ec134Context _dbContext;
        public RepositorioOperaciones(ec134Context dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public Operaciones GetOperacionPorClave(string clave)
        {
            return
                GetOperaciones()
                .Where(operacion => operacion.Clave == clave)
                .FirstOrDefault();
        }

        public Operaciones GetOperacionPorClaveSMTP(string claveSMTP)
        {
            return
                GetOperaciones()
                .Where(operacion => operacion.ClaveSMTP == claveSMTP)
                .FirstOrDefault();
        }

        public Operaciones GetOperacionPorGuidLogalty(string guidLogalty)
        {
            return
                GetOperaciones()
                .Where(operacion => operacion.GuidLogalty == guidLogalty)
                .FirstOrDefault();
        }

        public IEnumerable<Operaciones> GetOperacionesCaducadasConRecordatorio()
        {
            var fi = DateTime.Now.AddHours(-3);
            var fechaLimite = new DateTime(fi.Year, fi.Month, fi.Day, fi.Hour, 00, 00);
            return
                GetOperaciones()
                .Where(operacion =>
                operacion.EnvioRecordatorio.HasValue &&
                !operacion.Anonimizado.HasValue &&
                !operacion.Regularizada.HasValue &&
                operacion.EnvioRecordatorio.Value <= fechaLimite);
        }

        public IEnumerable<Operaciones> GetOperacionesCaducadasSinRecordatorio()
        {
            return
                GetOperaciones()
                .Where(operacion =>
                operacion.FechaCaducidad.HasValue &&
                !operacion.EnvioRecordatorio.HasValue &&
                !operacion.Firmada &&
                !operacion.Anonimizado.HasValue &&
                !operacion.Regularizada.HasValue &&
                operacion.FechaCaducidad <= DateTime.Now);

        }

        //public IQueryable<Operaciones> GetOperaciones6Horas()
        //{
        //    var fechaFin = DateTime.Now.AddHours(-6);
        //    var fechaInicio = DateTime.Now.AddHours(-7);

        //    return
        //       GetOperaciones()
        //        .Where(operacion =>
        //        operacion.FechaCaducidad.HasValue &&
        //        !operacion.Regularizada.HasValue &&
        //        !operacion.Firmada &&
        //        !operacion.Anonimizado.HasValue &&
        //        fechaInicio < operacion.FechaRegistro && operacion.FechaRegistro < fechaFin);

        //}

        public IQueryable<Operaciones> GetOperaciones6Horas(int idProducto)
        {
            //return GetOperaciones6Horas().Where(operacion => operacion.IdProducto == idProducto);

            var fechaFin = DateTime.Now.AddHours(-6);
            
            var fi = DateTime.Now.AddHours(-7);
            var fechaInicio = new DateTime(fi.Year, fi.Month, fi.Day, fi.Hour, 00, 00);

            return
               GetOperaciones()
                .Where(operacion =>
                operacion.IdProducto == idProducto &&
                operacion.FechaCaducidad.HasValue &&
                !operacion.Regularizada.HasValue &&
                !operacion.Firmada &&
                !operacion.Anonimizado.HasValue &&
                fechaInicio <= operacion.FechaRegistro && operacion.FechaRegistro <= fechaFin
                );

        }

        //public IQueryable<Operaciones> GetOperaciones12Horas()
        //{
        //    var fechaFin = DateTime.Now.AddHours(-12);
        //    var fechaInicio = DateTime.Now.AddHours(-13);

        //    return
        //        GetOperaciones()
        //        .Where(operacion =>
        //        operacion.FechaCaducidad.HasValue &&
        //        !operacion.Regularizada.HasValue &&
        //        !operacion.Firmada &&
        //        !operacion.Anonimizado.HasValue &&
        //        fechaInicio < operacion.FechaRegistro && operacion.FechaRegistro < fechaFin);
        //}

        public IQueryable<Operaciones> GetOperaciones12Horas(int idProducto)
        {
            //return GetOperaciones12Horas().Where(operacion => operacion.IdProducto == idProducto);

            var fechaFin = DateTime.Now.AddHours(-12);
            var fi = DateTime.Now.AddHours(-13);
            var fechaInicio = new DateTime(fi.Year, fi.Month, fi.Day, fi.Hour, 00, 00);

            return
                GetOperaciones()
                .Where(operacion =>
                operacion.IdProducto == idProducto &&
                operacion.FechaCaducidad.HasValue &&
                !operacion.Regularizada.HasValue &&
                !operacion.Firmada &&
                !operacion.Anonimizado.HasValue &&
                fechaInicio <= operacion.FechaRegistro && operacion.FechaRegistro <= fechaFin
                );

        }

        //public IQueryable<Operaciones> GetOperaciones20Horas()
        //{
        //    var fechaFin = DateTime.Now.AddHours(-20);
        //    var fechaInicio = DateTime.Now.AddHours(-21);

        //    return
        //        GetOperaciones()
        //        .Where(operacion =>
        //        operacion.FechaCaducidad.HasValue &&
        //        !operacion.Regularizada.HasValue &&
        //        !operacion.Firmada &&
        //        !operacion.Anonimizado.HasValue &&
        //        fechaInicio < operacion.FechaRegistro && operacion.FechaRegistro < fechaFin);
        //}

        public IQueryable<Operaciones> GetOperaciones20Horas(int idProducto)
        {
            //return GetOperaciones20Horas().Where(operacion => operacion.IdProducto == idProducto);

            var fechaFin = DateTime.Now.AddHours(-20);
            var fi = DateTime.Now.AddHours(-21);
            var fechaInicio = new DateTime(fi.Year, fi.Month, fi.Day, fi.Hour, 00, 00);

            return
                GetOperaciones()
                .Where(operacion =>
                operacion.IdProducto == idProducto &&
                operacion.FechaCaducidad.HasValue &&
                !operacion.Regularizada.HasValue &&
                !operacion.Firmada &&
                !operacion.Anonimizado.HasValue &&
                fechaInicio <= operacion.FechaRegistro && operacion.FechaRegistro <= fechaFin
                );
        }



        public IQueryable<Operaciones> GetOperaciones24Horas(int idProducto)
        {
            var fechaFin = DateTime.Now.AddHours(-24);
            var fi = DateTime.Now.AddHours(-25);
            var fechaInicio = new DateTime(fi.Year, fi.Month, fi.Day, fi.Hour, 00, 00);

            return GetOperaciones()
                .Where(operacion =>
                operacion.IdProducto == idProducto &&
                operacion.IdEstadoOperacion != 21 &&
                operacion.FechaCaducidad.HasValue &&
                !operacion.Firmada &&
                !operacion.Anonimizado.HasValue &&
                !operacion.Regularizada.HasValue &&
                fechaInicio <= operacion.FechaRegistro && operacion.FechaRegistro <= fechaFin
                );
        }


        public IEnumerable<Operaciones> GetOperacionesDenegadas(int idProducto)
        {

            var documentos = _dbContext.DocumentosSolicitud.Where(ds =>
           (ds.IdTipoEstado == (int)EstadosSolicitud.Denegada ||
            ds.IdTipoEstado == (int)EstadosSolicitud.DenegadasAltaMK)).Select(o => o.Documentos.IdOperacion).ToList();


            Operaciones op = new Operaciones();
            List<Operaciones> listop = new List<Operaciones>();


            var operaciones = GetOperaciones().Where(operacion =>
            operacion.IdProducto == idProducto &&
            (!operacion.AvisoDenegada.HasValue || !operacion.AvisoDenegada.Value)
            && operacion.Firmada).ToList();

            //var operaciones = GetOperaciones().Where(operacion =>
            //operacion.IdOperacion == 631249).ToList();

            operaciones.ForEach(x =>
            {
                if (documentos.Contains(x.IdOperacion))
                {
                    listop.Add(x);
                }

            });

            return listop;
        }

        public IQueryable<Operaciones> GetOperacionesCaducadas(int idProducto)
        {
            var fechaFin = DateTime.Now;
            return GetOperaciones()
                .Where(operacion =>
                operacion.IdProducto == idProducto &&
                operacion.IdEstadoOperacion == 0 &&
                operacion.FechaCaducidad.HasValue &&
                !operacion.Firmada &&
                !operacion.Anonimizado.HasValue &&
                !operacion.Regularizada.HasValue &&
                operacion.FechaCaducidad <= fechaFin
                );
        }


        //RECOVERY....

        public IQueryable<Operaciones> GetOperaciones12HorasRecovery(int idProducto)
        {
            //return GetOperaciones().Where(operacion => operacion.IdOperacion == 480117);

            var fechaFin = DateTime.Now.AddHours(-13);
            var fechaInicio = DateTime.Now.AddHours(-12);

            return
                GetOperaciones()
                .Where(operacion =>
                operacion.IdProducto == idProducto &&
                operacion.FechaCaducidad.HasValue &&
                operacion.Firmada &&
                !operacion.Anonimizado.HasValue &&
                fechaInicio <= operacion.FechaCaducidad && fechaFin >= operacion.FechaCaducidad
                );

        }


        public IQueryable<Operaciones> GetOperaciones24HorasRecovery(int idProducto)
        {
            var fechaFin = DateTime.Now.AddHours(+25);
            var fechaInicio = DateTime.Now.AddHours(+24);


            return GetOperaciones()
                .Where(operacion =>
                operacion.IdProducto == idProducto &&
                operacion.FechaCaducidad.HasValue &&
                operacion.Firmada &&
                !operacion.Anonimizado.HasValue &&
                fechaInicio <= operacion.FechaCaducidad && fechaFin >= operacion.FechaCaducidad
                );
        }


        public IQueryable<Operaciones> GetOperaciones36HorasRecovery(int idProducto)
        {
            var fechaFin = DateTime.Now.AddHours(-37);
            var fechaInicio = DateTime.Now.AddHours(-36);

            return GetOperaciones()
                .Where(operacion =>
                operacion.IdProducto == idProducto &&
                operacion.FechaCaducidad.HasValue &&
                operacion.Firmada &&
                !operacion.Anonimizado.HasValue &&
                fechaInicio <= operacion.FechaCaducidad && fechaFin >= operacion.FechaCaducidad
                );
        }


        public IQueryable<Operaciones> GetOperaciones48HorasRecovery(int idProducto)
        {
            var fechaFin = DateTime.Now.AddHours(-49);
            var fechaInicio = DateTime.Now.AddHours(-48);

            return GetOperaciones()
                .Where(operacion =>
                operacion.IdProducto == idProducto &&
                operacion.FechaCaducidad.HasValue &&
                operacion.Firmada &&
                !operacion.Anonimizado.HasValue &&
                fechaInicio <= operacion.FechaCaducidad && fechaFin >= operacion.FechaCaducidad
                );
        }

        public IQueryable<Operaciones> GetOperacionesCaducadasRecovery(int idProducto)
        {
            var fechaFin = DateTime.Now;
            return GetOperaciones()
                .Where(operacion =>
                operacion.IdProducto == idProducto &&
                operacion.FechaCaducidad.HasValue &&
                operacion.Firmada &&
                !operacion.Anonimizado.HasValue &&
                operacion.FechaCaducidad <= fechaFin
                );
        }




        public IQueryable<Operaciones> GetOperacionesWithoutTrasactions(int idProducto)
        {

            return
               GetOperaciones()
                .Where(operacion =>
                operacion.IdProducto == idProducto &&
                operacion.IdEstadoOperacion == (int)EstadoOperacion.PendienteValidacion &&
                operacion.Firmada &&
                operacion.TransaccionesLogalty.FirstOrDefault().IdEstadoLogalty == (int)Model.Enum.EstadosLogalty.Aceptado &&
                operacion.TransaccionesDasNano.Count == 0
                );
        }




        public IQueryable<Operaciones> GetOperacionesToDelete(int idProducto)
        {
            var fechaFin = DateTime.Now.AddHours(-24);


            return GetOperaciones()
                .Where(operacion =>
                operacion.IdProducto == idProducto &&
                operacion.IdEstadoOperacion == 0 &&
                operacion.FechaCaducidad.HasValue &&
                !operacion.Firmada &&
                !operacion.Anonimizado.HasValue &&
                !operacion.Regularizada.HasValue &&
                operacion.FechaRegistro <= fechaFin
                );
        }


        public IQueryable<Operaciones> GetOperacionesWithoutSignature(int idProducto)
        {
            var fechaFin = DateTime.Now.AddHours(-72);

            return GetOperaciones()
                .Where(operacion =>
                operacion.IdProducto == idProducto &&
                operacion.IdEstadoOperacion != 21 &&
                operacion.FechaCaducidad.HasValue &&
                !operacion.Firmada &&
                !operacion.Anonimizado.HasValue &&
                !operacion.Regularizada.HasValue &&
                operacion.FechaRegistro <= fechaFin
                );
        }

        public IEnumerable<Operaciones> GetOperacionesWithSignature(int idProducto)
        {

            var fechaFin = DateTime.Now.AddHours(-30);
            var documentos = _dbContext.DocumentosSolicitud.Where(ds =>
           (ds.IdTipoSolicitud == (int)TiposSolicitud.Inactiva) 
           && ds.FxUltimoEstado != null && ds.FxUltimoEstado <= fechaFin).Select(o => o.Documentos.IdOperacion).ToList();


            Operaciones op = new Operaciones();
            List<Operaciones> listop = new List<Operaciones>();


            var operaciones = GetOperaciones().Where(operacion =>
            operacion.IdProducto == idProducto &&
            (!operacion.Anonimizado.HasValue)
            && operacion.Firmada).ToList();

            //var operaciones = GetOperaciones().Where(operacion =>
            //operacion.IdOperacion == 631249).ToList();

            operaciones.ForEach(x =>
            {
                if (documentos.Contains(x.IdOperacion))
                {
                    listop.Add(x);
                }

            });

            return listop;
        }






        public bool ExisteClave(string clave)
        {
            return
                GetOperaciones()
                .Any(operacion => operacion.Clave == clave);
        }

        public bool ExisteClaveSMTP(string claveSMTP)
        {
            return
                GetOperaciones()
                .Any(operacion => operacion.ClaveSMTP == claveSMTP);
        }
    }
}
