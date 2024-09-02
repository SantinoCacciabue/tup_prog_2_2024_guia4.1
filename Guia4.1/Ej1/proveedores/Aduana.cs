using Ej1.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.proveedores
{
    internal class Aduana : IProcesadorEnvios
    {
        public double ValorFijo { get;private set; }
        public Aduana(double valorFijo)
        {
            ValorFijo = valorFijo;
        }

        public void ProcesarEnvios(IProcesable[] vec)
        {
            double valorProducto = ValorFijo;
            foreach(IProcesable a in vec )
            {
                a.CrearCosto("Costo aduanero", valorProducto);
            }
        }
    }
}
