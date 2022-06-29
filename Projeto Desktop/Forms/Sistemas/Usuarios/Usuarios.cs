using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Desktop
{
    public partial class Usuarios : Form
    {
        DataTable dt = new DataTable();
        public Usuarios()
        {
            InitializeComponent();
        }

        public void Carrega_Dgv()
        {
            StringBuilder sql = new StringBuilder(@"SELECT codusu as ""Código"", nomusu as ""Usuário"", nomcompusu as ""Nome do Usuario"" FROM cadusu where");
            if (tb_codusu.Text != "")
            {
                sql.Append($@" codusu = '{tb_codusu.Text}' and");
            }
            if (tb_nomusu.Text != "")
            {
                sql.Append($@" nomusu like '%{tb_nomusu.Text}%' and");
            }
            if (rb_ativo.Checked)
            {
                sql.Append($@" ativo = 'S'");
            }
            if (rb_inativo.Checked)
            {
                sql.Append($@" ativo = 'N'");
            }

            dgv_usuarios.DataSource = Connection.select(sql.ToString());
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            Carrega_Dgv();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            Carrega_Dgv();
        }


        private void msi_novo_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManipulaUsuario mu = new ManipulaUsuario();
            mu.FormClosed += (s, args) => this.Show();
            mu.FormClosed += (s, args) => this.Carrega_Dgv();
            mu.Text = "Cadastro de Usuário";
            mu.ShowDialog();
        }

        private void msi_editar_Click(object sender, EventArgs e)
        {
            try
            {
                string codusu = dgv_usuarios.SelectedRows[0].Cells[0].Value.ToString();
                /*                dt = Connection.select($@" SELECT cadusu.codusu,
                                                    cadusu.nomusu,
                                                    cadusu.senusu,
                                                    COALESCE(cadusu.nomcompusu, ''::character varying) AS coa_nomcomp,
                                                    cadusu.ativo,
                                                    COALESCE(cadusu.emailusu, ''::character varying) AS coa_emailusu,
                                                    COALESCE(cadusu.telusu, ''::character varying) AS coa_telusu,
                                                    COALESCE(cadusu.endusu, ''::character varying) AS coa_endusu,
                                                    COALESCE(cadusu.numendusu, ''::character varying) AS coa_numenusu,
                                                    COALESCE(cadusu.baiendusu, ''::character varying) AS coa_baiendusu,
                                                    COALESCE(cadusu.complendusu, ''::character varying) AS coa_complendusu,
                                                    COALESCE(cadusu.cependusu, ''::character varying) AS coa_cependusu
                                                   FROM cadusu where codusu = {codusu};");*/
                dt = Connection.select($@"select * from cadusu where codusu = {codusu}");
                string nomcompusu = ConverteReader.ConverteString(dt.Rows[0].ItemArray[3]);
                string nomusu = ConverteReader.ConverteString(dt.Rows[0].ItemArray[1]);
                string senusu = ConverteReader.ConverteString(dt.Rows[0].ItemArray[2]);
                string emailusu = ConverteReader.ConverteString(dt.Rows[0].ItemArray[5]);
                string telusu = ConverteReader.ConverteString(dt.Rows[0].ItemArray[6]);
                string endusu = ConverteReader.ConverteString(dt.Rows[0].ItemArray[7]);
                string numendusu = ConverteReader.ConverteString(dt.Rows[0].ItemArray[8]);
                string baiendusu = ConverteReader.ConverteString(dt.Rows[0].ItemArray[9]);
                string complendusu = ConverteReader.ConverteString(dt.Rows[0].ItemArray[10]);
                string cependusu = ConverteReader.ConverteString(dt.Rows[0].ItemArray[11]);
                char ativo = char.Parse(dt.Rows[0].ItemArray[4].ToString());
                int ID = ConverteReader.ConverteInt(dt.Rows[0].ItemArray[0]);

                ManipulaUsuario mu;
                mu = new ManipulaUsuario(nomcompusu, nomusu, senusu, emailusu, telusu, endusu, numendusu, baiendusu, complendusu, cependusu, ativo, ID);

                this.Hide();
                mu.FormClosed += (s, args) => this.Show();
                mu.FormClosed += (s, args) => this.Carrega_Dgv();
                mu.Text = "Edição de usuário";
                mu.ShowDialog();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Selecione um usuário válido", "Erro de seleção");
                return;
            }
        }

        private void msi_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                string codusu = dgv_usuarios.SelectedRows[0].Cells[0].Value.ToString();
                string sql = $"delete from cadusu where codusu = {codusu}";
                Connection.delete(sql);
                MessageBox.Show("Usuário deletado com sucesso.");
            } catch
            {
                return;
            }
            finally
            {
                Carrega_Dgv();
            }
        }
    }
}
