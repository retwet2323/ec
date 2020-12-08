using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;
using System.Collections.Generic;
using System;

namespace ec134.Bd.Repositorios
{
    public class RepositorioNumerosMagicos : RepositorioNumerosMagicosBase, IRepositorioNumerosMagicos
	{
		public RepositorioNumerosMagicos (ec134Context dbContext) : base(dbContext)
		{

		}

        public IEnumerable<NumerosMagicos> GetNumerosMagicosPorByteInicial(byte byteInicial)
        {
            var hex = byteInicial.ToString("X").ToUpper();
            return GetNumerosMagicos().Where(num =>
               num.Hexadecimal != null &&
               num.Hexadecimal.Length > 2 &&
               (num.Hexadecimal.StartsWith("XX") ||
               num.Hexadecimal.StartsWith(hex))
            );
        }
    }
}
