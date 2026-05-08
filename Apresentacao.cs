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
        Reaper ReaperLeviata = new Reaper();
        Monstro GhostLeviata = new Monstro();
        Monstro SeaDragonLeviata = new Monstro();
        Monstro SeaEmperorLeviata = new Monstro();

        // Objeto
        PictureBox imagem = new PictureBox();
        Label lblNome = new Label();
        Label lblAparencia = new Label();
        Label lblMovimento = new Label();
        Label lblTamanho = new Label();
        Label lblPeso = new Label();
        Label lblHabitat = new Label();
        Label lblReaperSom = new Label();

        //btn dos monstros
        Button btnReaper = new Button();
        Button btnGhost = new Button();
        Button btnSeaDragon = new Button();
        Button btnSeaImperor = new Button();

        // toda classe tem um construtor
        public Apresentacao()
        {
            btnReaper.Click += clicar;
            btnGhost.Click += clicar;
            btnSeaDragon.Click += clicar;
            btnSeaImperor.Click += clicar;

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

            //reaper
            ReaperLeviata.Nome = "Leviatã ceifador";
            ReaperLeviata.Aparencia = "Monstro marinho gigante com cabeça grande e dentes afiados";
            ReaperLeviata.Movimento = "Nada rapidamente para atacar suas presas";
            ReaperLeviata.Tamanho = "20 metros";
            ReaperLeviata.Peso = "3500 kg";
            ReaperLeviata.Habitat = "Águas rasas do planeta 4546-B";
            //ghost
            GhostLeviata.Nome = "Leviatã fantasma";
            GhostLeviata.Aparencia = "Monstro marinho com pele transparente e com leve coloração azul;";
            GhostLeviata.Movimento = "Nada silenciosamente para pegar suas presas desprevinidas";
            GhostLeviata.Tamanho = "50 metros";
            GhostLeviata.Peso = "5000 kg";
            GhostLeviata.Habitat = "Águas profundas na entrada das cavernas de magma";
            //seaEmperor
            SeaEmperorLeviata.Nome = "Leviatã imperador do mar";
            SeaEmperorLeviata.Aparencia = "Monstro marinho com coloração cinza, olhos azuis e tentáculos gigantes";
            SeaEmperorLeviata.Movimento = "Se alimenta de algas e da flora do planeta 4546-B, pois não é agressivo";
            SeaEmperorLeviata.Tamanho = "75 metros";
            SeaEmperorLeviata.Peso = "6500 kg";
            SeaEmperorLeviata.Habitat = "Habita as profundas cavernas de magma dentro da instalação da inteligência alienígena: arquitetos";
            //SeaDragon
            SeaDragonLeviata.Nome = "Leviatã dragão do mar";
            SeaDragonLeviata.Aparencia = "Monstro marinho gigantesco com escamas escarlate e olhos laranja";
            SeaDragonLeviata.Movimento = "Atinge suas presas com bolas de fogo para queima-las instantâneamente";
            SeaDragonLeviata.Tamanho = "125 metros";
            SeaDragonLeviata.Peso = "8000 kg";
            SeaDragonLeviata.Habitat = "Habita a parte ativa das cavernas de magma, protegendo a instalação alienígena dos arquitetos";

            btnReaper.Location = new Point(190, 50);
            btnGhost.Location = new Point(290, 50);
            btnSeaDragon.Location = new Point(390, 50);
            btnSeaImperor.Location = new Point(490, 50);

            //posicao dos dados
            lblNome.Location = new Point(50, 150);
            lblNome.AutoSize = true;

            lblAparencia.Location = new Point(50, 180);
            lblAparencia.AutoSize = true;

            lblMovimento.Location = new Point(50, 210);
            lblMovimento.AutoSize = true;

            lblTamanho.Location = new Point(50, 240);
            lblTamanho.AutoSize = true;

            lblPeso.Location = new Point(50, 270);
            lblPeso.AutoSize = true;

            lblHabitat.Location = new Point(50, 300);
            lblHabitat.AutoSize = true;

            lblReaperSom.Location = new Point(50, 330);
            lblReaperSom.AutoSize = true;

            this.Controls.AddRange(new Control[] { btnReaper, btnGhost, btnSeaDragon, btnSeaImperor, lblNome, lblAparencia,
                lblMovimento, lblTamanho, lblPeso, lblHabitat, imagem });
        }

        // metodo de Evento

        private void clicar(Object sender, EventArgs e)
        {
            if (sender == btnReaper)
            {
                lblNome.Text = ReaperLeviata.Nome;
                lblAparencia.Text = ReaperLeviata.Aparencia;
                lblMovimento.Text = ReaperLeviata.Movimento;
                lblTamanho.Text = ReaperLeviata.Tamanho;
                lblPeso.Text = ReaperLeviata.Peso;
                lblHabitat.Text = ReaperLeviata.Descricao();
                lblHabitat.Text = ReaperLeviata.Som();
            }
            else if (sender == btnGhost)
            {
                lblNome.Text = GhostLeviata.Nome;
                lblAparencia.Text = GhostLeviata.Aparencia;
                lblMovimento.Text = GhostLeviata.Movimento;
                lblTamanho.Text = GhostLeviata.Tamanho;
                lblPeso.Text = GhostLeviata.Peso;
                lblHabitat.Text = GhostLeviata.Habitat;
            }
            else if (sender == btnSeaImperor)
            {
                lblNome.Text = SeaEmperorLeviata.Nome;
                lblAparencia.Text = SeaEmperorLeviata.Aparencia;
                lblMovimento.Text = SeaEmperorLeviata.Movimento;
                lblTamanho.Text = SeaEmperorLeviata.Tamanho;
                lblPeso.Text = SeaEmperorLeviata.Peso;
                lblHabitat.Text = SeaEmperorLeviata.Habitat;
            }
            else if (sender == btnSeaDragon)
            {
                lblNome.Text = SeaDragonLeviata.Nome;
                lblAparencia.Text = SeaDragonLeviata.Aparencia;
                lblMovimento.Text = SeaDragonLeviata.Movimento;
                lblTamanho.Text = SeaDragonLeviata.Tamanho;
                lblPeso.Text = SeaDragonLeviata.Peso;
                lblHabitat.Text = SeaDragonLeviata.Habitat;
            }
        }
    }
}
//adicionar a imagem em cada um
