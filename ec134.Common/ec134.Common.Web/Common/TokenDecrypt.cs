using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ec134.Common.Web.Common
{
    /// <summary>
    /// Clase que se utiliza para sacar los datos del Token
    /// </summary>
    public static class TokenDecrypt
    {
        /// <summary>
        /// Función que lee el Token
        /// </summary>
        /// <param name="token">Token de autentificación</param>
        /// <returns>Información del token</returns>
        public static JwtSecurityToken ReadToken(string token)
        {
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            return handler.ReadToken(token) as JwtSecurityToken;
        }
    }
}
