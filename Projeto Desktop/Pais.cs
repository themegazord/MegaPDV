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
    public partial class Pais : Form
    {
        public string SelectedRowID;
        public Pais()
        {
            InitializeComponent();
        }
        public Pais(bool extrair = false) : this()
        {
            if (extrair)
            {
                SelectedRowID = dgv_pais.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        public void AtualizaDGV()
        {
            StringBuilder sql = new StringBuilder($@"select codpais as ""Código"", sigla as ""Sigla"", nome_pt as ""Nome"", bacen as ""BACEN"" from pais");
            string AndWhere = " where ";

            if (tb_codigo.Text != "")
            {
                sql.Append($@"{AndWhere}codpais = {tb_codigo.Text}");
                AndWhere = " and ";
            } else
            {
                if (cb_alvo.SelectedIndex == 0)
                {
                    sql.Append($@"{AndWhere}nome_pt like '%{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tb_pesquisa.Text)}%'");
                    AndWhere = " and ";
                } else if (cb_alvo.SelectedIndex == 1)
                {
                    sql.Append($@"{AndWhere}sigla like '%{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tb_pesquisa.Text)}%'");
                    AndWhere = " and ";
                }else if (cb_alvo.SelectedIndex == 2)
                {
                    sql.Append($@"{AndWhere}bacen like %{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tb_pesquisa.Text)}%");
                    AndWhere = " and ";
                }
            }


            try
            {
                dgv_pais.DataSource = Connection.select(sql.ToString());
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
    }
}
