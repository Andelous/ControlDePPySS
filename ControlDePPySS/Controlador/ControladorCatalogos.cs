using ControlDePPySS.DataLinq;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDePPySS.Controlador
{
    public class ControladorCatalogos
    {
        // INSERTS
        public int registrarOrganizacion(string nombre, string direccion)
        {
            Organizacion organizacion = new Organizacion();

            organizacion.direccion = direccion;
            organizacion.nombre = nombre;

            try
            {
                PPSSClasses_SQLServerDataContext db = Vinculo_DB.generarContexto();

                db.Organizacions.InsertOnSubmit(organizacion);
                db.SubmitChanges();
            }
            catch (Exception)
            {
                return 0;
            }

            return 1;
        }

        // UPDATES
        public int modificarOrganizacion(
            string nombre,
            string direccion,
            Organizacion organizacionOriginal
            )
        {
            try
            {
                PPSSClasses_SQLServerDataContext db = Vinculo_DB.generarContexto();

                Organizacion organizacion = db.Organizacions.Single(o => o.organizacion_id == organizacionOriginal.organizacion_id);
                organizacion.nombre = nombre;
                organizacion.direccion = direccion;

                db.SubmitChanges();
            }
            catch (Exception)
            {
                return 0;
            }

            return 1;
        }
        


        // GETS
        public List<Licenciatura> obtenerLicenciaturas()
        {
            List<Licenciatura> listaLicenciaturas = null;

            try
            {
                PPSSClasses_SQLServerDataContext bd = Vinculo_DB.generarContexto();
                Table<Licenciatura> licenciaturas = bd.GetTable<Licenciatura>();

                listaLicenciaturas = licenciaturas.ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return listaLicenciaturas;
        }

        public List<TipoSolicitud> obtenerTiposSolicitud()
        {
            List<TipoSolicitud> listaTipos = null;

            try
            {
                PPSSClasses_SQLServerDataContext bd = Vinculo_DB.generarContexto();
                Table<TipoSolicitud> tipos = bd.GetTable<TipoSolicitud>();

                listaTipos = tipos.ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return listaTipos;
        }

        public List<Organizacion> obtenerOrganizaciones()
        {
            return obtenerOrganizaciones("");
        }

        public List<Organizacion> obtenerOrganizaciones(string nombre)
        {
            List<Organizacion> listaOrganizaciones = null;

            try
            {
                PPSSClasses_SQLServerDataContext bd = Vinculo_DB.generarContexto();
                Table<Organizacion> organizaciones = bd.GetTable<Organizacion>();

                listaOrganizaciones = organizaciones.
                    Where(o => o.nombre.Contains(nombre)).
                    ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return listaOrganizaciones;
        }

        public Organizacion obtenerOrganizacion(int organizacion_id)
        {
            Organizacion o = null;

            try
            {
                PPSSClasses_SQLServerDataContext db = Vinculo_DB.generarContexto();

                o = db.Organizacions.Single(o1 => o1.organizacion_id == organizacion_id);
            }
            catch (Exception)
            {
                throw;
            }

            return o;
        }

        // DELETES

        public int eliminarOrganizacion(int organizacion_id)
        {
            try
            {
                PPSSClasses_SQLServerDataContext bd = Vinculo_DB.generarContexto();

                Organizacion organizacion = bd.Organizacions.Single(o => o.organizacion_id == organizacion_id);

                bd.Organizacions.DeleteOnSubmit(organizacion);
                bd.SubmitChanges();
            }
            catch (Exception)
            {
                return 0;
            }

            return 1;
        }
    }
}
