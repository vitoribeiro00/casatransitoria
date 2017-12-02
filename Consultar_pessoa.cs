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
    public partial class Consultar_pessoa : Form
    {
        //Interface_principal teste = new Interface_principal();
        Interface_principal teste { get; set; }

        public Consultar_pessoa()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        public Consultar_pessoa(Interface_principal interfac)
        {
            InitializeComponent();
            radioButton1.Checked = true;
            teste = interfac;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                dataGridView1.DataSource = null;
                if (textBox1.Text != "")
                {
                    Paciente pes = new Paciente();
                    pes.consultar_cliente_Nome(dataGridView1, textBox1.Text);
                }
            }
            else
            {
                dataGridView1.DataSource = null;
                if (textBox1.Text != "")
                {
                    Paciente pes = new Paciente();
                    pes.consultar_cliente_CPF(dataGridView1, textBox1.Text);
                }
            }
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bool isNova = false;

            if (teste == null)
            {
                teste = new Interface_principal();
                isNova = true;
            }

            #region codigo

            int id_cliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Paciente paciente = new Paciente();
            DataTable tabela = paciente.consultar_cliente_id_cliente(Convert.ToString(id_cliente));

            teste.textBox27.Text = tabela.Rows[0]["Nome"].ToString();
            teste.textBox3.Text = Convert.ToString(id_cliente);
            teste.textBox56.Text = Convert.ToString(id_cliente);
            teste.textBox25.Text = tabela.Rows[0]["Apelido"].ToString();
            teste.textBox24.Text = tabela.Rows[0]["Sexo "].ToString();
            teste.maskedTextBox9.Text = tabela.Rows[0]["Data_nascimento"].ToString();
            teste.textBox23.Text = tabela.Rows[0]["E_mail "].ToString();
            teste.textBox22.Text = tabela.Rows[0]["Nome_da_mae "].ToString();
            teste.textBox21.Text = tabela.Rows[0]["Nome_do_pai "].ToString();
            teste.textBox20.Text = tabela.Rows[0]["referencia_familiar "].ToString();
            teste.maskedTextBox2.Text = tabela.Rows[0]["Telefone "].ToString();
            teste.textBox19.Text = tabela.Rows[0]["Estado_Civil "].ToString();
            teste.maskedTextBox3.Text = tabela.Rows[0]["RG "].ToString();
            teste.comboBox1.Text = tabela.Rows[0]["UF "].ToString();
            teste.maskedTextBox4.Text = tabela.Rows[0]["CPF "].ToString();
            teste.textBox18.Text = tabela.Rows[0]["Orgao_expedicao "].ToString();
            teste.maskedTextBox5.Text = tabela.Rows[0]["data_expedicao "].ToString();
            teste.textBox2.Text = tabela.Rows[0]["pais "].ToString();
            teste.textBox12.Text = tabela.Rows[0]["Cidade_Natal "].ToString();
            teste.comboBox2.Text = tabela.Rows[0]["UF_Naturalidade"].ToString();
            teste.textBox1.Text = tabela.Rows[0]["Endereco "].ToString();
            teste.textBox14.Text = tabela.Rows[0]["Complemento "].ToString();
            teste.comboBox3.Text = tabela.Rows[0]["UF_Contato "].ToString();
            teste.maskedTextBox6.Text = tabela.Rows[0]["Telefone_contato "].ToString();
            teste.textBox15.Text = tabela.Rows[0]["Bairro "].ToString();
            teste.textBox16.Text = tabela.Rows[0]["Numero "].ToString();
            teste.maskedTextBox7.Text = tabela.Rows[0]["CEP "].ToString();
            teste.textBox17.Text = tabela.Rows[0]["Cidade "].ToString();
            teste.maskedTextBox8.Text = tabela.Rows[0]["Telefone_celular "].ToString();
            teste.richTextBox1.Text = tabela.Rows[0]["Observacao_pessoal "].ToString();
            teste.maskedTextBox57.Text = tabela.Rows[0]["Febre_Amarela1 "].ToString();
            teste.maskedTextBox56.Text = tabela.Rows[0]["Febre_Amarela2 "].ToString();
            teste.maskedTextBox55.Text = tabela.Rows[0]["Febre_Amarela3"].ToString();
            teste.maskedTextBox54.Text = tabela.Rows[0]["Febre_Amarela_Unica"].ToString();
            teste.maskedTextBox53.Text = tabela.Rows[0]["HepatiteB_1 "].ToString();
            teste.maskedTextBox52.Text = tabela.Rows[0]["HepatiteB_2 "].ToString();
            teste.maskedTextBox51.Text = tabela.Rows[0]["HepatiteB_3 "].ToString();
            teste.maskedTextBox50.Text = tabela.Rows[0]["HepatiteB_Unica "].ToString();
            teste.maskedTextBox49.Text = tabela.Rows[0]["Influenza_1 "].ToString();
            teste.maskedTextBox13.Text = tabela.Rows[0]["Influenza_2 "].ToString();
            teste.maskedTextBox11.Text = tabela.Rows[0]["Influenza_3 "].ToString();
            teste.maskedTextBox10.Text = tabela.Rows[0]["Influenza_Unica "].ToString();
            teste.maskedTextBox16.Text = tabela.Rows[0]["Poliomelite_1 "].ToString();
            teste.maskedTextBox15.Text = tabela.Rows[0]["Poliomelite_2 "].ToString();
            teste.maskedTextBox14.Text = tabela.Rows[0]["Poliomelite_3 "].ToString();
            teste.maskedTextBox12.Text = tabela.Rows[0]["Poliomelite_Unica "].ToString();
            teste.maskedTextBox20.Text = tabela.Rows[0]["Pneumococica_10_Valente_1 "].ToString();
            teste.maskedTextBox19.Text = tabela.Rows[0]["Pneumococica_10_Valente_2 "].ToString();
            teste.maskedTextBox18.Text = tabela.Rows[0]["Pneumococica_10_Valente_3 "].ToString();
            teste.maskedTextBox17.Text = tabela.Rows[0]["Pneumococica_10_Valente_Unica "].ToString();
            teste.maskedTextBox24.Text = tabela.Rows[0]["Pneumococica_23_Valente_1 "].ToString();
            teste.maskedTextBox23.Text = tabela.Rows[0]["Pneumococica_23_Valente_2 "].ToString();
            teste.maskedTextBox22.Text = tabela.Rows[0]["Pneumococica_23_Valente_3 "].ToString();
            teste.maskedTextBox21.Text = tabela.Rows[0]["Pneumococica_23_Valente_Unica "].ToString();
            teste.maskedTextBox28.Text = tabela.Rows[0]["Tetraviral_1 "].ToString();
            teste.maskedTextBox27.Text = tabela.Rows[0]["Tetraviral_2 "].ToString();
            teste.maskedTextBox26.Text = tabela.Rows[0]["Tetraviral_3 "].ToString();
            teste.maskedTextBox25.Text = tabela.Rows[0]["Tetraviral_Unica "].ToString();
            teste.maskedTextBox32.Text = tabela.Rows[0]["Triplice_Bacteriana_1 "].ToString();
            teste.maskedTextBox31.Text = tabela.Rows[0]["Triplice_Bacteriana_2 "].ToString();
            teste.maskedTextBox30.Text = tabela.Rows[0]["Triplice_Bacteriana_3 "].ToString();
            teste.maskedTextBox29.Text = tabela.Rows[0]["Triplice_Bacteriana_Unica "].ToString();
            teste.maskedTextBox36.Text = tabela.Rows[0]["Triplice_Viral_1 "].ToString();
            teste.maskedTextBox35.Text = tabela.Rows[0]["Triplice_Viral_2 "].ToString();
            teste.maskedTextBox34.Text = tabela.Rows[0]["Triplice_Viral_3 "].ToString();
            teste.maskedTextBox33.Text = tabela.Rows[0]["Triplice_Viral_Unica "].ToString();
            teste.maskedTextBox40.Text = tabela.Rows[0]["Vacina_DT_difteria_e_tetano_1 "].ToString();
            teste.maskedTextBox39.Text = tabela.Rows[0]["Vacina_DT_difteria_e_tetano_2 "].ToString();
            teste.maskedTextBox38.Text = tabela.Rows[0]["Vacina_DT_difteria_e_tetano_3 "].ToString();
            teste.maskedTextBox37.Text = tabela.Rows[0]["Vacina_DT_difteria_e_tetano_Unica "].ToString();
            teste.maskedTextBox44.Text = tabela.Rows[0]["Vacina_Menigocica_C_1 "].ToString();
            teste.maskedTextBox43.Text = tabela.Rows[0]["Vacina_Menigocica_C_2 "].ToString();
            teste.maskedTextBox42.Text = tabela.Rows[0]["Vacina_Menigocica_C_3 "].ToString();
            teste.maskedTextBox41.Text = tabela.Rows[0]["Vacina_Menigocica_C_Unica "].ToString();
            teste.maskedTextBox48.Text = tabela.Rows[0]["Vacina_Oral_Rotavirus_Humano_1 "].ToString();
            teste.maskedTextBox47.Text = tabela.Rows[0]["Vacina_Oral_Rotavirus_Humano_2 "].ToString();
            teste.maskedTextBox46.Text = tabela.Rows[0]["Vacina_Oral_Rotavirus_Humano_3 "].ToString();
            teste.maskedTextBox45.Text = tabela.Rows[0]["Vacina_Oral_Rotavirus_Humano_Unica "].ToString();
            teste.textBox33.Text = tabela.Rows[0]["SOC_ESCOLARIDADE "].ToString();
            teste.comboBox7.Text = tabela.Rows[0]["SOC_ESTUDO "].ToString();
            string fezcurso = tabela.Rows[0]["SOC_FEZCURSO "].ToString();
            if (fezcurso == "SIM")
            {
                teste.radioButton12.Checked = true;
            }
            else
            {
                teste.radioButton11.Checked = true;
            }
            teste.textBox31.Text = tabela.Rows[0]["SOC_CURSO "].ToString();
            //teste.textBox32.Text = tabela.Rows[0]["SOC_ESTUDO "].ToString();
            teste.textBox29.Text = tabela.Rows[0]["SOC_ADICIONAIS "].ToString();
            teste.textBox30.Text = tabela.Rows[0]["SOC_PROFISSAO "].ToString();
            teste.comboBox6.Text = tabela.Rows[0]["SOC_TRABALHO "].ToString();
            string Temfilhos = tabela.Rows[0]["SOC_FILHOS "].ToString();
            if (Temfilhos == "SIM")
            {
                teste.radioButton4.Checked = true;
            }
            else
            {
                teste.radioButton3.Checked = true;
            }

            string Rua = tabela.Rows[0]["SOC_RUA "].ToString();
            if (Rua == "SIM")
            {
                teste.radioButton6.Checked = true;
            }
            else
            {
                teste.radioButton5.Checked = true;
            }

            string Familia = tabela.Rows[0]["SOC_FAMILIAR "].ToString();
            if (Familia == "SIM")
            {
                teste.radioButton8.Checked = true;
            }
            else
            {
                teste.radioButton7.Checked = true;
            }

            string INSTITUICAO = tabela.Rows[0]["SOC_INSTITUICAO "].ToString();
            if (INSTITUICAO == "SIM")
            {
                teste.radioButton10.Checked = true;
            }
            else
            {
                teste.radioButton9.Checked = true;
            }

            teste.textBox26.Text = tabela.Rows[0]["SOC_NOMEINSTITUICAO"].ToString();
            teste.comboBox5.Text = tabela.Rows[0]["SOC_RESPONSAVEL "].ToString();
            teste.comboBox8.Text = tabela.Rows[0]["SOC_TEMPO "].ToString();
            teste.comboBox4.Text = tabela.Rows[0]["SOC_PARENTESCO "].ToString();
            teste.textBox4.Text = tabela.Rows[0]["Nome"].ToString();
            string FUMANTE = tabela.Rows[0]["PAT_FUMANTE "].ToString();
            if (FUMANTE == "SIM")
            {
                teste.radioButton1.Checked = true;
            }
            else
            {
                teste.radioButton2.Checked = true;
            }

            string ALERGIA = tabela.Rows[0]["PAT_ALERGIA "].ToString();
            if (ALERGIA == "SIM")
            {
                teste.radioButton13.Checked = true;
            }
            else
            {
                teste.radioButton14.Checked = true;
            }

            string ALCOOL = tabela.Rows[0]["PAT_ALCOOL "].ToString();
            if (ALCOOL == "SIM")
            {
                teste.radioButton15.Checked = true;
            }
            else
            {
                teste.radioButton16.Checked = true;
            }

            string REMEDIO = tabela.Rows[0]["PAT_REMEDIO "].ToString();
            if (REMEDIO == "SIM")
            {
                teste.radioButton17.Checked = true;
            }
            else
            {
                teste.radioButton18.Checked = true;
            }

            string DIABETES = tabela.Rows[0]["PAT_DIABETES "].ToString();
            if (DIABETES == "SIM")
            {
                teste.radioButton19.Checked = true;
            }
            else
            {
                teste.radioButton20.Checked = true;
            }

            string COLESTEROL = tabela.Rows[0]["PAT_COLESTEROL "].ToString();
            if (COLESTEROL == "SIM")
            {
                teste.radioButton21.Checked = true;
            }
            else
            {
                teste.radioButton22.Checked = true;
            }

            string DROGA = tabela.Rows[0]["PAT_DROGA "].ToString();
            if (DROGA == "SIM")
            {
                teste.radioButton23.Checked = true;
            }
            else
            {
                teste.radioButton24.Checked = true;
            }

            string RINS = tabela.Rows[0]["PAT_RINS "].ToString();
            if (RINS == "SIM")
            {
                teste.radioButton25.Checked = true;
            }
            else
            {
                teste.radioButton26.Checked = true;
            }

            string CARDIACO = tabela.Rows[0]["PAT_CARDIACO "].ToString();
            if (CARDIACO == "SIM")
            {
                teste.radioButton27.Checked = true;
            }
            else
            {
                teste.radioButton28.Checked = true;
            }

            string AVC = tabela.Rows[0]["PAT_AVC "].ToString();
            if (AVC == "SIM")
            {
                teste.radioButton29.Checked = true;
            }
            else
            {
                teste.radioButton30.Checked = true;
            }

            string RESPIRATORIO = tabela.Rows[0]["PAT_RESPIRATORIO "].ToString();
            if (RESPIRATORIO == "SIM")
            {
                teste.radioButton31.Checked = true;
            }
            else
            {
                teste.radioButton32.Checked = true;
            }

            string CANCER = tabela.Rows[0]["PAT_CANCER "].ToString();
            if (CANCER == "SIM")
            {
                teste.radioButton33.Checked = true;
            }
            else
            {
                teste.radioButton34.Checked = true;
            }

            string HEREDITARIA = tabela.Rows[0]["PAT_HEREDITARIA "].ToString();
            if (HEREDITARIA == "SIM")
            {
                teste.radioButton35.Checked = true;
            }
            else
            {
                teste.radioButton36.Checked = true;
            }

            string DEFICIENCIA = tabela.Rows[0]["PAT_DEFICIENCIA "].ToString();
            if (DEFICIENCIA == "SIM")
            {
                teste.radioButton37.Checked = true;
            }
            else
            {
                teste.radioButton38.Checked = true;
            }

            string INTERNACAO = tabela.Rows[0]["PAT_INTERNACAO"].ToString();
            if (INTERNACAO == "SIM")
            {
                teste.radioButton39.Checked = true;
            }
            else
            {
                teste.radioButton40.Checked = true;
            }

            string HEPATITE = tabela.Rows[0]["PAT_HEPATITE "].ToString();
            if (HEPATITE == "SIM")
            {
                teste.radioButton41.Checked = true;
            }
            else
            {
                teste.radioButton42.Checked = true;
            }

            string DST = tabela.Rows[0]["PAT_DST "].ToString();
            if (DST == "SIM")
            {
                teste.radioButton43.Checked = true;
            }
            else
            {
                teste.radioButton44.Checked = true;
            }

            teste.textBox54.Text = tabela.Rows[0]["PAT_TEMPO_F "].ToString();
            teste.textBox53.Text = tabela.Rows[0]["PAT_QUAL_A "].ToString();
            teste.textBox52.Text = tabela.Rows[0]["PAT_QUAL_AL "].ToString();
            teste.textBox51.Text = tabela.Rows[0]["PAT_QUAL_R "].ToString();
            teste.textBox48.Text = tabela.Rows[0]["PAT_QUAL_D "].ToString();
            teste.textBox50.Text = tabela.Rows[0]["PAT_QUAL_DI "].ToString();
            teste.textBox49.Text = tabela.Rows[0]["PAT_QUANTO_CO "].ToString();
            teste.textBox47.Text = tabela.Rows[0]["PAT_TIPO_RIN "].ToString();
            teste.textBox39.Text = tabela.Rows[0]["PAT_QUAL_CAR "].ToString();
            teste.textBox34.Text = tabela.Rows[0]["PAT_QUANDO_AVC "].ToString();
            teste.textBox40.Text = tabela.Rows[0]["PAT_QUAL_RES "].ToString();
            teste.textBox41.Text = tabela.Rows[0]["PAT_QUAL_CA "].ToString();
            teste.textBox42.Text = tabela.Rows[0]["PAT_QUAL_HE "].ToString();
            teste.textBox43.Text = tabela.Rows[0]["PAT_QUAL_DE "].ToString();
            teste.textBox44.Text = tabela.Rows[0]["PAT_POR_IN "].ToString();
            teste.textBox45.Text = tabela.Rows[0]["PAT_QUAL_HEP "].ToString();
            teste.textBox46.Text = tabela.Rows[0]["PAT_QUAL_DST "].ToString();
            teste.textBox35.Text = tabela.Rows[0]["Nome_medico "].ToString();
            teste.textBox36.Text = tabela.Rows[0]["PAT_motivo "].ToString();
            teste.textBox37.Text = tabela.Rows[0]["PAT_local_tratamento "].ToString();
            teste.textBox38.Text = tabela.Rows[0]["PAT_intervercoes_cirurgica "].ToString();
            teste.richTextBox2.Text = tabela.Rows[0]["PAT_observacao "].ToString();

            teste.flag = 1;

            teste.button1.Enabled = true;
            teste.btnNovoCadastro.Text = "Editar Cadastro";
            teste.toolStripMenuItem1.Enabled = true;

            #endregion

            if (isNova)
            {
                teste.Show();
                return;
            }

            this.Close();
        }

        private void Consultar_pessoa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id_cliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                string nome = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                string CPF = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);

                teste = new Interface_principal();

                teste.textBox27.Text = nome;
                teste.maskedTextBox4.Text = CPF;
                //this.Close();


                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string busca = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                    Paciente pes = new Paciente();

                    if (radioButton1.Checked == true)
                    {
                        pes.excluir_cliente(busca, dataGridView1, textBox1.Text);
                        pes.consultar_cliente_Nome(dataGridView1, textBox1.Text);
                    }

                    else
                    {
                        pes.excluir_cliente(busca, dataGridView1, textBox1.Text);
                        pes.consultar_cliente_CPF(dataGridView1, textBox1.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um usuário para exclusão!");
                }
            }

            else 
            {
                MessageBox.Show("Nenhum usuário selecionado!");
            }
        }
    }
}
