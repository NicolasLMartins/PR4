using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_CLC
{
    internal class Conexao
    {
        string conectarUS = (@"Provider = SQLOLEDB;
                               Data Source = COMP7L3\SQLEXPRESS;
                               Initial Catalog = Hotel-CLC;
                               User ID = sa;
                               Password = sa;");
        public OleDbConnection conexao = null;

        public void AbrirConexao()
        {
            try
            {
                conexao = new OleDbConnection(conectarUS);
                conexao.Open();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        
        public void FecharConexao()
        {
            try
            {
                conexao = new OleDbConnection(conectarUS);
                conexao.Close();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
