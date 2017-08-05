using ControlDePPySS.DataLinq;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDePPySS.Controlador
{
    public class ControladorAlumnos
    {

        public List<Alumno> obtenerAlumnosNombre(string coincidenciaNombre)
        {
            List<Alumno> listaAlumnos = null;

            try
            {
                PPSSClasses_SQLServerDataContext bd = Vinculo_DB.generarContexto();
                Table<Alumno> alumnos = bd.GetTable<Alumno>();

                listaAlumnos = alumnos.
                    Where(
                        a =>
                        (a.nombres + " " +
                        a.apellido_paterno + " " +
                        a.apellido_materno).
                        Contains(coincidenciaNombre)
                    ).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return listaAlumnos;
        }

        public List<Alumno> obtenerAlumnosMatricula(string coincidenciaMatricula)
        {
            List<Alumno> listaAlumnos = null;

            try
            {
                PPSSClasses_SQLServerDataContext bd = Vinculo_DB.generarContexto();
                Table<Alumno> alumnos = bd.GetTable<Alumno>();

                listaAlumnos = alumnos.
                    Where(a => a.matricula.Contains(coincidenciaMatricula)).
                    ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return listaAlumnos;
        }

        public Alumno obtenerAlumno(string matricula)
        {
            Alumno alumno = null;

            try
            {
                PPSSClasses_SQLServerDataContext bd = Vinculo_DB.generarContexto();
                Table<Alumno> alumnos = bd.GetTable<Alumno>();

                alumno = alumnos.Single(a => a.matricula == matricula);
            }
            catch (Exception)
            {
                throw;
            }

            return alumno;
        }

        public int registrarAlumno(
            string matricula,
            string nombres,
            string apellido_paterno,
            string apellido_materno,
            int ano_ingreso,
            Licenciatura licenciatura
            )
        {
            Alumno alumno = new Alumno();

            alumno.ano_ingreso = ano_ingreso;
            alumno.apellido_materno = apellido_materno;
            alumno.apellido_paterno = apellido_paterno;
            alumno.licenciatura_id = licenciatura.licenciatura_id;
            alumno.matricula = matricula;
            alumno.nombres = nombres;

            try
            {
                PPSSClasses_SQLServerDataContext bd = Vinculo_DB.generarContexto();

                Table<Alumno> alumnos = bd.GetTable<Alumno>();
                alumnos.InsertOnSubmit(alumno);

                bd.SubmitChanges();
            }
            catch (Exception)
            {
                return 0;
            }

            return 1;
        }

        public int modificarAlumno(
            string nombres,
            string apellido_paterno,
            string apellido_materno,
            int ano_ingreso,
            Licenciatura licenciatura,
            Alumno alumnoOriginal
            )
        {
            try
            {
                PPSSClasses_SQLServerDataContext bd = Vinculo_DB.generarContexto();

                Table<Alumno> alumnos = bd.GetTable<Alumno>();
                Alumno alumno = alumnos.Single(a1 => a1.matricula == alumnoOriginal.matricula);

                alumno.ano_ingreso = ano_ingreso;
                alumno.apellido_materno = apellido_materno;
                alumno.apellido_paterno = apellido_paterno;
                alumno.licenciatura_id = licenciatura.licenciatura_id;
                alumno.nombres = nombres;

                bd.SubmitChanges();
            }
            catch (Exception)
            {
                return 0;
            }

            return 1;
        }

        public int eliminarAlumno(string matricula)
        {
            try
            {
                PPSSClasses_SQLServerDataContext bd = Vinculo_DB.generarContexto();
                Table<Alumno> alumnos = bd.GetTable<Alumno>();

                Alumno alumno = alumnos.Single(a => a.matricula == matricula);

                alumnos.DeleteOnSubmit(alumno);
                bd.SubmitChanges();
            }
            catch (Exception)
            {
                return 0;
            }

            return 1;
        }

        public string calcularSemestreActual(int ano_ingreso)
        {
            int semestres = (DateTime.Today.Year - ano_ingreso) * 2;
            string sufijo = "";

            if (DateTime.Today.Month >= 7)
            {
                semestres++;
            }

            switch (semestres)
            {
                case 1:
                case 3:
                    sufijo = "er";
                    break;
                default:
                    sufijo = "°";
                    break;
            }

            return semestres.ToString() + sufijo;
        }

    }
}
