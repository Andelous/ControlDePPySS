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
    public partial class FrmModificarSolicitud : Form
    {
        public Solicitud solicitud { get; set; }
        public ControladorSesion controladorSesion { get; set; }

        public FrmModificarSolicitud(Solicitud solicitud, ControladorSesion controladorSesion)
        {
            InitializeComponent();

            this.solicitud = solicitud;
            this.controladorSesion = controladorSesion;
        }

        private void FrmModificarSolicitud_Load(object sender, EventArgs e)
        {
            ControladorSolicitudes.organizacionSeleccionada = solicitud.Organizacion;

            mostrarDatos();
        }

        private void mostrarDatos()
        {
            txtAlumno.Text = solicitud.Alumno.ToString();
            txtTipo.Text = solicitud.TipoSolicitud.ToString();

            txtJefeInmediado.Text = solicitud.jefe_inmediato;
            txtNumero.Text = solicitud.numero_de_contacto;
            txtArea.Text = solicitud.area;

            mostrarOrganizacion();
        }

        private void mostrarOrganizacion()
        {
            txtOrganizacion.Text = ControladorSolicitudes.organizacionSeleccionada == null ?
            "Ninguna" : ControladorSolicitudes.organizacionSeleccionada.ToString();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
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
                    modificarSolicitud(
                        txtJefeInmediado.Text,
                        txtNumero.Text,
                        txtArea.Text,
                        solicitud.en_revision,
                        solicitud.aprobada,
                        solicitud.rechazada,
                        ControladorSolicitudes.organizacionSeleccionada,
                        solicitud) == 1
                    )
                {
                    MessageBox.Show("Solicitud modificada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                }
                else
                {
                    MessageBox.Show("Error al modificar solicitud.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void cmdSeleccionar_Click(object sender, EventArgs e)
        {
            (new FrmSeleccionarOrganizacion(controladorSesion)).ShowDialog();
            mostrarOrganizacion();
        }
    }
}
