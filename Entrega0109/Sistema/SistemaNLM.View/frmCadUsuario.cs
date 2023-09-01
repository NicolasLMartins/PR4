using System;
using System.Windows.Forms;

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
