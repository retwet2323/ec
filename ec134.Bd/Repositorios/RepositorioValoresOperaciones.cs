using System;
using System.Linq;
using System.Threading.Tasks;
using ec134.Bd.Model;
using ec134.Bd.Repositorios.Base;

namespace ec134.Bd.Repositorios
{
    public class RepositorioValoresOperaciones : RepositorioValoresOperacionesBase, IRepositorioValoresOperaciones
	{

		public RepositorioValoresOperaciones (ec134Context dbContext) : base(dbContext)
		{
		}

        public string GetValorPorductoPorIdCampoProductoYIdOperacion(int idOperacion, int idCampoProducto)
        {
            return GetValoresOperaciones().Where(valor => valor.IdOperacion == idOperacion && valor.IdCampoProducto == idCampoProducto).Select(valor => valor.Valor).FirstOrDefault();
        }

        public ValoresOperaciones GetValoresOperacionesPorIdCampoProductoYIdOperacion(int idOperacion, int idCampoProducto)
        {
            return GetValoresOperaciones().Where(valor => valor.IdOperacion == idOperacion && valor.IdCampoProducto == idCampoProducto).FirstOrDefault();
        }

        public bool ExisteValor(int idOperacion, int idCampoProducto)
        {
            return GetValoresOperaciones().Any(valor => valor.IdOperacion == idOperacion && valor.IdCampoProducto == idCampoProducto);
        }

        public string GetValorPorductoPorIdProductoNombreCampoYIdOperacion(int idOperacion, int idProducto, string nombreCampoProducto)
        {
            return GetValoresOperaciones().Where(valor => valor.IdOperacion == idOperacion && valor.CamposProductos.IdProducto == idProducto && valor.CamposProductos.Nombre == nombreCampoProducto).FirstOrDefault().Valor;
        }

        public bool ExisteValor(int idOperacion, int idProducto, string nombreCampoProducto)
        {
            return GetValoresOperaciones().Any(valor => valor.IdOperacion == idOperacion && valor.CamposProductos.IdProducto == idProducto && valor.CamposProductos.Nombre == nombreCampoProducto);
        }

        public bool ActualizarValor(int idOperacion, int idCampoProducto, string valor)
        {
            var valorOperacionBD = GetValoresOperaciones().First(valorOperacion => valorOperacion.IdOperacion == idOperacion && valorOperacion.IdCampoProducto == idCampoProducto);
            valorOperacionBD.Valor = valor;
            valorOperacionBD.Insertado = DateTime.Now;
            return (UpdateValoresOperaciones(valorOperacionBD) > 0);
        }
        
        public bool ActualizarValor(int idOperacion, int idProducto, string nombreCampoProducto, string valor)
        {
            var valorOperacionBD = GetValoresOperaciones().FirstOrDefault( valorOperacion => 
                valorOperacion.IdOperacion == idOperacion
                && valorOperacion.CamposProductos.Nombre == nombreCampoProducto 
                && valorOperacion.CamposProductos.IdProducto == idProducto);
            if (valorOperacionBD != null)
            {
                valorOperacionBD.Valor = valor;
                valorOperacionBD.Insertado = DateTime.Now;
                return (UpdateValoresOperaciones(valorOperacionBD) > 0);
            }
            else
                return false;
        }

        public override async Task<ValoresOperaciones> CreateValoresOperacionesAsync(ValoresOperaciones source)
        {
            source.Valor = source.Valor;
            return await base.CreateValoresOperacionesAsync(source);

        }

        public override ValoresOperaciones CreateValoresOperaciones(ValoresOperaciones source)
        {
            source.Valor = source.Valor;
            return base.CreateValoresOperaciones(source);
        }
    }
}
