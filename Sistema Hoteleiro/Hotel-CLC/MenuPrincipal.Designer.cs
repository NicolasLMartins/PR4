﻿namespace Hotel_CLC
{
    partial class frMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMenuPrincipal));
            this.btSair = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btRelatorio = new System.Windows.Forms.Button();
            this.btCheckout = new System.Windows.Forms.Button();
            this.btCheckin = new System.Windows.Forms.Button();
            this.btQuadroReservas = new System.Windows.Forms.Button();
            this.btReservas = new System.Windows.Forms.Button();
            this.btMovimentacoes = new System.Windows.Forms.Button();
            this.btProduto = new System.Windows.Forms.Button();
            this.MenuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóspedesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quartosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.novoProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.novaVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasESaídasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.checkinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.novaReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quadroDeReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.pnlTopo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Location = new System.Drawing.Point(835, 0);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(34, 24);
            this.btSair.TabIndex = 2;
            this.btSair.Text = "X";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastros,
            this.MenuProdutos,
            this.MenuMovimentacoes,
            this.MenuCheck,
            this.MenuReservas,
            this.MenuRelatorios,
            this.MenuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pnlTopo
            // 
            this.pnlTopo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTopo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlTopo.Controls.Add(this.btRelatorio);
            this.pnlTopo.Controls.Add(this.btCheckout);
            this.pnlTopo.Controls.Add(this.btCheckin);
            this.pnlTopo.Controls.Add(this.btQuadroReservas);
            this.pnlTopo.Controls.Add(this.btReservas);
            this.pnlTopo.Controls.Add(this.btMovimentacoes);
            this.pnlTopo.Controls.Add(this.btProduto);
            this.pnlTopo.Location = new System.Drawing.Point(0, 22);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(608, 80);
            this.pnlTopo.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(607, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 428);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "13:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "20/10/2023";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel_CLC.Properties.Resources.relogio;
            this.pictureBox1.Location = new System.Drawing.Point(37, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btRelatorio
            // 
            this.btRelatorio.FlatAppearance.BorderSize = 0;
            this.btRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRelatorio.Image = global::Hotel_CLC.Properties.Resources.relatorio64px;
            this.btRelatorio.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRelatorio.Location = new System.Drawing.Point(527, 5);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Size = new System.Drawing.Size(70, 70);
            this.btRelatorio.TabIndex = 12;
            this.btRelatorio.UseVisualStyleBackColor = true;
            // 
            // btCheckout
            // 
            this.btCheckout.FlatAppearance.BorderSize = 0;
            this.btCheckout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCheckout.Image = global::Hotel_CLC.Properties.Resources.checkout64px;
            this.btCheckout.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCheckout.Location = new System.Drawing.Point(441, 5);
            this.btCheckout.Name = "btCheckout";
            this.btCheckout.Size = new System.Drawing.Size(70, 70);
            this.btCheckout.TabIndex = 11;
            this.btCheckout.UseVisualStyleBackColor = true;
            // 
            // btCheckin
            // 
            this.btCheckin.FlatAppearance.BorderSize = 0;
            this.btCheckin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btCheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCheckin.Image = global::Hotel_CLC.Properties.Resources.checkin64px;
            this.btCheckin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCheckin.Location = new System.Drawing.Point(355, 5);
            this.btCheckin.Name = "btCheckin";
            this.btCheckin.Size = new System.Drawing.Size(70, 70);
            this.btCheckin.TabIndex = 10;
            this.btCheckin.UseVisualStyleBackColor = true;
            // 
            // btQuadroReservas
            // 
            this.btQuadroReservas.FlatAppearance.BorderSize = 0;
            this.btQuadroReservas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btQuadroReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuadroReservas.Image = global::Hotel_CLC.Properties.Resources.quadroDeReservas;
            this.btQuadroReservas.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btQuadroReservas.Location = new System.Drawing.Point(269, 5);
            this.btQuadroReservas.Name = "btQuadroReservas";
            this.btQuadroReservas.Size = new System.Drawing.Size(70, 70);
            this.btQuadroReservas.TabIndex = 9;
            this.btQuadroReservas.UseVisualStyleBackColor = true;
            // 
            // btReservas
            // 
            this.btReservas.FlatAppearance.BorderSize = 0;
            this.btReservas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReservas.Image = global::Hotel_CLC.Properties.Resources.reservas64px;
            this.btReservas.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btReservas.Location = new System.Drawing.Point(183, 5);
            this.btReservas.Name = "btReservas";
            this.btReservas.Size = new System.Drawing.Size(70, 70);
            this.btReservas.TabIndex = 8;
            this.btReservas.UseVisualStyleBackColor = true;
            // 
            // btMovimentacoes
            // 
            this.btMovimentacoes.FlatAppearance.BorderSize = 0;
            this.btMovimentacoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btMovimentacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMovimentacoes.Image = global::Hotel_CLC.Properties.Resources.movimentacao;
            this.btMovimentacoes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btMovimentacoes.Location = new System.Drawing.Point(97, 5);
            this.btMovimentacoes.Name = "btMovimentacoes";
            this.btMovimentacoes.Size = new System.Drawing.Size(70, 70);
            this.btMovimentacoes.TabIndex = 7;
            this.btMovimentacoes.UseVisualStyleBackColor = true;
            // 
            // btProduto
            // 
            this.btProduto.FlatAppearance.BorderSize = 0;
            this.btProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProduto.Image = global::Hotel_CLC.Properties.Resources.produto64px;
            this.btProduto.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btProduto.Location = new System.Drawing.Point(11, 5);
            this.btProduto.Name = "btProduto";
            this.btProduto.Size = new System.Drawing.Size(70, 70);
            this.btProduto.TabIndex = 6;
            this.btProduto.UseVisualStyleBackColor = true;
            // 
            // MenuCadastros
            // 
            this.MenuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem,
            this.hóspedesToolStripMenuItem,
            this.quartosToolStripMenuItem,
            this.cargosToolStripMenuItem,
            this.fornecedoresToolStripMenuItem});
            this.MenuCadastros.Image = global::Hotel_CLC.Properties.Resources.cadastro;
            this.MenuCadastros.Name = "MenuCadastros";
            this.MenuCadastros.Size = new System.Drawing.Size(87, 20);
            this.MenuCadastros.Text = "Cadastros";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.funcionáriosToolStripMenuItem.Text = "&Funcionários";
            // 
            // hóspedesToolStripMenuItem
            // 
            this.hóspedesToolStripMenuItem.Name = "hóspedesToolStripMenuItem";
            this.hóspedesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.hóspedesToolStripMenuItem.Text = "&Hóspedes";
            // 
            // quartosToolStripMenuItem
            // 
            this.quartosToolStripMenuItem.Name = "quartosToolStripMenuItem";
            this.quartosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.quartosToolStripMenuItem.Text = "&Quartos";
            // 
            // cargosToolStripMenuItem
            // 
            this.cargosToolStripMenuItem.Name = "cargosToolStripMenuItem";
            this.cargosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.cargosToolStripMenuItem.Text = "&Cargos";
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.fornecedoresToolStripMenuItem.Text = "F&ornecedores";
            // 
            // MenuProdutos
            // 
            this.MenuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoProdutoToolStripMenuItem,
            this.estoqueToolStripMenuItem});
            this.MenuProdutos.Image = global::Hotel_CLC.Properties.Resources.produtos;
            this.MenuProdutos.Name = "MenuProdutos";
            this.MenuProdutos.Size = new System.Drawing.Size(83, 20);
            this.MenuProdutos.Text = "Produtos";
            // 
            // novoProdutoToolStripMenuItem
            // 
            this.novoProdutoToolStripMenuItem.Name = "novoProdutoToolStripMenuItem";
            this.novoProdutoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.novoProdutoToolStripMenuItem.Text = "&Novo Produto";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.estoqueToolStripMenuItem.Text = "&Estoque";
            // 
            // MenuMovimentacoes
            // 
            this.MenuMovimentacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaVendaToolStripMenuItem,
            this.novoServiçoToolStripMenuItem,
            this.entradasESaídasToolStripMenuItem});
            this.MenuMovimentacoes.Image = global::Hotel_CLC.Properties.Resources.movimentacoes;
            this.MenuMovimentacoes.Name = "MenuMovimentacoes";
            this.MenuMovimentacoes.Size = new System.Drawing.Size(120, 20);
            this.MenuMovimentacoes.Text = "Movimentações";
            // 
            // novaVendaToolStripMenuItem
            // 
            this.novaVendaToolStripMenuItem.Name = "novaVendaToolStripMenuItem";
            this.novaVendaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.novaVendaToolStripMenuItem.Text = "&Nova Venda";
            // 
            // novoServiçoToolStripMenuItem
            // 
            this.novoServiçoToolStripMenuItem.Name = "novoServiçoToolStripMenuItem";
            this.novoServiçoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.novoServiçoToolStripMenuItem.Text = "N&ovo Serviço";
            // 
            // entradasESaídasToolStripMenuItem
            // 
            this.entradasESaídasToolStripMenuItem.Name = "entradasESaídasToolStripMenuItem";
            this.entradasESaídasToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.entradasESaídasToolStripMenuItem.Text = "&Entradas e Saídas";
            // 
            // MenuCheck
            // 
            this.MenuCheck.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkinToolStripMenuItem,
            this.checkoutToolStripMenuItem});
            this.MenuCheck.Image = global::Hotel_CLC.Properties.Resources.checkIn;
            this.MenuCheck.Name = "MenuCheck";
            this.MenuCheck.Size = new System.Drawing.Size(147, 20);
            this.MenuCheck.Text = "C&heck-in/ Check-out";
            // 
            // checkinToolStripMenuItem
            // 
            this.checkinToolStripMenuItem.Name = "checkinToolStripMenuItem";
            this.checkinToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.checkinToolStripMenuItem.Text = "&Check-in";
            // 
            // checkoutToolStripMenuItem
            // 
            this.checkoutToolStripMenuItem.Name = "checkoutToolStripMenuItem";
            this.checkoutToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.checkoutToolStripMenuItem.Text = "&Check-out";
            // 
            // MenuReservas
            // 
            this.MenuReservas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaReservaToolStripMenuItem,
            this.quadroDeReservasToolStripMenuItem,
            this.consultarReservasToolStripMenuItem});
            this.MenuReservas.Image = global::Hotel_CLC.Properties.Resources.reservas;
            this.MenuReservas.Name = "MenuReservas";
            this.MenuReservas.Size = new System.Drawing.Size(80, 20);
            this.MenuReservas.Text = "&Reservas";
            // 
            // novaReservaToolStripMenuItem
            // 
            this.novaReservaToolStripMenuItem.Name = "novaReservaToolStripMenuItem";
            this.novaReservaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.novaReservaToolStripMenuItem.Text = "&Nova Reserva";
            // 
            // quadroDeReservasToolStripMenuItem
            // 
            this.quadroDeReservasToolStripMenuItem.Name = "quadroDeReservasToolStripMenuItem";
            this.quadroDeReservasToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.quadroDeReservasToolStripMenuItem.Text = "&Quadro de Reservas";
            // 
            // consultarReservasToolStripMenuItem
            // 
            this.consultarReservasToolStripMenuItem.Name = "consultarReservasToolStripMenuItem";
            this.consultarReservasToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.consultarReservasToolStripMenuItem.Text = "&Consultar Reservas";
            // 
            // MenuRelatorios
            // 
            this.MenuRelatorios.Image = global::Hotel_CLC.Properties.Resources.relatorio;
            this.MenuRelatorios.Name = "MenuRelatorios";
            this.MenuRelatorios.Size = new System.Drawing.Size(87, 20);
            this.MenuRelatorios.Text = "R&elatórios";
            // 
            // MenuSair
            // 
            this.MenuSair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.MenuSair.Image = global::Hotel_CLC.Properties.Resources.sair;
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(54, 20);
            this.MenuSair.Text = "&Sair";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "&Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // frMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTopo);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frMenuPrincipal";
            this.Text = "Grand Hyatt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.frMenuPrincipal_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlTopo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastros;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutos;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentacoes;
        private System.Windows.Forms.ToolStripMenuItem MenuCheck;
        private System.Windows.Forms.ToolStripMenuItem MenuReservas;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóspedesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quartosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasESaídasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quadroDeReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btProduto;
        private System.Windows.Forms.Button btMovimentacoes;
        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.Button btCheckout;
        private System.Windows.Forms.Button btCheckin;
        private System.Windows.Forms.Button btQuadroReservas;
        private System.Windows.Forms.Button btReservas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}