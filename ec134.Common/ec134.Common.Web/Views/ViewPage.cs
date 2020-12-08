using ec134.Common.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ec134.Common.Web.Views
{
    /// <summary>
    /// Sobrecarga de la clase de sistema WebViewPage
    /// </summary>
    public abstract class ViewPage : WebViewPage
    {
        /// <summary>
        /// Usuario en la session
        /// </summary>
        public virtual new UserPrincipal User
        {
            get { return Session["UserToken"] as UserPrincipal; }
        }
    }
    /// <summary>
    /// Sobrecarga de la clase de sistema WebViewPage TModel
    /// </summary>
    /// <typeparam name="TModel">Modelo que se pasa a la vista</typeparam>
    public abstract class ViewPage<TModel> : WebViewPage<TModel>
    {
        /// <summary>
        /// Usuario en la session
        /// </summary>
        public virtual new UserPrincipal User
        {
            get { return Session["UserToken"] as UserPrincipal; }
        }
    }
}
