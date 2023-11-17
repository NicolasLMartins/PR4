using System;
using System.Windows.Forms;

namespace Hotel_CLC.Cadastros
{
    public partial class frProdutos : Form
    {
        public frProdutos()
        {
            InitializeComponent();
        }

        private void HabilitarCampos()
        {
            tbNome.Enabled = true;
            tbDescricao.Enabled = true;
            tbValor.Enabled = true;
            cbFornecedor.Enabled = true;
            tbEstoque.Enabled = true;

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

            MessageBox.Show("Registro salvo com sucesso!", "REGISTRO SALVO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btNovo.Enabled = true;

            btSalvar.Enabled = false;

            LimparCampos();
            DesabilitarCampos();
            LimparImagem();
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

            if (tbValor.Text == "")
            {
                MessageBox.Show("Preencha o Valor!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbValor.Focus();
                return;
            }

            // CÓDIGO DO BOTÃO PARA EDITAR

            MessageBox.Show("Registro editado com sucesso!", "REGISTRO EDITADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btNovo.Enabled = true;
            btEditar.Enabled = false;
            btExcluir.Enabled = false;

            LimparCampos();
            DesabilitarCampos();
            LimparImagem();
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
                LimparImagem();
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
    }
}
