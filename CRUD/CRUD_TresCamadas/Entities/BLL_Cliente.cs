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

        public void GravaClienteDal(Modelo_Cliente cliente)
        {
            try
            {
                dalCli = new DAL_Cliente();
                dalCli.GravaCliente(cliente);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public void ExcluiClienteDal(Modelo_Cliente cliente)
        {
            try
            {
                dalCli = new DAL_Cliente();
                dalCli.ExcluiCliente(cliente);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public void AtualizaClienteDal(Modelo_Cliente cliente)
        {
            try
            {
                dalCli = new DAL_Cliente();
                dalCli.AtualizaCliente(cliente);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }

        public Modelo_Cliente PesquisaClienteDal(string pesquisa)
        {
            try
            {
                dalCli = new DAL_Cliente();
                return dalCli.pesquisaCliente(pesquisa);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
    }
}
