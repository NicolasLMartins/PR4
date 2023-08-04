using System;
using System.Windows.Forms;

namespace CRUD_TresCamadas
{
    public partial class frMenuPrincipal : Form
    {
        public frMenuPrincipal()
        {
            InitializeComponent();
        }

        private void tbPesquisar_TextChanged(object sender, EventArgs e)
        {
            btPesquisar.Enabled = true;

            if (tbPesquisar.Text == "")
            {
                btPesquisar.Enabled = false;
            }
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {
            btGravar.Enabled = true;

            if (tbNome.Text == "")
            {
                btGravar.Enabled = false;
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            tbPesquisar.Clear();

            tbNome.Focus();
            tbNome.Enabled = true;
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            tbCodigo.Clear();
            tbNome.Clear();
            
            tbNome.Enabled = false;
            btGravar.Enabled = false;

            tbPesquisar.Focus();

        }

        private void btLeitura_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_Cliente bllCli = new BLL_Cliente();
                dgvListarDados.DataSource = bllCli.ListaClienteDal();
            }
            catch (Exception erro)
            {

                MessageBox.Show($"Erro na listagem de dados: {erro}");
            }
        }
    }
}
