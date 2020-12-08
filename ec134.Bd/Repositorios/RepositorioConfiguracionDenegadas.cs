using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;
using System.Collections;

namespace ec134.Bd.Repositorios
{
    public class RepositorioConfiguracionDenegadas : RepositorioConfiguracionDenegadasBase, IRepositorioConfiguracionDenegadas
    {
       
        public RepositorioConfiguracionDenegadas(ec134Context dbContext) : base(dbContext)
        {
          
        }
    }
}
