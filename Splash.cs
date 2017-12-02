using Projeto_casa_transitoria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Casa_Transitoria
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        //incrementa a barra do progressbar e depois fecha o splah
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 2;
            }
            else
            {
                timer1.Enabled = false;
                Tela_Inicial login = new Tela_Inicial();
                login.Show();
                this.Visible = false;
            }
        }


    }
}
