using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Projeto_casa_transitoria;
using Projeto_Casa_Transitoria;

namespace Projeto_casa_transitoria
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, System.EventArgs e)
        {
            bool result;

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Banco_de_dados con = new Banco_de_dados();
                var conexao = con.abrir_conexao();

                string inserir = @"SELECT count(*) from Login where Usuario = '" + textBox1.Text + "' and Senha = '" + textBox2.Text + "'";

                SqlCommand cmd = new SqlCommand(inserir, conexao);
                SqlDataReader dados = cmd.ExecuteReader();
                result = dados.HasRows;
                if (result)
                {
                    Splash sp = new Splash();
                    sp.Show();
                    Visible = false;
                }
                conexao.Close();
            }

            else
            {
                MessageBox.Show("Informe usuário ou senha", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool result;

                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    Banco_de_dados con = new Banco_de_dados();
                    var conexao = con.abrir_conexao();

                    string inserir = @"SELECT count(*) from Login where Usuario = '" + textBox1.Text + "' and Senha = '" + textBox2.Text + "'";

                    SqlCommand cmd = new SqlCommand(inserir, conexao);
                    SqlDataReader dados = cmd.ExecuteReader();
                    result = dados.HasRows;
                    if (result)
                    {
                        Splash sp = new Splash();
                        sp.Show();
                        Visible = false;
                    }
                    conexao.Close();
                }

                else
                {
                    MessageBox.Show("Informe usuário ou senha", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool result;

                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    Banco_de_dados con = new Banco_de_dados();
                    var conexao = con.abrir_conexao();

                    string inserir = @"SELECT count(*) from Login where Usuario = '" + textBox1.Text + "' and Senha = '" + textBox2.Text + "'";

                    SqlCommand cmd = new SqlCommand(inserir, conexao);
                    SqlDataReader dados = cmd.ExecuteReader();
                    result = dados.HasRows;
                    if (result)
                    {
                        Splash sp = new Splash();
                        sp.Show();
                        Visible = false;
                    }
                    conexao.Close();
                }

                else
                {
                    MessageBox.Show("Informe usuário ou senha", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        
    }
}
