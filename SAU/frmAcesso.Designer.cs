
namespace SAU
{
    partial class frmAcesso
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
            this.lblTeste = new System.Windows.Forms.Label();
            this.btnTeste = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTeste
            // 
            this.lblTeste.AutoSize = true;
            this.lblTeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeste.Location = new System.Drawing.Point(75, 106);
            this.lblTeste.Name = "lblTeste";
            this.lblTeste.Size = new System.Drawing.Size(666, 42);
            this.lblTeste.TabIndex = 0;
            this.lblTeste.Text = "Testar conexão com o banco de dados";
            this.lblTeste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTeste.Click += new System.EventHandler(this.lblTeste_Click);
            // 
            // btnTeste
            // 
            this.btnTeste.BackColor = System.Drawing.SystemColors.Control;
            this.btnTeste.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnTeste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeste.Location = new System.Drawing.Point(166, 195);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(108, 40);
            this.btnTeste.TabIndex = 1;
            this.btnTeste.Text = "Testar";
            this.btnTeste.UseVisualStyleBackColor = false;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.ForeColor = System.Drawing.Color.Crimson;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(527, 195);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(108, 40);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.lblTeste);
            this.Name = "frmAcesso";
            this.Text = "Verificar conexão";
            this.Load += new System.EventHandler(this.frmAcesso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeste;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.Button btnSair;
    }
}