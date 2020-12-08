using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;
using System.Collections.Generic;

namespace ec134.Bd.Repositorios
{
    public class RepositorioMimeTypes : RepositorioMimeTypesBase, IRepositorioMimeTypes
	{
		public RepositorioMimeTypes (ec134Context dbContext) : base(dbContext)
		{

		}

        public MimeTypes GetMimeTypePorValor(string valor)
        {
            return GetMimeTypes().FirstOrDefault(mt => mt.Valor.Equals(valor));
        }

    }
}
