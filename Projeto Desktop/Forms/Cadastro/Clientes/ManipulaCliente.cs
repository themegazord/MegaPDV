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
    public partial class ManipulaCliente : Form
    {
        DataTable dt = new DataTable();
        public ManipulaCliente()
        {
            InitializeComponent();
            mtb_cnpj.Hide();
            lb_cnpj.Hide();
            lb_id.Hide();
            lb_mostra_id.Hide();
            cb_tipo_cliente.SelectedIndex = 0;
            btn_atualizar.Hide();
        }
        public ManipulaCliente(string id) : this()
        {
            string sql = $@"select nomcliente, nomsocialcliente, tipo_cliente, cpf_cliente, cnpjcliente, endereco_cliente, numero_cliente, complemento_cliente, bairro_cliente, cep_cliente, codcidade, nome_contato, telefone1, telefone2, telefone3, email_cliente, codvendedor from cadcli where cod_cliente = {id}";
            dt = Connection.select(sql);

            btn_atualizar.Show();
            btn_salvar.Hide();
            lb_mostra_id.Show();
            lb_id.Show();
            lb_id.Text = id;

            tb_nome_completo.Text = dt.Rows[0].ItemArray[0].ToString();
            tb_nome_social.Text = dt.Rows[0].ItemArray[1].ToString();
            if (char.Parse(dt.Rows[0].ItemArray[2].ToString()) == 'F')
            {
                mtb_cnpj.Hide();
                lb_cnpj.Hide();
                mtb_cpf.Text = dt.Rows[0].ItemArray[3].ToString();
                cb_tipo_cliente.SelectedIndex = 0;
            } else if (char.Parse(dt.Rows[0].ItemArray[2].ToString()) == 'J')
            {
                mtb_cnpj.Show();
                lb_cnpj.Show();
                mtb_cpf.Hide();
                lb_cpf.Hide();
                mtb_cnpj.Text = dt.Rows[0].ItemArray[4].ToString();
                cb_tipo_cliente.SelectedIndex = 1;
            }
            tb_endereco.Text = dt.Rows[0].ItemArray[5].ToString();
            tb_numero_endereco.Text = dt.Rows[0].ItemArray[6].ToString();
            tb_complemento.Text = dt.Rows[0].ItemArray[7].ToString();
            tb_bairro.Text = dt.Rows[0].ItemArray[8].ToString();
            mtb_cep.Text = dt.Rows[0].ItemArray[9].ToString();
            tb_codigo_cidade.Text = dt.Rows[0].ItemArray[10].ToString();
            tb_nome_contato.Text = dt.Rows[0].ItemArray[11].ToString();
            mtb_telefone1.Text = dt.Rows[0].ItemArray[12].ToString();
            mtb_telefone2.Text = dt.Rows[0].ItemArray[13].ToString();
            mtb_telefone3.Text = dt.Rows[0].ItemArray[14].ToString();
            tb_email.Text = dt.Rows[0].ItemArray[15].ToString();
            tb_codigo_vendedor.Text = dt.Rows[0].ItemArray[16].ToString();
        }

        private void cb_tipo_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tipo_cliente.SelectedIndex == 0) // Pessoa Fisica
            {
                lb_cnpj.Hide();
                mtb_cnpj.Hide();
                lb_cpf.Show();
                mtb_cpf.Show();
            } else if (cb_tipo_cliente.SelectedIndex == 1) // Pessoa Juridica
            {
                lb_cnpj.Show();
                mtb_cnpj.Show();
                lb_cpf.Hide();
                mtb_cpf.Hide();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string nomcliente = tb_nome_completo.Text;
            string nomsocialcliente = tb_nome_social.Text;
            char tipo_cliente = 'a';
            if (cb_tipo_cliente.SelectedIndex == 0) // Pessoa Fisica
            {
                tipo_cliente = 'F';
            }
            else if (cb_tipo_cliente.SelectedIndex == 1) // Pessoa Juridica
            {
                tipo_cliente = 'J';
            }
            string cpfcliente = mtb_cpf.Text;
            string cnpjcliente = mtb_cnpj.Text;
            string endereco = tb_endereco.Text;
            string numendereco = tb_numero_endereco.Text;
            string complemento = tb_complemento.Text;
            string bairro = tb_bairro.Text;
            string cep = mtb_cep.Text;
            Int16 cod_cidade = Int16.Parse(tb_codigo_cidade.Text);
            string nome_contato = tb_nome_contato.Text;
            string tel1 = mtb_telefone1.Text;
            string tel2 = mtb_telefone2.Text;
            string tel3 = mtb_telefone3.Text;
            string email = tb_email.Text;
            Int16 cod_vendedor = 0;
            if (tb_codigo_vendedor.Text != "")
            {
                cod_vendedor = Int16.Parse(tb_codigo_vendedor.Text);
            }


            if (nomcliente == "" || nomsocialcliente == "" || cpfcliente == "" || cnpjcliente == "" || endereco == "" || numendereco == "" || complemento == "" || bairro == "" || cep == "" || cod_cidade == 0)
            {
                MessageBox.Show("Algum dos campos obrigatórios estão vazios. Por favor, verifique os dados indicados", "Erro");
            }

            StringBuilder sql = new StringBuilder("insert into cadcli (nomcliente,nomsocialcliente,tipo_cliente,cpf_cliente,cnpjcliente,endereco_cliente,numero_cliente,bairro_cliente,complemento_cliente,cep_cliente,codcidade,nome_contato,telefone1,telefone2,telefone3,email_cliente,codvendedor) values (");
            sql.Append($@"'{nomcliente}',");
            sql.Append($@"'{nomsocialcliente}',");
            sql.Append($@"'{tipo_cliente}',");
            if (tipo_cliente == 'F')
            {
                sql.Append($@"'{cpfcliente}',");
                sql.Append($@"'',");
            }else if (tipo_cliente == 'J')
            {
                sql.Append($@"'',");
                sql.Append($@"'{cnpjcliente}',");
            }
            sql.Append($@"'{endereco}',");
            sql.Append($@"'{numendereco}',");
            sql.Append($@"'{bairro}',");
            sql.Append($@"'{complemento}',");
            sql.Append($@"'{cep}',");
            sql.Append($@"{cod_cidade},");
            sql.Append($@"'{nome_contato}',");
            sql.Append($@"'{tel1}',");
            sql.Append($@"'{tel2}',");
            sql.Append($@"'{tel3}',");
            sql.Append($@"'{email}',");
            sql.Append($@"{cod_vendedor})");

            Connection.insert(sql.ToString());
            MessageBox.Show("Cliente cadastro com sucesso!!!", "Sucesso");
            this.Close();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            string nomcliente = tb_nome_completo.Text;
            string nomsocialcliente = tb_nome_social.Text;
            char tipo_cliente = 'a';
            if (cb_tipo_cliente.SelectedIndex == 0) // Pessoa Fisica
            {
                tipo_cliente = 'F';
            }
            else if (cb_tipo_cliente.SelectedIndex == 1) // Pessoa Juridica
            {
                tipo_cliente = 'J';
            }
            string cpfcliente = mtb_cpf.Text;
            string cnpjcliente = mtb_cnpj.Text;
            string endereco = tb_endereco.Text;
            string numendereco = tb_numero_endereco.Text;
            string complemento = tb_complemento.Text;
            string bairro = tb_bairro.Text;
            string cep = mtb_cep.Text;
            Int16 cod_cidade = Int16.Parse(tb_codigo_cidade.Text);
            string nome_contato = tb_nome_contato.Text;
            string tel1 = mtb_telefone1.Text;
            string tel2 = mtb_telefone2.Text;
            string tel3 = mtb_telefone3.Text;
            string email = tb_email.Text;
            Int16 cod_vendedor = 0;
            if (tb_codigo_vendedor.Text != "")
            {
                cod_vendedor = Int16.Parse(tb_codigo_vendedor.Text);
            }


            if (nomcliente == "" || nomsocialcliente == "" || cpfcliente == "" || cnpjcliente == "" || endereco == "" || numendereco == "" || complemento == "" || bairro == "" || cep == "" || cod_cidade == 0)
            {
                MessageBox.Show("Algum dos campos obrigatórios estão vazios. Por favor, verifique os dados indicados", "Erro");
            }

            StringBuilder sql = new StringBuilder("update cadcli set ");
            sql.Append($@"nomcliente = '{nomcliente}',");
            sql.Append($@"nomsocialcliente = '{nomsocialcliente}',");
            sql.Append($@"tipo_cliente = '{tipo_cliente}',");
            if (tipo_cliente == 'F')
            {
                sql.Append($@"cpf_cliente = '{cpfcliente}',");
            } else if (tipo_cliente == 'J')
            {
                sql.Append($@"cnpj_cliente = '{cnpjcliente}',");
            }
            sql.Append($@"endereco_cliente = '{endereco}',");
            sql.Append($@"numero_cliente = '{numendereco}',");
            sql.Append($@"complemento_cliente = '{complemento}',");
            sql.Append($@"bairro_cliente = '{bairro}',");
            sql.Append($@"cep_cliente = '{cep}',");
            sql.Append($@"codcidade = '{cod_cidade}',");
            sql.Append($@"nome_contato = '{nome_contato}',");
            sql.Append($@"telefone1 = '{tel1}',");
            sql.Append($@"telefone2 = '{tel2}',");
            sql.Append($@"telefone3 = '{tel3}',");
            sql.Append($@"email_cliente = '{email}',");
            sql.Append($@"codvendedor = '{cod_vendedor}' ");
            sql.Append($@"where cod_cliente = {lb_id.Text}");

            Connection.update(sql.ToString());
            MessageBox.Show(sql.ToString());
            MessageBox.Show("Cliente alterado com sucesso!!!", "Sucesso");
            this.Close();
        }
    }
}
