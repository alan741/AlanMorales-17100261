using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpacyWings.Controllers
{
    public class Fabrica
    {
        public const int Iva16 = 1;

        public static PagoIva CrearPago(int pago)
        {
            switch (pago)
            {
                case Iva16:
                    return new PagarIVA16();
                default: return null;
            }
        }
    }
}