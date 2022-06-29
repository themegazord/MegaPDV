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
    public partial class ManipulaFornecedor : Form
    {
        DataTable dt = new DataTable();

        private string razaosocial;
        private string nomefantasia;
        private string cnpj;
        private string ie;
        private string im;
        private string endereco;
        private string numero;
        private string complemento;
        private string bairro;
        private string cep;
        private string codcidade;
        private string nomecontato;
        private string telefone1;
        private string telefone2;
        private string telefone3;
        private string email;

        public ManipulaFornecedor()
        {
            InitializeComponent();
            btn_atualizar.Hide();
            lb_mostra_id.Hide();
            lb_id.Hide();
        }
        public ManipulaFornecedor(string sql) : this()
        {
            this.Text = "Atualização de Fornecedor";

            btn_salvar.Hide();
            btn_atualizar.Show();
            lb_mostra_id.Show();
            lb_id.Show();

            dt = Connection.select(sql);

            lb_id.Text = dt.Rows[0].ItemArray[0].ToString();
            tb_razao_social.Text = dt.Rows[0].ItemArray[1].ToString();
            mtb_cnpj.Text = dt.Rows[0].ItemArray[2].ToString();
            mtb_telefone1.Text = dt.Rows[0].ItemArray[3].ToString();
            mtb_telefone2.Text = dt.Rows[0].ItemArray[4].ToString();
            tb_endereco.Text = dt.Rows[0].ItemArray[5].ToString();
            tb_numero_endereco.Text = dt.Rows[0].ItemArray[6].ToString();
            tb_complemento.Text = dt.Rows[0].ItemArray[7].ToString();
            tb_bairro.Text = dt.Rows[0].ItemArray[8].ToString();
            mtb_cep.Text = dt.Rows[0].ItemArray[9].ToString();
            tb_email.Text = dt.Rows[0].ItemArray[10].ToString();
            tb_codigo_cidade.Text = dt.Rows[0].ItemArray[11].ToString();
            tb_nome_fantasia.Text = dt.Rows[0].ItemArray[12].ToString();
            tb_ie.Text = dt.Rows[0].ItemArray[13].ToString();
            tb_im.Text = dt.Rows[0].ItemArray[14].ToString();
            tb_nome_contato.Text = dt.Rows[0].ItemArray[15].ToString();
            mtb_telefone3.Text = dt.Rows[0].ItemArray[16].ToString();

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (tb_razao_social.Text == "" || tb_nome_fantasia.Text == "" || mtb_cnpj.Text == "" || tb_endereco.Text == "" || tb_numero_endereco.Text == "" || tb_complemento.Text == ""|| tb_bairro.Text == "" || mtb_cep.Text == "" || tb_codigo_cidade.Text == "")
            {
                MessageBox.Show("Algum dos campos obrigatórios estão vazios. Por favor, verifique os dados indicados", "Erro");
            }

            string VerificaCNPJExistente = $@"select * from cadfor where cnpj_fornecedor = '{mtb_cnpj.Text}'";
            dt = Connection.select(VerificaCNPJExistente);

            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Já contém uma empresa com o CNPJ cadastrado, por favor verifique!!!", "Aviso");
            }


            razaosocial = tb_razao_social.Text;
            nomefantasia = tb_nome_fantasia.Text;
            cnpj = mtb_cnpj.Text;
            ie = tb_ie.Text;
            im = tb_im.Text;
            endereco = tb_endereco.Text;
            numero = tb_numero_endereco.Text;
            complemento = tb_complemento.Text;
            bairro = tb_bairro.Text;
            cep = mtb_cep.Text;
            codcidade = tb_codigo_cidade.Text;
            nomecontato = tb_nome_contato.Text;
            telefone1 = mtb_telefone1.Text;
            telefone2 = mtb_telefone2.Text;
            telefone3 = mtb_telefone3.Text;
            email = tb_email.Text;
            try
            {
                StringBuilder sql = new StringBuilder("insert into cadfor (razaosocialfor, nomefantasia_fornecedor, cnpj_fornecedor, ie_fornecedor, im_fornecedor, endereco_fornecedor, numero_fornecedor, complemento_fornecedor, bairro_fornecedor, cep_fornecedor, codcidade, nomecontato_fornecedor, telefone1, telefone2, telefone3, email_fornecedor) values (");
                sql.Append($@"'{razaosocial}',");
                sql.Append($@"'{nomefantasia}',");
                sql.Append($@"'{cnpj}',");
                sql.Append($@"'{ie}',");
                sql.Append($@"'{im}',");
                sql.Append($@"'{endereco}',");
                sql.Append($@"'{numero}',");
                sql.Append($@"'{complemento}',");
                sql.Append($@"'{bairro}',");
                sql.Append($@"'{cep}',");
                sql.Append($@"'{codcidade}',");
                sql.Append($@"'{nomecontato}',");

                if (telefone1 == "(  )      -")
                {
                    sql.Append($@"'',");
                }else
                {
                    sql.Append($@"'{telefone1}',");
                }
                if (telefone2 == "(  )      -")
                {
                    sql.Append($@"'',");
                }else
                {
                    sql.Append($@"'{telefone2}',");
                }
                if (telefone3 == "(  )      -")
                {
                    sql.Append($@"'',");
                } else
                {
                    sql.Append($@"'{telefone3}',");
                }

                sql.Append($@"'{email}')");
                try
                {
                    Connection.insert(sql.ToString());
                    MessageBox.Show("Fornecedor cadastrado com sucesso");
                    this.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            razaosocial = tb_razao_social.Text;
            nomefantasia = tb_nome_fantasia.Text;
            cnpj = mtb_cnpj.Text;
            ie = tb_ie.Text;
            im = tb_im.Text;
            endereco = tb_endereco.Text;
            numero = tb_numero_endereco.Text;
            complemento = tb_complemento.Text;
            bairro = tb_bairro.Text;
            cep = mtb_cep.Text;
            codcidade = tb_codigo_cidade.Text;
            nomecontato = tb_nome_contato.Text;
            telefone1 = mtb_telefone1.Text;
            telefone2 = mtb_telefone2.Text;
            telefone3 = mtb_telefone3.Text;
            email = tb_email.Text;


            StringBuilder sqlUpdate = new StringBuilder("update cadfor set ");

            if (tb_razao_social.Text == "" || tb_nome_fantasia.Text == "" || mtb_cnpj.Text == "" || tb_endereco.Text == "" || tb_numero_endereco.Text == "" || tb_complemento.Text == "" || tb_bairro.Text == "" || mtb_cep.Text == "" || tb_codigo_cidade.Text == "")
            {
                MessageBox.Show("Algum dos campos obrigatórios estão vazios. Por favor, verifique os dados indicados", "Erro");
            }

            sqlUpdate.Append($@"razaosocialfor = '{razaosocial}',");
            sqlUpdate.Append($@"nomefantasia_fornecedor = '{nomefantasia}',");
            sqlUpdate.Append($@"cnpj_fornecedor = '{cnpj}',");
            sqlUpdate.Append($@"ie_fornecedor = '{ie}',");
            sqlUpdate.Append($@"im_fornecedor = '{im}',");
            sqlUpdate.Append($@"endereco_fornecedor = '{endereco}',");
            sqlUpdate.Append($@"numero_fornecedor = '{numero}',");
            sqlUpdate.Append($@"complemento_fornecedor = '{complemento}',");
            sqlUpdate.Append($@"bairro_fornecedor = '{bairro}',");
            sqlUpdate.Append($@"cep_fornecedor = '{cep}',");
            sqlUpdate.Append($@"codcidade = '{codcidade}',");
            sqlUpdate.Append($@"nomecontato_fornecedor = '{nomecontato}',");
            sqlUpdate.Append($@"telefone1 = '{telefone1}',");
            sqlUpdate.Append($@"telefone2 = '{telefone2}',");
            sqlUpdate.Append($@"telefone3 = '{telefone3}',");
            sqlUpdate.Append($@"email_fornecedor = '{email}' where codfor = {lb_id.Text}");

            Connection.update(sqlUpdate.ToString());
            this.Close();
            MessageBox.Show("Fornecedor atualizado com sucesso.", "Sucesso");
        }
    }
}
