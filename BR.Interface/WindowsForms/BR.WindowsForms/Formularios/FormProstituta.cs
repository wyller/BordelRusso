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
    public partial class FormProstituta : Form
    {

        BordelRussoEntities db = new BordelRussoEntities();
        private prostituta prostituta;

        public FormProstituta()
        {
            InitializeComponent();
        }

        private void FormProstituta_Load(object sender, EventArgs e)
        {
            cbo_EspecialidadeProstituta.DataSource = db.tipoEspecialiade.ToList();
            cbo_EspecialidadeProstituta.DisplayMember = "descricao";
            cbo_EspecialidadeProstituta.ValueMember = "idTipoEspecialidade";

            cbo_SexoProstituta.DataSource = db.sexo.ToList();
            cbo_SexoProstituta.DisplayMember = "descrição";
            cbo_SexoProstituta.ValueMember = "idSexo";

            grid_Prostituta.ColumnCount = 4;
            grid_Prostituta.EditMode = DataGridViewEditMode.EditProgrammatically;
            grid_Prostituta.MultiSelect = false;
            grid_Prostituta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grid_Prostituta.Columns[0].HeaderText = "Codigo";
            grid_Prostituta.Columns[0].DataPropertyName = "idProstituta";
            grid_Prostituta.Columns[0].Name = "idProstituta";
            grid_Prostituta.Columns[0].Width = 50;

            grid_Prostituta.Columns[1].HeaderText = "Valor";
            grid_Prostituta.Columns[1].DataPropertyName = "valor";
            grid_Prostituta.Columns[1].Name = "valor";
            grid_Prostituta.Columns[1].Width = 126;

            grid_Prostituta.Columns[2].HeaderText = "Especialidade";
            grid_Prostituta.Columns[2].DataPropertyName = "descricao";
            grid_Prostituta.Columns[2].Name = "descricao";
            grid_Prostituta.Columns[2].Width = 200;

            grid_Prostituta.Columns[3].HeaderText = "Genero";
            grid_Prostituta.Columns[3].DataPropertyName = "descrição";
            grid_Prostituta.Columns[3].Name = "descrição";
            grid_Prostituta.Columns[3].Width = 100;

            CarregarGrid();
        }

        public void CarregarGrid()
        {
            var prostitutas = from prostituta in db.prostituta
                              join tipoEspecialiade in db.tipoEspecialiade
                              on prostituta.idTipoEspecialidade equals tipoEspecialiade.idTipoEspecialidade
                              join sexo in db.sexo
                              on prostituta.idSexo equals sexo.idSexo
                              select (new { prostituta.idProstituta, prostituta.valor, tipoEspecialiade.descricao, sexo.descrição});

            grid_Prostituta.DataSource = prostitutas.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (prostituta == null)
            {
                prostituta = new prostituta();
            }

            int idProstituta = prostituta.idProstituta > 0 ? prostituta.idProstituta : 0;

            prostituta.idProstituta = idProstituta;
            prostituta.valor = Convert.ToDouble(txt_ValorProstituta.Text);
            prostituta.idTipoEspecialidade = (int)cbo_EspecialidadeProstituta.SelectedValue;
            prostituta.idSexo = (int)cbo_SexoProstituta.SelectedValue;

            string mensagem = "";

            if (verificaProstitutaExistente(prostituta.valor))
            {
                MessageBox.Show("prostituta ja existente");
            }
            else
            {
                if (prostituta.idProstituta == 0)
                {
                    db.prostituta.Add(prostituta);
                    mensagem = "prostituta salvo com sucesso!";
                }
                else
                {
                    var obj = db.Entry(prostituta);
                    obj.Property(x => x.valor);
                    mensagem = "prostituta Editado com sucesso!";
                }

                db.SaveChanges();

                MessageBox.Show(mensagem);
                CarregarGrid();
                LimparCampos();
            }
        }

        private void LimparCampos()
        {
            txt_ValorProstituta.Clear();
            cbo_EspecialidadeProstituta.SelectedIndex = 0;
            cbo_SexoProstituta.SelectedIndex = 0;
            prostituta = null;
        }

        private bool verificaProstitutaExistente(double valor)
        {
            return db.prostituta.Where(x => x.valor == valor).Count() > 0 ? true : false;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (grid_Prostituta.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = grid_Prostituta.SelectedRows[0];

                int idProstituta = (int)linha.Cells["idProstituta"].Value;

                prostituta = db.prostituta.Where(x => x.idProstituta == idProstituta).FirstOrDefault();

                cbo_EspecialidadeProstituta.SelectedValue = prostituta.idTipoEspecialidade;
                cbo_SexoProstituta.SelectedValue = prostituta.idSexo;
                txt_ValorProstituta.Text = Convert.ToString(prostituta.valor);

            }
            else
            {
                MessageBox.Show("Selecione antes qual sera editado.");
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (grid_Prostituta.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir essa prostituta?", "confirma Excluir prostituta",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int idProstituta = (int)grid_Prostituta.CurrentRow.Cells[0].Value;

                    prostituta = db.prostituta.Where(x => x.idProstituta == idProstituta).FirstOrDefault();

                    db.prostituta.Remove(prostituta);
                    db.SaveChanges();

                    MessageBox.Show("Prostituta excluida com sucesso");
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
