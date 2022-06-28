namespace Projeto_Desktop
{
    partial class SubGrupo
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.rb_inativo = new System.Windows.Forms.RadioButton();
            this.rb_ativo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_subgrupos = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_extrair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_subgrupos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(356, 105);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 27);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(356, 66);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(75, 29);
            this.btn_pesquisar.TabIndex = 4;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Location = new System.Drawing.Point(183, 103);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(55, 17);
            this.rb_todos.TabIndex = 22;
            this.rb_todos.Text = "Todos";
            this.rb_todos.UseVisualStyleBackColor = true;
            // 
            // rb_inativo
            // 
            this.rb_inativo.AutoSize = true;
            this.rb_inativo.Location = new System.Drawing.Point(120, 103);
            this.rb_inativo.Name = "rb_inativo";
            this.rb_inativo.Size = new System.Drawing.Size(57, 17);
            this.rb_inativo.TabIndex = 21;
            this.rb_inativo.Text = "Inativo";
            this.rb_inativo.UseVisualStyleBackColor = true;
            // 
            // rb_ativo
            // 
            this.rb_ativo.AutoSize = true;
            this.rb_ativo.Checked = true;
            this.rb_ativo.Location = new System.Drawing.Point(65, 103);
            this.rb_ativo.Name = "rb_ativo";
            this.rb_ativo.Size = new System.Drawing.Size(49, 17);
            this.rb_ativo.TabIndex = 3;
            this.rb_ativo.TabStop = true;
            this.rb_ativo.Text = "Ativo";
            this.rb_ativo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Status";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(63, 67);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(232, 20);
            this.tb_nome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // tb_codigo
            // 
            this.tb_codigo.Location = new System.Drawing.Point(63, 36);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(56, 20);
            this.tb_codigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // dgv_subgrupos
            // 
            this.dgv_subgrupos.AllowUserToAddRows = false;
            this.dgv_subgrupos.AllowUserToDeleteRows = false;
            this.dgv_subgrupos.AllowUserToOrderColumns = true;
            this.dgv_subgrupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_subgrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_subgrupos.Location = new System.Drawing.Point(12, 141);
            this.dgv_subgrupos.Name = "dgv_subgrupos";
            this.dgv_subgrupos.ReadOnly = true;
            this.dgv_subgrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_subgrupos.Size = new System.Drawing.Size(419, 217);
            this.dgv_subgrupos.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(443, 24);
            this.menuStrip1.TabIndex = 23;
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
            // btn_extrair
            // 
            this.btn_extrair.Location = new System.Drawing.Point(356, 27);
            this.btn_extrair.Name = "btn_extrair";
            this.btn_extrair.Size = new System.Drawing.Size(75, 29);
            this.btn_extrair.TabIndex = 24;
            this.btn_extrair.Text = "Extrair";
            this.btn_extrair.UseVisualStyleBackColor = true;
            this.btn_extrair.Click += new System.EventHandler(this.btn_extrair_Click);
            // 
            // SubGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 370);
            this.Controls.Add(this.btn_extrair);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.rb_todos);
            this.Controls.Add(this.rb_inativo);
            this.Controls.Add(this.rb_ativo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_codigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_subgrupos);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SubGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sub-Grupo";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_subgrupos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.RadioButton rb_todos;
        private System.Windows.Forms.RadioButton rb_inativo;
        private System.Windows.Forms.RadioButton rb_ativo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_subgrupos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.Button btn_extrair;
    }
}