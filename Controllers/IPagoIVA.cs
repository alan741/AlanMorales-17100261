using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacyWings.Controllers
{
    interface IPagoIVA
    {
        decimal ObtenerMasIva(decimal param);
    }
}
