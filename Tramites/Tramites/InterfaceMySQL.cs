using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tramites
{
    public static partial class InterfaceMySQL
    {
        static string Server { get { return "Localhost"; } }
        static uint Port { get { return 3306; } }
        static string DataBase { get { return "tramites"; } }
        static string Usuario
        {
            get {
                return "root";
            }
        }
        static string Password
        {
            get {
                //return "";
                return "300896mabe";
            }
        }

        enum TipoConsulta { DevuelveInt, DevuelveReader };
        static bool ConexionAbierta { get; set; }
        static int RegistrosAfectados { get; set; }
        static bool OperacionRealizada { get { return RegistrosAfectados > 0; } }
        static bool FilasObtenidas { get { return TablaDeResultados.Rows.Count > 0; } }
        static MySqlConnection Conexion { get; set; }
        static MySqlCommand Comando { get; set; }
        static MySqlDataReader Lector { get; set; }
        static DataTable TablaDeResultados { get; set; }

        public static void InicializarConexion()
        {
            MySqlConnectionStringBuilder CadenaConexion = new MySqlConnectionStringBuilder();
            CadenaConexion.Port = Port;
            CadenaConexion.UserID = Usuario;
            CadenaConexion.Database = DataBase;
            CadenaConexion.Server = Server;
            CadenaConexion.Password = Password;
            CadenaConexion.SslMode = MySqlSslMode.None;
            Conexion = new MySqlConnection(CadenaConexion.ConnectionString);
        }

        static bool EjecutarConsulta(string Consulta)
        {
            bool Abierto = AbrirConexion();
            if (ConexionAbierta) {
                Comando = new MySqlCommand(Consulta, Conexion);
                Comando.ExecuteNonQuery();
                CerrarConexion();
            }
            return Abierto;
        }

        static MySqlDataReader EjecutarProcedimientoAlmacenado(string NombreProcedimiento)
        {
            Comando = new MySqlCommand(NombreProcedimiento, Conexion);
            Comando.CommandType = CommandType.StoredProcedure;
            AbrirConexion();
            Lector = Comando.ExecuteReader();
            TablaDeResultados = new DataTable();
            TablaDeResultados.Load(Lector);
            CerrarConexion();
            return Lector;
        }

        static bool EjecutarProcedimientoAlmacenado(string NombreProcedimiento,
            TipoConsulta Tipo, params MySqlParameter[] Datos)
        {
            Comando = new MySqlCommand(NombreProcedimiento, Conexion);
            if (Datos != null) {
                Comando.Parameters.AddRange(Datos);
            }
            Comando.CommandType = CommandType.StoredProcedure;
            bool Abierto = AbrirConexion();
            if (Abierto) {
                if (Tipo == TipoConsulta.DevuelveInt) {
                    RegistrosAfectados = Comando.ExecuteNonQuery();
                }
                else {
                    try {
                        Lector = Comando.ExecuteReader();
                        TablaDeResultados = new DataTable();
                        TablaDeResultados.Load(Lector);
                    }
                    catch (Exception ms) {
                        Console.WriteLine(ms.StackTrace);
                    }
                }
                CerrarConexion();
            }
            return Abierto;
        }

        static MySqlParameter Parametro(string Nombre, object Valor)
        {
            return new MySqlParameter(Nombre, Valor);
        }

        static bool AbrirConexion()
        {
            bool Abierto = true;
            try {
                if (Conexion.State != ConnectionState.Open) {
                    Conexion.Open();
                }
                else {
                    Conexion.Close();
                    AbrirConexion();
                }
            }
            catch (Exception ms) {
                MessageBox.Show("No se pudo establecer la conexión, por favor revisa tu conexión a internet\n\nSe cerrará el sistema", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Abierto = false;
            }
            return Abierto;
        }

        static void CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open) {
                Conexion.Close();
            }
        }
    }
}