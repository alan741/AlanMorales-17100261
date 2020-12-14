using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpacyWings.Controllers
{
    public class PagoIva : IPagoIVA
    {
        public decimal ObtenerMasIva(decimal param)
        {
            return param * 1.16M;
        }
    }
}