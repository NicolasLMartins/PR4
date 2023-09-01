using System;
using System.Windows.Forms;
using SistemaNLM.Controller;
using SistemaNLM.Tables;

namespace SistemaNLM.View
{
    public partial class frmCadUsuario : Form
    {
        tblUsuario objTabela = new tblUsuario();

        public frmCadUsuario()
        {
            InitializeComponent();
        }

        private string opc = "";

        private void iniciarOpc()
        {
            switch (opc)
            {
                case "Novo":
                    HabilitarCampos();
                    LimparCampos();
                    break;

                case "Salvar":
                    try
                    {
                        objTabela.Nome = tbNome.Text;
                        objTabela.Usuario = tbUsuario.Text;
                        objTabela.Senha = tbSenha.Text;

                        int x = ctlUsuario.Inserir(objTabela);

                        if (x > 0)
                        {
                            // MessageBox.Show("Usuário inserido com sucesso!");
                            MessageBox.Show(String.Format("Usuário: {0} foi inserido com sucesso!", tbNome.Text));
                        }
                        else
                        {
                            MessageBox.Show("Usuário não inserido!");
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Ocorreu um erro ao Salvar: " + erro.Message);
                        throw erro;
                    }
                    break;

                case "Excluir":

                    break;

                case "Editar":

                    break;
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            opc = "Novo";
            iniciarOpc();
        }

        private void HabilitarCampos()
        {
            tbNome.Enabled = true;
            tbUsuario.Enabled = true;
            tbSenha.Enabled = true;
        }

        private void LimparCampos()
        {
            tbNome.Clear(); // tbNome.Text = "";
            tbUsuario.Clear(); // tbUsuario.Text = "";
            tbSenha.Clear(); // tbSenha.Text = "";

            tbNome.Focus();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            opc = "Salvar";
            iniciarOpc();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            opc = "Excluir";
            iniciarOpc();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            opc = "Editar";
            iniciarOpc();
        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
