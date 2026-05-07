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
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Velocidade { get; set; }
        public int Ano { get; set; }
        public string imagen { get; set; }

        /*  
          private string Marca;

          public void SetMarca(string marca) {
                  Marca = marca;
          }

          public string GetMarca() {
               return Marca;
          }
         */

        // criar um constructor para a classe automovel
        public Automovel()
        {

        }

        public Automovel(string marca)
        {
            this.Marca = marca;
        }

        public void Acelerar()
        {
            Console.WriteLine("Acelerando o carro");
        }

        public string Acelerar(string velocidade)
        {
            return " Acelerando o carro a " + velocidade + " KM/H";
        }

        public int Acelerar(int velocidade)
        {
            return velocidade + 10;
        }

        public virtual string Frear()
        {
            return "Freando o carro";
        }

    }
}
