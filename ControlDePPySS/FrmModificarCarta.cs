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
    public partial class FrmModificarCarta : Form
    {
        public ControladorSesion controladorSesion { get; set; }
        public CartaAceptacion carta { get; set; }

        public FrmModificarCarta(ControladorSesion controladorSesion, CartaAceptacion carta)
        {
            InitializeComponent();

            this.controladorSesion = controladorSesion;
            this.carta = carta;
        }

        private void FrmModificarCarta_Load(object sender, EventArgs e)
        {
            ControladorCartas.solicitudSeleccionada = carta.Solicitud;

            comboMesF.SelectedIndex = carta.fecha_fin.Month - 1;
            comboMesI.SelectedIndex = carta.fecha_inicio.Month - 1;

            nudAnoF.Value = carta.fecha_fin.Year;
            nudAnoI.Value = carta.fecha_inicio.Year;

            nudDiaF.Value = carta.fecha_fin.Day;
            nudDiaI.Value = carta.fecha_inicio.Day;

            txtAlumno.Text = carta.Solicitud.Alumno.ToString();

            txtHoraI.Text = carta.hora_entrada.Substring(0, 2);
            txtMinutoI.Text = carta.hora_entrada.Substring(3, 2);

            txtHoraF.Text = carta.hora_salida.Substring(0, 2);
            txtMinutoF.Text = carta.hora_salida.Substring(3, 2);

            nudHoras.Value = carta.horas_a_liberar;

            chkLunes.Checked = carta.lunes;
            chkMartes.Checked = carta.martes;
            chkMiercoles.Checked = carta.miercoles;
            chkJueves.Checked = carta.jueves;
            chkViernes.Checked = carta.viernes;
            chkSabado.Checked = carta.sabado;
            chkDomingo.Checked = carta.domingo;

            mostrarSolicitud();
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

        private void mostrarSolicitud()
        {
            txtSolicitud.Text = ControladorCartas.solicitudSeleccionada == null ?
                "Ninguna" : ControladorCartas.solicitudSeleccionada.ToString();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void cmdSeleccionarSolicitud_Click(object sender, EventArgs e)
        {
            (new FrmSeleccionarSolicitud(controladorSesion, carta.Solicitud.Alumno)).ShowDialog();
            mostrarSolicitud();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
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
                    modificarCarta(
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
                        ControladorCartas.solicitudSeleccionada,
                        carta) == 1
                    )
                {
                    MessageBox.Show("Carta de aceptación modificada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                }
                else
                {
                    MessageBox.Show("Error al modificar carta de aceptación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
