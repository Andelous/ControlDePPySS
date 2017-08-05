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
    public partial class FrmSeleccionarSolicitud : Form
    {
        public ControladorSesion controladorSesion { get; set; }
        public Alumno alumno { get; set; }

        public FrmSeleccionarSolicitud(ControladorSesion controladorSesion, Alumno alumno)
        {
            InitializeComponent();

            this.controladorSesion = controladorSesion;
            this.alumno = alumno;
        }

        private void FrmSeleccionarSolicitud_Load(object sender, EventArgs e)
        {
            mostrarSolicitudes(
                controladorSesion.
                controladorSolicitudes.
                obtenerSolicitudesAceptadas(alumno.matricula)
            );
        }

        private void mostrarSolicitudes(List<Solicitud> lista)
        {
            dgvSolicitudes.DataSource = lista;

            dgvSolicitudes.Columns[0].Visible = false;
            dgvSolicitudes.Columns[4].Visible = false;
            dgvSolicitudes.Columns[5].Visible = false;
            dgvSolicitudes.Columns[6].Visible = false;
            dgvSolicitudes.Columns[7].Visible = false;
            dgvSolicitudes.Columns[8].Visible = false;
            dgvSolicitudes.Columns[9].Visible = false;
            dgvSolicitudes.Columns[10].Visible = false;
            //dgvSolicitudes.Columns[11].Visible = false;
            dgvSolicitudes.Columns[13].Visible = false;

            dgvSolicitudes.Columns[1].HeaderText = "Jefe inmediato";
            dgvSolicitudes.Columns[2].HeaderText = "Contacto";
            dgvSolicitudes.Columns[3].HeaderText = "Área";
            dgvSolicitudes.Columns[11].HeaderText = "Organización";
            dgvSolicitudes.Columns[12].HeaderText = "Tipo de solicitud";
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void cmdSeleccionar_Click(object sender, EventArgs e)
        {
            ControladorCartas.solicitudSeleccionada = controladorSesion.
                controladorSolicitudes.
                obtenerSolicitud(
                    Convert.ToInt32(dgvSolicitudes.SelectedRows[0].Cells[0].Value)
                );

            Hide();
        }

        private void dgvSolicitudes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSolicitudes.SelectedRows.Count > 0)
            {
                cmdSeleccionar.Enabled = true;
            }
            else
            {
                cmdSeleccionar.Enabled = false;
            }
        }
    }
}
