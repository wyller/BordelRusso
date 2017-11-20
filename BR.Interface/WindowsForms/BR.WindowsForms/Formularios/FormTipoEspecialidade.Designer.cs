namespace BR.WindowsForms.Formularios
{
    partial class FormTipoEspecialidade
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
            this.lbl_DescricaoEspecialidade = new System.Windows.Forms.Label();
            this.txt_DescricaoEspecialidade = new System.Windows.Forms.TextBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.grid_TipoEspecialidade = new System.Windows.Forms.DataGridView();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_TipoEspecialidade)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_DescricaoEspecialidade
            // 
            this.lbl_DescricaoEspecialidade.AutoSize = true;
            this.lbl_DescricaoEspecialidade.Location = new System.Drawing.Point(42, 85);
            this.lbl_DescricaoEspecialidade.Name = "lbl_DescricaoEspecialidade";
            this.lbl_DescricaoEspecialidade.Size = new System.Drawing.Size(55, 13);
            this.lbl_DescricaoEspecialidade.TabIndex = 0;
            this.lbl_DescricaoEspecialidade.Text = "Descrição";
            // 
            // txt_DescricaoEspecialidade
            // 
            this.txt_DescricaoEspecialidade.Location = new System.Drawing.Point(104, 85);
            this.txt_DescricaoEspecialidade.Name = "txt_DescricaoEspecialidade";
            this.txt_DescricaoEspecialidade.Size = new System.Drawing.Size(395, 20);
            this.txt_DescricaoEspecialidade.TabIndex = 1;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(24, 136);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(100, 23);
            this.btn_Salvar.TabIndex = 2;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // grid_TipoEspecialidade
            // 
            this.grid_TipoEspecialidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_TipoEspecialidade.Location = new System.Drawing.Point(12, 165);
            this.grid_TipoEspecialidade.Name = "grid_TipoEspecialidade";
            this.grid_TipoEspecialidade.Size = new System.Drawing.Size(615, 150);
            this.grid_TipoEspecialidade.TabIndex = 3;
            this.grid_TipoEspecialidade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_TipoEspecialidade_CellContentClick);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(271, 136);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(100, 23);
            this.btn_Editar.TabIndex = 4;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(518, 136);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(100, 23);
            this.btn_Excluir.TabIndex = 5;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // FormTipoEspecialidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 327);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.grid_TipoEspecialidade);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.txt_DescricaoEspecialidade);
            this.Controls.Add(this.lbl_DescricaoEspecialidade);
            this.Name = "FormTipoEspecialidade";
            this.Text = "FormTipoEspecialidade";
            this.Load += new System.EventHandler(this.FormTipoEspecialidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_TipoEspecialidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DescricaoEspecialidade;
        private System.Windows.Forms.TextBox txt_DescricaoEspecialidade;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.DataGridView grid_TipoEspecialidade;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Excluir;
    }
}