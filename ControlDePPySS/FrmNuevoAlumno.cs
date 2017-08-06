using ControlDePPySS.Controlador;
using ControlDePPySS.DataLinq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDePPySS
{
    public partial class FrmNuevoAlumno : Form
    {
        public ControladorSesion controladorSesion { get; set; }

        public FrmNuevoAlumno(ControladorSesion controladorSesion)
        {
            InitializeComponent();
            this.controladorSesion = controladorSesion;
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            if(
                txtApe_Mat.Text == "" ||
                txtApe_Pat.Text == "" ||
                txtNombres.Text == "" ||
                txtMatricula.Text.Length != 9 ||
                !Regex.IsMatch(txtMatricula.Text, @"^\d+$"))
            {
                MessageBox.Show("Rellene los campos correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (controladorSesion.controladorAlumnos.registrarAlumno(
                    txtMatricula.Text,
                    txtNombres.Text,
                    txtApe_Pat.Text,
                    txtApe_Mat.Text,
                    (int)nudAno_Ingreso.Value,
                    (Licenciatura)comboLicenciatura.SelectedItem
                ) == 1)
                {
                    MessageBox.Show("Alumno registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Error al registrar alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmNuevoAlumno_Load(object sender, EventArgs e)
        {
            comboLicenciatura.DataSource = controladorSesion.controladorCatalogos.obtenerLicenciaturas();
            nudAno_Ingreso.Maximum = DateTime.Today.Year;
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
