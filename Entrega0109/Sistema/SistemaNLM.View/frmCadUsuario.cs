using System;
using System.Collections.Generic;
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

        private void frmCadUsuario_Load(object sender, EventArgs e)
        {
            ListaGrid();
        }

        private string opc = "";
        private void iniciarOpc()
        {
            switch (opc)
            {
                case "Novo":
                    LimparCampos();
                    HabilitarCampos();

                    tbNome.Focus();
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
                    try
                    {
                        objTabela.Id = Convert.ToInt32(tbCodigo.Text);

                        int x = ctlUsuario.Excluir(objTabela);

                        if (x > 0)
                        {
                            // MessageBox.Show("Usuário inserido com sucesso!");
                            MessageBox.Show(String.Format("Usuário {0} excluído com sucesso!", tbNome.Text));
                        }
                        else
                        {
                            MessageBox.Show("Usuário não excluído!");
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Ocorreu um erro ao Excluir: " + erro.Message);
                    }
                    break;

                case "Editar":
                    try
                    {
                        objTabela.Id = Convert.ToInt32(tbCodigo.Text);
                        objTabela.Nome = tbNome.Text;
                        objTabela.Usuario = tbUsuario.Text;
                        objTabela.Senha = tbSenha.Text;

                        int x = ctlUsuario.Editar(objTabela);

                        if (x > 0)
                        {
                            // MessageBox.Show("Usuário inserido com sucesso!");
                            MessageBox.Show(String.Format("Dado(s) do usuário {0} editado(s) com sucesso!", tbNome.Text));
                        }
                        else
                        {
                            MessageBox.Show("Usuário não editado!");
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Ocorreu um erro ao Editar: " + erro.Message);
                    }
                    break;
            }
        }

        private void HabilitarCampos()
        {
            tbNome.Enabled = true;
            tbUsuario.Enabled = true;
            tbSenha.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            tbNome.Enabled = false;
            tbUsuario.Enabled = false;
            tbSenha.Enabled = false;
        }

        private void LimparCampos()
        {
            tbCodigo.Clear();
            tbNome.Clear(); // tbNome.Text = "";
            tbUsuario.Clear(); // tbUsuario.Text = "";
            tbSenha.Clear(); // tbSenha.Text = "";
        }

        private void ListaGrid()
        {
            try
            {
                List<tblUsuario> lista = new List<tblUsuario>();

                lista = new ctlUsuario().Lista();

                dgvLerDados.AutoGenerateColumns = false;
                dgvLerDados.DataSource = lista;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar dados: " + erro.Message); ;
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            opc = "Novo";
            iniciarOpc();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            opc = "Salvar";
            iniciarOpc();
            ListaGrid();
            LimparCampos();
            DesabilitarCampos();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text == "")
            {
                MessageBox.Show("Selecione um registro da tabela para excluir!");
                return;
            }

            opc = "Excluir";
            iniciarOpc();
            ListaGrid();
            LimparCampos();
            DesabilitarCampos();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (tbCodigo.Text == "")
            {
                MessageBox.Show("Selecione um registro da tabela para editar!");
                return;
            }

            opc = "Editar";
            iniciarOpc();
            ListaGrid();
        }

        private void dgvLerDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbCodigo.Text = dgvLerDados.CurrentRow.Cells[0].Value.ToString();
            tbNome.Text = dgvLerDados.CurrentRow.Cells[1].Value.ToString();
            tbUsuario.Text = dgvLerDados.CurrentRow.Cells[2].Value.ToString();
            tbSenha.Text = dgvLerDados.CurrentRow.Cells[3].Value.ToString();
            HabilitarCampos();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
