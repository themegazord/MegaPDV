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
    public partial class SubGrupo : Form
    {
        public string SelectedRow = "";
        public SubGrupo()
        {
            InitializeComponent();
            btn_extrair.Hide();
        }
        public SubGrupo(bool extrai = false) : this()
        {
            if (extrai)
            {
                btn_extrair.Show();
            }
        }

        public void AtualizaDGV()
        {
            StringBuilder sql = new StringBuilder($@"select cod_subgrupo as ""Código"", nome_subgrupo as ""Nome do Grupo"", stasubgrupro as ""Status"" from cadsubgrupo");
            string AndWhere = " where ";

            if (tb_codigo.Text != "")
            {
                sql.Append($@"{AndWhere}cod_subgrupo = {tb_codigo.Text}");
                AndWhere = " and ";

                if (rb_ativo.Checked)
                {
                    sql.Append($@"{AndWhere}stasubgrupro = 'A'");
                    AndWhere = " and ";
                }
                else if (rb_inativo.Checked)
                {
                    sql.Append($@"{AndWhere}stasubgrupro = 'I'");
                    AndWhere = " and ";
                }
                else if (rb_todos.Checked)
                {
                    sql.Append($@"{AndWhere}stasubgrupro in ('A', 'I')");
                    AndWhere = " and ";
                }
            }
            else
            {
                sql.Append($@"{AndWhere}nome_subgrupo like '%{tb_nome.Text}%'");
                AndWhere = " and ";

                if (rb_ativo.Checked)
                {
                    sql.Append($@"{AndWhere}stasubgrupro = 'A'");
                    AndWhere = " and ";
                }
                else if (rb_inativo.Checked)
                {
                    sql.Append($@"{AndWhere}stasubgrupro = 'I'");
                    AndWhere = " and ";
                }
                else if (rb_todos.Checked)
                {
                    sql.Append($@"{AndWhere}stasubgrupro in ('A', 'I')");
                    AndWhere = " and ";
                }
            }
            dgv_subgrupos.DataSource = Connection.select(sql.ToString());
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            AtualizaDGV();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManipulaSubGrupo msg = new ManipulaSubGrupo();
            msg.FormClosed += (s, args) => this.AtualizaDGV();
            msg.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = dgv_subgrupos.SelectedRows[0].Cells[0].Value.ToString();
            ManipulaSubGrupo msg = new ManipulaSubGrupo(id);
            msg.FormClosed += (s, args) => this.AtualizaDGV();
            msg.ShowDialog();
        }

        private void btn_extrair_Click(object sender, EventArgs e)
        {
            SelectedRow = dgv_subgrupos.SelectedRows[0].Cells[0].Value.ToString();
            this.Close();
        }
    }
}
