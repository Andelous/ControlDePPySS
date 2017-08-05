using ControlDePPySS.DataLinq;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDePPySS.Controlador
{
    public class ControladorSesion
    {
        public Usuario usuarioActivo { get; set; }
        public ControladorAlumnos controladorAlumnos { get; set; }
        public ControladorCatalogos controladorCatalogos { get; set; }
        public ControladorSolicitudes controladorSolicitudes { get; set; }
        public ControladorCartas controladorCartas { get; set; }
        public ControladorReportes controladorReportes { get; set; }

        public ControladorSesion()
        {
            usuarioActivo = null;
            controladorAlumnos = new ControladorAlumnos();
            controladorCatalogos = new ControladorCatalogos();
            controladorSolicitudes = new ControladorSolicitudes();
            controladorCartas = new ControladorCartas();
            controladorReportes = new ControladorReportes();
        }

        public Usuario obtenerUsuario(string usuario, string contrasena)
        {
            Usuario user = null;

            try
            {
                PPSSClasses_SQLServerDataContext bd = Vinculo_DB.generarContexto();
                user = bd.Usuarios.Single(u => u.identificador == usuario && u.contrasena == contrasena);
            }
            catch (Exception)
            {
                return null;
            }

            return user;
        }
    }
}
