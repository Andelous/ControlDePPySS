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
    public partial class FrmModificarReporte : Form
    {
        public ControladorSesion controladorSesion { get; set; }
        public Reporte reporte { get; set; }

        public FrmModificarReporte(ControladorSesion controladorSesion, Reporte reporte)
        {
            InitializeComponent();

            this.controladorSesion = controladorSesion;
            this.reporte = reporte;
        }

        private void FrmModificarReporte_Load(object sender, EventArgs e)
        {
            ControladorReportes.cartaAceptacionSeleccionada = reporte.Solicitud.CartaAceptacions.Single(
                c => c.solicitud_id == reporte.solicitud_id
            );

            comboMesF.SelectedIndex = reporte.fecha_fin.Month - 1;
            comboMesI.SelectedIndex = reporte.fecha_inicio.Month - 1;

            nudAnoF.Value = reporte.fecha_fin.Year;
            nudAnoI.Value = reporte.fecha_inicio.Year;

            nudDiaF.Value = reporte.fecha_fin.Day;
            nudDiaI.Value = reporte.fecha_inicio.Day;

            txtAlumno.Text = reporte.Solicitud.Alumno.ToString();
            nudHoras.Value = reporte.horas_liberadas;

            mostrarCarta();
        }

        private void mostrarCarta()
        {
            txtCarta.Text = ControladorReportes.cartaAceptacionSeleccionada == null ?
                "Ninguna" : ControladorReportes.cartaAceptacionSeleccionada.ToString();
        }

        private void cmdSeleccionarCarta_Click(object sender, EventArgs e)
        {
            (new FrmSeleccionarCarta(controladorSesion, reporte.Solicitud.Alumno)).ShowDialog();
            mostrarCarta();
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

        private void cmdActualizar_Click(object sender, EventArgs e)
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
                    modificarReporte(
                        horas_liberadas,
                        fecha_inicio,
                        fecha_final,
                        false,
                        ControladorReportes.cartaAceptacionSeleccionada,
                        reporte) == 1
                    )
                {
                    MessageBox.Show("Reporte modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                }
                else
                {
                    MessageBox.Show("Error al modificar el reporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
