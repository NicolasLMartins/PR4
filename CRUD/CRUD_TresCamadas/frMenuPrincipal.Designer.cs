﻿namespace CRUD_TresCamadas
{
    partial class frMenuPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPesquisar = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.btLeitura = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.dgvListarDados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // tbPesquisar
            // 
            this.tbPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbPesquisar.Location = new System.Drawing.Point(133, 8);
            this.tbPesquisar.Name = "tbPesquisar";
            this.tbPesquisar.Size = new System.Drawing.Size(370, 29);
            this.tbPesquisar.TabIndex = 3;
            this.tbPesquisar.TextChanged += new System.EventHandler(this.tbPesquisar_TextChanged);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbCodigo.Location = new System.Drawing.Point(133, 66);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(132, 29);
            this.tbCodigo.TabIndex = 4;
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbNome.Location = new System.Drawing.Point(133, 124);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(254, 29);
            this.tbNome.TabIndex = 5;
            this.tbNome.TextChanged += new System.EventHandler(this.tbNome_TextChanged);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Enabled = false;
            this.btPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btPesquisar.Location = new System.Drawing.Point(509, 7);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(122, 31);
            this.btPesquisar.TabIndex = 6;
            this.btPesquisar.Text = "&Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btCadastrar.Location = new System.Drawing.Point(17, 183);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(122, 29);
            this.btCadastrar.TabIndex = 7;
            this.btCadastrar.Text = "&Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btGravar
            // 
            this.btGravar.Enabled = false;
            this.btGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btGravar.Location = new System.Drawing.Point(140, 183);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(122, 29);
            this.btGravar.TabIndex = 8;
            this.btGravar.Text = "&Gravar(C)";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // btLeitura
            // 
            this.btLeitura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btLeitura.Location = new System.Drawing.Point(263, 183);
            this.btLeitura.Name = "btLeitura";
            this.btLeitura.Size = new System.Drawing.Size(122, 29);
            this.btLeitura.TabIndex = 9;
            this.btLeitura.Text = "&Leitura(R)";
            this.btLeitura.UseVisualStyleBackColor = true;
            this.btLeitura.Click += new System.EventHandler(this.btLeitura_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Enabled = false;
            this.btAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btAtualizar.Location = new System.Drawing.Point(386, 183);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(122, 29);
            this.btAtualizar.TabIndex = 10;
            this.btAtualizar.Text = "&Atualizar(U)";
            this.btAtualizar.UseVisualStyleBackColor = true;
            // 
            // btExcluir
            // 
            this.btExcluir.Enabled = false;
            this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btExcluir.Location = new System.Drawing.Point(509, 183);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(122, 29);
            this.btExcluir.TabIndex = 11;
            this.btExcluir.Text = "&Excluir(D)";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // dgvListarDados
            // 
            this.dgvListarDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarDados.Location = new System.Drawing.Point(17, 218);
            this.dgvListarDados.Name = "dgvListarDados";
            this.dgvListarDados.Size = new System.Drawing.Size(614, 150);
            this.dgvListarDados.TabIndex = 12;
            // 
            // frMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 378);
            this.Controls.Add(this.dgvListarDados);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btLeitura);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.tbPesquisar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD Em Três Camadas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPesquisar;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Button btLeitura;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.DataGridView dgvListarDados;
    }
}

