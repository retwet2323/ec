using System;
using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public class RepositorioTransaccionesLogalty : RepositorioTransaccionesLogaltyBase, IRepositorioTransaccionesLogalty
    {
        public RepositorioTransaccionesLogalty(ec134Context dbContext) : base(dbContext)
        {

        }

        public IQueryable<TransaccionesLogalty> GetTransaccionesLogaltyPending()
        {
            IQueryable<TransaccionesLogalty> transaccionesExcluir =
                 GetTransaccionesLogalty().Where(t => (t.IdEstadoLogalty.Value == 7
                                                 && t.DescargaContrato == true && t.DescargaCertificado == true)
                                                 //Se excluyen los identificadores de Error de transacciones de Logalty,
                                                 //no recuperables
                                                 || (t.IdEstadoLogalty == 99904 || t.IdEstadoLogalty == 99906));



            IQueryable<TransaccionesLogalty> transaccionesPendientes =
                GetTransaccionesLogalty()
             .Where(x => (x.IdEstadoLogalty.HasValue && (x.IdEstadoLogalty.Value == 0 || x.IdEstadoLogalty.Value == 7)) &&
             (!x.DescargaContrato || !x.DescargaCertificado)
                 && !transaccionesExcluir.Any(tran => tran.IdOperacion == x.IdOperacion)
              );


            return transaccionesPendientes;



        }

        public TransaccionesLogalty GetTransacccionLogaltyPorId(int idTransaccionLogalty)
        {
            return GetTransaccionesLogaltyByPrimaryKey(idTransaccionLogalty);
        }
    }
}
