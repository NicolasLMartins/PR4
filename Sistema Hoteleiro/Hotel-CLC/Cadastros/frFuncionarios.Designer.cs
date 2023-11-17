namespace Hotel_CLC.Cadastros
{
    partial class frFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frFuncionarios));
            this.mtbBuscarCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.tbBuscarNome = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.dgvLerDados = new System.Windows.Forms.DataGridView();
            this.btNovo = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLerDados)).BeginInit();
            this.SuspendLayout();
            // 
            // mtbBuscarCPF
            // 
            this.mtbBuscarCPF.Location = new System.Drawing.Point(338, 35);
            this.mtbBuscarCPF.Mask = "000,000,000-00";
            this.mtbBuscarCPF.Name = "mtbBuscarCPF";
            this.mtbBuscarCPF.Size = new System.Drawing.Size(87, 20);
            this.mtbBuscarCPF.TabIndex = 1;
            this.mtbBuscarCPF.Visible = false;
            // 
            // mtbCPF
            // 
            this.mtbCPF.Enabled = false;
            this.mtbCPF.Location = new System.Drawing.Point(338, 97);
            this.mtbCPF.Mask = "000,000,000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(87, 20);
            this.mtbCPF.TabIndex = 3;
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Enabled = false;
            this.mtbTelefone.Location = new System.Drawing.Point(338, 138);
            this.mtbTelefone.Mask = "(99) 00000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(87, 20);
            this.mtbTelefone.TabIndex = 5;
            // 
            // tbBuscarNome
            // 
            this.tbBuscarNome.Location = new System.Drawing.Point(338, 9);
            this.tbBuscarNome.Name = "tbBuscarNome";
            this.tbBuscarNome.Size = new System.Drawing.Size(87, 20);
            this.tbBuscarNome.TabIndex = 0;
            this.tbBuscarNome.Visible = false;
            // 
            // tbNome
            // 
            this.tbNome.Enabled = false;
            this.tbNome.Location = new System.Drawing.Point(102, 97);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(230, 20);
            this.tbNome.TabIndex = 2;
            // 
            // tbEndereco
            // 
            this.tbEndereco.Enabled = false;
            this.tbEndereco.Location = new System.Drawing.Point(102, 138);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(230, 20);
            this.tbEndereco.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Endereço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cargo:";
            // 
            // cbCargo
            // 
            this.cbCargo.Enabled = false;
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "Camareira",
            "Garçom",
            "Gerente"});
            this.cbCargo.Location = new System.Drawing.Point(102, 180);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(121, 21);
            this.cbCargo.TabIndex = 6;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Location = new System.Drawing.Point(170, 10);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(53, 17);
            this.rbNome.TabIndex = 13;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            this.rbNome.CheckedChanged += new System.EventHandler(this.rbNome_CheckedChanged);
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.Location = new System.Drawing.Point(258, 10);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(45, 17);
            this.rbCPF.TabIndex = 14;
            this.rbCPF.TabStop = true;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = true;
            this.rbCPF.CheckedChanged += new System.EventHandler(this.rbCPF_CheckedChanged);
            // 
            // dgvLerDados
            // 
            this.dgvLerDados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLerDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLerDados.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLerDados.Location = new System.Drawing.Point(102, 226);
            this.dgvLerDados.Name = "dgvLerDados";
            this.dgvLerDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLerDados.Size = new System.Drawing.Size(323, 179);
            this.dgvLerDados.TabIndex = 7;
            this.dgvLerDados.Click += new System.EventHandler(this.dgvLerDados_Click);
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(102, 421);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(75, 23);
            this.btNovo.TabIndex = 8;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btEditar
            // 
            this.btEditar.Enabled = false;
            this.btEditar.Location = new System.Drawing.Point(267, 421);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 10;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Enabled = false;
            this.btSalvar.Location = new System.Drawing.Point(185, 421);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 9;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Enabled = false;
            this.btExcluir.Location = new System.Drawing.Point(350, 421);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 11;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // frFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(526, 483);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.dgvLerDados);
            this.Controls.Add(this.rbCPF);
            this.Controls.Add(this.rbNome);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbBuscarNome);
            this.Controls.Add(this.mtbTelefone);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.mtbBuscarCPF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE FUNCIONÁRIOS";
            this.Load += new System.EventHandler(this.frFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLerDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbBuscarCPF;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.TextBox tbBuscarNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.DataGridView dgvLerDados;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btExcluir;
    }
}