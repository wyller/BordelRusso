namespace BR.WindowsForms.Formularios
{
    partial class FormTipoQuarto
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
            this.grid_TipoQuarto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_DescricaoTipoQuarto = new System.Windows.Forms.TextBox();
            this.btn_tipoQuartoEditar = new System.Windows.Forms.Button();
            this.btn_TipoQuartoSalvar = new System.Windows.Forms.Button();
            this.btn_TipoQuartoExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_TipoQuarto)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_TipoQuarto
            // 
            this.grid_TipoQuarto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_TipoQuarto.Location = new System.Drawing.Point(12, 148);
            this.grid_TipoQuarto.Name = "grid_TipoQuarto";
            this.grid_TipoQuarto.Size = new System.Drawing.Size(503, 150);
            this.grid_TipoQuarto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TipoQuarto";
            // 
            // txt_DescricaoTipoQuarto
            // 
            this.txt_DescricaoTipoQuarto.Location = new System.Drawing.Point(95, 56);
            this.txt_DescricaoTipoQuarto.Name = "txt_DescricaoTipoQuarto";
            this.txt_DescricaoTipoQuarto.Size = new System.Drawing.Size(399, 20);
            this.txt_DescricaoTipoQuarto.TabIndex = 2;
            // 
            // btn_tipoQuartoEditar
            // 
            this.btn_tipoQuartoEditar.Location = new System.Drawing.Point(205, 119);
            this.btn_tipoQuartoEditar.Name = "btn_tipoQuartoEditar";
            this.btn_tipoQuartoEditar.Size = new System.Drawing.Size(114, 23);
            this.btn_tipoQuartoEditar.TabIndex = 3;
            this.btn_tipoQuartoEditar.Text = "Editar";
            this.btn_tipoQuartoEditar.UseVisualStyleBackColor = true;
            this.btn_tipoQuartoEditar.Click += new System.EventHandler(this.btn_tipoQuartoEditar_Click);
            // 
            // btn_TipoQuartoSalvar
            // 
            this.btn_TipoQuartoSalvar.Location = new System.Drawing.Point(31, 119);
            this.btn_TipoQuartoSalvar.Name = "btn_TipoQuartoSalvar";
            this.btn_TipoQuartoSalvar.Size = new System.Drawing.Size(114, 23);
            this.btn_TipoQuartoSalvar.TabIndex = 4;
            this.btn_TipoQuartoSalvar.Text = "Salvar";
            this.btn_TipoQuartoSalvar.UseVisualStyleBackColor = true;
            this.btn_TipoQuartoSalvar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_TipoQuartoExcluir
            // 
            this.btn_TipoQuartoExcluir.Location = new System.Drawing.Point(379, 119);
            this.btn_TipoQuartoExcluir.Name = "btn_TipoQuartoExcluir";
            this.btn_TipoQuartoExcluir.Size = new System.Drawing.Size(114, 23);
            this.btn_TipoQuartoExcluir.TabIndex = 5;
            this.btn_TipoQuartoExcluir.Text = "Excluir";
            this.btn_TipoQuartoExcluir.UseVisualStyleBackColor = true;
            this.btn_TipoQuartoExcluir.Click += new System.EventHandler(this.btn_TipoQuartoExcluir_Click);
            // 
            // FormTipoQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 310);
            this.Controls.Add(this.btn_TipoQuartoExcluir);
            this.Controls.Add(this.btn_TipoQuartoSalvar);
            this.Controls.Add(this.btn_tipoQuartoEditar);
            this.Controls.Add(this.txt_DescricaoTipoQuarto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_TipoQuarto);
            this.Name = "FormTipoQuarto";
            this.Text = "FormTipoQuarto";
            this.Load += new System.EventHandler(this.FormTipoQuarto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_TipoQuarto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_TipoQuarto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_DescricaoTipoQuarto;
        private System.Windows.Forms.Button btn_tipoQuartoEditar;
        private System.Windows.Forms.Button btn_TipoQuartoSalvar;
        private System.Windows.Forms.Button btn_TipoQuartoExcluir;
    }
}