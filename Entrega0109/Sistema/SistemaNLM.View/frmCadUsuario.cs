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
            tbNome.Clear(); // tbNome.Text = "";
            tbUsuario.Clear(); // tbUsuario.Text = "";
            tbSenha.Clear(); // tbSenha.Text = "";

            tbNome.Focus();
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
            LimparCampos();
            DesabilitarCampos();
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

                MessageBox.Show("Erro ao lista dados: " + erro.Message);;
            }
        }
    }
}
