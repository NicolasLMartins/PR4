using System;
using System.Windows.Forms;

namespace SistemaNLM.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            frmCadUsuario frmCadUsu = new frmCadUsuario();
            frmCadUsu.ShowDialog();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
