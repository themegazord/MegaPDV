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
    public partial class Usuarios : Form
    {

        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            string sql = @"SELECT codusu as Código, nomusu as Usuário, nomcompusu as ""Nome do Usuario"" FROM cadusu";
            dgv_usuarios.DataSource = Banco.select(sql);
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder(@"SELECT codusu as Código, nomusu as Usuário, nomcompusu as ""Nome do Usuario"" FROM cadusu where");
            if (tb_codusu.Text != "")
            {
                sql.Append($@" codusu = '{tb_codusu.Text}' and");
            }
            if (tb_nomusu.Text != "")
            {
                sql.Append($@" nomusu like '%{tb_nomusu.Text}%' and");
            }
            if (rb_ativo.Checked)
            {
                sql.Append($@" ativo = 'S'");
            }
            if (rb_inativo.Checked)
            {
                sql.Append($@" ativo = 'N'");
            }

            dgv_usuarios.DataSource = Banco.select(sql.ToString());
        }
    }
}
