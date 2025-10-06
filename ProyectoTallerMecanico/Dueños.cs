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
    public partial class frmDueños : Form
    {
        public frmDueños()
        {
            InitializeComponent();
            if (VariablesGlobales.UsuarioAdministrador == true)
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Limpiar();

            lblTitulo.Visible = true;
            lblTitulo.Text = "Registrar un dueño";
            lblNombre.Visible = true;
            lblDireccion.Visible = true;
            lblTelefono.Visible = true;
            lblCorreo.Visible = true;
            lblRecordatorio.Visible = true;
            lblNota1.Visible = true;
            lblNota2.Visible = true;
            lblNota3.Visible = true;
            lblAdvertencia.Visible = false;
            lblRequisitoModificar.Visible = false;

            txtNombre.Visible = true;
            txtDireccion.Visible = true;
            txtTelefono.Visible = true;
            txtCorreo.Visible = true;

            lblEliModId.Visible = false;
            txtEliModId.Visible = false;

            btnIngresar.Visible = true;
            btnModificacion.Visible = false;
            btnEliminacion.Visible = false;

            dGVDueño.Visible = false;
            dGVModificacion.Visible = false;

            lblNombre.Location = new Point(365, 193);
            lblDireccion.Location = new Point(365, 258);
            lblTelefono.Location = new Point(365, 319);
            lblCorreo.Location = new Point(364, 387);
            txtNombre.Location = new Point(369, 220);
            txtDireccion.Location = new Point(369, 285);
            txtTelefono.Location = new Point(368, 346);
            txtCorreo.Location = new Point(369, 414);
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            Limpiar();

            lblTitulo.Visible = true;
            lblTitulo.Text = "Consultar dueños";
            lblNombre.Visible = false;
            lblDireccion.Visible = false;
            lblTelefono.Visible = false;
            lblCorreo.Visible = false;
            lblRecordatorio.Visible = false;
            lblNota1.Visible = false;
            lblNota2.Visible = false;
            lblNota3.Visible = false;
            lblAdvertencia.Visible = false;
            lblRequisitoModificar.Visible = false;

            txtNombre.Visible = false;
            txtDireccion.Visible = false;
            txtTelefono.Visible = false;
            txtCorreo.Visible = false;

            lblEliModId.Visible = false;
            txtEliModId.Visible = false;

            btnIngresar.Visible = false;
            btnModificacion.Visible = false;
            btnEliminacion.Visible = false;

            dGVDueño.Visible = true;
            dGVModificacion.Visible = false;

            Consultainicial();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Limpiar();

            lblTitulo.Visible = true;
            lblTitulo.Text = "Modificar un dueño";
            lblNombre.Visible = true;
            lblDireccion.Visible = true;
            lblTelefono.Visible = true;
            lblCorreo.Visible = true;
            lblRecordatorio.Visible = true;
            lblNota1.Visible = false;
            lblNota2.Visible = true;
            lblNota3.Visible = true;
            lblAdvertencia.Visible = false;
            lblRequisitoModificar.Visible = true;

            txtNombre.Visible = true;
            txtDireccion.Visible = true;
            txtTelefono.Visible = true;
            txtCorreo.Visible = true;

            lblEliModId.Visible = true;
            txtEliModId.Visible = true;

            btnIngresar.Visible = false;
            btnModificacion.Visible = true;
            btnEliminacion.Visible = false;

            dGVDueño.Visible = false;
            dGVModificacion.Visible = true;

            lblNombre.Location = new Point(365, 258);
            lblDireccion.Location = new Point(365, 319);
            lblTelefono.Location = new Point(364, 387);
            lblCorreo.Location = new Point(364, 449);
            txtNombre.Location = new Point(369, 285);
            txtDireccion.Location = new Point(368, 346);
            txtTelefono.Location = new Point(369, 414);
            txtCorreo.Location = new Point(368, 476);

            ConsultaDatosModificar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Limpiar();

            lblTitulo.Visible = true;
            lblTitulo.Text = "Eliminar un dueño";
            lblNombre.Visible = false;
            lblDireccion.Visible = false;
            lblTelefono.Visible = false;
            lblCorreo.Visible = false;
            lblRecordatorio.Visible = false;
            lblNota1.Visible = false;
            lblNota2.Visible = false;
            lblNota3.Visible = false;
            lblAdvertencia.Visible = true;
            lblRequisitoModificar.Visible = false;

            txtNombre.Visible = false;
            txtDireccion.Visible = false;
            txtTelefono.Visible = false;
            txtCorreo.Visible = false;

            lblEliModId.Visible = true;
            txtEliModId.Visible = true;

            btnIngresar.Visible = false;
            btnModificacion.Visible = false;
            btnEliminacion.Visible = true;

            dGVDueño.Visible = false;
            dGVModificacion.Visible = false;
        }

        private void dGVDueño_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dGVDueño.DefaultCellStyle.ForeColor = Color.Blue;
            this.dGVDueño.DefaultCellStyle.BackColor = Color.Beige;
            this.dGVDueño.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dGVDueño.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
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
            else if (txtDireccion.Text == "")
            {
                MessageBox.Show("Ingrese una direccion");
                txtDireccion.Focus();
            }
            else if (txtTelefono.Text == "")
            {
                MessageBox.Show("Favor de ingresar un telefono");
                txtTelefono.Focus();
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
                codigo.CommandText = "select * from dueno where id_dueno = \"" + txtEliModId.Text + "\";";
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
                codigo.CommandText = "delete from dueno where id_dueno = \"" + txtEliModId.Text + "\";";
                codigo.ExecuteNonQuery();
                conectar.Close();
                MessageBox.Show("El dueño fue eliminado exitosamente");

                txtEliModId.Clear();
            }
            else
            {
                MessageBox.Show("El Id es incorrecto, intente de nuevo.");
                txtEliModId.Text = "";
                txtEliModId.Focus();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
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
                codigo.CommandText = "insert into dueno (nombre, domicilio, telefono, email) values (" + "\"" + txtNombre.Text + "\", \"" +
                    txtDireccion.Text + "\", \"" + txtTelefono.Text + "\", \"" + txtCorreo.Text + "\");";
                //Ejecuta una instrucción de Transact-SQL en la conexión y devuelve el número de filas afectadas
                codigo.ExecuteNonQuery();
                //Mandamos un mensaje para decirle al usuario que se a registrado correctamente
                MessageBox.Show("Dueño Registrado");
                //Cerramos la conexion
                conectar.Close();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la alta del dueño...\n" + ex);
                return;
            }
        }

        public void Limpiar()
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
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
                    codigo.CommandText = "update dueno set nombre = \"" + txtNombre.Text + "\", domicilio = \"" +
                        txtDireccion.Text + "\", telefono = \"" + txtTelefono.Text + "\", email = \"" + txtCorreo.Text + 
                        "\" where id_dueno = \"" + txtEliModId.Text + "\";";
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
                codigo.CommandText = "select * from dueno;";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(codigo);
                DataTable datostabla = new DataTable();
                adaptador.Fill(datostabla);
                dGVDueño.DataSource = datostabla;
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
                codigo.CommandText = "select * from dueno;";
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
            txtDireccion.Text = dGVModificacion.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = dGVModificacion.CurrentRow.Cells[3].Value.ToString();
            txtCorreo.Text = dGVModificacion.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
