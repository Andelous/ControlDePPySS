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
    public partial class FrmNuevaOrganizacion : Form
    {
        public ControladorSesion controladorSesion { get; set; }

        public FrmNuevaOrganizacion(ControladorSesion controladorSesion)
        {
            InitializeComponent();

            this.controladorSesion = controladorSesion;
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void FrmNuevaOrganizacion_Load(object sender, EventArgs e)
        {

        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "" || txtNombre.Text == "")
            {
                MessageBox.Show("Rellene los campos correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (controladorSesion.
                    controladorCatalogos.
                    registrarOrganizacion(txtNombre.Text, txtDireccion.Text)
                    ==
                    1)
                {
                    MessageBox.Show("Organización registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                }
                else
                {
                    MessageBox.Show("Error al registrar organización.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
