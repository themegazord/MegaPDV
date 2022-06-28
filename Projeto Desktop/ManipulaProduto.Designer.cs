namespace Projeto_Desktop
{
    partial class ManipulaProduto
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
            this.tb_nome_produto = new System.Windows.Forms.TextBox();
            this.tb_nome_subgrupo = new System.Windows.Forms.TextBox();
            this.btn_subgrupo = new System.Windows.Forms.Button();
            this.tb_codigo_subgrupo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nome_grupo = new System.Windows.Forms.TextBox();
            this.btn_cod_grupo = new System.Windows.Forms.Button();
            this.tb_codigo_grupo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nome_unidade = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_codigo_unidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_estoque = new System.Windows.Forms.TextBox();
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.tb_custo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.gb_status = new System.Windows.Forms.GroupBox();
            this.rb_inativo = new System.Windows.Forms.RadioButton();
            this.rb_ativo = new System.Windows.Forms.RadioButton();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.lb_mostra_id = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gb_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // tb_nome_produto
            // 
            this.tb_nome_produto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_nome_produto.Location = new System.Drawing.Point(76, 132);
            this.tb_nome_produto.Name = "tb_nome_produto";
            this.tb_nome_produto.Size = new System.Drawing.Size(326, 20);
            this.tb_nome_produto.TabIndex = 4;
            // 
            // tb_nome_subgrupo
            // 
            this.tb_nome_subgrupo.Location = new System.Drawing.Point(145, 72);
            this.tb_nome_subgrupo.Name = "tb_nome_subgrupo";
            this.tb_nome_subgrupo.ReadOnly = true;
            this.tb_nome_subgrupo.Size = new System.Drawing.Size(257, 20);
            this.tb_nome_subgrupo.TabIndex = 0;
            // 
            // btn_subgrupo
            // 
            this.btn_subgrupo.Location = new System.Drawing.Point(118, 70);
            this.btn_subgrupo.Name = "btn_subgrupo";
            this.btn_subgrupo.Size = new System.Drawing.Size(21, 23);
            this.btn_subgrupo.TabIndex = 0;
            this.btn_subgrupo.Text = "▲";
            this.btn_subgrupo.UseVisualStyleBackColor = true;
            this.btn_subgrupo.Click += new System.EventHandler(this.btn_subgrupo_Click);
            // 
            // tb_codigo_subgrupo
            // 
            this.tb_codigo_subgrupo.Location = new System.Drawing.Point(77, 72);
            this.tb_codigo_subgrupo.Name = "tb_codigo_subgrupo";
            this.tb_codigo_subgrupo.Size = new System.Drawing.Size(35, 20);
            this.tb_codigo_subgrupo.TabIndex = 2;
            this.tb_codigo_subgrupo.TextChanged += new System.EventHandler(this.tb_codigo_subgrupo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sub-Grupo";
            // 
            // tb_nome_grupo
            // 
            this.tb_nome_grupo.Location = new System.Drawing.Point(145, 40);
            this.tb_nome_grupo.Name = "tb_nome_grupo";
            this.tb_nome_grupo.ReadOnly = true;
            this.tb_nome_grupo.Size = new System.Drawing.Size(257, 20);
            this.tb_nome_grupo.TabIndex = 0;
            // 
            // btn_cod_grupo
            // 
            this.btn_cod_grupo.Location = new System.Drawing.Point(118, 38);
            this.btn_cod_grupo.Name = "btn_cod_grupo";
            this.btn_cod_grupo.Size = new System.Drawing.Size(21, 23);
            this.btn_cod_grupo.TabIndex = 0;
            this.btn_cod_grupo.Text = "▲";
            this.btn_cod_grupo.UseVisualStyleBackColor = true;
            this.btn_cod_grupo.Click += new System.EventHandler(this.btn_cod_grupo_Click);
            // 
            // tb_codigo_grupo
            // 
            this.tb_codigo_grupo.Location = new System.Drawing.Point(77, 40);
            this.tb_codigo_grupo.Name = "tb_codigo_grupo";
            this.tb_codigo_grupo.Size = new System.Drawing.Size(35, 20);
            this.tb_codigo_grupo.TabIndex = 1;
            this.tb_codigo_grupo.TextChanged += new System.EventHandler(this.tb_codigo_grupo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Grupo";
            // 
            // tb_nome_unidade
            // 
            this.tb_nome_unidade.Location = new System.Drawing.Point(145, 103);
            this.tb_nome_unidade.Name = "tb_nome_unidade";
            this.tb_nome_unidade.ReadOnly = true;
            this.tb_nome_unidade.Size = new System.Drawing.Size(257, 20);
            this.tb_nome_unidade.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "▲";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_codigo_unidade
            // 
            this.tb_codigo_unidade.Location = new System.Drawing.Point(77, 103);
            this.tb_codigo_unidade.Name = "tb_codigo_unidade";
            this.tb_codigo_unidade.Size = new System.Drawing.Size(35, 20);
            this.tb_codigo_unidade.TabIndex = 3;
            this.tb_codigo_unidade.TextChanged += new System.EventHandler(this.tb_codigo_unidade_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Unidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Estoque";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Custo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Preço";
            // 
            // tb_estoque
            // 
            this.tb_estoque.Location = new System.Drawing.Point(76, 162);
            this.tb_estoque.Name = "tb_estoque";
            this.tb_estoque.Size = new System.Drawing.Size(82, 20);
            this.tb_estoque.TabIndex = 5;
            this.tb_estoque.Text = "0";
            this.tb_estoque.TextChanged += new System.EventHandler(this.tb_estoque_TextChanged);
            // 
            // tb_preco
            // 
            this.tb_preco.Location = new System.Drawing.Point(76, 195);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(82, 20);
            this.tb_preco.TabIndex = 6;
            this.tb_preco.Text = "0";
            this.tb_preco.TextChanged += new System.EventHandler(this.tb_preco_TextChanged);
            // 
            // tb_custo
            // 
            this.tb_custo.Location = new System.Drawing.Point(76, 225);
            this.tb_custo.Name = "tb_custo";
            this.tb_custo.Size = new System.Drawing.Size(82, 20);
            this.tb_custo.TabIndex = 7;
            this.tb_custo.Text = "0";
            this.tb_custo.TextChanged += new System.EventHandler(this.tb_custo_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_tipo);
            this.groupBox1.Location = new System.Drawing.Point(235, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // cb_tipo
            // 
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Items.AddRange(new object[] {
            "Produto Acabado",
            "Materia Prima",
            "Embalagem"});
            this.cb_tipo.Location = new System.Drawing.Point(24, 15);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(121, 21);
            this.cb_tipo.TabIndex = 8;
            // 
            // gb_status
            // 
            this.gb_status.Controls.Add(this.rb_inativo);
            this.gb_status.Controls.Add(this.rb_ativo);
            this.gb_status.Location = new System.Drawing.Point(235, 213);
            this.gb_status.Name = "gb_status";
            this.gb_status.Size = new System.Drawing.Size(167, 40);
            this.gb_status.TabIndex = 22;
            this.gb_status.TabStop = false;
            this.gb_status.Text = "Status";
            // 
            // rb_inativo
            // 
            this.rb_inativo.AutoSize = true;
            this.rb_inativo.Location = new System.Drawing.Point(77, 13);
            this.rb_inativo.Name = "rb_inativo";
            this.rb_inativo.Size = new System.Drawing.Size(57, 17);
            this.rb_inativo.TabIndex = 25;
            this.rb_inativo.TabStop = true;
            this.rb_inativo.Text = "Inativo";
            this.rb_inativo.UseVisualStyleBackColor = true;
            // 
            // rb_ativo
            // 
            this.rb_ativo.AutoSize = true;
            this.rb_ativo.Location = new System.Drawing.Point(11, 13);
            this.rb_ativo.Name = "rb_ativo";
            this.rb_ativo.Size = new System.Drawing.Size(49, 17);
            this.rb_ativo.TabIndex = 9;
            this.rb_ativo.TabStop = true;
            this.rb_ativo.Text = "Ativo";
            this.rb_ativo.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(442, 20);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 59);
            this.btn_salvar.TabIndex = 12;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(442, 99);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 59);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(442, 20);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(75, 59);
            this.btn_atualizar.TabIndex = 11;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            // 
            // lb_mostra_id
            // 
            this.lb_mostra_id.AutoSize = true;
            this.lb_mostra_id.Location = new System.Drawing.Point(35, 9);
            this.lb_mostra_id.Name = "lb_mostra_id";
            this.lb_mostra_id.Size = new System.Drawing.Size(21, 13);
            this.lb_mostra_id.TabIndex = 0;
            this.lb_mostra_id.Text = "ID:";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(77, 9);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(0, 13);
            this.lb_id.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(408, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(408, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(408, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(408, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(408, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "*";
            // 
            // ManipulaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 265);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.lb_mostra_id);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.gb_status);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_custo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_preco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_estoque);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_nome_unidade);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_codigo_unidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_nome_subgrupo);
            this.Controls.Add(this.btn_subgrupo);
            this.Controls.Add(this.tb_codigo_subgrupo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nome_grupo);
            this.Controls.Add(this.btn_cod_grupo);
            this.Controls.Add(this.tb_codigo_grupo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nome_produto);
            this.Controls.Add(this.label1);
            this.Name = "ManipulaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.groupBox1.ResumeLayout(false);
            this.gb_status.ResumeLayout(false);
            this.gb_status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nome_produto;
        private System.Windows.Forms.TextBox tb_nome_subgrupo;
        private System.Windows.Forms.Button btn_subgrupo;
        private System.Windows.Forms.TextBox tb_codigo_subgrupo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nome_grupo;
        private System.Windows.Forms.Button btn_cod_grupo;
        private System.Windows.Forms.TextBox tb_codigo_grupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nome_unidade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_codigo_unidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_estoque;
        private System.Windows.Forms.TextBox tb_preco;
        private System.Windows.Forms.TextBox tb_custo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.GroupBox gb_status;
        private System.Windows.Forms.RadioButton rb_inativo;
        private System.Windows.Forms.RadioButton rb_ativo;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Label lb_mostra_id;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}