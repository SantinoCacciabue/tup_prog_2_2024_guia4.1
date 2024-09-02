using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.models
{
    internal class Fijo : Costo
    {
        public Fijo(string concepto, double valorFinal) : base(concepto)
        {
            ValorFinal = valorFinal;
        }
        public override string ToString()
        {
            return $"Costo fijo:{ValorFinal}\r\n";
        }
    }
}
