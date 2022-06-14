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
    public partial class TelaLogin : Form
    {
        DataTable dt = new DataTable();
        public TelaLogin()
        {
            InitializeComponent();
            Frm_Conexoes frm = new Frm_Conexoes();
            frm.ShowDialog();
        }

        public void btn_login_Click(object sender, EventArgs e)
        {
            string usuario = tb_usuario.Text;
            string senha = tb_senha.Text;

            if (usuario == "" || senha == "")
            {
                MessageBox.Show("Usuário ou senha em branco, por gentileza preencher todos os campos!", "Erro de preenchimento");
                tb_usuario.Focus();
                return;
            }

            string sql = $"SELECT * FROM cadusu WHERE nomusu = '{usuario}' and senusu = '{senha}'";
            dt = Banco.select(sql);

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Usuario logado");
                MenuPrincipal mp = new MenuPrincipal();
                mp.ShowDialog();
            } else
            {
                MessageBox.Show("Não encontrei nada");
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
