namespace Projeto_Desktop
{
    partial class Usuarios
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
            System.Windows.Forms.GroupBox gb_ativo;
            this.rb_inativo = new System.Windows.Forms.RadioButton();
            this.rb_ativo = new System.Windows.Forms.RadioButton();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_codusu = new System.Windows.Forms.TextBox();
            this.tb_nomusu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msi_novo = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_editar = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_excluir = new System.Windows.Forms.ToolStripMenuItem();
            gb_ativo = new System.Windows.Forms.GroupBox();
            gb_ativo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_ativo
            // 
            gb_ativo.Controls.Add(this.rb_inativo);
            gb_ativo.Controls.Add(this.rb_ativo);
            gb_ativo.Location = new System.Drawing.Point(297, 40);
            gb_ativo.Name = "gb_ativo";
            gb_ativo.Size = new System.Drawing.Size(157, 37);
            gb_ativo.TabIndex = 6;
            gb_ativo.TabStop = false;
            gb_ativo.Text = "Situação";
            // 
            // rb_inativo
            // 
            this.rb_inativo.AutoSize = true;
            this.rb_inativo.Location = new System.Drawing.Point(88, 14);
            this.rb_inativo.Name = "rb_inativo";
            this.rb_inativo.Size = new System.Drawing.Size(57, 17);
            this.rb_inativo.TabIndex = 6;
            this.rb_inativo.TabStop = true;
            this.rb_inativo.Text = "Inativo";
            this.rb_inativo.UseVisualStyleBackColor = true;
            // 
            // rb_ativo
            // 
            this.rb_ativo.AutoSize = true;
            this.rb_ativo.Checked = true;
            this.rb_ativo.Location = new System.Drawing.Point(6, 14);
            this.rb_ativo.Name = "rb_ativo";
            this.rb_ativo.Size = new System.Drawing.Size(49, 17);
            this.rb_ativo.TabIndex = 5;
            this.rb_ativo.TabStop = true;
            this.rb_ativo.Text = "Ativo";
            this.rb_ativo.UseVisualStyleBackColor = true;
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AllowUserToAddRows = false;
            this.dgv_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Location = new System.Drawing.Point(12, 96);
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.ReadOnly = true;
            this.dgv_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_usuarios.Size = new System.Drawing.Size(534, 305);
            this.dgv_usuarios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // tb_codusu
            // 
            this.tb_codusu.Location = new System.Drawing.Point(26, 57);
            this.tb_codusu.Name = "tb_codusu";
            this.tb_codusu.Size = new System.Drawing.Size(54, 20);
            this.tb_codusu.TabIndex = 2;
            // 
            // tb_nomusu
            // 
            this.tb_nomusu.Location = new System.Drawing.Point(99, 57);
            this.tb_nomusu.Name = "tb_nomusu";
            this.tb_nomusu.Size = new System.Drawing.Size(174, 20);
            this.tb_nomusu.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome do Usuário";
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(471, 41);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(75, 33);
            this.btn_pesquisar.TabIndex = 7;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msi_novo,
            this.msi_editar,
            this.msi_excluir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msi_novo
            // 
            this.msi_novo.Name = "msi_novo";
            this.msi_novo.Size = new System.Drawing.Size(48, 20);
            this.msi_novo.Text = "Novo";
            this.msi_novo.Click += new System.EventHandler(this.msi_novo_Click);
            // 
            // msi_editar
            // 
            this.msi_editar.Name = "msi_editar";
            this.msi_editar.Size = new System.Drawing.Size(49, 20);
            this.msi_editar.Text = "Editar";
            this.msi_editar.Click += new System.EventHandler(this.msi_editar_Click);
            // 
            // msi_excluir
            // 
            this.msi_excluir.Name = "msi_excluir";
            this.msi_excluir.Size = new System.Drawing.Size(54, 20);
            this.msi_excluir.Text = "Excluir";
            this.msi_excluir.Click += new System.EventHandler(this.msi_excluir_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 414);
            this.Controls.Add(this.dgv_usuarios);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(gb_ativo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_codusu);
            this.Controls.Add(this.tb_nomusu);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Usuários";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            gb_ativo.ResumeLayout(false);
            gb_ativo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_codusu;
        private System.Windows.Forms.TextBox tb_nomusu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_ativo;
        private System.Windows.Forms.RadioButton rb_inativo;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msi_novo;
        private System.Windows.Forms.ToolStripMenuItem msi_editar;
        private System.Windows.Forms.ToolStripMenuItem msi_excluir;
    }
}