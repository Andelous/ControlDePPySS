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
    public partial class FrmNuevaSolicitud : Form
    {
        public ControladorSesion controladorSesion { get; set; }
        public Alumno alumno { get; set; }
        public TipoSolicitud tipo { get; set; }

        public FrmNuevaSolicitud(Alumno alumno, TipoSolicitud tipo, ControladorSesion controladorSesion)
        {
            InitializeComponent();

            this.alumno = alumno;
            this.tipo = tipo;
            this.controladorSesion = controladorSesion;
        }

        private void FrmNuevaSolicitud_Load(object sender, EventArgs e)
        {
            ControladorSolicitudes.organizacionSeleccionada = null;

            mostrarDatos();
        }

        private void cmdSeleccionar_Click(object sender, EventArgs e)
        {
            (new FrmSeleccionarOrganizacion(controladorSesion)).ShowDialog();
            mostrarDatos();
        }

        private void mostrarDatos()
        {
            txtAlumno.Text = alumno.ToString();
            txtTipo.Text = tipo.ToString();

            txtOrganizacion.Text = ControladorSolicitudes.organizacionSeleccionada == null ?
                "Ninguna" : ControladorSolicitudes.organizacionSeleccionada.ToString();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            if (
                txtJefeInmediado.Text == "" || 
                txtNumero.Text == "" || 
                txtArea.Text == "" ||
                ControladorSolicitudes.organizacionSeleccionada == null
                )
            {
                MessageBox.Show("Rellene los campos correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (
                    controladorSesion.controladorSolicitudes.
                    registrarSolicitud(
                        txtJefeInmediado.Text,
                        txtNumero.Text, 
                        txtArea.Text, 
                        alumno, 
                        ControladorSolicitudes.organizacionSeleccionada, 
                        tipo) == 1
                    )
                {
                    MessageBox.Show("Solicitud registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                }
                else
                {
                    MessageBox.Show("Error al registrar solicitud.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
