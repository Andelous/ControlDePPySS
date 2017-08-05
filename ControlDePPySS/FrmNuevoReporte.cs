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
    public partial class FrmNuevoReporte : Form
    {
        public ControladorSesion controladorSesion { get; set; }
        public Alumno alumno { get; set; }

        public FrmNuevoReporte(Alumno alumno, ControladorSesion controladorSesion)
        {
            InitializeComponent();

            this.controladorSesion = controladorSesion;
            this.alumno = alumno;
        }

        private void FrmNuevoReporte_Load(object sender, EventArgs e)
        {
            ControladorReportes.cartaAceptacionSeleccionada = null;

            comboMesF.SelectedIndex = DateTime.Today.Month - 1;
            comboMesI.SelectedIndex = DateTime.Today.Month - 1;

            nudAnoF.Value = DateTime.Today.Year;
            nudAnoI.Value = DateTime.Today.Year;

            nudDiaF.Value = DateTime.Today.Day;
            nudDiaI.Value = DateTime.Today.Day;

            txtAlumno.Text = alumno.ToString();

            mostrarCarta();
        }

        private void mostrarCarta()
        {
            txtCarta.Text = ControladorReportes.cartaAceptacionSeleccionada == null ?
                "Ninguna" : ControladorReportes.cartaAceptacionSeleccionada.ToString();
        }

        private void cmdSeleccionarCarta_Click(object sender, EventArgs e)
        {
            (new FrmSeleccionarCarta(controladorSesion, alumno)).ShowDialog();
            mostrarCarta();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            if (
                ControladorReportes.cartaAceptacionSeleccionada == null
                )
            {
                MessageBox.Show("Rellene los campos correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int horas_liberadas = (int)nudHoras.Value;

                DateTime fecha_inicio = new DateTime(
                    (int)nudAnoI.Value,
                    comboMesI.SelectedIndex + 1,
                    (int)nudDiaI.Value);
                DateTime fecha_final = new DateTime(
                    (int)nudAnoF.Value,
                    comboMesF.SelectedIndex + 1,
                    (int)nudDiaF.Value
                    );

                if (
                    controladorSesion.controladorReportes.
                    registrarReporte(
                        horas_liberadas,
                        fecha_inicio,
                        fecha_final,
                        false,
                        ControladorReportes.cartaAceptacionSeleccionada) == 1
                    )
                {
                    MessageBox.Show("Reporte registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                }
                else
                {
                    MessageBox.Show("Error al registrar reporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void comboMesI_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudDiaI.Maximum = cambiarMaximoDia(comboMesI, nudAnoI);
        }

        private void comboMesF_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudDiaF.Maximum = cambiarMaximoDia(comboMesF, nudAnoF);
        }

        private int cambiarMaximoDia(ComboBox combo, NumericUpDown nud)
        {
            int max = 0;

            switch (combo.SelectedIndex + 1)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    max = 31;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    max = 30;
                    break;

                case 2:
                    max = nud.Value % 4 == 0 ? 29 : 28;
                    break;
            }

            return max;
        }

        private void nudAnoF_ValueChanged(object sender, EventArgs e)
        {
            comboMesF_SelectedIndexChanged(sender, e);
        }

        private void nudAnoI_ValueChanged(object sender, EventArgs e)
        {
            comboMesI_SelectedIndexChanged(sender, e);
        }
    }
}
