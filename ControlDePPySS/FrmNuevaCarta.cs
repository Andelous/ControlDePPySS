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
    public partial class FrmNuevaCarta : Form
    {
        public ControladorSesion controladorSesion { get; set; }
        public Alumno alumno { get; set; }

        public FrmNuevaCarta(Alumno alumno, ControladorSesion controladorSesion)
        {
            InitializeComponent();

            this.controladorSesion = controladorSesion;
            this.alumno = alumno;
        }

        private void FrmNuevaCarta_Load(object sender, EventArgs e)
        {
            ControladorCartas.solicitudSeleccionada = null;

            comboMesF.SelectedIndex = DateTime.Today.Month - 1;
            comboMesI.SelectedIndex = DateTime.Today.Month - 1;

            nudAnoF.Value = DateTime.Today.Year;
            nudAnoI.Value = DateTime.Today.Year;

            nudDiaF.Value = DateTime.Today.Day;
            nudDiaI.Value = DateTime.Today.Day;

            txtAlumno.Text = alumno.ToString();

            mostrarSolicitud();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
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

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            if (
                txtHoraI.Text == "" ||
                txtHoraF.Text == "" ||
                txtMinutoI.Text == "" ||
                txtMinutoF.Text == "" ||
                ControladorCartas.solicitudSeleccionada == null
                )
            {
                MessageBox.Show("Rellene los campos correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int horas_a_liberar = (int)nudHoras.Value;

                DateTime fecha_inicio = new DateTime(
                    (int)nudAnoI.Value,
                    comboMesI.SelectedIndex + 1,
                    (int)nudDiaI.Value);
                DateTime fecha_final = new DateTime(
                    (int)nudAnoF.Value,
                    comboMesF.SelectedIndex + 1,
                    (int)nudDiaF.Value
                    );

                bool lunes = chkLunes.Checked;
                bool martes = chkMartes.Checked;
                bool miercoles = chkMiercoles.Checked;
                bool jueves = chkJueves.Checked;
                bool viernes = chkViernes.Checked;
                bool sabado = chkSabado.Checked;
                bool domingo = chkDomingo.Checked;

                string hora_entrada = txtHoraI.Text + ":" + txtMinutoI.Text;
                string hora_salida = txtHoraF.Text + ":" + txtMinutoF.Text;

                if (
                    controladorSesion.controladorCartas.
                    registrarCarta(
                        horas_a_liberar, 
                        fecha_inicio, 
                        fecha_final, 
                        lunes,
                        martes,
                        miercoles,
                        jueves,
                        viernes,
                        sabado,
                        domingo,
                        hora_entrada,
                        hora_salida,
                        ControladorCartas.solicitudSeleccionada) == 1
                    )
                {
                    MessageBox.Show("Carta de aceptación registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Error al registrar carta de aceptación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmdSeleccionarSolicitud_Click(object sender, EventArgs e)
        {
            (new FrmSeleccionarSolicitud(controladorSesion, alumno)).ShowDialog();
            mostrarSolicitud();
        }

        private void mostrarSolicitud()
        {
            txtSolicitud.Text = ControladorCartas.solicitudSeleccionada == null ?
                "Ninguna" : ControladorCartas.solicitudSeleccionada.ToString();
        }
    }
}
