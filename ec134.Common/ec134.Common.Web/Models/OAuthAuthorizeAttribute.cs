using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ec134.Common.Web.Models
{
    /// <summary>
    /// Sobrecarga del atribute Authorize para comprobar el token en la sesión
    /// </summary>
    public class OAuthAuthorizeAttribute : AuthorizeAttribute
    {

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            UserPrincipal usuario = httpContext.Session["UserToken"] as UserPrincipal;
            if (usuario == null)
                return false;
            if (!string.IsNullOrEmpty(Roles))
                return usuario.IsInRole(Roles);
            return true;

        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
        }
    }
}
