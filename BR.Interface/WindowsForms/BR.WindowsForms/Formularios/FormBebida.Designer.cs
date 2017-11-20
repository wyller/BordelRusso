namespace BR.WindowsForms.Formularios
{
    partial class FormBebida
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
            this.lbl_tipoBebida = new System.Windows.Forms.Label();
            this.lbl_marcaBebida = new System.Windows.Forms.Label();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.cbo_TipoBebida = new System.Windows.Forms.ComboBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.grid_bebida = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_bebida)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tipoBebida
            // 
            this.lbl_tipoBebida.AutoSize = true;
            this.lbl_tipoBebida.Location = new System.Drawing.Point(27, 28);
            this.lbl_tipoBebida.Name = "lbl_tipoBebida";
            this.lbl_tipoBebida.Size = new System.Drawing.Size(64, 13);
            this.lbl_tipoBebida.TabIndex = 0;
            this.lbl_tipoBebida.Text = "Tipo Bebida";
            // 
            // lbl_marcaBebida
            // 
            this.lbl_marcaBebida.AutoSize = true;
            this.lbl_marcaBebida.Location = new System.Drawing.Point(27, 58);
            this.lbl_marcaBebida.Name = "lbl_marcaBebida";
            this.lbl_marcaBebida.Size = new System.Drawing.Size(37, 13);
            this.lbl_marcaBebida.TabIndex = 1;
            this.lbl_marcaBebida.Text = "Marca";
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(109, 58);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(225, 20);
            this.txt_Marca.TabIndex = 2;
            // 
            // cbo_TipoBebida
            // 
            this.cbo_TipoBebida.FormattingEnabled = true;
            this.cbo_TipoBebida.Location = new System.Drawing.Point(109, 20);
            this.cbo_TipoBebida.Name = "cbo_TipoBebida";
            this.cbo_TipoBebida.Size = new System.Drawing.Size(225, 21);
            this.cbo_TipoBebida.TabIndex = 3;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(36, 132);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(95, 23);
            this.btn_salvar.TabIndex = 4;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(265, 132);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(95, 23);
            this.btn_Editar.TabIndex = 5;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(475, 132);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(95, 23);
            this.btn_Excluir.TabIndex = 6;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.button3_Click);
            // 
            // grid_bebida
            // 
            this.grid_bebida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_bebida.Location = new System.Drawing.Point(12, 172);
            this.grid_bebida.Name = "grid_bebida";
            this.grid_bebida.Size = new System.Drawing.Size(577, 127);
            this.grid_bebida.TabIndex = 7;
            // 
            // FormBebida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 311);
            this.Controls.Add(this.grid_bebida);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.cbo_TipoBebida);
            this.Controls.Add(this.txt_Marca);
            this.Controls.Add(this.lbl_marcaBebida);
            this.Controls.Add(this.lbl_tipoBebida);
            this.Name = "FormBebida";
            this.Text = "FormBebida";
            this.Load += new System.EventHandler(this.FormBebida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_bebida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tipoBebida;
        private System.Windows.Forms.Label lbl_marcaBebida;
        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.ComboBox cbo_TipoBebida;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.DataGridView grid_bebida;
    }
}