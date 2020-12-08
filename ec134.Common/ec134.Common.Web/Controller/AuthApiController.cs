using ec134.Auth.Service.Aplicacion.Entidades;
using ec134.Auth.Service.Aplicacion.Servicios;
using ec134.Common.Web.Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ec134.Common.Web.Controller
{
    /// <summary>
    /// Sobrecarga de la clase de sistema ApiController
    /// </summary>
    public class AuthApiController : System.Web.Http.ApiController
    {
        private readonly ServicioVerificacion _servicioVerificacion;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public AuthApiController()
        {
            _servicioVerificacion = new ServicioVerificacion();
        }

        /// <summary>
        /// Informacion del token
        /// </summary>
        public JwtSecurityToken JwtSecurityToken
        {
            get
            {
                return TokenDecrypt.ReadToken(Request.Headers.Authorization.Parameter);
            }
        }
        
        /// <summary>
        /// Id del Usuario
        /// </summary>
        public string Id
        {
            get
            {
                return JwtSecurityToken.Claims.Where(x => x.Type == "Id").Select(x => x.Value).FirstOrDefault();
            }
        }
        /// <summary>
        /// Email del usuario
        /// </summary>
        public string Email
        {
            get
            {
                return JwtSecurityToken.Claims.Where(x => x.Type == "Email").Select(x => x.Value).FirstOrDefault();
            }
        }

        /// <summary>
        /// Telefono
        /// </summary>
        public string Phone
        {
            get
            {
                return JwtSecurityToken.Claims.Where(x => x.Type == "Phone").Select(x => x.Value).FirstOrDefault();
            }
        }

        /// <summary>
        /// SocialName
        /// </summary>
        public string SocialName
        {
            get
            {
                return JwtSecurityToken.Claims.Where(x => x.Type == "SocialName").Select(x => x.Value).FirstOrDefault();
            }
        }


        /// <summary>
        /// Active
        /// </summary>
        public string Active
        {
            get
            {
                return JwtSecurityToken.Claims.Where(x => x.Type == "Active").Select(x => x.Value).FirstOrDefault();
            }
        }

        /// <summary>
        /// FirstTime
        /// </summary>
        public string FirstTime
        {
            get
            {
                return JwtSecurityToken.Claims.Where(x => x.Type == "FirstTime").Select(x => x.Value).FirstOrDefault();
            }
        }

        /// <summary>
        /// ClientId del usuario
        /// </summary>
        public string ClientId
        {
            get
            {
                return JwtSecurityToken.Claims.Where(x => x.Type == "ClientId").Select(x => x.Value).FirstOrDefault();
            }
        }


        /// <summary>
        /// Aplicacion en la que esta conectado
        /// </summary>
        public string ApplicationActive
        {
            get
            {
                return JwtSecurityToken.Claims.Where(x => x.Type == "ApplicationActive").Select(x => x.Value).FirstOrDefault();
            }
        }

        /// <summary>
        /// Roles del usuario
        /// </summary>
        public string[] Roles
        {
            get
            {
                return JwtSecurityToken.Claims.Where(x => x.Type == "Role").Select(x => x.Value).ToArray();
            }
        }

        /// <summary>
        /// Aplicaciones del usuario
        /// </summary>
        public string[] Applications
        {
            get
            {
                return JwtSecurityToken.Claims.Where(x => x.Type == "Application").Select(x => x.Value).ToArray();
            }
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
                ClientKey = ClientId,
                Hits = numeroFicheros,
                Platform = TipoPlataforma.Web,
                App = ensamblado,
            });

            return respuestaLicencia.CodigoError == 0;

        }

    }
}
