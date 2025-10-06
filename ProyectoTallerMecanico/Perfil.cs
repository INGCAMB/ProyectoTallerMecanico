using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using MySql.Data.MySqlClient;

namespace ProyectoTallerMecanico
{
    public partial class frmPerfil : Form
    {
        //Variables para guardar los datos viejos de la base de datos
        string NombreViejo = "", CorreoViejo = "", ContraVieja = "";

        public frmPerfil()
        {
            InitializeComponent();
            ConsultarDatos();
        }

        public void ConsultarDatos()
        {
            //Conexion ya sea por localhost o por servidor
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=bdtallermecanico; Uid=root; pwd=;");
            //MySqlConnection conectar = new MySqlConnection("server=arsoft.myvnc.com; database=topicosprueba; Uid=developer; pwd=camb6691481;");
            //Abrimos conexion
            conectar.Open();
            //Abrimos objeto para comando mysql
            MySqlCommand codigo = new MySqlCommand();
            //Nos conectamos
            MySqlConnection conectanos = new MySqlConnection();
            //Hacemos conexion con los comandos de mysql con la base de datos 
            codigo.Connection = conectar;
            //Escribimos el comando para consultar un correo del txtCorreo de la tabla usuarios
            codigo.CommandText = "select * from usuario where correo = \"" + VariablesGlobales.CorreoDelUsuarioActivo + "\";";
            //Leemos los datos del registro buscado
            MySqlDataReader leer = codigo.ExecuteReader();
            leer.Read();
            //Los guardamos en las variables los obtenemos con su tipo de dato y la posicion en la que se encuentran en la base de datos
            NombreViejo = leer.GetString(1);
            CorreoViejo = leer.GetString(2);
            //Cerramos la conexion
            conectar.Close();

            //Las insertamos a la vista del usuario en las textbox
            txtNombre.Text = NombreViejo;
            txtCorreo.Text = CorreoViejo;

            txtId.Text = VariablesGlobales.IdDeUsuarioActivo.ToString();
            txtTipo.Text = VariablesGlobales.TipoUsuario;

            //Guardamos el nombre y el correo actualizado
            txtNombre.Text = VariablesGlobales.NombreDeUsuarioActivo;
            txtCorreo.Text = VariablesGlobales.CorreoDelUsuarioActivo;
        }

        public void Consulta()
        {
            //Conexion ya sea por localhost o por servidor
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=bdtallermecanico; Uid=root; pwd=;");
            //MySqlConnection conectar = new MySqlConnection("server=arsoft.myvnc.com; database=topicosprueba; Uid=developer; pwd=camb6691481;");
            conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            MySqlConnection conectanos = new MySqlConnection();
            codigo.Connection = conectar;
            codigo.CommandText = "select * from usuario where correo = \"" + VariablesGlobales.CorreoDelUsuarioActivo + "\";";
            MySqlDataReader leer = codigo.ExecuteReader();
            leer.Read();
            NombreViejo = leer.GetString(1);
            CorreoViejo = leer.GetString(2);
            ContraVieja = leer.GetString(3);
            conectar.Close();

            txtNombre.Text = NombreViejo;
            txtCorreo.Text = CorreoViejo;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RealizarCambios();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Consulta de cuenta";

            btnAceptar.Visible = false;
            btnAceptar.Enabled = false;
            txtNombre.ReadOnly = true;
            txtCorreo.ReadOnly = true;
            txtId.ReadOnly = true;
            txtTipo.ReadOnly = true;

            lblNombre.Text = "Nombre del usuario:";
            lblCorreo.Text = "Correo del usuario:";
            lblId.Text = "Id del usuario:";
            lblTipo.Text = "Tipo de usuario:";

            txtId.PasswordChar = '\0';
            txtTipo.PasswordChar = '\0';

            ConsultarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Modificar cuenta";

            txtId.Text = "";
            txtTipo.Text = "";

            btnAceptar.Visible = true;
            btnAceptar.Enabled = false;
            txtNombre.ReadOnly = false;
            txtCorreo.ReadOnly = false;
            txtId.ReadOnly = false;
            txtTipo.ReadOnly = false;

            lblNombre.Text = "Nombre del usuario:";
            lblCorreo.Text = "Correo:";
            lblId.Text = "Contraseña actual:";
            lblTipo.Text = "Contraseña nueva:";

            txtId.PasswordChar = '*';
            txtTipo.PasswordChar = '*';

            Consulta();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            btnAceptar.Enabled = true;
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            txtTipo.Enabled = true;
            btnAceptar.Enabled = true;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            txtTipo.Enabled = true;
            btnAceptar.Enabled = true;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtCorreo.Focus();
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtId.Focus();
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTipo.Focus();
            }
        }

        private void txtTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAceptar.Focus();
            }
        }

        //Metodo de RealizarCambios para poder modificar los datos viejos a los nuevos que el usuario esta ingresando
        public void RealizarCambios()
        {
            if (txtId.Text == "")
            {
                try
                {
                    //Conexion ya sea por localhost o por servidor
                    MySqlConnection conectar = new MySqlConnection("server=localhost; database=bdtallermecanico; Uid=root; pwd=;");
                    //MySqlConnection conectar = new MySqlConnection("server=arsoft.myvnc.com; database=topicosprueba; Uid=developer; pwd=camb6691481;");
                    conectar.Open();
                    MySqlCommand codigo = new MySqlCommand();
                    MySqlConnection conectanos = new MySqlConnection();
                    codigo.Connection = conectar;
                    codigo.CommandText = "update usuario set nombre = \"" + txtNombre.Text + "\", correo = \"" +
                        txtCorreo.Text + "\" where correo = \"" + CorreoViejo + "\";";
                    codigo.ExecuteNonQuery();
                    conectar.Close();

                    VariablesGlobales.NombreDeUsuarioActivo = txtNombre.Text;
                    VariablesGlobales.CorreoDelUsuarioActivo = txtCorreo.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cambiar los datos:\n" + ex);
                }
            }
            else if (ContraVieja == txtId.Text)
            {
                try
                {
                    //Conexion ya sea por localhost o por servidor
                    MySqlConnection conectar = new MySqlConnection("server=localhost; database=bdtallermecanico; Uid=root; pwd=;");
                    //MySqlConnection conectar = new MySqlConnection("server=arsoft.myvnc.com; database=topicosprueba; Uid=developer; pwd=camb6691481;");
                    conectar.Open();
                    MySqlCommand codigo = new MySqlCommand();
                    MySqlConnection conectanos = new MySqlConnection();
                    codigo.Connection = conectar;
                    codigo.CommandText = "update usuario set nombre = \"" + txtNombre.Text + "\", correo = \"" +
                        txtCorreo.Text + "\", Contra = \"" + txtTipo.Text + "\" where correo = \"" +
                        CorreoViejo + "\";";
                    codigo.ExecuteNonQuery();
                    conectar.Close();

                    VariablesGlobales.NombreDeUsuarioActivo = txtNombre.Text;
                    VariablesGlobales.CorreoDelUsuarioActivo = txtCorreo.Text;

                    Limpiar();

                    MessageBox.Show("Cambios realizados exitosamente");

                    Consulta();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cambiar los datos:\n" + ex);
                }
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta, favor de intentarlo de nuevo");
            }
        }

        public void Limpiar()
        {
            txtNombre.Clear();
            txtCorreo.Clear();
            txtId.Clear();
            txtTipo.Clear();
        }


    }
}
