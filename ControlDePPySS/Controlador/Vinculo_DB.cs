using ControlDePPySS.DataLinq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDePPySS.Controlador
{
    public static class Vinculo_DB
    {
        public static string dataSource
        {
            get
            {
                string host = File.ReadAllText("host.sys").Trim();

                return host;
            }
        }
        public static SqlConnectionStringBuilder scb { get; set; }

        static Vinculo_DB()
        {
            scb = null;
        }

        public static void inicializarConexion()
        {
            scb = new SqlConnectionStringBuilder();

            scb.UserID = "sa";
            scb.Password = "Mexico.2017";
            scb.DataSource = dataSource + "\\SQLEXPRESS";
            scb.InitialCatalog = "PPSS";
        }

        public static PPSSClasses_SQLServerDataContext generarContexto()
        {
            PPSSClasses_SQLServerDataContext bd = null;

            try
            {
                bd = new PPSSClasses_SQLServerDataContext(
                    scb.ToString()
                );

                bd.Licenciaturas.Where(a => true);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
                MessageBox.Show("Error al conectar a la Base de Datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return bd;
        }

        public static bool probarConexion()
        {
            try
            {
                PPSSClasses_SQLServerDataContext bd = new PPSSClasses_SQLServerDataContext(
                    scb.ToString()
                );

                //object[] asdf = { "asdf", "" };
                bd.ExecuteQuery(typeof(int), "SELECT 1", "Equ");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al conectar a la base de datos. Excepción...\n" + e.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(scb.ToString());
                return false;
            }

            return true;
        }
    }
}
