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
    public partial class frmContatos : Form
    {
        public frmContatos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblendereco_Click(object sender, EventArgs e)
        {

        }

        private void txtendereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Rotina para limpar os controles
            txtNome.Clear();
            txtEndereco.Clear();
            txtCodigo.Clear();
            txtNumeroEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtUf.Clear();
            mskCep.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();


            // Posicionar o cursor
            txtNome.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Rotinar para sair do form
            // Enviar mensagem

            if (MessageBox.Show("Deseja sair do aplicativo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblBairro_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void txtUf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumeroEndereco_TextChanged(object sender, EventArgs e)
        {

        }


        private void lblCidade_Click(object sender, EventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTelefone_Click(object sender, EventArgs e)
        {

        }

        private void frmContatos_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Instanciar as classes
            SalvarContatos salvarContatos = new SalvarContatos();
            ContatosDTO dados = new ContatosDTO();



            //validar se os campos estão preenchidos
            //Definir vaiável para receber o nome do textbox
            TextBox textBox = new TextBox();
            //Variável para indicar o textbox que irá receber o focus/msg
            bool finalizar = false;

            //Criar uma consulta LINQ
            var controle = from crtl in this.Controls.OfType<TextBox>()
                           where crtl.Name != "txtCodigo"
                           orderby crtl.TabIndex
                           select crtl;

            //Percorrer a consulta e verificar quais os campos não foram preenchidos

            foreach (var crtlTxt in controle)
            {
                if (crtlTxt.Text == string.Empty)
                {
                    finalizar = true;
                    textBox.Name = crtlTxt.Name;
                    crtlTxt.Focus();
                    break;
                }
            }


            minimoCaracteres(null, null);

            //Remover a máscara do CEP - formatação
            //Verificar se os campos uf e telefone estão vazios
            if (txtUf.Text != string.Empty && txtTelefone.Text == String.Empty)
            {
                mskCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                if (mskCep.Text == string.Empty)
                {
                    MessageBox.Show("Favor informar o CEP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mskCep.Focus();
                    finalizar = true;
                }
                else
                {
                    mskCep.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                }
            }

            //Apresentar msg para preencher o campo
            if (finalizar == true && mskCep.Text != String.Empty)
            {
                MessageBox.Show("Favor preencher o campo" + textBox.Name.Substring(3,textBox.Name.Length-3), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   
                
            }
            
            if (finalizar == false)
            {

                /*  foreach (Control verificar in this.Controls)
                  {
                      if (verificar is TextBox)
                      {
                          ((TextBox)verificar).Text = String.Empty;
                          verificar.Focus();
                          MessageBox.Show("Favor preencher os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                      }

                  }
                */


                //Popular a classe
                dados.nome = txtNome.Text;
                dados.endereco = txtEndereco.Text;
                dados.numero = Convert.ToInt32(txtNumeroEndereco.Text);
                dados.bairro = txtBairro.Text;
                dados.cidade = txtCidade.Text;
                dados.uf = txtUf.Text;
                dados.cep = mskCep.Text;
                dados.telefone = txtTelefone.Text;
                dados.email = txtEmail.Text;


                //Chamar o método
                salvarContatos.ContatosIncluir(dados);
                //Verificar o resultado
                if (dados.codigo != 0)
                {
                    //Popular o campo código
                    txtCodigo.Text = dados.codigo.ToString();
                    MessageBox.Show("Cadastro realizado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Desabilitar(null, null);

                }
                else
                {
                    MessageBox.Show("Não foi possível realizar o cadastro " + dados.mensagens, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }

     

        private void btnFechar_Click(object sender, EventArgs e)
        {

           // btnSalvar.Text = "Novo";
           // grpContatos.Visible = false;

            // Rotina para limpar os controles
            /*
            txtNome.Clear();
            txtEndereco.Clear();
            txtCodigo.Clear();
            txtNumeroEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtUf.Clear();
            mskCep.Clear();
            txtTelefone.Clear();
            txtEmail.Clear(); */
            
            // Tornar invisível o grpContatos
            grpContatos.Visible = false;

            // Habilitar os controlers abaixo
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            mskCep.Enabled = true;
            txtTelefone.Enabled = true;
            txtUf.Enabled = true;
            txtNumeroEndereco.Enabled = true;
            txtEmail.Enabled = true;
            btnSalvar.Enabled = true;
            btnListar.Enabled = true;
            btnLimpar.Enabled = true;
            btnSair.Enabled = true;

            // Posicionar o cursor
            txtNome.Focus();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {


            //Instanciar as classes DTO
            ConsultarContatos consultarContatos = new ConsultarContatos();
            ContatosDTO dados = new ContatosDTO();

            //Chamar método para consulta 
            consultarContatos.MostrarContatos(dados);


            //Limpar fonte de dados e a Lista
            lstContatos.DataSource = null;
            lstContatos.Items.Clear();

            //Popular listbox 
            //Apenas o nome será vísivel, o código não
            lstContatos.ValueMember = "codContato";
            lstContatos.DisplayMember = "nomedoContato";
            lstContatos.DataSource = consultarContatos.ContatosDataTable;

            // Tornar visível o grpContatos
            grpContatos.Visible = true;

            // Desabilitar os controlers abaixo
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            mskCep.Enabled = false;
            txtTelefone.Enabled = false;
            txtUf.Enabled = false;
            txtNumeroEndereco.Enabled = false;
            txtEmail.Enabled = false;
            btnSalvar.Enabled = false;
            btnListar.Enabled = false;
            btnLimpar.Enabled = false;
            btnSair.Enabled = false;

            //Exibir os dados que foram preenchidos
            // lstContatos.Items.Clear();
          //  lstContatos.Items.Add(txtNome.Text);



        }

        private void txtNumeroEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
                // Verifica se não estão sendo utilizados números
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // If you want, you can allow decimal (float) numbers
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            
        }

        private void grpContatos_Enter(object sender, EventArgs e)
        {

        }

        public void Desabilitar(object sender, EventArgs e)
        {
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            mskCep.Enabled = false;
            txtTelefone.Enabled = false;
            txtUf.Enabled = false;
            txtNumeroEndereco.Enabled = false;
            txtEmail.Enabled = false;
            btnSalvar.Enabled = false;
            btnListar.Enabled = false;
            btnLimpar.Enabled = false;
            //btnLimpar_Click(null, null);

        }


        public void minimoCaracteres(object sender, EventArgs e)
        {
            //Verificar o mínimo de caracteres digitados 
            if (txtNome.Text.Length < 5)
            {
                MessageBox.Show("O nome do contato deve possuir mais que 5 caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
            }
          else if (txtEndereco.Text.Length < 5)
            {
                MessageBox.Show("O nome do endereço deve possuir mais que 5 caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEndereco.Focus();
            }

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {  

        }

        private void lstContatos_Click(object sender, EventArgs e)
        {
            //Extrair o código do contato selecionado
            DataRowView drv = (DataRowView)lstContatos.Items[lstContatos.SelectedIndex];

            //Instanciar as classes DTO
            ConsultarContatos consultarContatos = new ConsultarContatos();
            ContatosDTO dados = new ContatosDTO();

            //Chamar método para consulta
            consultarContatos.MostrarContatos(dados);

            //Percorrer o DataTable para localizar os dados do contato selecionado
            for (int i = 0; i < consultarContatos.ContatosDataTable.Rows.Count; i++)
            {
                if(drv["codContato"].ToString() == consultarContatos.ContatosDataTable.Rows[i]["codContato"].ToString())
                {
                    txtCodigo.Text = consultarContatos.ContatosDataTable.Rows[i]["codContato"].ToString();
                    txtNome.Text = consultarContatos.ContatosDataTable.Rows[i]["nomedoContato"].ToString();
                    txtEndereco.Text = consultarContatos.ContatosDataTable.Rows[i]["enderecoContato"].ToString();
                    txtTelefone.Text = consultarContatos.ContatosDataTable.Rows[i]["telefoneContato"].ToString();
                    txtBairro.Text = consultarContatos.ContatosDataTable.Rows[i]["bairro"].ToString();
                    txtCidade.Text = consultarContatos.ContatosDataTable.Rows[i]["cidade"].ToString();
                    txtUf.Text = consultarContatos.ContatosDataTable.Rows[i]["uf"].ToString();
                    mskCep.Text = consultarContatos.ContatosDataTable.Rows[i]["cep"].ToString();
                    txtEmail.Text = consultarContatos.ContatosDataTable.Rows[i]["emailContato"].ToString();

                    btnFechar_Click(null, null);
                }
            }
        }

        private void lstContatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
