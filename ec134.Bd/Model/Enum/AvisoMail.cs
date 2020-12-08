using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ec134.Bd.Model.Enum
{
    public enum AvisoMail:int
    {
        Aviso6Horas = 0,
        Aviso12Horas = 1,
        Aviso20Horas = 2,
        Eliminacion24Horas = 3,
        CaducadasPendientes = 4,
        Aviso12HorasRecovery = 5,
        Aviso24HorasRecovery = 6,
        Aviso36HorasRecovery = 7,
        Eliminacion48HorasRecovery = 8,
        CaducadasPendientesRecovery = 9,
        Denegada = 10
    }
}
