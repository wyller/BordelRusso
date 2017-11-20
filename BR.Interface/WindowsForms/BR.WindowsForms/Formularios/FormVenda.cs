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
    public partial class FormVenda : Form
    {
        BordelRussoEntities db = new BordelRussoEntities();
        private venda venda;

        public FormVenda()
        {
            InitializeComponent();
        }

        private void FormVenda_Load(object sender, EventArgs e)
        {
            cbo_Cliente.DataSource = db.cliente.ToList();
            cbo_Cliente.DisplayMember = "Apelido";
            cbo_Cliente.ValueMember = "idCliete";

            cbo_Bebida.DataSource = db.bebida.ToList();
            cbo_Bebida.DisplayMember = "marca";
            cbo_Bebida.ValueMember = "idBebida";

            grid_Vendas.ColumnCount = 4;
            grid_Vendas.EditMode = DataGridViewEditMode.EditProgrammatically;
            grid_Vendas.MultiSelect = false;
            grid_Vendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grid_Vendas.Columns[0].HeaderText = "Nome";
            grid_Vendas.Columns[0].DataPropertyName = "nome";
            grid_Vendas.Columns[0].Name = "nome";
            grid_Vendas.Columns[0].Width = 150;

            grid_Vendas.Columns[1].HeaderText = "Apelido";
            grid_Vendas.Columns[1].DataPropertyName = "Apelido";
            grid_Vendas.Columns[1].Name = "Apelido";
            grid_Vendas.Columns[1].Width = 150;

            grid_Vendas.Columns[2].HeaderText = "Marca";
            grid_Vendas.Columns[2].DataPropertyName = "marca";
            grid_Vendas.Columns[2].Name = "marca";
            grid_Vendas.Columns[2].Width = 150;

            grid_Vendas.Columns[3].HeaderText = "Tipo venda";
            grid_Vendas.Columns[3].DataPropertyName = "descricao";
            grid_Vendas.Columns[3].Name = "descricao";
            grid_Vendas.Columns[3].Width = 270;

            CarregarGrid();
        }

        public void CarregarGrid()
        {
            var vendas = from venda in db.venda
                            join cliente in db.cliente
                            on venda.idCliete equals cliente.idCliete
                            join bebida in db.bebida
                            on venda.idBebida equals bebida.idBebida
                            join tipoBebida in db.tipoBebida
                            on bebida.idTipoBebida equals tipoBebida.idtipoBebida
                          select (new {
                              cliente.nome,
                              cliente.Apelido,
                              bebida.marca,
                              tipoBebida.descricao,
                              venda.idCliete,
                              venda.idBebida
                          });

            grid_Vendas.DataSource = vendas.ToList();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (venda == null)
            {
                venda = new venda();

            }

                venda.idBebida = (int)cbo_Bebida.SelectedValue;
                venda.idCliete = (int)cbo_Cliente.SelectedValue;

                string mensagem = "";

                db.venda.Add(venda);
                mensagem = "Venda realizada com sucesso!";             

                db.SaveChanges();

                MessageBox.Show(mensagem);
                CarregarGrid();
                LimparCampos();
            
        }

        private void LimparCampos()
        {
            cbo_Bebida.SelectedIndex = 0;
            cbo_Cliente.SelectedIndex = 0;
            venda = null;
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (grid_Vendas.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir essa bebida?", "confirma Excluir bebida",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    DataGridViewRow linha = grid_Vendas.SelectedRows[0];

                    int idCliente = (int)linha.Cells["idCliete"].Value;
                    int idBebidas = (int)linha.Cells["idBebida"].Value;

                    venda = db.venda.Where(x => x.idBebida == idBebidas && x.idCliete == idCliente).FirstOrDefault();

                    db.venda.Remove(venda);
                    db.SaveChanges();

                    MessageBox.Show("Venda excluida com sucesso");
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
