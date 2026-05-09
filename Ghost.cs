using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POO
{
    internal class Ghost : Monstro
    {
        public Ghost()
        {
            Nome = "Leviatã fantasma";
            Aparencia = "Monstro marinho com pele transparente e com leve coloração azul;";
            Movimento = "Nada silenciosamente para pegar suas presas desprevinidas";
            Tamanho = 50;
            Peso = 5000;
            Habitat = "Águas profundas na entrada das cavernas de magma";
            Imagem = Properties.Resources.Ghost;
        }

        public override string Som()
        {
            return Nome + ": Emite o som de um fantasma no momento que ataca";
        }
    }
}
