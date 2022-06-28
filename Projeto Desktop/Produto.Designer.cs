namespace Projeto_Desktop
{
    partial class Produto
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
            this.dgv_produtos = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.tb_codigo_grupo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cod_grupo = new System.Windows.Forms.Button();
            this.tb_nome_grupo = new System.Windows.Forms.TextBox();
            this.tb_nome_subgrupo = new System.Windows.Forms.TextBox();
            this.btn_subgrupo = new System.Windows.Forms.Button();
            this.tb_codigo_subgrupo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_produtos
            // 
            this.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produtos.Location = new System.Drawing.Point(10, 170);
            this.dgv_produtos.Name = "dgv_produtos";
            this.dgv_produtos.Size = new System.Drawing.Size(731, 304);
            this.dgv_produtos.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 24);
            this.menuStrip1.TabIndex = 1;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // tb_codigo
            // 
            this.tb_codigo.Location = new System.Drawing.Point(71, 39);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(35, 20);
            this.tb_codigo.TabIndex = 1;
            // 
            // tb_codigo_grupo
            // 
            this.tb_codigo_grupo.Location = new System.Drawing.Point(71, 71);
            this.tb_codigo_grupo.Name = "tb_codigo_grupo";
            this.tb_codigo_grupo.Size = new System.Drawing.Size(35, 20);
            this.tb_codigo_grupo.TabIndex = 2;
            this.tb_codigo_grupo.TextChanged += new System.EventHandler(this.tb_codigo_grupo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Grupo";
            // 
            // btn_cod_grupo
            // 
            this.btn_cod_grupo.Location = new System.Drawing.Point(112, 69);
            this.btn_cod_grupo.Name = "btn_cod_grupo";
            this.btn_cod_grupo.Size = new System.Drawing.Size(21, 23);
            this.btn_cod_grupo.TabIndex = 0;
            this.btn_cod_grupo.Text = "▲";
            this.btn_cod_grupo.UseVisualStyleBackColor = true;
            this.btn_cod_grupo.Click += new System.EventHandler(this.btn_cod_grupo_Click);
            // 
            // tb_nome_grupo
            // 
            this.tb_nome_grupo.Location = new System.Drawing.Point(139, 71);
            this.tb_nome_grupo.Name = "tb_nome_grupo";
            this.tb_nome_grupo.ReadOnly = true;
            this.tb_nome_grupo.Size = new System.Drawing.Size(257, 20);
            this.tb_nome_grupo.TabIndex = 0;
            // 
            // tb_nome_subgrupo
            // 
            this.tb_nome_subgrupo.Location = new System.Drawing.Point(139, 103);
            this.tb_nome_subgrupo.Name = "tb_nome_subgrupo";
            this.tb_nome_subgrupo.ReadOnly = true;
            this.tb_nome_subgrupo.Size = new System.Drawing.Size(257, 20);
            this.tb_nome_subgrupo.TabIndex = 0;
            // 
            // btn_subgrupo
            // 
            this.btn_subgrupo.Location = new System.Drawing.Point(112, 101);
            this.btn_subgrupo.Name = "btn_subgrupo";
            this.btn_subgrupo.Size = new System.Drawing.Size(21, 23);
            this.btn_subgrupo.TabIndex = 0;
            this.btn_subgrupo.Text = "▲";
            this.btn_subgrupo.UseVisualStyleBackColor = true;
            this.btn_subgrupo.Click += new System.EventHandler(this.btn_subgrupo_Click);
            // 
            // tb_codigo_subgrupo
            // 
            this.tb_codigo_subgrupo.Location = new System.Drawing.Point(71, 103);
            this.tb_codigo_subgrupo.Name = "tb_codigo_subgrupo";
            this.tb_codigo_subgrupo.Size = new System.Drawing.Size(35, 20);
            this.tb_codigo_subgrupo.TabIndex = 3;
            this.tb_codigo_subgrupo.TextChanged += new System.EventHandler(this.tb_codigo_subgrupo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sub-Grupo";
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(71, 133);
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(325, 20);
            this.tb_descricao.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Descrição";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.excluirToolStripMenuItem.Text = "Excluir";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_status);
            this.groupBox1.Location = new System.Drawing.Point(443, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "Todos",
            "Ativo",
            "Inativo"});
            this.cb_status.Location = new System.Drawing.Point(15, 18);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(121, 21);
            this.cb_status.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_tipo);
            this.groupBox2.Location = new System.Drawing.Point(443, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 48);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo";
            // 
            // cb_tipo
            // 
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Items.AddRange(new object[] {
            "Produto Acabado",
            "Matéria Prima",
            "Embalagem"});
            this.cb_tipo.Location = new System.Drawing.Point(15, 18);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(121, 21);
            this.cb_tipo.TabIndex = 6;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(632, 110);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(109, 45);
            this.btn_pesquisar.TabIndex = 7;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 486);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_nome_subgrupo);
            this.Controls.Add(this.btn_subgrupo);
            this.Controls.Add(this.tb_codigo_subgrupo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nome_grupo);
            this.Controls.Add(this.btn_cod_grupo);
            this.Controls.Add(this.tb_codigo_grupo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_codigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_produtos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_produtos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.TextBox tb_codigo_grupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cod_grupo;
        private System.Windows.Forms.TextBox tb_nome_grupo;
        private System.Windows.Forms.TextBox tb_nome_subgrupo;
        private System.Windows.Forms.Button btn_subgrupo;
        private System.Windows.Forms.TextBox tb_codigo_subgrupo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.Button btn_pesquisar;
    }
}