using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.models
{
    internal class Logistica
    {
        ArrayList envios = new ArrayList();
        public int CantidadEnvios
        {
            get
            {
                return envios.Count;
            }
        }
        public Envio AgregarEnvio(Envio envio)
        {
            if(envio != null)
            {
                envios.Add(envio);
            }
            return envio;
        }
        public int VerEnvioPorCodigo(int codigo)
        {
            envios.Sort();
            int i = envios.BinarySearch(new Envio("", codigo));
            return i;
        }
        public Envio VerEnvio(int i)
        {
            if (i >= 0 && i < CantidadEnvios)
            {
                return envios[i] as Envio;
            }
            return null;
        }
    }
}
