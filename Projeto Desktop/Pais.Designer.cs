namespace Projeto_Desktop
{
    partial class Pais
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
            this.dgv_pais = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.tb_pesquisa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_alvo = new System.Windows.Forms.ComboBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pais)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_pais
            // 
            this.dgv_pais.AllowUserToAddRows = false;
            this.dgv_pais.AllowUserToDeleteRows = false;
            this.dgv_pais.AllowUserToOrderColumns = true;
            this.dgv_pais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pais.Location = new System.Drawing.Point(12, 107);
            this.dgv_pais.Name = "dgv_pais";
            this.dgv_pais.ReadOnly = true;
            this.dgv_pais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pais.Size = new System.Drawing.Size(522, 275);
            this.dgv_pais.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pesquisa";
            // 
            // tb_codigo
            // 
            this.tb_codigo.Location = new System.Drawing.Point(68, 32);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(60, 20);
            this.tb_codigo.TabIndex = 1;
            // 
            // tb_pesquisa
            // 
            this.tb_pesquisa.Location = new System.Drawing.Point(68, 64);
            this.tb_pesquisa.Name = "tb_pesquisa";
            this.tb_pesquisa.Size = new System.Drawing.Size(199, 20);
            this.tb_pesquisa.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_alvo);
            this.groupBox1.Location = new System.Drawing.Point(273, 27);
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
            "Sigla",
            "BACEN"});
            this.cb_alvo.Location = new System.Drawing.Point(34, 16);
            this.cb_alvo.Name = "cb_alvo";
            this.cb_alvo.Size = new System.Drawing.Size(121, 21);
            this.cb_alvo.TabIndex = 0;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(459, 35);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(75, 66);
            this.btn_pesquisar.TabIndex = 4;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // Pais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 394);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_pesquisa);
            this.Controls.Add(this.tb_codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_pais);
            this.Name = "Pais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pais";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pais)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_pais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.TextBox tb_pesquisa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_alvo;
        private System.Windows.Forms.Button btn_pesquisar;
    }
}