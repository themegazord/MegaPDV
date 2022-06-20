using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            return new NpgsqlConnection($"Server={servidor};User Id={usuario};Password={senha};Database={banco}");
        }


        static NpgsqlConnection conn = new NpgsqlConnection($"Server={ConexaoAtiva.Servidor};User Id={ConexaoAtiva.Usuario};Password={ConexaoAtiva.Senha};Database={ConexaoAtiva.Banco}");

        public static DataTable select(string sql)
        {
            NpgsqlDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = sql;
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);
                    conn.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show($"ERRO DE CONSULTA NO BANCO DE DADOS!\n{ex}", "Erro de Consulta");
                return dt;
            }
            finally
            {
                conn.Close();
            }
        }
        public static void insert(string sql)
        {
            try
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show($"ERRO DE INSERÇÃO NO BANCO DE DADOS!\n{ex}", "Erro de Inserção");
            }
        }
        public static void delete(string sql)
        {
            try
            {
                using (var cmd= conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText= sql;
                    cmd.ExecuteNonQuery();
                }
            }catch (Exception ex)
            {
                MessageBox.Show($"ERRO DE DELEÇÃO DO BANCO DE DADOS!\n{ex.Message}", "Erro de Deleção");
            }
            finally
            {
                conn.Close();
            }
        }

        public static void update(string sql)
        {
            try
            {
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"ERRO DE ATUALIZAÇÃO DE DADOS.\n{ex.Message}", "Erro de atualização");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
