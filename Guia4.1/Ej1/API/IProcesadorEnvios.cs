using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.API
{
    internal interface IProcesadorEnvios
    {
        void ProcesarEnvios(IProcesable[] vec);
    }
}
