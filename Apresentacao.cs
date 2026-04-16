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
        // objeto
        public Button btnObj01 = new Button();

        // toda classe tem um construtor
        public Apresentacao() 
        {
            this.Text = " Titulo ";
            this.Size = new Size(600, 600);
            btnObj01.Text = " Clicar ";
            btnObj01.Location = new Point(50, 50);
            btnObj01.Click += clicar;
            this.Controls.Add(btnObj01);

        }

        // metodo de evento
        private void clicar(object sender, EventArgs e)
        {
            MessageBox.Show("Metodo de evento");
        }
    }
}
