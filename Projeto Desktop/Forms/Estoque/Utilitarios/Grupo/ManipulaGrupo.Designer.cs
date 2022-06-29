namespace Projeto_Desktop
{
    partial class ManipulaGrupo
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
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.lb_mostra_id = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.gb_status = new System.Windows.Forms.GroupBox();
            this.gb_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // tb_nome
            // 
            this.tb_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_nome.Location = new System.Drawing.Point(74, 66);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(173, 20);
            this.tb_nome.TabIndex = 1;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(424, 12);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(88, 64);
            this.btn_salvar.TabIndex = 2;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(424, 94);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(88, 64);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Location = new System.Drawing.Point(424, 12);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(88, 64);
            this.btn_atualizar.TabIndex = 4;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // lb_mostra_id
            // 
            this.lb_mostra_id.AutoSize = true;
            this.lb_mostra_id.Location = new System.Drawing.Point(38, 21);
            this.lb_mostra_id.Name = "lb_mostra_id";
            this.lb_mostra_id.Size = new System.Drawing.Size(21, 13);
            this.lb_mostra_id.TabIndex = 5;
            this.lb_mostra_id.Text = "ID:";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(71, 21);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(0, 13);
            this.lb_id.TabIndex = 6;
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cb_status.Location = new System.Drawing.Point(15, 19);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(121, 21);
            this.cb_status.TabIndex = 7;
            // 
            // gb_status
            // 
            this.gb_status.Controls.Add(this.cb_status);
            this.gb_status.Location = new System.Drawing.Point(254, 12);
            this.gb_status.Name = "gb_status";
            this.gb_status.Size = new System.Drawing.Size(152, 46);
            this.gb_status.TabIndex = 8;
            this.gb_status.TabStop = false;
            this.gb_status.Text = "Status";
            // 
            // ManipulaGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 171);
            this.Controls.Add(this.gb_status);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.lb_mostra_id);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label1);
            this.Name = "ManipulaGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Grupos";
            this.gb_status.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Label lb_mostra_id;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.GroupBox gb_status;
    }
}