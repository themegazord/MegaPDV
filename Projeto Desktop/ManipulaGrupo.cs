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
    public partial class ManipulaGrupo : Form
    {
        DataTable dt = new DataTable();
        public ManipulaGrupo()
        {
            InitializeComponent();

            lb_id.Hide();
            lb_mostra_id.Hide();
            btn_atualizar.Hide();
            gb_status.Hide();
        }

        public ManipulaGrupo(string id) : this()
        {
            btn_salvar.Hide();

            btn_atualizar.Show();
            lb_id.Show();
            lb_mostra_id.Show();
            gb_status.Show();

            string sql = $@"select nome_grupo, stagrupro from cadgrupo where cod_grupo = {id}";
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
            StringBuilder sql = new StringBuilder($@"insert into cadgrupo (nome_grupo) values ('{tb_nome.Text}')");
            Connection.insert(sql.ToString());
            MessageBox.Show("Grupo cadastrado com sucesso!!!", "Sucesso");
            this.Close();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder($@"update cadgrupo set");
            sql.Append($@" nome_grupo = '{tb_nome.Text}',");
            if(cb_status.SelectedIndex == 0)
            {
                sql.Append($@"stagrupro = 'A'");
            } else if (cb_status.SelectedIndex == 1)
            {
                sql.Append($@"stagrupro = 'I'");
            }
            sql.Append($@" where cod_grupo = {lb_id.Text}");

            Connection.update(sql.ToString());
            MessageBox.Show("Usuário atualizado com sucesso!!!", "Sucesso");
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
