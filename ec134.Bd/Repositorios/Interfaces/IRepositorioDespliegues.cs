using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public interface IRepositorioDespliegues : IRepositorioDesplieguesBase
    {
        Despliegues GetDesplieguePorCode(string code);
    }
}
