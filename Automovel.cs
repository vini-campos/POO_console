using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Automovel
    {
        // criar as propriedades da classe automovel
        public string Marca;
        public string Modelo { get; set; }
        public string Velocidade { get; set; }
        public int Ano { get; set; }
        

        public string Imagem { get; set; }

        public void setMarca(string marca)
        {
            Marca = marca;
        }

        public string GetMarca()
        {
            return Marca;
        }

    }
}
