
namespace Projeto_Integrador_QT3___Sistema_Farmacêutico
{
    partial class frmCaixa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaixa));
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.txtCodFuncionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpProduto = new System.Windows.Forms.GroupBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.dtPedido = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.nrPedido = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsPrecoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.grpCliente.SuspendLayout();
            this.grpProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomeCliente.Location = new System.Drawing.Point(119, 65);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(500, 29);
            this.txtNomeCliente.TabIndex = 0;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.AllowDrop = true;
            this.txtCodCliente.Enabled = false;
            this.txtCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCliente.Location = new System.Drawing.Point(6, 65);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(76, 29);
            this.txtCodCliente.TabIndex = 1;
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCliente.Location = new System.Drawing.Point(6, 42);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(63, 20);
            this.lblCodCliente.TabIndex = 3;
            this.lblCodCliente.Text = "Código:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(115, 42);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(130, 20);
            this.lblNomeCliente.TabIndex = 4;
            this.lblNomeCliente.Text = "Nome do Cliente:";
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.label3);
            this.grpCliente.Controls.Add(this.lblNomeCliente);
            this.grpCliente.Controls.Add(this.txtNomeFuncionario);
            this.grpCliente.Controls.Add(this.txtCodFuncionario);
            this.grpCliente.Controls.Add(this.label2);
            this.grpCliente.Controls.Add(this.lblCodCliente);
            this.grpCliente.Controls.Add(this.txtCodCliente);
            this.grpCliente.Controls.Add(this.txtNomeCliente);
            this.grpCliente.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCliente.Location = new System.Drawing.Point(29, 27);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(647, 203);
            this.grpCliente.TabIndex = 7;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Cliente/Funcionário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome do Funcionário";
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Enabled = false;
            this.txtNomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFuncionario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomeFuncionario.Location = new System.Drawing.Point(119, 139);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(500, 29);
            this.txtNomeFuncionario.TabIndex = 2;
            // 
            // txtCodFuncionario
            // 
            this.txtCodFuncionario.AllowDrop = true;
            this.txtCodFuncionario.Enabled = false;
            this.txtCodFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodFuncionario.Location = new System.Drawing.Point(6, 139);
            this.txtCodFuncionario.Name = "txtCodFuncionario";
            this.txtCodFuncionario.Size = new System.Drawing.Size(76, 29);
            this.txtCodFuncionario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código:";
            // 
            // grpProduto
            // 
            this.grpProduto.BackColor = System.Drawing.Color.Transparent;
            this.grpProduto.Controls.Add(this.btnIncluir);
            this.grpProduto.Controls.Add(this.dtPedido);
            this.grpProduto.Controls.Add(this.label1);
            this.grpProduto.Controls.Add(this.label6);
            this.grpProduto.Controls.Add(this.label4);
            this.grpProduto.Controls.Add(this.txtNomeProduto);
            this.grpProduto.Controls.Add(this.txtCodProduto);
            this.grpProduto.Controls.Add(this.txtPedido);
            this.grpProduto.Controls.Add(this.nrPedido);
            this.grpProduto.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProduto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpProduto.Location = new System.Drawing.Point(703, 27);
            this.grpProduto.Name = "grpProduto";
            this.grpProduto.Size = new System.Drawing.Size(647, 203);
            this.grpProduto.TabIndex = 8;
            this.grpProduto.TabStop = false;
            this.grpProduto.Text = "Produto";
            this.grpProduto.Paint += new System.Windows.Forms.PaintEventHandler(this.grpProduto_Paint);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Location = new System.Drawing.Point(534, 131);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(98, 37);
            this.btnIncluir.TabIndex = 3;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click_1);
            // 
            // dtPedido
            // 
            this.dtPedido.Enabled = false;
            this.dtPedido.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPedido.Location = new System.Drawing.Point(132, 140);
            this.dtPedido.Name = "dtPedido";
            this.dtPedido.Size = new System.Drawing.Size(313, 28);
            this.dtPedido.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Data do pedido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Código:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nome do Produto";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomeProduto.Location = new System.Drawing.Point(132, 65);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(500, 29);
            this.txtNomeProduto.TabIndex = 1;
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.AllowDrop = true;
            this.txtCodProduto.Enabled = false;
            this.txtCodProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProduto.Location = new System.Drawing.Point(19, 65);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(76, 29);
            this.txtCodProduto.TabIndex = 7;
            // 
            // txtPedido
            // 
            this.txtPedido.AllowDrop = true;
            this.txtPedido.Enabled = false;
            this.txtPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPedido.Location = new System.Drawing.Point(19, 139);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(76, 29);
            this.txtPedido.TabIndex = 6;
            // 
            // nrPedido
            // 
            this.nrPedido.AutoSize = true;
            this.nrPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrPedido.Location = new System.Drawing.Point(19, 112);
            this.nrPedido.Name = "nrPedido";
            this.nrPedido.Size = new System.Drawing.Size(58, 20);
            this.nrPedido.TabIndex = 10;
            this.nrPedido.Text = "Pedido";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dsCodigo,
            this.dsProduto,
            this.dsPreco,
            this.dsQuantidade,
            this.dsDesconto,
            this.dsPrecoTotal});
            this.dataGridView1.Location = new System.Drawing.Point(234, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(934, 349);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dsCodigo
            // 
            this.dsCodigo.HeaderText = "Código";
            this.dsCodigo.Name = "dsCodigo";
            this.dsCodigo.ReadOnly = true;
            // 
            // dsProduto
            // 
            this.dsProduto.HeaderText = "Produto";
            this.dsProduto.Name = "dsProduto";
            this.dsProduto.ReadOnly = true;
            this.dsProduto.Width = 300;
            // 
            // dsPreco
            // 
            this.dsPreco.HeaderText = "Valor Unitário";
            this.dsPreco.Name = "dsPreco";
            this.dsPreco.ReadOnly = true;
            this.dsPreco.Width = 130;
            // 
            // dsQuantidade
            // 
            this.dsQuantidade.HeaderText = "Quantidade";
            this.dsQuantidade.Name = "dsQuantidade";
            this.dsQuantidade.ReadOnly = true;
            // 
            // dsDesconto
            // 
            this.dsDesconto.HeaderText = "Desconto";
            this.dsDesconto.Name = "dsDesconto";
            this.dsDesconto.ReadOnly = true;
            this.dsDesconto.Width = 130;
            // 
            // dsPrecoTotal
            // 
            this.dsPrecoTotal.HeaderText = "Total";
            this.dsPrecoTotal.Name = "dsPrecoTotal";
            this.dsPrecoTotal.ReadOnly = true;
            this.dsPrecoTotal.Width = 130;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.BorderSize = 20;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(1265, 554);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 104);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSair.FlatAppearance.BorderSize = 20;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(1265, 441);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(107, 107);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizarCompra.Image")));
            this.btnFinalizarCompra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFinalizarCompra.Location = new System.Drawing.Point(1265, 328);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(107, 107);
            this.btnFinalizarCompra.TabIndex = 15;
            this.btnFinalizarCompra.Text = "Finalizar Compra";
            this.btnFinalizarCompra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFinalizarCompra.UseVisualStyleBackColor = true;
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1384, 661);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grpProduto);
            this.Controls.Add(this.grpCliente);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCaixa";
            this.Text = "FarmaTec - Caixa";
            this.Load += new System.EventHandler(this.frmCaixa_Load);
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.grpProduto.ResumeLayout(false);
            this.grpProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label lblCodCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.GroupBox grpProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodFuncionario;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Label nrPedido;
        private System.Windows.Forms.DateTimePicker dtPedido;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsPrecoTotal;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnFinalizarCompra;
    }
}