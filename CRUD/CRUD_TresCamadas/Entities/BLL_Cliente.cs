using System;
using System.Data;

namespace CRUD_TresCamadas
{
    public class BLL_Cliente
    {
        DAL_Cliente dalCli = null;

        public DataTable ListaClienteDal()
        {
            DataTable dt = new DataTable();

            try
            {
                dalCli = new DAL_Cliente();
                dt = dalCli.ListaClientes();
            }
            catch (Exception erro)
            {

                throw erro;
            }

            return dt;
        }
    }
}
