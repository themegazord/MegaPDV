using System;
using Projeto_Desktop.Rel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Projeto_Desktop
{
    public partial class Clientes : Form
    {
        string caminhoProj = $@"C:\Users\SF\Desktop\Projeto Desktop\Projeto Desktop\Relatórios";
        public Clientes()
        {
            InitializeComponent();
            rb_ativo.Checked = true;
        }

        private void Atualizar_Dgv()
        {
            string codcli = tb_codigo_cliente.Text;
            string pesquisa = tb_pesquisa.Text;
            string codven = tb_cod_vendedor.Text;
            StringBuilder sql = new StringBuilder($@"select cod_cliente as ""Código"", nomcliente as ""Nome do Cliente"", nomsocialcliente as ""Nome Social"", cpf_cliente as ""CPF"", cnpjcliente as ""CNPJ"", endereco_cliente as ""Endereço"", telefone1 as ""Telefone Fixo"", telefone2 as ""Telefone Celular"", telefone3 as ""Telefone de Contato"", codvendedor as ""Código do Vendedor"" from cadcli");
            string AndWhere = " where ";
            if (tb_codigo_cliente.Text != "")
            {
                sql.Append($@"{AndWhere}cod_cliente = {tb_codigo_cliente}");
                AndWhere = " and ";

                if (rb_ativo.Checked)
                {
                    sql.Append($@"{AndWhere}status_cliente = 'A'");
                    AndWhere = " and ";
                }
                else if (rb_inativo.Checked)
                {
                    sql.Append($@"{AndWhere}status_cliente = 'I'");
                    AndWhere = " and ";
                }
                else if (rb_todos.Checked)
                {
                    sql.Append($@"{AndWhere}status_cliente in ('A', 'I')");
                    AndWhere = " and ";
                }
            } else
            {   
                if (cb_alvo.SelectedIndex == 0)
                {
                    sql.Append($@"{AndWhere}nomcliente like '%{pesquisa}%'");
                    AndWhere = " and ";
                } else if (cb_alvo.SelectedIndex == 1)
                {
                    sql.Append($@"{AndWhere}cpf_cliente like '%{pesquisa}%'");
                    AndWhere = " and ";
                } else if (cb_alvo.SelectedIndex == 2)
                {
                    sql.Append($@"{AndWhere}cnpjcliente like '%{pesquisa}%'");
                    AndWhere = " and ";
                } else if (cb_alvo.SelectedIndex == 3)
                {
                    sql.Append($@"{AndWhere}endereco_cliente like '%{pesquisa}%'");
                    AndWhere = " and ";
                } else if (cb_alvo.SelectedIndex == 4)
                {
                    sql.Append($@"{AndWhere}telefone1 like '%{pesquisa}%' or telefone2 like '%{pesquisa}%' or telefone3 like '%{pesquisa}%'");
                    AndWhere = " and ";
                }
                if (rb_ativo.Checked)
                {
                    sql.Append($@"{AndWhere}status_cliente = 'A'");
                    AndWhere = " and ";
                } else if (rb_inativo.Checked)
                {
                    sql.Append($@"{AndWhere}status_cliente = 'I'");
                    AndWhere = " and ";
                } else if (rb_todos.Checked)
                {
                    sql.Append($@"{AndWhere}status_cliente in ('A', 'I')");
                    AndWhere = " and ";
                }
                if (cb_pf.Checked)
                {
                    sql.Append($@"{AndWhere}tipo_cliente = 'F'");
                    AndWhere = " and ";
                }
                else if (cb_pj.Checked)
                {
                    sql.Append($@"{AndWhere}tipo_cliente = 'J'");
                    AndWhere = " and ";
                } else
                {
                    sql.Append($@"{AndWhere}tipo_cliente in ('F', 'J')");
                    AndWhere = " and ";
                }
            }
            //MessageBox.Show(sql.ToString());
            dgv_clientes.DataSource = Connection.select(sql.ToString());
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManipulaCliente mc = new ManipulaCliente();
            mc.FormClosed += (s, args) => this.Atualizar_Dgv();
            mc.FormClosed += (s, args) => this.Show();
            mc.Text = "Cadastro de Clientes";
            mc.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                string id = dgv_clientes.SelectedRows[0].Cells[0].Value.ToString();
                ManipulaCliente mc = new ManipulaCliente(id);
                mc.FormClosed += (s, args) => this.Show();
                mc.FormClosed += (s, args) => this.Atualizar_Dgv();
                mc.Text = "Atualização de Clientes";
                mc.ShowDialog();
            } catch (Exception ex)
            {
                MessageBox.Show("Selecione um usuário válido", "Erro");
                return;
            }

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            Atualizar_Dgv();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dgv_clientes.SelectedRows[0].Cells[0].Value.ToString();
                string sql = $@"delete from cadcli where cod_cliente = {id}";
                Connection.delete(sql);
                Atualizar_Dgv();
                MessageBox.Show("Cliente excluido com sucesso!!!", "Sucesso");
            } catch (Exception ex)
            {
                MessageBox.Show("Selecione um usuário válido", "Erro");
                return;
            }

        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(var frm = new Rel.RelacaoClientes())
            {
                frm.ShowDialog();
            }
        }
    }
}
