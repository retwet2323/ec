using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ec134.Common.Web.Models
{
    /// <summary>
    /// Implementacion de la interfaz IUserPrincipal
    /// </summary>
    public class UserPrincipal : IUserPrincipal
    {
        /// <summary>
        /// Aplicaciones del usuario
        /// </summary>
        public string[] Application { get; set; }

        /// <summary>
        /// Aplicacion en la que esta conectado
        /// </summary>
        public string ApplicationActive { get; set; }

        /// <summary>
        /// Email del usuario
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Telefono descripcion del usuario
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// SocialName 
        /// </summary>
        public string SocialName { get; set; }

        /// <summary>
        /// Active 
        /// </summary>
        public string Active { get; set; }

        /// <summary>
        /// FirsTime 
        /// </summary>
        public string FirstTime { get; set; }

        /// <summary>
        /// Implementacion de la interfaz IIdentity
        /// </summary>
        public IIdentity Identity { get; set; }

        /// <summary>
        /// Roles del usuario
        /// </summary>
        public string[] Roles { get; set; }

        /// <summary>
        /// Id del Usuario
        /// </summary>
        public string Id { get; set; }


        /// <summary>
        /// Id del Usuario
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Es Administrador o no
        /// </summary>
        public bool IsAdministrator
        {
            get
            {
                return IsInRole("Admin") || IsInRole("Administrador");
            }
        }

        /// <summary>
        /// Comprueba si un usuario esta en un Rol
        /// </summary>
        /// <param name="role">Rol a comprobar</param>
        /// <returns>Verdadero o Falso</returns>
        public bool IsInRole(string role)
        {
            return Roles.Contains(role);
        }


    }
}
