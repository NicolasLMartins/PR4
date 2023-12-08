using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Hotel_CLC.Cadastros
{
    public partial class frFuncionarios : Form
    {
        Conexao con = new Conexao();
        string sql;
        OleDbCommand cmd;
        string id;
        
        public frFuncionarios()
        {
            InitializeComponent();
        }

        private void frFuncionarios_Load(object sender, EventArgs e)
        {
            rbNome.Checked = true;
        }

        private void HabilitarCampos()
        {
            tbNome.Enabled = true;
            mtbCPF.Enabled = true;
            tbEndereco.Enabled = true;
            mtbTelefone.Enabled = true;
            cbCargo.Enabled = true;
        }
        private void DesabilitarCampos()
        {
            tbNome.Enabled = false;
            mtbCPF.Enabled = false;
            tbEndereco.Enabled = false;
            mtbTelefone.Enabled = false;
            cbCargo.Enabled = false;
        }

        private void LimparCampos()
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
            HabilitarCampos();

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
                MessageBox.Show("Preencha o Nome!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNome.Focus();
                return;
            }
            
            if (mtbCPF.Text == "   .   .   -")
            {
                MessageBox.Show("Preencha o CPF!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbCPF.Focus();
                return;
            }

            //CÓDIGO DO BOTÃO PARA SALVAR

            MessageBox.Show("Registro salvo com sucesso!", "REGISTRO SALVO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btNovo.Enabled = true;

            btSalvar.Enabled = false;

            LimparCampos();
            DesabilitarCampos();
        }

        private void dgvLerDados_Click(object sender, EventArgs e)
        {
            btEditar.Enabled = true;
            btExcluir.Enabled = true;
            btSalvar.Enabled = false;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (tbNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o Nome!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNome.Clear();
                tbNome.Focus();
                return;
            }

            if (mtbCPF.Text == "   .   .   -")
            {
                MessageBox.Show("Preencha o CPF!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbCPF.Clear();
                mtbCPF.Focus();
                return;
            }

            // CÓDIGO DO BOTÃO PARA EDITAR

            MessageBox.Show("Registro editado com sucesso!", "REGISTRO EDITADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btNovo.Enabled = true;
            btEditar.Enabled = false;
            btExcluir.Enabled = false;

            LimparCampos();
            DesabilitarCampos();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja realmente excluir o registro?", "REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // CÓDIGO DO BOTÃO PARA EXCLUIR

                MessageBox.Show("Registro excluído com sucesso!", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btNovo.Enabled = true;
                btSalvar.Enabled = false;
                btExcluir.Enabled = false;

                LimparCampos();
                DesabilitarCampos();
            }
        }
    }
}
