using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ec134.Common.Web.Models
{
    /// <summary>
    /// Sobrecarga de la interfaz
    /// </summary>
    public interface IUserPrincipal : IPrincipal
    {
        /// <summary>
        /// Email del usuario
        /// </summary>
        string Email { get; set; }

        /// <summary>
        /// Roles del usuario
        /// </summary>
        string[] Roles { get; set; }

        /// <summary>
        /// Aplicaciones del Usuario
        /// </summary>
        string[] Application { get; set; }
    }
}
