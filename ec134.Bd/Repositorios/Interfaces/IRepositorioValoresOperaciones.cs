using System.Linq;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public interface IRepositorioValoresOperaciones : IRepositorioValoresOperacionesBase
	{
        string GetValorPorductoPorIdCampoProductoYIdOperacion(int idOperacion, int idCampoProducto);
        ValoresOperaciones GetValoresOperacionesPorIdCampoProductoYIdOperacion(int idOperacion, int idCampoProducto);
        bool ExisteValor(int idOperacion, int idCampoProducto);
        bool ActualizarValor(int idOperacion, int idCampoProducto, string valor);
        string GetValorPorductoPorIdProductoNombreCampoYIdOperacion(int idOperacion, int idProducto, string nombreCampoProducto);
        bool ExisteValor(int idOperacion, int idProducto, string nombreCampoProducto);
        bool ActualizarValor(int idOperacion, int idProducto, string nombreCampoProducto, string valor);
    }
}
