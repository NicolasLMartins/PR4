using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hotel_CLC.Cadastros
{
    public partial class frCargos : Form
    {

        Conexao con = new Conexao();
        string sql;
        OleDbCommand cmd;
        string id;

        public frCargos()
        {
            InitializeComponent();
        }

        private void FormatarDGV()
        {
            dgvLerDados.Columns[0].HeaderText = "Código";
            dgvLerDados.Columns[1].HeaderText = "Cargo";

            dgvLerDados.Columns[0].Visible = false;
            dgvLerDados.Columns[1].Width = 200;
        }

        private void Listar()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM tblCargos ORDER BY Cargo ASC";
            cmd = new OleDbCommand(sql, con.conexao);
            OleDbDataAdapter daLista = new OleDbDataAdapter();
            daLista.SelectCommand = cmd;
            DataTable dtLista = new DataTable();
            daLista.Fill(dtLista);
            dgvLerDados.DataSource = dtLista;
            con.FecharConexao();

            FormatarDGV();
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
                Listar();
                tbCargo.Focus();
                return;
            }

            // CÓDIGO DO BOTÃO PARA SALVAR
            con.AbrirConexao();
            sql = $"INSERT INTO tblCargos (Cargo) VALUES('{tbCargo.Text}')";
            cmd = new OleDbCommand(sql, con.conexao);
            cmd.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Registro salvo com sucesso!", "REGISTRO SALVO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btNovo.Enabled = true;
            btSalvar.Enabled = false;
            btEditar.Enabled = false;
            btExcluir.Enabled = false;

            limparCampos();
            desabilitarCampos();
            Listar();
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

            con.AbrirConexao();
            sql = "UPDATE tblCargos SET cargo = '" + tbCargo.Text + "' WHERE idCargo = " + id;
            cmd = new OleDbCommand(sql, con.conexao);
            cmd.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Registro editado com sucesso!", "REGISTRO EDITADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btNovo.Enabled = true;
            btSalvar.Enabled = false;
            btEditar.Enabled = false;
            btExcluir.Enabled = false;

            limparCampos();
            desabilitarCampos();
            Listar();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja realmente excluir o registro?", "EXCLUIR REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // CÓDIGO DO BOTÃO PARA EXCLUIR
                con.AbrirConexao();
                sql = "DELETE FROM tblCargos WHERE idCargo = " + id;
                cmd = new OleDbCommand(sql, con.conexao);
                cmd.ExecuteNonQuery();
                con.FecharConexao();

                MessageBox.Show("Registro excluído com sucesso!", "EXCLUIR REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btNovo.Enabled = true;
                btSalvar.Enabled = false;
                btEditar.Enabled = false;
                btExcluir.Enabled = false;

                limparCampos();
                desabilitarCampos();
                Listar();
            }
        }

        private void frCargos_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void dgvLerDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btEditar.Enabled = true;
            btExcluir.Enabled = true;
            btSalvar.Enabled = false;
            btNovo.Enabled = true;
            tbCargo.Enabled = true;

            id = dgvLerDados.CurrentRow.Cells[0].Value.ToString();
            //MessageBox.Show(id);
            tbCargo.Text = dgvLerDados.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
