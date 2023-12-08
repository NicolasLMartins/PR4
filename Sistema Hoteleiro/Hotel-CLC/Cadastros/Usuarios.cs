using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_CLC.Cadastros
{
    public partial class frUsuarios : Form
    {
        Conexao con = new Conexao();
        string sql;
        OleDbCommand cmd;
        string id;

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
            sql = $"INSERT INTO tblUsuarios VALUES('{tbNome.Text}', '{cbCargo.Text}', '{tbUsuario.Text}', '{tbSenha.Text}', '{DateTime.Now}')";
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
    }
}
