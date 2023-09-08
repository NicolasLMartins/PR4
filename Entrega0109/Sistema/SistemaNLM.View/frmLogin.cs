using SistemaNLM.Controller;
using SistemaNLM.Tables;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaNLM.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbUsuario.Text == "")
                {
                    MessageBox.Show("Preencha o campo usuário!");
                    tbUsuario.Focus();
                    return;
                }
                if (tbSenha.Text == "")
                {
                    MessageBox.Show("Preencha o campo senha!");
                    tbSenha.Focus();
                    return;
                }

                tblUsuario objTabela = new tblUsuario();

                objTabela.Usuario = tbUsuario.Text;
                objTabela.Senha = tbSenha.Text;

                objTabela = new ctlUsuario().Login(objTabela);

                if (objTabela.Usuario == null || objTabela.Senha == null)
                {
                    lbMensagem.Text = "Usuário ou senha não encontrados!";
                    lbMensagem.ForeColor = Color.Red;
                    return;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao logar: " + erro.Message);
            }

            frmCadUsuario frmCadUsu = new frmCadUsuario();
            frmCadUsu.ShowDialog();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
