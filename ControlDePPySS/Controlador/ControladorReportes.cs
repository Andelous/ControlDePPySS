using ControlDePPySS.DataLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDePPySS.Controlador
{
    public class ControladorReportes
    {
        public static CartaAceptacion cartaAceptacionSeleccionada { get; set; }

        static ControladorReportes()
        {
            cartaAceptacionSeleccionada = null;
        }

        // GETS
        public List<Reporte>  obtenerReportes(string matricula)
        {
            List<Reporte> listaReportes = null;

            try
            {
                PPSSClasses_SQLServerDataContext db = Vinculo_DB.generarContexto();

                listaReportes = db.Reportes.Where(
                    r => r.Solicitud.Alumno.matricula == matricula
                ).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return listaReportes;
        }

        public Reporte obtenerReporte(int reporte_id)
        {
            Reporte reporte = null;

            try
            {
                PPSSClasses_SQLServerDataContext db = Vinculo_DB.generarContexto();

                reporte = db.Reportes.Single(
                    r => r.reporte_id == reporte_id
                    );
            }
            catch (Exception)
            {
                throw;
            }

            return reporte;
        }

        // INSERTS
        public int registrarReporte(
            int horas_liberadas,
            DateTime fecha_inicio,
            DateTime fecha_fin,
            bool firma_coordinador,
            CartaAceptacion carta
            )
        {
            Reporte reporte = new Reporte();

            reporte.horas_liberadas = horas_liberadas;
            reporte.fecha_inicio = fecha_inicio;
            reporte.fecha_fin = fecha_fin;
            reporte.firma_coordinador = firma_coordinador;
            reporte.solicitud_id = carta.Solicitud.solicitud_id;

            try
            {
                PPSSClasses_SQLServerDataContext db = Vinculo_DB.generarContexto();

                db.Reportes.InsertOnSubmit(reporte);
                db.SubmitChanges();
            }
            catch (Exception)
            {
                return 0;
            }

            return 1;
        }

        // DELETES
        public int eliminarReporte(int reporte_id)
        {
            try
            {
                PPSSClasses_SQLServerDataContext db = Vinculo_DB.generarContexto();

                Reporte reporte = db.Reportes.Single(
                    r => r.reporte_id == reporte_id
                );

                db.Reportes.DeleteOnSubmit(reporte);
                db.SubmitChanges();
            }
            catch (Exception)
            {
                return 0;
            }

            return 1;
        }

        // UPDATES
        public int modificarReporte(
            int horas_liberadas,
            DateTime fecha_inicio,
            DateTime fecha_fin,
            bool firma_coordinador,
            CartaAceptacion carta,
            Reporte reporteOriginal
            )
        {
            try
            {
                PPSSClasses_SQLServerDataContext db = Vinculo_DB.generarContexto();

                Reporte reporte = db.Reportes.Single(
                    r => r.reporte_id == reporteOriginal.reporte_id
                );

                reporte.horas_liberadas = horas_liberadas;
                reporte.fecha_inicio = fecha_inicio;
                reporte.fecha_fin = fecha_fin;
                reporte.firma_coordinador = firma_coordinador;
                reporte.solicitud_id = carta.Solicitud.solicitud_id;

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
