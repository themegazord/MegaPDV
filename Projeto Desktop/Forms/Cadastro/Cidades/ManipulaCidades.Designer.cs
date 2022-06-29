namespace Projeto_Desktop
{
    partial class ManipulaCidades
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_mostra_id = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.tb_nome_cidade = new System.Windows.Forms.TextBox();
            this.tb_ibge = new System.Windows.Forms.TextBox();
            this.tb_tom = new System.Windows.Forms.TextBox();
            this.btn_busca_cidade = new System.Windows.Forms.Button();
            this.tb_codigo_estado = new System.Windows.Forms.TextBox();
            this.tb_nome_estado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IBGE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Código TOM (SERPRO)";
            // 
            // lb_mostra_id
            // 
            this.lb_mostra_id.AutoSize = true;
            this.lb_mostra_id.Location = new System.Drawing.Point(354, 20);
            this.lb_mostra_id.Name = "lb_mostra_id";
            this.lb_mostra_id.Size = new System.Drawing.Size(21, 13);
            this.lb_mostra_id.TabIndex = 4;
            this.lb_mostra_id.Text = "ID:";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(381, 20);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(0, 13);
            this.lb_id.TabIndex = 5;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(474, 12);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 60);
            this.btn_salvar.TabIndex = 6;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(474, 91);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 60);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(474, 12);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(75, 60);
            this.btn_atualizar.TabIndex = 8;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // tb_nome_cidade
            // 
            this.tb_nome_cidade.Location = new System.Drawing.Point(63, 17);
            this.tb_nome_cidade.Name = "tb_nome_cidade";
            this.tb_nome_cidade.Size = new System.Drawing.Size(260, 20);
            this.tb_nome_cidade.TabIndex = 9;
            // 
            // tb_ibge
            // 
            this.tb_ibge.Location = new System.Drawing.Point(63, 53);
            this.tb_ibge.Name = "tb_ibge";
            this.tb_ibge.Size = new System.Drawing.Size(77, 20);
            this.tb_ibge.TabIndex = 10;
            // 
            // tb_tom
            // 
            this.tb_tom.Location = new System.Drawing.Point(149, 88);
            this.tb_tom.Name = "tb_tom";
            this.tb_tom.Size = new System.Drawing.Size(77, 20);
            this.tb_tom.TabIndex = 11;
            // 
            // btn_busca_cidade
            // 
            this.btn_busca_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busca_cidade.Location = new System.Drawing.Point(116, 121);
            this.btn_busca_cidade.Name = "btn_busca_cidade";
            this.btn_busca_cidade.Size = new System.Drawing.Size(21, 21);
            this.btn_busca_cidade.TabIndex = 0;
            this.btn_busca_cidade.Text = "▲";
            this.btn_busca_cidade.UseVisualStyleBackColor = true;
            this.btn_busca_cidade.Click += new System.EventHandler(this.btn_busca_cidade_Click);
            // 
            // tb_codigo_estado
            // 
            this.tb_codigo_estado.Location = new System.Drawing.Point(71, 121);
            this.tb_codigo_estado.Name = "tb_codigo_estado";
            this.tb_codigo_estado.Size = new System.Drawing.Size(39, 20);
            this.tb_codigo_estado.TabIndex = 16;
            this.tb_codigo_estado.TextChanged += new System.EventHandler(this.tb_codigo_estado_TextChanged);
            // 
            // tb_nome_estado
            // 
            this.tb_nome_estado.Location = new System.Drawing.Point(143, 121);
            this.tb_nome_estado.Name = "tb_nome_estado";
            this.tb_nome_estado.ReadOnly = true;
            this.tb_nome_estado.Size = new System.Drawing.Size(251, 20);
            this.tb_nome_estado.TabIndex = 17;
            // 
            // ManipulaCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 172);
            this.Controls.Add(this.btn_busca_cidade);
            this.Controls.Add(this.tb_codigo_estado);
            this.Controls.Add(this.tb_nome_estado);
            this.Controls.Add(this.tb_tom);
            this.Controls.Add(this.tb_ibge);
            this.Controls.Add(this.tb_nome_cidade);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.lb_mostra_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManipulaCidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cidades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_mostra_id;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.TextBox tb_nome_cidade;
        private System.Windows.Forms.TextBox tb_ibge;
        private System.Windows.Forms.TextBox tb_tom;
        private System.Windows.Forms.Button btn_busca_cidade;
        private System.Windows.Forms.TextBox tb_codigo_estado;
        private System.Windows.Forms.TextBox tb_nome_estado;
    }
}