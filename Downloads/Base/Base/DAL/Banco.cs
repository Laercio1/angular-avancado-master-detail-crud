using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Banco
    {
        private static SqlConnection conexao;

        readonly SqlTransaction t = null;
        readonly SqlConnection cn = null;
        public Banco()
        {
            t = cn.BeginTransaction(IsolationLevel.Serializable);
            cn = new SqlConnection("");
        }

        public bool ExecutarComando(List<ComandoSQL> _cmd)
        {
            foreach (var item in _cmd)
            {
                item.Comando.Transaction = t;

                foreach (var p in item.Parametros)
                {
                    item.Comando.Parameters.AddWithValue(p.Parametro, p.Valor);
                }
                item.Comando.ExecuteNonQuery();
            }

            t.Commit();
            return true;

        }
        private static SqlConnection ConexaoBanco()
        {
            conexao = new SqlConnection("Data Source = NSYS-CDS-0301\\SQLDESENVOLVEDOR; Initial Catalog = Loja; Integrated Security = True");
            conexao.Open();
            return conexao;
        }
        public static DataTable ObterTodosUsuarios()
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Usuario";
                    da = new SqlDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;

                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }

        public static DataTable Consulta(string sql)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SqlDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static DataTable dql(string sql)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SqlDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
