using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BR.Modelo;

namespace BR.WindowsForms.Formularios
{
    public partial class FormSexo : Form
    {

        BordelRussoEntities db = new BordelRussoEntities();
        private sexo tipoSexo;

        public FormSexo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (grid_TipoSexo.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir esse sexo?", "confirma Excluir sexo",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    DataGridViewRow linha = grid_TipoSexo.SelectedRows[0];
                    int idTipoSexo = (int)linha.Cells["idSexo"].Value;

                    tipoSexo = db.sexo.Where(x => x.idSexo == idTipoSexo).FirstOrDefault();

                    db.sexo.Remove(tipoSexo);
                    db.SaveChanges();

                    MessageBox.Show("Sexo excluido com sucesso");
                    CarregarGrid();
                    LimparCampos();


                }
            }
            else
            {
                MessageBox.Show("Selecione antes qual sera excluido.");
            }
        }

        private void FormSexo_Load(object sender, EventArgs e)
        {
            grid_TipoSexo.ColumnCount = 2;
            grid_TipoSexo.EditMode = DataGridViewEditMode.EditProgrammatically;
            grid_TipoSexo.MultiSelect = false;
            grid_TipoSexo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grid_TipoSexo.Columns[0].HeaderText = "Codigo";
            grid_TipoSexo.Columns[0].DataPropertyName = "idSexo";
            grid_TipoSexo.Columns[0].Width = 150;
            grid_TipoSexo.Columns[0].Name = "idSexo";

            grid_TipoSexo.Columns[1].HeaderText = "Descrição";
            grid_TipoSexo.Columns[1].DataPropertyName = "Descrição";
            grid_TipoSexo.Columns[1].Width = 500;
            grid_TipoSexo.Columns[1].Name = "Descrição";

            CarregarGrid();
        }

        public void CarregarGrid()
        {
            var tipoSexo = from sexo in db.sexo select (new { sexo.idSexo, sexo.descrição });
            grid_TipoSexo.DataSource = tipoSexo.ToList();
        }

        public void LimparCampos()
        {
            txt_TipoSexo.Clear();
            tipoSexo = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (grid_TipoSexo.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = grid_TipoSexo.SelectedRows[0];
                int idTipoSexo = (int)linha.Cells["idSexo"].Value;

                tipoSexo = db.sexo.Where(x => x.idSexo == idTipoSexo).FirstOrDefault();
                txt_TipoSexo.Text = tipoSexo.descrição;
            }
            else
            {
                MessageBox.Show("Selecione um sexo para alterar! ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tipoSexo == null)
            {
                tipoSexo = new sexo();
            }

            int idTípoBebida = tipoSexo.idSexo > 0 ? tipoSexo.idSexo : 0;

            tipoSexo.idSexo = idTípoBebida;
            tipoSexo.descrição = txt_TipoSexo.Text;

            string mensagem = "";

            if (tipoSexo.idSexo == 0)
            {
                db.sexo.Add(tipoSexo);
                mensagem = "Tipo sexo registrado com sucesso";
            }
            else
            {
                var obj = db.Entry(tipoSexo);
                obj.Property(x => x.descrição).IsModified = true;

                mensagem = "Tipo sexo alterado com sucesso";

            }

            db.SaveChanges();

            MessageBox.Show(mensagem);
            CarregarGrid();
            LimparCampos();
        }
    }
}
