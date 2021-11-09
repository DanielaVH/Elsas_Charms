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
    public partial class MDIPrincipal : Form
    {
        private int childFormNumber = 0;

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormulario<frmForm>() where frmForm : Form, new()
        {
            frmForm formPrincipal;
            formPrincipal = new frmForm();
            formPrincipal.MdiParent = this;

            var name = formPrincipal.Name.ToString();

            Form form = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == name).SingleOrDefault<Form>();
            
            if (form != null )
            {
                formPrincipal.BringToFront();
            }
            else
            {                
                formPrincipal.Show();
                formPrincipal.BringToFront();
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Salir();            
        }

        private void Salir()
        {
            if (MessageBox.Show("¿Desea salir de la Aplicacioón?", "Elsas Charms", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2 ) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<formIntegrantes>();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<formProductos>();
        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<formReporteVentasPorProducto>();
        }
    }
}
