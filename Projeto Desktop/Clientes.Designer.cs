namespace Projeto_Desktop
{
    partial class Clientes
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
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_codigo_cliente = new System.Windows.Forms.TextBox();
            this.tb_pesquisa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_cod_vendedor = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_busca_vendedor = new System.Windows.Forms.Button();
            this.cb_alvo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_ativo = new System.Windows.Forms.RadioButton();
            this.rb_inativo = new System.Windows.Forms.RadioButton();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_pf = new System.Windows.Forms.CheckBox();
            this.cb_pj = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Location = new System.Drawing.Point(12, 143);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.Size = new System.Drawing.Size(736, 306);
            this.dgv_clientes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.imprimirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pesquisa";
            // 
            // tb_codigo_cliente
            // 
            this.tb_codigo_cliente.Location = new System.Drawing.Point(68, 33);
            this.tb_codigo_cliente.Name = "tb_codigo_cliente";
            this.tb_codigo_cliente.Size = new System.Drawing.Size(59, 20);
            this.tb_codigo_cliente.TabIndex = 1;
            // 
            // tb_pesquisa
            // 
            this.tb_pesquisa.Location = new System.Drawing.Point(68, 68);
            this.tb_pesquisa.Name = "tb_pesquisa";
            this.tb_pesquisa.Size = new System.Drawing.Size(329, 20);
            this.tb_pesquisa.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vendedor";
            // 
            // tb_cod_vendedor
            // 
            this.tb_cod_vendedor.Location = new System.Drawing.Point(68, 107);
            this.tb_cod_vendedor.Name = "tb_cod_vendedor";
            this.tb_cod_vendedor.Size = new System.Drawing.Size(28, 20);
            this.tb_cod_vendedor.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(129, 107);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(268, 20);
            this.textBox4.TabIndex = 8;
            // 
            // btn_busca_vendedor
            // 
            this.btn_busca_vendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busca_vendedor.Location = new System.Drawing.Point(102, 107);
            this.btn_busca_vendedor.Name = "btn_busca_vendedor";
            this.btn_busca_vendedor.Size = new System.Drawing.Size(21, 20);
            this.btn_busca_vendedor.TabIndex = 9;
            this.btn_busca_vendedor.Text = "▲";
            this.btn_busca_vendedor.UseVisualStyleBackColor = true;
            // 
            // cb_alvo
            // 
            this.cb_alvo.FormattingEnabled = true;
            this.cb_alvo.Items.AddRange(new object[] {
            "Nome do cliente",
            "CPF",
            "CNPJ",
            "Endereço",
            "Telefone"});
            this.cb_alvo.Location = new System.Drawing.Point(55, 14);
            this.cb_alvo.Name = "cb_alvo";
            this.cb_alvo.Size = new System.Drawing.Size(121, 21);
            this.cb_alvo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Alvo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_alvo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(432, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 41);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_todos);
            this.groupBox2.Controls.Add(this.rb_inativo);
            this.groupBox2.Controls.Add(this.rb_ativo);
            this.groupBox2.Location = new System.Drawing.Point(432, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 46);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ativo ?";
            // 
            // rb_ativo
            // 
            this.rb_ativo.AutoSize = true;
            this.rb_ativo.Location = new System.Drawing.Point(4, 19);
            this.rb_ativo.Name = "rb_ativo";
            this.rb_ativo.Size = new System.Drawing.Size(49, 17);
            this.rb_ativo.TabIndex = 5;
            this.rb_ativo.TabStop = true;
            this.rb_ativo.Text = "Ativo";
            this.rb_ativo.UseVisualStyleBackColor = true;
            // 
            // rb_inativo
            // 
            this.rb_inativo.AutoSize = true;
            this.rb_inativo.Location = new System.Drawing.Point(55, 19);
            this.rb_inativo.Name = "rb_inativo";
            this.rb_inativo.Size = new System.Drawing.Size(57, 17);
            this.rb_inativo.TabIndex = 14;
            this.rb_inativo.TabStop = true;
            this.rb_inativo.Text = "Inativo";
            this.rb_inativo.UseVisualStyleBackColor = true;
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Location = new System.Drawing.Point(118, 19);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(55, 17);
            this.rb_todos.TabIndex = 14;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Todos";
            this.rb_todos.UseVisualStyleBackColor = true;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(620, 92);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(128, 45);
            this.btn_pesquisar.TabIndex = 7;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_pj);
            this.groupBox3.Controls.Add(this.cb_pf);
            this.groupBox3.Location = new System.Drawing.Point(620, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 61);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PF / PJ";
            // 
            // cb_pf
            // 
            this.cb_pf.AutoSize = true;
            this.cb_pf.Location = new System.Drawing.Point(6, 18);
            this.cb_pf.Name = "cb_pf";
            this.cb_pf.Size = new System.Drawing.Size(91, 17);
            this.cb_pf.TabIndex = 17;
            this.cb_pf.Text = "Pessoa Fisica";
            this.cb_pf.UseVisualStyleBackColor = true;
            // 
            // cb_pj
            // 
            this.cb_pj.AutoSize = true;
            this.cb_pj.Location = new System.Drawing.Point(6, 38);
            this.cb_pj.Name = "cb_pj";
            this.cb_pj.Size = new System.Drawing.Size(100, 17);
            this.cb_pj.TabIndex = 18;
            this.cb_pj.Text = "Pessoa Juridica";
            this.cb_pj.UseVisualStyleBackColor = true;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 461);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_busca_vendedor);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.tb_cod_vendedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_pesquisa);
            this.Controls.Add(this.tb_codigo_cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_clientes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_codigo_cliente;
        private System.Windows.Forms.TextBox tb_pesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_cod_vendedor;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_busca_vendedor;
        private System.Windows.Forms.ComboBox cb_alvo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_todos;
        private System.Windows.Forms.RadioButton rb_inativo;
        private System.Windows.Forms.RadioButton rb_ativo;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cb_pf;
        private System.Windows.Forms.CheckBox cb_pj;
    }
}