using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hotel_CLC.Cadastros
{
    public partial class frProdutos : Form
    {
        Conexao con = new Conexao();
        string sql;
        OleDbCommand cmd;
        string id;
        Boolean alterou;

        public frProdutos()
        {
            InitializeComponent();
        }

        private void CarregarComboBox()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM tblFornecedores ORDER BY nome asc";
            cmd = new OleDbCommand(sql, con.conexao);
            OleDbDataAdapter daLista = new OleDbDataAdapter();
            daLista.SelectCommand = cmd;
            DataTable dtLista = new DataTable();
            daLista.Fill(dtLista);
            cbFornecedor.DataSource = dtLista;
            cbFornecedor.ValueMember = "idFornec";
            cbFornecedor.DisplayMember = "nome";
            con.FecharConexao();
        }

        private void FormatarDGV()
        {
            dgvLerDados.Columns[0].HeaderText = "Código";
            dgvLerDados.Columns[1].HeaderText = "Nome";
            dgvLerDados.Columns[2].HeaderText = "Descrição";
            dgvLerDados.Columns[3].HeaderText = "Estoque";
            dgvLerDados.Columns[4].HeaderText = "Fornecedor";
            dgvLerDados.Columns[5].HeaderText = "Valor venda";
            dgvLerDados.Columns[6].HeaderText = "Valor compra";
            dgvLerDados.Columns[7].HeaderText = "Data";
            dgvLerDados.Columns[8].HeaderText = "Imagem";
            dgvLerDados.Columns[8].HeaderText = "ID Fornecedor";

            dgvLerDados.Columns[0].Visible = false;
            dgvLerDados.Columns[8].Visible = false;
            dgvLerDados.Columns[9].Visible = false;

            dgvLerDados.Columns[3].Width = 60;
            dgvLerDados.Columns[5].Width = 90;
            dgvLerDados.Columns[6].Width = 95;
            dgvLerDados.Columns[7].Width = 90;
        }

        private void Listar()
        {
            con.AbrirConexao();
            sql = "SELECT prod.idProd, prod.nome, prod.descricao, prod.estoque, prod.fornecedor, prod.valor_venda, "
+ "prod.valor_compra, prod.data, prod.imagem, fornec.nome, fornec.telefone "
+ "FROM tblProdutos as prod INNER JOIN tblFornecedores as fornec "
+ "ON prod.fornecedor = fornec.idFornec ORDER BY prod.nome ASC";
            cmd = new OleDbCommand(sql, con.conexao);
            OleDbDataAdapter daLista = new OleDbDataAdapter();
            daLista.SelectCommand = cmd;
            DataTable dtLista = new DataTable();
            daLista.Fill(dtLista);
            dgvLerDados.DataSource = dtLista;
            con.FecharConexao();

            FormatarDGV();
        }

        private void BuscarPorNome()
        {
            con.AbrirConexao();
            sql = "SELECT prod.idProd, prod.nome, prod.descricao, prod.estoque, prod.fornecedor, prod.valor_venda, "
+ "prod.valor_compra, prod.data, prod.imagem, fornec.nome, fornec.telefone "
+ "FROM tblProdutos as prod INNER JOIN tblFornecedores as fornec "
+ "ON prod.fornecedor = fornec.idFornec ORDER BY prod.nome ASC";
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
            tbDescricao.Enabled = true;
            tbValor.Enabled = true;
            cbFornecedor.Enabled = true;
            //tbEstoque.Enabled = true;

            tbNome.Focus();
            btAdicionarImg.Enabled = true;
        }
        private void DesabilitarCampos()
        {
            tbNome.Enabled = false;
            tbDescricao.Enabled = false;
            tbValor.Enabled = false;
            cbFornecedor.Enabled = false;
            tbEstoque.Enabled = false;
            btAdicionarImg.Enabled = false;
        }

        private void LimparCampos()
        {
            tbNome.Clear();
            tbDescricao.Clear();
            tbValor.Clear();
            tbEstoque.Clear();
            LimparImagem();
        }

        private void LimparImagem()
        {
            pbImagem.Image = Properties.Resources.noimageCrop;
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            if (cbFornecedor.Text == "")
            {
                MessageBox.Show("Cadastre antes um fornecedor!");
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

            if (tbValor.Text == "")
            {
                MessageBox.Show("Preencha o Valor!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbValor.Focus();
                return;
            }

            //CÓDIGO DO BOTÃO PARA SALVAR
            con.AbrirConexao();

            double valor_venda = 0.0;

            sql = $"INSERT INTO tblProdutos VALUES('{tbNome.Text}', '{tbDescricao.Text}', '{tbEstoque.Text}', '{cbFornecedor.SelectedValue}', '{tbValor.Text.Replace(",", ".")}', '{valor_venda}', '{DateTime.Today}', '{pbImagem.ImageLocation}')";

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
            LimparImagem();
            Listar();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            // CÓDIGO DO BOTÃO PARA EDITAR
            con.AbrirConexao();

            if (alterou == true)
            {
                sql = $"UPDATE tblProdutos SET nome = '{tbNome.Text}', descricao = '{tbDescricao.Text}', estoque = '{tbEstoque.Text}', fornecedor = '{cbFornecedor.SelectedValue}', valor_venda = '{decimal.Parse(tbValor.Text.Replace(",", "."))}', imagem = '{pbImagem.ImageLocation}' WHERE idProd = {id}";

                cmd = new OleDbCommand(sql, con.conexao);
            }
            else
            {
                sql = $"UPDATE tblProdutos SET nome = '{tbNome.Text}', descricao = '{tbDescricao.Text}', estoque = '{tbEstoque.Text}', fornecedor = '{cbFornecedor.SelectedValue}', valor_venda = '{decimal.Parse(tbValor.Text.Replace(",", "."))}' WHERE idProd = {id}";

                cmd = new OleDbCommand(sql, con.conexao);
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
            LimparImagem();
            alterou = false;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja realmente excluir o registro?", "REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // CÓDIGO DO BOTÃO PARA EXCLUIR
                con.AbrirConexao();
                sql = $"DELETE FROM tblProdutos WHERE idProd = {id}";
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
                LimparImagem();
                Listar();
            }
        }

        private void btAdicionarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog imgDialog = new OpenFileDialog();

            imgDialog.Filter = "Arquivos de imagem JPEG(*.jpeg) |*.jpeg|Arquivos PNG(*.png) |*.png|Todos os arquivos (*.*) |*.*";

            if (imgDialog.ShowDialog() == DialogResult.OK)
            {
                string foto = imgDialog.FileName.ToString();
                //MessageBox.Show(foto);

                pbImagem.ImageLocation = foto;
            }
        }

        private void frProdutos_Load(object sender, EventArgs e)
        {
            Listar();
            LimparImagem();
            CarregarComboBox();
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
            tbDescricao.Text = dgvLerDados.CurrentRow.Cells[2].Value.ToString();
            tbEstoque.Text = dgvLerDados.CurrentRow.Cells[3].Value.ToString();
            cbFornecedor.Text = dgvLerDados.CurrentRow.Cells[4].Value.ToString();
            tbValor.Text = dgvLerDados.CurrentRow.Cells[5].Value.ToString();
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarPorNome();
        }
    }
}
