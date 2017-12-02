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
    public partial class Tela_Inicial : Form
    {
        public Tela_Inicial()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Consultar_pessoa cons = new Consultar_pessoa();
            cons.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Interface_principal principal = new Interface_principal();
            principal.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
