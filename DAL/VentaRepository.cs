using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VentaRepository
    {
        private SqlConnection cn;
        private SqlConnection Conexion;
        private SqlDataReader Reader;
        IList<Venta> Ventas = new List<Venta>();
        private List<Venta> ventaRepository;
        string FileName = @"D:\Universidad\Septimo Semestre\PG3\Tercer Corte\cosas para el parcial\Parcial3\Log.txt";
        string FileName1 = @"D:\Universidad\Septimo Semestre\PG3\Tercer Corte\cosas para el parcial\Parcial3\Sede 01.txt";
        string FileName2 = @"D:\Universidad\Septimo Semestre\PG3\Tercer Corte\cosas para el parcial\Parcial3\Sede 02.txt";
        string FileName3 = @"D:\Universidad\Septimo Semestre\PG3\Tercer Corte\cosas para el parcial\Parcial3\Sede 03.txt";
        public VentaRepository()
        {

            cn = new SqlConnection(@"Data Source=DESKTOP-TV2MNDR; Initial Catalog=Ventas;" +
                                            "Integrated Security=SSPI;MultipleActiveResultSets = True ");
            ventaRepository = new List<Venta>();
        }
        public VentaRepository(SqlConnection conexion)
        {
            Conexion = conexion;
        }
        public string GuardarArchivo(Venta venta)
        {
            try
            {
                FileStream SourceStream = new FileStream(FileName, FileMode.Append);
                StreamWriter write = new StreamWriter(SourceStream);
                write.WriteLine(venta.CodigoProducto + ";" + venta.NombreProducto + ";" + venta.Valor + ";"+venta.CodigoSede);
                write.Close();
                SourceStream.Close();
                return "Informacion ha sido guardada";
            }
            catch (Exception e)
            {
                return $"Error : {e}";
            }

        }
        public IList<Venta> Consultar()
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * From Venta";
                Reader = Comando.ExecuteReader();
                Comando.Parameters.Clear();

                while (Reader.Read())
                {
                    Venta venta = new Venta();
                    venta = Map(Reader);
                    Ventas.Add(venta);
                }
                return Ventas;
            }
        }
        public Venta Map(SqlDataReader reader)
        {
            Venta venta = new Venta();
            venta.CodigoProducto = (string)reader["CodigoProducto"];
            venta.NombreProducto = (string)reader["Nombre del Producto"];
            venta.Valor = (string)reader["Valor del Producto"];
            venta.Nombre = (string)reader["Nombre de la Sede"];
            venta.CodigoSede = (string)reader["Codigo de Sede"];
            return venta;
        }
        public DataTable BuscarxSede(Venta venta)
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * From Venta Where SedeVenta like '%'+@SedeVenta+'%'";
                Comando.Parameters.AddWithValue("@SedeVenta", venta.SedeVenta);
                using (SqlDataAdapter dt = new SqlDataAdapter(Comando))
                {
                    DataTable tbl = new DataTable();
                    dt.Fill(tbl);
                    return tbl;
                }
            }
        }
        
        public List<Venta> ConsultarArchivo1()
        {
            //try {
            ventaRepository.Clear();
            FileStream SourceStream = new FileStream(FileName1, FileMode.OpenOrCreate);
            StreamReader Lector = new StreamReader(SourceStream);
            string Linea = string.Empty;
            while ((Linea = Lector.ReadLine()) != null)
            {
                Venta venta = Map1(Linea);
                ventaRepository.Add(venta);
            }
            Lector.Close();
            SourceStream.Close();
            return ventaRepository;
            //} catch (Exception) {
            //    throw;
            //}
        }

        private static Venta Map1(string Linea)
        {
            char delimiter = ';';
            string[] DatosVenta = Linea.Split(delimiter);
            Venta venta = new Venta();
            venta.Identificacion = DatosVenta[0];
            venta.Nombre = DatosVenta[1];
            venta.CodigoProducto = DatosVenta[2];
            venta.SedeVenta = DatosVenta[3];
            venta.PrecioVenta = DatosVenta[4];
            return venta;
        }
        public List<Venta> ConsultarArchivo2()
        {
            //try {
            ventaRepository.Clear();
            FileStream SourceStream = new FileStream(FileName2, FileMode.OpenOrCreate);
            StreamReader Lector = new StreamReader(SourceStream);
            string Linea = string.Empty;
            while ((Linea = Lector.ReadLine()) != null)
            {
                Venta venta = Map2(Linea);
                ventaRepository.Add(venta);
            }
            Lector.Close();
            SourceStream.Close();
            return ventaRepository;
            //} catch (Exception) {
            //    throw;
            //}
        }

        private static Venta Map2(string Linea)
        {
            char delimiter = ';';
            string[] DatosVenta = Linea.Split(delimiter);
            Venta venta = new Venta();
            venta.Identificacion = DatosVenta[0];
            venta.Nombre = DatosVenta[1];
            venta.CodigoProducto = DatosVenta[2];
            venta.SedeVenta = DatosVenta[3];
            venta.PrecioVenta = DatosVenta[4];
            return venta;
        }
        public List<Venta> ConsultarArchivo3()
        {
            //try {
            ventaRepository.Clear();
            FileStream SourceStream = new FileStream(FileName3, FileMode.OpenOrCreate);
            StreamReader Lector = new StreamReader(SourceStream);
            string Linea = string.Empty;
            while ((Linea = Lector.ReadLine()) != null)
            {
                Venta venta = Map3(Linea);
                ventaRepository.Add(venta);
            }
            Lector.Close();
            SourceStream.Close();
            return ventaRepository;
            //} catch (Exception) {
            //    throw;
            //}
        }

        private static Venta Map3(string Linea)
        {
            char delimiter = ';';
            string[] DatosVenta = Linea.Split(delimiter);
            Venta venta = new Venta();
            venta.Identificacion = DatosVenta[0];
            venta.Nombre = DatosVenta[1];
            venta.CodigoProducto = DatosVenta[2];
            venta.SedeVenta = DatosVenta[3];
            venta.PrecioVenta = DatosVenta[4];
            return venta;
        }
        public DataTable GuardarBD(Venta venta)
        {
            using (SqlCommand cmd = new SqlCommand("GuardarVenta", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Identificacion", venta.Identificacion);
                cmd.Parameters.AddWithValue("@Nombre", venta.Nombre);
                cmd.Parameters.AddWithValue("@CodigoProducto", venta.CodigoProducto);
                cmd.Parameters.AddWithValue("@SedeVenta", venta.SedeVenta);
                cmd.Parameters.AddWithValue("@PrecioVenta", venta.PrecioVenta);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }
            }
        }
    }
}
