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

        Button btnReaper = new Button();
        Button btnGhost = new Button();
        Button btnSeaDragon = new Button();
        Button btnSeaImperor = new Button();

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
            lblNome.Location = new Point(50, 150);
            lblNome.AutoSize = true;
            lblNome.ForeColor = Color.White;

            lblAparencia.Location = new Point(50, 180);
            lblAparencia.AutoSize = true;
            lblAparencia.ForeColor = Color.White;

            lblMovimento.Location = new Point(50, 210);
            lblMovimento.AutoSize = true;
            lblMovimento.ForeColor = Color.White;

            lblTamanho.Location = new Point(50, 240);
            lblTamanho.AutoSize = true;
            lblTamanho.ForeColor = Color.White;

            lblPeso.Location = new Point(50, 270);
            lblPeso.AutoSize = true;
            lblPeso.ForeColor = Color.White;

            lblHabitat.Location = new Point(50, 300);
            lblHabitat.AutoSize = true;
            lblHabitat.ForeColor = Color.White;

            lblReaperSom.Location = new Point(50, 330);
            lblReaperSom.AutoSize = true;
            lblReaperSom.ForeColor = Color.White;

            imagem.Size = new Size(500, 300);
            imagem.Location = new Point(350, 450);
            imagem.SizeMode = PictureBoxSizeMode.Zoom;

            this.Controls.AddRange(new Control[] { btnReaper, btnGhost, btnSeaDragon, btnSeaImperor, lblNome, lblAparencia,
                lblMovimento, lblTamanho, lblPeso, lblHabitat, imagem, lblReaperSom });
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
    }
}