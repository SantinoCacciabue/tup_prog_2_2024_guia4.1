using Ej1.API;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.cliente
{
    internal class Envio : IProcesable, IComparable
    {
        ArrayList costos = new ArrayList();
        public int NumeroAduanero { get;private set; }
        public double CostoTotal {  get;private set; }
        public int CantidadCostos
        {
            get
            {
                return costos.Count;
            }
        }
        public Envio(int nroAduanero)
        {
            NumeroAduanero = nroAduanero;
        }
        public int CompareTo(object obj)
        {
            Envio envio = obj as Envio;
            if(envio != null)
            {
                return NumeroAduanero.CompareTo(envio.NumeroAduanero);
            }
            return -1;
        }

        public ICosto CrearCosto(string concepto, double valor)
        {
            ICosto costo = new Costo(valor, concepto);
            costos.Add(costos);
            return costo;
        }

        public ICosto VerCosto(int i)
        {
            if (i >= 0 && i < CantidadCostos)
            {
                return costos[i] as ICosto;
            }
            return null;
        }
        public override string ToString()
        {
            return $"Envio: {NumeroAduanero}";
        }
    }
}
