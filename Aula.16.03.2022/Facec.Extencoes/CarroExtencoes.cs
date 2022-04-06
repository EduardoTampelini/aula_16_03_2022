using Facec.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.Extencoes
{
    public static class CarroExtencoes
    {
        public static string ObterVelocidadeFinal(this AbstractCarro carro)
        {
            return $"{carro.ObterMarca()} - {carro.ObterModelo()} :" +
                $"{carro.ObterVelocidadeFinal()} km/h";
        }
    }
}
