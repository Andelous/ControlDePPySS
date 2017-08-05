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
    public partial class FrmSolicitudes : Form
    {
        public Alumno alumno { get; set; }
        public ControladorSesion controladorSesion { get; set; }

        public FrmSolicitudes(Alumno alumno, ControladorSesion controladorSesion)
        {
            InitializeComponent();

            this.alumno = alumno;
            this.controladorSesion = controladorSesion;
        }

        private void FrmSolicitudes_Load(object sender, EventArgs e)
        {
            lblNombre.Text = alumno.nombres;
            lblApellidos.Text = alumno.apellido_paterno + " " + alumno.apellido_materno;
            lblMatricula.Text = "Matrícula - " + alumno.matricula;
            lblLicenciatura.Text = alumno.Licenciatura.nombre;
            lblSemestre.Text = controladorSesion.controladorAlumnos.calcularSemestreActual(alumno.ano_ingreso) + " Semestre";

            comboTipoSolicitud.DataSource = controladorSesion.controladorCatalogos.obtenerTiposSolicitud();
            //comboEstado.SelectedIndex = 0;
            mostrarSolicitudes();
        }

        private void panelAlumno_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Point ph1 = new Point(7, 40);
            Point ph2 = new Point(241, 40);

            g.DrawLine(Pens.DarkGray, ph1, ph2);
        }

        private void panelSolicitud_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Point ph1 = new Point(7, 40);
            Point ph2 = new Point(241, 40);

            g.DrawLine(Pens.DarkGray, ph1, ph2);
        }

        private void dgvSolicitudes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSolicitudes.SelectedRows.Count > 0)
            {
                cmdModificarSolicitud.Enabled = true;
                cmdEliminarSolicitud.Enabled = true;
                comboEstado.Enabled = true;

                lblOrganizacion.Text = dgvSolicitudes.SelectedRows[0].Cells["Organizacion"].Value.ToString();
                lblJefeInmediato.Text = dgvSolicitudes.SelectedRows[0].Cells["jefe_inmediato"].Value.ToString();
                lblNumeroDeContacto.Text = dgvSolicitudes.SelectedRows[0].Cells["numero_de_contacto"].Value.ToString();

                string estado = "";

                if (Convert.ToBoolean(dgvSolicitudes.SelectedRows[0].Cells["en_revision"].Value))
                {
                    estado = "En revisión";
                    comboEstado.SelectedIndex = 0;
                }
                if (Convert.ToBoolean(dgvSolicitudes.SelectedRows[0].Cells["aprobada"].Value))
                {
                    estado = "Aprobada";
                    comboEstado.SelectedIndex = 1;
                }
                if (Convert.ToBoolean(dgvSolicitudes.SelectedRows[0].Cells["rechazada"].Value))
                {
                    estado = "Rechazada";
                    comboEstado.SelectedIndex = 2;
                }
                if (Convert.ToBoolean(dgvSolicitudes.SelectedRows[0].Cells["cancelada"].Value))
                {
                    estado = "Cancelada";
                }

                lblEstado.Text = estado;
            }
            else
            {
                lblOrganizacion.Text = "Sin selección";
                lblJefeInmediato.Text = "--";
                lblNumeroDeContacto.Text = "--";
                lblEstado.Text = "--";

                cmdModificarSolicitud.Enabled = false;
                cmdEliminarSolicitud.Enabled = false;
                comboEstado.Enabled = false;
            }
        }

        private void mostrarSolicitudes()
        {
            mostrarSolicitudes(controladorSesion.controladorSolicitudes.obtenerSolicitudes(alumno.matricula, ((TipoSolicitud)comboTipoSolicitud.SelectedItem).tipo_solicitud_id));
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
            dgvSolicitudes.Columns[11].Visible = false;
            dgvSolicitudes.Columns[13].Visible = false;

            dgvSolicitudes.Columns[1].HeaderText = "Jefe inmediato";
            dgvSolicitudes.Columns[2].HeaderText = "Contacto";
            dgvSolicitudes.Columns[3].HeaderText = "Área";
            dgvSolicitudes.Columns[12].HeaderText = "Tipo de solicitud";
        }

        private void FrmSolicitudes_Resize(object sender, EventArgs e)
        {
            // Panel solicitudes
            panelSolicitudes.Width = Width - 284;
            panelSolicitudes.Height = Height - 39;
            {
                // Componentes del panel
                comboTipoSolicitud.Location = new Point(
                    panelSolicitudes.Width - 229,
                    comboTipoSolicitud.Location.Y
                );

                dgvSolicitudes.Width = panelSolicitudes.Width - 12;
                dgvSolicitudes.Height = panelSolicitudes.Height - 123;

                cmdNuevaSolicitud.Location = new Point(
                    cmdNuevaSolicitud.Location.X,
                    panelSolicitudes.Height - 43
                );

                cmdModificarSolicitud.Location = new Point(
                    cmdModificarSolicitud.Location.X,
                    panelSolicitudes.Height - 43
                );

                cmdEliminarSolicitud.Location = new Point(
                    cmdEliminarSolicitud.Location.X,
                    panelSolicitudes.Height - 43
                );
            }


            // GroupBox Datos
            gbDatos.Location = new Point(
                Width - 278,
                gbDatos.Location.Y
            );
            gbDatos.Height = Height - 63;
            {
                // Componentes del gb
                panelSolicitud.Location = new Point(
                    panelSolicitud.Location.X,
                    gbDatos.Height - 237
                );
            }
        }

        private void cmdNuevaSolicitud_Click(object sender, EventArgs e)
        {
            (new FrmNuevaSolicitud(alumno, (TipoSolicitud)comboTipoSolicitud.SelectedItem, controladorSesion)).ShowDialog();
            mostrarSolicitudes();
        }

        private void cmdModificarSolicitud_Click(object sender, EventArgs e)
        {
            (new FrmModificarSolicitud(
                controladorSesion.controladorSolicitudes.
                obtenerSolicitud(Convert.ToInt32(dgvSolicitudes.SelectedRows[0].Cells[0].Value)),
                controladorSesion)).ShowDialog();
            mostrarSolicitudes();
        }

        private void comboTipoSolicitud_SelectedIndexChanged(object sender, EventArgs e)
        {
            mostrarSolicitudes(
                controladorSesion.
                controladorSolicitudes.
                obtenerSolicitudes(
                    alumno.matricula,
                    ((TipoSolicitud)comboTipoSolicitud.SelectedItem).tipo_solicitud_id)
            );
        }

        private void cmdEliminarSolicitud_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(
                "¿Está seguro que desea eliminar la solicitud seleccionada?\n" +
                "Una vez eliminada, no se podrán recuperar sus datos,\n" +
                "incluyendo reportes, cartas de aceptación, etc.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes
                )
            {
                if (
                    MessageBox.Show(
                    "Se procederá a eliminar los datos\n" +
                    "¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes
                    )
                {
                    if (controladorSesion.controladorSolicitudes.eliminarSolicitud(
                        Convert.ToInt32(dgvSolicitudes.SelectedRows[0].Cells[0].Value)
                        ) == 1)
                    {
                        MessageBox.Show("Solicitud eliminada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la solicitud.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            mostrarSolicitudes();
        }

        private void comboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvSolicitudes.RowCount > 0)
            {
                Solicitud s = controladorSesion.controladorSolicitudes.
                obtenerSolicitud(Convert.ToInt32(dgvSolicitudes.SelectedRows[0].Cells[0].Value));

                controladorSesion.
                controladorSolicitudes.
                modificarSolicitud(
                    s.jefe_inmediato,
                    s.numero_de_contacto,
                    s.area,
                    comboEstado.SelectedIndex == 0 ? true : false,
                    comboEstado.SelectedIndex == 1 ? true : false,
                    comboEstado.SelectedIndex == 2 ? true : false,
                    s.Organizacion,
                    s
                );
            }
        }
    }
}
