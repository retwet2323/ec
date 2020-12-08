using ec134.Auth.Service.Aplicacion.Entidades;
using ec134.Auth.Service.Aplicacion.Servicios;
using ec134.Common.Web.Common;
using ec134.Common.Web.Models;
using System;
using System.Configuration;
using System.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;

namespace ec134.Common.Web.Controller
{
    /// <summary>
    /// Sobrecarga de la clase Controller
    /// </summary>
    public class AuthController : System.Web.Mvc.Controller
    {
        public readonly ServicioVerificacion _servicioVerificacion;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public AuthController()
        {
            _servicioVerificacion = new ServicioVerificacion();
        }

        /// <summary>
        /// Funcion que guarda el token en la Sesion.
        /// </summary>
        public void SaveTokenInSession()
        {
            var header = Request.Headers.Get("Authorization").Replace("Bearer ", string.Empty);
            JwtSecurityToken token = TokenDecrypt.ReadToken(header);

            Session["UserToken"] = new UserPrincipal()
            {
                Id = token.Claims.Where(x => x.Type == "Id").Select(x => x.Value).FirstOrDefault(),
                Email = token.Claims.Where(x => x.Type == "Email").Select(x => x.Value).FirstOrDefault(),
                Phone = token.Claims.Where(x => x.Type == "Phone").Select(x => x.Value).FirstOrDefault(),
                Active = token.Claims.Where(x => x.Type == "Active").Select(x => x.Value).FirstOrDefault(),
                FirstTime = token.Claims.Where(x => x.Type == "FirstTime").Select(x => x.Value).FirstOrDefault(),
                SocialName = token.Claims.Where(x => x.Type == "SocialName").Select(x => x.Value).FirstOrDefault(),
                Roles = token.Claims.Where(x => x.Type == "Role").Select(x => x.Value).ToArray(),
                Application = token.Claims.Where(x => x.Type == "Application").Select(x => x.Value).ToArray(),
                ApplicationActive = token.Claims.Where(x => x.Type == "ApplicationActive").Select(x => x.Value).FirstOrDefault(),
                ClientId = token.Claims.Where(x => x.Type == "ClientId").Select(x => x.Value).FirstOrDefault()
            };
        }

        /// <summary>
        /// Usuario conectado a la Sesion
        /// </summary>
        protected virtual new UserPrincipal User
        {
            get { return Session["UserToken"] as UserPrincipal; }
        }

        /// <summary>
        /// Comprueba si el usuario tiene una licencia valida
        /// </summary>
        /// <param name="numeroFicheros">Numero de ficheros a Procesar</param>
        /// <returns>Verdadero o False</returns>
        protected async Task<bool> ComprobarLicencia(int numeroFicheros)
        {
            string ensamblado = ConfigurationManager.AppSettings["Ensamblado"];
            if (string.IsNullOrEmpty(ensamblado))
                throw new ArgumentException("No se ha encontrado el nombre del ensamblado en el archivo de configuración");

            RespuestaLicencia respuestaLicencia = await _servicioVerificacion.Verificar(new PeticionLicencia()
            {
                ClientKey = User.ClientId,
                Hits = numeroFicheros,
                Platform = TipoPlataforma.Web,
                App = ensamblado,
            });

            return respuestaLicencia.CodigoError == 0;

        }

    }
}
