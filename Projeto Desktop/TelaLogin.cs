using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projeto_Desktop
{
    public partial class TelaLogin : Form
    {
        string Path = @"C:\Users\SF\Desktop\Projeto Desktop\Projeto Desktop\conn.ini";
        INIFile ini = new INIFile(@"C:\Users\SF\Desktop\Projeto Desktop\Projeto Desktop\conn.ini");

        DataTable dt = new DataTable();
        public TelaLogin()
        {
            InitializeComponent();
            string GetFileFullText() => File.ReadAllText(this.Path);
            string fileText = GetFileFullText();

            int count = fileText.Count(f => f == ']');

            if (count == 0 || count == 1)
            {
                ConexaoAtiva.ID = ini.IniReadValue("1", "ID");
                ConexaoAtiva.Servidor = ini.IniReadValue("1", "Servidor");
                ConexaoAtiva.Usuario = ini.IniReadValue("1", "Usuário");
                ConexaoAtiva.Senha = CLCripto.Base64Decode(ini.IniReadValue("1", "Senha"));
                ConexaoAtiva.Banco = ini.IniReadValue("1", "Banco");
                return;
            }
            else
            {
                Frm_Conexoes frm = new Frm_Conexoes();
                frm.ShowDialog();
            }
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
            dt = Connection.select(sql);

            if (dt.Rows.Count == 1)
            {
                // fecha o login, e assim que o menu principal for fechado, ai sim fecha tudo
                this.Hide();
                MenuPrincipal mp = new MenuPrincipal();
                mp.FormClosed += (s, args) => this.Close();
                mp.ShowDialog();
            } else
            {
                MessageBox.Show("Usuário não encontrado");
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_conexoes_Click(object sender, EventArgs e)
        {
            Frm_Conexoes frm = new Frm_Conexoes();
            frm.ShowDialog();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btn_login;
        }
    }
}
