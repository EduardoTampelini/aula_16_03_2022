using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.Classes
{
    public sealed class Cooper : AbstractCarro
    {
        public override string ObterMarca()
        {
            return "Mini";
        }

        public override string ObterModelo()
        {
            return "Cooper";
        }

        public override int ObterVelocidade()
        {
            return 199;
        }
        public override string RelatorioDeManutencao()
        {
            return $"Esse método foi sobrescrito \n" +
                base.RelatorioDeManutencao();
        }
    }
}
