using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_casa_transitoria
{
    public partial class Pagina_inicial : Form
    {
        private Interface_principal interface_principal;

        public Pagina_inicial()
        {
            InitializeComponent();
        }

        public Pagina_inicial(Interface_principal interface_principal)
        {
            // TODO: Complete member initialization
            this.interface_principal = interface_principal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Interface_principal principal = new Interface_principal();
            principal.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Consultar_pessoa cons = new Consultar_pessoa();
            cons.Show();
        }
    }
}
