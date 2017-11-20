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
    public partial class FormTipoBebida : Form
    {
        BordelRussoEntities db = new BordelRussoEntities();
        private tipoBebida tipoBebida;

        public FormTipoBebida()
        {
            InitializeComponent();
        }

        private void FormTipoBebida_Load(object sender, EventArgs e)
        {
            grid_TipoBebida.ColumnCount = 2;
            grid_TipoBebida.EditMode = DataGridViewEditMode.EditProgrammatically;
            grid_TipoBebida.MultiSelect = false;
            grid_TipoBebida.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grid_TipoBebida.Columns[0].HeaderText = "Codigo tipo bebida";
            grid_TipoBebida.Columns[0].DataPropertyName = "idtipoBebida";
            grid_TipoBebida.Columns[0].Width = 150;
            grid_TipoBebida.Columns[0].Name = "idtipoBebida";

            grid_TipoBebida.Columns[1].HeaderText = "Descrição";
            grid_TipoBebida.Columns[1].DataPropertyName = "descricao";
            grid_TipoBebida.Columns[1].Width = 309;
            grid_TipoBebida.Columns[1].Name = "descricao";

            CarregarGrid();

        }

        private void lbl_TipoBebida_Click(object sender, EventArgs e)
        {

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (grid_TipoBebida.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = grid_TipoBebida.SelectedRows[0];
                int idTipoBebida = (int)linha.Cells["idTipoBebida"].Value;

                tipoBebida = db.tipoBebida.Where(x => x.idtipoBebida == idTipoBebida).FirstOrDefault();

                db.tipoBebida.Remove(tipoBebida);
                db.SaveChanges();

                MessageBox.Show("Tipo bebida excluido com sucesso");
                CarregarGrid();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Selecione um tipo de bebida para excluir! ");
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if(grid_TipoBebida.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = grid_TipoBebida.SelectedRows[0];
                int idTipoBebida = (int)linha.Cells["idTipoBebida"].Value;

                tipoBebida = db.tipoBebida.Where(x => x.idtipoBebida == idTipoBebida).FirstOrDefault();
                txt_DescricaoTipoBebida.Text = tipoBebida.descricao;
            }
            else
            {
                MessageBox.Show("Selecione um tipo de bebida para alterar! ");
            }
        }

        public void CarregarGrid()
        {
            var tipoBebidas = from tipoBebida in db.tipoBebida select (new { tipoBebida.idtipoBebida, tipoBebida.descricao });
            grid_TipoBebida.DataSource = tipoBebidas.ToList();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (tipoBebida == null)
            {
                tipoBebida = new tipoBebida();
            }

            int idTípoBebida = tipoBebida.idtipoBebida > 0 ? tipoBebida.idtipoBebida : 0;

            tipoBebida.idtipoBebida = idTípoBebida;
            tipoBebida.descricao = txt_DescricaoTipoBebida.Text;

            string mensagem = "";

            if(tipoBebida.idtipoBebida == 0)
            {                   
                db.tipoBebida.Add(tipoBebida);
                mensagem = "Tipo bebida registrado com sucesso";
            }
            else
            {
                var obj = db.Entry(tipoBebida);
                obj.Property(x => x.descricao).IsModified = true;

                mensagem = "Tipo bebida alterado com sucesso";

            }

            db.SaveChanges();

            MessageBox.Show(mensagem);
            CarregarGrid();
            LimparCampos();
        }

        public void LimparCampos()
        {
            txt_DescricaoTipoBebida.Clear();
            tipoBebida = null;
        }

        private void grid_TipoBebida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}