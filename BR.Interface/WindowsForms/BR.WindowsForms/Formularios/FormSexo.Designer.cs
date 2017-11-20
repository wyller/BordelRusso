namespace BR.WindowsForms.Formularios
{
    partial class FormSexo
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
            this.lbl_descricaoSexo = new System.Windows.Forms.Label();
            this.txt_TipoSexo = new System.Windows.Forms.TextBox();
            this.grid_TipoSexo = new System.Windows.Forms.DataGridView();
            this.btn_SalvarSexo = new System.Windows.Forms.Button();
            this.btn_EditarSexo = new System.Windows.Forms.Button();
            this.btn_ExcluirSexo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_TipoSexo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_descricaoSexo
            // 
            this.lbl_descricaoSexo.AutoSize = true;
            this.lbl_descricaoSexo.Location = new System.Drawing.Point(40, 79);
            this.lbl_descricaoSexo.Name = "lbl_descricaoSexo";
            this.lbl_descricaoSexo.Size = new System.Drawing.Size(31, 13);
            this.lbl_descricaoSexo.TabIndex = 0;
            this.lbl_descricaoSexo.Text = "Sexo";
            this.lbl_descricaoSexo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_TipoSexo
            // 
            this.txt_TipoSexo.Location = new System.Drawing.Point(77, 76);
            this.txt_TipoSexo.Name = "txt_TipoSexo";
            this.txt_TipoSexo.Size = new System.Drawing.Size(376, 20);
            this.txt_TipoSexo.TabIndex = 1;
            // 
            // grid_TipoSexo
            // 
            this.grid_TipoSexo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_TipoSexo.Location = new System.Drawing.Point(12, 173);
            this.grid_TipoSexo.Name = "grid_TipoSexo";
            this.grid_TipoSexo.Size = new System.Drawing.Size(612, 127);
            this.grid_TipoSexo.TabIndex = 2;
            // 
            // btn_SalvarSexo
            // 
            this.btn_SalvarSexo.Location = new System.Drawing.Point(24, 144);
            this.btn_SalvarSexo.Name = "btn_SalvarSexo";
            this.btn_SalvarSexo.Size = new System.Drawing.Size(97, 23);
            this.btn_SalvarSexo.TabIndex = 3;
            this.btn_SalvarSexo.Text = "Salvar";
            this.btn_SalvarSexo.UseVisualStyleBackColor = true;
            this.btn_SalvarSexo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_EditarSexo
            // 
            this.btn_EditarSexo.Location = new System.Drawing.Point(267, 144);
            this.btn_EditarSexo.Name = "btn_EditarSexo";
            this.btn_EditarSexo.Size = new System.Drawing.Size(97, 23);
            this.btn_EditarSexo.TabIndex = 4;
            this.btn_EditarSexo.Text = "Editar";
            this.btn_EditarSexo.UseVisualStyleBackColor = true;
            this.btn_EditarSexo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_ExcluirSexo
            // 
            this.btn_ExcluirSexo.Location = new System.Drawing.Point(510, 144);
            this.btn_ExcluirSexo.Name = "btn_ExcluirSexo";
            this.btn_ExcluirSexo.Size = new System.Drawing.Size(97, 23);
            this.btn_ExcluirSexo.TabIndex = 5;
            this.btn_ExcluirSexo.Text = "Excluir";
            this.btn_ExcluirSexo.UseVisualStyleBackColor = true;
            this.btn_ExcluirSexo.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormSexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 309);
            this.Controls.Add(this.btn_ExcluirSexo);
            this.Controls.Add(this.btn_EditarSexo);
            this.Controls.Add(this.btn_SalvarSexo);
            this.Controls.Add(this.grid_TipoSexo);
            this.Controls.Add(this.txt_TipoSexo);
            this.Controls.Add(this.lbl_descricaoSexo);
            this.Name = "FormSexo";
            this.Text = "Formulario tipo de sexo";
            this.Load += new System.EventHandler(this.FormSexo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_TipoSexo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_descricaoSexo;
        private System.Windows.Forms.TextBox txt_TipoSexo;
        private System.Windows.Forms.DataGridView grid_TipoSexo;
        private System.Windows.Forms.Button btn_SalvarSexo;
        private System.Windows.Forms.Button btn_EditarSexo;
        private System.Windows.Forms.Button btn_ExcluirSexo;
    }
}