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
using System.Data.Entity;


namespace BR.WindowsForms.Formularios
{
    public partial class FormTipoQuarto : Form
    {
        BordelRussoEntities db = new BordelRussoEntities();
        private tipoQuarto tipoQuarto;

        public FormTipoQuarto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tipoQuarto == null)
            {
                tipoQuarto = new tipoQuarto();
            }

            int idTipoQuarto = tipoQuarto.idTipoQuarto > 0 ? tipoQuarto.idTipoQuarto : 0;

            tipoQuarto.idTipoQuarto = idTipoQuarto;
            tipoQuarto.descricao = txt_DescricaoTipoQuarto.Text;

            string mensagem = "";

            if (tipoQuarto.idTipoQuarto == 0)
            {
                db.tipoQuarto.Add(tipoQuarto);
                mensagem = "Tipo quarto registrado com sucesso";
            }
            else
            {
                var obj = db.Entry(tipoQuarto);
                obj.Property(x => x.descricao).IsModified = true;

                mensagem = "Tipo quarto alterado com sucesso";

            }

            db.SaveChanges();

            MessageBox.Show(mensagem);
            CarregarGrid();
            LimparCampos();
        }

        public void LimparCampos()
        {
            txt_DescricaoTipoQuarto.Clear();
            tipoQuarto = null;
        }

        private void FormTipoQuarto_Load(object sender, EventArgs e)
        {
            grid_TipoQuarto.ColumnCount = 2;
            grid_TipoQuarto.EditMode = DataGridViewEditMode.EditProgrammatically;
            grid_TipoQuarto.MultiSelect = false;
            grid_TipoQuarto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grid_TipoQuarto.Columns[0].HeaderText = "Codigo tipo quarto";
            grid_TipoQuarto.Columns[0].DataPropertyName = "idTipoQuarto";
            grid_TipoQuarto.Columns[0].Width = 150;
            grid_TipoQuarto.Columns[0].Name = "idTipoQuarto";

            grid_TipoQuarto.Columns[1].HeaderText = "Descrição tipo quarto";
            grid_TipoQuarto.Columns[1].DataPropertyName = "descricao";
            grid_TipoQuarto.Columns[1].Width = 309;
            grid_TipoQuarto.Columns[1].Name = "descricao";

            CarregarGrid();
        }

        public void CarregarGrid()
        {
            var tipoQuartos = from tipoQuarto in db.tipoQuarto select (new { tipoQuarto.idTipoQuarto, tipoQuarto.descricao });
            grid_TipoQuarto.DataSource = tipoQuartos.ToList();
        }

        private void btn_tipoQuartoEditar_Click(object sender, EventArgs e)
        {
            if (grid_TipoQuarto.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = grid_TipoQuarto.SelectedRows[0];
                int idTipoQuarto = (int)linha.Cells["idTipoQuarto"].Value;

                tipoQuarto = db.tipoQuarto.Where(x => x.idTipoQuarto == idTipoQuarto).FirstOrDefault();
                txt_DescricaoTipoQuarto.Text = tipoQuarto.descricao;
            }
            else
            {
                MessageBox.Show("Selecione um tipo de quarto para alterar! ");
            }
        }

        private void btn_TipoQuartoExcluir_Click(object sender, EventArgs e)
        {
            if (grid_TipoQuarto.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = grid_TipoQuarto.SelectedRows[0];
                int idtipoQuarto = (int)linha.Cells["idtipoQuarto"].Value;

                tipoQuarto = db.tipoQuarto.Where(x => x.idTipoQuarto == idtipoQuarto).FirstOrDefault();

                db.tipoQuarto.Remove(tipoQuarto);
                db.SaveChanges();

                MessageBox.Show("Tipo quarto excluido com sucesso");
                CarregarGrid();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Selecione um tipo de quarto para excluir! ");
            }
        }
    }
}
