using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public class RepositorioVersionesElementos : RepositorioVersionesElementosBase, IRepositorioVersionesElementos
	{
		public RepositorioVersionesElementos (ec134Context dbContext) : base(dbContext)
		{

		}


        public VersionesElementos UltimaVersionElemento(int idElemento)
        {
            var idUltimaVersion = GetVersionesElementosByIdElementoVersionable(idElemento).Max(version => version.IdVersionElemento);
            return GetVersionesElementosByPrimaryKey(idUltimaVersion);
        }
    }
}
