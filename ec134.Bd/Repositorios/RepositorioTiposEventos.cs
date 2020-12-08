using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public class RepositorioTiposEventos : RepositorioTiposEventosBase, IRepositorioTiposEventos
	{
		public RepositorioTiposEventos (ec134Context dbContext) : base(dbContext)
		{

		}
        
        public IQueryable<TiposEventos> GetTiposEventoPorIdFormulario(int idFormulario)
        {
            return
                GetTiposEventos()
                .Where(x => x.Eventos.Any(evento => evento.IdFormularioPrecedente == idFormulario));
        }
    }
}
