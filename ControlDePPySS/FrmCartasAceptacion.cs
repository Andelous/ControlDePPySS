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
    public partial class FrmCartasAceptacion : Form
    {
        public Alumno alumno { get; set; }
        public ControladorSesion controladorSesion { get; set; }

        public FrmCartasAceptacion(Alumno alumno, ControladorSesion controladorSesion)
        {
            InitializeComponent();

            this.alumno = alumno;
            this.controladorSesion = controladorSesion;
        }

        private void FrmCartasAceptacion_Load(object sender, EventArgs e)
        {
            lblNombre.Text = alumno.nombres;
            lblApellidos.Text = alumno.apellido_paterno + " " + alumno.apellido_materno;
            lblMatricula.Text = "Matrícula - " + alumno.matricula;
            lblLicenciatura.Text = alumno.Licenciatura.nombre;
            lblSemestre.Text = controladorSesion.controladorAlumnos.calcularSemestreActual(alumno.ano_ingreso) + " Semestre";

            mostrarCartas();
        }

        private void mostrarCartas()
        {
            dgvCartas.DataSource = controladorSesion.controladorCartas.obtenerCartas(alumno.matricula);

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

        private void panelAlumno_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Point ph1 = new Point(7, 40);
            Point ph2 = new Point(241, 40);

            g.DrawLine(Pens.DarkGray, ph1, ph2);
        }

        private void panelCarta_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Point ph1 = new Point(7, 40);
            Point ph2 = new Point(241, 40);

            g.DrawLine(Pens.DarkGray, ph1, ph2);
        }

        private void cmdNuevaCarta_Click(object sender, EventArgs e)
        {
            (new FrmNuevaCarta(alumno, controladorSesion)).ShowDialog();
            mostrarCartas();
        }

        private void FrmCartasAceptacion_Resize(object sender, EventArgs e)
        {
            // Panel cartas
            panelCartas.Width = Width - 284;
            panelCartas.Height = Height - 39;
            {
                // Componentes del panel

                dgvCartas.Width = panelCartas.Width - 12;
                dgvCartas.Height = panelCartas.Height - 123;

                cmdNuevaCarta.Location = new Point(
                    cmdNuevaCarta.Location.X,
                    panelCartas.Height - 43
                );

                cmdModificarCarta.Location = new Point(
                    cmdModificarCarta.Location.X,
                    panelCartas.Height - 43
                );

                cmdEliminarCarta.Location = new Point(
                    cmdEliminarCarta.Location.X,
                    panelCartas.Height - 43
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
                panelCarta.Location = new Point(
                    panelCarta.Location.X,
                    gbDatos.Height - 237
                );
            }
        }

        private void cmdModificarCarta_Click(object sender, EventArgs e)
        {
            (new FrmModificarCarta(
                controladorSesion,
                controladorSesion.
                    controladorCartas.
                    obtenerCarta(
                        Convert.ToInt32(dgvCartas.SelectedRows[0].Cells[0].Value)
                        )
                )).ShowDialog();
            mostrarCartas();
        }

        private void cmdEliminarCarta_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(
                "¿Está seguro que desea eliminar la carta seleccionada?\n" +
                "Una vez eliminada, no se podrán recuperar sus datos,\n" +
                "incluyendo reportes, informes, etc.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes
                )
            {
                if (
                    MessageBox.Show(
                    "Se procederá a eliminar los datos\n" +
                    "¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes
                    )
                {
                    if (controladorSesion.controladorCartas.eliminarCarta(
                        Convert.ToInt32(dgvCartas.SelectedRows[0].Cells[0].Value)
                        ) == 1)
                    {
                        MessageBox.Show("Carta de aceptación eliminada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la carta de aceptación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            mostrarCartas();
        }

        private void dgvCartas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCartas.SelectedRows.Count > 0)
            {
                cmdEliminarCarta.Enabled = true;
                cmdModificarCarta.Enabled = true;

                lblOrganizacion.Text = dgvCartas.SelectedRows[0].Cells["Solicitud"].Value.ToString();
                lblDesde.Text = dgvCartas.SelectedRows[0].Cells["fecha_inicio"].Value.ToString().Substring(0, 10);
                lblHasta.Text = dgvCartas.SelectedRows[0].Cells["fecha_fin"].Value.ToString().Substring(0, 10);

                lblHorario.Text =
                    dgvCartas.SelectedRows[0].Cells["hora_entrada"].Value.ToString() +
                    " a " +
                    dgvCartas.SelectedRows[0].Cells["hora_salida"].Value.ToString() ;

                lblLun.ForeColor = 
                    Convert.ToBoolean(dgvCartas.SelectedRows[0].Cells["lunes"].Value) ?
                    Color.Blue : Color.Black;
                lblMar.ForeColor =
                    Convert.ToBoolean(dgvCartas.SelectedRows[0].Cells["martes"].Value) ?
                    Color.Blue : Color.Black;
                lblMie.ForeColor =
                    Convert.ToBoolean(dgvCartas.SelectedRows[0].Cells["miercoles"].Value) ?
                    Color.Blue : Color.Black;
                lblJue.ForeColor =
                    Convert.ToBoolean(dgvCartas.SelectedRows[0].Cells["jueves"].Value) ?
                    Color.Blue : Color.Black;
                lblVie.ForeColor =
                    Convert.ToBoolean(dgvCartas.SelectedRows[0].Cells["viernes"].Value) ?
                    Color.Blue : Color.Black;
                lblSab.ForeColor =
                    Convert.ToBoolean(dgvCartas.SelectedRows[0].Cells["sabado"].Value) ?
                    Color.Blue : Color.Black;
                lblDom.ForeColor =
                    Convert.ToBoolean(dgvCartas.SelectedRows[0].Cells["domingo"].Value) ?
                    Color.Blue : Color.Black;
            }
            else
            {
                cmdEliminarCarta.Enabled = false;
                cmdModificarCarta.Enabled = false;

                lblOrganizacion.Text = "Sin selección";
                lblDesde.Text = "--";
                lblHasta.Text = "--";

                lblHorario.Text = "..:.. a ..:..";

                lblLun.ForeColor = Color.Black;
                lblMar.ForeColor = Color.Black;
                lblMie.ForeColor = Color.Black;
                lblJue.ForeColor = Color.Black;
                lblVie.ForeColor = Color.Black;
                lblSab.ForeColor = Color.Black;
                lblDom.ForeColor = Color.Black;
            }
        }
    }
}
