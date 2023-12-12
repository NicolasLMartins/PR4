using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hotel_CLC.Cadastros
{
    public partial class frUsuarios : Form
    {
        Conexao con = new Conexao();
        string sql;
        OleDbCommand cmd;
        string id;
        string usuarioAntigo;

        public frUsuarios()
        {
            InitializeComponent();
        }

        private void FormatarDGV()
        {
            dgvLerDados.Columns[0].HeaderText = "Código";
            dgvLerDados.Columns[1].HeaderText = "Nome";
            dgvLerDados.Columns[2].HeaderText = "Cargo";
            dgvLerDados.Columns[3].HeaderText = "Usuário";
            dgvLerDados.Columns[4].HeaderText = "Senha";
            dgvLerDados.Columns[5].HeaderText = "Data";

            dgvLerDados.Columns[0].Visible = false;
        }

        private void Listar()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM tblUsuarios ORDER BY nome ASC";
            cmd = new OleDbCommand(sql, con.conexao);
            OleDbDataAdapter daLista = new OleDbDataAdapter();
            daLista.SelectCommand = cmd;
            DataTable dtLista = new DataTable();
            daLista.Fill(dtLista);
            dgvLerDados.DataSource = dtLista;
            con.FecharConexao();

            FormatarDGV();
        }

        private void CarregarComboBox()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM tblCargos order by cargo asc";
            cmd = new OleDbCommand(sql, con.conexao);
            OleDbDataAdapter daLista = new OleDbDataAdapter();
            daLista.SelectCommand = cmd;
            DataTable dtLista = new DataTable();
            daLista.Fill(dtLista);
            cbCargo.DataSource = dtLista;
            cbCargo.DisplayMember = "Cargo";
            con.FecharConexao();
        }

        private void BuscarPorNome()
        {
            con.AbrirConexao();
            sql = $"SELECT * FROM tblUsuarios WHERE nome LIKE '{tbBuscar.Text}%' ORDER BY nome ASC";
            cmd = new OleDbCommand(sql, con.conexao);
            OleDbDataAdapter daLista = new OleDbDataAdapter();
            daLista.SelectCommand = cmd;
            DataTable dtLista = new DataTable();
            daLista.Fill(dtLista);
            dgvLerDados.DataSource = dtLista;
            con.FecharConexao();

            FormatarDGV();
        }

        private void HabilitarCampos()
        {
            tbNome.Enabled = true;
            tbUsuario.Enabled = true;
            tbSenha.Enabled = true;
            cbCargo.Enabled = true;
        }
        private void DesabilitarCampos()
        {
            tbNome.Enabled = false;
            tbUsuario.Enabled = false;
            tbSenha.Enabled = false;
            cbCargo.Enabled = false;
        }

        private void LimparCampos()
        {
            tbNome.Clear();
            tbUsuario.Clear();
            tbSenha.Clear();
        }

        private void frUsuarios_Load(object sender, EventArgs e)
        {
            Listar();
            CarregarComboBox();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            if (cbCargo.Text == "")
            {
                MessageBox.Show("Cadastre antes um cargo!");
                Close();
            }

            HabilitarCampos();
            btSalvar.Enabled = true;
            tbNome.Focus();
            btNovo.Enabled = false;
            btEditar.Enabled= false;
            btExcluir.Enabled = false;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (tbNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o Nome!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNome.Focus();
                return;
            }

            //CÓDIGO DO BOTÃO PARA SALVAR
            con.AbrirConexao();
            sql = $"INSERT INTO tblUsuarios VALUES('{tbNome.Text}', '{cbCargo.Text}', '{tbUsuario.Text}', '{tbSenha.Text}', '{DateTime.Today}')";
            cmd = new OleDbCommand(sql, con.conexao);

            OleDbCommand cmdVerificar;
            cmdVerificar = new OleDbCommand($"SELECT * FROM tblUsuarios WHERE usuario = '{tbUsuario.Text}'", con.conexao);
            OleDbDataAdapter daLista = new OleDbDataAdapter();
            daLista.SelectCommand = cmdVerificar;
            DataTable dtLista = new DataTable();
            daLista.Fill(dtLista);

            if (dtLista.Rows.Count > 0)
            {
                MessageBox.Show("Usuário já registrado!", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbUsuario.Clear();
                tbUsuario.Focus();
                return;
            }

            cmd.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Registro salvo com sucesso!", "REGISTRO SALVO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btNovo.Enabled = true;
            btSalvar.Enabled = false;
            btEditar.Enabled = false;
            btExcluir.Enabled = false;

            LimparCampos();
            DesabilitarCampos();
            Listar();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            // CÓDIGO DO BOTÃO PARA EDITAR
            con.AbrirConexao();
            sql = $"UPDATE tblUsuarios SET nome = '{tbNome.Text}', cargo = '{cbCargo.Text}', usuario = '{tbUsuario.Text}', senha = '{tbSenha.Text}' WHERE idUsuario = {id}";
            cmd = new OleDbCommand(sql, con.conexao);

            if (tbUsuario.Text != usuarioAntigo)
            {
                OleDbCommand cmdVerificar;
                cmdVerificar = new OleDbCommand($"SELECT * FROM tblUsuarios WHERE usuario = '{tbUsuario.Text}'", con.conexao);
                OleDbDataAdapter daLista = new OleDbDataAdapter();
                daLista.SelectCommand = cmdVerificar;
                DataTable dtLista = new DataTable();
                daLista.Fill(dtLista);

                if (dtLista.Rows.Count > 0)
                {
                    MessageBox.Show("Usuário já registrado!", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbUsuario.Clear();
                    tbUsuario.Focus();
                    return;
                }
            }

            cmd.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Registro editado com sucesso!", "REGISTRO EDITADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btNovo.Enabled = true;
            btSalvar.Enabled = false;
            btEditar.Enabled = false;
            btExcluir.Enabled = false;

            LimparCampos();
            DesabilitarCampos();
            Listar();
        }

        private void dgvLerDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btEditar.Enabled = true;
            btExcluir.Enabled = true;
            btSalvar.Enabled = false;
            btNovo.Enabled = true;
            HabilitarCampos();

            id = dgvLerDados.CurrentRow.Cells[0].Value.ToString();
            tbNome.Text = dgvLerDados.CurrentRow.Cells[1].Value.ToString();
            cbCargo.Text = dgvLerDados.CurrentRow.Cells[2].Value.ToString();
            tbUsuario.Text = dgvLerDados.CurrentRow.Cells[3].Value.ToString();
            tbSenha.Text = dgvLerDados.CurrentRow.Cells[4].Value.ToString();

            usuarioAntigo = dgvLerDados.CurrentRow.Cells[3].Value.ToString();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja realmente excluir o registro?", "REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // CÓDIGO DO BOTÃO PARA EXCLUIR
                con.AbrirConexao();
                sql = $"DELETE FROM tblUsuarios WHERE idUsuario = {id}";
                cmd = new OleDbCommand(sql, con.conexao);
                cmd.ExecuteNonQuery();
                con.FecharConexao();

                MessageBox.Show("Registro excluído com sucesso!", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btNovo.Enabled = true;
                btSalvar.Enabled = false;
                btEditar.Enabled = false;
                btExcluir.Enabled = false;

                LimparCampos();
                DesabilitarCampos();
                Listar();
            }
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarPorNome();
        }
    }
}
