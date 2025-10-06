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
    public partial class frmMecanicoAtendioVehiculo : Form
    {
        public frmMecanicoAtendioVehiculo()
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
            lblTitulo.Text = "Registrar un mecanico";
            lblIdVehiculo.Visible = true;
            lblNombre.Visible = true;
            lblRecordatorio.Visible = true;
            lblNota1.Visible = true;
            lblNota3.Visible = true;
            lblAdvertencia.Visible = false;
            lblRequisitoModificar.Visible = false;

            txtIdVehiculo.Visible = true;
            txtNombre.Visible = true;

            lblEliModId.Visible = false;
            txtEliModId.Visible = false;

            btnIngresar.Visible = true;
            btnModificacion.Visible = false;
            btnEliminacion.Visible = false;

            dGVMecanico.Visible = false;
            dGVModificacion.Visible = false;

            lblIdVehiculo.Location = new Point(380, 223);
            lblNombre.Location = new Point(380, 293);
            txtIdVehiculo.Location = new Point(384, 250);
            txtNombre.Location = new Point(384, 320);

            lblNota3.Location = new Point(42, 338);
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            Limpiar();

            lblTitulo.Visible = true;
            lblTitulo.Text = "Consultar mecanicos";
            lblIdVehiculo.Visible = false;
            lblNombre.Visible = false;
            lblRecordatorio.Visible = false;
            lblNota1.Visible = false;
            lblNota3.Visible = false;
            lblAdvertencia.Visible = false;
            lblRequisitoModificar.Visible = false;

            txtIdVehiculo.Visible = false;
            txtNombre.Visible = false;

            lblEliModId.Visible = false;
            txtEliModId.Visible = false;

            btnIngresar.Visible = false;
            btnModificacion.Visible = false;
            btnEliminacion.Visible = false;

            dGVMecanico.Visible = true;
            dGVModificacion.Visible = false;

            Consultainicial();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Limpiar();

            lblTitulo.Visible = true;
            lblTitulo.Text = "Modificar un mecanico";
            lblIdVehiculo.Visible = true;
            lblNombre.Visible = true;
            lblRecordatorio.Visible = true;
            lblNota1.Visible = false;
            lblNota3.Visible = true;
            lblAdvertencia.Visible = false;
            lblRequisitoModificar.Visible = true;

            txtIdVehiculo.Visible = true;
            txtNombre.Visible = true;

            lblEliModId.Visible = true;
            txtEliModId.Visible = true;

            btnIngresar.Visible = false;
            btnModificacion.Visible = true;
            btnEliminacion.Visible = false;

            dGVMecanico.Visible = false;
            dGVModificacion.Visible = true;

            lblIdVehiculo.Location = new Point(380, 293);
            lblNombre.Location = new Point(380, 358);
            txtIdVehiculo.Location = new Point(384, 320);
            txtNombre.Location = new Point(383, 385);

            lblNota3.Location = new Point(42, 265);
            lblRequisitoModificar.Location = new Point(42, 338);

            ConsultaDatosModificar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Limpiar();

            lblTitulo.Visible = true;
            lblTitulo.Text = "Eliminar un mecanico";
            lblIdVehiculo.Visible = false;
            lblNombre.Visible = false;
            lblRecordatorio.Visible = false;
            lblNota1.Visible = false;
            lblNota3.Visible = false;
            lblAdvertencia.Visible = true;
            lblRequisitoModificar.Visible = false;

            txtIdVehiculo.Visible = false;
            txtNombre.Visible = false;

            lblEliModId.Visible = true;
            txtEliModId.Visible = true;

            btnIngresar.Visible = false;
            btnModificacion.Visible = false;
            btnEliminacion.Visible = true;

            dGVMecanico.Visible = false;
            dGVModificacion.Visible = false;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Limpiar();

            string cadena = txtIdVehiculo.Text;
            //nombre.Text = Convert.ToString(cadena.Length);
            if (txtIdVehiculo.Text == "")
            {
                MessageBox.Show("Ingrese un identificador de vehiculo!");
                txtIdVehiculo.Focus();
            }
            else if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre");
                txtNombre.Focus();
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
                codigo.CommandText = "select * from mecanico where id_mecanico = \"" + txtEliModId.Text + "\";";
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
                codigo.CommandText = "delete from mecanico where id_mecanico = \"" + txtEliModId.Text + "\";";
                codigo.ExecuteNonQuery();
                conectar.Close();
                MessageBox.Show("El mecanico fue eliminado exitosamente");

                txtEliModId.Clear();
            }
            else
            {
                MessageBox.Show("El Id es incorrecto, intente de nuevo.");
                txtEliModId.Text = "";
                txtEliModId.Focus();
            }
        }

        private void dGVMecanico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dGVMecanico.DefaultCellStyle.ForeColor = Color.Blue;
            this.dGVMecanico.DefaultCellStyle.BackColor = Color.Beige;
            this.dGVMecanico.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dGVMecanico.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
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
                codigo.CommandText = "insert into mecanico (id_vehiculo, nombre) values (" + "\"" + txtIdVehiculo.Text + "\", \"" +
                    txtNombre.Text + "\");";
                //Ejecuta una instrucción de Transact-SQL en la conexión y devuelve el número de filas afectadas
                codigo.ExecuteNonQuery();
                //Mandamos un mensaje para decirle al usuario que se a registrado correctamente
                MessageBox.Show("Mecanico Registrado");
                //Cerramos la conexion
                conectar.Close();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la alta del mecanico...\n" + ex);
                return;
            }
        }

        public void Limpiar()
        {
            txtIdVehiculo.Clear();
            txtNombre.Clear();
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
                    codigo.CommandText = "update mecanico set id_vehiculo = \"" + txtIdVehiculo.Text + "\", nombre = \"" +
                        txtNombre.Text + "\" where id_mecanico = \"" + txtEliModId.Text + "\";";
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
                codigo.CommandText = "select * from mecanico;";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(codigo);
                DataTable datostabla = new DataTable();
                adaptador.Fill(datostabla);
                dGVMecanico.DataSource = datostabla;
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
                codigo.CommandText = "select * from mecanico;";
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
            txtIdVehiculo.Text = dGVModificacion.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dGVModificacion.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
