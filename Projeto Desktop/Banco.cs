using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace Projeto_Desktop
{
    class Banco
    {
        
        private static NpgsqlConnection ConexaoBanco()
        {
            return Connection.GetConnection(ConexaoAtiva.Servidor, ConexaoAtiva.Usuario, ConexaoAtiva.Senha, ConexaoAtiva.Banco);
        }
        public static DataTable select(string sql)
        {
            NpgsqlDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new NpgsqlDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }
    }
}
