using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Monstro
    {
        public string Nome { get; set; }
        public string Aparencia { get; set; }
        public string Movimento { get; set; }
        public int Tamanho { get; set; }
        public int Peso { get; set; }
        public string Habitat { get; set; }

        public Image Imagem { get; set; }

        

        public virtual string Descricao()
        {
            return "Vive em: " + Habitat;
        }

        public virtual string Som()
        {
            return Nome + ": Som genérico";
        }

        public virtual string estado()
        {
            return Nome + ": Estado genérico";
        }
    }
}
