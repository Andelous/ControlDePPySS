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
    public partial class FrmSeleccionarOrganizacion : Form
    {
        public ControladorSesion controladorSesion { get; set; }

        public FrmSeleccionarOrganizacion(ControladorSesion controlador)
        {
            InitializeComponent();

            controladorSesion = controlador;
        }

        private void FrmSeleccionarOrganizacion_Load(object sender, EventArgs e)
        {
            mostrarOrganizaciones();
        }

        private void mostrarOrganizaciones()
        {
            mostrarOrganizaciones(controladorSesion.controladorCatalogos.obtenerOrganizaciones());
        }
        
        private void mostrarOrganizaciones(List<Organizacion> lista)
        {
            dgvOrganizaciones.DataSource = lista;

            dgvOrganizaciones.Columns[0].Visible = false;
            dgvOrganizaciones.Columns[1].HeaderText = "Nombre";
            dgvOrganizaciones.Columns[2].HeaderText = "Dirección";
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            mostrarOrganizaciones(controladorSesion.controladorCatalogos.obtenerOrganizaciones(txtNombre.Text));
        }

        private void dgvOrganizaciones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrganizaciones.SelectedRows.Count > 0)
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
            ControladorSolicitudes.organizacionSeleccionada = controladorSesion.
                controladorCatalogos.
                obtenerOrganizacion(
                    Convert.ToInt32(dgvOrganizaciones.SelectedRows[0].Cells[0].Value)
                );

            Hide();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmdBuscar_Click(sender, e);
            }
        }

        private void cmdNuevaOrganizacion_Click(object sender, EventArgs e)
        {
            (new FrmNuevaOrganizacion(controladorSesion)).ShowDialog();
            mostrarOrganizaciones();
        }
    }
}
