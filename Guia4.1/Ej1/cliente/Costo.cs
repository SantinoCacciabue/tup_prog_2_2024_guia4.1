using Ej1.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.cliente
{
    internal class Costo:ICosto
    {
        public double Valor { get; private set; }
        public string Concepto {  get; private set; }
        public Costo(double valor, string concepto)
        {
            Valor = valor;
            Concepto = concepto;
        }
        public override string ToString()
        {
            return $"{Concepto}-Valor:{Valor}";
        }
    }
}
