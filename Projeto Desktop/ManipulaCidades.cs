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
    public partial class ManipulaCidades : Form
    {
        DataTable dt = new DataTable();
        public ManipulaCidades()
        {
            InitializeComponent();
            btn_atualizar.Hide();
            lb_mostra_id.Hide();
            lb_id.Hide();
        }
        public ManipulaCidades(string sql) : this()
        {
            btn_atualizar.Show();
            lb_mostra_id.Show();
            lb_id.Show();
            btn_salvar.Hide();

            this.Text = "Atualização de Cidade";

            dt = Connection.select(sql);
            lb_id.Text = dt.Rows[0].ItemArray[0].ToString();
            tb_nome_cidade.Text = dt.Rows[0].ItemArray[1].ToString();
            tb_ibge.Text = dt.Rows[0].ItemArray[2].ToString();
            tb_tom.Text = dt.Rows[0].ItemArray[3].ToString();
            tb_codigo_estado.Text = dt.Rows[0].ItemArray[4].ToString();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_busca_cidade_Click(object sender, EventArgs e)
        {
            string id = "";
            Estados es = new Estados(true);
            es.FormClosed += (s, args) => id = es.SelectedRowID;
            es.ShowDialog();
            tb_codigo_estado.Text = id;    
        }

        private void tb_codigo_estado_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string id = tb_codigo_estado.Text;
                string sql = $@"select nome from estado where codestado = {id}";
                dt = Connection.select(sql);
                tb_nome_estado.Text = dt.Rows[0].ItemArray[0].ToString();
            }
            catch
            {
                MessageBox.Show("Estado não existe.", "Erro");
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder($@"insert into cidade (nome, uf, ibge, cod_tom) values (");
            sql.Append($@"'{tb_nome_cidade.Text}',");
            sql.Append($@"{tb_codigo_estado},");
            sql.Append($@"{tb_ibge},");
            if(tb_tom.TextLength > 0)
            {
                sql.Append($@"{tb_tom.Text}");
            }
            else
            {
                sql.Append("0");
            }
            try
            {
                Connection.insert(sql.ToString());
                MessageBox.Show("Cidade cadastrada com sucesso.", "Sucesso");
            }
            catch
            {
                MessageBox.Show("Erro ao cadastrar a cidade.", "Erro");
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder($@"update cidade set ");
            sql.Append($@"nome = '{tb_nome_cidade.Text}',");
            sql.Append($@"uf = {tb_codigo_estado.Text},");
            sql.Append($@"ibge = {tb_ibge.Text},");
            if (tb_tom.TextLength > 0)
            {
                sql.Append($@"cod_tom = {tb_tom.Text} where codcidade = {lb_id.Text}");
            }
            else
            {
                sql.Append($@"cod_tom = 0 where codcidade = {lb_id.Text}");
            }

            try
            {
                Connection.update(sql.ToString());
                MessageBox.Show("Cidade atualizada com sucesso com sucesso.", "Sucesso");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao atualizar a cidade.", "Erro");
            }
        }
    }
}
