using SistemaNLM.Model;
using SistemaNLM.Tables;

namespace SistemaNLM.Controller
{
    public class ctlUsuario
    {
        public static int Inserir(tblUsuario objTabela)
        {
            return new modUsuario.Inserir(objTabela);
        }
    }
}
