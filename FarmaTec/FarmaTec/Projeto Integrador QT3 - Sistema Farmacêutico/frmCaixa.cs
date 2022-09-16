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
    public partial class frmCaixa : Form
    {
        public frmCaixa()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCaixa_Load(object sender, EventArgs e)
        {
            
        }

        private void btnIncluir_Click_1(object sender, EventArgs e)
        {

            if (txtNomeCliente.Text == String.Empty && txtNomeProduto.Text == String.Empty)
            {
                MessageBox.Show("Favor inserir o nome do Cliente e do Produto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeCliente.BackColor = Color.Red;
                txtNomeProduto.BackColor = Color.Red;
                txtNomeCliente.Focus();
            }
            else if (txtNomeCliente.Text == String.Empty)
            {
                MessageBox.Show("Favor inserir o nome do Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
               txtNomeCliente.BackColor = Color.Red;
               txtNomeProduto.BackColor = Color.Green;
               txtNomeCliente.Focus();
            }


            else if (txtNomeProduto.Text == String.Empty)
            {
                MessageBox.Show("Favor inserir o nome do Produto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeProduto.BackColor = Color.Red;
                txtNomeCliente.BackColor = Color.Green;
                txtNomeProduto.Focus();
            }

            else {
                txtNomeCliente.BackColor = Color.White;
                txtNomeProduto.BackColor = Color.White;
                txtNomeCliente.Enabled = false;
                txtNomeProduto.Clear();
                txtCodProduto.Clear();
                btnFinalizar.Enabled = true;
            }
         
        }

        private void grpProduto_Paint(object sender, PaintEventArgs e)
        {
          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da compra?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
    }

