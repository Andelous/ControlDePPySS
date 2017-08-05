using ControlDePPySS.DataLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDePPySS.Controlador
{
    public class ControladorCartas
    {
        public static Solicitud solicitudSeleccionada { get; set; }

        static ControladorCartas()
        {
            solicitudSeleccionada = null;
        }

        // GETS
        public List<CartaAceptacion> obtenerCartas(string matricula)
        {
            List<CartaAceptacion> listaCartas = null;

            try
            {
                PPSSClasses_SQLServerDataContext db = Vinculo_DB.generarContexto();

                listaCartas = db.CartaAceptacions.Where(
                    c => c.Solicitud.matricula == matricula
                ).ToList();

            }
            catch (Exception)
            {
                throw;
            }

            return listaCartas;
        }

        public CartaAceptacion obtenerCarta(int carta_aceptacion_id)
        {
            CartaAceptacion carta = null;

            try
            {
                PPSSClasses_SQLServerDataContext db = Vinculo_DB.generarContexto();

                carta = db.CartaAceptacions.Single(
                    c => c.carta_aceptacion_id == carta_aceptacion_id
                );
            }
            catch (Exception)
            {
                throw;
            }

            return carta;
        }

        // INSERTS
        public int registrarCarta(
            int horas_a_liberar,
            DateTime fecha_inicio,
            DateTime fecha_fin,
            bool lunes,
            bool martes,
            bool miercoles,
            bool jueves,
            bool viernes,
            bool sabado,
            bool domingo,
            string hora_entrada,
            string hora_salida,
            Solicitud solicitud
            )
        {
            CartaAceptacion carta = new CartaAceptacion();

            carta.horas_a_liberar = horas_a_liberar;
            carta.fecha_fin = fecha_fin;
            carta.fecha_inicio = fecha_inicio;
            carta.lunes = lunes;
            carta.martes = martes;
            carta.miercoles = miercoles;
            carta.jueves = jueves;
            carta.viernes = viernes;
            carta.sabado = sabado;
            carta.domingo = domingo;
            carta.hora_entrada = hora_entrada;
            carta.hora_salida = hora_salida;
            carta.solicitud_id = solicitud.solicitud_id;

            try
            {
                PPSSClasses_SQLServerDataContext db = Vinculo_DB.generarContexto();

                db.CartaAceptacions.InsertOnSubmit(carta);
                db.SubmitChanges();
            }
            catch (Exception)
            {
                return 0;
            }

            return 1;
        }

        // UPDATES
        public int modificarCarta(
            int horas_a_liberar,
            DateTime fecha_inicio,
            DateTime fecha_fin,
            bool lunes,
            bool martes,
            bool miercoles,
            bool jueves,
            bool viernes,
            bool sabado,
            bool domingo,
            string hora_entrada,
            string hora_salida,
            Solicitud solicitud,
            CartaAceptacion cartaOriginal
            )
        {
            try
            {
                PPSSClasses_SQLServerDataContext db = Vinculo_DB.generarContexto();

                CartaAceptacion carta = db.CartaAceptacions.Single(
                    c => c.carta_aceptacion_id == cartaOriginal.carta_aceptacion_id
                );

                carta.horas_a_liberar = horas_a_liberar;
                carta.fecha_fin = fecha_fin;
                carta.fecha_inicio = fecha_inicio;
                carta.lunes = lunes;
                carta.martes = martes;
                carta.miercoles = miercoles;
                carta.jueves = jueves;
                carta.viernes = viernes;
                carta.sabado = sabado;
                carta.domingo = domingo;
                carta.hora_entrada = hora_entrada;
                carta.hora_salida = hora_salida;
                carta.solicitud_id = solicitud.solicitud_id;

                db.SubmitChanges();
            }
            catch (Exception)
            {
                return 0;
            }

            return 1;
        }

        // DELETES
        public int eliminarCarta(int carta_aceptacion_id)
        {
            try
            {
                PPSSClasses_SQLServerDataContext db = Vinculo_DB.generarContexto();

                CartaAceptacion carta = db.CartaAceptacions.Single(
                    c => c.carta_aceptacion_id == carta_aceptacion_id
                );

                db.CartaAceptacions.DeleteOnSubmit(carta);
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
