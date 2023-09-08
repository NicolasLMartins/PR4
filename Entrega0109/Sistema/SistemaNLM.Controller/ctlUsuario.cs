using SistemaNLM.Model;
using SistemaNLM.Tables;
using System;
using System.Collections.Generic;

namespace SistemaNLM.Controller
{
    public class ctlUsuario
    {
        public static int Inserir(tblUsuario objTabela)
        {
            return new modUsuario().Inserir(objTabela);
        }

        public List<tblUsuario> Lista()
        {
            return new modUsuario().Lista();
        }

        public tblUsuario Login(tblUsuario objTabela)
        {
            return new modUsuario().Login(objTabela);
        }
    }
}
