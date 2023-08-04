namespace CRUD_TresCamadas
{
    public class Modelo_Cliente
    {
        private int codigo;
        private string nome;

        public int Codigo
        {
            set { Codigo = value; }
            get { return Codigo;}
        }

        public string Nome
        {
            set { Nome = value; }
            get { return Nome; }
        }
    }
}
