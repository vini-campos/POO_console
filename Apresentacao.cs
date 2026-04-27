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
            btnObj01.Text = " Clicar ";
            btnObj01.Location = new Point(50, 50);
            btnObj01.Click += clicar;


            //carro01.setMarca("Fiat");
            //this.txtMarca.Text = carro01.GetMarca();
            carro01.Marca = "Fiat";
            txtMarca.Text = " marca: " + carro01.Marca;
            txtMarca.Location = new Point(300, 300);
            txtModelo.Location = new Point(300, 325);
            txtVelocidade.Location = new Point(300, 350);
            txtAno.Location = new Point(300, 370);
            

            
            img.SizeMode = PictureBoxSizeMode.AutoSize;
            img.Width = 50;
            img.Height = 100;
            img.Location = new Point(300, 50);


            this.Controls.AddRange(new Control[] { btnObj01});

            


        }

        // metodo de evento
        private void clicar(object sender, EventArgs e)
        {

            carro01.Ano = 2020;
            carro01.Modelo = "uno";
            img.Image = Image.FromFile("C:\\Users\\LabInfo\\Desktop\\POO\\img\\uno.jpg");
            carro01.Velocidade = "3000000 km/h";
            carro01.Marca = "Fiat";
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
            this.ResumeLayout(false);

        }
    }
}
