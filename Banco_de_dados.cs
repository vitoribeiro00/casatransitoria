using Projeto_casa_transitoria.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_casa_transitoria
{
    class Banco_de_dados
    {
        SqlConnection con;
        public SqlConnection abrir_conexao()
        {
            //string caminho = Path.GetFullPath("CasaTransitoria.mdf");
            con = new SqlConnection();
            //con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='" + caminho + "';Integrated Security=True;Connect Timeout=30";
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\CasaTransitoria.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True";

            con = new SqlConnection();
            con.ConnectionString = Settings.Default.stringConexaoNuvem;
            con.Open();


           // String path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            return con;

        }

       
        public void fechar_conexao(SqlConnection con)
        {
            con.Close();
        }
    }
}
