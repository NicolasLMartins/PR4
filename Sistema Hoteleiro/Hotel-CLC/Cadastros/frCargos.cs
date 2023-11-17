using System;
using System.Windows.Forms;

namespace Hotel_CLC.Cadastros
{
    public partial class frCargos : Form
    {
        public frCargos()
        {
            InitializeComponent();
        }

        private void desabilitarCampos()
        {
            tbCargo.Enabled = false;
        }

        private void limparCampos()
        {
            tbCargo.Clear();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            tbCargo.Enabled = true;
            btSalvar.Enabled = true;
            btNovo.Enabled = false;
            btEditar.Enabled = false;
            btExcluir.Enabled = false;

            tbCargo.Focus();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (tbCargo.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o Cargo!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
                tbCargo.Focus();
                return;
            }

            // CÓDIGO DO BOTÃO PARA SALVAR

            MessageBox.Show("Registro salvo com sucesso!", "REGISTRO EDITADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btNovo.Enabled = true;
            btSalvar.Enabled = false;

            limparCampos();
            desabilitarCampos();
        }

        private void dgvLerDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLerDados_Click(object sender, EventArgs e)
        {
            btEditar.Enabled = true;
            btExcluir.Enabled = true;
            btSalvar.Enabled = false;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (tbCargo.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o Cargo!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
                tbCargo.Focus();
                return;
            }

            // CÓDIGO DO BOTÃO PARA EDITAR

            MessageBox.Show("Registro editado com sucesso!", "REGISTRO EDITADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btNovo.Enabled = true;
            btEditar.Enabled = false;
            btExcluir.Enabled = false;

            limparCampos();
            desabilitarCampos();
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

                limparCampos();
                desabilitarCampos();
            }
        }
    }
}
