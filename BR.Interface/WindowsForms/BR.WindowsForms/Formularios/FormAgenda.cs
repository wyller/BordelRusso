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
    public partial class FormAgenda : Form
    {
        BordelRussoEntities db = new BordelRussoEntities();
        private agenda agenda;

        public FormAgenda()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void FormAgenda_Load(object sender, EventArgs e)
        {
            cbo_Quarto.DataSource = db.quarto.ToList();
            cbo_Quarto.DisplayMember = "numero";
            cbo_Quarto.ValueMember = "idQuarto";

            cbo_Prostituta.DataSource = db.prostituta.ToList();
            cbo_Prostituta.DisplayMember = "valor";
            cbo_Prostituta.ValueMember = "idProstituta";

            grid_Agenda.ColumnCount = 6;
            grid_Agenda.EditMode = DataGridViewEditMode.EditProgrammatically;
            grid_Agenda.MultiSelect = false;
            grid_Agenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grid_Agenda.Columns[0].HeaderText = "Quarto";
            grid_Agenda.Columns[0].DataPropertyName = "numero";
            grid_Agenda.Columns[0].Name = "numero";
            grid_Agenda.Columns[0].Width = 50;

            grid_Agenda.Columns[1].HeaderText = "Valor";
            grid_Agenda.Columns[1].DataPropertyName = "valor";
            grid_Agenda.Columns[1].Name = "valor";
            grid_Agenda.Columns[1].Width = 150;

            grid_Agenda.Columns[2].HeaderText = "Especialiade";
            grid_Agenda.Columns[2].DataPropertyName = "descricao";
            grid_Agenda.Columns[2].Name = "descricao";
            grid_Agenda.Columns[2].Width = 200;

            grid_Agenda.Columns[3].HeaderText = "Genero";
            grid_Agenda.Columns[3].DataPropertyName = "descrição";
            grid_Agenda.Columns[3].Name = "descrição";
            grid_Agenda.Columns[3].Width = 150;

            grid_Agenda.Columns[4].HeaderText = "Horario inicio";
            grid_Agenda.Columns[4].DataPropertyName = "horaInicio";
            grid_Agenda.Columns[4].Name = "horaInicio";
            grid_Agenda.Columns[4].Width = 150;

            grid_Agenda.Columns[5].HeaderText = "Horario Fim";
            grid_Agenda.Columns[5].DataPropertyName = "horaFim";
            grid_Agenda.Columns[5].Name = "horaFim";
            grid_Agenda.Columns[5].Width = 150;

            CarregarGrid();
        }

        public void CarregarGrid()
        {
            var agendas = from agenda in db.agenda
                          join prostituta in db.prostituta
                          on agenda.idProstituta equals prostituta.idProstituta
                          join quarto in db.quarto
                          on agenda.idQuarto equals quarto.idQuarto
                          join tipoEspecialiade in db.tipoEspecialiade
                          on prostituta.idTipoEspecialidade equals tipoEspecialiade.idTipoEspecialidade
                          join sexo in db.sexo
                          on prostituta.idSexo equals sexo.idSexo

                          select (new
                          {
                              quarto.numero,
                              prostituta.valor,
                              tipoEspecialiade.descricao,
                              sexo.descrição,
                              agenda.horaInicio,
                              agenda.horaFim,
                              agenda.idProstituta,
                              agenda.idQuarto
                          });

            grid_Agenda.DataSource = agendas.ToList();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (agenda == null)
            {
                agenda = new agenda();
            }

            agenda.idProstituta = (int)cbo_Prostituta.SelectedValue;
            agenda.idQuarto = (int)cbo_Quarto.SelectedValue; ;
            agenda.horaInicio = TimeSpan.Parse(txt_horaInicio.Text, System.Globalization.CultureInfo.CurrentCulture);
            agenda.horaFim = TimeSpan.Parse(txt_horaFim.Text, System.Globalization.CultureInfo.CurrentCulture);

            string mensagem = "";

            if (verificaAgendaExistente(agenda.horaInicio, agenda.idProstituta))
            {
                MessageBox.Show("Já foi agendado");
            }

            else
            {
                db.agenda.Add(agenda);
                mensagem = "Agendado!";

                db.SaveChanges();

                MessageBox.Show(mensagem);
                CarregarGrid();
                LimparCampos();
            }
        }
        private void LimparCampos()
        {
            txt_horaInicio.Clear();
            txt_horaFim.Clear();
            cbo_Quarto.SelectedIndex = 0;
            cbo_Prostituta.SelectedIndex = 0;
            agenda = null;
        }

        private bool verificaAgendaExistente(TimeSpan horaInicio, int idProstituta)
        {
            return db.agenda.Where(x => x.idProstituta == idProstituta &&
            x.horaInicio == horaInicio).Count() > 0 ? true : false;
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (grid_Agenda.SelectedRows.Count > 0)
            {
                DataGridViewRow linha = grid_Agenda.SelectedRows[0];
                int idProstituta = (int)linha.Cells["idProstituta"].Value;
                int idQuarto = (int)linha.Cells["idQuarto"].Value;

                agenda = db.agenda.Where(x => x.idProstituta == idProstituta).FirstOrDefault();
                agenda = db.agenda.Where(x => x.idQuarto == idQuarto).FirstOrDefault();

                cbo_Quarto.SelectedValue = agenda.idQuarto;
                cbo_Prostituta.SelectedValue = agenda.idProstituta;
                txt_horaFim.Text = Convert.ToString(agenda.horaInicio);
                txt_horaInicio.Text = Convert.ToString(agenda.horaFim);

            }
            else
            {
                MessageBox.Show("Selecione antes qual sera editado.");
            }
        }
    }
}

