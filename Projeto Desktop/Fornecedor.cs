using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Desktop.Rel;

namespace Projeto_Desktop
{
    public partial class Fornecedor : Form
    {
        DataTable dt = new DataTable();
        public Fornecedor()
        {
            InitializeComponent();
        }

        private void AtualizaDgv()
        {
            StringBuilder sql = new StringBuilder($@"select codfor as ""Código"", razaosocialfor as ""Razão Social"", nomefantasia_fornecedor as ""Nome Fantasia"", cnpj_fornecedor as ""CNPJ"", endereco_fornecedor as ""Endereço"", telefone1 as ""Telefone"" from cadfor");
            string AndWhere = " where ";
            if (tb_codigo_fornecedor.Text != "")
            {
                sql.Append($@"{AndWhere} codfor = {tb_codigo_fornecedor.Text}");
                AndWhere = " and ";

                if (rb_ativo.Checked)
                {
                    sql.Append($@"{AndWhere} ativo = 'A'");
                    AndWhere = " and ";
                }
                else if (rb_inativo.Checked)
                {
                    sql.Append($@"{AndWhere} ativo = 'I'");
                    AndWhere = " and ";
                }
                else if (rb_todos.Checked)
                {
                    sql.Append($@"{AndWhere} ativo in ('A', 'I')");
                    AndWhere = " and ";
                }
            }
            else
            {
                if (cb_alvo.SelectedIndex == 0)
                {
                    sql.Append($@"{AndWhere} razaosocialfor like '%{tb_pesquisa}%'");
                    AndWhere = " and ";
                }
                else if (cb_alvo.SelectedIndex == 1)
                {
                    sql.Append($@"{AndWhere} cnpj_fornecedor like '%{tb_pesquisa}%'");
                    AndWhere = " and ";
                }
                else if (cb_alvo.SelectedIndex == 2)
                {
                    sql.Append($@"{AndWhere} endereco_fornecedor like '%{tb_pesquisa}%'");
                    AndWhere = " and ";
                }
                else if (cb_alvo.SelectedIndex == 3)
                {
                    sql.Append($@"{AndWhere} telefone1 like '%{tb_pesquisa}%'");
                    AndWhere = " and ";
                }
                if (rb_ativo.Checked)
                {
                    sql.Append($@"{AndWhere} ativo = 'A'");
                    AndWhere = " and ";
                }
                else if (rb_inativo.Checked)
                {
                    sql.Append($@"{AndWhere} ativo = 'I'");
                    AndWhere = " and ";
                }
                else if (rb_todos.Checked)
                {
                    sql.Append($@"{AndWhere} ativo in ('A', 'I')");
                    AndWhere = " and ";
                }
            }
            dgv_fornecedor.DataSource = Connection.select(sql.ToString());
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManipulaFornecedor mf = new ManipulaFornecedor();
            mf.FormClosed += (s, args) => this.Show();
            mf.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $@"select * from cadfor where codfor = {dgv_fornecedor.SelectedRows[0].Cells[0].Value.ToString()}";
                this.Hide();
                ManipulaFornecedor mf = new ManipulaFornecedor(sql);
                mf.FormClosed += (s, args) => this.Show();
                mf.FormClosed += (s, args) => this.AtualizaDgv();
                mf.ShowDialog();
            } catch (Exception ex)
            {
                MessageBox.Show("Selecione um fornecedor válido", "Erro");
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            AtualizaDgv();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dgv_fornecedor.SelectedRows[0].Cells[0].Value.ToString();
                string sql = $@"delete from cadfor where codfor = {id}";
                Connection.delete(sql);
                MessageBox.Show("Fornecedor foi deletado","Sucesso");
                AtualizaDgv();
            }catch(Exception ex)
            {
                MessageBox.Show("Excluir o fornecedor.", "Erro");
                return;
            }
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rel.RelacaoFornecedor rf = new RelacaoFornecedor();
            rf.FormClosed += (s, args) => this.Show();
            rf.ShowDialog();
        }
    }
}
