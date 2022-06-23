namespace Projeto_Desktop
{
    partial class Estados
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_alvo = new System.Windows.Forms.ComboBox();
            this.tb_pesquisa = new System.Windows.Forms.TextBox();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_estados = new System.Windows.Forms.DataGridView();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_extrair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_alvo);
            this.groupBox1.Location = new System.Drawing.Point(275, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 43);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alvo";
            // 
            // cb_alvo
            // 
            this.cb_alvo.FormattingEnabled = true;
            this.cb_alvo.Items.AddRange(new object[] {
            "Nome",
            "UF"});
            this.cb_alvo.Location = new System.Drawing.Point(34, 16);
            this.cb_alvo.Name = "cb_alvo";
            this.cb_alvo.Size = new System.Drawing.Size(121, 21);
            this.cb_alvo.TabIndex = 0;
            // 
            // tb_pesquisa
            // 
            this.tb_pesquisa.Location = new System.Drawing.Point(70, 56);
            this.tb_pesquisa.Name = "tb_pesquisa";
            this.tb_pesquisa.Size = new System.Drawing.Size(199, 20);
            this.tb_pesquisa.TabIndex = 2;
            // 
            // tb_codigo
            // 
            this.tb_codigo.Location = new System.Drawing.Point(70, 24);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(60, 20);
            this.tb_codigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pesquisa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // dgv_estados
            // 
            this.dgv_estados.AllowUserToAddRows = false;
            this.dgv_estados.AllowUserToDeleteRows = false;
            this.dgv_estados.AllowUserToOrderColumns = true;
            this.dgv_estados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_estados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_estados.Location = new System.Drawing.Point(14, 99);
            this.dgv_estados.Name = "dgv_estados";
            this.dgv_estados.ReadOnly = true;
            this.dgv_estados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_estados.Size = new System.Drawing.Size(522, 275);
            this.dgv_estados.TabIndex = 7;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(461, 48);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(75, 34);
            this.btn_pesquisar.TabIndex = 4;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_extrair
            // 
            this.btn_extrair.Location = new System.Drawing.Point(461, 8);
            this.btn_extrair.Name = "btn_extrair";
            this.btn_extrair.Size = new System.Drawing.Size(75, 34);
            this.btn_extrair.TabIndex = 8;
            this.btn_extrair.Text = "Extrair";
            this.btn_extrair.UseVisualStyleBackColor = true;
            this.btn_extrair.Click += new System.EventHandler(this.btn_extrair_Click);
            // 
            // Estados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 390);
            this.Controls.Add(this.btn_extrair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_pesquisa);
            this.Controls.Add(this.tb_codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_estados);
            this.Controls.Add(this.btn_pesquisar);
            this.Name = "Estados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estados";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_alvo;
        private System.Windows.Forms.TextBox tb_pesquisa;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_estados;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_extrair;
    }
}