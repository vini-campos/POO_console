using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace POO
{
    class Apresentacao : Form
    {
        Monstro Leviata1 = new Monstro();

        // Objeto
        PictureBox imagem = new PictureBox();
        Label lblNome = new Label();
        Label lblAparencia = new Label();
        Label lblMovimento = new Label();
        Label lblTamanho = new Label();
        Label lblPeso = new Label();
        Label lblHabitat = new Label();

        //btn dos monstros
        Button btnReaper = new Button();
        Button btnGhost = new Button();
        Button btnSeaDragon = new Button();
        Button btnSeaImperor = new Button();

        // toda classe tem um construtor
        public Apresentacao()
        {
            btnReaper.Click += clicar;

            this.Text = "Monstros de Subnautica";
            this.Size = new Size(800, 600);

            btnReaper.Text = "Leviatã Ceifador";
            btnReaper.AutoSize = true;
            btnGhost.Text = "Leviatã Fantasma";
            btnGhost.AutoSize = true;
            btnSeaDragon.Text = "Dragão do Mar";
            btnSeaDragon.AutoSize = true;
            btnSeaImperor.Text = "Imperador do Mar";
            btnSeaImperor.AutoSize = true;

            btnReaper.Location = new Point(190, 50);
            btnGhost.Location = new Point(290, 50);
            btnSeaDragon.Location = new Point(390, 50);
            btnSeaImperor.Location = new Point(490, 50);

            this.Controls.AddRange(new Control[] { btnReaper, btnGhost, btnSeaDragon, btnSeaImperor, lblNome, lblAparencia,
                lblMovimento, lblTamanho, lblPeso, lblHabitat, imagem });
        }

        // metodo de Evento

        private void clicar(Object sender, EventArgs e)
        {
            Leviata1.Nome = "Leviatã Ceifador";
            Leviata1.Aparencia = "Monstro marinho gigante com cabeça grande e dentes afiados";
            Leviata1.Movimento = "Nada rapidamente para atacar suas presas";
            Leviata1.Tamanho = "20 metros";
            Leviata1.Peso = "5000 kg";
            Leviata1.Habitat = "Águas profundas do planeta 4546B";

            lblNome.Text = "Nome: " + Leviata1.Nome;
            lblNome.Location = new Point(50,150);
            lblNome.AutoSize = true;
            lblAparencia.Text = "Aparência: " + Leviata1.Aparencia;
            lblAparencia.Location = new Point(50, 180);
            lblAparencia.AutoSize = true;
            lblMovimento.Text = "Movimento: " + Leviata1.Movimento;
            lblMovimento.Location = new Point(50, 210);
            lblMovimento.AutoSize = true;
            lblTamanho.Text = "Tamanho: " + Leviata1.Tamanho;
            lblTamanho.Location = new Point(50, 240);
            lblTamanho.AutoSize = true;
            lblPeso.Text = "Peso: " + Leviata1.Peso;
            lblPeso.Location = new Point(50, 270);
            lblPeso.AutoSize = true;
            lblHabitat.Text = "Habitat: " + Leviata1.Habitat;
            lblHabitat.Location = new Point(50, 300);
            lblHabitat.AutoSize = true;

        }

    }
}

//criar outra classe para armazenar dados dos monstros