using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
        internal class Reaper : Monstro
        {
            public override string Descricao()
            {
                return base.Descricao() + " e caça submarinos";
            }

            public override string Som()
            {
                return "Emite um rugido estremecedor";
            }
        }
}
