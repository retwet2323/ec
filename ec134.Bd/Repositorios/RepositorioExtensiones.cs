using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public class RepositorioExtensiones : RepositorioExtensionesBase, IRepositorioExtensiones
	{
		public RepositorioExtensiones (ec134Context dbContext) : base(dbContext)
		{

		}

        public Extensiones GetExtension(string valor)
        {
            return GetExtensiones().FirstOrDefault(ext => ext.Valor.Equals(valor));
        }
    }
}
