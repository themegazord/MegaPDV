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
    public partial class ManipulaUsuario : Form
    {
        public ManipulaUsuario()
        {
            InitializeComponent();
            btn_atualizar.Hide();
        }
        public ManipulaUsuario(string nomcompusu, string nomusu, string senusu, string emailusu,  string telusu, string endusu, string numendusu, string baiendusu, string complendusu, string cependusu, char ativo, int ID) : this()
        {
            btn_salvar.Hide();
            btn_atualizar.Show();

            lb_ativo.Visible = true;
            rb_ativo.Visible = true;
            rb_inativo.Visible = true;


            lb_idusu.Text = ID.ToString();
            tb_nome.Text = nomcompusu;
            tb_usuario.Text = nomusu;
            tb_senha.Text = senusu;
            tb_email.Text = emailusu;
            tb_telefone.Text = telusu;
            tb_endereco.Text = endusu;
            tb_numero_endereco.Text = numendusu;
            tb_bairro.Text = baiendusu;
            tb_complemento.Text = complendusu;
            tb_cep.Text = cependusu;
            if (ativo == 'S')
            {
                rb_ativo.Checked = true;
            } else
            {
                rb_inativo.Checked = true;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (tb_nome.Text == "" || tb_usuario.Text == "" || tb_senha.Text == "")
            {
                MessageBox.Show("Um dos campos obrigatórios não foi preenchido, por favor preencha!", "Erro de preenchimento");
                return;
            }
            if (Connection.select($@"select * from cadusu where nomusu = '{tb_usuario.Text}'").Rows.Count > 0)
            {
                MessageBox.Show($"Usuário: {tb_usuario.Text} já existe na base de dados.", "Atenção");
                return;
            }
            string sql = "insert into cadusu (nomusu, senusu, nomcompusu, emailusu, telusu, endusu, numendusu, baiendusu, complendusu, cependusu) values (" +
                $@"'{tb_usuario.Text}'," +
                $@"'{tb_senha.Text}'," +
                $@"'{tb_nome.Text}'," +
                $@"'{tb_email.Text}'," +
                $@"'{tb_telefone.Text}'," +
                $@"'{tb_endereco.Text}'," +
                $@"'{tb_numero_endereco.Text}'," +
                $@"'{tb_bairro.Text}'," +
                $@"'{tb_complemento.Text}'," +
                $@"'{tb_cep.Text}')";
            Connection.insert(sql);
            MessageBox.Show("Usuário cadastro com sucesso", "Sucesso");
            this.Close();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            if (tb_nome.Text == "" || tb_usuario.Text == "" || tb_senha.Text == "")
            {
                MessageBox.Show("Um dos campos obrigatórios não foi preenchido, por favor preencha!", "Erro de preenchimento");
                return;
            }
            if (rb_ativo.Checked)
            {
                char ativo = 'S';
            } else
            {
                char ativo = 'N';
            }
            StringBuilder sql = new StringBuilder();
            sql.Append("update cadusu set ");
            sql.Append($@"nomusu = '{tb_usuario.Text}',");
            sql.Append($@"senusu = '{tb_senha.Text}',");
            sql.Append($@"nomcompusu = '{tb_nome.Text}',");
            sql.Append($@"emailusu = '{tb_email.Text}',");
            sql.Append($@"telusu = '{tb_telefone.Text}',");
            sql.Append($@"endusu = '{tb_endereco.Text}',");
            sql.Append($@"numendusu = '{tb_numero_endereco.Text}',");
            sql.Append($@"baiendusu = '{tb_bairro.Text}',");
            sql.Append($@"complendusu = '{tb_complemento.Text}',");
            if (rb_ativo.Checked)
            {
                sql.Append($@"ativo = 'S',");
            } else
            {
                sql.Append($@"ativo = 'N',");
            }
            sql.Append($@"cependusu = '{tb_cep.Text}' where codusu = {lb_idusu.Text}");
            Connection.update(sql.ToString());
            MessageBox.Show("Usuário atualizado com sucesso", "Sucesso");
            this.Close();
        }
    }
}
