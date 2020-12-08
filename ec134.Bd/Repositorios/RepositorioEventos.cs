using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public class RepositorioEventos : RepositorioEventosBase, IRepositorioEventos
	{
		public RepositorioEventos (ec134Context dbContext) : base(dbContext)
		{

		}


        public IQueryable<Eventos> GetEventosPorIdFormularioEIdTipoEvento(int idFormulario, int idTipoEvento)
        {
            return GetEventosByIdFormularioPrecedente(idFormulario).Where(evento => evento.IdTipoEvento == idTipoEvento).OrderBy(evento =>evento.OrdenEvaluacion);
        }

    }
}
