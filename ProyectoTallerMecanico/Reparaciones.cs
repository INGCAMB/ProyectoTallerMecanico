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
    public partial class frmReparaciones : Form
    {
        public frmReparaciones()
        {
            InitializeComponent();
            //Dos listas para poder guardar la textbox y la string que guardara la textbox
            List<TextBox> tList = new List<TextBox>();
            List<string> sList = new List<string>();
            tList.Add(txtFecha);
            sList.Add("2020-04-25 AAAA-MM-DD");
            SetCueBanner(ref tList, sList);

            if (VariablesGlobales.UsuarioAdministrador == true)
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
            }
        }

        //Dll para poder usar hint en los textbox
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr i, string str);

        //Metodo para poder quitar o poner el texto de marca de agua
        void SetCueBanner(ref List<TextBox> textBox, List<string> CueText)
        {
            for (int x = 0; x < textBox.Count; x++)
            {
                SendMessage(textBox[x].Handle, 0x1501, (IntPtr)1, CueText[x]);
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Limpiar();

            lblTitulo.Visible = true;
            lblTitulo.Text = "Registrar una reparacion";
            lblIdMecanico.Visible = true;
            lblTipoReparacion.Visible = true;
            lblFecha.Visible = true;
            lblRecordatorio.Visible = true;
            lblNota1.Visible = true;
            lblNota2.Visible = true;
            lblNota3.Visible = true;
            lblAdvertencia.Visible = false;
            lblRequisitoModificar.Visible = false;

            txtIdMecanico.Visible = true;
            txtTipoReparacion.Visible = true;
            txtFecha.Visible = true;

            lblEliModId.Visible = false;
            txtEliModId.Visible = false;

            btnIngresar.Visible = true;
            btnModificacion.Visible = false;
            btnEliminacion.Visible = false;

            dGVReparacion.Visible = false;
            dGVModificacion.Visible = false;
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            Limpiar();

            lblTitulo.Visible = true;
            lblTitulo.Text = "Consultar reparaciones";
            lblIdMecanico.Visible = false;
            lblTipoReparacion.Visible = false;
            lblFecha.Visible = false;
            lblRecordatorio.Visible = false;
            lblNota1.Visible = false;
            lblNota2.Visible = false;
            lblNota3.Visible = false;
            lblAdvertencia.Visible = false;
            lblRequisitoModificar.Visible = false;

            txtIdMecanico.Visible = false;
            txtTipoReparacion.Visible = false;
            txtFecha.Visible = false;

            lblEliModId.Visible = false;
            txtEliModId.Visible = false;

            btnIngresar.Visible = false;
            btnModificacion.Visible = false;
            btnEliminacion.Visible = false;

            dGVReparacion.Visible = true;
            dGVModificacion.Visible = false;

            Consultainicial();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Limpiar();

            lblTitulo.Visible = true;
            lblTitulo.Text = "Modificar una reparacion";
            lblIdMecanico.Visible = true;
            lblTipoReparacion.Visible = true;
            lblFecha.Visible = true;
            lblRecordatorio.Visible = true;
            lblNota1.Visible = false;
            lblNota2.Visible = true;
            lblNota3.Visible = true;
            lblAdvertencia.Visible = false;
            lblRequisitoModificar.Visible = true;

            txtIdMecanico.Visible = true;
            txtTipoReparacion.Visible = true;
            txtFecha.Visible = true;

            lblEliModId.Visible = true;
            txtEliModId.Visible = true;

            btnIngresar.Visible = false;
            btnModificacion.Visible = true;
            btnEliminacion.Visible = false;

            dGVReparacion.Visible = false;
            dGVModificacion.Visible = true;

            lblEliModId.Location = new Point(53, 410);
            txtEliModId.Location = new Point(57, 437);

            ConsultaDatosModificar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Limpiar();

            lblTitulo.Visible = true;
            lblTitulo.Text = "Eliminar una reparacion";
            lblIdMecanico.Visible = false;
            lblTipoReparacion.Visible = false;
            lblFecha.Visible = false;
            lblRecordatorio.Visible = false;
            lblNota1.Visible = false;
            lblNota2.Visible = false;
            lblNota3.Visible = false;
            lblAdvertencia.Visible = true;
            lblRequisitoModificar.Visible = false;

            txtIdMecanico.Visible = false;
            txtTipoReparacion.Visible = false;
            txtFecha.Visible = false;

            lblEliModId.Visible = true;
            txtEliModId.Visible = true;

            btnIngresar.Visible = false;
            btnModificacion.Visible = false;
            btnEliminacion.Visible = true;

            dGVReparacion.Visible = false;
            dGVModificacion.Visible = false;

            lblEliModId.Location = new Point(351, 320);
            txtEliModId.Location = new Point(355, 347);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string cadena = txtIdMecanico.Text;
            //nombre.Text = Convert.ToString(cadena.Length);
            if (txtIdMecanico.Text == "")
            {
                MessageBox.Show("Ingrese un identificador del mecanico");
                txtIdMecanico.Focus();
            }
            else if (txtTipoReparacion.Text == "")
            {
                MessageBox.Show("Ingrese un tipo de reparacion");
                txtTipoReparacion.Focus();
            }
            else if (txtFecha.Text == "")
            {
                MessageBox.Show("Favor de ingresar una fecha");
                txtFecha.Focus();
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
                codigo.CommandText = "select * from reparacion where id_reparacion = \"" + txtEliModId.Text + "\";";
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
                codigo.CommandText = "delete from reparacion where id_reparacion = \"" + txtEliModId.Text + "\";";
                codigo.ExecuteNonQuery();
                conectar.Close();
                MessageBox.Show("La reparacion fue eliminado exitosamente");

                txtEliModId.Clear();
            }
            else
            {
                MessageBox.Show("El Id es incorrecto, intente de nuevo.");
                txtEliModId.Text = "";
                txtEliModId.Focus();
            }
        }

        private void dGVReparacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dGVReparacion.DefaultCellStyle.ForeColor = Color.Blue;
            this.dGVReparacion.DefaultCellStyle.BackColor = Color.Beige;
            this.dGVReparacion.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            this.dGVReparacion.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
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
                codigo.CommandText = "insert into reparacion (id_mecanico, tipo_reparacion, fecha) values (" + "\"" + txtIdMecanico.Text + "\", \"" +
                    txtTipoReparacion.Text + "\", \"" + txtFecha.Text + "\");";
                //Ejecuta una instrucción de Transact-SQL en la conexión y devuelve el número de filas afectadas
                codigo.ExecuteNonQuery();
                //Mandamos un mensaje para decirle al usuario que se a registrado correctamente
                MessageBox.Show("Reparacion Registrada");
                //Cerramos la conexion
                conectar.Close();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la alta de la reparacion...\n" + ex);
                return;
            }
        }

        public void Limpiar()
        {
            txtIdMecanico.Clear();
            txtTipoReparacion.Clear();
            txtFecha.Clear();
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
                    codigo.CommandText = "update reparacion set id_mecanico = \"" + txtIdMecanico.Text + "\", tipo_reparacion = \"" +
                        txtTipoReparacion.Text + "\", fecha = \"" + txtFecha.Text + "\" where id_reparacion = \"" + txtEliModId.Text + "\";";
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
                codigo.CommandText = "select * from reparacion;";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(codigo);
                DataTable datostabla = new DataTable();
                adaptador.Fill(datostabla);
                dGVReparacion.DataSource = datostabla;
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
            txtIdMecanico.Text = dGVModificacion.CurrentRow.Cells[1].Value.ToString();
            txtTipoReparacion.Text = dGVModificacion.CurrentRow.Cells[2].Value.ToString();
            txtFecha.Text = dGVModificacion.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
