using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_casa_transitoria
{
    class Paciente
    {
        //inicio cadastro
        int Id_paciente;
        string Nome = "";
        string Apelido = "";
        string Data_Nascimento = "";
        string Sexo = "";
        string CPF = "";
        string RG = "";
        string Cidade = "";
        string Cidade_Natal = "";
        string Endereco = "";
        string Bairro = "";
        string Complemento = "";
        string Numero = "";
        string CEP = "";
        string Telefone = "";
        string Telefone_celular = "";
        string telefone_contato = "";
        string E_mail = "";
        string Nome_da_Mae = "";
        string Nome_do_Pai = "";
        string Estado_Civil = "";
        string Orgao_Expedicao = "";
        string Data_Expedicao = "";
        string Pais = "";
        string Referencia_Familiar = "";
        string UF = "";
        string UF_Naturalidade = "";
        string UF_Contato = "";
        string Observacao_pessoal = "";
        string Febre_Amarela1 = "";
        string Febre_Amarela2 = "";
        string Febre_Amarela3 = "";
        string Febre_Amarela_Unica = "";
        string HepatiteB_1 = "";
        string HepatiteB_2 = "";
        string HepatiteB_3 = "";
        string HepatiteB_Unica = "";
        string Influenza_1 = "";
        string Influenza_2 = "";
        string Influenza_3 = "";
        string Influenza_Unica = "";
        string Poliomelite_1 = "";
        string Poliomelite_2 = "";
        string Poliomelite_3 = "";
        string Poliomelite_Unica = "";
        string Pneumococica_10_Valente_1 = "";
        string Pneumococica_10_Valente_2 = "";
        string Pneumococica_10_Valente_3 = "";
        string Pneumococica_10_Valente_Unica = "";
        string Pneumococica_23_Valente_1 = "";
        string Pneumococica_23_Valente_2 = "";
        string Pneumococica_23_Valente_3 = "";
        string Pneumococica_23_Valente_Unica = "";
        string Tetraviral_1 = "";
        string Tetraviral_2 = "";
        string Tetraviral_3 = "";
        string Tetraviral_Unica = "";
        string Triplice_Bacteriana_1 = "";
        string Triplice_Bacteriana_2 = "";
        string Triplice_Bacteriana_3 = "";
        string Triplice_Bacteriana_Unica = "";
        string Triplice_Viral_1 = "";
        string Triplice_Viral_2 = "";
        string Triplice_Viral_3 = "";
        string Triplice_Viral_Unica = "";
        string Vacina_DT_difteria_e_tetano_1 = "";
        string Vacina_DT_difteria_e_tetano_2 = "";
        string Vacina_DT_difteria_e_tetano_3 = "";
        string Vacina_DT_difteria_e_tetano_Unica = "";
        string Vacina_Menigocica_C_1 = "";
        string Vacina_Menigocica_C_2 = "";
        string Vacina_Menigocica_C_3 = "";
        string Vacina_Menigocica_C_Unica = "";
        string Vacina_Oral_Rotavirus_Humano_1 = "";
        string Vacina_Oral_Rotavirus_Humano_2 = "";
        string Vacina_Oral_Rotavirus_Humano_3 = "";
        string Vacina_Oral_Rotavirus_Humano_Unica = "";
        string SOC_ESCOLARIDADE = "";
        string SOC_ESTUDO = "";
        string SOC_FEZCURSO = "";
        string SOC_CURSO = "";
        string SOC_TRABALHO = "";
        string SOC_PROFISSAO = "";
        string SOC_FILHOS = "";
        string SOC_RESPONSAVEL = "";
        string SOC_RUA = "";
        string SOC_TEMPO = "";
        string SOC_INSTITUICAO = "";
        string SOC_NOMEINSTITUICAO = "";
        string SOC_FAMILIAR = "";
        string SOC_PARENTESCO = "";
        string SOC_ADICIONAIS = "";
        string PAT_FUMANTE = "";
        string PAT_ALERGIA = "";
        string PAT_ALCOOL = "";
        string PAT_REMEDIO = "";
        string PAT_DROGA = "";
        string PAT_DIABETES = "";
        string PAT_COLESTEROL = "";
        string PAT_CARDIACO = "";
        string PAT_AVC = "";
        string PAT_RINS = "";
        string PAT_RESPIRATORIO = "";
        string PAT_INTERNACAO = "";
        string PAT_CANCER = "";
        string PAT_HEREDITARIA = "";
        string PAT_DEFICIENCIA = "";
        string PAT_Hepatite = "";
        string PAT_DST = "";
        string PAT_TEMPO_F = "";
        string PAT_QUAL_A = "";
        string PAT_QUAL_AL = "";
        string PAT_QUAL_R = "";
        string PAT_QUAL_D = "";
        string PAT_QUAL_DI = "";
        string PAT_QUANTO_CO = "";
        string PAT_QUAL_CAR = "";
        string PAT_QUANDO_AVC = "";
        string PAT_TIPO_RIN = "";
        string PAT_QUAL_RES = "";
        string PAT_POR_IN = "";
        string PAT_QUAL_CA = "";
        string PAT_QUAL_HE = "";
        string PAT_QUAL_DE = "";
        string PAT_QUAL_HEP = "";
        string PAT_QUAL_DST = "";
        string Nome_medico = "";
        string PAT_motivo = "";
        string PAT_local_tratamento = "";
        string PAT_intervercoes_cirurgica = "";
        string PAT_observacao = "";

        //Fim cadastro
        //Variável Antecedentes Criminais
        int Id_criminal;
        string processo = "";
        string Local = "";
        string classe = "";
        string foro = "";
        string situacao = "";
        string data_julgamento = "";
        string auto_prisao;

        Banco_de_dados banco = new Banco_de_dados();
        SqlConnection con;
        //Fim Antecedentes


        // Começo Cadastrar.
        public void Cadastrar_paciente()
        {

            con = banco.abrir_conexao();  
                string inserir2 = @"insert into Paciente(Nome, Apelido, Data_nascimento, Sexo, CPF, RG, Cidade, Cidade_Natal, Endereco, Bairro, Complemento, Numero, CEP, Telefone, Telefone_celular, E_mail, Nome_da_Mae, Nome_do_Pai, Telefone_contato, Estado_Civil, Orgao_expedicao, data_expedicao, pais, referencia_familiar, UF, UF_Naturalidade, UF_Contato, Observacao_pessoal, Febre_Amarela1, Febre_Amarela2, Febre_Amarela3, Febre_Amarela_Unica, HepatiteB_1, HepatiteB_2, HepatiteB_3, HepatiteB_Unica, Influenza_1, Influenza_2, Influenza_3, Influenza_Unica, Poliomelite_1, Poliomelite_2, Poliomelite_3, Poliomelite_Unica, Pneumococica_10_Valente_1, Pneumococica_10_Valente_2, Pneumococica_10_Valente_3, Pneumococica_10_Valente_Unica, Pneumococica_23_Valente_1, Pneumococica_23_Valente_2, Pneumococica_23_Valente_3, Pneumococica_23_Valente_Unica, Tetraviral_1, Tetraviral_2, Tetraviral_3, Tetraviral_Unica, Triplice_Bacteriana_1, Triplice_Bacteriana_2, Triplice_Bacteriana_3, Triplice_Bacteriana_Unica, Triplice_Viral_1, Triplice_Viral_2, Triplice_Viral_3, Triplice_Viral_Unica, Vacina_DT_difteria_e_tetano_1, Vacina_DT_difteria_e_tetano_2, Vacina_DT_difteria_e_tetano_3, Vacina_DT_difteria_e_tetano_Unica, Vacina_Menigocica_C_1, Vacina_Menigocica_C_2, Vacina_Menigocica_C_3, Vacina_Menigocica_C_Unica, Vacina_Oral_Rotavirus_Humano_1, Vacina_Oral_Rotavirus_Humano_2, Vacina_Oral_Rotavirus_Humano_3, Vacina_Oral_Rotavirus_Humano_Unica, SOC_ESCOLARIDADE, SOC_ESTUDO, SOC_FEZCURSO, SOC_CURSO, SOC_TRABALHO, SOC_PROFISSAO, SOC_FILHOS, SOC_RESPONSAVEL, SOC_RUA, SOC_TEMPO, SOC_INSTITUICAO, SOC_NOMEINSTITUICAO, SOC_FAMILIAR, SOC_PARENTESCO, SOC_ADICIONAIS, PAT_FUMANTE, PAT_ALERGIA, PAT_ALCOOL, PAT_REMEDIO, PAT_DROGA, PAT_DIABETES, PAT_COLESTEROL, PAT_CARDIACO, PAT_AVC, PAT_RINS, PAT_RESPIRATORIO, PAT_INTERNACAO, PAT_CANCER, PAT_HEREDITARIA, PAT_DEFICIENCIA, PAT_HEPATITE, PAT_DST,  PAT_TEMPO_F, PAT_QUAL_A, PAT_QUAL_AL, PAT_QUAL_R, PAT_QUAL_D, PAT_QUAL_DI, PAT_QUANTO_CO, PAT_QUAL_CAR, PAT_QUANDO_AVC, PAT_TIPO_RIN, PAT_QUAL_RES, PAT_POR_IN, PAT_QUAL_CA, PAT_QUAL_HE, PAT_QUAL_DE, PAT_QUAL_HEP, PAT_QUAL_DST, Nome_medico, PAT_motivo, PAT_local_tratamento, PAT_intervercoes_cirurgica, PAT_observacao)  Values('" + Nome + "', '" + Apelido + "', '" + Data_Nascimento + "', '" + Sexo + "', '" + CPF + "', '" + RG + "', '" + Cidade + "', '" + Cidade_Natal + "', '" + Endereco + "' , '" + Bairro + "', '" + Complemento + "', '" + Numero + "', '" + CEP + "', '" + Telefone + "', '" + Telefone_celular + "', '" + E_mail + "', '" + Nome_da_Mae + "', '" + Nome_do_Pai + "', '" + telefone_contato + "', '" + Estado_Civil + "', '" + Orgao_Expedicao + "', '" + Data_Expedicao + "', '" + Pais + "', '" + Referencia_Familiar + "', '" + UF + "', '" + UF_Naturalidade + "', '" + UF_Contato + "', '" + Observacao_pessoal + "', '" + Febre_Amarela1 + "', '" + Febre_Amarela2 + "', '" + Febre_Amarela3 + "', '" + Febre_Amarela_Unica + "', '" + HepatiteB_1 + "', '" + HepatiteB_2 + "', '" + HepatiteB_3 + "', '" + HepatiteB_Unica + "', '" + Influenza_1 + "', '" + Influenza_2 + "', '" + Influenza_3 + "', '" + Influenza_Unica + "', '" + Poliomelite_1 + "', '" + Poliomelite_2 + "', '" + Poliomelite_3 + "', '" + Poliomelite_Unica + "', '" + Pneumococica_10_Valente_1 + "', '" + Pneumococica_10_Valente_2 + "', '" + Pneumococica_10_Valente_3 + "', '" + Pneumococica_10_Valente_Unica + "', '" + Pneumococica_23_Valente_1 + "', '" + Pneumococica_23_Valente_2 + "', '" + Pneumococica_23_Valente_3 + "', '" + Pneumococica_23_Valente_Unica + "', '" + Tetraviral_1 + "', '" + Tetraviral_2 + "', '" + Tetraviral_3 + "', '" + Tetraviral_Unica + "', '" + Triplice_Bacteriana_1 + "', '" + Triplice_Bacteriana_2 + "', '" + Triplice_Bacteriana_3 + "', '" + Triplice_Bacteriana_Unica + "', '" + Triplice_Viral_1 + "', '" + Triplice_Viral_2 + "', '" + Triplice_Viral_3 + "', '" + Triplice_Viral_Unica + "', '" + Vacina_DT_difteria_e_tetano_1 + "', '" + Vacina_DT_difteria_e_tetano_2 + "', '" + Vacina_DT_difteria_e_tetano_3 + "', '" + Vacina_DT_difteria_e_tetano_Unica + "', '" + Vacina_Menigocica_C_1 + "', '" + Vacina_Menigocica_C_2 + "', '" + Vacina_Menigocica_C_3 + "', '" + Vacina_Menigocica_C_Unica + "', '" + Vacina_Oral_Rotavirus_Humano_1 + "', '" + Vacina_Oral_Rotavirus_Humano_2 + "', '" + Vacina_Oral_Rotavirus_Humano_3 + "', '" + Vacina_Oral_Rotavirus_Humano_Unica + "', '" + SOC_ESCOLARIDADE + "', '" + SOC_ESTUDO + "', '" + SOC_FEZCURSO + "', '" + SOC_CURSO + "', '" + SOC_TRABALHO + "', '" + SOC_PROFISSAO + "', '" + SOC_FILHOS + "', '" + SOC_RESPONSAVEL + "', '" + SOC_RUA + "', '" + SOC_TEMPO + "', '" + SOC_INSTITUICAO + "', '" + SOC_NOMEINSTITUICAO + "', '" + SOC_FAMILIAR + "', '" + SOC_PARENTESCO + "', '" + SOC_ADICIONAIS + "', '" + PAT_FUMANTE + "', '" + PAT_ALERGIA + "', '" + PAT_ALCOOL + "', '" + PAT_REMEDIO + "', '" + PAT_DROGA + "', '" + PAT_DIABETES + "', '" + PAT_COLESTEROL + "', '" + PAT_CARDIACO + "', '" + PAT_AVC + "', '" + PAT_RINS + "', '" + PAT_RESPIRATORIO + "', '" + PAT_INTERNACAO + "', '" + PAT_CANCER + "', '" + PAT_HEREDITARIA + "', '" + PAT_DEFICIENCIA + "', '" + PAT_Hepatite + "', '" + PAT_DST + "', '" + PAT_TEMPO_F + "', '" + PAT_QUAL_A + "', '" + PAT_QUAL_AL + "', '" + PAT_QUAL_R + "', '" + PAT_QUAL_D + "', '" + PAT_QUAL_DI + "', '" + PAT_QUANTO_CO + "', '" + PAT_QUAL_CAR + "', '" + PAT_QUANDO_AVC + "', '" + PAT_TIPO_RIN + "', '" + PAT_QUAL_RES + "', '" + PAT_POR_IN + "', '" + PAT_QUAL_CA + "', '" + PAT_QUAL_HE + "', '" + PAT_QUAL_DE + "', '" + PAT_QUAL_HEP + "', '" + PAT_QUAL_DST + "', '" + Nome_medico + "', '" + PAT_motivo + "', '" + PAT_local_tratamento + "', '" + PAT_intervercoes_cirurgica + "' , '" + PAT_observacao + "');Select @@IDENTITY as newId;";
                SqlCommand _cmd2 = new SqlCommand(inserir2, con);
            
                //_cmd2.ExecuteNonQuery();
                string insertedID = _cmd2.ExecuteScalar().ToString();

                string inserir = @"insert into criminal(id_paciente,local, classe, foro, situacao, processo, data_julgamento, auto_prisao) Values('" + insertedID + "', '" + Local + "', '" + classe + "', '" + foro + "', '" + situacao + "', '" + processo + "', '" + data_julgamento + "', '" + auto_prisao + "')";
                SqlCommand _cmd = new SqlCommand(inserir, con);
                _cmd.ExecuteNonQuery();
                MessageBox.Show("Dados inseridos com sucesso ! ", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();

        }

        public void Cadastrar_antecedentes_criminais(string id_paciente)
        {
            con = banco.abrir_conexao();


            string inserir = @"insert into criminal(id_paciente,local, classe, foro, situacao, processo, data_julgamento, auto_prisao) Values('" + id_paciente + "', '" + Local + "', '" + classe + "', '" + foro + "', '" + situacao + "', '" + processo + "', '" + data_julgamento + "', '" + auto_prisao + "')";
            SqlCommand _cmd = new SqlCommand(inserir, con);
            DialogResult dialogResult = MessageBox.Show("Deseja mesmo realizar o cadastro? ",
                "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {               
                _cmd.ExecuteNonQuery();
                MessageBox.Show("Dados inseridos com sucesso ! ", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                
            }
            con.Close();
        }

        // id criminal
        public int get_Id_criminal()
        {
            return Id_criminal;
        }


        public void set_Id_criminal(int Id_criminal2)
        {
            this.Id_criminal = Id_criminal2;
        }

        // fim id criminal


        // Numero processo

        public string get_Processo()
        {
            return processo;
        }

        public void set_Processo(string processo)
        {
            this.processo = processo;
        }

        // fim numero processo

        //inicio local

        public string get_Local()
        {
            return Local;
        }

        public void set_Local(string Local)
        {
            this.Local = Local;
        }

        // fim do local

        // inicio classe

        public string get_classe()
        {
            return classe;
        }

        public void set_Classe(string classe)
        {
            this.classe = classe;
        }

        // fim classe

        // inicio foro 
        public string get_foro()
        {
            return foro;
        }

        public void set_Foro(string foro)
        {
            this.foro = foro;
        }

        // fim foro


        // inicio situacao

        public string get_situacao()
        {
            return situacao;
        }

        public void set_Situacao(string situacao)
        {
            this.situacao = situacao;
        }

        //fim situacao

        // inicio data_julgamento

        public string get_data_julgamento()
        {
            return data_julgamento;
        }

        public void set_Data_julgamento(string data_julgamento)
        {
            this.data_julgamento = data_julgamento;
        }

        //fim data_julgamento

        // inicio auto_prisao

        public string get_auto_prisao()
        {
            return auto_prisao;
        }

        public void set_Auto_prisao(string auto_prisao)
        {
            this.auto_prisao = auto_prisao;
        }

        //fim auto_prisao

        //get_Id_Paciente
        public int get_Id_paciente()
        {
            return Id_paciente;
        }

        public void set_Id_paciente(int Id_paciente2)
        {
            this.Id_paciente = Id_paciente2;
        }

        //get_Nome
        public string get_Nome()
        {
            return Nome;
        }

        public void set_Nome(string Nome)
        {
            this.Nome = Nome;
        }

        //get_Apelido
        public string get_Apelido()
        {
            return Apelido;
        }

        public void set_Apelido(string Apelido)
        {
            this.Apelido = Apelido;
        }

        

        //get_Data_nascimento
        public string get_Data_nascimento()
        {
            return Data_Nascimento;
        }

        public void set_Data_nascimento(string Data_nascimento)
        {
            this.Data_Nascimento = Data_nascimento;
        }

        //get_Sexo
        public string get_Sexo()
        {
            return Sexo;
        }

        public void set_Sexo(string Sexo)
        {
            this.Sexo = Sexo;
        }

        //get_CPF
        public string get_CPF()
        {
            return CPF;
        }

        public void set_CPF(string CPF)
        {
            this.CPF = CPF;
        }

        //get_RG
        public string get_RG()
        {
            return RG;
        }

        public void set_RG(string RG)
        {
            this.RG = RG;
        }

        //get_Cidade
        public string get_Cidade()
        {
            return Cidade;
        }
        public void set_Cidade(string Cidade)
        {
            this.Cidade = Cidade;
        }

        //get_Cidade_Natal
        public string get_Cidade_Natal()
        {
            return Cidade_Natal;
        }

        public void set_Cidade_Natal(string Cidade_Natal)
        {
            this.Cidade_Natal = Cidade_Natal;
        }

        //get_Endereco
        public string get_Endereco()
        {
            return Endereco;
        }

        public void set_Endereco(string Endereco)
        {
            this.Endereco = Endereco;
        }

        //get_Bairro
        public string get_Bairro()
        {
            return Bairro;
        }

        public void set_Bairro(string Bairro)
        {
            this.Bairro = Bairro;
        }

        // Complemento 

        public string get_Complemento()
        {
            return Complemento;
        }

        public void set_Complemento(string Complemento)
        {
            this.Complemento = Complemento;
        }

        //

        // NUMEROS 

        public string get_Numero()
        {
            return Numero;
        }

        public void set_Numero(string Numero)
        {
            this.Numero = Numero;
        }

        //

        // CEP 

        public string get_CEP()
        {
            return CEP;
        }

        public void set_CEP(string CEP)
        {
            this.CEP = CEP;
        }

        //

        //get_Telefone
        public string get_Telefone()
        {
            return Telefone;
        }

        public void set_Telefone(string Telefone)
        {
            this.Telefone = Telefone;
        }

        //

        //get_Telefone_celular
        public string get_Telefone_celular()
        {
            return Telefone_celular;
        }

        public void set_Telefone_celular(string Telefone_celular)
        {
            this.Telefone_celular = Telefone_celular;
        }

        //

        //get_E_mail
        public string get_E_mail()
        {
            return E_mail;
        }

        public void set_E_mail(string E_mail)
        {
            this.E_mail = E_mail;
        }

        //get_Nome_da_Mae
        public string get_Nome_da_Mae()
        {
            return Nome_da_Mae;
        }

        public void set_Nome_da_Mae(string Nome_da_Mae)
        {
            this.Nome_da_Mae = Nome_da_Mae;
        }

        //get_Nome_do_Pai
        public string get_Nome_do_Pai()
        {
            return Nome_do_Pai;
        }

        public void set_Nome_do_Pai(string Nome_do_Pai)
        {
            this.Nome_do_Pai = Nome_do_Pai;
        }

        //get_Religiao
        public string get_Telefone_contato()
        {
            return telefone_contato;
        }

        public void set_Telefone_contato(string Telefone_contato)
        {
            this.telefone_contato = Telefone_contato;
        }

        //get_Estado_Civil
        public string get_Estado_Civil()
        {
            return Estado_Civil;
        }

        public void set_Estado_Civil(string Estado_Civil)
        {
            this.Estado_Civil = Estado_Civil;
        }

        //get_Orgao_expedicao
        public string get_Orgao_expedicao()
        {
            return Orgao_Expedicao;
        }

        public void set_Orgao_expedicao(string Orgao_expedicao)
        {
            this.Orgao_Expedicao = Orgao_expedicao;
        }

        //get_data_expedicao
        public string get_data_expedicao()
        {
            return Data_Expedicao;
        }

        public void set_data_expedicao(string data_expedicao)
        {
            this.Data_Expedicao = data_expedicao;
        }

        //get_pais
        public string get_pais()
        {
            return Pais;
        }

        public void set_pais(string pais)
        {
            this.Pais = pais;
        }

        //get_referencia_familiar
        public string get_referencia_familiar()
        {
            return Referencia_Familiar;
        }

        public void set_referencia_familiar(string referencia_familiar)
        {
            this.Referencia_Familiar = referencia_familiar;
        }

        //get_UF
        public string get_UF()
        {
            return UF;
        }

        public void set_UF(string UF)
        {
            this.UF = UF;
        }

        //

        //get_UF
        public string get_UF_Naturalidade()
        {
            return UF_Naturalidade;
        }

        public void set_UF_Naturalidade(string UF_Naturalidade)
        {
            this.UF_Naturalidade = UF_Naturalidade;
        }


        //get_UF_Contato
        public string get_UF_Contato()
        {
            return UF_Contato;
        }

        public void set_UF_Contato(string UF_Contato)
        {
            this.UF_Contato = UF_Contato;
        }

        //get_UF_Contato
        public string get_Observacao_pessoal()
        {
            return Observacao_pessoal;
        }

        public void set_Observacao_pessoal(string Observacao_pessoal)
        {
            this.Observacao_pessoal = Observacao_pessoal;
        }

        //
        //get_Febre_Amarela1
        public string get_Febre_Amarela1()
        {
            return Febre_Amarela1;
        }

        public void set_Febre_Amarela1(string Febre_Amarela1)
        {
            this.Febre_Amarela1 = Febre_Amarela1;
        }

        //get_Febre_Amarela2
        public string get_Febre_Amarela2()
        {
            return Febre_Amarela2;
        }

        public void set_Febre_Amarela2(string Febre_Amarela2)
        {
            this.Febre_Amarela2 = Febre_Amarela2;
        }

        //get_Febre_Amarela3
        public string get_Febre_Amarela3()
        {
            return Febre_Amarela3;
        }

        public void set_Febre_Amarela3(string Febre_Amarela3)
        {
            this.Febre_Amarela3 = Febre_Amarela3;
        }

        //get_Febre_Amarela_Unica
        public string get_Febre_Amarela_Unica()
        {
            return Febre_Amarela_Unica;
        }

        public void set_Febre_Amarela_Unica(string Febre_Amarela_Unica)
        {
            this.Febre_Amarela_Unica = Febre_Amarela_Unica;
        }

        //get_HepatiteB_1
        public string get_HepatiteB_1()
        {
            return HepatiteB_1;
        }

        public void set_HepatiteB_1(string HepatiteB_1)
        {
            this.HepatiteB_1 = HepatiteB_1;
        }

        //get_HepatiteB_2
        public string get_HepatiteB_2()
        {
            return HepatiteB_2;
        }

        public void set_HepatiteB_2(string HepatiteB_2)
        {
            this.HepatiteB_2 = HepatiteB_2;
        }

        //get_HepatiteB_3
        public string get_HepatiteB_3()
        {
            return HepatiteB_3;
        }

        public void set_HepatiteB_3(string HepatiteB_3)
        {
            this.HepatiteB_3 = HepatiteB_3;
        }

        //get_HepatiteB_Unica
        public string get_HepatiteB_Unica()
        {
            return HepatiteB_Unica;
        }

        public void set_HepatiteB_Unica(string HepatiteB_Unica)
        {
            this.HepatiteB_Unica = HepatiteB_Unica;
        }

        //get_Influenza_1
        public string get_Influenza_1()
        {
            return Influenza_1;
        }

        public void set_Influenza_1(string Influenza_1)
        {
            this.Influenza_1 = Influenza_1;
        }

        //get_Influenza_2
        public string get_Influenza_2()
        {
            return Influenza_2;
        }

        public void set_Influenza_2(string Influenza_2)
        {
            this.Influenza_2 = Influenza_2;
        }

        //get_Influenza_3
        public string get_Influenza_3()
        {
            return Influenza_3;
        }

        public void set_Influenza_3(string Influenza_3)
        {
            this.Influenza_3 = Influenza_3;
        }

        //get_Influenza_Unica
        public string get_Influenza_Unica()
        {
            return Influenza_Unica;
        }

        public void set_Influenza_Unica(string Influenza_Unica)
        {
            this.Influenza_Unica = Influenza_Unica;
        }

        //get_Poliomelite_1
        public string get_Poliomelite_1()
        {
            return Poliomelite_1;
        }

        public void set_Poliomelite_1(string Poliomelite_1)
        {
            this.Poliomelite_1 = Poliomelite_1;
        }

        //get_Poliomelite_2
        public string get_Poliomelite_2()
        {
            return Poliomelite_2;
        }

        public void set_Poliomelite_2(string Poliomelite_2)
        {
            this.Poliomelite_2 = Poliomelite_2;
        }

        //get_Poliomelite_3
        public string get_Poliomelite_3()
        {
            return Poliomelite_3;
        }

        public void set_Poliomelite_3(string Poliomelite_3)
        {
            this.Poliomelite_3 = Poliomelite_3;
        }

        //get_Poliomelite_Unica
        public string get_Poliomelite_Unica()
        {
            return Poliomelite_Unica;
        }

        public void set_Poliomelite_Unica(string Poliomelite_Unica)
        {
            this.Poliomelite_Unica = Poliomelite_Unica;
        }

        //get_Pneumococica_10_Valente_1
        public string get_Pneumococica_10_Valente_1()
        {
            return Pneumococica_10_Valente_1;
        }

        public void set_Pneumococica_10_Valente_1(string Pneumococica_10_Valente_1)
        {
            this.Pneumococica_10_Valente_1 = Pneumococica_10_Valente_1;
        }

        //get_Pneumococica_10_Valente_2
        public string get_Pneumococica_10_Valente_2()
        {
            return Pneumococica_10_Valente_2;
        }

        public void set_Pneumococica_10_Valente_2(string Pneumococica_10_Valente_2)
        {
            this.Pneumococica_10_Valente_2 = Pneumococica_10_Valente_2;
        }

        //get_Pneumococica_10_Valente_3
        public string get_Pneumococica_10_Valente_3()
        {
            return Pneumococica_10_Valente_3;
        }

        public void set_Pneumococica_10_Valente_3(string Pneumococica_10_Valente_3)
        {
            this.Pneumococica_10_Valente_3 = Pneumococica_10_Valente_3;
        }

        //get_Pneumococica_10_Valente_Unica
        public string get_Pneumococica_10_Valente_Unica()
        {
            return Pneumococica_10_Valente_Unica;
        }

        public void set_Pneumococica_10_Valente_Unica(string Pneumococica_10_Valente_Unica)
        {
            this.Pneumococica_10_Valente_Unica = Pneumococica_10_Valente_Unica;
        }

        //get_Pneumococica_23_Valente_1
        public string get_Pneumococica_23_Valente_1()
        {
            return Pneumococica_23_Valente_1;
        }

        public void set_Pneumococica_23_Valente_1(string Pneumococica_23_Valente_1)
        {
            this.Pneumococica_23_Valente_1 = Pneumococica_23_Valente_1;
        }

        //get_Pneumococica_23_Valente_2
        public string get_Pneumococica_23_Valente_2()
        {
            return Pneumococica_23_Valente_2;
        }

        public void set_Pneumococica_23_Valente_2(string Pneumococica_23_Valente_2)
        {
            this.Pneumococica_23_Valente_2 = Pneumococica_23_Valente_2;
        }

        //get_Pneumococica_23_Valente_3
        public string get_Pneumococica_23_Valente_3()
        {
            return Pneumococica_23_Valente_3;
        }

        public void set_Pneumococica_23_Valente_3(string Pneumococica_23_Valente_3)
        {
            this.Pneumococica_23_Valente_3 = Pneumococica_23_Valente_3;
        }

        //get_Pneumococica_23_Valente_Unica
        public string get_Pneumococica_23_Valente_Unica()
        {
            return Pneumococica_23_Valente_Unica;
        }

        public void set_Pneumococica_23_Valente_Unica(string Pneumococica_23_Valente_Unica)
        {
            this.Pneumococica_23_Valente_Unica = Pneumococica_23_Valente_Unica;
        }

        //get_Tetraviral_1
        public string get_Tetraviral_1()
        {
            return Tetraviral_1;
        }

        public void set_Tetraviral_1(string Tetraviral_1)
        {
            this.Tetraviral_1 = Tetraviral_1;
        }

        //get_Tetraviral_2
        public string get_Tetraviral_2()
        {
            return Tetraviral_2;
        }

        public void set_Tetraviral_2(string Tetraviral_2)
        {
            this.Tetraviral_2 = Tetraviral_2;
        }

        //get_Tetraviral_3
        public string get_Tetraviral_3()
        {
            return Tetraviral_3;
        }

        public void set_Tetraviral_3(string Tetraviral_3)
        {
            this.Tetraviral_3 = Tetraviral_3;
        }

        //get_Tetraviral_Unica
        public string get_Tetraviral_Unica()
        {
            return Tetraviral_Unica;
        }

        public void set_Tetraviral_Unica(string Tetraviral_Unica)
        {
            this.Tetraviral_Unica = Tetraviral_Unica;
        }

        //get_Triplice_Bacteriana_1
        public string get_Triplice_Bacteriana_1()
        {
            return Triplice_Bacteriana_1;
        }

        public void set_Triplice_Bacteriana_1(string Triplice_Bacteriana_1)
        {
            this.Triplice_Bacteriana_1 = Triplice_Bacteriana_1;
        }

        //get_Triplice_Bacteriana_2
        public string get_Triplice_Bacteriana_2()
        {
            return Triplice_Bacteriana_2;
        }

        public void set_Triplice_Bacteriana_2(string Triplice_Bacteriana_2)
        {
            this.Triplice_Bacteriana_2 = Triplice_Bacteriana_2;
        }

        //get_Triplice_Bacteriana_3
        public string get_Triplice_Bacteriana_3()
        {
            return Triplice_Bacteriana_3;
        }

        public void set_Triplice_Bacteriana_3(string Triplice_Bacteriana_3)
        {
            this.Triplice_Bacteriana_3 = Triplice_Bacteriana_3;
        }

        //get_Triplice_Bacteriana_Unica
        public string get_Triplice_Bacteriana_Unica()
        {
            return Triplice_Bacteriana_Unica;
        }

        public void set_Triplice_Bacteriana_Unica(string Triplice_Bacteriana_Unica)
        {
            this.Triplice_Bacteriana_Unica = Triplice_Bacteriana_Unica;
        }

        //get_Triplice_Viral_1
        public string get_Triplice_Viral_1()
        {
            return Triplice_Viral_1;
        }

        public void set_Triplice_Viral_1(string Triplice_Viral_1)
        {
            this.Triplice_Viral_1 = Triplice_Viral_1;
        }

        //get_Triplice_Viral_2
        public string get_Triplice_Viral_2()
        {
            return Triplice_Viral_2;
        }

        public void set_Triplice_Viral_2(string Triplice_Viral_2)
        {
            this.Triplice_Viral_2 = Triplice_Viral_2;
        }

        //get_Triplice_Viral_3
        public string get_Triplice_Viral_3()
        {
            return Triplice_Viral_3;
        }

        public void set_Triplice_Viral_3(string Triplice_Viral_3)
        {
            this.Triplice_Viral_3 = Triplice_Viral_3;
        }

        //get_Triplice_Viral_Unica
        public string get_Triplice_Viral_Unica()
        {
            return Triplice_Viral_Unica;
        }

        public void set_Triplice_Viral_Unica(string Triplice_Viral_Unica)
        {
            this.Triplice_Viral_Unica = Triplice_Viral_Unica;
        }

        //get_Vacina_DT_difteria_e_tetano_1
        public string get_Vacina_DT_difteria_e_tetano_1()
        {
            return Vacina_DT_difteria_e_tetano_1;
        }

        public void set_Vacina_DT_difteria_e_tetano_1(string Vacina_DT_difteria_e_tetano_1)
        {
            this.Vacina_DT_difteria_e_tetano_1 = Vacina_DT_difteria_e_tetano_1;
        }

        //get_Vacina_DT_difteria_e_tetano_2
        public string get_Vacina_DT_difteria_e_tetano_2()
        {
            return Vacina_DT_difteria_e_tetano_2;
        }

        public void set_Vacina_DT_difteria_e_tetano_2(string Vacina_DT_difteria_e_tetano_2)
        {
            this.Vacina_DT_difteria_e_tetano_2 = Vacina_DT_difteria_e_tetano_2;
        }

        //get_Vacina_DT_difteria_e_tetano_3
        public string get_Vacina_DT_difteria_e_tetano_3()
        {
            return Vacina_DT_difteria_e_tetano_3;
        }

        public void set_Vacina_DT_difteria_e_tetano_3(string Vacina_DT_difteria_e_tetano_3)
        {
            this.Vacina_DT_difteria_e_tetano_3 = Vacina_DT_difteria_e_tetano_3;
        }

        //get_Vacina_DT_difteria_e_tetano_Unica
        public string get_Vacina_DT_difteria_e_tetano_Unica()
        {
            return Vacina_DT_difteria_e_tetano_Unica;
        }

        public void set_Vacina_DT_difteria_e_tetano_Unica(string Vacina_DT_difteria_e_tetano_Unica)
        {
            this.Vacina_DT_difteria_e_tetano_Unica = Vacina_DT_difteria_e_tetano_Unica;
        }

        //get_Vacina_Menigocica_C_1
        public string get_Vacina_Menigocica_C_1()
        {
            return Vacina_Menigocica_C_1;
        }

        public void set_Vacina_Menigocica_C_1(string Vacina_Menigocica_C_1)
        {
            this.Vacina_Menigocica_C_1 = Vacina_Menigocica_C_1;
        }

        //get_Vacina_Menigocica_C_2
        public string get_Vacina_Menigocica_C_2()
        {
            return Vacina_Menigocica_C_2;
        }

        public void set_Vacina_Menigocica_C_2(string Vacina_Menigocica_C_2)
        {
            this.Vacina_Menigocica_C_2 = Vacina_Menigocica_C_2;
        }

        //get_Vacina_Menigocica_C_3
        public string get_Vacina_Menigocica_C_3()
        {
            return Vacina_Menigocica_C_3;
        }

        public void set_Vacina_Menigocica_C_3(string Vacina_Menigocica_C_3)
        {
            this.Vacina_Menigocica_C_3 = Vacina_Menigocica_C_3;
        }

        //get_Vacina_Menigocica_C_Unica
        public string get_Vacina_Menigocica_C_Unica()
        {
            return Vacina_Menigocica_C_Unica;
        }

        public void set_Vacina_Menigocica_C_Unica(string Vacina_Menigocica_C_Unica)
        {
            this.Vacina_Menigocica_C_Unica = Vacina_Menigocica_C_Unica;
        }

        //get_Vacina_Oral_Rotavirus_Humano_1
        public string get_Vacina_Oral_Rotavirus_Humano_1()
        {
            return Vacina_Oral_Rotavirus_Humano_1;
        }

        public void set_Vacina_Oral_Rotavirus_Humano_1(string Vacina_Oral_Rotavirus_Humano_1)
        {
            this.Vacina_Oral_Rotavirus_Humano_1 = Vacina_Oral_Rotavirus_Humano_1;
        }

        //get_Vacina_Oral_Rotavirus_Humano_2
        public string get_Vacina_Oral_Rotavirus_Humano_2()
        {
            return Vacina_Oral_Rotavirus_Humano_2;
        }

        public void set_Vacina_Oral_Rotavirus_Humano_2(string Vacina_Oral_Rotavirus_Humano_2)
        {
            this.Vacina_Oral_Rotavirus_Humano_2 = Vacina_Oral_Rotavirus_Humano_2;
        }

        //get_Vacina_Oral_Rotavirus_Humano_3
        public string get_Vacina_Oral_Rotavirus_Humano_3()
        {
            return Vacina_Oral_Rotavirus_Humano_3;
        }

        public void set_Vacina_Oral_Rotavirus_Humano_3(string Vacina_Oral_Rotavirus_Humano_3)
        {
            this.Vacina_Oral_Rotavirus_Humano_3 = Vacina_Oral_Rotavirus_Humano_3;
        }

        //get_Vacina_Oral_Rotavirus_Humano_Unica
        public string get_Vacina_Oral_Rotavirus_Humano_Unica()
        {
            return Vacina_Oral_Rotavirus_Humano_Unica;
        }

        public void set_Vacina_Oral_Rotavirus_Humano_Unica(string Vacina_Oral_Rotavirus_Humano_Unica)
        {
            this.Vacina_Oral_Rotavirus_Humano_Unica = Vacina_Oral_Rotavirus_Humano_Unica;
        }

        //get_SOC_ESCOLARIDADE
        public string get_SOC_ESCOLARIDADE()
        {
            return SOC_ESCOLARIDADE;
        }

        public void set_SOC_ESCOLARIDADE(string SOC_ESCOLARIDADE)
        {
            this.SOC_ESCOLARIDADE = SOC_ESCOLARIDADE;
        }

        //get_SOC_ESTUDO
        public string get_SOC_ESTUDO()
        {
            return SOC_ESTUDO;
        }

        public void set_SOC_ESTUDO(string SOC_ESTUDO)
        {
            this.SOC_ESTUDO = SOC_ESTUDO;
        }

        //get_SOC_FEZCURSO
        public string get_SOC_FEZCURSO()
        {
            return SOC_FEZCURSO;
        }

        public void set_SOC_FEZCURSO(string SOC_FEZCURSO)
        {
            this.SOC_FEZCURSO = SOC_FEZCURSO;
        }

        //get_SOC_CURSO
        public string get_SOC_CURSO()
        {
            return SOC_CURSO;
        }

        public void set_SOC_CURSO(string SOC_CURSO)
        {
            this.SOC_CURSO = SOC_CURSO;
        }

        //get_SOC_TRABALHO
        public string get_SOC_TRABALHO()
        {
            return SOC_TRABALHO;
        }

        public void set_SOC_TRABALHO(string SOC_TRABALHO)
        {
            this.SOC_TRABALHO = SOC_TRABALHO;
        }

        //get_SOC_PROFISSAO
        public string get_SOC_PROFISSAO()
        {
            return SOC_PROFISSAO;
        }

        public void set_SOC_PROFISSAO(string SOC_PROFISSAO)
        {
            this.SOC_PROFISSAO = SOC_PROFISSAO;
        }

        //get_SOC_FILHOS
        public string get_SOC_FILHOS()
        {
            return SOC_FILHOS;
        }

        public void set_SOC_FILHOS(string SOC_FILHOS)
        {
            this.SOC_FILHOS = SOC_FILHOS;
        }

        //get_SOC_RESPONSAVEL
        public string get_SOC_RESPONSAVEL()
        {
            return SOC_RESPONSAVEL;
        }

        public void set_SOC_RESPONSAVEL(string SOC_RESPONSAVEL)
        {
            this.SOC_RESPONSAVEL = SOC_RESPONSAVEL;
        }

        //get_SOC_RUA
        public string get_SOC_RUA()
        {
            return SOC_RUA;
        }

        public void set_SOC_RUA(string SOC_RUA)
        {
            this.SOC_RUA = SOC_RUA;
        }

        //get_SOC_TEMPO
        public string get_SOC_TEMPO()
        {
            return SOC_TEMPO;
        }

        public void set_SOC_TEMPO(string SOC_TEMPO)
        {
            this.SOC_TEMPO = SOC_TEMPO;
        }

        //get_SOC_INSTITUICAO
        public string get_SOC_INSTITUICAO()
        {
            return SOC_INSTITUICAO;
        }

        public void set_SOC_INSTITUICAO(string SOC_INSTITUICAO)
        {
            this.SOC_INSTITUICAO = SOC_INSTITUICAO;
        }

        //get_SOC_NOMEINSTITUICAO
        public string get_SOC_NOMEINSTITUICAO()
        {
            return SOC_NOMEINSTITUICAO;
        }

        public void set_SOC_NOMEINSTITUICAO(string SOC_NOMEINSTITUICAO)
        {
            this.SOC_NOMEINSTITUICAO = SOC_NOMEINSTITUICAO;
        }

        //get_SOC_FAMILIAR
        public string get_SOC_FAMILIAR()
        {
            return SOC_FAMILIAR;
        }

        public void set_SOC_FAMILIAR(string SOC_FAMILIAR)
        {
            this.SOC_FAMILIAR = SOC_FAMILIAR;
        }

        //get_SOC_PARENTESCO
        public string get_SOC_PARENTESCO()
        {
            return SOC_PARENTESCO;
        }

        public void set_SOC_PARENTESCO(string SOC_PARENTESCO)
        {
            this.SOC_PARENTESCO = SOC_PARENTESCO;
        }

        //get_SOC_ADICIONAIS
        public string get_SOC_ADICIONAIS()
        {
            return SOC_ADICIONAIS;
        }

        public void set_SOC_ADICIONAIS(string SOC_ADICIONAIS)
        {
            this.SOC_ADICIONAIS = SOC_ADICIONAIS;
        }

        //get_PAT_FUMANTE
        public string get_PAT_FUMANTE()
        {
            return PAT_FUMANTE;
        }

        public void set_PAT_FUMANTE(string PAT_FUMANTE)
        {
            this.PAT_FUMANTE = PAT_FUMANTE;
        }

        //get_PAT_ALERGIA
        public string get_PAT_ALERGIA()
        {
            return PAT_ALERGIA;
        }

        public void set_PAT_ALERGIA(string PAT_ALERGIA)
        {
            this.PAT_ALERGIA = PAT_ALERGIA;
        }

        //get_PAT_ALCOOL
        public string get_PAT_ALCOOL()
        {
            return PAT_ALCOOL;
        }

        public void set_PAT_ALCOOL(string PAT_ALCOOL)
        {
            this.PAT_ALCOOL = PAT_ALCOOL;
        }

        //get_PAT_REMEDIO
        public string get_PAT_REMEDIO()
        {
            return PAT_REMEDIO;
        }

        public void set_PAT_REMEDIO(string PAT_REMEDIO)
        {
            this.PAT_REMEDIO = PAT_REMEDIO;
        }

        //get_PAT_DROGA
        public string get_PAT_DROGA()
        {
            return PAT_DROGA;
        }

        public void set_PAT_DROGA(string PAT_DROGA)
        {
            this.PAT_DROGA = PAT_DROGA;
        }

        //get_PAT_DIABETES
        public string get_PAT_DIABETES()
        {
            return PAT_DIABETES;
        }

        public void set_PAT_DIABETES(string PAT_DIABETES)
        {
            this.PAT_DIABETES = PAT_DIABETES;
        }

        //get_PAT_COLESTEROL
        public string get_PAT_COLESTEROL()
        {
            return PAT_COLESTEROL;
        }

        public void set_PAT_COLESTEROL(string PAT_COLESTEROL)
        {
            this.PAT_COLESTEROL = PAT_COLESTEROL;
        }

        //get_PAT_CARDIACO
        public string get_PAT_CARDIACO()
        {
            return PAT_CARDIACO;
        }

        public void set_PAT_CARDIACO(string PAT_CARDIACO)
        {
            this.PAT_CARDIACO = PAT_CARDIACO;
        }

        //get_PAT_AVC
        public string get_PAT_AVC()
        {
            return PAT_AVC;
        }

        public void set_PAT_AVC(string PAT_AVC)
        {
            this.PAT_AVC = PAT_AVC;
        }

        //get_PAT_RINS
        public string get_PAT_RINS()
        {
            return PAT_RINS;
        }

        public void set_PAT_RINS(string PAT_RINS)
        {
            this.PAT_RINS = PAT_RINS;
        }

        //get_PAT_RESPIRATORIO
        public string get_PAT_RESPIRATORIO()
        {
            return PAT_RESPIRATORIO;
        }

        public void set_PAT_RESPIRATORIO(string PAT_RESPIRATORIO)
        {
            this.PAT_RESPIRATORIO = PAT_RESPIRATORIO;
        }

        //get_PAT_INTERNACAO
        public string get_PAT_INTERNACAO()
        {
            return PAT_INTERNACAO;
        }

        public void set_PAT_INTERNACAO(string PAT_INTERNACAO)
        {
            this.PAT_INTERNACAO = PAT_INTERNACAO;
        }

        //get_PAT_CANCER
        public string get_PAT_CANCER()
        {
            return PAT_CANCER;
        }

        public void set_PAT_CANCER(string PAT_CANCER)
        {
            this.PAT_CANCER = PAT_CANCER;
        }

        //get_PAT_HEREDITARIA
        public string get_PAT_HEREDITARIA()
        {
            return PAT_HEREDITARIA;
        }

        public void set_PAT_HEREDITARIA(string PAT_HEREDITARIA)
        {
            this.PAT_HEREDITARIA = PAT_HEREDITARIA;
        }

        //get_PAT_DEFICIENCIA
        public string get_PAT_DEFICIENCIA()
        {
            return PAT_DEFICIENCIA;
        }

        public void set_PAT_DEFICIENCIA(string PAT_DEFICIENCIA)
        {
            this.PAT_DEFICIENCIA = PAT_DEFICIENCIA;
        }

        //get_PAT_HEPATITE
        public string get_PAT_Hepatite()
        {
            return PAT_Hepatite;
        }

        public void set_PAT_Hepatite(string PAT_Hepatite)
        {
            this.PAT_Hepatite = PAT_Hepatite;
        }

        //

        //get_PAT_HEPATITE
        public string get_PAT_DST()
        {
            return PAT_DST;
        }

        public void set_PAT_DST(string PAT_DST)
        {
            this.PAT_DST = PAT_DST;
        }

        //
        //get_PAT_TEMPO_F
        public string get_PAT_TEMPO_F()
        {
            return PAT_TEMPO_F;
        }

        public void set_PAT_TEMPO_F(string PAT_TEMPO_F)
        {
            this.PAT_TEMPO_F = PAT_TEMPO_F;
        }

        //get_PAT_QUAL_A
        public string get_PAT_QUAL_A()
        {
            return PAT_QUAL_A;
        }

        public void set_PAT_QUAL_A(string PAT_QUAL_A)
        {
            this.PAT_QUAL_A = PAT_QUAL_A;
        }

        //get_PAT_QUAL_AL
        public string get_PAT_QUAL_AL()
        {
            return PAT_QUAL_AL;
        }

        public void set_PAT_QUAL_AL(string PAT_QUAL_AL)
        {
            this.PAT_QUAL_AL = PAT_QUAL_AL;
        }

        //get_PAT_QUAL_R
        public string get_PAT_QUAL_R()
        {
            return PAT_QUAL_R;
        }

        public void set_PAT_QUAL_R(string PAT_QUAL_R)
        {
            this.PAT_QUAL_R = PAT_QUAL_R;
        }

        //get_PAT_QUAL_D
        public string get_PAT_QUAL_D()
        {
            return PAT_QUAL_D;
        }

        public void set_PAT_QUAL_D(string PAT_QUAL_D)
        {
            this.PAT_QUAL_D = PAT_QUAL_D;
        }

        //get_PAT_QUAL_DI
        public string get_PAT_QUAL_DI()
        {
            return PAT_QUAL_DI;
        }

        public void set_PAT_QUAL_DI(string PAT_QUAL_DI)
        {
            this.PAT_QUAL_DI = PAT_QUAL_DI;
        }

        //get_PAT_QUANTO_CO
        public string get_PAT_QUANTO_CO()
        {
            return PAT_QUANTO_CO;
        }

        public void set_PAT_QUANTO_CO(string PAT_QUANTO_CO)
        {
            this.PAT_QUANTO_CO = PAT_QUANTO_CO;
        }

        //get_PAT_QUAL_CAR
        public string get_PAT_QUAL_CAR()
        {
            return PAT_QUAL_CAR;
        }

        public void set_PAT_QUAL_CAR(string PAT_QUAL_CAR)
        {
            this.PAT_QUAL_CAR = PAT_QUAL_CAR;
        }

        //get_PAT_QUANDO_AVC
        public string get_PAT_QUANDO_AVC()
        {
            return PAT_QUANDO_AVC;
        }

        public void set_PAT_QUANDO_AVC(string PAT_QUANDO_AVC)
        {
            this.PAT_QUANDO_AVC = PAT_QUANDO_AVC;
        }

        //get_PAT_TIPO_RIN
        public string get_PAT_TIPO_RIN()
        {
            return PAT_TIPO_RIN;
        }

        public void set_PAT_TIPO_RIN(string PAT_TIPO_RIN)
        {
            this.PAT_TIPO_RIN = PAT_TIPO_RIN;
        }

        //get_PAT_QUAL_RES
        public string get_PAT_QUAL_RES()
        {
            return PAT_QUAL_RES;
        }

        public void set_PAT_QUAL_RES(string PAT_QUAL_RES)
        {
            this.PAT_QUAL_RES = PAT_QUAL_RES;
        }

        //get_PAT_POR_IN
        public string get_PAT_POR_IN()
        {
            return PAT_POR_IN;
        }

        public void set_PAT_POR_IN(string PAT_POR_IN)
        {
            this.PAT_POR_IN = PAT_POR_IN;
        }

        //get_PAT_QUAL_CA
        public string get_PAT_QUAL_CA()
        {
            return PAT_QUAL_CA;
        }

        public void set_PAT_QUAL_CA(string PAT_QUAL_CA)
        {
            this.PAT_QUAL_CA = PAT_QUAL_CA;
        }

        //get_PAT_QUAL_HE
        public string get_PAT_QUAL_HE()
        {
            return PAT_QUAL_HE;
        }

        public void set_PAT_QUAL_HE(string PAT_QUAL_HE)
        {
            this.PAT_QUAL_HE = PAT_QUAL_HE;
        }

        //get_PAT_QUAL_DE
        public string get_PAT_QUAL_DE()
        {
            return PAT_QUAL_DE;
        }

        public void set_PAT_QUAL_DE(string PAT_QUAL_DE)
        {
            this.PAT_QUAL_DE = PAT_QUAL_DE;
        }

        //get_PAT_QUAL_HEPATITE
        public string get_PAT_QUAL_HEP()
        {
            return PAT_QUAL_HEP;
        }

        public void set_PAT_QUAL_HEP(string PAT_QUAL_HEP)
        {
            this.PAT_QUAL_HEP = PAT_QUAL_HEP;
        }

        //get_PAT_DST
        public string get_PAT_QUAL_DST()
        {
            return PAT_QUAL_DST;
        }

        public void set_PAT_QUAL_DST(string PAT_QUAL_DST)
        {
            this.PAT_QUAL_DST = PAT_QUAL_DST;
        }
        //get_Nome_medico
        public string get_Nome_medico()
        {
            return Nome_medico;
        }

        public void set_Nome_medico(string Nome_medico)
        {
            this.Nome_medico = Nome_medico;
        }

        //get_PAT_motivo
        public string get_PAT_motivo()
        {
            return PAT_motivo;
        }

        public void set_PAT_motivo(string PAT_motivo)
        {
            this.PAT_motivo = PAT_motivo;
        }

        //get_PAT_local_tratamento
        public string get_PAT_local_tratamento()
        {
            return PAT_local_tratamento;
        }

        public void set_PAT_local_tratamento(string PAT_local_tratamento)
        {
            this.PAT_local_tratamento = PAT_local_tratamento;
        }

        //get_PAT_intervercoes_cirurgica
        public string get_PAT_intervercoes_cirurgica()
        {
            return PAT_intervercoes_cirurgica;
        }

        public void set_PAT_intervercoes_cirurgica(string PAT_intervercoes_cirurgica)
        {
            this.PAT_intervercoes_cirurgica = PAT_intervercoes_cirurgica;
        }

        //get_PAT_observacao
        public string get_PAT_observacao()
        {
            return PAT_observacao;
        }

        public void set_PAT_observacao(string PAT_observacao)
        {
            this.PAT_observacao = PAT_observacao;
        }
        //Fim_pat_observaçao
        // Fim Cadastrar.



        // Começo Consultar.

        //Pesquisa por nome.
        public void consultar_cliente_Nome(DataGridView dataGridView1, string busca)
        {
            con = banco.abrir_conexao();
            string selecionar = @"SELECT ID_paciente,Nome,CPF,Data_nascimento, Nome_da_mae, Nome_do_pai, referencia_familiar, Telefone_contato, Telefone_celular, Endereco, Cidade, Bairro, CEP  FROM Paciente where Nome collate Latin1_General_CI_AI like '%" + busca + "%'";
            SqlDataAdapter a = new SqlDataAdapter(selecionar, con);
            DataTable t = new DataTable();
            a.Fill(t);
            dataGridView1.DataSource = t;
            con.Close();
        }

        //Pesquisa por CPF.
        public void consultar_cliente_CPF(DataGridView dataGridView1, string busca)
        {
            con = banco.abrir_conexao();
            string selecionar = @"SELECT ID_paciente,Nome,CPF,Data_nascimento, Nome_da_mae, Nome_do_pai, referencia_familiar, Telefone_contato, Telefone_celular, Endereco, Cidade, Bairro, CEP FROM Paciente where CPF like '%" + busca + "%'";
            SqlDataAdapter a = new SqlDataAdapter(selecionar, con);
            DataTable t = new DataTable();
            a.Fill(t);
            dataGridView1.DataSource = t;
            con.Close();
        }

        public DataTable consultar_cliente_id_cliente(string busca)
        {
            con = banco.abrir_conexao();
            string selecionar = @"SELECT * FROM Paciente where Id_paciente = '" + busca + "'";
            SqlDataAdapter a = new SqlDataAdapter(selecionar, con);
            DataTable t = new DataTable();
            a.Fill(t);
            con.Close();
            return t;
        }

        public void consultar_antecedentes_criminais(DataGridView dataGridView1, string busca)
        {
            con = banco.abrir_conexao();
            string selecionar = @"SELECT Id_criminal,Id_paciente, local, classe, foro, situacao, processo, data_julgamento, auto_prisao FROM criminal where id_paciente like '%" + busca + "%'";
            SqlDataAdapter a = new SqlDataAdapter(selecionar, con);
            DataTable t = new DataTable();
            a.Fill(t);
            dataGridView1.DataSource = t;
            con.Close();
        }

        // Fim Consultar.

        // Botão Excluir.

        public void excluir_cliente(string busca, DataGridView dataGridView1, string campo_busca)
        {
            con = banco.abrir_conexao();
            // comando SQL para inserir - Insert Into
            string deletar = @"DELETE FROM Paciente WHERE Id_paciente='" + busca + "'";

            // inicializa o comando e a conexão

            SqlCommand _cmd = new SqlCommand(deletar, con);
            // executa o comando

            DialogResult dialogResult = MessageBox.Show("Deseja mesmo deletar? ",
                "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                _cmd.ExecuteNonQuery();
                //  atualizar_datagrid(dataGridView1, campo_busca);
                MessageBox.Show("Excluido");
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

            con.Close();
        }


        public void editar_paciente(string id)
        {
            con = banco.abrir_conexao();
            string inserir2 = @"update Paciente Set Nome = '" + Nome + "',Apelido = '" + Apelido + "',Data_nascimento = '" + Data_Nascimento + "',Sexo= '" + Sexo + "',CPF = '" + CPF + "',RG = '" + RG + "',Cidade = '" + Cidade + "', Cidade_Natal= '" + Cidade_Natal + "', Endereco = '" + Endereco + "', Bairro = '" + Bairro + "', Complemento = '" + Complemento + "', CEP = '" + CEP + "', Telefone = '" + Telefone + "', Telefone_celular = '" + Telefone_celular + "', E_mail = '" + E_mail + "', Nome_da_Mae = '" + Nome_da_Mae + "', Nome_do_Pai = '" + Nome_do_Pai + "', Telefone_Contato = '" + telefone_contato + "',Estado_Civil = '" + Estado_Civil + "', Orgao_Expedicao = '" + Orgao_Expedicao + "', data_expedicao = '" + Data_Expedicao + "', pais = '" + Pais + "',referencia_familiar = '" + Referencia_Familiar + "', UF = '" + UF + "', UF_Naturalidade = '" + UF_Naturalidade + "', UF_Contato = '" + UF_Contato + "', Observacao_pessoal = '" + Observacao_pessoal + "', Febre_Amarela1 = '" + Febre_Amarela1 + "', Febre_Amarela2 = '" + Febre_Amarela2 + "', Febre_Amarela3 = '" + Febre_Amarela3 + "', Febre_Amarela_Unica = '" + Febre_Amarela_Unica + "', HepatiteB_1 = '" + HepatiteB_1 + "', HepatiteB_2 = '" + HepatiteB_2 + "', HepatiteB_3 = '" + HepatiteB_3 + "', HepatiteB_Unica = '" + HepatiteB_Unica + "', Influenza_1 = '" + Influenza_1 + "', Influenza_2 = '" + Influenza_2 + "', Influenza_3 = '" + Influenza_3 + "', Influenza_Unica = '" + Influenza_Unica + "', Poliomelite_1 = '" + Poliomelite_1 + "', Poliomelite_2 = '" + Poliomelite_2 + "', Poliomelite_3 = '" + Poliomelite_3 + "', Poliomelite_Unica = '" + Poliomelite_Unica + "', Pneumococica_10_Valente_1 = '" + Pneumococica_10_Valente_1 + "', Pneumococica_10_Valente_2 = '" + Pneumococica_10_Valente_2 + "', Pneumococica_10_Valente_3 = '" + Pneumococica_10_Valente_3 + "', Pneumococica_10_Valente_Unica = '" + Pneumococica_10_Valente_Unica + "', Pneumococica_23_Valente_1 = '" + Pneumococica_23_Valente_1 + "', Pneumococica_23_Valente_2 = '" + Pneumococica_23_Valente_2 + "', Pneumococica_23_Valente_3 = '" + Pneumococica_23_Valente_3 + "', Pneumococica_23_Valente_Unica = '" + Pneumococica_23_Valente_Unica + "', Tetraviral_1 = '" + Tetraviral_1 + "', Tetraviral_2 = '" + Tetraviral_2 + "', Tetraviral_3 = '" + Tetraviral_3 + "', Tetraviral_Unica = '" + Tetraviral_Unica + "', Triplice_Bacteriana_1 = '" + Triplice_Bacteriana_1 + "', Triplice_Bacteriana_2 = '" + Triplice_Bacteriana_2 + "', Triplice_Bacteriana_3 = '" + Triplice_Bacteriana_3 + "', Triplice_Bacteriana_Unica = '" + Triplice_Bacteriana_Unica + "', Triplice_Viral_1 = '" + Triplice_Viral_1 + "', Triplice_Viral_2 = '" + Triplice_Viral_2 + "', Triplice_Viral_3 = '" + Triplice_Viral_3 + "', Triplice_Viral_Unica = '" + Triplice_Viral_Unica + "', Vacina_DT_difteria_e_tetano_1 = '" + Vacina_DT_difteria_e_tetano_1 + "', Vacina_DT_difteria_e_tetano_2 = '" + Vacina_DT_difteria_e_tetano_2 + "', Vacina_DT_difteria_e_tetano_3 = '" + Vacina_DT_difteria_e_tetano_3 + "', Vacina_DT_difteria_e_tetano_Unica = '" + Vacina_DT_difteria_e_tetano_Unica + "', Vacina_Menigocica_C_1 = '" + Vacina_Menigocica_C_1 + "', Vacina_Menigocica_C_2 = '" + Vacina_Menigocica_C_2 + "', Vacina_Menigocica_C_3 = '" + Vacina_Menigocica_C_3 + "', Vacina_Menigocica_C_Unica = '" + Vacina_Menigocica_C_Unica + "', Vacina_Oral_Rotavirus_Humano_1 = '" + Vacina_Oral_Rotavirus_Humano_1 + "', Vacina_Oral_Rotavirus_Humano_2 = '" + Vacina_Oral_Rotavirus_Humano_2 + "', Vacina_Oral_Rotavirus_Humano_3 = '" + Vacina_Oral_Rotavirus_Humano_3 + "', Vacina_Oral_Rotavirus_Humano_Unica = '" + Vacina_Oral_Rotavirus_Humano_Unica + "', SOC_ESCOLARIDADE = '" + SOC_ESCOLARIDADE + "', SOC_ESTUDO = '" + SOC_ESTUDO + "', SOC_FEZCURSO = '" + SOC_FEZCURSO + "', SOC_CURSO = '" + SOC_CURSO + "', SOC_TRABALHO = '" + SOC_TRABALHO + "', SOC_PROFISSAO = '" + SOC_PROFISSAO + "', SOC_FILHOS = '" + SOC_FILHOS + "', SOC_RESPONSAVEL = '" + SOC_RESPONSAVEL + "', SOC_RUA = '" + SOC_RUA + "', SOC_TEMPO = '" + SOC_TEMPO + "', SOC_INSTITUICAO = '" + SOC_INSTITUICAO + "', SOC_NOMEINSTITUICAO = '" + SOC_NOMEINSTITUICAO + "', SOC_FAMILIAR = '" + SOC_FAMILIAR + "', SOC_PARENTESCO = '" + SOC_PARENTESCO + "', SOC_ADICIONAIS = '" + SOC_ADICIONAIS + "', PAT_FUMANTE = '" + PAT_FUMANTE + "', PAT_ALERGIA = '" + PAT_ALERGIA + "', PAT_ALCOOL = '" + PAT_ALCOOL + "', PAT_REMEDIO = '" + PAT_REMEDIO + "', PAT_DROGA = '" + PAT_DROGA + "', PAT_DIABETES = '" + PAT_DIABETES + "', PAT_COLESTEROL = '" + PAT_COLESTEROL + "', PAT_CARDIACO = '" + PAT_CARDIACO + "', PAT_AVC = '" + PAT_AVC + "', PAT_RINS = '" + PAT_RINS + "', PAT_RESPIRATORIO = '" + PAT_RESPIRATORIO + "', PAT_INTERNACAO = '" + PAT_INTERNACAO + "', PAT_CANCER = '" + PAT_CANCER + "', PAT_HEREDITARIA = '" + PAT_HEREDITARIA + "', PAT_DEFICIENCIA = '" + PAT_DEFICIENCIA + "', PAT_TEMPO_F = '" + PAT_TEMPO_F + "', PAT_QUAL_A = '" + PAT_QUAL_A + "', PAT_QUAL_AL = '" + PAT_QUAL_AL + "', PAT_QUAL_R = '" + PAT_QUAL_R + "', PAT_QUAL_D = '" + PAT_QUAL_D + "', PAT_QUAL_DI = '" + PAT_QUAL_DI + "', PAT_QUANTO_CO = '" + PAT_QUANTO_CO + "', PAT_QUAL_CAR = '" + PAT_QUAL_CAR + "', PAT_QUANDO_AVC = '" + PAT_QUANDO_AVC + "', PAT_TIPO_RIN = '" + PAT_TIPO_RIN + "', PAT_QUAL_RES = '" + PAT_QUAL_RES + "', PAT_POR_IN = '" + PAT_POR_IN + "', PAT_QUAL_CA = '" + PAT_QUAL_CA + "', PAT_QUAL_HE = '" + PAT_QUAL_HE + "' , PAT_QUAL_DE = '" + PAT_QUAL_DE + "', Nome_medico = '" + Nome_medico + "', PAT_motivo = '" + PAT_motivo + "', PAT_local_tratamento = '" + PAT_local_tratamento + "', PAT_intervercoes_cirurgica = '" + PAT_intervercoes_cirurgica + "', PAT_observacao = '" + PAT_observacao + "'   where Id_paciente = '" + id + "';";//atualiza o editar
            SqlCommand _cmd = new SqlCommand(inserir2, con);
            _cmd.ExecuteNonQuery();
            con.Close();


        }
        public void editar_criminal(string id_criminal)
        {
            con = banco.abrir_conexao();
            string inserir1 = @"update criminal Set Local ='" + Local + "', classe = '" + classe + "', foro = '" + foro + "', situacao = '" + situacao + "', processo = '" + processo + "', data_julgamento = '" + data_julgamento + "', auto_prisao = '" + auto_prisao + "' where Id_criminal = '" + id_criminal + "';";
            SqlCommand _cmd2 = new SqlCommand(inserir1, con);
            _cmd2.ExecuteNonQuery();

            //do something

            con.Close();

        }



        // Fim Excluir
    }
}
