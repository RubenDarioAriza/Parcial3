using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial3
{
    public partial class FrmPrincipal : Form
    {
        VentaService ventaService = new VentaService();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (cmbSedeCargar.Text == "Sede Norte")
            {
                dtgArchivos.DataSource = ventaService.ConsultarArchivo1();
                dtgArchivos.Refresh();
            }
            if (cmbSedeCargar.Text == "Sede Sur")
            {
                dtgArchivos.DataSource = ventaService.ConsultarArchivo2();
                dtgArchivos.Refresh();
            }
            if (cmbSedeCargar.Text == "Sede Centro")
            {
                dtgArchivos.DataSource = ventaService.ConsultarArchivo3();
                dtgArchivos.Refresh();
            }
        }

        private void btnGuardarBD_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            ValidarInfo();
            MessageBox.Show("Datos Guardados Correctamente");
        }
        private void ValidarInfo()
        {
            Venta venta = new Venta();

            for (int i = 0; i < dtgArchivos.RowCount; i++)
            {
                venta.CodigoProducto = (string)dtgArchivos.Rows[i].Cells[0].Value;
                venta.NombreProducto = (string)dtgArchivos.Rows[i].Cells[1].Value;
                venta.Valor = (string)dtgArchivos.Rows[i].Cells[2].Value;
                venta.CodigoSede = (string)dtgArchivos.Rows[i].Cells[3].Value;
                venta.Nombre = (string)dtgArchivos.Rows[i].Cells[4].Value;
                if (venta.CodigoProducto == "P001" || venta.CodigoProducto == "P002" || venta.CodigoProducto == "P003" || venta.CodigoProducto == "P004" || venta.PrecioVenta == "1000000" || venta.PrecioVenta == "1200000" || venta.PrecioVenta == "800000" || venta.PrecioVenta == "500000")
                {
                    ventaService.GuardarBD(venta);
                }
                else
                {
                    for (int j = 0; j < dtgArchivos.RowCount; j++)
                    {
                        venta.CodigoProducto = (string)dtgArchivos.Rows[j].Cells[0].Value;
                        venta.NombreProducto = (string)dtgArchivos.Rows[j].Cells[1].Value;
                        venta.Valor = (string)dtgArchivos.Rows[j].Cells[2].Value;
                        venta.CodigoSede= (string)dtgArchivos.Rows[j].Cells[3].Value;
                        venta.Nombre = (string)dtgArchivos.Rows[j].Cells[4].Value;
                    }
                    ventaService.GuardarArchivo(venta);
                }
            }       
        }
        private void btnCargarBD_Click(object sender, EventArgs e)
        {

            Venta venta = new Venta();
            venta.Nombre = cmbSedeConsulta.Text;
            dtgBD.DataSource = ventaService.BuscarxSede(venta);
            dtgBD.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            dtgBD.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dtgBD.Refresh();

            //if (cmbSedeConsulta.Text == "01")
            //{
            //    Venta venta = new Venta();
            //    venta.SedeVenta = cmbSedeConsulta.Text;
            //    dtgBD.DataSource = ventaService.BuscarxSede(venta);
            //    dtgBD.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            //    dtgBD.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            //    dtgBD.Refresh();
            //}
            //if (cmbSedeConsulta.Text == "02")
            //{
            //    Venta venta = new Venta();
            //    venta.SedeVenta = cmbSedeConsulta.Text;
            //    dtgBD.DataSource = ventaService.BuscarxSede(venta);
            //    dtgBD.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            //    dtgBD.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            //    dtgBD.Refresh();
            //}
            //if (cmbSedeConsulta.Text == "03")
            //{
            //    Venta venta = new Venta();
            //    venta.SedeVenta = cmbSedeConsulta.Text;
            //    dtgBD.DataSource = ventaService.BuscarxSede(venta);
            //    dtgBD.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            //    dtgBD.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            //    dtgBD.Refresh();
            //}
        }

        private void cmbSedeConsulta_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dtgBD.DataSource = ventaService.Consultar();
            dtgBD.Refresh();
        }
    }
}
