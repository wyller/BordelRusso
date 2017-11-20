namespace BR.WindowsForms.Formularios
{
    partial class FormTipoBebida
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
            this.lbl_TipoBebida = new System.Windows.Forms.Label();
            this.txt_DescricaoTipoBebida = new System.Windows.Forms.TextBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.grid_TipoBebida = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_TipoBebida)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TipoBebida
            // 
            this.lbl_TipoBebida.AutoSize = true;
            this.lbl_TipoBebida.Location = new System.Drawing.Point(28, 60);
            this.lbl_TipoBebida.Name = "lbl_TipoBebida";
            this.lbl_TipoBebida.Size = new System.Drawing.Size(61, 13);
            this.lbl_TipoBebida.TabIndex = 0;
            this.lbl_TipoBebida.Text = "TipoBebida";
            this.lbl_TipoBebida.Click += new System.EventHandler(this.lbl_TipoBebida_Click);
            // 
            // txt_DescricaoTipoBebida
            // 
            this.txt_DescricaoTipoBebida.Location = new System.Drawing.Point(95, 56);
            this.txt_DescricaoTipoBebida.Name = "txt_DescricaoTipoBebida";
            this.txt_DescricaoTipoBebida.Size = new System.Drawing.Size(399, 20);
            this.txt_DescricaoTipoBebida.TabIndex = 1;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(31, 119);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(114, 23);
            this.btn_Salvar.TabIndex = 2;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(220, 119);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(114, 23);
            this.btn_Editar.TabIndex = 3;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(406, 119);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(114, 23);
            this.btn_Excluir.TabIndex = 4;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // grid_TipoBebida
            // 
            this.grid_TipoBebida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_TipoBebida.Location = new System.Drawing.Point(12, 148);
            this.grid_TipoBebida.Name = "grid_TipoBebida";
            this.grid_TipoBebida.Size = new System.Drawing.Size(525, 150);
            this.grid_TipoBebida.TabIndex = 5;
            this.grid_TipoBebida.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_TipoBebida_CellContentClick);
            // 
            // FormTipoBebida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(551, 310);
            this.Controls.Add(this.grid_TipoBebida);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.txt_DescricaoTipoBebida);
            this.Controls.Add(this.lbl_TipoBebida);
            this.Name = "FormTipoBebida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formulario Tipo Bebida";
            this.Load += new System.EventHandler(this.FormTipoBebida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_TipoBebida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TipoBebida;
        private System.Windows.Forms.TextBox txt_DescricaoTipoBebida;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.DataGridView grid_TipoBebida;
    }
}