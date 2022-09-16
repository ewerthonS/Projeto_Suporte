
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Namespace para o MySQL
using MySql.Data;
using MySql.Data.MySqlClient;

//para retornar a string de conexão
using AcessoBanco.Properties;


namespace AcessoBanco
{
    public class Conexao
    {
        //Irá receber as mensagens do MySqlException
        public static string mensagem = string.Empty;

        //Criar Conexão
        private static string strConn = Settings.Default.strConexao;
        // representa a conexão com o banco
        private static MySqlConnection conn = null;
        // método que permite obter a conexão
        public static MySqlConnection obterConexao()
        {
            // vamos criar a conexão
            //Instanciar
            conn = new MySqlConnection(strConn);
            //Tratamento de exceções
            try
            {
                // abre a conexão e a devolve ao chamador do método
                conn.Open();
            }
            catch (MySqlException e)
            {
                // retorna a variável como nulo
                conn = null;
                // apresentar a mensagem de exceção
                //throw e;
                mensagem = e.Message.ToString();
            }
            return conn;
        }
        public static MySqlConnection fecharConexao()
        {
            // vamos criar a conexão
            //Instanciar
            conn = new MySqlConnection(strConn);
            //Tratamento de exceções
            try
            {
                conn.Close();
            }
            catch (MySqlException e)
            {
                // retorna a variável como nulo
                conn = null;
                // apresentar a mensagem de exceção
                //throw e;
                mensagem = e.Message.ToString();
            }
            return conn;
        }


    }
}
