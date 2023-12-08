namespace Hotel_CLC.Cadastros
{
    partial class frUsuarios
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
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.dgvLerDados = new System.Windows.Forms.DataGridView();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLerDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btExcluir
            // 
            this.btExcluir.Enabled = false;
            this.btExcluir.Location = new System.Drawing.Point(351, 435);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 9;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.Enabled = false;
            this.btSalvar.Location = new System.Drawing.Point(186, 435);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 7;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Enabled = false;
            this.btEditar.Location = new System.Drawing.Point(268, 435);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 8;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(103, 435);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(75, 23);
            this.btNovo.TabIndex = 6;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // dgvLerDados
            // 
            this.dgvLerDados.AllowUserToAddRows = false;
            this.dgvLerDados.AllowUserToDeleteRows = false;
            this.dgvLerDados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLerDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLerDados.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLerDados.Location = new System.Drawing.Point(103, 240);
            this.dgvLerDados.Name = "dgvLerDados";
            this.dgvLerDados.ReadOnly = true;
            this.dgvLerDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLerDados.Size = new System.Drawing.Size(323, 179);
            this.dgvLerDados.TabIndex = 5;
            // 
            // cbCargo
            // 
            this.cbCargo.Enabled = false;
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "Camareira",
            "Garçom",
            "Gerente"});
            this.cbCargo.Location = new System.Drawing.Point(339, 111);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(87, 21);
            this.cbCargo.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cargo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nome:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Enabled = false;
            this.tbUsuario.Location = new System.Drawing.Point(103, 152);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(230, 20);
            this.tbUsuario.TabIndex = 3;
            // 
            // tbNome
            // 
            this.tbNome.Enabled = false;
            this.tbNome.Location = new System.Drawing.Point(103, 111);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(230, 20);
            this.tbNome.TabIndex = 1;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(149, 23);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(277, 20);
            this.tbBuscar.TabIndex = 0;
            this.tbBuscar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Buscar:";
            // 
            // tbSenha
            // 
            this.tbSenha.Enabled = false;
            this.tbSenha.Location = new System.Drawing.Point(339, 152);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(87, 20);
            this.tbSenha.TabIndex = 4;
            this.tbSenha.UseSystemPasswordChar = true;
            // 
            // frUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(526, 483);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.dgvLerDados);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE USUÁRIOS";
            this.Load += new System.EventHandler(this.frUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLerDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.DataGridView dgvLerDados;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSenha;
    }
}