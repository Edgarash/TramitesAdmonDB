using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tramites
{
    public static partial class InterfaceMySQL
    {
        public static bool HacerLogin(string Usuario, string Password)
        {
            bool Exito = false;
            EjecutarProcedimientoAlmacenado("HacerLogin", TipoConsulta.DevuelveReader,
                Parametro("Usuario", Usuario));
            if (FilasObtenidas)
            {
                if (TablaDeResultados.Rows[0]["Contraseña"].ToString() == Password)
                {
                    Exito = true;
                }
            }
            return Exito;
        }

        public static DataTable ObtenerCatalogo(string Catalogo)
        {
            DataTable Personal = null;
            EjecutarProcedimientoAlmacenado(Catalogo, TipoConsulta.DevuelveReader);
            if (FilasObtenidas) {
                Personal = TablaDeResultados;
            }
            return Personal;
        }
        public static DataTable MostrarDepartamento(int IDepto)
        {
            DataTable Departamento = null;
            EjecutarProcedimientoAlmacenado("MostrarDepartamento", TipoConsulta.DevuelveReader, Parametro("IDepto", IDepto));
            if (FilasObtenidas)
            {
                Departamento = TablaDeResultados;
            }
            return Departamento;
        }
        public static DataTable MostrarPersonal(int NumEmp)
        {
            DataTable Personal = null;
            EjecutarProcedimientoAlmacenado("MostrarPersonal", TipoConsulta.DevuelveReader,
                Parametro("NumEmp", NumEmp));
            if(FilasObtenidas)
            {
                Personal = TablaDeResultados;
            }
            return Personal;
        }
        public static DataTable MostrarNotasBuenas()
        {
            DataTable NotasBuenas = null;
            EjecutarProcedimientoAlmacenado("TodasNotasBuenas", TipoConsulta.DevuelveReader);
            if (FilasObtenidas)
            {
                NotasBuenas = TablaDeResultados;
            }
            return NotasBuenas;
        }
        public static DataTable MostrarNotasMalas()
        {
            DataTable NotasMalas = null;
            EjecutarProcedimientoAlmacenado("TodasNotasMalas", TipoConsulta.DevuelveReader);
            if (FilasObtenidas)
            {
                NotasMalas = TablaDeResultados;
            }
            return NotasMalas;
        }

        public static bool AgregarDepa(string Nombre,int Jefe)
        {
            EjecutarProcedimientoAlmacenado("AgregarDepartamento", TipoConsulta.DevuelveInt,
                Parametro("Nombre", Nombre), Parametro("Jefe", Jefe == 0 ? null : (object)Jefe));
            return OperacionRealizada;
        }
        public static bool AgregarPersonal(string RFC, string Nombre, string Ap_Paterno, string Ap_Materno, int Departamento, string Puesto, string Fecha_Ingreso)
        {
            EjecutarProcedimientoAlmacenado("AgregarPersonal", TipoConsulta.DevuelveInt,
                Parametro("RFC", RFC),
                Parametro("Nombre", Nombre),
                Parametro("APaterno", Ap_Paterno),
                Parametro("AMaterno", Ap_Materno),
                Parametro("Departamento", Departamento),
                Parametro("Puesto", Puesto),
                Parametro("FechaIngreso", Fecha_Ingreso));

            return OperacionRealizada;
        }

        public static bool ActualizarDepa(int id,string Nombre, int Jefe)
        {
            EjecutarProcedimientoAlmacenado("ActualizarDepartamento", TipoConsulta.DevuelveInt,
                Parametro("IDepto",id),
                Parametro("Nombre", Nombre), Parametro("Jefe", Jefe == 0 ? null : (object)Jefe));
            return OperacionRealizada;
        }
        public static bool ActualizarPersonal(int NumEmp, string RFC, string Nombre, string APaterno, string AMaterno, int Departamento, string Puesto, string FechaIngreso)
        {
            EjecutarProcedimientoAlmacenado("ActualizarPersonal", TipoConsulta.DevuelveInt,
                Parametro("NumEmp", NumEmp),
                Parametro("RFC",RFC),
                Parametro("Nombre", Nombre),
                Parametro("APaterno", APaterno),
                Parametro("AMaterno", AMaterno),
                Parametro("Departamento", Departamento),
                Parametro("Puesto", Puesto),
                Parametro("FechaIngreso", FechaIngreso));
            return OperacionRealizada;
        }

        public static bool EliminarDepartamento(int NumDepto)
        {
            EjecutarProcedimientoAlmacenado("EliminarDepartamento", TipoConsulta.DevuelveInt,
                Parametro("NumDepto", NumDepto));
            return OperacionRealizada;
        }
        public static bool EliminarPersonal(int NumEmp)
        {
            EjecutarProcedimientoAlmacenado("EliminarPersonal", TipoConsulta.DevuelveInt,
                Parametro("NumEmp", NumEmp));
            return OperacionRealizada;
        }

        public static bool NotaMala(int expide, int trabajador, int noOficio)
        {
            EjecutarProcedimientoAlmacenado("NotasMalas", TipoConsulta.DevuelveInt,
                Parametro("Expide", expide),
                Parametro("Trabajador", trabajador),
                Parametro("NoOficio", noOficio));
            return OperacionRealizada;
        }

        public static bool NotaBuena(int expide, int trabajador, int noOficio)
        {
            EjecutarProcedimientoAlmacenado("NotasBuenas", TipoConsulta.DevuelveInt,
                   Parametro("Expide", expide),
                   Parametro("Trabajador", trabajador),
                   Parametro("NoOficio", noOficio));
            return OperacionRealizada;
        }
    }
}
