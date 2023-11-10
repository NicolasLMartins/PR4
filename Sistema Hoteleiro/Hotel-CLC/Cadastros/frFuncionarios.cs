using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_CLC.Cadastros
{
    public partial class frFuncionarios : Form
    {
        public frFuncionarios()
        {
            InitializeComponent();
        }

        private void frFuncionarios_Load(object sender, EventArgs e)
        {
            rbNome.Checked = true;
        }

        private void habilitarCampos()
        {
            tbNome.Enabled = true;
            mtbCPF.Enabled = true;
            tbEndereco.Enabled = true;
            mtbTelefone.Enabled = true;
            cbCargo.Enabled = true;
        }
        private void desabilitarCampos()
        {
            tbNome.Enabled = false;
            mtbCPF.Enabled = false;
            tbEndereco.Enabled = false;
            mtbTelefone.Enabled = false;
            cbCargo.Enabled = false;
        }

        private void limparCampos()
        {
            tbNome.Clear();
            mtbCPF.Clear();
            tbEndereco.Clear();
            mtbTelefone.Clear();
            cbCargo.ResetText();
        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            tbBuscarNome.Visible = true;
            mtbBuscarCPF.Visible = false;

            mtbBuscarCPF.Clear();
            tbBuscarNome.Clear();
            tbBuscarNome.Focus();
        }

        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
            tbBuscarNome.Visible = false;
            mtbBuscarCPF.Visible = true;

            tbBuscarNome.Clear();
            mtbBuscarCPF.Clear();
            mtbBuscarCPF.Focus();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();

            btSalvar.Enabled = true;

            tbNome.Focus();

            btNovo.Enabled = false;
            btEditar.Enabled = false;
            btExcluir.Enabled = false;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (tbNome.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o Nome!");
                tbNome.Focus();
                return;
            }
            
            if (mtbCPF.Text == "   .   .   -")
            {
                MessageBox.Show("Preencha o CPF!");
                mtbCPF.Focus();
                return;
            }

            //CÓDIGO DO BOTÃO PARA SALVAR

            MessageBox.Show("Registro salvo com sucesso!");

            btNovo.Enabled = true;

            btSalvar.Enabled = false;

            limparCampos();
            desabilitarCampos();
        }
    }
}
