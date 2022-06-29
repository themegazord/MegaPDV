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
    public partial class ManipulaUnidade : Form
    {
        DataTable dt = new DataTable();
        public ManipulaUnidade()
        {
            InitializeComponent();

            lb_id.Hide();
            lb_mostra_id.Hide();
            btn_atualizar.Hide();
            gb_status.Hide();

        }

        public ManipulaUnidade(string id) : this()
        {
            btn_salvar.Hide();

            btn_atualizar.Show();
            lb_id.Show();
            lb_mostra_id.Show();
            gb_status.Show();

            string sql = $@"select desc_unidade, sigla_unidade, staunidade from cadunidade where cod_unidade = {id}";
            dt = Connection.select(sql);

            lb_id.Text = id;
            tb_nome.Text = dt.Rows[0].ItemArray[0].ToString();
            tb_sigla.Text = dt.Rows[0].ItemArray[1].ToString();
            if (char.Parse(dt.Rows[0].ItemArray[2].ToString()) == 'A')
            {
                cb_status.SelectedIndex = 0;
            } else if (char.Parse(dt.Rows[0].ItemArray[2].ToString()) == 'I')
            {
                cb_status.SelectedIndex = 1;
            }
        }

        private bool VerificaTamanhoSigla()
        {
            if(tb_sigla.Text.Length > 5)
            {
                MessageBox.Show("Campo de siglas contêm mais de 5 caracteres, por favor, arrume-o", "Erro");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (VerificaTamanhoSigla())
            {
                return;
            } else
            {
                StringBuilder sql = new StringBuilder($@"insert into cadunidade (desc_unidade, sigla_unidade) values ('{tb_nome.Text}', '{tb_sigla.Text}')");
                Connection.insert(sql.ToString());
                MessageBox.Show("Unidade cadastrada com sucesso!!!", "Sucesso");
            }
        }
        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (VerificaTamanhoSigla())
            {
                return;
            }else
            {
                StringBuilder sql = new StringBuilder("update cadunidade set");
                sql.Append($@" desc_unidade = '{tb_nome.Text}',");
                sql.Append($@"sigla_unidade = '{tb_sigla.Text}',");
                if (cb_status.SelectedIndex == 0)
                {
                    sql.Append($@"staunidade = 'A'");
                }
                else if (cb_status.SelectedIndex == 1)
                {
                    sql.Append($@"staunidade = 'I'");
                }
                sql.Append($@" where cod_unidade = {lb_id.Text}");

                Connection.update(sql.ToString());
                MessageBox.Show("Unidade atualizada com sucesso!!!", "Sucesso");
                this.Close();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
