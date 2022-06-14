namespace Projeto_Desktop
{
    partial class DadosConexao
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
            this.lb_servidor = new System.Windows.Forms.Label();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.lb_senha = new System.Windows.Forms.Label();
            this.lb_bd = new System.Windows.Forms.Label();
            this.tb_servidor = new System.Windows.Forms.TextBox();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.tb_banco = new System.Windows.Forms.TextBox();
            this.btn_testaConexao = new System.Windows.Forms.Button();
            this.btn_gravarConexao = new System.Windows.Forms.Button();
            this.lb_idconn = new System.Windows.Forms.Label();
            this.tb_idconn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_servidor
            // 
            this.lb_servidor.AutoSize = true;
            this.lb_servidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_servidor.Location = new System.Drawing.Point(37, 67);
            this.lb_servidor.Name = "lb_servidor";
            this.lb_servidor.Size = new System.Drawing.Size(69, 17);
            this.lb_servidor.TabIndex = 0;
            this.lb_servidor.Text = "Servidor";
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_usuario.Location = new System.Drawing.Point(37, 120);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(64, 17);
            this.lb_usuario.TabIndex = 1;
            this.lb_usuario.Text = "Usuário";
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_senha.Location = new System.Drawing.Point(37, 175);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(54, 17);
            this.lb_senha.TabIndex = 2;
            this.lb_senha.Text = "Senha";
            // 
            // lb_bd
            // 
            this.lb_bd.AutoSize = true;
            this.lb_bd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bd.Location = new System.Drawing.Point(37, 238);
            this.lb_bd.Name = "lb_bd";
            this.lb_bd.Size = new System.Drawing.Size(127, 17);
            this.lb_bd.TabIndex = 3;
            this.lb_bd.Text = "Banco de Dados";
            // 
            // tb_servidor
            // 
            this.tb_servidor.Location = new System.Drawing.Point(173, 67);
            this.tb_servidor.Name = "tb_servidor";
            this.tb_servidor.Size = new System.Drawing.Size(139, 20);
            this.tb_servidor.TabIndex = 4;
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(173, 120);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(139, 20);
            this.tb_usuario.TabIndex = 5;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(173, 175);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(139, 20);
            this.tb_senha.TabIndex = 6;
            // 
            // tb_banco
            // 
            this.tb_banco.Location = new System.Drawing.Point(173, 238);
            this.tb_banco.Name = "tb_banco";
            this.tb_banco.Size = new System.Drawing.Size(139, 20);
            this.tb_banco.TabIndex = 7;
            // 
            // btn_testaConexao
            // 
            this.btn_testaConexao.Location = new System.Drawing.Point(40, 306);
            this.btn_testaConexao.Name = "btn_testaConexao";
            this.btn_testaConexao.Size = new System.Drawing.Size(98, 23);
            this.btn_testaConexao.TabIndex = 8;
            this.btn_testaConexao.Text = "Testa Conexão";
            this.btn_testaConexao.UseVisualStyleBackColor = true;
            this.btn_testaConexao.Click += new System.EventHandler(this.btn_testaConexao_Click);
            // 
            // btn_gravarConexao
            // 
            this.btn_gravarConexao.Location = new System.Drawing.Point(208, 306);
            this.btn_gravarConexao.Name = "btn_gravarConexao";
            this.btn_gravarConexao.Size = new System.Drawing.Size(104, 23);
            this.btn_gravarConexao.TabIndex = 9;
            this.btn_gravarConexao.Text = "Gravar";
            this.btn_gravarConexao.UseVisualStyleBackColor = true;
            this.btn_gravarConexao.Click += new System.EventHandler(this.btn_gravarConexao_Click);
            // 
            // lb_idconn
            // 
            this.lb_idconn.AutoSize = true;
            this.lb_idconn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idconn.Location = new System.Drawing.Point(37, 22);
            this.lb_idconn.Name = "lb_idconn";
            this.lb_idconn.Size = new System.Drawing.Size(90, 17);
            this.lb_idconn.TabIndex = 10;
            this.lb_idconn.Text = "ID Conexão";
            // 
            // tb_idconn
            // 
            this.tb_idconn.Location = new System.Drawing.Point(173, 22);
            this.tb_idconn.Name = "tb_idconn";
            this.tb_idconn.Size = new System.Drawing.Size(139, 20);
            this.tb_idconn.TabIndex = 11;
            // 
            // DadosConexao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 350);
            this.Controls.Add(this.tb_idconn);
            this.Controls.Add(this.lb_idconn);
            this.Controls.Add(this.btn_gravarConexao);
            this.Controls.Add(this.btn_testaConexao);
            this.Controls.Add(this.tb_banco);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.tb_servidor);
            this.Controls.Add(this.lb_bd);
            this.Controls.Add(this.lb_senha);
            this.Controls.Add(this.lb_usuario);
            this.Controls.Add(this.lb_servidor);
            this.Name = "DadosConexao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DadosConexao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_servidor;
        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.Label lb_bd;
        private System.Windows.Forms.TextBox tb_servidor;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.TextBox tb_banco;
        private System.Windows.Forms.Button btn_testaConexao;
        private System.Windows.Forms.Button btn_gravarConexao;
        private System.Windows.Forms.Label lb_idconn;
        private System.Windows.Forms.TextBox tb_idconn;
    }
}