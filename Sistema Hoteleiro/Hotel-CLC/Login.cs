﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_CLC
{
    public partial class frLogin : Form
    {
        public frLogin()
        {
            InitializeComponent();
            pnlLogin.Visible = false;
        }

        private void frLogin_Load(object sender, EventArgs e)
        {
            //pnlLogin.Location = new Point(0, 0);
            //pnlLogin.Location = new Point(this.Width / 2, this.Height / 2);
            //pnlLogin.Location = new Point(this.Width - 160, this.Height - 112);
            //pnlLogin.Location = new Point(this.Width / 2 - pnlLogin.BackgroundImage.Size.Width, this.Height / 2 - pnlLogin.BackgroundImage.Size.Height);
            //pnlLogin.Location = new Point(this.Width / 2 - pnlLogin.BackgroundImage.Width, this.Height / 2 - pnlLogin.BackgroundImage.Height);

            pnlLogin.Visible = true;
        }

        public void ChamarLogin()
        {
            if (tbUsuario.Text == "")
            {
                MessageBox.Show("Preencha o campo Usuário!");
                tbUsuario.Focus();
                return;
            }

            if (tbSenha.Text == "")
            {
                MessageBox.Show("Preencha o campo Senha!");
                tbSenha.Focus();
                return;
            }
            
            //AQUI SERA O CODIGO PARA O LOGIN
            frMenuPrincipal frMenuPrinc = new frMenuPrincipal();
            //this.Hide();
            Limpar();
            frMenuPrinc.ShowDialog();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            ChamarLogin();
        }

        private void Limpar()
        {
            tbUsuario.Clear();
            tbSenha.Clear();
        }

        private void frLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //MessageBox.Show("Tecla pressionada!");
                btLogin_Click(sender, e);
            }
        }
    }
}
