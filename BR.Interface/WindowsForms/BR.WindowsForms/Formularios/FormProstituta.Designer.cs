namespace BR.WindowsForms.Formularios
{
    partial class FormProstituta
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ValorProstituta = new System.Windows.Forms.TextBox();
            this.cbo_EspecialidadeProstituta = new System.Windows.Forms.ComboBox();
            this.cbo_SexoProstituta = new System.Windows.Forms.ComboBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.grid_Prostituta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Prostituta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Especialidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genero";
            // 
            // txt_ValorProstituta
            // 
            this.txt_ValorProstituta.Location = new System.Drawing.Point(154, 32);
            this.txt_ValorProstituta.Name = "txt_ValorProstituta";
            this.txt_ValorProstituta.Size = new System.Drawing.Size(225, 20);
            this.txt_ValorProstituta.TabIndex = 3;
            // 
            // cbo_EspecialidadeProstituta
            // 
            this.cbo_EspecialidadeProstituta.FormattingEnabled = true;
            this.cbo_EspecialidadeProstituta.Location = new System.Drawing.Point(154, 65);
            this.cbo_EspecialidadeProstituta.Name = "cbo_EspecialidadeProstituta";
            this.cbo_EspecialidadeProstituta.Size = new System.Drawing.Size(225, 21);
            this.cbo_EspecialidadeProstituta.TabIndex = 4;
            // 
            // cbo_SexoProstituta
            // 
            this.cbo_SexoProstituta.FormattingEnabled = true;
            this.cbo_SexoProstituta.Location = new System.Drawing.Point(154, 99);
            this.cbo_SexoProstituta.Name = "cbo_SexoProstituta";
            this.cbo_SexoProstituta.Size = new System.Drawing.Size(225, 21);
            this.cbo_SexoProstituta.TabIndex = 5;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(23, 159);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(113, 23);
            this.btn_Salvar.TabIndex = 6;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(266, 159);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(113, 23);
            this.btn_Editar.TabIndex = 7;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(506, 159);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(113, 23);
            this.btn_Excluir.TabIndex = 8;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // grid_Prostituta
            // 
            this.grid_Prostituta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Prostituta.Location = new System.Drawing.Point(13, 189);
            this.grid_Prostituta.Name = "grid_Prostituta";
            this.grid_Prostituta.Size = new System.Drawing.Size(617, 139);
            this.grid_Prostituta.TabIndex = 9;
            this.grid_Prostituta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormProstituta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 340);
            this.Controls.Add(this.grid_Prostituta);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.cbo_SexoProstituta);
            this.Controls.Add(this.cbo_EspecialidadeProstituta);
            this.Controls.Add(this.txt_ValorProstituta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormProstituta";
            this.Text = "FormProstituta";
            this.Load += new System.EventHandler(this.FormProstituta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Prostituta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ValorProstituta;
        private System.Windows.Forms.ComboBox cbo_EspecialidadeProstituta;
        private System.Windows.Forms.ComboBox cbo_SexoProstituta;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.DataGridView grid_Prostituta;
    }
}