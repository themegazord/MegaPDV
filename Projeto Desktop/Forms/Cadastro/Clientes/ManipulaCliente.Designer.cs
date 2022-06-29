namespace Projeto_Desktop
{
    partial class ManipulaCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nome_contato = new System.Windows.Forms.TextBox();
            this.lb_cpf = new System.Windows.Forms.Label();
            this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.tb_nome_social = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_tipo_cliente = new System.Windows.Forms.ComboBox();
            this.mtb_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.lb_cnpj = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btn_busca_cidade = new System.Windows.Forms.Button();
            this.tb_codigo_cidade = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mtb_cep = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_bairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_complemento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_numero_endereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mtb_telefone1 = new System.Windows.Forms.MaskedTextBox();
            this.mtb_telefone2 = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mtb_telefone3 = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_nome_completo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_pesquisa_vendedor = new System.Windows.Forms.Button();
            this.tb_codigo_vendedor = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.lb_mostra_id = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Contato";
            // 
            // tb_nome_contato
            // 
            this.tb_nome_contato.Location = new System.Drawing.Point(118, 299);
            this.tb_nome_contato.Name = "tb_nome_contato";
            this.tb_nome_contato.Size = new System.Drawing.Size(211, 20);
            this.tb_nome_contato.TabIndex = 11;
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.Location = new System.Drawing.Point(322, 82);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(27, 13);
            this.lb_cpf.TabIndex = 0;
            this.lb_cpf.Text = "CPF";
            // 
            // mtb_cpf
            // 
            this.mtb_cpf.Location = new System.Drawing.Point(355, 82);
            this.mtb_cpf.Mask = "000,000,000-00";
            this.mtb_cpf.Name = "mtb_cpf";
            this.mtb_cpf.Size = new System.Drawing.Size(86, 20);
            this.mtb_cpf.TabIndex = 4;
            // 
            // tb_nome_social
            // 
            this.tb_nome_social.Location = new System.Drawing.Point(118, 47);
            this.tb_nome_social.Name = "tb_nome_social";
            this.tb_nome_social.Size = new System.Drawing.Size(323, 20);
            this.tb_nome_social.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome Social";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo";
            // 
            // cb_tipo_cliente
            // 
            this.cb_tipo_cliente.FormattingEnabled = true;
            this.cb_tipo_cliente.Items.AddRange(new object[] {
            "Pessoa Física",
            "Pessoa Jurídica"});
            this.cb_tipo_cliente.Location = new System.Drawing.Point(118, 79);
            this.cb_tipo_cliente.Name = "cb_tipo_cliente";
            this.cb_tipo_cliente.Size = new System.Drawing.Size(121, 21);
            this.cb_tipo_cliente.TabIndex = 3;
            this.cb_tipo_cliente.SelectedIndexChanged += new System.EventHandler(this.cb_tipo_cliente_SelectedIndexChanged);
            // 
            // mtb_cnpj
            // 
            this.mtb_cnpj.Location = new System.Drawing.Point(335, 82);
            this.mtb_cnpj.Mask = "00,000,000/0000-00";
            this.mtb_cnpj.Name = "mtb_cnpj";
            this.mtb_cnpj.Size = new System.Drawing.Size(106, 20);
            this.mtb_cnpj.TabIndex = 4;
            // 
            // lb_cnpj
            // 
            this.lb_cnpj.AutoSize = true;
            this.lb_cnpj.Location = new System.Drawing.Point(295, 82);
            this.lb_cnpj.Name = "lb_cnpj";
            this.lb_cnpj.Size = new System.Drawing.Size(34, 13);
            this.lb_cnpj.TabIndex = 0;
            this.lb_cnpj.Text = "CNPJ";
            this.lb_cnpj.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.btn_busca_cidade);
            this.groupBox2.Controls.Add(this.tb_codigo_cidade);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.mtb_cep);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tb_bairro);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tb_complemento);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_numero_endereco);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_endereco);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(15, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 153);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço de Cobrança";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(432, 120);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(11, 13);
            this.label25.TabIndex = 33;
            this.label25.Text = "*";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.Red;
            this.label24.Location = new System.Drawing.Point(282, 88);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(11, 13);
            this.label24.TabIndex = 32;
            this.label24.Text = "*";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(432, 88);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(11, 13);
            this.label23.TabIndex = 31;
            this.label23.Text = "*";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(432, 48);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(11, 13);
            this.label22.TabIndex = 30;
            this.label22.Text = "*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(561, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(11, 13);
            this.label21.TabIndex = 29;
            this.label21.Text = "*";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(432, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(11, 13);
            this.label20.TabIndex = 28;
            this.label20.Text = "*";
            // 
            // btn_busca_cidade
            // 
            this.btn_busca_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busca_cidade.Location = new System.Drawing.Point(148, 120);
            this.btn_busca_cidade.Name = "btn_busca_cidade";
            this.btn_busca_cidade.Size = new System.Drawing.Size(21, 21);
            this.btn_busca_cidade.TabIndex = 15;
            this.btn_busca_cidade.Text = "▲";
            this.btn_busca_cidade.UseVisualStyleBackColor = true;
            // 
            // tb_codigo_cidade
            // 
            this.tb_codigo_cidade.Location = new System.Drawing.Point(103, 120);
            this.tb_codigo_cidade.Name = "tb_codigo_cidade";
            this.tb_codigo_cidade.Size = new System.Drawing.Size(39, 20);
            this.tb_codigo_cidade.TabIndex = 10;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(175, 120);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(251, 20);
            this.textBox7.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cidade";
            // 
            // mtb_cep
            // 
            this.mtb_cep.Location = new System.Drawing.Point(360, 88);
            this.mtb_cep.Mask = "00,000-999";
            this.mtb_cep.Name = "mtb_cep";
            this.mtb_cep.Size = new System.Drawing.Size(66, 20);
            this.mtb_cep.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "CEP";
            // 
            // tb_bairro
            // 
            this.tb_bairro.Location = new System.Drawing.Point(103, 88);
            this.tb_bairro.Name = "tb_bairro";
            this.tb_bairro.Size = new System.Drawing.Size(173, 20);
            this.tb_bairro.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Bairro";
            // 
            // tb_complemento
            // 
            this.tb_complemento.Location = new System.Drawing.Point(103, 59);
            this.tb_complemento.Name = "tb_complemento";
            this.tb_complemento.Size = new System.Drawing.Size(323, 20);
            this.tb_complemento.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Complemento";
            // 
            // tb_numero_endereco
            // 
            this.tb_numero_endereco.Location = new System.Drawing.Point(499, 24);
            this.tb_numero_endereco.Name = "tb_numero_endereco";
            this.tb_numero_endereco.Size = new System.Drawing.Size(58, 20);
            this.tb_numero_endereco.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Número";
            // 
            // tb_endereco
            // 
            this.tb_endereco.Location = new System.Drawing.Point(103, 24);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(323, 20);
            this.tb_endereco.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Endereço";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Telefone 1";
            // 
            // mtb_telefone1
            // 
            this.mtb_telefone1.Location = new System.Drawing.Point(118, 333);
            this.mtb_telefone1.Mask = "(99) 00000-0000";
            this.mtb_telefone1.Name = "mtb_telefone1";
            this.mtb_telefone1.Size = new System.Drawing.Size(89, 20);
            this.mtb_telefone1.TabIndex = 12;
            // 
            // mtb_telefone2
            // 
            this.mtb_telefone2.Location = new System.Drawing.Point(277, 333);
            this.mtb_telefone2.Mask = "(99) 00000-0000";
            this.mtb_telefone2.Name = "mtb_telefone2";
            this.mtb_telefone2.Size = new System.Drawing.Size(89, 20);
            this.mtb_telefone2.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(213, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Telefone 2";
            // 
            // mtb_telefone3
            // 
            this.mtb_telefone3.Location = new System.Drawing.Point(436, 333);
            this.mtb_telefone3.Mask = "(99) 00000-0000";
            this.mtb_telefone3.Name = "mtb_telefone3";
            this.mtb_telefone3.Size = new System.Drawing.Size(91, 20);
            this.mtb_telefone3.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(372, 336);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Telefone 3";
            // 
            // tb_nome_completo
            // 
            this.tb_nome_completo.Location = new System.Drawing.Point(118, 12);
            this.tb_nome_completo.Name = "tb_nome_completo";
            this.tb_nome_completo.Size = new System.Drawing.Size(323, 20);
            this.tb_nome_completo.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Nome Completo";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(118, 368);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(323, 20);
            this.tb_email.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(80, 371);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Email";
            // 
            // btn_pesquisa_vendedor
            // 
            this.btn_pesquisa_vendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisa_vendedor.Location = new System.Drawing.Point(163, 406);
            this.btn_pesquisa_vendedor.Name = "btn_pesquisa_vendedor";
            this.btn_pesquisa_vendedor.Size = new System.Drawing.Size(21, 21);
            this.btn_pesquisa_vendedor.TabIndex = 23;
            this.btn_pesquisa_vendedor.Text = "▲";
            this.btn_pesquisa_vendedor.UseVisualStyleBackColor = true;
            // 
            // tb_codigo_vendedor
            // 
            this.tb_codigo_vendedor.Location = new System.Drawing.Point(118, 406);
            this.tb_codigo_vendedor.Name = "tb_codigo_vendedor";
            this.tb_codigo_vendedor.Size = new System.Drawing.Size(39, 20);
            this.tb_codigo_vendedor.TabIndex = 16;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(190, 406);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(251, 20);
            this.textBox12.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(59, 409);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Vendedor";
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(598, 12);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(80, 52);
            this.btn_salvar.TabIndex = 17;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(598, 82);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(80, 52);
            this.btn_cancelar.TabIndex = 18;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(447, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(11, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(447, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(11, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(447, 79);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(11, 13);
            this.label19.TabIndex = 27;
            this.label19.Text = "*";
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(598, 12);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(80, 52);
            this.btn_atualizar.TabIndex = 28;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // lb_mostra_id
            // 
            this.lb_mostra_id.AutoSize = true;
            this.lb_mostra_id.Location = new System.Drawing.Point(511, 15);
            this.lb_mostra_id.Name = "lb_mostra_id";
            this.lb_mostra_id.Size = new System.Drawing.Size(21, 13);
            this.lb_mostra_id.TabIndex = 29;
            this.lb_mostra_id.Text = "ID:";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(538, 15);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(0, 13);
            this.lb_id.TabIndex = 30;
            // 
            // ManipulaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.lb_mostra_id);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_pesquisa_vendedor);
            this.Controls.Add(this.tb_codigo_vendedor);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tb_nome_completo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.mtb_telefone3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.mtb_telefone2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mtb_telefone1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mtb_cnpj);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lb_cnpj);
            this.Controls.Add(this.cb_tipo_cliente);
            this.Controls.Add(this.tb_nome_contato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_nome_social);
            this.Controls.Add(this.lb_cpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtb_cpf);
            this.Name = "ManipulaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManipulaCliente";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_nome_social;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtb_cpf;
        private System.Windows.Forms.Label lb_cpf;
        private System.Windows.Forms.TextBox tb_nome_contato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtb_cnpj;
        private System.Windows.Forms.Label lb_cnpj;
        private System.Windows.Forms.ComboBox cb_tipo_cliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_codigo_cidade;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtb_cep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_bairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_complemento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_numero_endereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_busca_cidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mtb_telefone1;
        private System.Windows.Forms.MaskedTextBox mtb_telefone2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mtb_telefone3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_nome_completo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_pesquisa_vendedor;
        private System.Windows.Forms.TextBox tb_codigo_vendedor;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Label lb_mostra_id;
        private System.Windows.Forms.Label lb_id;
    }
}