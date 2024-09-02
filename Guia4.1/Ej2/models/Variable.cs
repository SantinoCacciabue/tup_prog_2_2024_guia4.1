using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.models
{
    internal class Variable:Costo
    {
        public double PrecioPorUnidad { get; private set; }
        
        public double Unidades {  get; private set; }
        public override double ValorFinal
        {
            get
            {
                return PrecioPorUnidad * Unidades;
            }
        }
        public Variable(double precioPorUnidad, double unidades, string concepto):base(concepto)
        {
            PrecioPorUnidad = precioPorUnidad;
            Unidades = unidades;
        }
        public override string ToString()
        {
            return $"Costo variable:{ValorFinal}\r\n";
        }
    }

}
