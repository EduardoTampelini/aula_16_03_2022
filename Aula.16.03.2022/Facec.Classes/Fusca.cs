using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.Classes
{
    public class Fusca : AbstractCarro
    {
        public override string ObterMarca()
        {
            return "Volkswagem";
        }

        public override string ObterModelo()
        {
            return "New Fusca";
        }

        public override int ObterVelocidade()
        {
            return 225;
        }
    }
}
