namespace Hotel_CLC.Cadastros
{
    partial class frProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frProdutos));
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.dgvLerDados = new System.Windows.Forms.DataGridView();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbBuscarProduto = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbEstoque = new System.Windows.Forms.TextBox();
            this.btAdicionarImg = new System.Windows.Forms.Button();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLerDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btExcluir
            // 
            this.btExcluir.Enabled = false;
            this.btExcluir.Location = new System.Drawing.Point(565, 420);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 32;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Enabled = false;
            this.btSalvar.Location = new System.Drawing.Point(297, 420);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 27;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Enabled = false;
            this.btEditar.Location = new System.Drawing.Point(431, 420);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 30;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(161, 420);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(75, 23);
            this.btNovo.TabIndex = 25;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // dgvLerDados
            // 
            this.dgvLerDados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLerDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLerDados.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLerDados.Location = new System.Drawing.Point(161, 225);
            this.dgvLerDados.Name = "dgvLerDados";
            this.dgvLerDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLerDados.Size = new System.Drawing.Size(479, 179);
            this.dgvLerDados.TabIndex = 23;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.Enabled = false;
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Items.AddRange(new object[] {
            "Camareira",
            "Garçom",
            "Gerente"});
            this.cbFornecedor.Location = new System.Drawing.Point(161, 179);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(121, 21);
            this.cbFornecedor.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Fornecedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Estoque:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Buscar:";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Enabled = false;
            this.tbDescricao.Location = new System.Drawing.Point(161, 137);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(158, 20);
            this.tbDescricao.TabIndex = 19;
            // 
            // tbNome
            // 
            this.tbNome.Enabled = false;
            this.tbNome.Location = new System.Drawing.Point(161, 96);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(158, 20);
            this.tbNome.TabIndex = 17;
            // 
            // tbBuscarProduto
            // 
            this.tbBuscarProduto.Location = new System.Drawing.Point(244, 8);
            this.tbBuscarProduto.Name = "tbBuscarProduto";
            this.tbBuscarProduto.Size = new System.Drawing.Size(240, 20);
            this.tbBuscarProduto.TabIndex = 15;
            this.tbBuscarProduto.Visible = false;
            // 
            // tbValor
            // 
            this.tbValor.Enabled = false;
            this.tbValor.Location = new System.Drawing.Point(326, 96);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(158, 20);
            this.tbValor.TabIndex = 33;
            // 
            // tbEstoque
            // 
            this.tbEstoque.Enabled = false;
            this.tbEstoque.Location = new System.Drawing.Point(326, 138);
            this.tbEstoque.Name = "tbEstoque";
            this.tbEstoque.Size = new System.Drawing.Size(158, 20);
            this.tbEstoque.TabIndex = 34;
            // 
            // btAdicionarImg
            // 
            this.btAdicionarImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdicionarImg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAdicionarImg.Location = new System.Drawing.Point(610, 164);
            this.btAdicionarImg.Name = "btAdicionarImg";
            this.btAdicionarImg.Size = new System.Drawing.Size(30, 30);
            this.btAdicionarImg.TabIndex = 36;
            this.btAdicionarImg.Text = "+";
            this.btAdicionarImg.UseVisualStyleBackColor = true;
            this.btAdicionarImg.Click += new System.EventHandler(this.btAdicionarImg_Click);
            // 
            // pbImagem
            // 
            this.pbImagem.Location = new System.Drawing.Point(490, 8);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(150, 150);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagem.TabIndex = 35;
            this.pbImagem.TabStop = false;
            // 
            // frProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btAdicionarImg);
            this.Controls.Add(this.pbImagem);
            this.Controls.Add(this.tbEstoque);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.dgvLerDados);
            this.Controls.Add(this.cbFornecedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbBuscarProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE PRODUTOS";
            this.Load += new System.EventHandler(this.frProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLerDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.DataGridView dgvLerDados;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbBuscarProduto;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbEstoque;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.Button btAdicionarImg;
    }
}