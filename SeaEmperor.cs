using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class SeaEmperor : Monstro
    {
        public SeaEmperor()
        {
            Nome = "Leviatã imperador do mar";
            Aparencia = "Monstro marinho com coloração cinza, olhos azuis e tentáculos gigantes";
            Movimento = "Se alimenta de algas e da flora do planeta 4546-B, pois não é agressivo";
            Tamanho = 75;
            Peso = 6500;
            Habitat = "Habita as profundas cavernas de magma dentro da instalação da inteligência alienígena: arquitetos";
            Imagem = Properties.Resources.Sea_emperor;
        }

        public override string Som()
        {
            return Nome + ": É capaz de se comunicar com os seres humanos através de telepatia";
        }
    }
}
