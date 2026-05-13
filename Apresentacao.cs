using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        Ghost GhostLeviata = new Ghost();
        SeaDragon SeaDragonLeviata = new SeaDragon();
        SeaEmperor SeaEmperorLeviata = new SeaEmperor();

        PictureBox imagem = new PictureBox();
        Label lblNome = new Label();
        Label lblAparencia = new Label();
        Label lblMovimento = new Label();
        Label lblTamanho = new Label();
        Label lblPeso = new Label();
        Label lblHabitat = new Label();
        Label lblReaperSom = new Label();
        Label lblComportamento = new Label();

        Button btnReaper = new Button();
        Button btnGhost = new Button();
        Button btnSeaDragon = new Button();
        Button btnSeaImperor = new Button();

        //panels

        Panel panelBTN = new Panel();//borda
        Panel containerBTNs = new Panel();
        Panel panelBorda = new Panel();//borda
        Panel containerTXT = new Panel();
        Panel panelIMG = new Panel();//borda



        public Apresentacao()
        {

            btnReaper.Click += clicar;
            btnGhost.Click += clicar;
            btnSeaDragon.Click += clicar;
            btnSeaImperor.Click += clicar;

            this.Text = "Monstros de Subnautica";
            this.Size = new Size(1200, 800);
            this.BackColor = Color.FromArgb(34, 65, 84);
            this.StartPosition = FormStartPosition.CenterScreen;

            btnReaper.Text = "Leviatã Ceifador";
            btnReaper.AutoSize = true;
            btnGhost.Text = "Leviatã Fantasma";
            btnGhost.AutoSize = true;
            btnSeaDragon.Text = "Dragão do Mar";
            btnSeaDragon.AutoSize = true;
            btnSeaImperor.Text = "Imperador do Mar";
            btnSeaImperor.AutoSize = true;

            //posicao e cores dos btn
            btnReaper.Location = new Point(370, 50);
            btnReaper.BackColor = Color.DarkCyan;
            btnReaper.ForeColor = Color.White;

            btnGhost.Location = new Point(480, 50);
            btnGhost.BackColor = Color.DarkCyan;
            btnGhost.ForeColor = Color.White;

            btnSeaDragon.Location = new Point(595, 50);
            btnSeaDragon.BackColor = Color.DarkCyan;
            btnSeaDragon.ForeColor = Color.White;

            btnSeaImperor.Location = new Point(695, 50);
            btnSeaImperor.BackColor = Color.DarkCyan;
            btnSeaImperor.ForeColor = Color.White;

            //posicao dos dados
            lblNome.Location = new Point(350, 150);
            lblNome.AutoSize = true;
            lblNome.ForeColor = Color.White;

            lblAparencia.Location = new Point(350, 180);
            lblAparencia.AutoSize = true;
            lblAparencia.ForeColor = Color.White;

            lblMovimento.Location = new Point(350, 210);
            lblMovimento.AutoSize = true;
            lblMovimento.ForeColor = Color.White;

            lblTamanho.Location = new Point(350, 240);
            lblTamanho.AutoSize = true;
            lblTamanho.ForeColor = Color.White;

            lblPeso.Location = new Point(350, 270);
            lblPeso.AutoSize = true;
            lblPeso.ForeColor = Color.White;

            lblHabitat.Location = new Point(350, 300);
            lblHabitat.AutoSize = true;
            lblHabitat.ForeColor = Color.White;

            lblReaperSom.Location = new Point(350, 330);
            lblReaperSom.AutoSize = true;
            lblReaperSom.ForeColor = Color.White;

            lblComportamento.Location = new Point(350, 360);
            lblComportamento.AutoSize = true;
            lblComportamento.ForeColor = Color.White;

            imagem.Size = new Size(500, 250);
            imagem.Location = new Point(350, 450);
            imagem.SizeMode = PictureBoxSizeMode.Zoom;

            //panels pra decoração

            //panel de botoes

            panelBTN.Size = new Size(450, 45);
            panelBTN.Location = new Point(360, 40);
            panelBTN.BackColor = Color.FromArgb(127, 221, 193);

            containerBTNs.Size = new Size(444, 38);
            containerBTNs.Location = new Point(363, 43);




            //panel de fundo texto (borda)


            panelBorda.Size = new Size(500, 250);
            panelBorda.Location = new Point(340, 135);

            panelBorda.BackColor = Color.FromArgb(127, 221, 193);

            //panel conteúdo do texto

            containerTXT.Size = new Size(490, 240);
            containerTXT.Location = new Point(345, 140);


            //panel img (borda)


            panelIMG.Size = new Size(510, 260);
            panelIMG.Location = new Point(345, 445);

            panelIMG.BackColor = Color.FromArgb(127, 221, 193);





            this.Controls.AddRange(new Control[] { btnReaper, btnGhost, btnSeaDragon, btnSeaImperor, lblNome, lblAparencia,
                lblMovimento, lblTamanho, lblPeso, lblHabitat, imagem, lblReaperSom, lblComportamento, containerTXT, panelBorda, containerBTNs, panelBTN});
        }


        //exibe as infomacoes do btn clicado
        private void MostrarMonstro(Monstro m)
        {
            lblNome.Text = m.Nome;
            lblAparencia.Text = m.Aparencia;
            lblMovimento.Text = m.Movimento;
            lblTamanho.Text = "Tamanho: " + m.Tamanho + " metros";
            lblPeso.Text = "Peso: " + m.Peso + " Kg";
            imagem.Image = m.Imagem;
            lblHabitat.Text = m.Descricao();
            lblReaperSom.Text = m.Som();
            lblComportamento.Text = m.estado();

            this.Controls.Add(panelIMG);
        }

        private void clicar(Object sender, EventArgs e)
        {
            if (sender == btnReaper)
            {
                MostrarMonstro(ReaperLeviata);
            }
            else if (sender == btnGhost)
            {
                MostrarMonstro(GhostLeviata);
            }
            else if (sender == btnSeaImperor)
            {
                MostrarMonstro(SeaEmperorLeviata);
            }
            else if (sender == btnSeaDragon)
            {
                MostrarMonstro(SeaDragonLeviata);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Apresentacao
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Apresentacao";
            this.Load += new System.EventHandler(this.Apresentacao_Load);
            this.ResumeLayout(false);

        }

        private void Apresentacao_Load(object sender, EventArgs e)
        {

        }
    }
}