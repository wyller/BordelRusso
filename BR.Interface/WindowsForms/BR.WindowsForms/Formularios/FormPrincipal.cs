using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BR.WindowsForms.Formularios
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void tipoBebidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTipoBebida formTipoBebida = new FormTipoBebida();
            formTipoBebida.MdiParent = this;
            formTipoBebida.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void tipoQuartoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tipoQuartoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormTipoQuarto formTipoQuarto = new FormTipoQuarto();
            formTipoQuarto.MdiParent = this;
            formTipoQuarto.Show();
        }

        private void quartoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuarto formQuarto = new FormQuarto();
            formQuarto.MdiParent = this;
            formQuarto.Show();
        }

        private void bebidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBebida formBebida = new FormBebida();
            formBebida.MdiParent = this;
            formBebida.Show();
        }

        private void sexoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSexo formSexo = new FormSexo();
            formSexo.MdiParent = this;
            formSexo.Show();
        }

        private void tipoEspecialidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTipoEspecialidade formTipoEspecialidade = new FormTipoEspecialidade();
            formTipoEspecialidade.MdiParent = this;
            formTipoEspecialidade.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.MdiParent = this;
            formCliente.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void prostitutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProstituta formProstituta = new FormProstituta();
            formProstituta.MdiParent = this;
            formProstituta.Show();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgenda formAgenda = new FormAgenda();
            formAgenda.MdiParent = this;
            formAgenda.Show();

        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVenda formVenda = new FormVenda();
            formVenda.MdiParent = this;
            formVenda.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
