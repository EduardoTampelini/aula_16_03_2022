using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.Classes
{
    public abstract class AbstractCarro
    {
        public abstract string ObterMarca();
        public abstract string ObterModelo();

        public bool ObterVelocidadeFinal()
        {
            throw new NotImplementedException();
        }

        public abstract int ObterVelocidade();

        public virtual string RelatorioDeManutencao()
        {
            return $"{ObterMarca()} -" +
                $"{ObterModelo()} \n" +
                $"TESTE TESTE";
        }



    }
}
