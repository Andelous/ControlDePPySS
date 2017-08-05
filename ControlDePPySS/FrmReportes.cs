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
    public partial class FrmReportes : Form
    {
        public Alumno alumno { get; set; }
        public ControladorSesion controladorSesion { get; set; }

        public FrmReportes(Alumno alumno, ControladorSesion controladorSesion)
        {
            InitializeComponent();

            this.alumno = alumno;
            this.controladorSesion = controladorSesion;
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            lblNombre.Text = alumno.nombres;
            lblApellidos.Text = alumno.apellido_paterno + " " + alumno.apellido_materno;
            lblMatricula.Text = "Matrícula - " + alumno.matricula;
            lblLicenciatura.Text = alumno.Licenciatura.nombre;
            lblSemestre.Text = controladorSesion.controladorAlumnos.calcularSemestreActual(alumno.ano_ingreso) + " Semestre";

            mostrarReportes();
        }

        private void panelAlumno_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Point ph1 = new Point(7, 40);
            Point ph2 = new Point(241, 40);

            g.DrawLine(Pens.DarkGray, ph1, ph2);
        }

        private void panelReporte_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Point ph1 = new Point(7, 40);
            Point ph2 = new Point(241, 40);

            g.DrawLine(Pens.DarkGray, ph1, ph2);
        }

        private void FrmReportes_Resize(object sender, EventArgs e)
        {
            // Panel reportes
            panelReportes.Width = Width - 284;
            panelReportes.Height = Height - 39;
            {
                // Componentes del panel

                dgvReportes.Width = panelReportes.Width - 12;
                dgvReportes.Height = panelReportes.Height - 123;

                cmdNuevoReporte.Location = new Point(
                    cmdNuevoReporte.Location.X,
                    panelReportes.Height - 43
                );

                cmdModificarReporte.Location = new Point(
                    cmdModificarReporte.Location.X,
                    panelReportes.Height - 43
                );

                cmdEliminarReporte.Location = new Point(
                    cmdEliminarReporte.Location.X,
                    panelReportes.Height - 43
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
                panelReporte.Location = new Point(
                    panelReporte.Location.X,
                    gbDatos.Height - 237
                );
            }
        }

        private void cmdNuevoReporte_Click(object sender, EventArgs e)
        {
            (new FrmNuevoReporte(alumno, controladorSesion)).ShowDialog();
            mostrarReportes();
        }

        private void mostrarReportes()
        {
            dgvReportes.DataSource = controladorSesion.controladorReportes.obtenerReportes(alumno.matricula);

            dgvReportes.Columns[0].Visible = false;
            dgvReportes.Columns[4].Visible = false;
            dgvReportes.Columns[5].Visible = false;

            dgvReportes.Columns[1].HeaderText = "Horas liberadas";
            dgvReportes.Columns[2].HeaderText = "Fecha de inicio";
            dgvReportes.Columns[3].HeaderText = "Fecha de fin";
        }

        private void cmdModificarReporte_Click(object sender, EventArgs e)
        {
            (new FrmModificarReporte(
                controladorSesion, 
                controladorSesion.
                    controladorReportes.
                    obtenerReporte(
                        Convert.ToInt32(dgvReportes.SelectedRows[0].Cells[0].Value)
                    )
            )).ShowDialog();
            mostrarReportes();
        }

        private void cmdEliminarReporte_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(
                "¿Está seguro que desea eliminar el reporte seleccionado?\n" +
                "Una vez eliminado, no se podrán recuperar sus datos,\n" +
                "incluyendo informes, etc.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes
                )
            {
                if (
                    MessageBox.Show(
                    "Se procederá a eliminar los datos\n" +
                    "¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes
                    )
                {
                    if (controladorSesion.controladorReportes.eliminarReporte(
                        Convert.ToInt32(dgvReportes.SelectedRows[0].Cells[0].Value)
                        ) == 1)
                    {
                        MessageBox.Show("Reporte eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el reporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            mostrarReportes();
        }

        private void dgvReportes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReportes.SelectedRows.Count > 0)
            {
                cmdEliminarReporte.Enabled = true;
                cmdModificarReporte.Enabled = true;

                lblOrganizacion.Text = dgvReportes.SelectedRows[0].Cells[6].Value.ToString();
                lblDesde.Text = dgvReportes.SelectedRows[0].Cells[2].Value.ToString().Substring(0, 10);
                lblHasta.Text = dgvReportes.SelectedRows[0].Cells[3].Value.ToString().Substring(0, 10);
                lblHorasLiberadas.Text = dgvReportes.SelectedRows[0].Cells[1].Value.ToString() + " horas";
            }
            else
            {
                cmdEliminarReporte.Enabled = false;
                cmdModificarReporte.Enabled = false;

                lblOrganizacion.Text = "Sin selección";
                lblDesde.Text = "--";
                lblHasta.Text = "--";
                lblHorasLiberadas.Text = "-- horas";
            }
        }
    }
}
