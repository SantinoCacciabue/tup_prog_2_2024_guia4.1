using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.models
{
    abstract class Costo
    {
        public string Concepto { get; private set; }
        public virtual double ValorFinal {  get; protected set; }
        public Costo(string concepto)
        {
            Concepto = concepto;
        }
    }
}
