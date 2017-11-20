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
    public partial class FormCliente : Form
    {
        BordelRussoEntities db = new BordelRussoEntities();
        private cliente cliente;

        public FormCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            cbo_TipoSexo.DataSource = db.sexo.ToList();
            cbo_TipoSexo.DisplayMember = "descrição";
            cbo_TipoSexo.ValueMember = "idSexo";

            grid_Cliente.ColumnCount = 4;
            grid_Cliente.EditMode = DataGridViewEditMode.EditProgrammatically;
            grid_Cliente.MultiSelect = false;
            grid_Cliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grid_Cliente.Columns[0].HeaderText = "Codigo";
            grid_Cliente.Columns[0].DataPropertyName = "idCliete";
            grid_Cliente.Columns[0].Name = "idCliete";
            grid_Cliente.Columns[0].Width = 50;

            grid_Cliente.Columns[1].HeaderText = "Nome";
            grid_Cliente.Columns[1].DataPropertyName = "nome";
            grid_Cliente.Columns[1].Name = "nome";
            grid_Cliente.Columns[1].Width = 125;

            grid_Cliente.Columns[2].HeaderText = "Apelido";
            grid_Cliente.Columns[2].DataPropertyName = "Apelido";
            grid_Cliente.Columns[2].Name = "Apelido";
            grid_Cliente.Columns[2].Width = 125;

            grid_Cliente.Columns[3].HeaderText = "Tipo";
            grid_Cliente.Columns[3].DataPropertyName = "descrição";
            grid_Cliente.Columns[3].Name = "descrição";
            grid_Cliente.Columns[3].Width = 125;

            CarregarGrid();
        }

        public void CarregarGrid()
        {
            var clientes = from cliente in db.cliente
                          join sexo in db.sexo
                          on cliente.idSexo equals sexo.idSexo
                          select (new { cliente.idCliete, cliente.nome, cliente.Apelido, sexo.descrição});

            grid_Cliente.DataSource = clientes.ToList();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (cliente == null)
            {
                cliente = new cliente();
            }

            int idCliete = cliente.idCliete > 0 ? cliente.idCliete : 0;

            cliente.idCliete = idCliete;
            cliente.nome = txt_NomeCliente.Text;
            cliente.Apelido = txt_ApelidoCliente.Text;
            cliente.idSexo = (int)cbo_TipoSexo.SelectedValue;

            string mensagem = "";

            if (verificaClienteExistente(cliente.Apelido, cliente.nome))
            {
                MessageBox.Show("cliente ja existente");
            }
            else
            {
                if (cliente.idCliete == 0)
                {
                    db.cliente.Add(cliente);
                    mensagem = "cliente salvo com sucesso!";
                }
                else
                {
                    var obj = db.Entry(cliente);
                    obj.Property(x => x.nome);
                    obj.Property(x => x.Apelido);
                    mensagem = "cliente Editado com sucesso!";
                }

                db.SaveChanges();

                MessageBox.Show(mensagem);
                CarregarGrid();
                LimparCampos();
            }
        }

        private void LimparCampos()
        {
            txt_ApelidoCliente.Clear();
            txt_NomeCliente.Clear();
            cbo_TipoSexo.SelectedIndex = 0;
            cliente = null;
        }

        private bool verificaClienteExistente(string Apelido, string Nome)
        {
            return db.cliente.Where(x => x.Apelido == Apelido && x.nome == Nome).Count() > 0 ? true : false;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (grid_Cliente.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = grid_Cliente.SelectedRows[0];

                int idCliente = (int)linha.Cells["idCliete"].Value;

                cliente = db.cliente.Where(x => x.idCliete == idCliente).FirstOrDefault();

                cbo_TipoSexo.SelectedValue = cliente.idSexo;
                txt_NomeCliente.Text = cliente.nome;
                txt_ApelidoCliente.Text = cliente.Apelido;

            }
            else
            {
                MessageBox.Show("Selecione antes qual sera editado.");
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (grid_Cliente.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir essa bebida?", "confirma Excluir bebida",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int idBebida = (int)grid_Cliente.CurrentRow.Cells[0].Value;

                    cliente = db.cliente.Where(x => x.idCliete == idBebida).FirstOrDefault();

                    db.cliente.Remove(cliente);
                    db.SaveChanges();

                    MessageBox.Show("cliente excluido com sucesso");
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
