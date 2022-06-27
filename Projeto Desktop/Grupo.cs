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
    public partial class Grupo : Form
    {
        public static string SelectedRow = "";
        public Grupo()
        {
            InitializeComponent();
        }
        public Grupo(bool extrai) : this()
        {
            if (extrai)
            {
                SelectedRow = dgv_grupos.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        public void AtualizaDGV()
        {
            StringBuilder sql = new StringBuilder($@"select cod_grupo as ""Código"", nome_grupo as ""Nome do Grupo"", stagrupro as ""Status"" from cadgrupo");
            string AndWhere = " where ";

            if (tb_codigo.Text != "")
            {
                sql.Append($@"{AndWhere}cod_grupo = {tb_codigo.Text}");
                AndWhere = " and ";

                if (rb_ativo.Checked)
                {
                    sql.Append($@"{AndWhere}stagrupro = 'A'");
                    AndWhere = " and ";
                } else if (rb_inativo.Checked)
                {
                    sql.Append($@"{AndWhere}stagrupro = 'I'");
                    AndWhere = " and ";
                } else if (rb_todos.Checked)
                {
                    sql.Append($@"{AndWhere}stagrupro in ('A', 'I')");
                    AndWhere = " and ";
                }
            }
            else
            {
                sql.Append($@"{AndWhere}nome_grupo like '%{tb_nome.Text}%'");
                AndWhere = " and ";

                if (rb_ativo.Checked)
                {
                    sql.Append($@"{AndWhere}stagrupro = 'A'");
                    AndWhere = " and ";
                }
                else if (rb_inativo.Checked)
                {
                    sql.Append($@"{AndWhere}stagrupro = 'I'");
                    AndWhere = " and ";
                }
                else if (rb_todos.Checked)
                {
                    sql.Append($@"{AndWhere}stagrupro in ('A', 'I')");
                    AndWhere = " and ";
                }
            }
            dgv_grupos.DataSource = Connection.select(sql.ToString());
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            AtualizaDGV();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManipulaGrupo mg = new ManipulaGrupo();
            mg.FormClosed += (s, args) => this.AtualizaDGV();   
            mg.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id = dgv_grupos.SelectedRows[0].Cells[0].Value.ToString();
            ManipulaGrupo mg = new ManipulaGrupo(id);
            mg.FormClosed += (s, args) => this.AtualizaDGV();
            mg.Text = "Atualiza Grupo";
            mg.ShowDialog();
        }
    }
}
