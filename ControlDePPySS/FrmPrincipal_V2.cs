using ControlDePPySS.Controlador;
using ControlDePPySS.DataLinq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDePPySS
{
    public partial class FrmPrincipal_V2 : Form
    {
        public FrmLogin frmLogin { get; set; }
        public ControladorSesion controladorSesion { get; set; }

        public FrmPrincipal_V2(FrmLogin frmLogin, ControladorSesion controladorSesion)
        {
            InitializeComponent();

            this.frmLogin = frmLogin;
            this.controladorSesion = controladorSesion;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = controladorSesion.usuarioActivo.identificador;

            configurarDGVAlumnos();
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin.Show();
            controladorSesion.usuarioActivo = null;
        }

        private void cmdCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
            FrmPrincipal_FormClosed(sender, null);
        }

        private void cmdBuscarAlumnos_Click(object sender, EventArgs e)
        {
            if(Regex.IsMatch(txtBuscarAlumnos.Text, @"^\d+$"))
            {
                configurarDGVAlumnos(controladorSesion.controladorAlumnos.obtenerAlumnosMatricula(txtBuscarAlumnos.Text));
            }
            else
            {
                configurarDGVAlumnos(controladorSesion.controladorAlumnos.obtenerAlumnosNombre(txtBuscarAlumnos.Text));
            }
        }

        private void cmdNuevoAlumno_Click(object sender, EventArgs e)
        {
            (new FrmNuevoAlumno(controladorSesion)).ShowDialog();
            cmdActualizar_Click(sender, e);
        }

        private void cmdModificarAlumno_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                (new FrmModificarAlumno(
                    controladorSesion.controladorAlumnos.obtenerAlumno(
                        dgvAlumnos.SelectedRows[0].Cells["matricula"].Value.ToString()
                    ),
                    controladorSesion
                )).ShowDialog();
                cmdActualizar_Click(sender, e);
            }
        }

        private void configurarDGVAlumnos()
        {
            configurarDGVAlumnos(controladorSesion.controladorAlumnos.obtenerAlumnosNombre(""));
        }

        private void configurarDGVAlumnos(List<Alumno> lista)
        {
            dgvAlumnos.DataSource = lista;

            dgvAlumnos.Columns[0].HeaderText = "Matrícula";
            dgvAlumnos.Columns[1].HeaderText = "Nombre";
            dgvAlumnos.Columns[2].HeaderText = "Apellido paterno";
            dgvAlumnos.Columns[3].HeaderText = "Apellido materno";
            dgvAlumnos.Columns[4].HeaderText = "Año de ingreso";
            dgvAlumnos.Columns[5].Visible = false;
            //dgvAlumnos.Columns[6].HeaderText = "Licenciatura";
        }

        private void dgvAlumnos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                cmdModificarAlumno.Enabled = true;
                cmdEliminarAlumno.Enabled = true;

                cmdSolicitudes.Enabled = true;
                cmdReportes.Enabled = true;
                cmdCartaAceptacion.Enabled = true;
                cmdEntrega.Enabled = false;

                lblAlumno.Text =
                    dgvAlumnos.SelectedRows[0].Cells["nombres"].Value.ToString() + " " +
                    dgvAlumnos.SelectedRows[0].Cells["apellido_paterno"].Value.ToString() + " " +
                    dgvAlumnos.SelectedRows[0].Cells["apellido_materno"].Value.ToString();

                lblMatricula.Text = 
                    dgvAlumnos.SelectedRows[0].Cells["matricula"].Value.ToString() +
                    " - " +
                    dgvAlumnos.SelectedRows[0].Cells["Licenciatura"].Value.ToString();
            }
            else
            {
                lblAlumno.Text = "Sin selección";
                lblMatricula.Text = "Sin datos";

                cmdModificarAlumno.Enabled = false;
                cmdEliminarAlumno.Enabled = false;

                cmdSolicitudes.Enabled = false;
                cmdReportes.Enabled = false;
                cmdCartaAceptacion.Enabled = false;
                cmdEntrega.Enabled = false;
            }
        }

        private void txtBuscarAlumnos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmdBuscarAlumnos_Click(sender, null);
            }
        }

        private void FrmPrincipal_Resize(object sender, EventArgs e)
        {
            panelAlumnos.Width = Width - 280;
            panelAlumnos.Height = Height - 35;

            dgvAlumnos.Width = panelAlumnos.Width - 22;
            dgvAlumnos.Height = panelAlumnos.Height - 133;

            Point pCmdA0 = new Point(cmdNuevoAlumno.Location.X, panelAlumnos.Height - 40);
            Point pCmdA1 = new Point(cmdModificarAlumno.Location.X, panelAlumnos.Height - 40);
            Point pCmdA2 = new Point(cmdEliminarAlumno.Location.X, panelAlumnos.Height - 40);
            cmdNuevoAlumno.Location = pCmdA0;
            cmdModificarAlumno.Location = pCmdA1;
            cmdEliminarAlumno.Location = pCmdA2;

            Point pPict = new Point(panelAlumnos.Width - 65, pctLaSalle.Location.Y);
            pctLaSalle.Location = pPict;

            gbOpciones.Height = Height - 63;
            Point pGrou = new Point(Width - 273, gbOpciones.Location.Y);
            gbOpciones.Location = pGrou;

            Point pPan2 = new Point(panelUsuario.Location.X, gbOpciones.Height - 116);
            Point pCmdC = new Point(cmdCerrarSesion.Location.X, gbOpciones.Height - 45);
            panelUsuario.Location = pPan2;
            cmdCerrarSesion.Location = pCmdC;
        }

        private void cmdEliminarAlumno_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(
                "¿Está seguro que desea eliminar al alumno seleccionado?\n" +
                "Una vez eliminado, no se podrán recuperar sus datos,\n" +
                "incluyendo solicitudes, reportes, cartas de aceptación, etc.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes
                )
            {
                if (
                    MessageBox.Show(
                    "Se procederá a eliminar los datos\n" +
                    "¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes
                    )
                {
                    if (controladorSesion.controladorAlumnos.eliminarAlumno(
                        dgvAlumnos.SelectedRows[0].Cells["matricula"].Value.ToString()
                        ) == 1)
                    {
                        MessageBox.Show("Alumno eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar al alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            cmdActualizar_Click(sender, e);
        }

        private void cmdActualizar_Click(object sender, EventArgs e)
        {
            txtBuscarAlumnos.Text = "";
            configurarDGVAlumnos();
        }

        private void cmdSolicitudes_Click(object sender, EventArgs e)
        {
            (new FrmSolicitudes(controladorSesion.controladorAlumnos.obtenerAlumno(
                dgvAlumnos.SelectedRows[0].Cells["matricula"].Value.ToString()
                ), controladorSesion)).ShowDialog();
        }

        private void cmdOrganizaciones_Click(object sender, EventArgs e)
        {
            (new FrmOrganizaciones(controladorSesion)).ShowDialog();
        }

        private void cmdCartaAceptacion_Click(object sender, EventArgs e)
        {
            (new FrmCartasAceptacion(controladorSesion.controladorAlumnos.obtenerAlumno(
                dgvAlumnos.SelectedRows[0].Cells["matricula"].Value.ToString()
                ), controladorSesion)).ShowDialog();
        }

        private void cmdReportes_Click(object sender, EventArgs e)
        {
            (new FrmReportes(controladorSesion.controladorAlumnos.obtenerAlumno(
                dgvAlumnos.SelectedRows[0].Cells["matricula"].Value.ToString()
                ), controladorSesion)).ShowDialog();
        }
    }
}
