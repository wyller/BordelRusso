namespace BR.WindowsForms.Formularios
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tipoBebidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bebidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoQuartoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quartoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sexoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoEspecialidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prostitutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoBebidaToolStripMenuItem,
            this.bebidaToolStripMenuItem,
            this.tipoQuartoToolStripMenuItem,
            this.quartoToolStripMenuItem,
            this.sexoToolStripMenuItem,
            this.tipoEspecialidadeToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.prostitutaToolStripMenuItem,
            this.agendaToolStripMenuItem,
            this.vendasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(750, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tipoBebidaToolStripMenuItem
            // 
            this.tipoBebidaToolStripMenuItem.Name = "tipoBebidaToolStripMenuItem";
            this.tipoBebidaToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.tipoBebidaToolStripMenuItem.Text = "Tipo Bebida";
            this.tipoBebidaToolStripMenuItem.Click += new System.EventHandler(this.tipoBebidaToolStripMenuItem_Click);
            // 
            // bebidaToolStripMenuItem
            // 
            this.bebidaToolStripMenuItem.Name = "bebidaToolStripMenuItem";
            this.bebidaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.bebidaToolStripMenuItem.Text = "Bebida";
            this.bebidaToolStripMenuItem.Click += new System.EventHandler(this.bebidaToolStripMenuItem_Click);
            // 
            // tipoQuartoToolStripMenuItem
            // 
            this.tipoQuartoToolStripMenuItem.Name = "tipoQuartoToolStripMenuItem";
            this.tipoQuartoToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.tipoQuartoToolStripMenuItem.Text = "Tipo Quarto";
            this.tipoQuartoToolStripMenuItem.Click += new System.EventHandler(this.tipoQuartoToolStripMenuItem_Click_1);
            // 
            // quartoToolStripMenuItem
            // 
            this.quartoToolStripMenuItem.Name = "quartoToolStripMenuItem";
            this.quartoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quartoToolStripMenuItem.Text = "Quarto";
            this.quartoToolStripMenuItem.Click += new System.EventHandler(this.quartoToolStripMenuItem_Click);
            // 
            // sexoToolStripMenuItem
            // 
            this.sexoToolStripMenuItem.Name = "sexoToolStripMenuItem";
            this.sexoToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.sexoToolStripMenuItem.Text = "Sexo";
            this.sexoToolStripMenuItem.Click += new System.EventHandler(this.sexoToolStripMenuItem_Click);
            // 
            // tipoEspecialidadeToolStripMenuItem
            // 
            this.tipoEspecialidadeToolStripMenuItem.Name = "tipoEspecialidadeToolStripMenuItem";
            this.tipoEspecialidadeToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.tipoEspecialidadeToolStripMenuItem.Text = "Tipo Especialidade";
            this.tipoEspecialidadeToolStripMenuItem.Click += new System.EventHandler(this.tipoEspecialidadeToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // prostitutaToolStripMenuItem
            // 
            this.prostitutaToolStripMenuItem.Name = "prostitutaToolStripMenuItem";
            this.prostitutaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.prostitutaToolStripMenuItem.Text = "Prostituta";
            this.prostitutaToolStripMenuItem.Click += new System.EventHandler(this.prostitutaToolStripMenuItem_Click);
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.agendaToolStripMenuItem.Text = "Agenda";
            this.agendaToolStripMenuItem.Click += new System.EventHandler(this.agendaToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(750, 337);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tipoBebidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoQuartoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quartoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bebidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sexoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoEspecialidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prostitutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
    }
}