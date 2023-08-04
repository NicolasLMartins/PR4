using System;
using System.Data;
using System.Data.SqlClient;

namespace CRUD_TresCamadas
{
    public class DAL_Cliente
    {
        private string con_SQLServer = @"Data Source = .\SQLEXPRESS; Initial Catalog = Academia2023; 
                                 User id = sa; pwd = sa;";

        SqlConnection conexao = null;

        public DataTable ListaClientes()
        {
            try
            {
                conexao = new SqlConnection(con_SQLServer);
                SqlCommand sql = new SqlCommand("SELECT * FROM tbCliente", conexao);

                SqlDataAdapter daCliente = new SqlDataAdapter();
                daCliente.SelectCommand = sql;

                DataTable dtCliente = new DataTable();
                daCliente.Fill(dtCliente);
                return dtCliente;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        
    }
}
