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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
            if (VariablesGlobales.UsuarioAdministrador == true)
            {
                btnRegistro.Enabled = true;
                btnConsultas.Enabled = true;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                btnRegistro.Enabled = false;
                btnConsultas.Enabled = true;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        public int admin = 0;
        public string tipo = "usuario";

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Limpiar();

            lblTitulo.Visible = true;
            lblTitulo.Text = "Registrar un usuario";
            lblNombre.Visible = true;
            lblContra.Visible = true;
            lblCorreo.Visible = true;
            lblRecordatorio.Visible = true;
            lblNota1.Visible = true;
            lblNota2.Visible = true;
            lblNota3.Visible = true;
            lblAdvertencia.Visible = false;
            lblRequisitoModificar.Visible = false;

            txtNombre.Visible = true;
            txtContra.Visible = true;
            txtCorreo.Visible = true;

            lblEliModId.Visible = false;
            txtEliModId.Visible = false;

            btnIngresar.Visible = true;
            btnModificacion.Visible = false;
            btnEliminacion.Visible = false;

            dGVUsuarios.Visible = false;
            dGVModificacion.Visible = false;
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = true;
            lblTitulo.Text = "Consultar usuarios";
            lblNombre.Visible = false;
            lblContra.Visible = false;
            lblCorreo.Visible = false;
            lblRecordatorio.Visible = false;
            lblNota1.Visible = false;
            lblNota2.Visible = false;
            lblNota3.Visible = false;
            lblAdvertencia.Visible = false;
            lblRequisitoModificar.Visible = false;

            txtNombre.Visible = false;
            txtContra.Visible = false;
            txtCorreo.Visible = false;

            lblEliModId.Visible = false;
            txtEliModId.Visible = false;

            btnIngresar.Visible = false;
            btnModificacion.Visible = false;
            btnEliminacion.Visible = false;

            dGVUsuarios.Visible = true;
            dGVModificacion.Visible = false;

            Consultainicial();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Limpiar();

            lblTitulo.Visible = true;
            lblTitulo.Text = "Modificar un usuario";
            lblNombre.Visible = true;
            lblContra.Visible = true;
            lblCorreo.Visible = true;
            lblRecordatorio.Visible = true;
            lblNota1.Visible = false;
            lblNota2.Visible = true;
            lblNota3.Visible = true;
            lblAdvertencia.Visible = false;
            lblRequisitoModificar.Visible = true;

            txtNombre.Visible = true;
            txtContra.Visible = true;
            txtCorreo.Visible = true;

            lblEliModId.Visible = true;
            txtEliModId.Visible = true;

            btnIngresar.Visible = false;
            btnModificacion.Visible = true;
            btnEliminacion.Visible = false;

            dGVUsuarios.Visible = false;
            dGVModificacion.Visible = true;

            lblEliModId.Location = new Point(38, 327);
            txtEliModId.Location = new Point(42, 354);

            ConsultaDatosModificar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Limpiar();

            lblTitulo.Visible = true;
            lblTitulo.Text = "Eliminar un usuario";
            lblNombre.Visible = false;
            lblContra.Visible = false;
            lblCorreo.Visible = false;
            lblRecordatorio.Visible = false;
            lblNota1.Visible = false;
            lblNota2.Visible = false;
            lblNota3.Visible = false;
            lblAdvertencia.Visible = true;
            lblRequisitoModificar.Visible = false;

            txtNombre.Visible = false;
            txtContra.Visible = false;
            txtCorreo.Visible = false;

            lblEliModId.Visible = true;
            txtEliModId.Visible = true;

            btnIngresar.Visible = false;
            btnModificacion.Visible = false;
            btnEliminacion.Visible = true;

            dGVUsuarios.Visible = false;
            dGVModificacion.Visible = false;

            lblEliModId.Location = new Point(351, 320);
            txtEliModId.Location = new Point(355, 347);
        }

        private void dGVUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dGVUsuarios.DefaultCellStyle.ForeColor = Color.Blue;
            this.dGVUsuarios.DefaultCellStyle.BackColor = Color.Beige;
            this.dGVUsuarios.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dGVUsuarios.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string cadena = txtNombre.Text;
            //nombre.Text = Convert.ToString(cadena.Length);
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre de usuario!");
                txtNombre.Focus();
            }
            else if (txtContra.Text == "")
            {
                MessageBox.Show("Ingrese una contra");
                txtContra.Focus();
            }
            else if (txtCorreo.Text == "")
            {
                MessageBox.Show("Por favor ingrese su correo electrónico");
                txtCorreo.Focus();
            }
            else
            {
                AltaUsuario();
            }
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            RealizarCambios();
            ConsultaDatosModificar();
        }

        private void btnEliminacion_Click(object sender, EventArgs e)
        {
            string ContraComp = "";
            try
            {
                //Conexion ya sea por localhost o por servidor
                MySqlConnection conectar = new MySqlConnection("server=localhost; database=bdtallermecanico; Uid=root; pwd=;");
                //MySqlConnection conectar = new MySqlConnection("server=arsoft.myvnc.com; database=topicosprueba; Uid=developer; pwd=camb6691481;");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                codigo.Connection = conectar;
                codigo.CommandText = "select * from usuario where id_usuario = \"" + txtEliModId.Text + "\";";
                MySqlDataReader leer = codigo.ExecuteReader();
                leer.Read();
                ContraComp = leer.GetString(0);
                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: \n" + ex);
            }

            if (txtEliModId.Text == ContraComp)
            {
                //Conexion ya sea por localhost o por servidor
                MySqlConnection conectar = new MySqlConnection("server=localhost; database=bdtallermecanico; Uid=root; pwd=;");
                //MySqlConnection conectar = new MySqlConnection("server=arsoft.myvnc.com; database=topicosprueba; Uid=developer; pwd=camb6691481;");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                MySqlConnection conectanos = new MySqlConnection();
                codigo.Connection = conectar;
                codigo.CommandText = "delete from usuario where id_usuario = \"" + txtEliModId.Text + "\";";
                codigo.ExecuteNonQuery();
                conectar.Close();
                MessageBox.Show("El usuario fue eliminado exitosamente");

                txtEliModId.Clear();
            }
            else
            {
                MessageBox.Show("El Id es incorrecto, intente de nuevo.");
                txtEliModId.Text = "";
                txtEliModId.Focus();
            }
        }

        private void AltaUsuario()
        {
            //Un try/catch para evitar un error en la alta de usuario y mandar un mensaje y no truene el programa
            try
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
                //Escribimos el comando para insertar un nombre, correo y contra el id no es indispensable insertar 
                codigo.CommandText = "insert into usuario (nombre, correo, contra, admin, tipo) values (" + "\"" + txtNombre.Text + "\", \"" +
                    txtCorreo.Text + "\", \"" + txtContra.Text + "\", \"" + admin + "\", \"" + tipo + "\");";
                //Ejecuta una instrucción de Transact-SQL en la conexión y devuelve el número de filas afectadas
                codigo.ExecuteNonQuery();
                //Mandamos un mensaje para decirle al usuario que se a registrado correctamente
                MessageBox.Show("Usuario Registrado");
                //Cerramos la conexion
                conectar.Close();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la alta del usuario...\n" + ex);
                return;
            }
        }

        public void Limpiar()
        {
            txtNombre.Clear();
            txtContra.Clear();
            txtCorreo.Clear();
            txtEliModId.Clear();
        }

        //Metodo de RealizarCambios para poder modificar los datos viejos a los nuevos que el usuario esta ingresando
        public void RealizarCambios()
        {
            if (txtEliModId.Text.Length != 0)
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
                        txtCorreo.Text + "\", contra = \"" + txtContra.Text + "\" where id_usuario = \"" + txtEliModId.Text + "\";";
                    codigo.ExecuteNonQuery();
                    conectar.Close();

                    MessageBox.Show("Cambios realizados exitosamente");

                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cambiar los datos:\n" + ex);
                }
            }
            else
            {
                MessageBox.Show("El Id es incorrecto, favor de intentarlo de nuevo");
            }
        }

        private void Consultainicial()
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
                codigo.CommandText = "select id_usuario, nombre, correo, tipo from usuario;";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(codigo);
                DataTable datostabla = new DataTable();
                adaptador.Fill(datostabla);
                dGVUsuarios.DataSource = datostabla;
                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\n" + ex);
            }
        }

        private void ConsultaDatosModificar()
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
                codigo.CommandText = "select id_usuario, nombre, correo, tipo from usuario;";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(codigo);
                DataTable datostabla = new DataTable();
                adaptador.Fill(datostabla);
                dGVModificacion.DataSource = datostabla;
                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\n" + ex);
            }
        }

        private void dGVModificacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evento de click en la dataGridView donde pasa registros de la tabla a cajas de texto haciendo doble click.
            txtEliModId.Text = dGVModificacion.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dGVModificacion.CurrentRow.Cells[1].Value.ToString();
            txtCorreo.Text = dGVModificacion.CurrentRow.Cells[2].Value.ToString();
            txtContra.Text = dGVModificacion.CurrentRow.Cells[3].Value.ToString();

        }
    }
}
