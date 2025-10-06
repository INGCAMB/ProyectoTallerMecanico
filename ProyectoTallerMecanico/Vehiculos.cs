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
    public partial class frmVehiculos : Form
    {
        public frmVehiculos()
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
                codigo.CommandText = "insert into vehiculo (id_dueno, matricula, modelo, marca, presupuesto) values (" + "\"" + txtIdDueno.Text + "\", \"" +
                    txtMatricula.Text + "\", \"" + txtModelo.Text + "\", \"" + txtMarca.Text + "\", \"" + txtPresupuesto.Text + "\");";
                //Ejecuta una instrucción de Transact-SQL en la conexión y devuelve el número de filas afectadas
                codigo.ExecuteNonQuery();
                //Mandamos un mensaje para decirle al usuario que se a registrado correctamente
                MessageBox.Show("Vehiculo Registrado");
                //Cerramos la conexion
                conectar.Close();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la alta del vehiculo...\n" + ex);
                return;
            }
        }

        public void Limpiar()
        {
            txtIdDueno.Clear();
            txtMatricula.Clear();
            txtModelo.Clear();
            txtMarca.Clear();
            txtPresupuesto.Clear();
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
                    codigo.CommandText = "update vehiculo set id_dueno = \"" + txtIdDueno.Text + "\", matricula = \"" +
                        txtMatricula.Text + "\", modelo = \"" + txtModelo.Text + "\", marca = \"" + txtMarca.Text + "\", presupuesto = \""
                        + txtPresupuesto.Text + "\" where id_vehiculo = \"" + txtEliModId.Text + "\";";
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
                codigo.CommandText = "select * from vehiculo;";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(codigo);
                DataTable datostabla = new DataTable();
                adaptador.Fill(datostabla);
                dGVVehiculos.DataSource = datostabla;
                conectar.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:\n\n" + ex);
            }
        }

        private void dGVVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dGVVehiculos.DefaultCellStyle.ForeColor = Color.Blue;
            this.dGVVehiculos.DefaultCellStyle.BackColor = Color.Beige;
            this.dGVVehiculos.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dGVVehiculos.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Limpiar();

            lblTitulo.Visible = true;
            lblTitulo.Text = "Registrar un vehiculo";
            lblIdDueno.Visible = true;
            lblMatricula.Visible = true;
            lblModelo.Visible = true;
            lblMarca.Visible = true;
            lblPresupuesto.Visible = true;
            lblRecordatorio.Visible = true;
            lblNota1.Visible = true;
            lblAdvertencia.Visible = false;
            lblRequisitoModificar.Visible = false;

            txtIdDueno.Visible = true;
            txtMatricula.Visible = true;
            txtModelo.Visible = true;
            txtMarca.Visible = true;
            txtPresupuesto.Visible = true;

            lblEliModId.Visible = false;
            txtEliModId.Visible = false;

            btnIngresar.Visible = true;
            btnModificacion.Visible = false;
            btnEliminacion.Visible = false;

            dGVVehiculos.Visible = false;
            pbCarro.Visible = true;
            dGVModificacion.Visible = false;
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            Limpiar();

            lblTitulo.Visible = true;
            lblTitulo.Text = "Consultar vehiculos";
            lblIdDueno.Visible = false;
            lblMatricula.Visible = false;
            lblModelo.Visible = false;
            lblMarca.Visible = false;
            lblPresupuesto.Visible = false;
            lblRecordatorio.Visible = false;
            lblNota1.Visible = false;
            lblAdvertencia.Visible = false;
            lblRequisitoModificar.Visible = false;

            txtIdDueno.Visible = false;
            txtMatricula.Visible = false;
            txtModelo.Visible = false;
            txtMarca.Visible = false;
            txtPresupuesto.Visible = false;

            lblEliModId.Visible = false;
            txtEliModId.Visible = false;

            btnIngresar.Visible = false;
            btnModificacion.Visible = false;
            btnEliminacion.Visible = false;

            dGVVehiculos.Visible = true;
            pbCarro.Visible = false;
            dGVModificacion.Visible = false;

            Consultainicial();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Limpiar();

            lblTitulo.Visible = true;
            lblTitulo.Text = "Modificar un vehiculo";
            lblIdDueno.Visible = true;
            lblMatricula.Visible = true;
            lblModelo.Visible = true;
            lblMarca.Visible = true;
            lblPresupuesto.Visible = true;
            lblRecordatorio.Visible = true;
            lblNota1.Visible = false;
            lblAdvertencia.Visible = false;
            lblRequisitoModificar.Visible = true;

            txtIdDueno.Visible = true;
            txtMatricula.Visible = true;
            txtModelo.Visible = true;
            txtMarca.Visible = true;
            txtPresupuesto.Visible = true;
            lblEliModId.Visible = true;
            txtEliModId.Visible = true;

            btnIngresar.Visible = false;
            btnModificacion.Visible = true;
            btnEliminacion.Visible = false;

            dGVVehiculos.Visible = false;
            pbCarro.Visible = false;
            dGVModificacion.Visible = true;

            ConsultaDatosModificar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Limpiar();

            lblTitulo.Visible = true;
            lblTitulo.Text = "Eliminar un vehiculo";
            lblIdDueno.Visible = false;
            lblMatricula.Visible = false;
            lblModelo.Visible = false;
            lblMarca.Visible = false;
            lblPresupuesto.Visible = false;
            lblRecordatorio.Visible = false;
            lblNota1.Visible = false;
            lblAdvertencia.Visible = true;
            lblRequisitoModificar.Visible = false;

            txtIdDueno.Visible = false;
            txtMatricula.Visible = false;
            txtModelo.Visible = false;
            txtMarca.Visible = false;
            txtPresupuesto.Visible = false;

            lblEliModId.Visible = true;
            txtEliModId.Visible = true;

            btnIngresar.Visible = false;
            btnModificacion.Visible = false;
            btnEliminacion.Visible = true;

            dGVVehiculos.Visible = false;
            pbCarro.Visible = false;
            dGVModificacion.Visible = false;
        }

        //Evento Click para poder asegurar de que se escribio en los textbox tambien para que sean iguales los correos y contras
        //Despues se va a consultar correo
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string cadena = txtIdDueno.Text;
            //nombre.Text = Convert.ToString(cadena.Length);
            if (txtIdDueno.Text == "")
            {
                MessageBox.Show("Ingrese un id de dueño!");
                txtIdDueno.Focus();
            }
            else if (txtMatricula.Text == "")
            {
                MessageBox.Show("Ingrese una matricula");
                txtMatricula.Focus();
            }
            else if (txtModelo.Text == "")
            {
                MessageBox.Show("Favor de ingresar un modelo");
                txtModelo.Focus();
            }
            else if (txtMarca.Text == "")
            {
                MessageBox.Show("Por favor ingrese la marca del vehiculo");
                txtMarca.Focus();
            }
            else if (txtPresupuesto.Text == "")
            {
                MessageBox.Show("Favor de ingresar un presupuesto");
                txtPresupuesto.Focus();
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
                codigo.CommandText = "select * from vehiculo where id_vehiculo = \"" + txtEliModId.Text + "\";";
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
                codigo.CommandText = "delete from vehiculo where id_vehiculo = \"" + txtEliModId.Text + "\";";
                codigo.ExecuteNonQuery();
                conectar.Close();
                MessageBox.Show("El vehiculo fue eliminado exitosamente");

                txtEliModId.Clear();
            }
            else
            {
                MessageBox.Show("El Id es incorrecto, intente de nuevo.");
                txtEliModId.Text = "";
                txtEliModId.Focus();
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
                codigo.CommandText = "select * from vehiculo;";
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
            txtIdDueno.Text = dGVModificacion.CurrentRow.Cells[1].Value.ToString();
            txtMatricula.Text = dGVModificacion.CurrentRow.Cells[2].Value.ToString();
            txtModelo.Text = dGVModificacion.CurrentRow.Cells[3].Value.ToString();
            txtMarca.Text = dGVModificacion.CurrentRow.Cells[4].Value.ToString();
            txtPresupuesto.Text = dGVModificacion.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
