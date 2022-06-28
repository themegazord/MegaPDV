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
    public partial class Produto : Form
    {
        DataTable dt = new DataTable();
        public Produto()
        {
            InitializeComponent();
            cb_status.SelectedIndex = 0;
        }

        public void AtualizaDGV()
        {
            StringBuilder sql = new StringBuilder($@"
                select 
                    c.cod_produto as ""Código"", 
                    c.nome_produto as ""Nome do Produto"", 
                    c.valor_produto as ""Valor de Venda"", 
                    c.custo_produto as ""Custo do Produto"", 
                    cg.nome_grupo as ""Grupo"", 
                    csg.nome_subgrupo as ""Sub-Grupo"",
                    cu.desc_unidade as ""Unidade"",  
                    c.estoque as ""Estoque"" 
                from cadpro c
                inner join cadgrupo cg on c.cod_grupo = cg.cod_grupo
                inner join cadsubgrupo csg on c.cod_subgrupo = csg.cod_subgrupo
                inner join cadunidade cu on c.cod_unidade = cu.cod_unidade");
            string AndWhere = " where ";

            if(tb_codigo.Text != "")
            {
                sql.Append($@"{AndWhere} c.cod_produto = {tb_codigo.Text}");
                AndWhere = " and ";

                if (cb_status.SelectedIndex == 0)
                {
                    sql.Append($@"{AndWhere} c.stapro in ('A','I')");
                    AndWhere = " and ";
                } else if (cb_status.SelectedIndex == 1)
                {
                    sql.Append($@"{AndWhere} c.stapro = 'A'");
                    AndWhere = " and ";
                } else if (cb_status.SelectedIndex == 2)
                {
                    sql.Append($@"{AndWhere} c.stapro = 'I'");
                    AndWhere = " and ";
                }

                if (cb_tipo.SelectedIndex == 0) // Produto Acabado
                {
                    sql.Append($@"{AndWhere} c.tipo_produto = 'A'");
                    AndWhere = " and ";
                } else if (cb_tipo.SelectedIndex == 1) // Matéria Prima
                {
                    sql.Append($@"{AndWhere} c.tipo_produto = 'M'");
                    AndWhere = " and ";
                } else if (cb_tipo.SelectedIndex == 2) // Embalagem
                {
                    sql.Append($@"{AndWhere} c.tipo_produto = 'E'");
                    AndWhere = " and ";
                }

                if (tb_codigo_grupo.Text != "")
                {
                    sql.Append($@"{AndWhere} c.cod_grupo = {tb_codigo_grupo.Text}");
                    AndWhere = " and ";
                }

                if (tb_codigo_subgrupo.Text != "")
                {
                    sql.Append($@"{AndWhere} c.cod_subgrupo = {tb_codigo_subgrupo.Text}");
                    AndWhere = " and ";
                }
            }else
            {
                sql.Append($@"{AndWhere} c.nome_produto like '%{tb_descricao.Text}%'");
                AndWhere = " and ";

                if (cb_status.SelectedIndex == 0)
                {
                    sql.Append($@"{AndWhere} c.stapro in ('A','I')");
                    AndWhere = " and ";
                }
                else if (cb_status.SelectedIndex == 1)
                {
                    sql.Append($@"{AndWhere} c.stapro = 'A'");
                    AndWhere = " and ";
                }
                else if (cb_status.SelectedIndex == 2)
                {
                    sql.Append($@"{AndWhere} c.stapro = 'I'");
                    AndWhere = " and ";
                }

                if (cb_tipo.SelectedIndex == 0) // Produto Acabado
                {
                    sql.Append($@"{AndWhere} c.tipo_produto = 'A'");
                    AndWhere = " and ";
                }
                else if (cb_tipo.SelectedIndex == 1) // Matéria Prima
                {
                    sql.Append($@"{AndWhere} c.tipo_produto = 'M'");
                    AndWhere = " and ";
                }
                else if (cb_tipo.SelectedIndex == 2) // Embalagem
                {
                    sql.Append($@"{AndWhere} c.tipo_produto = 'E'");
                    AndWhere = " and ";
                }

                if (tb_codigo_grupo.Text != "")
                {
                    sql.Append($@"{AndWhere} c.cod_grupo = {tb_codigo_grupo.Text}");
                    AndWhere = " and ";
                }

                if (tb_codigo_subgrupo.Text != "")
                {
                    sql.Append($@"{AndWhere} c.cod_subgrupo = {tb_codigo_subgrupo.Text}");
                    AndWhere = " and ";
                }
            }
            dgv_produtos.DataSource = Connection.select(sql.ToString());
        }


        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            AtualizaDGV();
        }

        private void btn_cod_grupo_Click(object sender, EventArgs e)
        {
            Grupo g = new Grupo(true);
            g.FormClosed += (s, args) => tb_codigo_grupo.Text = g.SelectedRow;
            g.ShowDialog();
        }

        private void btn_subgrupo_Click(object sender, EventArgs e)
        {
            SubGrupo sg = new SubGrupo(true);
            sg.FormClosed += (s, args) => tb_codigo_subgrupo.Text = sg.SelectedRow;
            sg.ShowDialog();
        }

        private void tb_codigo_grupo_TextChanged(object sender, EventArgs e)
        {
            if(tb_codigo_grupo.Text == "")
            {
                tb_codigo_grupo.Focus();
                tb_codigo_grupo.Clear();
                tb_nome_grupo.Clear();
                return;
            }
            try
            {
                string sql = $@"select nome_grupo from cadgrupo where cod_grupo = {tb_codigo_grupo.Text}";
                dt = Connection.select(sql);
                tb_nome_grupo.Text = dt.Rows[0].ItemArray[0].ToString();
            } catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Código inexistente, verifique melhor!!!", "Atenção");
                Grupo g = new Grupo(true);
                g.FormClosed += (s, args) => tb_codigo_grupo.Text = g.SelectedRow;
                g.ShowDialog();
            }
        }

        private void tb_codigo_subgrupo_TextChanged(object sender, EventArgs e)
        {
            if (tb_codigo_subgrupo.Text == "")
            {
                tb_codigo_subgrupo.Focus();
                tb_codigo_subgrupo.Clear();
                tb_nome_subgrupo.Clear();
                return;
            }
            try
            {
                string sql = $@"select nome_subgrupo from cadsubgrupo where cod_subgrupo = {tb_codigo_subgrupo.Text}";
                dt = Connection.select(sql);
                tb_nome_subgrupo.Text = dt.Rows[0].ItemArray[0].ToString();
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Código inexistente, verifique melhor!!!", "Atenção");
                SubGrupo sg = new SubGrupo(true);
                sg.FormClosed += (s, args) => tb_codigo_subgrupo.Text = sg.SelectedRow;
                sg.ShowDialog();
            }
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManipulaProduto mp = new ManipulaProduto();
            mp.ShowDialog();
        }
    }
}
