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

        private void FormatarDGV()
        {
            dgvLerDados.Columns[0].HeaderText = "Código";
            dgvLerDados.Columns[1].HeaderText = "Nome";
            dgvLerDados.Columns[2].HeaderText = "CPF";
            dgvLerDados.Columns[3].HeaderText = "Endereço";
            dgvLerDados.Columns[4].HeaderText = "Telefone";
            dgvLerDados.Columns[5].HeaderText = "Cargo";
            dgvLerDados.Columns[6].HeaderText = "Data";

            dgvLerDados.Columns[0].Visible = false;
        }

        private void Listar()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM tblFuncionarios ORDER BY nome ASC";
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

        private void frFuncionarios_Load(object sender, EventArgs e)
        {
            Listar();
            rbNome.Checked = true;
            CarregarComboBox();
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
            if (cbCargo.Text == "")
            {
                MessageBox.Show("Cadastre antes um cargo!");
                Close();
            }

            HabilitarCampos();

            btSalvar.Enabled = true;

            tbNome.Focus();

            btNovo.Enabled = false;
            btEditar.Enabled = false;
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
            
            if (mtbCPF.Text == "   .   .   -")
            {
                MessageBox.Show("Preencha o CPF!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbCPF.Focus();
                return;
            }

            //CÓDIGO DO BOTÃO PARA SALVAR
            con.AbrirConexao();
            sql = $"INSERT INTO tblFuncionarios VALUES('{tbNome.Text}', '{mtbCPF.Text}', '{tbEndereco.Text}', '{mtbTelefone.Text}', '{cbCargo.Text}', '{DateTime.Now}')";
            cmd = new OleDbCommand(sql, con.conexao);
            cmd.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Registro salvo com sucesso!", "REGISTRO SALVO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btNovo.Enabled = true;

            btSalvar.Enabled = false;

            LimparCampos();
            DesabilitarCampos();
            Listar();
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
            con.AbrirConexao();
            sql = $"UPDATE tblFuncionarios SET nome = '{tbNome.Text}', cpf = '{mtbCPF.Text}', endereco = '{tbEndereco.Text}', telefone = '{mtbTelefone.Text}', cargo = '{cbCargo.Text}' WHERE idFunc = {id}";
            cmd = new OleDbCommand(sql, con.conexao);
            cmd.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Registro editado com sucesso!", "REGISTRO EDITADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btNovo.Enabled = true;
            btEditar.Enabled = false;
            btExcluir.Enabled = false;

            LimparCampos();
            DesabilitarCampos();
            Listar();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja realmente excluir o registro?", "REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // CÓDIGO DO BOTÃO PARA EXCLUIR
                con.AbrirConexao();
                sql = $"DELETE FROM tblFuncionarios WHERE idFunc = {id}";
                cmd = new OleDbCommand(sql, con.conexao);
                cmd.ExecuteNonQuery();
                con.FecharConexao();

                MessageBox.Show("Registro excluído com sucesso!", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btNovo.Enabled = true;
                btSalvar.Enabled = false;
                btExcluir.Enabled = false;

                LimparCampos();
                DesabilitarCampos();
                Listar();
            }
        }

        private void BuscarPorNome()
        {
            con.AbrirConexao();
            sql = $"SELECT * FROM tblFuncionarios WHERE nome LIKE '{tbBuscarNome.Text}%' ORDER BY nome ASC";
            cmd = new OleDbCommand(sql, con.conexao);
            OleDbDataAdapter daLista = new OleDbDataAdapter();
            daLista.SelectCommand = cmd;
            DataTable dtLista = new DataTable();
            daLista.Fill(dtLista);
            dgvLerDados.DataSource = dtLista;
            con.FecharConexao();

            FormatarDGV();
        }

         private void BuscarPorCpf()
        {
            con.AbrirConexao();
            sql = $"SELECT * FROM tblFuncionarios WHERE cpf LIKE '{mtbBuscarCPF.Text}' ORDER BY nome ASC";
            cmd = new OleDbCommand(sql, con.conexao);
            OleDbDataAdapter daLista = new OleDbDataAdapter();
            daLista.SelectCommand = cmd;
            DataTable dtLista = new DataTable();
            daLista.Fill(dtLista);
            dgvLerDados.DataSource = dtLista;
            con.FecharConexao();

            FormatarDGV();
        }

        private void dgvLerDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btEditar.Enabled = true;
            btExcluir.Enabled = true;
            btSalvar.Enabled = false;
            HabilitarCampos();

            id = dgvLerDados.CurrentRow.Cells[0].Value.ToString();
            tbNome.Text = dgvLerDados.CurrentRow.Cells[1].Value.ToString();
            mtbCPF.Text = dgvLerDados.CurrentRow.Cells[2].Value.ToString();
            tbEndereco.Text = dgvLerDados.CurrentRow.Cells[3].Value.ToString();
            mtbTelefone.Text = dgvLerDados.CurrentRow.Cells[4].Value.ToString();
            cbCargo.Text = dgvLerDados.CurrentRow.Cells[5].Value.ToString();
        }

        private void tbBuscarNome_TextChanged(object sender, EventArgs e)
        {
            BuscarPorNome();
        }

        private void mtbBuscarCPF_TextChanged(object sender, EventArgs e)
        {
            if (mtbBuscarCPF.Text == "   .   .   -")
            {
                Listar();
            }
            else
            {
                BuscarPorCpf();
            }
        }
    }
}
