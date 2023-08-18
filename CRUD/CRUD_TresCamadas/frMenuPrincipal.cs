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
        private void btPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = tbPesquisar.Text;

            Modelo_Cliente obj_cliente = new Modelo_Cliente();

            try
            {
                BLL_Cliente bllCli = new BLL_Cliente();
                obj_cliente = bllCli.PesquisaClienteDal(pesquisa);

                tbCodigo.Text = obj_cliente.Codigo.ToString();
                tbNome.Text = obj_cliente.Nome;
            }
            catch (Exception erro)
            {

                MessageBox.Show($"Erro ao pesquisar o cliente: {erro}");;
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

        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {
            tbNome.Enabled = true;
            btAtualizar.Enabled = true;
            btExcluir.Enabled = true;

            if (tbCodigo.Text == "")
            {
                btAtualizar.Enabled = false;
                btExcluir.Enabled = false;
            }
        }

        public void povoaGrade()
        {
            BLL_Cliente bllCli = new BLL_Cliente();
            dgvListarDados.DataSource = bllCli.ListaClienteDal();
        }

        private void frMenuPrincipal_Load(object sender, EventArgs e)
        {
            povoaGrade();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            tbPesquisar.Clear();

            tbNome.Enabled = true;
            tbNome.Focus();
        }

        private void btGravar_Click(object sender, EventArgs e)
        {
            Modelo_Cliente obj_cliente = new Modelo_Cliente();
            obj_cliente.Nome = tbNome.Text.Trim();

            try
            {
                BLL_Cliente bllCli = new BLL_Cliente();
                bllCli.GravaClienteDal(obj_cliente);
                MessageBox.Show("Cliente cadastrado com sucesso!");
                povoaGrade();
            }
            catch (Exception erro)
            {

                throw erro;
            }

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
                povoaGrade();
            }
            catch (Exception erro)
            {

                MessageBox.Show($"Erro na listagem de dados: {erro}");
            }
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            Modelo_Cliente obj_cliente = new Modelo_Cliente();
            obj_cliente.Codigo = int.Parse(tbCodigo.Text);
            obj_cliente.Nome = tbNome.Text;

            try
            {
                BLL_Cliente bllCli = new BLL_Cliente();
                bllCli.AtualizaClienteDal(obj_cliente);
                MessageBox.Show("Cliente atualizado com sucesso!");
                povoaGrade();
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            Modelo_Cliente obj_cliente = new Modelo_Cliente();
            obj_cliente.Codigo = int.Parse(tbCodigo.Text);

            try
            {
                BLL_Cliente bllCli = new BLL_Cliente();
                bllCli.ExcluiClienteDal(obj_cliente);
                MessageBox.Show("Cliente excluído com sucesso!");
                povoaGrade();
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btGravar_Click(sender, e);
            povoaGrade();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btAtualizar_Click(sender, e);
        }
    }
}
