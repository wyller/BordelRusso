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
    public partial class FormTipoEspecialidade : Form
    {
        BordelRussoEntities db = new BordelRussoEntities();
        private tipoEspecialiade tipoEspecialidade;

        public FormTipoEspecialidade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tipoEspecialidade == null)
            {
                tipoEspecialidade = new tipoEspecialiade();
            }

            int idTípoBebida = tipoEspecialidade.idTipoEspecialidade > 0 ? tipoEspecialidade.idTipoEspecialidade : 0;

            tipoEspecialidade.idTipoEspecialidade = idTípoBebida;
            tipoEspecialidade.descricao = txt_DescricaoEspecialidade.Text;

            string mensagem = "";

            if (tipoEspecialidade.idTipoEspecialidade == 0)
            {
                db.tipoEspecialiade.Add(tipoEspecialidade);
                mensagem = "Tipo da especialidade registrado com sucesso";
            }
            else
            {
                var obj = db.Entry(tipoEspecialidade);
                obj.Property(x => x.descricao).IsModified = true;

                mensagem = "Tipo da especialidade alterado com sucesso";

            }

            db.SaveChanges();

            MessageBox.Show(mensagem);
            CarregarGrid();
            LimparCampos();
        }

        public void LimparCampos()
        {
            txt_DescricaoEspecialidade.Clear();
            tipoEspecialidade = null;
        }

        private void FormTipoEspecialidade_Load(object sender, EventArgs e)
        {
            grid_TipoEspecialidade.ColumnCount = 2;
            grid_TipoEspecialidade.EditMode = DataGridViewEditMode.EditProgrammatically;
            grid_TipoEspecialidade.MultiSelect = false;
            grid_TipoEspecialidade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grid_TipoEspecialidade.Columns[0].HeaderText = "Codigo";
            grid_TipoEspecialidade.Columns[0].DataPropertyName = "idTipoEspecialidade";
            grid_TipoEspecialidade.Columns[0].Width = 150;
            grid_TipoEspecialidade.Columns[0].Name = "idTipoEspecialidade";

            grid_TipoEspecialidade.Columns[1].HeaderText = "Descrição";
            grid_TipoEspecialidade.Columns[1].DataPropertyName = "descricao";
            grid_TipoEspecialidade.Columns[1].Width = 309;
            grid_TipoEspecialidade.Columns[1].Name = "descricao";

            CarregarGrid();

        }
        public void CarregarGrid()
        {
            var tipoEspecialidade = from tipoEspecialiade in db.tipoEspecialiade select (new { tipoEspecialiade.idTipoEspecialidade, tipoEspecialiade.descricao });
            grid_TipoEspecialidade.DataSource = tipoEspecialidade.ToList();
        }

        private void grid_TipoEspecialidade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (grid_TipoEspecialidade.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = grid_TipoEspecialidade.SelectedRows[0];
                int idTipoEspecialidade = (int)linha.Cells["idTipoEspecialidade"].Value;

                tipoEspecialidade = db.tipoEspecialiade.Where(x => x.idTipoEspecialidade == idTipoEspecialidade).FirstOrDefault();
                txt_DescricaoEspecialidade.Text = tipoEspecialidade.descricao;
            }
            else
            {
                MessageBox.Show("Selecione a especialidade para alterar! ");
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (grid_TipoEspecialidade.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir essa especialidade?", "Confirma Excluir Especialidade",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int idTipoEspecialidade = (int)grid_TipoEspecialidade.CurrentRow.Cells[0].Value;

                    tipoEspecialidade = db.tipoEspecialiade.Where(x => x.idTipoEspecialidade == idTipoEspecialidade).FirstOrDefault();

                    db.tipoEspecialiade.Remove(tipoEspecialidade);
                    db.SaveChanges();

                    MessageBox.Show("Especialidade excluido com sucesso");
                    CarregarGrid();
                    LimparCampos();


                }
            }
            else
            {
                MessageBox.Show("Selecione antes qual sera excluido.");
            }
        }
    }
}
