using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Desktop
{
    public partial class Estados : Form
    {
        public string SelectedRowID;
        public Estados()
        {
            InitializeComponent();
            btn_extrair.Hide();
        }
        public Estados(bool extrai = false) : this()
        {
            btn_extrair.Show();
        }
        public void AtualizaDGV()
        {
            StringBuilder sql = new StringBuilder($@"select codestado as ""Código"", uf as ""UF"", nome as ""Nome"" from estado");
            string AndWhere = " where ";

            if (tb_codigo.Text != "")
            {
                sql.Append($@"{AndWhere}codestado = {tb_codigo.Text}");
                AndWhere = " and ";
            }
            else
            {
                if (cb_alvo.SelectedIndex == 0)
                {
                    sql.Append($@"{AndWhere}nome like '%{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tb_pesquisa.Text)}%'");
                    AndWhere = " and ";
                }
                else if (cb_alvo.SelectedIndex == 1)
                {
                    sql.Append($@"{AndWhere}uf like '%{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tb_pesquisa.Text)}%'");
                    AndWhere = " and ";
                }
            }


            try
            {
                dgv_estados.DataSource = Connection.select(sql.ToString());
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

        private void btn_extrair_Click(object sender, EventArgs e)
        {
            SelectedRowID = dgv_estados.SelectedRows[0].Cells[0].Value.ToString();
            this.Close();
        }
    }
}
