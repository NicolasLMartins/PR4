using SistemaNLM.Tables;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System;
using System.Runtime.InteropServices.ComTypes;

namespace SistemaNLM.Model
{
    public class modUsuario
    {
        public int Editar(tblUsuario objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Banco;

                SqlCommand sql = new SqlCommand();

                sql.CommandType = CommandType.Text;

                con.Open();

                sql.CommandText = "UPDATE tblUsuario SET nome = @Nome, usuario = @Usuario, senha = @Senha WHERE id = @Id";

                sql.Parameters.Add("@Id", SqlDbType.Int).Value = objTabela.Id;
                sql.Parameters.Add("@Nome", SqlDbType.VarChar).Value = objTabela.Nome;
                sql.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = objTabela.Usuario;
                sql.Parameters.Add("@Senha", SqlDbType.VarChar).Value = objTabela.Senha;

                sql.Connection = con;

                int quantidade = sql.ExecuteNonQuery();

                return quantidade;
            }
        }

        public int Excluir(tblUsuario objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Banco;

                SqlCommand sql = new SqlCommand();

                sql.CommandType = CommandType.Text;

                con.Open();

                sql.CommandText = "DELETE FROM tblUsuario WHERE id = @Id";

                sql.Parameters.Add("@Id", SqlDbType.Int).Value = objTabela.Id;

                sql.Connection = con;

                int quantidade = sql.ExecuteNonQuery();

                return quantidade;
            }
        }

        public int Inserir(tblUsuario objTabela)
        {
            //Sintaxe do "using" precisa de um OBJETO
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Banco;

                SqlCommand sql = new SqlCommand();

                sql.CommandType = CommandType.Text;

                con.Open();

                sql.CommandText = "INSERT INTO tblUsuario ([nome], [usuario], [senha]) VALUES (@Nome, @Usuario, @Senha)";

                sql.Parameters.Add("@Nome", SqlDbType.VarChar).Value = objTabela.Nome;
                sql.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = objTabela.Usuario;
                sql.Parameters.Add("@Senha", SqlDbType.VarChar).Value = objTabela.Senha;

                sql.Connection = con;

                int quantidade = sql.ExecuteNonQuery();

                return quantidade;
            }
        }

        public List<tblUsuario> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Banco;

                SqlCommand sql = new SqlCommand();

                sql.CommandType = CommandType.Text;

                con.Open();

                sql.CommandText = "SELECT * FROM tblUsuario ORDER BY id DESC";

                sql.Connection = con;

                SqlDataReader dr;

                List<tblUsuario> lista = new List<tblUsuario>();

                dr = sql.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        tblUsuario dado = new tblUsuario();

                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Usuario = Convert.ToString(dr["usuario"]);
                        dado.Senha = Convert.ToString(dr["senha"]);

                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }

        public tblUsuario Login(tblUsuario objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Banco;

                SqlCommand sql = new SqlCommand();

                sql.CommandType = CommandType.Text;

                con.Open();

                sql.CommandText = "SELECT * FROM tblUsuario WHERE usuario = @Usuario AND senha = @Senha";

                sql.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = objTabela.Usuario;
                sql.Parameters.Add("@Senha", SqlDbType.VarChar).Value = objTabela.Senha;

                sql.Connection = con;

                SqlDataReader dr;

                dr = sql.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        tblUsuario dado = new tblUsuario();

                        dado.Usuario = Convert.ToString(dr["usuario"]);
                        dado.Senha = Convert.ToString(dr["senha"]);
                    }
                }
                else
                {
                    objTabela.Usuario = null;
                    objTabela.Senha = null;
                }

                return objTabela;
            }
        }
    }
}
