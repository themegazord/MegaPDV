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
    public partial class DadosConexao : Form
    {
        string Path = @"C:\Users\SF\Desktop\Projeto Desktop\Projeto Desktop\conn.ini";
        INIFile ini = new INIFile(@"C:\Users\SF\Desktop\Projeto Desktop\Projeto Desktop\conn.ini");
        

        string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public DadosConexao()
        {
            InitializeComponent();

        }

        public DadosConexao(string id, string servidor, string usuario, string senha, string banco)
        {
            InitializeComponent();
            tb_idconn.Text = id;
            tb_servidor.Text = servidor;
            tb_usuario.Text = usuario;
            tb_senha.Text = senha;
            tb_banco.Text = banco;
        }

        private void btn_gravarConexao_Click(object sender, EventArgs e)
        {
            string id = tb_idconn.Text;
            string servidor = tb_servidor.Text;
            string usuario = tb_usuario.Text;
            string senha = tb_senha.Text;
            string banco = tb_banco.Text;

            string GetFileFullText() => File.ReadAllText(this.Path);
            string fileText = GetFileFullText();
            if (fileText.Contains($"[{id}]"))
            {
                ini.IniWriteValue($"{id}", "ID", id);
                ini.IniWriteValue($"{id}", "Servidor", servidor);
                ini.IniWriteValue($"{id}", "Usuário", usuario);
                ini.IniWriteValue($"{id}", "Senha", Base64Encode(senha));
                ini.IniWriteValue($"{id}", "Banco", banco);
            } else
            {
                ini.IniWriteValue($"{id}", "ID", id);
                ini.IniWriteValue($"{id}", "Servidor", servidor);
                ini.IniWriteValue($"{id}", "Usuário", usuario);
                ini.IniWriteValue($"{id}", "Senha", Base64Encode(senha));
                ini.IniWriteValue($"{id}", "Banco", banco);
            }
            this.Close();
        }

        private void btn_testaConexao_Click(object sender, EventArgs e)
        { 
            string servidor = tb_servidor.Text;
            string usuario = tb_usuario.Text;
            string senha = tb_senha.Text;
            string banco = tb_banco.Text;
            
            
            if (Connection.TestConnection(servidor, usuario, senha , banco))
            {
                MessageBox.Show("Banco conectado com sucesso");
            } else
            {
                MessageBox.Show("Erro ao conectar ao banco");
            }
        }
    }
}
