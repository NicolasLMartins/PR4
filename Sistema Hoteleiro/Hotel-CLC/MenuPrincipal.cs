using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_CLC
{
    public partial class frMenuPrincipal : Form
    {
        public frMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frMenuPrincipal_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastros.frFuncionarios frFunc = new Cadastros.frFuncionarios();
            frFunc.ShowDialog();
        }

        private void frMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
