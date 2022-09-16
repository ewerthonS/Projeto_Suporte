
namespace SAU
{
    partial class frmLogin
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
            this.lblEmailUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblSenhaAtual = new System.Windows.Forms.Label();
            this.lblNovaSenha = new System.Windows.Forms.Label();
            this.lblRepetirSenha = new System.Windows.Forms.Label();
            this.lblmsgEmail = new System.Windows.Forms.Label();
            this.pnlMudarSenha = new System.Windows.Forms.Panel();
            this.mskRepetirSenha = new System.Windows.Forms.MaskedTextBox();
            this.mskNovaSenha = new System.Windows.Forms.MaskedTextBox();
            this.mskSenhaAtual = new System.Windows.Forms.MaskedTextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtEmailUsuario = new System.Windows.Forms.TextBox();
            this.mskSenha = new System.Windows.Forms.MaskedTextBox();
            this.pnlMudarSenha.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmailUsuario
            // 
            this.lblEmailUsuario.AutoSize = true;
            this.lblEmailUsuario.Location = new System.Drawing.Point(76, 79);
            this.lblEmailUsuario.Name = "lblEmailUsuario";
            this.lblEmailUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblEmailUsuario.TabIndex = 0;
            this.lblEmailUsuario.Text = "E-mail";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(76, 149);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha";
            this.lblSenha.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSenhaAtual
            // 
            this.lblSenhaAtual.AutoSize = true;
            this.lblSenhaAtual.Location = new System.Drawing.Point(58, 19);
            this.lblSenhaAtual.Name = "lblSenhaAtual";
            this.lblSenhaAtual.Size = new System.Drawing.Size(65, 13);
            this.lblSenhaAtual.TabIndex = 2;
            this.lblSenhaAtual.Text = "Senha Atual";
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.AutoSize = true;
            this.lblNovaSenha.Location = new System.Drawing.Point(58, 58);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(67, 13);
            this.lblNovaSenha.TabIndex = 3;
            this.lblNovaSenha.Text = "Nova Senha";
            // 
            // lblRepetirSenha
            // 
            this.lblRepetirSenha.AutoSize = true;
            this.lblRepetirSenha.Location = new System.Drawing.Point(40, 97);
            this.lblRepetirSenha.Name = "lblRepetirSenha";
            this.lblRepetirSenha.Size = new System.Drawing.Size(116, 13);
            this.lblRepetirSenha.TabIndex = 4;
            this.lblRepetirSenha.Text = "Confirme a nova senha";
            this.lblRepetirSenha.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblmsgEmail
            // 
            this.lblmsgEmail.AutoSize = true;
            this.lblmsgEmail.Location = new System.Drawing.Point(76, 117);
            this.lblmsgEmail.Name = "lblmsgEmail";
            this.lblmsgEmail.Size = new System.Drawing.Size(154, 13);
            this.lblmsgEmail.TabIndex = 5;
            this.lblmsgEmail.Text = "O e-mail será o usuário de login";
            this.lblmsgEmail.Click += new System.EventHandler(this.lblmsgEmail_Click);
            // 
            // pnlMudarSenha
            // 
            this.pnlMudarSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMudarSenha.Controls.Add(this.mskRepetirSenha);
            this.pnlMudarSenha.Controls.Add(this.mskNovaSenha);
            this.pnlMudarSenha.Controls.Add(this.mskSenhaAtual);
            this.pnlMudarSenha.Controls.Add(this.btnAlterar);
            this.pnlMudarSenha.Controls.Add(this.lblSenhaAtual);
            this.pnlMudarSenha.Controls.Add(this.lblNovaSenha);
            this.pnlMudarSenha.Controls.Add(this.lblRepetirSenha);
            this.pnlMudarSenha.Location = new System.Drawing.Point(387, 59);
            this.pnlMudarSenha.Name = "pnlMudarSenha";
            this.pnlMudarSenha.Size = new System.Drawing.Size(213, 191);
            this.pnlMudarSenha.TabIndex = 6;
            // 
            // mskRepetirSenha
            // 
            this.mskRepetirSenha.Location = new System.Drawing.Point(24, 113);
            this.mskRepetirSenha.Name = "mskRepetirSenha";
            this.mskRepetirSenha.PasswordChar = '*';
            this.mskRepetirSenha.Size = new System.Drawing.Size(163, 20);
            this.mskRepetirSenha.TabIndex = 8;
            this.mskRepetirSenha.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskRepetirSenha_MaskInputRejected);
            // 
            // mskNovaSenha
            // 
            this.mskNovaSenha.Location = new System.Drawing.Point(24, 74);
            this.mskNovaSenha.Name = "mskNovaSenha";
            this.mskNovaSenha.PasswordChar = '*';
            this.mskNovaSenha.Size = new System.Drawing.Size(163, 20);
            this.mskNovaSenha.TabIndex = 7;
            // 
            // mskSenhaAtual
            // 
            this.mskSenhaAtual.Location = new System.Drawing.Point(24, 35);
            this.mskSenhaAtual.Name = "mskSenhaAtual";
            this.mskSenhaAtual.Size = new System.Drawing.Size(163, 20);
            this.mskSenhaAtual.TabIndex = 6;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(52, 139);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(95, 31);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(82, 189);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(92, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(199, 189);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(92, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtEmailUsuario
            // 
            this.txtEmailUsuario.Location = new System.Drawing.Point(79, 95);
            this.txtEmailUsuario.Name = "txtEmailUsuario";
            this.txtEmailUsuario.Size = new System.Drawing.Size(229, 20);
            this.txtEmailUsuario.TabIndex = 0;
            this.txtEmailUsuario.TextChanged += new System.EventHandler(this.txtEmailUsuario_TextChanged);
            // 
            // mskSenha
            // 
            this.mskSenha.Location = new System.Drawing.Point(79, 165);
            this.mskSenha.Name = "mskSenha";
            this.mskSenha.PasswordChar = '*';
            this.mskSenha.Size = new System.Drawing.Size(232, 20);
            this.mskSenha.TabIndex = 1;
            this.mskSenha.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskSenha_MaskInputRejected);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.lblEmailUsuario);
            this.Controls.Add(this.mskSenha);
            this.Controls.Add(this.pnlMudarSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtEmailUsuario);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblmsgEmail);
            this.Controls.Add(this.btnSair);
            this.Name = "frmLogin";
            this.Text = "Login Sistema";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlMudarSenha.ResumeLayout(false);
            this.pnlMudarSenha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmailUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblSenhaAtual;
        private System.Windows.Forms.Label lblNovaSenha;
        private System.Windows.Forms.Label lblRepetirSenha;
        private System.Windows.Forms.Label lblmsgEmail;
        private System.Windows.Forms.Panel pnlMudarSenha;
        private System.Windows.Forms.MaskedTextBox mskRepetirSenha;
        private System.Windows.Forms.MaskedTextBox mskNovaSenha;
        private System.Windows.Forms.MaskedTextBox mskSenhaAtual;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtEmailUsuario;
        private System.Windows.Forms.MaskedTextBox mskSenha;
    }
}