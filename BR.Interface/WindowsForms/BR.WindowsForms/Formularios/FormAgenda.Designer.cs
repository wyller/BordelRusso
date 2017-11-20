namespace BR.WindowsForms.Formularios
{
    partial class FormAgenda
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
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_Quarto = new System.Windows.Forms.ComboBox();
            this.cbo_Prostituta = new System.Windows.Forms.ComboBox();
            this.txt_horaInicio = new System.Windows.Forms.TextBox();
            this.txt_horaFim = new System.Windows.Forms.TextBox();
            this.grid_Agenda = new System.Windows.Forms.DataGridView();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Agenda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quarto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dançarina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ate";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbo_Quarto
            // 
            this.cbo_Quarto.FormattingEnabled = true;
            this.cbo_Quarto.Location = new System.Drawing.Point(82, 9);
            this.cbo_Quarto.Name = "cbo_Quarto";
            this.cbo_Quarto.Size = new System.Drawing.Size(182, 21);
            this.cbo_Quarto.TabIndex = 4;
            // 
            // cbo_Prostituta
            // 
            this.cbo_Prostituta.FormattingEnabled = true;
            this.cbo_Prostituta.Location = new System.Drawing.Point(82, 36);
            this.cbo_Prostituta.Name = "cbo_Prostituta";
            this.cbo_Prostituta.Size = new System.Drawing.Size(182, 21);
            this.cbo_Prostituta.TabIndex = 5;
            // 
            // txt_horaInicio
            // 
            this.txt_horaInicio.Location = new System.Drawing.Point(82, 63);
            this.txt_horaInicio.Name = "txt_horaInicio";
            this.txt_horaInicio.Size = new System.Drawing.Size(182, 20);
            this.txt_horaInicio.TabIndex = 6;
            // 
            // txt_horaFim
            // 
            this.txt_horaFim.Location = new System.Drawing.Point(311, 63);
            this.txt_horaFim.Name = "txt_horaFim";
            this.txt_horaFim.Size = new System.Drawing.Size(182, 20);
            this.txt_horaFim.TabIndex = 7;
            // 
            // grid_Agenda
            // 
            this.grid_Agenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Agenda.Location = new System.Drawing.Point(12, 159);
            this.grid_Agenda.Name = "grid_Agenda";
            this.grid_Agenda.Size = new System.Drawing.Size(692, 122);
            this.grid_Agenda.TabIndex = 8;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(153, 130);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(111, 23);
            this.btn_salvar.TabIndex = 9;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(496, 130);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(111, 23);
            this.btn_Excluir.TabIndex = 11;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 293);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.grid_Agenda);
            this.Controls.Add(this.txt_horaFim);
            this.Controls.Add(this.txt_horaInicio);
            this.Controls.Add(this.cbo_Prostituta);
            this.Controls.Add(this.cbo_Quarto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAgenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.FormAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Agenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_Quarto;
        private System.Windows.Forms.ComboBox cbo_Prostituta;
        private System.Windows.Forms.TextBox txt_horaInicio;
        private System.Windows.Forms.TextBox txt_horaFim;
        private System.Windows.Forms.DataGridView grid_Agenda;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_Excluir;
    }
}