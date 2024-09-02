using Ej1.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.proveedores
{
    internal class Transporte: IProcesadorEnvios
    {
        public double DistanciaKm { get; private set; }

        public double PrecioKm { get; private set; }
        public Transporte(double distanciaKm, double precioKm)
        {
            DistanciaKm = distanciaKm;
            PrecioKm = precioKm;
        }

        public void ProcesarEnvios(IProcesable[] vec)
        {
            double valorProducto = (DistanciaKm*PrecioKm)/vec.Length;
            foreach(IProcesable p in vec)
            {
                p.CrearCosto("Costo de transporte por unidad", valorProducto);
            }
        }
    }
}
