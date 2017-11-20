namespace BR.WindowsForms.Formularios
{
    partial class FormQuarto
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
            this.Lbl_Numero = new System.Windows.Forms.Label();
            this.lbl_TipoQuarto = new System.Windows.Forms.Label();
            this.cbo_TipoQuarto = new System.Windows.Forms.ComboBox();
            this.txt_numeroQuarto = new System.Windows.Forms.TextBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.grid_tipoQuarto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tipoQuarto)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Numero
            // 
            this.Lbl_Numero.AutoSize = true;
            this.Lbl_Numero.Location = new System.Drawing.Point(49, 67);
            this.Lbl_Numero.Name = "Lbl_Numero";
            this.Lbl_Numero.Size = new System.Drawing.Size(44, 13);
            this.Lbl_Numero.TabIndex = 0;
            this.Lbl_Numero.Text = "Numero";
            this.Lbl_Numero.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_TipoQuarto
            // 
            this.lbl_TipoQuarto.AutoSize = true;
            this.lbl_TipoQuarto.Location = new System.Drawing.Point(49, 27);
            this.lbl_TipoQuarto.Name = "lbl_TipoQuarto";
            this.lbl_TipoQuarto.Size = new System.Drawing.Size(76, 13);
            this.lbl_TipoQuarto.TabIndex = 1;
            this.lbl_TipoQuarto.Text = "Tipo do quarto";
            this.lbl_TipoQuarto.Click += new System.EventHandler(this.Lbl_TipoQuarto_Click);
            // 
            // cbo_TipoQuarto
            // 
            this.cbo_TipoQuarto.FormattingEnabled = true;
            this.cbo_TipoQuarto.Location = new System.Drawing.Point(142, 24);
            this.cbo_TipoQuarto.Name = "cbo_TipoQuarto";
            this.cbo_TipoQuarto.Size = new System.Drawing.Size(196, 21);
            this.cbo_TipoQuarto.TabIndex = 2;
            // 
            // txt_numeroQuarto
            // 
            this.txt_numeroQuarto.Location = new System.Drawing.Point(142, 64);
            this.txt_numeroQuarto.Name = "txt_numeroQuarto";
            this.txt_numeroQuarto.Size = new System.Drawing.Size(196, 20);
            this.txt_numeroQuarto.TabIndex = 3;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(34, 133);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(100, 23);
            this.btn_Salvar.TabIndex = 4;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(288, 133);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(100, 23);
            this.btn_Editar.TabIndex = 5;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(542, 133);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(100, 23);
            this.btn_Excluir.TabIndex = 6;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // grid_tipoQuarto
            // 
            this.grid_tipoQuarto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_tipoQuarto.Location = new System.Drawing.Point(12, 181);
            this.grid_tipoQuarto.Name = "grid_tipoQuarto";
            this.grid_tipoQuarto.Size = new System.Drawing.Size(652, 129);
            this.grid_tipoQuarto.TabIndex = 7;
            // 
            // FormQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 322);
            this.Controls.Add(this.grid_tipoQuarto);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.txt_numeroQuarto);
            this.Controls.Add(this.cbo_TipoQuarto);
            this.Controls.Add(this.lbl_TipoQuarto);
            this.Controls.Add(this.Lbl_Numero);
            this.Name = "FormQuarto";
            this.Text = "FormQuarto";
            this.Load += new System.EventHandler(this.FormQuarto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_tipoQuarto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Numero;
        private System.Windows.Forms.Label lbl_TipoQuarto;
        private System.Windows.Forms.ComboBox cbo_TipoQuarto;
        private System.Windows.Forms.TextBox txt_numeroQuarto;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.DataGridView grid_tipoQuarto;
    }
}