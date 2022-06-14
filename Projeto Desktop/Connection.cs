using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Projeto_Desktop
{
    class Connection
    {
        public static bool TestConnection(string servidor, string usuario, string senha, string banco)
        {
            using (NpgsqlConnection con = GetConnection(servidor, usuario, senha, banco))
            {
                try
                {
                    con.Open();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static NpgsqlConnection GetConnection(string servidor, string usuario, string senha, string banco)
        {
            return new NpgsqlConnection($"Server={servidor};Port={5432};User Id={usuario};Password={senha};Database={banco}");
        }
    }
}
