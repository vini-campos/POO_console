using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace POO
{
    internal class Apresentacao:Form
    {
        //criar um objeto do automovel


        // objeto
        PictureBox img = new PictureBox();
        public Button btnObj01 = new Button();
        public Button btnObj02 = new Button();
        public Button btnObj03 = new Button();
        public Button btnObj04 = new Button();

        Label txtMarca = new Label();
        Label txtVelocidade = new Label();
        Label txtModelo = new Label();
        Label txtAno = new Label();

        Automovel carro01 = new Automovel();

        // toda classe tem um construtor
        public Apresentacao() 
        {
            this.Text = " Titulo ";
            this.Size = new Size(600, 600);

           

            //uno
            btnObj01.Text = "Uno";
            btnObj01.Location = new Point(50, 50);
            btnObj01.Click += clicar;

            //2
            btnObj02.Text = "Fusca";
            btnObj02.Location = new Point(50, 70);
            btnObj02.Click += clicar;

            //3
            btnObj03.Text = "Brasilia";
            btnObj03.Location = new Point(50, 90);
            btnObj03.Click += clicar;


            //carro01.setMarca("Fiat");
            //this.txtMarca.Text = carro01.GetMarca();
            carro01.Marca = "Fiat";
            txtMarca.Text = " marca: " + carro01.Marca;
            txtMarca.Location = new Point(300, 300);
            txtModelo.Location = new Point(300, 325);
            txtVelocidade.Location = new Point(300, 350);
            txtAno.Location = new Point(300, 370);
            

            
            


            this.Controls.AddRange(new Control[] { btnObj01, btnObj02, btnObj03});

            


        }

        // metodo de evento
        private void clicar(object sender, EventArgs e)
        {

            Button botao = (Button)sender;
            Console.WriteLine(botao.Text + " AGNALDO");
            switch (botao.Text)
            {
                case "Uno":
                    carro01.Velocidade = "3000000 km/h";
                    carro01.Marca = "Fiat";
                    carro01.Ano = 2020;
                    carro01.Modelo = "Uno";
                    break;
                case "Fusca":
                    carro01.Velocidade = "3 km/h";
                    carro01.Marca = "Volkswagen";
                    carro01.Ano = 1945;
                    carro01.Modelo = "Fusca";
                    break;
                case "Brasilia":
                    carro01.Velocidade = "80 km/h";
                    carro01.Marca = "Volkswagen";
                    carro01.Ano = 1995;
                    carro01.Modelo = "Brasilia";
                    break;

            }
            
            img.SizeMode = PictureBoxSizeMode.Zoom;
            img.Width = 50;
            img.Height = 100;
            
            img.Location = new Point(100, 70);

            
            
            
            
            img.Image = Image.FromFile("C:\\Users\\LabInfo\\Desktop\\ds\\img\\" + carro01.Modelo + ".jpg");
            img.Width = 200;
            img.Height = 100;
            
            MessageBox.Show("Metodo de evento");
           
            txtMarca.Text = carro01.Marca;
            txtModelo.Text = carro01.Modelo;
            txtVelocidade.Text = carro01.Velocidade;
            txtAno.Text = carro01.Ano.ToString();
            this.Controls.AddRange(new Control[] { txtMarca, btnObj01, txtAno, txtModelo, txtVelocidade, img});

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Apresentacao
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "Apresentacao";
            this.Load += new System.EventHandler(this.Apresentacao_Load);
            this.ResumeLayout(false);

        }

        private void Apresentacao_Load(object sender, EventArgs e)
        {

        }
    }
}
