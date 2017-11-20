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
    public partial class FormBebida : Form
    {

        BordelRussoEntities db = new BordelRussoEntities();
        private bebida bebida;

        public FormBebida()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (grid_bebida.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir essa bebida?", "confirma Excluir bebida",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int idBebida = (int)grid_bebida.CurrentRow.Cells[0].Value;

                    bebida = db.bebida.Where(x => x.idBebida == idBebida).FirstOrDefault();

                    db.bebida.Remove(bebida);
                    db.SaveChanges();

                    MessageBox.Show("bebida excluida com sucesso");
                    CarregarGrid();
                    LimparCampos();


                }
            }
            else
            {
                MessageBox.Show("Selecione antes qual sera editado.");
            }
        }

        private void FormBebida_Load(object sender, EventArgs e)
        {
            cbo_TipoBebida.DataSource = db.tipoBebida.ToList();
            cbo_TipoBebida.DisplayMember = "descricao";
            cbo_TipoBebida.ValueMember = "idTipoBebida";

            grid_bebida.ColumnCount = 3;
            grid_bebida.EditMode = DataGridViewEditMode.EditProgrammatically;
            grid_bebida.MultiSelect = false;
            grid_bebida.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grid_bebida.Columns[0].HeaderText = "Codigo";
            grid_bebida.Columns[0].DataPropertyName = "idBebida";
            grid_bebida.Columns[0].Name = "idBebida";
            grid_bebida.Columns[0].Width = 50;

            grid_bebida.Columns[1].HeaderText = "Tipo";
            grid_bebida.Columns[1].DataPropertyName = "descricao";
            grid_bebida.Columns[1].Name = "descricao";
            grid_bebida.Columns[1].Width = 270;

            grid_bebida.Columns[2].HeaderText = "Marca";
            grid_bebida.Columns[2].DataPropertyName = "marca";
            grid_bebida.Columns[2].Name = "marca";
            grid_bebida.Columns[2].Width = 270;

            CarregarGrid();
        }

        public void CarregarGrid()
        {
            var bebidas = from bebida in db.bebida
                          join tipoBebida in db.tipoBebida
                          on bebida.idTipoBebida equals tipoBebida.idtipoBebida
                          select (new { bebida.idBebida, tipoBebida.descricao, bebida.marca});

            grid_bebida.DataSource = bebidas.ToList();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (bebida == null)
            {
                bebida = new bebida();
            }

            int idBebida = bebida.idBebida > 0 ? bebida.idBebida : 0;

            bebida.idBebida = idBebida;
            bebida.marca = txt_Marca.Text;
            bebida.idTipoBebida = (int)cbo_TipoBebida.SelectedValue;

            string mensagem = "";

            if (verificabebidaExistente(bebida.marca))
            {
                MessageBox.Show("Bebida ja existente");
            }
            else
            {
                if (bebida.idBebida == 0)
                {
                    db.bebida.Add(bebida);
                    mensagem = "bebida salvo com sucesso!";
                }
                else
                {
                    var obj = db.Entry(bebida);
                    obj.Property(x => x.marca);
                    mensagem = "bebida Editado com sucesso!";
                }

                db.SaveChanges();

                MessageBox.Show(mensagem);
                CarregarGrid();
                LimparCampos();
            }
        }

        private void LimparCampos()
        {
            txt_Marca.Clear();
            cbo_TipoBebida.SelectedIndex = 0;
            bebida = null;
        }

        private bool verificabebidaExistente(string marca)
        {
            return db.bebida.Where(x => x.marca == marca).Count() > 0 ? true : false;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (grid_bebida.SelectedRows.Count > 0)
            {
                int idBebida = (int)grid_bebida.CurrentRow.Cells[0].Value;

                bebida = db.bebida.Where(x => x.idBebida == idBebida).FirstOrDefault();

                cbo_TipoBebida.SelectedValue = bebida.idTipoBebida;
                txt_Marca.Text = Convert.ToString(bebida.marca);

            }
            else
            {
                MessageBox.Show("Selecione antes qual sera editado.");
            }
        }
    }
}
