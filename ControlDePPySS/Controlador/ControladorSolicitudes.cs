using ControlDePPySS.DataLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDePPySS.Controlador
{
    public class ControladorSolicitudes
    {
        public static Organizacion organizacionSeleccionada { get; set;}

        static ControladorSolicitudes()
        {
            organizacionSeleccionada = null;
        }

        // INSERTS
        public int registrarSolicitud(
            string jefe_inmediato,
            string numero_de_contacto,
            string area,
            Alumno alumno,
            Organizacion organizacion,
            TipoSolicitud tipo
            )
        {
            Solicitud s = new Solicitud();

            s.jefe_inmediato = jefe_inmediato;
            s.numero_de_contacto = numero_de_contacto;
            s.area = area;
            s.matricula = alumno.matricula;
            s.organizacion_id = organizacion.organizacion_id;
            s.tipo_solicitud_id = tipo.tipo_solicitud_id;
            s.en_revision = true;

            try
            {
                PPSSClasses_SQLServerDataContext db = Vinculo_DB.generarContexto();

                db.Solicituds.InsertOnSubmit(s);
                db.SubmitChanges();
            }
            catch (Exception)
            {
                return 0;
            }

            return 1;
        }

        // UPDATES
        public int modificarSolicitud(
            string jefe_inmediato, 
            string numero_de_contacto, 
            string area, 
            bool en_revision,
            bool aceptada,
            bool rechazada,
            Organizacion organizacionSeleccionada, 
            Solicitud solicitudOriginal)
        {
            try
            {
                PPSSClasses_SQLServerDataContext db = Vinculo_DB.generarContexto();

                Solicitud solicitud  = db.Solicituds.Single(s => s.solicitud_id == solicitudOriginal.solicitud_id);

                solicitud.jefe_inmediato = jefe_inmediato;
                solicitud.numero_de_contacto = numero_de_contacto;
                solicitud.area = area;
                solicitud.en_revision = en_revision;
                solicitud.aprobada = aceptada;
                solicitud.rechazada = rechazada;
                solicitud.organizacion_id = organizacionSeleccionada.organizacion_id;

                db.SubmitChanges();
            }
            catch (Exception)
            {
                return 0;
            }

            return 1;
        }

        // GETS
        public List<Solicitud> obtenerSolicitudes(string matricula, int tipo_solicitud_id)
        {
            List<Solicitud> listaSolicitudes = null;

            try
            {
                PPSSClasses_SQLServerDataContext db = Vinculo_DB.generarContexto();
                listaSolicitudes = db.Solicituds.Where(
                    s =>
                    s.Alumno.matricula == matricula &&
                    s.TipoSolicitud.tipo_solicitud_id == tipo_solicitud_id
                ).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return listaSolicitudes;
        }

        public List<Solicitud> obtenerSolicitudesAceptadas(string matricula)
        {
            List<Solicitud> listaSolicitudes = null;

            try
            {
                PPSSClasses_SQLServerDataContext db = Vinculo_DB.generarContexto();
                listaSolicitudes = db.Solicituds.Where(
                    s =>
                    s.Alumno.matricula == matricula &&
                    s.aprobada
                ).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return listaSolicitudes;
        }

        public Solicitud obtenerSolicitud(int solicitud_id)
        {
            Solicitud s = null;

            try
            {
                PPSSClasses_SQLServerDataContext db = Vinculo_DB.generarContexto();
                s = db.Solicituds.Single(s1 => s1.solicitud_id == solicitud_id);
            }
            catch (Exception)
            {
                throw;
            }

            return s;
        }

        // DELETES

        public int eliminarSolicitud(int solicitud_id)
        {
            try
            {
                PPSSClasses_SQLServerDataContext db = Vinculo_DB.generarContexto();

                Solicitud solicitud = db.Solicituds.Single(s => s.solicitud_id == solicitud_id);

                db.Solicituds.DeleteOnSubmit(solicitud);
                db.SubmitChanges();
            }
            catch (Exception)
            {
                return 0;
            }

            return 1;
        }
    }
}
