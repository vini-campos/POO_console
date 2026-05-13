using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Reaper : Monstro
    {
        public Reaper()
        {
            Nome = "Leviatã ceifador";
            Aparencia = "Monstro marinho gigante com cabeça grande e dentes afiados";
            Movimento = "Nada rapidamente para atacar suas presas";
            Tamanho = 20;
            Peso = 3500;
            Habitat = "Águas rasas do planeta 4546-B";
            Imagem = Properties.Resources.Reaper;
        }

        public override string Descricao()
        {
            return base.Descricao() + " e caça submarinos";
        }

        public override string Som()
        {
            return Nome + ": " + "Emite um rugido estremecedor";
        }
        public override string estado()
        {
            return Nome + ": é hostil ao jogador";
        }
    }
}
