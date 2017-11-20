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
    public partial class FormQuarto : Form
    {
        BordelRussoEntities db = new BordelRussoEntities();
        private quarto quarto;

        public FormQuarto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_TipoQuarto_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(grid_tipoQuarto.SelectedRows.Count > 0)
            {
                int idQuarto = (int)grid_tipoQuarto.CurrentRow.Cells[0].Value;

                quarto = db.quarto.Where(x => x.idQuarto == idQuarto).FirstOrDefault();

                cbo_TipoQuarto.SelectedValue = quarto.idTipoQuarto;
                txt_numeroQuarto.Text = Convert.ToString(quarto.numero);

            }
            else
            {
                MessageBox.Show("Selecione antes qual sera editado.");
            }
        }

        private void FormQuarto_Load(object sender, EventArgs e)
        {
            cbo_TipoQuarto.DataSource = db.tipoQuarto.ToList();
            cbo_TipoQuarto.DisplayMember = "descricao";
            cbo_TipoQuarto.ValueMember = "idTipoQuarto";

            grid_tipoQuarto.ColumnCount = 3;
            grid_tipoQuarto.EditMode = DataGridViewEditMode.EditProgrammatically;
            grid_tipoQuarto.MultiSelect = false;
            grid_tipoQuarto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grid_tipoQuarto.Columns[0].HeaderText = "Codigo";
            grid_tipoQuarto.Columns[0].DataPropertyName = "idQuarto";
            grid_tipoQuarto.Columns[0].Name = "idQuarto";
            grid_tipoQuarto.Columns[0].Width = 50;

            grid_tipoQuarto.Columns[1].HeaderText = "Tipo";
            grid_tipoQuarto.Columns[1].DataPropertyName = "descricao";
            grid_tipoQuarto.Columns[1].Name = "descricao";
            grid_tipoQuarto.Columns[1].Width = 282;

            grid_tipoQuarto.Columns[2].HeaderText = "Numero";
            grid_tipoQuarto.Columns[2].DataPropertyName = "numero";
            grid_tipoQuarto.Columns[2].Name = "numero";
            grid_tipoQuarto.Columns[2].Width = 280;

            CarregarGrid();

        }

        public void CarregarGrid()
        {
            var quartos = from quarto in db.quarto
                          join tipoQuarto in db.tipoQuarto
                          on quarto.idTipoQuarto equals tipoQuarto.idTipoQuarto
                          select (new { quarto.idQuarto, tipoQuarto.descricao, quarto.numero });

            grid_tipoQuarto.DataSource = quartos.ToList();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if(quarto == null)
            {
                quarto = new quarto();
            }

            int idQuarto = quarto.idQuarto > 0 ? quarto.idQuarto : 0;

            quarto.idQuarto = idQuarto;
            quarto.numero = Convert.ToInt32(txt_numeroQuarto.Text);
            quarto.idTipoQuarto = (int)cbo_TipoQuarto.SelectedValue;

            string mensagem = "";

            if (verificaQuartoExistente(quarto.numero))
            {
                MessageBox.Show("Quarto ja existente");
            }
            else
            {
                if(quarto.idQuarto == 0)
                {
                    db.quarto.Add(quarto);
                    mensagem = "Quarto salvo com sucesso!";
                }
                else
                {
                    var obj = db.Entry(quarto);
                    obj.Property(x => x.numero);
                    mensagem = "Quarto Editado com sucesso!";
                }

                db.SaveChanges();

                MessageBox.Show(mensagem);
                CarregarGrid();
                LimparCampos();


            }
        }

        private bool verificaQuartoExistente(int numero)
        {
            return db.quarto.Where(x => x.numero == numero).Count() > 0 ? true : false;
        }

        private void LimparCampos()
        {
            txt_numeroQuarto.Clear();
            cbo_TipoQuarto.SelectedIndex = 0;
            quarto = null;
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (grid_tipoQuarto.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir esse quarto?", "confirma Excluir quarto",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int idQuarto = (int)grid_tipoQuarto.CurrentRow.Cells[0].Value;

                    quarto = db.quarto.Where(x => x.idQuarto == idQuarto).FirstOrDefault();

                    db.quarto.Remove(quarto);
                    db.SaveChanges();

                    MessageBox.Show("Quarto excluido com sucesso");
                    CarregarGrid();
                    LimparCampos();


                }
            }
            else
            {
                MessageBox.Show("Selecione antes qual sera editado.");
            }
        }
    }
}
