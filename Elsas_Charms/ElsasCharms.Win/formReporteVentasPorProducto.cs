using ElsasCharms.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElsasCharms.Win
{
    public partial class formReporteVentasPorProducto : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        ReporteVentasPorProductoBL _reporteVentasPorProductoBL;

        public formReporteVentasPorProducto()
        {
            InitializeComponent();

            _reporteVentasPorProductoBL = new ReporteVentasPorProductoBL();
            RefrescarDatos();
        }

        private void btnRefrescarDatos_Click(object sender, EventArgs e)
        {
            RefrescarDatos();
        }

        private void RefrescarDatos()
        {
            var listaVentasPorProducto = _reporteVentasPorProductoBL.ObtenerVentasPorProducto();

            listaVentasPorProductoBindingSource.DataSource = listaVentasPorProducto;

            listaVentasPorProductoBindingSource.ResetBindings(false);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formReporteVentasPorProducto_Load(object sender, EventArgs e)
        {

        }

    }
}
