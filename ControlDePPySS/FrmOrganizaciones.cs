using ControlDePPySS.Controlador;
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
    public partial class FrmOrganizaciones : Form
    {
        public ControladorSesion controladorSesion { get; set; }

        public FrmOrganizaciones(ControladorSesion controladorSesion)
        {
            InitializeComponent();

            this.controladorSesion = controladorSesion;
        }

        private void cmdNuevaOrganizacion_Click(object sender, EventArgs e)
        {
            (new FrmNuevaOrganizacion(controladorSesion)).ShowDialog();
            mostrarOrganizaciones();
        }

        private void dgvOrganizaciones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrganizaciones.SelectedRows.Count > 0)
            {
                cmdModificarOrganizacion.Enabled = true;
                cmdEliminarOrganizacion.Enabled = true;
            }
            else
            {
                cmdModificarOrganizacion.Enabled = false;
                cmdEliminarOrganizacion.Enabled = false;
            }
        }

        private void FrmOrganizaciones_Load(object sender, EventArgs e)
        {
            mostrarOrganizaciones();
        }

        private void mostrarOrganizaciones()
        {
            dgvOrganizaciones.DataSource = controladorSesion.controladorCatalogos.obtenerOrganizaciones();

            dgvOrganizaciones.Columns[0].Visible = false;
            dgvOrganizaciones.Columns[1].HeaderText = "Nombre";
            dgvOrganizaciones.Columns[2].HeaderText = "Dirección";
        }

        private void cmdModificarOrganizacion_Click(object sender, EventArgs e)
        {
            (new FrmModificarOrganizacion(
                controladorSesion.controladorCatalogos.obtenerOrganizacion(
                    Convert.ToInt32(dgvOrganizaciones.SelectedRows[0].Cells["organizacion_id"].Value)),
                    controladorSesion
                )).ShowDialog();

            mostrarOrganizaciones();
        }

        private void cmdEliminarOrganizacion_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(
                "¿Está seguro que desea eliminar la organización seleccionada?\n" +
                "Una vez eliminada, no se podrán recuperar sus datos.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes
            )
            {
                if (
                    MessageBox.Show(
                    "Se procederá a eliminar los datos\n" +
                    "¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes
                    )
                {
                    if (controladorSesion.controladorCatalogos.eliminarOrganizacion(
                        Convert.ToInt32(dgvOrganizaciones.SelectedRows[0].Cells["organizacion_id"].Value)
                        ) == 1)
                    {
                        MessageBox.Show("Organización eliminada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la organización.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            mostrarOrganizaciones();
        }
    }
}
