using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAU
{
    public partial class frmIdade : Form
    {
       // string nomeUsuario;
        public frmIdade()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Declaração de variáveis
           string nomeUsuario;
           int idadeUsuario;

            //Verificar se os campos foram preenchidos
            //   if ((txtNome.Text != string.Empty) && (txtIdade.Text != string.Empty))
         
            if  (txtNome.Text == "")
            {
               MessageBox.Show("Favor preencher o nome", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
            }
            else if(txtIdade.Text ==""){
                MessageBox.Show("Favor preencher a idade", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdade.Focus();
            }
            else
            {
                // Atribuição das variáveis
                nomeUsuario = txtNome.Text;
                idadeUsuario = Convert.ToInt32(txtIdade.Text);

                // Apresentar o resultado das variáveis
                MessageBox.Show("Nome : " + nomeUsuario.ToString() + " e Idade " + idadeUsuario.ToString());
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
            //nomeUsuario = txtNome.Text;
            // Rotina para limpar os controles
            txtNome.Clear();
            txtIdade.Clear();


            // Posicionar o cursor no texbox
            txtNome.Focus();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdade_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
