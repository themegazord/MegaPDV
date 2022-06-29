using System;
using Npgsql;
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
    public partial class Frm_Conexoes : Form
    {
        string Path = @"C:\Users\SF\Desktop\Projeto Desktop\Projeto Desktop\conn.ini";
        INIFile ini = new INIFile(@"C:\Users\SF\Desktop\Projeto Desktop\Projeto Desktop\conn.ini");

        public Frm_Conexoes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string GetFileFullText() => File.ReadAllText(this.Path);
            string fileText = GetFileFullText();

            int count = fileText.Count(f => f == ']');

            

            for (int i = 1; i <= count; i++)
            {
                string[] row = new string[]
                {
                    ini.IniReadValue($"{i}", "ID"),
                    ini.IniReadValue($"{i}", "Servidor"),
                    ini.IniReadValue($"{i}", "Usuário"),
                    CLCripto.Base64Decode(ini.IniReadValue($"{i}", "Senha")),
                    ini.IniReadValue($"{i}", "Banco"),
                };
                dgv_conexoes.Rows.Add(row);
            }
        }

        private void btn_inserirDados_Click(object sender, EventArgs e)
        {
            DadosConexao dc = new DadosConexao();
            dc.Show();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            DadosConexao dc = new DadosConexao(
            dgv_conexoes.SelectedRows[0].Cells[0].Value.ToString(),
            dgv_conexoes.SelectedRows[0].Cells[1].Value.ToString(),
            dgv_conexoes.SelectedRows[0].Cells[2].Value.ToString(),
            dgv_conexoes.SelectedRows[0].Cells[3].Value.ToString(),
            dgv_conexoes.SelectedRows[0].Cells[4].Value.ToString()
            );
            dc.Show();
        }

        // Mascara a senha no DGV.
        private void dgv_conexoes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            dgv_conexoes.Rows.Clear();


            string GetFileFullText() => File.ReadAllText(this.Path);
            string fileText = GetFileFullText();

            int count = fileText.Count(f => f == ']');



            for (int i = 1; i <= count; i++)
            {
                string[] row = new string[]
                {
                    ini.IniReadValue($"{i}", "ID"),
                    ini.IniReadValue($"{i}", "Servidor"),
                    ini.IniReadValue($"{i}", "Usuário"),
                    CLCripto.Base64Decode(ini.IniReadValue($"{i}", "Senha")),
                    ini.IniReadValue($"{i}", "Banco"),
                };
                dgv_conexoes.Rows.Add(row);
            }

        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            ini.DeleteSectionValue(
                    $"{dgv_conexoes.SelectedRows[0].Cells[0].Value}",
                    null,
                    this.Path
                );
                
        }

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            if (Connection.TestConnection(
                dgv_conexoes.SelectedRows[0].Cells[1].Value.ToString(),
                dgv_conexoes.SelectedRows[0].Cells[2].Value.ToString(),
                dgv_conexoes.SelectedRows[0].Cells[3].Value.ToString(),
                dgv_conexoes.SelectedRows[0].Cells[4].Value.ToString()
                ))
            {
                ConexaoAtiva.ID = dgv_conexoes.SelectedRows[0].Cells[0].Value.ToString();
                ConexaoAtiva.Servidor = dgv_conexoes.SelectedRows[0].Cells[1].Value.ToString();
                ConexaoAtiva.Usuario = dgv_conexoes.SelectedRows[0].Cells[2].Value.ToString();
                ConexaoAtiva.Senha = dgv_conexoes.SelectedRows[0].Cells[3].Value.ToString();
                ConexaoAtiva.Banco = dgv_conexoes.SelectedRows[0].Cells[4].Value.ToString();
                this.Close();
            } else
            {
                MessageBox.Show("Erro ao conectar com o banco de dados, verifique sua conexão", "Erro");
            }

        }
    }
}
