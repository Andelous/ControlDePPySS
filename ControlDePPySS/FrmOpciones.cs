using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDePPySS
{
    public partial class FrmOpciones : Form
    {
        public FrmOpciones()
        {
            InitializeComponent();
        }

        private void FrmOpciones_Load(object sender, EventArgs e)
        {
            string[] datos = new string[4];

            if (File.Exists("host.sys"))
            {
                datos = File.ReadAllLines("host.sys");
            }
            else
            {
                datos = new string[] { "Sin especificar", "Sin especificar", "Sin especificar", "Sin especificar" };
            }

            try
            {
                txtUsuario.Text = datos[0];
            }
            catch (Exception)
            {
                txtUsuario.Text = "Sin especificar";
            }

            //try
            //{
            //    txtContrasena.Text = datos[1];
            //}
            //catch (Exception)
            //{
            //    txtContrasena.Text = "Sin especificar";
            //}

            try
            { 
                txtHost.Text = datos[2];
            }
            catch (Exception)
            {
                txtHost.Text = "Sin especificar";
            }

            try
            {
                txtCatalogo.Text = datos[3];
            }
            catch (Exception)
            {
                txtCatalogo.Text = "Sin especificar";
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            string[] host = { txtUsuario.Text.Trim(), txtContrasena.Text.Trim(), txtHost.Text.Trim(), txtCatalogo.Text.Trim() };

            File.WriteAllLines("host.sys", host);

            MessageBox.Show("Guardado");
            Close();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
