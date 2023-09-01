namespace CRUD_TresCamadas
{
    public class Modelo_Cliente
    {
        private int codigo;
        private string nome;

        public int Codigo
        {
            set { codigo = value; }
            get { return codigo;}
        }

        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }
    }
}
