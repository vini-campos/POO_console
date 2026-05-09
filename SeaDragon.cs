using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class SeaDragon : Monstro
    {
        public SeaDragon()
        {
            Nome = "Leviatã dragão do mar";
            Aparencia = "Monstro marinho gigantesco com escamas escarlate e olhos laranja";
            Movimento = "Atinge suas presas com bolas de fogo para queima-las instantâneamente";
            Tamanho = 125;
            Peso = 8000;
            Habitat = "Habita a parte ativa das cavernas de magma, protegendo a instalação alienígena dos arquitetos";
            Imagem = Properties.Resources.Sea_Dragon;
        }

        public override string Som()
        {
            return Nome + ": Emite o som de um dragão no momento de seu ataque";
        }
    }
}
