using ControlDePPySS.Controlador;
using ControlDePPySS.DataLinq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDePPySS
{
    public partial class FrmSeleccionarCarta : Form
    {
        public ControladorSesion controladorSesion { get; set; }
        public Alumno alumno { get; set; }

        public FrmSeleccionarCarta(ControladorSesion controladorSesion, Alumno alumno)
        {
            InitializeComponent();

            this.controladorSesion = controladorSesion;
            this.alumno = alumno;
        }

        private void FrmSeleccionarCarta_Load(object sender, EventArgs e)
        {
            mostrarCartas(
                controladorSesion.
                controladorCartas.
                obtenerCartas(alumno.matricula)
            );
        }

        private void mostrarCartas(List<CartaAceptacion> lista)
        {
            dgvCartas.DataSource = lista;

            dgvCartas.Columns[0].Visible = false;
            dgvCartas.Columns[4].Visible = false;
            dgvCartas.Columns[5].Visible = false;
            dgvCartas.Columns[6].Visible = false;
            dgvCartas.Columns[7].Visible = false;
            dgvCartas.Columns[8].Visible = false;
            dgvCartas.Columns[9].Visible = false;
            dgvCartas.Columns[10].Visible = false;
            dgvCartas.Columns[13].Visible = false;

            dgvCartas.Columns[1].HeaderText = "Horas a liberar";
            dgvCartas.Columns[2].HeaderText = "Fecha de inicio";
            dgvCartas.Columns[3].HeaderText = "Fecha de fin";
            dgvCartas.Columns[11].HeaderText = "Hora de entrada";
            dgvCartas.Columns[12].HeaderText = "Hora de salida";
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void dgvCartas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCartas.SelectedRows.Count > 0)
            {
                cmdSeleccionar.Enabled = true;
            }
            else
            {
                cmdSeleccionar.Enabled = false;
            }
        }

        private void cmdSeleccionar_Click(object sender, EventArgs e)
        {
            ControladorReportes.cartaAceptacionSeleccionada =
                controladorSesion.
                controladorCartas.
                obtenerCarta(
                    Convert.ToInt32(dgvCartas.SelectedRows[0].Cells[0].Value)
                    );
            Hide();
        }
    }
}
