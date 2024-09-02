using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.models
{
    internal class Envio:IComparable
    {
        public ArrayList costos = new ArrayList();
        public int CodigoAduanero { get; private set; }
        public string Empresa {  get; private set; }
        public double ValorFinal
        {
            get
            {
                double valor = 0;
                foreach(Costo c in costos)
                {
                    valor += c.ValorFinal;
                }
                return valor;
            }
        }
        public Envio(string empresa, int codigo)
        {
            Empresa = empresa;
            CodigoAduanero = codigo;
        }
        public void AgregarCosto(Costo nuevo)
        {
            if (nuevo != null)
            {
                costos.Add(nuevo);
            }
        }

        public int CompareTo(object obj)
        {
            Envio envio = obj as Envio;
            if (envio != null)
            {
                return CodigoAduanero.CompareTo(envio.CodigoAduanero);
            }
            return 1;
        }
        public override string ToString()
        {
            return $"Empresa: {Empresa}--Código aduanero: {CodigoAduanero}--Total:{ValorFinal}\r\n";
        }
    }
}
