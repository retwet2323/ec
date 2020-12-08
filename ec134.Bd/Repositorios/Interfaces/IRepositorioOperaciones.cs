using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;
using System.Collections.Generic;

namespace ec134.Bd.Repositorios
{
    public interface IRepositorioOperaciones : IRepositorioOperacionesBase
	{
        Operaciones GetOperacionPorClave(string clave);
        Operaciones GetOperacionPorClaveSMTP(string claveSMTP);
        Operaciones GetOperacionPorGuidLogalty(string guidLogalty);

        bool ExisteClave(string clave);
        bool ExisteClaveSMTP(string claveSMTP);

        IEnumerable<Operaciones> GetOperacionesCaducadasConRecordatorio();
        IEnumerable<Operaciones> GetOperacionesCaducadasSinRecordatorio();
 
        IQueryable<Operaciones> GetOperaciones6Horas(int idProducto);
        IQueryable<Operaciones> GetOperaciones12Horas(int idProducto);
        IQueryable<Operaciones> GetOperaciones20Horas(int idProducto);
        IQueryable<Operaciones> GetOperaciones24Horas(int idProducto);
        IEnumerable<Operaciones> GetOperacionesDenegadas(int idProducto);
        IQueryable<Operaciones> GetOperacionesCaducadas(int idProducto);

        IQueryable<Operaciones> GetOperaciones12HorasRecovery(int idProducto);
        IQueryable<Operaciones> GetOperaciones24HorasRecovery(int idProducto);
        IQueryable<Operaciones> GetOperaciones36HorasRecovery(int idProducto);
        IQueryable<Operaciones> GetOperaciones48HorasRecovery(int idProducto);
        IQueryable<Operaciones> GetOperacionesCaducadasRecovery(int idProducto);


        IQueryable<Operaciones> GetOperacionesWithoutTrasactions(int idProducto);
        IQueryable<Operaciones> GetOperacionesWithoutSignature(int idProducto);
        IEnumerable<Operaciones> GetOperacionesWithSignature(int idProducto);

        IQueryable<Operaciones> GetOperacionesToDelete(int idProducto);

    }
}
