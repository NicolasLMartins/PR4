﻿using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hotel_CLC.Cadastros
{
    public partial class frFornecedores : Form
    {
        Conexao con = new Conexao();
        string sql;
        OleDbCommand cmd;
        string id;

        public frFornecedores()
        {
            InitializeComponent();
        }

        private void FormatarDGV()
        {
            dgvLerDados.Columns[0].HeaderText = "Código";
            dgvLerDados.Columns[1].HeaderText = "Nome";
            dgvLerDados.Columns[2].HeaderText = "Endereço";
            dgvLerDados.Columns[3].HeaderText = "Telefone";

            dgvLerDados.Columns[0].Visible = false;
        }

        private void Listar()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM tblFornecedores ORDER BY nome ASC";
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
            tbEndereco.Enabled = true;
            mtbTelefone.Enabled = true;
        }
        private void DesabilitarCampos()
        {
            tbNome.Enabled = false;
            tbEndereco.Enabled = false;
            mtbTelefone.Enabled = false;
        }

        private void LimparCampos()
        {
            tbNome.Clear();
            tbEndereco.Clear();
            mtbTelefone.Clear();
        }

        private void BuscarPorNome()
        {
            con.AbrirConexao();
            sql = $"SELECT * FROM tblFornecedores WHERE nome LIKE '{tbBuscar.Text}%' ORDER BY nome ASC";
            cmd = new OleDbCommand(sql, con.conexao);
            OleDbDataAdapter daLista = new OleDbDataAdapter();
            daLista.SelectCommand = cmd;
            DataTable dtLista = new DataTable();
            daLista.Fill(dtLista);
            dgvLerDados.DataSource = dtLista;
            con.FecharConexao();

            FormatarDGV();
        }

        private void frFornecedores_Load(object sender, EventArgs e)
        {
            Listar();
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
            if (tbNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o Nome!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNome.Focus();
                return;
            }

            //CÓDIGO DO BOTÃO PARA SALVAR
            con.AbrirConexao();
            sql = $"INSERT INTO tblFornecedores VALUES('{tbNome.Text}', '{tbEndereco.Text}', '{mtbTelefone.Text}')";
            cmd = new OleDbCommand(sql, con.conexao);

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

        private void dgvLerDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btEditar.Enabled = true;
            btExcluir.Enabled = true;
            btSalvar.Enabled = false;
            btNovo.Enabled = true;
            HabilitarCampos();

            id = dgvLerDados.CurrentRow.Cells[0].Value.ToString();
            tbNome.Text = dgvLerDados.CurrentRow.Cells[1].Value.ToString();
            tbEndereco.Text = dgvLerDados.CurrentRow.Cells[2].Value.ToString();
            mtbTelefone.Text = dgvLerDados.CurrentRow.Cells[3].Value.ToString();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            // CÓDIGO DO BOTÃO PARA EDITAR
            con.AbrirConexao();
            sql = $"UPDATE tblFornecedores SET nome = '{tbNome.Text}', endereco = '{tbEndereco.Text}', telefone = '{mtbTelefone.Text}' WHERE idFornec = {id}";
            cmd = new OleDbCommand(sql, con.conexao);

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

        private void btExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja realmente excluir o registro?", "REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // CÓDIGO DO BOTÃO PARA EXCLUIR
                con.AbrirConexao();
                sql = $"DELETE FROM tblFornecedores WHERE idFornec = {id}";
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
