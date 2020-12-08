using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ec134.Bd.Model.Enum
{
    public enum TiposControl : int
    {
        Html = 0,
        Modal = 1,
        HtmlDinamico = 2,
        Hidden = 10,
        TextBox = 100,
        NumericUpDown = 101,
        Numeric = 102,
        CheckBox = 200,
        MayorDeEdad = 201,
        MultiCheckBox = 202,
        YesNo = 203,
        ComboBox = 300,
        ComboOption = 301,
        ComboDate = 302,
        ComboOptionImage = 303,
        SubidaImagen = 400,
        SubidaFichero = 401,
        Captcha = 1000,
        ControlDI = 2000,
        MultiControl = 3000,
        Logalty = 4000,
        DasNano = 5000
    }
}
