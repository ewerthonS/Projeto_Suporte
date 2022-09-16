using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador_QT3___Sistema_Farmacêutico
{
    public partial class frmLogin : Form
    {

        //Declaração de variáveis
        public bool LoginSucesso = false;

        public frmLogin()
        {
            InitializeComponent();
        }


        private void FecharTodos()
        {
            try
            {
                foreach (Form childForm in Application.OpenForms)
                {
                    if (childForm.Name != this.Name)
                    {
                        childForm.Close();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            //Efetuar a verificação dos campos Usuário e senha
            //Verificar se o campo txtusuario está preenchido

            if (txtEmailUsuario.Text == String.Empty)
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

                if (dados.mensagens != null)
                {
                    MessageBox.Show(dados.mensagens);
                }
                else
                {
                    switch (dados.logado)
                    {
                        case 0:
                            MessageBox.Show("Usuário ou senha incorretos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            //Limpar os campos e posicionar o cursor no nome do usuário
                            txtEmailUsuario.Clear();
                            mskSenha.Clear();

                            txtEmailUsuario.Focus();

                            LoginSucesso = false;
                            break;

                        case 1:
                            LoginSucesso = true;
                            MessageBox.Show("Bem-vindo ao Sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            //Limpar os campos
                            txtEmailUsuario.Clear();
                            mskSenha.Clear();

                            if (LoginSucesso == true)
                            {
                                Close();
                            }
                            break;

                      
                  
                    }

                }
            }
            //Fechamento else








            if (txtUsuario.Text == String.Empty)
            {
                MessageBox.Show("Favor informar o usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
            }
            else if (mskSenha.Text == String.Empty)
            {
                MessageBox.Show("Favor digitar a senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskSenha.Focus();
            }
            else
            {
                FecharTodos();
                Form childForm = new frmPrincipal();
                childForm.Show();
            }
           

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
