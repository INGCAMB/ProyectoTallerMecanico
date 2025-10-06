using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Agregar estas dos referencia una para el hint de login y la otra para conexion MySql
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace ProyectoTallerMecanico
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            lblMenu.Text = "Menu";
            lblBienvenido.Text = "¡Bienvenido " + VariablesGlobales.NombreDeUsuarioActivo + "!";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pbRestaurar.Visible = false;
            pbMaximizar.Visible = true;
        }

        private void pbMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pbMaximizar.Visible = false;
            pbRestaurar.Visible = true;
        }

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pbCerrarSesion_Click(object sender, EventArgs e)
        {
            frmLogin regresar = new frmLogin();
            regresar.Show();
            Close();
        }

        private void pbAcercaDe_Click(object sender, EventArgs e)
        {
            lblMenu.Text = "Acerca De";
            if (this.plContenedor.Controls.Count > 0)
                this.plContenedor.Controls.RemoveAt(0);
            frmAcercaDe fa = new frmAcercaDe();
            fa.TopLevel = false;
            fa.FormBorderStyle = FormBorderStyle.None;
            fa.Dock = DockStyle.Fill;
            this.plContenedor.Controls.Add(fa);
            this.plContenedor.Tag = fa;
            fa.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            lblMenu.Text = "Perfil";
            if (this.plContenedor.Controls.Count > 0)
                this.plContenedor.Controls.RemoveAt(0);
            frmPerfil fp = new frmPerfil();
            fp.TopLevel = false;
            fp.FormBorderStyle = FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            this.plContenedor.Controls.Add(fp);
            this.plContenedor.Tag = fp;
            fp.Show();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            lblMenu.Text = "Vehiculos";
            if (this.plContenedor.Controls.Count > 0)
                this.plContenedor.Controls.RemoveAt(0);
            frmVehiculos fp = new frmVehiculos();
            fp.TopLevel = false;
            fp.FormBorderStyle = FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            this.plContenedor.Controls.Add(fp);
            this.plContenedor.Tag = fp;
            fp.Show();
        }

        private void btnDueños_Click(object sender, EventArgs e)
        {
            lblMenu.Text = "Dueños";
            if (this.plContenedor.Controls.Count > 0)
                this.plContenedor.Controls.RemoveAt(0);
            frmDueños fp = new frmDueños();
            fp.TopLevel = false;
            fp.FormBorderStyle = FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            this.plContenedor.Controls.Add(fp);
            this.plContenedor.Tag = fp;
            fp.Show();
        }

        private void btnReparaciones_Click(object sender, EventArgs e)
        {
            lblMenu.Text = "Reparaciones";
            if (this.plContenedor.Controls.Count > 0)
                this.plContenedor.Controls.RemoveAt(0);
            frmReparaciones fp = new frmReparaciones();
            fp.TopLevel = false;
            fp.FormBorderStyle = FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            this.plContenedor.Controls.Add(fp);
            this.plContenedor.Tag = fp;
            fp.Show(); 
        }

        private void btnMecanicoAtendioVehiculo_Click(object sender, EventArgs e)
        {
            lblMenu.Text = "Mecanico que atendio vehiculo";
            if (this.plContenedor.Controls.Count > 0)
                this.plContenedor.Controls.RemoveAt(0);
            frmMecanicoAtendioVehiculo fp = new frmMecanicoAtendioVehiculo();
            fp.TopLevel = false;
            fp.FormBorderStyle = FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            this.plContenedor.Controls.Add(fp);
            this.plContenedor.Tag = fp;
            fp.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            lblMenu.Text = "Reportes";
            if (this.plContenedor.Controls.Count > 0)
                this.plContenedor.Controls.RemoveAt(0);
            frmReportes fp = new frmReportes();
            fp.TopLevel = false;
            fp.FormBorderStyle = FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            this.plContenedor.Controls.Add(fp);
            this.plContenedor.Tag = fp;
            fp.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            lblMenu.Text = "Usuarios";
            if (this.plContenedor.Controls.Count > 0)
                this.plContenedor.Controls.RemoveAt(0);
            frmUsuarios fp = new frmUsuarios();
            fp.TopLevel = false;
            fp.FormBorderStyle = FormBorderStyle.None;
            fp.Dock = DockStyle.Fill;
            this.plContenedor.Controls.Add(fp);
            this.plContenedor.Tag = fp;
            fp.Show();
        }
    }
}
