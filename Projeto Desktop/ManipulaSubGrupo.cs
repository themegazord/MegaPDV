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
    public partial class ManipulaSubGrupo : Form
    {
        DataTable dt = new DataTable();

        public ManipulaSubGrupo()
        {
            InitializeComponent();

            lb_id.Hide();
            lb_mostra_id.Hide();
            btn_atualizar.Hide();
            gb_status.Hide();
        }

        public ManipulaSubGrupo(string id) : this()
        {
            btn_salvar.Hide();

            btn_atualizar.Show();
            lb_id.Show();
            lb_mostra_id.Show();
            gb_status.Show();

            string sql = $@"select nome_subgrupo, stasubgrupro from cadsubgrupo where cod_subgrupo = {id}";
            dt = Connection.select(sql);

            lb_id.Text = id;
            tb_nome.Text = dt.Rows[0].ItemArray[0].ToString();
            if (char.Parse(dt.Rows[0].ItemArray[1].ToString()) == 'A')
            {
                cb_status.SelectedIndex = 0;
            }else if (char.Parse(dt.Rows[0].ItemArray[1].ToString()) == 'I')
            {
                cb_status.SelectedIndex = 1;
            }

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder($@"insert into cadsubgrupo (nome_subgrupo) values ('{tb_nome.Text}')");
            Connection.insert(sql.ToString());
            MessageBox.Show("Subgrupo cadastrado com sucesso!!!", "Sucesso");
            this.Close();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder($@"update cadsubgrupo set");
            sql.Append($@" nome_subgrupo = '{tb_nome.Text}',");
            if (cb_status.SelectedIndex == 0)
            {
                sql.Append($@" stasubgrupro = 'A'");
            }else if (cb_status.SelectedIndex == 1)
            {
                sql.Append($@" stasubgrupro = 'I'");
            }
            sql.Append($@" where cod_subgrupo = {lb_id.Text}");
            Connection.update(sql.ToString());
            MessageBox.Show("Subgrupo cadastrado com sucesso!!!", "Sucesso");
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
