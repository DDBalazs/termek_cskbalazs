using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace termek_cskbalazs
{
    internal class Termek
    {
        string cikkszam;
        public string megnevezes;
        public int beszerzesiar;
        int afakulcs;
        bool akcios;
        int kedvezmény;
        
        public netto()
        {
            double netto = Math.Round(beszerzesiar * 1.35, 2);
        }
    }
}
