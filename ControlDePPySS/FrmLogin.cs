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
    public partial class FrmLogin : Form
    {
        public ControladorSesion controladorSesion { get; set; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (controladorSesion == null && Vinculo_DB.probarConexion())
                {
                    controladorSesion = new ControladorSesion();

                    //MessageBox.Show(Vinculo_DB.scb.ToString());
                }

                if (controladorSesion != null)
                {
                    Usuario usuario = controladorSesion.obtenerUsuario(txtUsuario.Text, txtContrasena.Text);

                    if (usuario != null)
                    {
                        Hide();
                        controladorSesion.usuarioActivo = usuario;
                        FrmPrincipal frmPrincipal = new FrmPrincipal(this, controladorSesion);
                        frmPrincipal.Show();
                        txtContrasena.Text = "";
                        txtUsuario.Text = "";
                        txtUsuario.Select();
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o contraseña erróneos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //txtUsuario.Text = "";
                        txtContrasena.Text = "";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un host en la ventana de opciones.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmdLogin_Click(sender, null);
            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtUsuario_KeyPress(sender, e);
        }

        private void cmdOpciones_Click(object sender, EventArgs e)
        {
            (new FrmOpciones()).ShowDialog();
        }

        private void cmdAcercaDe_Click(object sender, EventArgs e)
        {
            (new FrmAcercaDe()).ShowDialog();
        }
    }
}
