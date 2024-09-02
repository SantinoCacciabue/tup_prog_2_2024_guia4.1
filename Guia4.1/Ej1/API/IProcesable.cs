using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.API
{
    internal interface IProcesable
    {
        int CantidadCostos { get;}
        double CostoTotal { get; }
        ICosto CrearCosto(string concepto, double valor);
        ICosto VerCosto(int i);
    }
}
