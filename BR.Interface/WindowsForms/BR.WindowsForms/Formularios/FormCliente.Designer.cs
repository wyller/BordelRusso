namespace BR.WindowsForms.Formularios
{
    partial class FormCliente
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
            this.lbl_NomeCliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NomeCliente = new System.Windows.Forms.TextBox();
            this.txt_ApelidoCliente = new System.Windows.Forms.TextBox();
            this.cbo_TipoSexo = new System.Windows.Forms.ComboBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.grid_Cliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_NomeCliente
            // 
            this.lbl_NomeCliente.AutoSize = true;
            this.lbl_NomeCliente.Location = new System.Drawing.Point(43, 47);
            this.lbl_NomeCliente.Name = "lbl_NomeCliente";
            this.lbl_NomeCliente.Size = new System.Drawing.Size(35, 13);
            this.lbl_NomeCliente.TabIndex = 0;
            this.lbl_NomeCliente.Text = "Nome";
            this.lbl_NomeCliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apelido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexo";
            // 
            // txt_NomeCliente
            // 
            this.txt_NomeCliente.Location = new System.Drawing.Point(104, 47);
            this.txt_NomeCliente.Name = "txt_NomeCliente";
            this.txt_NomeCliente.Size = new System.Drawing.Size(198, 20);
            this.txt_NomeCliente.TabIndex = 3;
            // 
            // txt_ApelidoCliente
            // 
            this.txt_ApelidoCliente.Location = new System.Drawing.Point(104, 82);
            this.txt_ApelidoCliente.Name = "txt_ApelidoCliente";
            this.txt_ApelidoCliente.Size = new System.Drawing.Size(198, 20);
            this.txt_ApelidoCliente.TabIndex = 4;
            // 
            // cbo_TipoSexo
            // 
            this.cbo_TipoSexo.FormattingEnabled = true;
            this.cbo_TipoSexo.Location = new System.Drawing.Point(104, 117);
            this.cbo_TipoSexo.Name = "cbo_TipoSexo";
            this.cbo_TipoSexo.Size = new System.Drawing.Size(198, 21);
            this.cbo_TipoSexo.TabIndex = 5;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(26, 162);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(116, 23);
            this.btn_Salvar.TabIndex = 6;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(303, 162);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(116, 23);
            this.btn_Editar.TabIndex = 7;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(570, 162);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(116, 23);
            this.btn_Excluir.TabIndex = 8;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // grid_Cliente
            // 
            this.grid_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Cliente.Location = new System.Drawing.Point(13, 192);
            this.grid_Cliente.Name = "grid_Cliente";
            this.grid_Cliente.Size = new System.Drawing.Size(684, 130);
            this.grid_Cliente.TabIndex = 9;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 334);
            this.Controls.Add(this.grid_Cliente);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.cbo_TipoSexo);
            this.Controls.Add(this.txt_ApelidoCliente);
            this.Controls.Add(this.txt_NomeCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_NomeCliente);
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NomeCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NomeCliente;
        private System.Windows.Forms.TextBox txt_ApelidoCliente;
        private System.Windows.Forms.ComboBox cbo_TipoSexo;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.DataGridView grid_Cliente;
    }
}