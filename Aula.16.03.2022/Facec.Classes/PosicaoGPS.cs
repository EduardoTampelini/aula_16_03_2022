using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.Classes
{
    public struct PosicaoGPS
    {
        public decimal Latitude { get; private set; }
        public decimal Longitude { get; private set; }


        public PosicaoGPS(decimal latitude, decimal longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        
        public bool IsHemisferioNorte()
        {
            return Latitude > 0;
        }
    }
}
