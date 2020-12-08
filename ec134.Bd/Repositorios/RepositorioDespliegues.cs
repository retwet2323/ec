using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public class RepositorioDespliegues : RepositorioDesplieguesBase, IRepositorioDespliegues
	{
		public RepositorioDespliegues (ec134Context dbContext) : base(dbContext)
        {

        }

        public Despliegues GetDesplieguePorCode(string code)
        {
            return GetDespliegues().Where(valor => valor.Code == code).FirstOrDefault();
        }
    }
}
