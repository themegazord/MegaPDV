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
    public partial class Unidade : Form
    {
        public static string SelectedRow = "";
        public Unidade()
        {
            InitializeComponent();
        }

        public void AtualizaDGV()
        {
            StringBuilder sql = new StringBuilder($@"select cod_unidade as ""Código"", sigla_unidade as ""Sigla"", desc_unidade as ""Nome da Unidade"", staunidade as ""Status"" from cadunidade");
            string AndWhere = " where ";

            if(tb_codigo.Text != "")
            {
                sql.Append($@"{AndWhere} cod_unidade = {tb_codigo.Text}");
                AndWhere = " and ";

                if (rb_ativo.Checked)
                {
                    sql.Append($@"{AndWhere} staunidade = 'A'");
                    AndWhere = " and ";
                } else if (rb_inativo.Checked)
                {
                    sql.Append($@"{AndWhere} staunidade = 'I'");
                    AndWhere = " and ";
                }else if (rb_todos.Checked)
                {
                    sql.Append($@"{AndWhere} staunidade in ('A', 'I')");
                    AndWhere = " and ";
                }
            }else
            {
                sql.Append($@"{AndWhere} desc_unidade like '%{tb_nome.Text}%'");
                AndWhere = " and ";

                if (rb_ativo.Checked)
                {
                    sql.Append($@"{AndWhere} staunidade = 'A'");
                    AndWhere = " and ";
                }
                else if (rb_inativo.Checked)
                {
                    sql.Append($@"{AndWhere} staunidade = 'I'");
                    AndWhere = " and ";
                }
                else if (rb_todos.Checked)
                {
                    sql.Append($@"{AndWhere} staunidade in ('A', 'I')");
                    AndWhere = " and ";
                }
            }
            dgv_unidade.DataSource = Connection.select(sql.ToString());
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
            ManipulaUnidade mu = new ManipulaUnidade();
            mu.FormClosed += (s, args) => this.AtualizaDGV();
            mu.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectedRow = dgv_unidade.SelectedRows[0].Cells[0].Value.ToString();
            ManipulaUnidade mu = new ManipulaUnidade(SelectedRow);
            mu.FormClosed += (s, args) => this.AtualizaDGV();
            mu.Text = "Atualiza Unidade";
            mu.ShowDialog();
        }
    }
}
