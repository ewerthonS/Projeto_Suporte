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
            txtCep.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();


            // Posicionar o cursor
            txtNome.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Rotinar para sair do form
            // Enviar mensagem

            MessageBox.Show("Deseja sair do aplicativo?", "Aviso", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
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

        }
    }
}
