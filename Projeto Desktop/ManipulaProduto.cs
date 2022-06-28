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
    public partial class ManipulaProduto : Form
    {
        DataTable dt = new DataTable();
        public ManipulaProduto()
        {
            InitializeComponent();

            btn_atualizar.Hide();
            lb_mostra_id.Hide();
            lb_id.Hide();
            gb_status.Hide();
        }
        public ManipulaProduto(string id) : this()
        {
            DataTable dt2 = new DataTable();
            btn_salvar.Hide();

            btn_atualizar.Show();
            lb_mostra_id.Show();
            lb_id.Show();
            gb_status.Show();

            string sql = $@"select cod_grupo, cod_subgrupo, cod_unidade, nome_produto, estoque, valor_produto, custo_produto, tipo_produto, stapro from cadpro where cod_produto = {id}";

            dt2 = Connection.select(sql);
            lb_id.Text = id;

            tb_codigo_grupo.Text = dt2.Rows[0].ItemArray[0].ToString();
            tb_codigo_subgrupo.Text = dt2.Rows[0].ItemArray[1].ToString();
            tb_codigo_unidade.Text = dt2.Rows[0].ItemArray[2].ToString();
            tb_nome_produto.Text = dt2.Rows[0].ItemArray[3].ToString();
            tb_estoque.Text = dt2.Rows[0].ItemArray[4].ToString();
            tb_preco.Text = dt2.Rows[0].ItemArray[5].ToString();
            tb_custo.Text = dt2.Rows[0].ItemArray[6].ToString();
            if(char.Parse(dt2.Rows[0].ItemArray[7].ToString()) == 'A') // Produto Acabado
            {
                cb_tipo.SelectedIndex = 0;
            } else if(char.Parse(dt2.Rows[0].ItemArray[7].ToString()) == 'M') // Matéria Prima
            {
                cb_tipo.SelectedIndex = 1;
            } else if(char.Parse(dt2.Rows[0].ItemArray[7].ToString()) == 'E') // Embalagem
            {
                cb_tipo.SelectedIndex = 2;
            }
            if(char.Parse(dt2.Rows[0].ItemArray[8].ToString()) == 'A')
            {
                rb_ativo.Checked = true;
            } else if (char.Parse(dt2.Rows[0].ItemArray[7].ToString()) == 'I')
            {
                rb_inativo.Checked = true;
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if(tb_codigo_grupo.Text == "" || tb_codigo_subgrupo.Text == "" || tb_codigo_unidade.Text == "" || tb_nome_produto.Text == "" || cb_tipo.SelectedIndex == -1)
            {
                MessageBox.Show("Alguns dos campos não estão preenchidos!!!", "Atenção");
                tb_nome_grupo.Focus();
                return;
            }
            StringBuilder sql = new StringBuilder($@"insert into cadpro (cod_grupo, cod_subgrupo, cod_unidade, nome_produto, tipo_produto, estoque, valor_produto, custo_produto) values (");
            sql.Append($@"{tb_codigo_grupo.Text},");
            sql.Append($@"{tb_codigo_subgrupo.Text},");
            sql.Append($@"{tb_codigo_unidade.Text},");
            sql.Append($@"'{tb_nome_produto.Text}',");
            if(cb_tipo.SelectedIndex == 0) // Produto Acabado
            {
                sql.Append($@"'A',");
            }else if (cb_tipo.SelectedIndex == 1) // Matéria Prima
            {
                sql.Append($@"'M',");
            }else if (cb_tipo.SelectedIndex == 2) // Embalagem
            {
                sql.Append($@"'E',");
            }
            sql.Append($@"{tb_estoque.Text},");
            sql.Append($@"{tb_preco.Text},");
            sql.Append($@"{tb_custo.Text})");

            Connection.insert(sql.ToString());
            MessageBox.Show("Produto cadastrado com sucesso!!!", "Sucesso");
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Unidade u = new Unidade(true);
            u.FormClosed += (s, args) => tb_codigo_unidade.Text = u.SelectedRow;
            u.ShowDialog();
        }

        private void tb_codigo_grupo_TextChanged(object sender, EventArgs e)
        {
            if (tb_codigo_grupo.Text == "")
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
            }
            catch (IndexOutOfRangeException ex)
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

        private void tb_codigo_unidade_TextChanged(object sender, EventArgs e)
        {
            if (tb_codigo_unidade.Text == "")
            {
                tb_codigo_unidade.Focus();
                tb_codigo_unidade.Clear();
                tb_nome_unidade.Clear();
            }
            try
            {
                string sql = $@"select desc_unidade from cadunidade where cod_unidade = {tb_codigo_unidade.Text}";
                dt = Connection.select(sql);
                tb_nome_unidade.Text = dt.Rows[0].ItemArray[0].ToString();
            }catch(IndexOutOfRangeException ex)
            {
                MessageBox.Show("Código inexistente, verifique melhor!!!", "Atenção");
                Unidade u = new Unidade(true);
                u.FormClosed += (s, args) => tb_codigo_unidade.Text = u.SelectedRow;
                u.ShowDialog();
            }
        }

        private void tb_estoque_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tb_estoque.Text, @"[^0-9]+(?=\.)(?=[0-9])"))
            {
                tb_estoque.Text = "";
            }
        }

        private void tb_preco_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tb_preco.Text, @"[^0-9]+(?=\.)(?=[0-9])"))
            {
                tb_preco.Text = "";
            }
        }

        private void tb_custo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tb_custo.Text, @"[^0-9]+(?=\.)(?=[0-9])"))
            {
                tb_custo.Text = "";
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (tb_codigo_grupo.Text == "" || tb_codigo_subgrupo.Text == "" || tb_codigo_unidade.Text == "" || tb_nome_produto.Text == "" || cb_tipo.SelectedIndex == -1)
            {
                MessageBox.Show("Alguns dos campos não estão preenchidos!!!", "Atenção");
                tb_nome_grupo.Focus();
                return;
            }

            StringBuilder sql = new StringBuilder("update cadpro set ");
            sql.Append($@"cod_grupo = {tb_codigo_grupo.Text},");
            sql.Append($@"cod_subgrupo = {tb_codigo_subgrupo.Text},");
            sql.Append($@"cod_unidade = {tb_codigo_unidade.Text},");
            sql.Append($@"nome_produto = '{tb_nome_produto.Text}',");
            sql.Append($@"estoque = {tb_estoque.Text.Replace(',', '.')},");
            sql.Append($@"valor_produto = {tb_preco.Text.Replace(',', '.')},");
            sql.Append($@"custo_produto = {tb_custo.Text.Replace(',', '.')},");
            if(cb_tipo.SelectedIndex == 0)
            {
                sql.Append($@"tipo_produto = 'A',");
            } else if (cb_tipo.SelectedIndex == 1)
            {
                sql.Append($@"tipo_produto = 'M',");
            }else if (cb_tipo.SelectedIndex == 2)
            {
                sql.Append($@"tipo_produto = 'E',");
            }
            if (rb_ativo.Checked)
            {
                sql.Append($@"stapro = 'A' ");
            } else if (rb_inativo.Checked)
            {
                sql.Append($@"stapro = 'I' ");
            }
            sql.Append($@"where cod_produto = {lb_id.Text}");
            Connection.update(sql.ToString());
            MessageBox.Show("Produto atualizado com sucesso", "Sucesso");
            this.Close();
        }
    }
}
