namespace Projeto_Desktop
{
    partial class Frm_Conexoes
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_conexoes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERVIDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SENHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANCO_DE_DADOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_inserirDados = new System.Windows.Forms.Button();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_conexoes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_conexoes);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 310);
            this.panel1.TabIndex = 0;
            // 
            // dgv_conexoes
            // 
            this.dgv_conexoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_conexoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SERVIDOR,
            this.USUARIO,
            this.SENHA,
            this.BANCO_DE_DADOS});
            this.dgv_conexoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_conexoes.Location = new System.Drawing.Point(0, 0);
            this.dgv_conexoes.Name = "dgv_conexoes";
            this.dgv_conexoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_conexoes.Size = new System.Drawing.Size(582, 310);
            this.dgv_conexoes.TabIndex = 0;
            this.dgv_conexoes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_conexoes_CellFormatting);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // SERVIDOR
            // 
            this.SERVIDOR.HeaderText = "SERVIDOR";
            this.SERVIDOR.Name = "SERVIDOR";
            // 
            // USUARIO
            // 
            this.USUARIO.HeaderText = "USUARIO";
            this.USUARIO.Name = "USUARIO";
            // 
            // SENHA
            // 
            this.SENHA.HeaderText = "SENHA";
            this.SENHA.Name = "SENHA";
            // 
            // BANCO_DE_DADOS
            // 
            this.BANCO_DE_DADOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.BANCO_DE_DADOS.HeaderText = "BANCO_DE_DADOS";
            this.BANCO_DE_DADOS.Name = "BANCO_DE_DADOS";
            this.BANCO_DE_DADOS.Width = 134;
            // 
            // btn_inserirDados
            // 
            this.btn_inserirDados.Location = new System.Drawing.Point(600, 12);
            this.btn_inserirDados.Name = "btn_inserirDados";
            this.btn_inserirDados.Size = new System.Drawing.Size(86, 30);
            this.btn_inserirDados.TabIndex = 1;
            this.btn_inserirDados.Text = "Inserir";
            this.btn_inserirDados.UseVisualStyleBackColor = true;
            this.btn_inserirDados.Click += new System.EventHandler(this.btn_inserirDados_Click);
            // 
            // btn_conectar
            // 
            this.btn_conectar.Location = new System.Drawing.Point(600, 86);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(86, 30);
            this.btn_conectar.TabIndex = 2;
            this.btn_conectar.Text = "Conectar";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // btn_apagar
            // 
            this.btn_apagar.Location = new System.Drawing.Point(600, 290);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(86, 29);
            this.btn_apagar.TabIndex = 3;
            this.btn_apagar.Text = "Apagar";
            this.btn_apagar.UseVisualStyleBackColor = true;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(600, 48);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(86, 32);
            this.btn_editar.TabIndex = 4;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(600, 122);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(86, 28);
            this.btn_atualizar.TabIndex = 5;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // Frm_Conexoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 337);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.btn_conectar);
            this.Controls.Add(this.btn_inserirDados);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Conexoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexão ao Banco de Dados";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_conexoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_conexoes;
        private System.Windows.Forms.Button btn_inserirDados;
        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERVIDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SENHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn BANCO_DE_DADOS;
        private System.Windows.Forms.Button btn_atualizar;
    }
}

