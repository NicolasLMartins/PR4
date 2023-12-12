using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hotel_CLC
{
    public partial class frLogin : Form
    {
        Conexao con = new Conexao();

        public frLogin()
        {
            InitializeComponent();
            pnlLogin.Visible = false;
        }

        private void frLogin_Load(object sender, EventArgs e)
        {
            //pnlLogin.Location = new Point(0, 0);
            //pnlLogin.Location = new Point(this.Width / 2, this.Height / 2);
            //pnlLogin.Location = new Point(this.Width - 160, this.Height - 112);
            //pnlLogin.Location = new Point(this.Width / 2 - pnlLogin.BackgroundImage.Size.Width, this.Height / 2 - pnlLogin.BackgroundImage.Size.Height);
            //pnlLogin.Location = new Point(this.Width / 2 - pnlLogin.BackgroundImage.Width, this.Height / 2 - pnlLogin.BackgroundImage.Height);

            pnlLogin.Visible = true;
        }

        public void ChamarLogin()
        {
            if (tbUsuario.Text == "")
            {
                MessageBox.Show("Preencha o campo Usuário!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbUsuario.Focus();
                return;
            }

            if (tbSenha.Text == "")
            {
                MessageBox.Show("Preencha o campo Senha!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbSenha.Focus();
                return;
            }

            //AQUI SERA O CODIGO PARA O LOGIN
            OleDbCommand cmdVerificar;
            OleDbDataReader drDados;

            con.AbrirConexao();

            cmdVerificar = new OleDbCommand($"SELECT * FROM tblUsuarios WHERE usuario = '{tbUsuario.Text}' AND senha = '{tbSenha.Text}'", con.conexao);

            drDados = cmdVerificar.ExecuteReader();

            if (drDados.HasRows)
            {
                while (drDados.Read())
                {
                    Program.nomeUsuario = drDados["nome"].ToString();
                    Program.cargoUsuario = drDados["cargo"].ToString();

                    MessageBox.Show("con.nomeUsuario");
                }

                MessageBox.Show($"Bem-Vindo {Program.nomeUsuario}!", "LOGIN EFETUADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frMenuPrincipal frMenuPrinc = new frMenuPrincipal();
                Limpar();
                frMenuPrinc.Show();
            }
            else
            {
                MessageBox.Show("Nome do usuário ou senha incorreto!", "LOGIN NÃO EFETUADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbUsuario.Clear();
                tbUsuario.Focus();
                tbSenha.Clear();
            }

            con.FecharConexao();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            ChamarLogin();
        }

        private void Limpar()
        {
            tbUsuario.Clear();
            tbSenha.Clear();
        }

        private void frLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //MessageBox.Show("Tecla pressionada!");
                btLogin_Click(sender, e);
            }
        }

        private void frLogin_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; 
        }
    }
}
