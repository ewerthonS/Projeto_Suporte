using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferenciaDados;

namespace SAU
{
    public partial class frmLogin : Form
    {
        //Declaração de variáveis
        public bool LoginSucesso = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mskRepetirSenha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            pnlMudarSenha.Location = new Point(548, 24);
        }

        private void lblmsgEmail_Click(object sender, EventArgs e)
        {

        }

        private void mskSenha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Size = new Size(400, 332);
            this.Location = new Point(360, 400);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do aplicativo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //Efetuar a verificação dos campos Usuário e senha
            //Verificar se o campo txtusuario está preenchido

            if(txtEmailUsuario.Text == String.Empty)
            {
                MessageBox.Show("Favor informar o usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmailUsuario.Focus();
            }

            else if (mskSenha.Text == String.Empty)
            {
                MessageBox.Show("Favor digitar a senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskSenha.Focus();
            }
            else
            {
                //Instanciar as classes
                ValidarUsuario validarUsuario = new ValidarUsuario();
                UsuariosDTO dados = new UsuariosDTO();

                //Popular a classe
                dados.nomeusuario = txtEmailUsuario.Text;
                dados.senhausuario = mskSenha.Text;

                //Chamar o método
                validarUsuario.VerificarUsuario(dados);

                if(dados.mensagens != null)
                {
                    MessageBox.Show(dados.mensagens);
                }
                else
                {
                    switch (dados.logado)
                    {
                        case 0: MessageBox.Show("Usuário ou senha incorretos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            //Limpar os campos e posicionar o cursor no nome do usuário
                            txtEmailUsuario.Clear();
                            mskSenha.Clear();

                            txtEmailUsuario.Focus();

                            LoginSucesso = false;
                            break;

                        case 1: LoginSucesso = true;
                            MessageBox.Show("Bem-vindo ao Sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            //Limpar os campos
                            txtEmailUsuario.Clear();
                            mskSenha.Clear();

                            if(LoginSucesso == true)
                            {
                                Close();
                            }
                            break;

                        case 2:
                            MessageBox.Show("Usuário já conectado!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            //Limpar os campos e posicionar o cursor no nome do usuário
                            txtEmailUsuario.Clear();
                            mskSenha.Clear();

                            txtEmailUsuario.Focus();

                            LoginSucesso = false;

                            break;


                        case 3:
                            MessageBox.Show("Seu primeiro acesso" + " Será necessário alterar a senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            pnlMudarSenha.Location = new Point(360, 400);
                            mskSenhaAtual.Focus();
                            break;

                        case 4:
                            MessageBox.Show(" Verifique o ocorrido" + " Junto ao Administrador do Sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }

                }
            }   
            //Fechamento else

        }

        private void txtEmailUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
