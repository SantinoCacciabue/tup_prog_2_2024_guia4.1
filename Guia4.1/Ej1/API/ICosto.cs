using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.API
{
    internal interface ICosto
    {
        string Concepto {  get; }
        double Valor {  get; }
    }
}
