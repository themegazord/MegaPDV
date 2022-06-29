using System;
using System.Globalization;
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
    public partial class Cidades : Form
    {
        string SelectedRowID = "";
        public Cidades()
        {
            InitializeComponent();
        }

        public void AtualizaDGV()
        {
            StringBuilder sql = new StringBuilder($@"select codcidade as ""Código"", cidade.ibge as ""ibge"", estado.uf as ""UF"" ,cidade.nome as ""Nome"" from cidade inner join estado on cidade.uf = estado.codestado");
            string AndWhere = " where ";

            if (tb_codigo.Text != "")
            {
                sql.Append($@"{AndWhere}codcidade = {tb_codigo.Text}");
                AndWhere = " and ";
            }
            else
            {
                if (cb_alvo.SelectedIndex == 0)
                {
                    sql.Append($@"{AndWhere}cidade.nome like '%{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tb_pesquisa.Text)}%'");
                    AndWhere = " and ";
                }
                else if (cb_alvo.SelectedIndex == 1)
                {
                    sql.Append($@"{AndWhere}cidade.ibge like '%{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tb_pesquisa.Text)}%'");
                    AndWhere = " and ";
                }
            }


            try
            {
                dgv_cidade.DataSource = Connection.select(sql.ToString());
            }
            catch
            {
                MessageBox.Show("Erro na consulta, por favor, verifique todos os campos", "Erro");
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            AtualizaDGV();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManipulaCidades mc = new ManipulaCidades();
            mc.FormClosed += (s, args) => this.Show();
            mc.FormClosed += (s, args) => this.AtualizaDGV();
            mc.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectedRowID = dgv_cidade.SelectedRows[0].Cells[0].Value.ToString();
            string sql = $@"select codcidade, nome, ibge, cod_tom, uf from cidade where codcidade = {SelectedRowID}";
            this.Hide();
            ManipulaCidades mc = new ManipulaCidades(sql);
            mc.FormClosed += (s, args) => this.Show();
            mc.FormClosed += (s, args) => this.AtualizaDGV();
            mc.ShowDialog();
        }
    }
}
