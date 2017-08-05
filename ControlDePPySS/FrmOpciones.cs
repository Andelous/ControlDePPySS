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
            string host = "";

            if (File.Exists("host.sys"))
            {
                host = File.ReadAllText("host.sys").Trim();
            }
            else
            {
                host = "No se ha determinado aún";
            }

            txtHost.Text = host;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            string[] host = { txtHost.Text.Trim() };

            File.WriteAllLines("host.sys", host);

            MessageBox.Show("Guardado");
            Hide();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
