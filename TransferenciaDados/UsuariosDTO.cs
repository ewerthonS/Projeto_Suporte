using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Namespace para conexão e acesso ao banco de dados
using MySql.Data.MySqlClient;
using System.Data;
using AcessoBanco;


namespace TransferenciaDados
{
    public class UsuariosDTO
    {
        public String nomeusuario { get; set; }
        public String senhausuario { get; set; }
        public String emailusuario { get; set; }
        public int logado { get; set; }
        public String nomecompleto { get; set; }
        public String mensagens { get; set; }
        public String novasenha { get; set; }
        public int codperfil { get; set; }
        public byte[] foto { get; set; }

    }

    public class LoginSistema
    {
        public static string usuario { get; set; }
        public static string nomecompleto { get; set; }
        public static string codperfil { get; set; }

    }

    public class ValidarUsuario
    {
        public void VerificarUsuario(UsuariosDTO dados)
        {
            //Tratamento de exceções
            try
            {
                //Definir comando para execução
                MySqlCommand cmd = new MySqlCommand("spValidarUsuario", Conexao.obterConexao());
                //Definir como Stored Procedure
                cmd.CommandType = CommandType.StoredProcedure;

                //Parâmetros de entrada (input)
                cmd.Parameters.AddWithValue("@pNomeUsuario", dados.nomeusuario);
                cmd.Parameters.AddWithValue("@pSenhaUsuario", dados.senhausuario);

                //Executar is comandos SQL
                MySqlDataReader dr = cmd.ExecuteReader();
                //Verificar a existência de registros
                if (dr.HasRows)
                {
                    //Percorre os registros
                    while (dr.Read())
                    {
                        //Verificar o retorno do parâmetro resultado
                        int resultado = Convert.ToInt32(dr.GetValue(0).ToString());

                        if(resultado > 0)
                        {
                            //Popular com o resultado
                            LoginSistema.usuario = dados.nomeusuario;
                            LoginSistema.nomecompleto = dr.GetValue(2).ToString();
                            dados.logado = Convert.ToInt32(dr.GetValue(1).ToString());
                        }
                        else
                        {
                            dados.logado = resultado;
                        }
                       

                    }
                }
                dr.Close();

                //Fechar a conexão ao finalizar
                Conexao.fecharConexao();
            }
            catch (MySqlException e)
            {
                dados.mensagens = "Erro - ValidarUsuario - VerificarUsuario -" + e.Message.ToString();
            }
        }
        public void FinalizarAcesso(UsuariosDTO dados)
        {
            try
            {
                //Definir instruções SQL
                string sql = "update tbusuarios" +
                    "set logado = 1" +
                    "where nomeusuario = @usuario";

                //Definir comando para execução
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.obterConexao());

                //Definir como texto
                cmd.CommandType = CommandType.Text;

                //Popular o parâmetro
                cmd.Parameters.Add(new MySqlParameter("@usuario", dados.nomeusuario));

                //Executar os comandos SQL
                int registros = cmd.ExecuteNonQuery();

                if(registros >= 1)
                {
                    dados.mensagens = registros.ToString();
                }

                //Fechar a conexão
                Conexao.fecharConexao();


            }
            catch (MySqlException e)
            {
                dados.mensagens = "Erro - ValidarUsuario - FinalizarAcesso -" + e.Message.ToString();
            }
        }

    }

}
