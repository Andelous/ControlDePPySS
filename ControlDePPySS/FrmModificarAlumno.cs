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
    public partial class FrmModificarAlumno : Form
    {
        public ControladorSesion controladorSesion { get; set; }
        public Alumno alumno { get; set; }

        public FrmModificarAlumno(Alumno alumno, ControladorSesion controladorSesion)
        {
            InitializeComponent();

            this.alumno = alumno;
            this.controladorSesion = controladorSesion;
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if (
                txtApe_Mat.Text == "" ||
                txtApe_Pat.Text == "" ||
                txtNombres.Text == "")
            {
                MessageBox.Show("Rellene los campos correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (controladorSesion.controladorAlumnos.modificarAlumno(
                    txtNombres.Text,
                    txtApe_Pat.Text,
                    txtApe_Mat.Text,
                    (int)nudAno_Ingreso.Value,
                    (Licenciatura)comboLicenciatura.SelectedItem,
                    alumno
                ) == 1)
                {
                    MessageBox.Show("Alumno modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                }
                else
                {
                    MessageBox.Show("Error al modificar alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmModificarAlumno_Load(object sender, EventArgs e)
        {
            comboLicenciatura.DataSource = controladorSesion.controladorCatalogos.obtenerLicenciaturas();
            nudAno_Ingreso.Maximum = DateTime.Today.Year;

            txtMatricula.Text = alumno.matricula;
            txtNombres.Text = alumno.nombres;
            txtApe_Pat.Text = alumno.apellido_paterno;
            txtApe_Mat.Text = alumno.apellido_materno;

            nudAno_Ingreso.Value = alumno.ano_ingreso;

            comboLicenciatura.SelectedItem = alumno.Licenciatura;
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
