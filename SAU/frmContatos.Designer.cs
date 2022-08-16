
namespace SAU
{
    partial class frmContatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnome = new System.Windows.Forms.Label();
            this.lblendereco = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNumeroEndereco = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNumeroEndereco = new System.Windows.Forms.TextBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(103, 93);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(89, 13);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome do contato";
            this.lblnome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblendereco
            // 
            this.lblendereco.AutoSize = true;
            this.lblendereco.Location = new System.Drawing.Point(103, 119);
            this.lblendereco.Name = "lblendereco";
            this.lblendereco.Size = new System.Drawing.Size(53, 13);
            this.lblendereco.TabIndex = 1;
            this.lblendereco.Text = "Endereço";
            this.lblendereco.Click += new System.EventHandler(this.lblendereco_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(198, 90);
            this.txtNome.MaxLength = 10;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(379, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(198, 116);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(379, 20);
            this.txtEndereco.TabIndex = 1;
            this.txtEndereco.TextChanged += new System.EventHandler(this.txtendereco_TextChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSalvar.Location = new System.Drawing.Point(611, 84);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 30);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnListar
            // 
            this.btnListar.ForeColor = System.Drawing.Color.Blue;
            this.btnListar.Location = new System.Drawing.Point(611, 128);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(80, 30);
            this.btnListar.TabIndex = 10;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.ForeColor = System.Drawing.Color.Orange;
            this.btnLimpar.Location = new System.Drawing.Point(611, 171);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(80, 30);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(611, 211);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(80, 30);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(103, 67);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(95, 13);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Código do Contato";
            this.lblCodigo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblNumeroEndereco
            // 
            this.lblNumeroEndereco.AutoSize = true;
            this.lblNumeroEndereco.Location = new System.Drawing.Point(452, 148);
            this.lblNumeroEndereco.Name = "lblNumeroEndereco";
            this.lblNumeroEndereco.Size = new System.Drawing.Size(19, 13);
            this.lblNumeroEndereco.TabIndex = 7;
            this.lblNumeroEndereco.Text = "Nº";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(103, 145);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 8;
            this.lblBairro.Text = "Bairro";
            this.lblBairro.Click += new System.EventHandler(this.lblBairro_Click);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(103, 171);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 9;
            this.lblCidade.Text = "Cidade";
            this.lblCidade.Click += new System.EventHandler(this.lblCidade_Click);
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(450, 174);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(21, 13);
            this.lblUf.TabIndex = 10;
            this.lblUf.Text = "UF";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(103, 197);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(28, 13);
            this.lblCep.TabIndex = 11;
            this.lblCep.Text = "CEP";
            this.lblCep.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(103, 224);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 12;
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.Click += new System.EventHandler(this.lblTelefone_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(368, 227);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "E-mail";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(198, 141);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(243, 20);
            this.txtBairro.TabIndex = 2;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(198, 168);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(243, 20);
            this.txtCidade.TabIndex = 4;
            this.txtCidade.TextChanged += new System.EventHandler(this.txtCidade_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(198, 64);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 16;
            // 
            // txtNumeroEndereco
            // 
            this.txtNumeroEndereco.Location = new System.Drawing.Point(477, 145);
            this.txtNumeroEndereco.Name = "txtNumeroEndereco";
            this.txtNumeroEndereco.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroEndereco.TabIndex = 3;
            this.txtNumeroEndereco.TextChanged += new System.EventHandler(this.txtNumeroEndereco_TextChanged);
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(477, 171);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(100, 20);
            this.txtUf.TabIndex = 5;
            this.txtUf.TextChanged += new System.EventHandler(this.txtUf_TextChanged);
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(198, 194);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 20);
            this.txtCep.TabIndex = 6;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(198, 224);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(164, 20);
            this.txtTelefone.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(409, 221);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(168, 20);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // frmContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 355);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.txtNumeroEndereco);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblNumeroEndereco);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblendereco);
            this.Controls.Add(this.lblnome);
            this.Name = "frmContatos";
            this.Text = "Cadastro de Contatos";
            this.Load += new System.EventHandler(this.frmContatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblendereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNumeroEndereco;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNumeroEndereco;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
    }
}