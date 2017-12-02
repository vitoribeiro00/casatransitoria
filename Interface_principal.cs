using Projeto_Casa_Transitoria;
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
    public partial class Interface_principal : Form
    {
        public int flag = 0;
        int id_cliente;
        int opcao = 0;
        DataGridView datagrid;
        string busca;

        public Interface_principal()
        {
           
            InitializeComponent();
            textBox56.Enabled = false;
            button1.BackColor = System.Drawing.Color.Teal;
            button1.ForeColor = System.Drawing.Color.White;
            button1.Enabled = false;
            textBox3.Enabled = false;
            DesativarCampos();
            toolStripMenuItem1.Enabled = false;
        }

        public Interface_principal(int flag)
        {
            InitializeComponent();
            /*textBox1.Text = nome;
            textBox2.Text = cpf;
            datagrid = data;
            busca = texto;
            //comboBox1.SelectedIndex = 0;
            */
            this.id_cliente = id_cliente;

            salvar.Text = "Editar";
            textBox56.Enabled = false;


        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar_pessoa cons = new Consultar_pessoa(this);
            cons.Show();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int Id_criminal = 0;
            int Id_paciente = 0;
            string processo = textBox11.Text;
            string Local = textBox8.Text;
            string classe = textBox7.Text;
            string foro = textBox9.Text;
            string situacao = textBox10.Text;
            string data_julgamento = maskedTextBox1.Text;
            string auto_prisao = textBox13.Text;


            // Fim Salvar Antecedentes Criminais
            string sexo = textBox24.Text;
            string Nome = textBox27.Text;
            string cpf = maskedTextBox4.Text;
            string codigo = textBox56.Text;
            string apelido = textBox25.Text;
            string Data_Nascimento = maskedTextBox9.Text;
            string RG = maskedTextBox3.Text;
            string Cidade = textBox12.Text;
            string Cidade_Natal = textBox17.Text;
            string endereco = textBox1.Text;
            string Bairro = textBox15.Text;
            string complemento = textBox14.Text;
            string Numero = textBox16.Text;
            string CEP = maskedTextBox7.Text;
            string Nome_da_Mae = textBox22.Text;
            string Nome_da_Pai = textBox21.Text;
            string telefone = maskedTextBox2.Text;
            string telefone_contato = maskedTextBox6.Text;
            string telefone_celular = maskedTextBox8.Text;
            string Email = textBox23.Text;
            string UF_contato = comboBox3.Text;
            string Estado_Civil = textBox19.Text;
            string Orgao_expedicao = textBox18.Text;
            string data_expedicao = maskedTextBox5.Text;
            string pais = textBox2.Text;
            string referencia_familiar = textBox20.Text;
            string UF = comboBox1.Text;
            string UF_Naturalidade = comboBox2.Text;
            string observacao_pessoal = richTextBox1.Text;
            string Febre_Amarela1 = maskedTextBox57.Text;
            string Febre_Amarela2 = maskedTextBox56.Text;
            string Febre_Amarela3 = maskedTextBox55.Text;
            string Febre_Amarela_Unica = maskedTextBox54.Text;
            string HepatiteB_1 = maskedTextBox53.Text;
            string HepatiteB_2 = maskedTextBox52.Text;
            string HepatiteB_3 = maskedTextBox51.Text;
            string HepatiteB_Unica = maskedTextBox50.Text;
            string Influenza_1 = maskedTextBox49.Text;
            string Influenza_2 = maskedTextBox13.Text;
            string Influenza_3 = maskedTextBox11.Text;
            string Influenza_Unica = maskedTextBox10.Text;
            string Poliomelite_1 = maskedTextBox16.Text;
            string Poliomelite_2 = maskedTextBox15.Text;
            string Poliomelite_3 = maskedTextBox14.Text;
            string Poliomelite_Unica = maskedTextBox12.Text;
            string Pneumococica_10Valente_1 = maskedTextBox20.Text;
            string Pneumococica_10Valente_2 = maskedTextBox19.Text;
            string Pneumococica_10Valente_3 = maskedTextBox18.Text;
            string Pneumococica_10Valente_Unica = maskedTextBox17.Text;
            string Pneumococica_23Valente_1 = maskedTextBox24.Text;
            string Pneumococica_23Valente_2 = maskedTextBox23.Text;
            string Pneumococica_23Valente_3 = maskedTextBox22.Text;
            string Pneumococica_23Valente_Unica = maskedTextBox21.Text;
            string Tetraviral_1 = maskedTextBox28.Text;
            string Tetraviral_2 = maskedTextBox27.Text;
            string Tetraviral_3 = maskedTextBox26.Text;
            string Tetraviral_Unica = maskedTextBox25.Text;
            string Triplice_Bacteriana_1 = maskedTextBox32.Text;
            string Triplice_Bacteriana_2 = maskedTextBox31.Text;
            string Triplice_Bacteriana_3 = maskedTextBox30.Text;
            string Triplice_Bacteriana_Unica = maskedTextBox29.Text;
            string Triplice_Viral_1 = maskedTextBox36.Text;
            string Triplice_Viral_2 = maskedTextBox35.Text;
            string Triplice_Viral_3 = maskedTextBox34.Text;
            string Triplice_Viral_Unica = maskedTextBox33.Text;
            string Vacina_DTdifteria_e_tetano_1 = maskedTextBox40.Text;
            string Vacina_DTdifteria_e_tetano_2 = maskedTextBox39.Text;
            string Vacina_DTdifteria_e_tetano_3 = maskedTextBox38.Text;
            string Vacina_DTdifteria_e_tetano_Unica = maskedTextBox37.Text;
            string Vacina_Menigocica_C_1 = maskedTextBox44.Text;
            string Vacina_Menigocica_C_2 = maskedTextBox43.Text;
            string Vacina_Menigocica_C_3 = maskedTextBox42.Text;
            string Vacina_Menigocica_C_Unica = maskedTextBox41.Text;
            string Vacina_Oral_Rotavirus_Humano_1 = maskedTextBox48.Text;
            string Vacina_Oral_Rotavirus_Humano_2 = maskedTextBox47.Text;
            string Vacina_Oral_Rotavirus_Humano_3 = maskedTextBox46.Text;
            string Vacina_Oral_Rotavirus_Humano_Unica = maskedTextBox45.Text;
            string SOC_ESCOLARIDADE = textBox33.Text;
            string SOC_ESTUDO = comboBox7.Text;
            string SOC_FEZCURSO = "";
            if (radioButton12.Checked == true) { SOC_FEZCURSO = "SIM"; }
            if (radioButton11.Checked == true) { SOC_FEZCURSO = "NÃO"; }
            string SOC_CURSO = textBox31.Text;
            string SOC_TRABALHO = comboBox6.Text;
            string SOC_PROFISSAO = textBox30.Text;
            string SOC_FILHOS = "";
            if (radioButton4.Checked == true) { SOC_FILHOS = "SIM"; }
            if (radioButton3.Checked == true) { SOC_FILHOS = "NÃO"; }
            string SOC_RESPONSAVEL = comboBox5.Text;
            string SOC_RUA = "";
            if (radioButton6.Checked == true) { SOC_RUA = "SIM"; }
            if (radioButton5.Checked == true) { SOC_RUA = "NÃO"; }
            string SOC_TEMPO = comboBox8.Text;
            string SOC_INSTITUICAO = "";
            if (radioButton6.Checked == true) { SOC_INSTITUICAO = "SIM"; }
            if (radioButton5.Checked == true) { SOC_INSTITUICAO = "NÃO"; }
            string SOC_NOMEINSTITUICAO = textBox26.Text;
            string SOC_FAMILIAR = "";
            if (radioButton8.Checked == true) { SOC_FAMILIAR = "SIM"; }
            if (radioButton7.Checked == true) { SOC_FAMILIAR = "NÃO"; }
            string SOC_PARENTESCO = comboBox4.Text;
            string SOC_ADICIONAIS = textBox29.Text;
            string PAT_FUMANTE = "";
            if (radioButton1.Checked == true) { PAT_FUMANTE = "SIM"; }
            if (radioButton2.Checked == true) { PAT_FUMANTE = "NÃO"; }
            string PAT_ALERGIA = "";
            if (radioButton13.Checked == true) { PAT_ALERGIA = "SIM"; }
            if (radioButton14.Checked == true) { PAT_ALERGIA = "NÃO"; }
            string PAT_ALCOOL = "";
            if (radioButton15.Checked == true) { PAT_ALCOOL = "SIM"; }
            if (radioButton16.Checked == true) { PAT_ALCOOL = "NÃO"; }
            string PAT_REMEDIO = "";
            if (radioButton17.Checked == true) { PAT_REMEDIO = "SIM"; }
            if (radioButton18.Checked == true) { PAT_REMEDIO = "NÃO"; }
            string PAT_DROGA = "";
            if (radioButton19.Checked == true) { PAT_DROGA = "SIM"; }
            if (radioButton20.Checked == true) { PAT_DROGA = "NÃO"; }
            string PAT_DIABETES = "";
            if (radioButton21.Checked == true) { PAT_DIABETES = "SIM"; }
            if (radioButton22.Checked == true) { PAT_DIABETES = "NÃO"; }
            string PAT_COLESTEROL = "";
            if (radioButton23.Checked == true) { PAT_COLESTEROL = "SIM"; }
            if (radioButton24.Checked == true) { PAT_COLESTEROL = "NÃO"; }
            string PAT_CARDIACO = "";
            if (radioButton25.Checked == true) { PAT_CARDIACO = "SIM"; }
            if (radioButton26.Checked == true) { PAT_CARDIACO = "NÃO"; }
            string PAT_AVC = "";
            if (radioButton27.Checked == true) { PAT_AVC = "SIM"; }
            if (radioButton28.Checked == true) { PAT_AVC = "NÃO"; }
            string PAT_RINS = "";
            if (radioButton29.Checked == true) { PAT_RINS = "SIM"; }
            if (radioButton30.Checked == true) { PAT_RINS = "NÃO"; }
            string PAT_RESPIRATORIO = "";
            if (radioButton31.Checked == true) { PAT_RESPIRATORIO = "SIM"; }
            if (radioButton32.Checked == true) { PAT_RESPIRATORIO = "NÃO"; }
            string PAT_INTERNACAO = "";
            if (radioButton33.Checked == true) { PAT_INTERNACAO = "SIM"; }
            if (radioButton34.Checked == true) { PAT_INTERNACAO = "NÃO"; }
            string PAT_CANCER = "";
            if (radioButton35.Checked == true) { PAT_CANCER = "SIM"; }
            if (radioButton36.Checked == true) { PAT_CANCER = "NÃO"; }
            string PAT_HEREDITARIA = "";
            if (radioButton37.Checked == true) { PAT_HEREDITARIA = "SIM"; }
            if (radioButton38.Checked == true) { PAT_HEREDITARIA = "NÃO"; }
            string PAT_DEFICIENCIA = "";
            if (radioButton39.Checked == true) { PAT_DEFICIENCIA = "SIM"; }
            if (radioButton40.Checked == true) { PAT_DEFICIENCIA = "NÃO"; }
            string PAT_HEPATITE = "";
            if (radioButton41.Checked == true) { PAT_HEPATITE = "SIM"; }
            if (radioButton42.Checked == true) { PAT_HEPATITE = "NÃO"; }
            string PAT_DST = "";
            if (radioButton43.Checked == true) { PAT_DST = "SIM"; }
            if (radioButton44.Checked == true) { PAT_DST = "NÃO"; }
            string PAT_TEMPO_F = textBox54.Text;
            string PAT_QUAL_A = textBox53.Text;
            string PAT_QUAL_AL = textBox52.Text;
            string PAT_QUAL_R = textBox51.Text;
            string PAT_QUAL_D = textBox48.Text;
            string PAT_QUAL_DI = textBox50.Text;
            string PAT_QUANTO_CO = textBox49.Text;
            string PAT_QUAL_CAR = textBox39.Text;
            string PAT_QUANDO_AVC = textBox34.Text;
            string PAT_TIPO_RIN = textBox47.Text;
            string PAT_QUAL_RES = textBox40.Text;
            string PAT_POR_IN = textBox44.Text;
            string PAT_QUAL_CA = textBox41.Text;
            string PAT_QUAL_HE = textBox42.Text;
            string PAT_QUAL_DE = textBox43.Text;
            string PAT_QUAL_HEP = textBox45.Text;
            string PAT_QUAL_DST = textBox46.Text;
            string Nome_medico = textBox35.Text;
            string PAT_motivo = textBox36.Text;
            string PAT_local_tratamento = textBox37.Text;
            string PAT_intervercoes_cirurgica = textBox38.Text;
            string PAT_observacao = richTextBox2.Text;


            Paciente paciente = new Paciente();
            paciente.set_Id_criminal(Id_criminal);
            paciente.set_Id_paciente(Id_paciente);
            paciente.set_Processo(processo);
            paciente.set_Local(Local);
            paciente.set_Classe(classe);
            paciente.set_Foro(foro);
            paciente.set_Situacao(situacao);
            paciente.set_Data_julgamento(data_julgamento);
            paciente.set_Auto_prisao(auto_prisao);
            paciente.set_Nome(Nome);
            paciente.set_Apelido(apelido);
            paciente.set_Data_nascimento(Data_Nascimento);
            paciente.set_Sexo(sexo);
            paciente.set_CPF(cpf);
            paciente.set_RG(RG);
            paciente.set_Cidade(Cidade);
            paciente.set_Cidade_Natal(Cidade_Natal);
            paciente.set_Endereco(endereco);
            paciente.set_Bairro(Bairro);
            paciente.set_Complemento(complemento);
            paciente.set_Numero(Numero);
            paciente.set_CEP(CEP);
            paciente.set_Telefone(telefone);
            paciente.set_Telefone_celular(telefone_celular);
            paciente.set_Telefone_contato(telefone_contato);
            paciente.set_E_mail(Email);
            paciente.set_Nome_da_Mae(Nome_da_Mae);
            paciente.set_Nome_do_Pai(Nome_da_Pai);
            paciente.set_Estado_Civil(Estado_Civil);
            paciente.set_Orgao_expedicao(Orgao_expedicao);
            paciente.set_data_expedicao(data_expedicao);
            paciente.set_pais(pais);
            paciente.set_referencia_familiar(referencia_familiar);
            paciente.set_UF(UF);
            paciente.set_UF_Naturalidade(UF_Naturalidade);
            paciente.set_UF_Contato(UF_contato);
            paciente.set_Observacao_pessoal(observacao_pessoal);
            paciente.set_Febre_Amarela1(Febre_Amarela1);
            paciente.set_Febre_Amarela2(Febre_Amarela2);
            paciente.set_Febre_Amarela3(Febre_Amarela3);
            paciente.set_Febre_Amarela_Unica(Febre_Amarela_Unica);
            paciente.set_HepatiteB_1(HepatiteB_1);
            paciente.set_HepatiteB_2(HepatiteB_2);
            paciente.set_HepatiteB_3(HepatiteB_3);
            paciente.set_HepatiteB_Unica(HepatiteB_Unica);
            paciente.set_Influenza_1(Influenza_1);
            paciente.set_Influenza_2(Influenza_2);
            paciente.set_Influenza_3(Influenza_3);
            paciente.set_Influenza_Unica(Influenza_Unica);
            paciente.set_Poliomelite_1(Poliomelite_1);
            paciente.set_Poliomelite_2(Poliomelite_2);
            paciente.set_Poliomelite_3(Poliomelite_3);
            paciente.set_Poliomelite_Unica(Poliomelite_Unica);
            paciente.set_Pneumococica_10_Valente_1(Pneumococica_10Valente_1);
            paciente.set_Pneumococica_10_Valente_2(Pneumococica_10Valente_2);
            paciente.set_Pneumococica_10_Valente_3(Pneumococica_10Valente_3);
            paciente.set_Pneumococica_10_Valente_Unica(Pneumococica_10Valente_Unica);
            paciente.set_Pneumococica_23_Valente_1(Pneumococica_23Valente_1);
            paciente.set_Pneumococica_23_Valente_2(Pneumococica_23Valente_2);
            paciente.set_Pneumococica_23_Valente_3(Pneumococica_23Valente_3);
            paciente.set_Pneumococica_23_Valente_Unica(Pneumococica_23Valente_Unica);
            paciente.set_Tetraviral_1(Tetraviral_1);
            paciente.set_Tetraviral_2(Tetraviral_2);
            paciente.set_Tetraviral_3(Tetraviral_3);
            paciente.set_Tetraviral_Unica(Tetraviral_Unica);
            paciente.set_Triplice_Bacteriana_1(Triplice_Bacteriana_1);
            paciente.set_Triplice_Bacteriana_2(Triplice_Bacteriana_2);
            paciente.set_Triplice_Bacteriana_3(Triplice_Bacteriana_3);
            paciente.set_Triplice_Bacteriana_Unica(Triplice_Bacteriana_Unica);
            paciente.set_Triplice_Viral_1(Triplice_Viral_1);
            paciente.set_Triplice_Viral_2(Triplice_Viral_2);
            paciente.set_Triplice_Viral_3(Triplice_Viral_3);
            paciente.set_Triplice_Viral_Unica(Triplice_Viral_Unica);
            paciente.set_Vacina_DT_difteria_e_tetano_1(Vacina_DTdifteria_e_tetano_1);
            paciente.set_Vacina_DT_difteria_e_tetano_2(Vacina_DTdifteria_e_tetano_2);
            paciente.set_Vacina_DT_difteria_e_tetano_3(Vacina_DTdifteria_e_tetano_3);
            paciente.set_Vacina_DT_difteria_e_tetano_Unica(Vacina_DTdifteria_e_tetano_Unica);
            paciente.set_Vacina_Menigocica_C_1(Vacina_Menigocica_C_1);
            paciente.set_Vacina_Menigocica_C_2(Vacina_Menigocica_C_2);
            paciente.set_Vacina_Menigocica_C_3(Vacina_Menigocica_C_3);
            paciente.set_Vacina_Menigocica_C_Unica(Vacina_Menigocica_C_Unica);
            paciente.set_Vacina_Oral_Rotavirus_Humano_1(Vacina_Oral_Rotavirus_Humano_1);
            paciente.set_Vacina_Oral_Rotavirus_Humano_2(Vacina_Oral_Rotavirus_Humano_2);
            paciente.set_Vacina_Oral_Rotavirus_Humano_3(Vacina_Oral_Rotavirus_Humano_3);
            paciente.set_Vacina_Oral_Rotavirus_Humano_Unica(Vacina_Oral_Rotavirus_Humano_Unica);
            paciente.set_SOC_ESCOLARIDADE(SOC_ESCOLARIDADE);
            paciente.set_SOC_ESTUDO(SOC_ESTUDO);
            paciente.set_SOC_FEZCURSO(SOC_FEZCURSO);
            paciente.set_SOC_CURSO(SOC_CURSO);
            paciente.set_SOC_TRABALHO(SOC_TRABALHO);
            paciente.set_SOC_PROFISSAO(SOC_PROFISSAO);
            paciente.set_SOC_FILHOS(SOC_FILHOS);
            paciente.set_SOC_RESPONSAVEL(SOC_RESPONSAVEL);
            paciente.set_SOC_RUA(SOC_RUA);
            paciente.set_SOC_TEMPO(SOC_TEMPO);
            paciente.set_SOC_INSTITUICAO(SOC_INSTITUICAO);
            paciente.set_SOC_NOMEINSTITUICAO(SOC_NOMEINSTITUICAO);
            paciente.set_SOC_FAMILIAR(SOC_FAMILIAR);
            paciente.set_SOC_PARENTESCO(SOC_PARENTESCO);
            paciente.set_SOC_ADICIONAIS(SOC_ADICIONAIS);
            paciente.set_PAT_FUMANTE(PAT_FUMANTE);
            paciente.set_PAT_ALERGIA(PAT_ALERGIA);
            paciente.set_PAT_ALCOOL(PAT_ALCOOL);
            paciente.set_PAT_REMEDIO(PAT_REMEDIO);
            paciente.set_PAT_DROGA(PAT_DROGA);
            paciente.set_PAT_DIABETES(PAT_DIABETES);
            paciente.set_PAT_COLESTEROL(PAT_COLESTEROL);
            paciente.set_PAT_CARDIACO(PAT_CARDIACO);
            paciente.set_PAT_AVC(PAT_AVC);
            paciente.set_PAT_RINS(PAT_RINS);
            paciente.set_PAT_RESPIRATORIO(PAT_RESPIRATORIO);
            paciente.set_PAT_INTERNACAO(PAT_INTERNACAO);
            paciente.set_PAT_CANCER(PAT_CANCER);
            paciente.set_PAT_HEREDITARIA(PAT_HEREDITARIA);
            paciente.set_PAT_DEFICIENCIA(PAT_DEFICIENCIA);
            paciente.set_PAT_Hepatite(PAT_HEPATITE);
            paciente.set_PAT_DST(PAT_DST);
            paciente.set_PAT_TEMPO_F(PAT_TEMPO_F);
            paciente.set_PAT_QUAL_A(PAT_QUAL_A);
            paciente.set_PAT_QUAL_AL(PAT_QUAL_AL);
            paciente.set_PAT_QUAL_R(PAT_QUAL_R);
            paciente.set_PAT_QUAL_D(PAT_QUAL_D);
            paciente.set_PAT_QUAL_DI(PAT_QUAL_DI);
            paciente.set_PAT_QUANTO_CO(PAT_QUANTO_CO);
            paciente.set_PAT_QUAL_CAR(PAT_QUAL_CAR);
            paciente.set_PAT_QUANDO_AVC(PAT_QUANDO_AVC);
            paciente.set_PAT_TIPO_RIN(PAT_TIPO_RIN);
            paciente.set_PAT_QUAL_RES(PAT_QUAL_RES);
            paciente.set_PAT_POR_IN(PAT_POR_IN);
            paciente.set_PAT_QUAL_CA(PAT_QUAL_CA);
            paciente.set_PAT_QUAL_HE(PAT_QUAL_HE);
            paciente.set_PAT_QUAL_DE(PAT_QUAL_DE);
            paciente.set_PAT_QUAL_HEP(PAT_QUAL_HEP);
            paciente.set_PAT_QUAL_DST(PAT_QUAL_DST);
            paciente.set_Nome_medico(Nome_medico);
            paciente.set_PAT_motivo(PAT_motivo);
            paciente.set_PAT_local_tratamento(PAT_local_tratamento);
            paciente.set_PAT_intervercoes_cirurgica(PAT_intervercoes_cirurgica);
            paciente.set_PAT_observacao(PAT_observacao);
            if (flag == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Deseja realizar o cadastro? ",
                    "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    paciente.Cadastrar_paciente();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Deseja realizar atualização do cadastro? ",
                "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    paciente.editar_paciente(textBox56.Text);
                    if (dataGridView1.SelectedRows.Count != 0)
                    {
                        string criminal = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        paciente.editar_criminal(criminal);
                    }
                    flag = 0;
                    salvar.Text = "Salvar";
                    toolStripMenuItem1.Enabled = false;
                }
                button1.Enabled = false;
                //apagar campos

                
            }

            limparcampos();
        }

        private void DesativarCampos()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox12.Enabled = false;
            textBox13.Enabled = false;
            textBox14.Enabled = false;
            textBox15.Enabled = false;
            textBox16.Enabled = false;
            textBox17.Enabled = false;
            textBox18.Enabled = false;
            textBox19.Enabled = false;
            textBox20.Enabled = false;
            textBox21.Enabled = false;
            textBox22.Enabled = false;
            textBox23.Enabled = false;
            textBox24.Enabled = false;
            textBox24.Enabled = false;
            textBox24.Enabled = false;
            textBox25.Enabled = false;
            textBox26.Enabled = false;
            textBox27.Enabled = false;
            textBox29.Enabled = false;
            textBox30.Enabled = false;
            textBox31.Enabled = false;
            textBox33.Enabled = false;
            textBox34.Enabled = false;
            textBox35.Enabled = false;
            textBox36.Enabled = false;
            textBox37.Enabled = false;
            textBox38.Enabled = false;
            textBox39.Enabled = false;
            textBox40.Enabled = false;
            textBox41.Enabled = false;
            textBox42.Enabled = false;
            textBox43.Enabled = false;
            textBox44.Enabled = false;
            textBox45.Enabled = false;
            textBox46.Enabled = false;
            textBox47.Enabled = false;
            textBox48.Enabled = false;
            textBox49.Enabled = false;
            textBox50.Enabled = false;
            textBox51.Enabled = false;
            textBox52.Enabled = false;
            textBox53.Enabled = false;
            textBox54.Enabled = false;
            textBox56.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            radioButton6.Enabled = false;
            radioButton7.Enabled = false;
            radioButton8.Enabled = false;
            radioButton9.Enabled = false;
            radioButton10.Enabled = false;
            radioButton11.Enabled = false;
            radioButton12.Enabled = false;
            radioButton13.Enabled = false;
            radioButton14.Enabled = false;
            radioButton15.Enabled = false;
            radioButton16.Enabled = false;
            radioButton17.Enabled = false;
            radioButton18.Enabled = false;
            radioButton19.Enabled = false;
            radioButton20.Enabled = false;
            radioButton21.Enabled = false;
            radioButton22.Enabled = false;
            radioButton23.Enabled = false;
            radioButton24.Enabled = false;
            radioButton25.Enabled = false;
            radioButton26.Enabled = false;
            radioButton27.Enabled = false;
            radioButton28.Enabled = false;
            radioButton29.Enabled = false;
            radioButton30.Enabled = false;
            radioButton31.Enabled = false;
            radioButton32.Enabled = false;
            radioButton33.Enabled = false;
            radioButton34.Enabled = false;
            radioButton35.Enabled = false;
            radioButton36.Enabled = false;
            radioButton37.Enabled = false;
            radioButton38.Enabled = false;
            radioButton39.Enabled = false;
            radioButton40.Enabled = false;
            radioButton41.Enabled = false;
            radioButton42.Enabled = false;
            radioButton43.Enabled = false;
            radioButton44.Enabled = false;
            maskedTextBox1.Enabled = false;
            maskedTextBox2.Enabled = false;
            maskedTextBox3.Enabled = false;
            maskedTextBox4.Enabled = false;
            maskedTextBox5.Enabled = false;
            maskedTextBox6.Enabled = false;
            maskedTextBox7.Enabled = false;
            maskedTextBox8.Enabled = false;
            maskedTextBox9.Enabled = false;
            maskedTextBox10.Enabled = false;
            maskedTextBox11.Enabled = false;
            maskedTextBox12.Enabled = false;
            maskedTextBox13.Enabled = false;
            maskedTextBox14.Enabled = false;
            maskedTextBox15.Enabled = false;
            maskedTextBox16.Enabled = false;
            maskedTextBox17.Enabled = false;
            maskedTextBox18.Enabled = false;
            maskedTextBox19.Enabled = false;
            maskedTextBox20.Enabled = false;
            maskedTextBox21.Enabled = false;
            maskedTextBox22.Enabled = false;
            maskedTextBox23.Enabled = false;
            maskedTextBox24.Enabled = false;
            maskedTextBox25.Enabled = false;
            maskedTextBox26.Enabled = false;
            maskedTextBox27.Enabled = false;
            maskedTextBox28.Enabled = false;
            maskedTextBox29.Enabled = false;
            maskedTextBox30.Enabled = false;
            maskedTextBox31.Enabled = false;
            maskedTextBox32.Enabled = false;
            maskedTextBox33.Enabled = false;
            maskedTextBox34.Enabled = false;
            maskedTextBox35.Enabled = false;
            maskedTextBox36.Enabled = false;
            maskedTextBox37.Enabled = false;
            maskedTextBox38.Enabled = false;
            maskedTextBox39.Enabled = false;
            maskedTextBox40.Enabled = false;
            maskedTextBox41.Enabled = false;
            maskedTextBox42.Enabled = false;
            maskedTextBox43.Enabled = false;
            maskedTextBox44.Enabled = false;
            maskedTextBox45.Enabled = false;
            maskedTextBox46.Enabled = false;
            maskedTextBox47.Enabled = false;
            maskedTextBox48.Enabled = false;
            maskedTextBox49.Enabled = false;
            maskedTextBox50.Enabled = false;
            maskedTextBox51.Enabled = false;
            maskedTextBox52.Enabled = false;
            maskedTextBox53.Enabled = false;
            maskedTextBox54.Enabled = false;
            maskedTextBox55.Enabled = false;
            maskedTextBox56.Enabled = false;
            maskedTextBox57.Enabled = false;
            richTextBox1.Enabled = false;
            richTextBox2.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;
            comboBox7.Enabled = false;
            comboBox8.Enabled = false;
        }

        public void AtivarCampos()
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            textBox12.Enabled = true;
            textBox13.Enabled = true;
            textBox14.Enabled = true;
            textBox15.Enabled = true;
            textBox16.Enabled = true;
            textBox17.Enabled = true;
            textBox18.Enabled = true;
            textBox19.Enabled = true;
            textBox20.Enabled = true;
            textBox21.Enabled = true;
            textBox22.Enabled = true;
            textBox23.Enabled = true;
            textBox24.Enabled = true;
            textBox24.Enabled = true;
            textBox24.Enabled = true;
            textBox25.Enabled = true;
            textBox26.Enabled = true;
            textBox27.Enabled = true;
            textBox29.Enabled = true;
            textBox30.Enabled = true;
            textBox31.Enabled = true;
            textBox33.Enabled = true;
            textBox34.Enabled = true;
            textBox35.Enabled = true;
            textBox36.Enabled = true;
            textBox37.Enabled = true;
            textBox38.Enabled = true;
            textBox39.Enabled = true;
            textBox40.Enabled = true;
            textBox41.Enabled = true;
            textBox42.Enabled = true;
            textBox43.Enabled = true;
            textBox44.Enabled = true;
            textBox45.Enabled = true;
            textBox46.Enabled = true;
            textBox47.Enabled = true;
            textBox48.Enabled = true;
            textBox49.Enabled = true;
            textBox50.Enabled = true;
            textBox51.Enabled = true;
            textBox52.Enabled = true;
            textBox53.Enabled = true;
            textBox54.Enabled = true;
            textBox56.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
            radioButton7.Enabled = true;
            radioButton8.Enabled = true;
            radioButton9.Enabled = true;
            radioButton10.Enabled = true;
            radioButton11.Enabled = true;
            radioButton12.Enabled = true;
            radioButton13.Enabled = true;
            radioButton14.Enabled = true;
            radioButton15.Enabled = true;
            radioButton16.Enabled = true;
            radioButton17.Enabled = true;
            radioButton18.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;
            radioButton21.Enabled = true;
            radioButton22.Enabled = true;
            radioButton23.Enabled = true;
            radioButton24.Enabled = true;
            radioButton25.Enabled = true;
            radioButton26.Enabled = true;
            radioButton27.Enabled = true;
            radioButton28.Enabled = true;
            radioButton29.Enabled = true;
            radioButton30.Enabled = true;
            radioButton31.Enabled = true;
            radioButton32.Enabled = true;
            radioButton33.Enabled = true;
            radioButton34.Enabled = true;
            radioButton35.Enabled = true;
            radioButton36.Enabled = true;
            radioButton37.Enabled = true;
            radioButton38.Enabled = true;
            radioButton39.Enabled = true;
            radioButton40.Enabled = true;
            radioButton41.Enabled = true;
            radioButton42.Enabled = true;
            radioButton43.Enabled = true;
            radioButton44.Enabled = true;
            maskedTextBox1.Enabled = true;
            maskedTextBox2.Enabled = true;
            maskedTextBox3.Enabled = true;
            maskedTextBox4.Enabled = true;
            maskedTextBox5.Enabled = true;
            maskedTextBox6.Enabled = true;
            maskedTextBox7.Enabled = true;
            maskedTextBox8.Enabled = true;
            maskedTextBox9.Enabled = true;
            maskedTextBox10.Enabled = true;
            maskedTextBox11.Enabled = true;
            maskedTextBox12.Enabled = true;
            maskedTextBox13.Enabled = true;
            maskedTextBox14.Enabled = true;
            maskedTextBox15.Enabled = true;
            maskedTextBox16.Enabled = true;
            maskedTextBox17.Enabled = true;
            maskedTextBox18.Enabled = true;
            maskedTextBox19.Enabled = true;
            maskedTextBox20.Enabled = true;
            maskedTextBox21.Enabled = true;
            maskedTextBox22.Enabled = true;
            maskedTextBox23.Enabled = true;
            maskedTextBox24.Enabled = true;
            maskedTextBox25.Enabled = true;
            maskedTextBox26.Enabled = true;
            maskedTextBox27.Enabled = true;
            maskedTextBox28.Enabled = true;
            maskedTextBox29.Enabled = true;
            maskedTextBox30.Enabled = true;
            maskedTextBox31.Enabled = true;
            maskedTextBox32.Enabled = true;
            maskedTextBox33.Enabled = true;
            maskedTextBox34.Enabled = true;
            maskedTextBox35.Enabled = true;
            maskedTextBox36.Enabled = true;
            maskedTextBox37.Enabled = true;
            maskedTextBox38.Enabled = true;
            maskedTextBox39.Enabled = true;
            maskedTextBox40.Enabled = true;
            maskedTextBox41.Enabled = true;
            maskedTextBox42.Enabled = true;
            maskedTextBox43.Enabled = true;
            maskedTextBox44.Enabled = true;
            maskedTextBox45.Enabled = true;
            maskedTextBox46.Enabled = true;
            maskedTextBox47.Enabled = true;
            maskedTextBox48.Enabled = true;
            maskedTextBox49.Enabled = true;
            maskedTextBox50.Enabled = true;
            maskedTextBox51.Enabled = true;
            maskedTextBox52.Enabled = true;
            maskedTextBox53.Enabled = true;
            maskedTextBox54.Enabled = true;
            maskedTextBox55.Enabled = true;
            maskedTextBox56.Enabled = true;
            maskedTextBox57.Enabled = true;
            richTextBox1.Enabled = true;
            richTextBox2.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            comboBox5.Enabled = true;
            comboBox6.Enabled = true;
            comboBox7.Enabled = true;
            comboBox8.Enabled = true;
        }

        private void limparcampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";
            textBox24.Text = "";
            textBox24.Text = "";
            textBox24.Text = "";
            textBox25.Text = "";
            textBox26.Text = "";
            textBox27.Text = "";
            textBox29.Text = "";
            textBox30.Text = "";
            textBox31.Text = "";
            textBox33.Text = "";
            textBox34.Text = "";
            textBox35.Text = "";
            textBox36.Text = "";
            textBox37.Text = "";
            textBox38.Text = "";
            textBox39.Text = "";
            textBox40.Text = "";
            textBox41.Text = "";
            textBox42.Text = "";
            textBox43.Text = "";
            textBox44.Text = "";
            textBox45.Text = "";
            textBox46.Text = "";
            textBox47.Text = "";
            textBox48.Text = "";
            textBox49.Text = "";
            textBox50.Text = "";
            textBox51.Text = "";
            textBox52.Text = "";
            textBox53.Text = "";
            textBox54.Text = "";
            textBox56.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
            radioButton14.Checked = false;
            radioButton15.Checked = false;
            radioButton16.Checked = false;
            radioButton17.Checked = false;
            radioButton18.Checked = false;
            radioButton19.Checked = false;
            radioButton20.Checked = false;
            radioButton21.Checked = false;
            radioButton22.Checked = false;
            radioButton23.Checked = false;
            radioButton24.Checked = false;
            radioButton25.Checked = false;
            radioButton26.Checked = false;
            radioButton27.Checked = false;
            radioButton28.Checked = false;
            radioButton29.Checked = false;
            radioButton30.Checked = false;
            radioButton31.Checked = false;
            radioButton32.Checked = false;
            radioButton33.Checked = false;
            radioButton34.Checked = false;
            radioButton35.Checked = false;
            radioButton36.Checked = false;
            radioButton37.Checked = false;
            radioButton38.Checked = false;
            radioButton39.Checked = false;
            radioButton40.Checked = false;
            radioButton41.Checked = false;
            radioButton42.Checked = false;
            radioButton43.Checked = false;
            radioButton44.Checked = false;
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
            maskedTextBox4.Text = "";
            maskedTextBox5.Text = "";
            maskedTextBox6.Text = "";
            maskedTextBox7.Text = "";
            maskedTextBox8.Text = "";
            maskedTextBox9.Text = "";
            maskedTextBox10.Text = "";
            maskedTextBox11.Text = "";
            maskedTextBox12.Text = "";
            maskedTextBox13.Text = "";
            maskedTextBox14.Text = "";
            maskedTextBox15.Text = "";
            maskedTextBox16.Text = "";
            maskedTextBox17.Text = "";
            maskedTextBox18.Text = "";
            maskedTextBox19.Text = "";
            maskedTextBox20.Text = "";
            maskedTextBox21.Text = "";
            maskedTextBox22.Text = "";
            maskedTextBox23.Text = "";
            maskedTextBox24.Text = "";
            maskedTextBox25.Text = "";
            maskedTextBox26.Text = "";
            maskedTextBox27.Text = "";
            maskedTextBox28.Text = "";
            maskedTextBox29.Text = "";
            maskedTextBox30.Text = "";
            maskedTextBox31.Text = "";
            maskedTextBox32.Text = "";
            maskedTextBox33.Text = "";
            maskedTextBox34.Text = "";
            maskedTextBox35.Text = "";
            maskedTextBox36.Text = "";
            maskedTextBox37.Text = "";
            maskedTextBox38.Text = "";
            maskedTextBox39.Text = "";
            maskedTextBox40.Text = "";
            maskedTextBox41.Text = "";
            maskedTextBox42.Text = "";
            maskedTextBox43.Text = "";
            maskedTextBox44.Text = "";
            maskedTextBox45.Text = "";
            maskedTextBox46.Text = "";
            maskedTextBox47.Text = "";
            maskedTextBox48.Text = "";
            maskedTextBox49.Text = "";
            maskedTextBox50.Text = "";
            maskedTextBox51.Text = "";
            maskedTextBox52.Text = "";
            maskedTextBox53.Text = "";
            maskedTextBox54.Text = "";
            maskedTextBox55.Text = "";
            maskedTextBox56.Text = "";
            maskedTextBox57.Text = "";
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
            comboBox8.Text = "";
            dataGridView1.DataSource = null;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            if (textBox3.Text != "")
            {
                paciente.consultar_antecedentes_criminais(dataGridView1, textBox3.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            string processo = textBox11.Text;
            string Local = textBox8.Text;
            string classe = textBox7.Text;
            string foro = textBox9.Text;
            string situacao = textBox10.Text;
            string data_julgamento = maskedTextBox1.Text;
            string auto_prisao = textBox13.Text;
            int Id_paciente = Convert.ToInt32(textBox3.Text);

            paciente.set_Id_paciente(Id_paciente);
            paciente.set_Processo(processo);
            paciente.set_Local(Local);
            paciente.set_Classe(classe);
            paciente.set_Foro(foro);
            paciente.set_Situacao(situacao);
            paciente.set_Data_julgamento(data_julgamento);
            paciente.set_Auto_prisao(auto_prisao);
            paciente.Cadastrar_antecedentes_criminais(textBox3.Text);

            //apagar campos
            textBox11.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox13.Text = "";
            maskedTextBox1.Text = "";
            dataGridView1.DataSource = null;

            if (textBox3.Text != "")
            {
                paciente.consultar_antecedentes_criminais(dataGridView1, textBox3.Text);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox8.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox11.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox13.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            AtivarCampos();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            limparcampos();
            DesativarCampos();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar_pessoa cons = new Consultar_pessoa(this);
            cons.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Tela_Inicial pg = new Tela_Inicial();
            pg.Visible = true;
            this.Close();
            this.Dispose();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AtivarCampos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //tabPage4.Show();

            tabControl1.SelectedTab = tabPage4;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void Interface_principal_Load(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.Teal;
            button1.ForeColor = System.Drawing.Color.White;
        }


        












    }
}
