using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class VentaService
    {
        SqlConnection conexion;
        VentaRepository Venta;
        IList<Venta> Ventas;
        VentaRepository ventaRepository;
        public VentaService()
        {
            ventaRepository = new VentaRepository();

            conexion = new SqlConnection(@"Data Source=DESKTOP-TV2MNDR; Initial Catalog=Ventas;" +
                                            "Integrated Security=SSPI;MultipleActiveResultSets = True ");
            Venta = new VentaRepository(conexion);
        }
        public string GuardarArchivo(Venta venta)
        {
            try
            {
                if (venta != null)
                {
                    string mensaje = ventaRepository.GuardarArchivo(venta);
                    return mensaje;
                }
                else
                {
                    return "Valide la Informacion";
                }
            }
            catch (Exception e)
            {
                return $"Ocurrio un error : {e}";
            }
        }
        public IList<Venta> Consultar()
        {
            conexion.Open();
            Ventas = new List<Venta>();
            Ventas = Venta.Consultar();
            conexion.Close();
            return Ventas;
        }
        public DataTable BuscarxSede(Venta venta)
        {
            return Venta.BuscarxSede(venta);
        }
        public IList<Venta> ConsultarArchivo1()
        {
            try
            {
                return ventaRepository.ConsultarArchivo1();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IList<Venta> ConsultarArchivo2()
        {
            try
            {
                return ventaRepository.ConsultarArchivo2();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IList<Venta> ConsultarArchivo3()
        {
            try
            {
                return ventaRepository.ConsultarArchivo3();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable GuardarBD(Venta venta)
        {
            return ventaRepository.GuardarBD(venta);
        }
    }
}
