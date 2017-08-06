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
    public partial class FrmModificarOrganizacion : Form
    {
        public Organizacion organizacion { get; set; }
        public ControladorSesion controladorSesion { get; set; }

        public FrmModificarOrganizacion(Organizacion organizacion, ControladorSesion controladorSesion)
        {
            InitializeComponent();

            this.organizacion = organizacion;
            this.controladorSesion = controladorSesion;
        }

        private void FrmModificarOrganizacion_Load(object sender, EventArgs e)
        {
            txtNombre.Text = organizacion.nombre;
            txtDireccion.Text = organizacion.direccion;
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if (
                txtNombre.Text == "" ||
                txtDireccion.Text == ""
                )
            {
                MessageBox.Show("Rellene los campos correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (
                    controladorSesion.
                    controladorCatalogos.
                    modificarOrganizacion(
                        txtNombre.Text, 
                        txtDireccion.Text, 
                        organizacion
                        ) == 1
                    )
                {
                    MessageBox.Show("Organización modificada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Error al modificar organización.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
