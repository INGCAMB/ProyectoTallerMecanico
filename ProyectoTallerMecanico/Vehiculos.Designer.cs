namespace ProyectoTallerMecanico
{
    partial class frmVehiculos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehiculos));
            this.plContenedorBase = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.lblRequisitoModificar = new System.Windows.Forms.Label();
            this.txtEliModId = new System.Windows.Forms.TextBox();
            this.lblEliModId = new System.Windows.Forms.Label();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.dGVVehiculos = new System.Windows.Forms.DataGridView();
            this.btnEliminacion = new System.Windows.Forms.Button();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.lblRecordatorio = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.txtPresupuesto = new System.Windows.Forms.TextBox();
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtIdDueno = new System.Windows.Forms.TextBox();
            this.lblIdDueno = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbCarro = new System.Windows.Forms.PictureBox();
            this.dGVModificacion = new System.Windows.Forms.DataGridView();
            this.plContenedorBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVModificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // plContenedorBase
            // 
            this.plContenedorBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plContenedorBase.Controls.Add(this.btnEliminar);
            this.plContenedorBase.Controls.Add(this.btnModificar);
            this.plContenedorBase.Controls.Add(this.btnConsultas);
            this.plContenedorBase.Controls.Add(this.btnRegistro);
            this.plContenedorBase.Location = new System.Drawing.Point(920, 0);
            this.plContenedorBase.Name = "plContenedorBase";
            this.plContenedorBase.Size = new System.Drawing.Size(160, 612);
            this.plContenedorBase.TabIndex = 20;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImage = global::ProyectoTallerMecanico.Properties.Resources.borrar;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(48, 451);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(67, 59);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BackgroundImage = global::ProyectoTallerMecanico.Properties.Resources.modificar;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(48, 337);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(67, 59);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultas.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultas.BackgroundImage = global::ProyectoTallerMecanico.Properties.Resources.consultas;
            this.btnConsultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnConsultas.ForeColor = System.Drawing.Color.White;
            this.btnConsultas.Location = new System.Drawing.Point(48, 223);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(67, 59);
            this.btnConsultas.TabIndex = 1;
            this.btnConsultas.UseVisualStyleBackColor = false;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistro.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistro.BackgroundImage = global::ProyectoTallerMecanico.Properties.Resources.registrar;
            this.btnRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnRegistro.ForeColor = System.Drawing.Color.White;
            this.btnRegistro.Location = new System.Drawing.Point(48, 104);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(67, 59);
            this.btnRegistro.TabIndex = 0;
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // lblRequisitoModificar
            // 
            this.lblRequisitoModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequisitoModificar.ForeColor = System.Drawing.Color.Black;
            this.lblRequisitoModificar.Location = new System.Drawing.Point(19, 331);
            this.lblRequisitoModificar.Name = "lblRequisitoModificar";
            this.lblRequisitoModificar.Size = new System.Drawing.Size(229, 96);
            this.lblRequisitoModificar.TabIndex = 72;
            this.lblRequisitoModificar.Text = "*Para modificar los datos es obligatorio rellenar el Id del vehiculo";
            this.lblRequisitoModificar.Visible = false;
            // 
            // txtEliModId
            // 
            this.txtEliModId.BackColor = System.Drawing.Color.CadetBlue;
            this.txtEliModId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEliModId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEliModId.ForeColor = System.Drawing.Color.Black;
            this.txtEliModId.Location = new System.Drawing.Point(316, 277);
            this.txtEliModId.MaxLength = 40;
            this.txtEliModId.Name = "txtEliModId";
            this.txtEliModId.Size = new System.Drawing.Size(233, 22);
            this.txtEliModId.TabIndex = 70;
            this.txtEliModId.Visible = false;
            // 
            // lblEliModId
            // 
            this.lblEliModId.AutoSize = true;
            this.lblEliModId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliModId.ForeColor = System.Drawing.Color.Black;
            this.lblEliModId.Location = new System.Drawing.Point(312, 250);
            this.lblEliModId.Name = "lblEliModId";
            this.lblEliModId.Size = new System.Drawing.Size(132, 24);
            this.lblEliModId.TabIndex = 71;
            this.lblEliModId.Text = "Id del vehiculo";
            this.lblEliModId.Visible = false;
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblAdvertencia.ForeColor = System.Drawing.Color.Black;
            this.lblAdvertencia.Location = new System.Drawing.Point(63, 109);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(783, 77);
            this.lblAdvertencia.TabIndex = 69;
            this.lblAdvertencia.Text = "¿Esta seguro de que desea borrar registro de esta plataforma? Una vez eliminada n" +
    "o podrá recuperar la información que esta tenga. Para confirmar la acción, favor" +
    " de ingresar el Id.";
            this.lblAdvertencia.Visible = false;
            // 
            // dGVVehiculos
            // 
            this.dGVVehiculos.AllowUserToAddRows = false;
            this.dGVVehiculos.AllowUserToDeleteRows = false;
            this.dGVVehiculos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dGVVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVVehiculos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dGVVehiculos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dGVVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVVehiculos.GridColor = System.Drawing.Color.BlueViolet;
            this.dGVVehiculos.Location = new System.Drawing.Point(67, 109);
            this.dGVVehiculos.Margin = new System.Windows.Forms.Padding(2);
            this.dGVVehiculos.Name = "dGVVehiculos";
            this.dGVVehiculos.ReadOnly = true;
            this.dGVVehiculos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dGVVehiculos.RowTemplate.Height = 24;
            this.dGVVehiculos.Size = new System.Drawing.Size(779, 454);
            this.dGVVehiculos.TabIndex = 68;
            this.dGVVehiculos.Visible = false;
            this.dGVVehiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVVehiculos_CellContentClick);
            // 
            // btnEliminacion
            // 
            this.btnEliminacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEliminacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminacion.FlatAppearance.BorderSize = 0;
            this.btnEliminacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminacion.ForeColor = System.Drawing.Color.White;
            this.btnEliminacion.Location = new System.Drawing.Point(241, 388);
            this.btnEliminacion.Name = "btnEliminacion";
            this.btnEliminacion.Size = new System.Drawing.Size(370, 52);
            this.btnEliminacion.TabIndex = 67;
            this.btnEliminacion.Text = "Borrar vehiculo";
            this.btnEliminacion.UseVisualStyleBackColor = false;
            this.btnEliminacion.Visible = false;
            this.btnEliminacion.Click += new System.EventHandler(this.btnEliminacion_Click);
            // 
            // btnModificacion
            // 
            this.btnModificacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnModificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModificacion.FlatAppearance.BorderSize = 0;
            this.btnModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificacion.ForeColor = System.Drawing.Color.White;
            this.btnModificacion.Location = new System.Drawing.Point(367, 484);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(370, 52);
            this.btnModificacion.TabIndex = 66;
            this.btnModificacion.Text = "Aceptar";
            this.btnModificacion.UseVisualStyleBackColor = false;
            this.btnModificacion.Visible = false;
            this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click);
            // 
            // lblRecordatorio
            // 
            this.lblRecordatorio.AutoSize = true;
            this.lblRecordatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordatorio.ForeColor = System.Drawing.Color.Firebrick;
            this.lblRecordatorio.Location = new System.Drawing.Point(57, 199);
            this.lblRecordatorio.Name = "lblRecordatorio";
            this.lblRecordatorio.Size = new System.Drawing.Size(164, 31);
            this.lblRecordatorio.TabIndex = 60;
            this.lblRecordatorio.Text = "*Recuerda*";
            this.lblRecordatorio.Visible = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(367, 484);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(370, 52);
            this.btnIngresar.TabIndex = 64;
            this.btnIngresar.Text = "Registrar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Visible = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblNota1
            // 
            this.lblNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota1.ForeColor = System.Drawing.Color.Black;
            this.lblNota1.Location = new System.Drawing.Point(19, 250);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(241, 56);
            this.lblNota1.TabIndex = 61;
            this.lblNota1.Text = "*Todos los campos son obligatorios";
            this.lblNota1.Visible = false;
            // 
            // txtPresupuesto
            // 
            this.txtPresupuesto.BackColor = System.Drawing.Color.CadetBlue;
            this.txtPresupuesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresupuesto.ForeColor = System.Drawing.Color.Black;
            this.txtPresupuesto.Location = new System.Drawing.Point(595, 405);
            this.txtPresupuesto.MaxLength = 40;
            this.txtPresupuesto.Name = "txtPresupuesto";
            this.txtPresupuesto.Size = new System.Drawing.Size(233, 22);
            this.txtPresupuesto.TabIndex = 54;
            this.txtPresupuesto.Visible = false;
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresupuesto.ForeColor = System.Drawing.Color.Black;
            this.lblPresupuesto.Location = new System.Drawing.Point(592, 378);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(116, 24);
            this.lblPresupuesto.TabIndex = 59;
            this.lblPresupuesto.Text = "Presupuesto";
            this.lblPresupuesto.Visible = false;
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.CadetBlue;
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.ForeColor = System.Drawing.Color.Black;
            this.txtMarca.Location = new System.Drawing.Point(595, 339);
            this.txtMarca.MaxLength = 40;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(233, 22);
            this.txtMarca.TabIndex = 53;
            this.txtMarca.Visible = false;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.Black;
            this.lblMarca.Location = new System.Drawing.Point(591, 312);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(62, 24);
            this.lblMarca.TabIndex = 58;
            this.lblMarca.Text = "Marca";
            this.lblMarca.Visible = false;
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.Color.CadetBlue;
            this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.ForeColor = System.Drawing.Color.Black;
            this.txtModelo.Location = new System.Drawing.Point(596, 277);
            this.txtModelo.MaxLength = 20;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(233, 22);
            this.txtModelo.TabIndex = 52;
            this.txtModelo.Visible = false;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.Black;
            this.lblModelo.Location = new System.Drawing.Point(591, 250);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(74, 24);
            this.lblModelo.TabIndex = 57;
            this.lblModelo.Text = "Modelo";
            this.lblModelo.Visible = false;
            // 
            // txtMatricula
            // 
            this.txtMatricula.BackColor = System.Drawing.Color.CadetBlue;
            this.txtMatricula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.ForeColor = System.Drawing.Color.Black;
            this.txtMatricula.Location = new System.Drawing.Point(315, 405);
            this.txtMatricula.MaxLength = 20;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(233, 22);
            this.txtMatricula.TabIndex = 51;
            this.txtMatricula.Visible = false;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.BackColor = System.Drawing.Color.Transparent;
            this.lblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.ForeColor = System.Drawing.Color.Black;
            this.lblMatricula.Location = new System.Drawing.Point(312, 378);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(85, 24);
            this.lblMatricula.TabIndex = 56;
            this.lblMatricula.Text = "Matricula";
            this.lblMatricula.Visible = false;
            // 
            // txtIdDueno
            // 
            this.txtIdDueno.BackColor = System.Drawing.Color.CadetBlue;
            this.txtIdDueno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdDueno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDueno.ForeColor = System.Drawing.Color.Black;
            this.txtIdDueno.Location = new System.Drawing.Point(316, 340);
            this.txtIdDueno.MaxLength = 30;
            this.txtIdDueno.Name = "txtIdDueno";
            this.txtIdDueno.Size = new System.Drawing.Size(236, 22);
            this.txtIdDueno.TabIndex = 50;
            this.txtIdDueno.Visible = false;
            // 
            // lblIdDueno
            // 
            this.lblIdDueno.AutoSize = true;
            this.lblIdDueno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDueno.ForeColor = System.Drawing.Color.Black;
            this.lblIdDueno.Location = new System.Drawing.Point(312, 313);
            this.lblIdDueno.Name = "lblIdDueno";
            this.lblIdDueno.Size = new System.Drawing.Size(85, 24);
            this.lblIdDueno.TabIndex = 55;
            this.lblIdDueno.Text = "Id dueño";
            this.lblIdDueno.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(281, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(440, 50);
            this.lblTitulo.TabIndex = 65;
            this.lblTitulo.Text = "Registrar un vehiculo";
            this.lblTitulo.Visible = false;
            // 
            // pbCarro
            // 
            this.pbCarro.BackColor = System.Drawing.Color.Transparent;
            this.pbCarro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCarro.BackgroundImage")));
            this.pbCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCarro.Location = new System.Drawing.Point(367, 192);
            this.pbCarro.Name = "pbCarro";
            this.pbCarro.Size = new System.Drawing.Size(141, 107);
            this.pbCarro.TabIndex = 73;
            this.pbCarro.TabStop = false;
            this.pbCarro.Visible = false;
            // 
            // dGVModificacion
            // 
            this.dGVModificacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dGVModificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVModificacion.Location = new System.Drawing.Point(279, 104);
            this.dGVModificacion.Name = "dGVModificacion";
            this.dGVModificacion.ReadOnly = true;
            this.dGVModificacion.Size = new System.Drawing.Size(567, 126);
            this.dGVModificacion.TabIndex = 123;
            this.dGVModificacion.Visible = false;
            this.dGVModificacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVModificacion_CellContentClick);
            // 
            // frmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.dGVModificacion);
            this.Controls.Add(this.pbCarro);
            this.Controls.Add(this.lblRequisitoModificar);
            this.Controls.Add(this.txtEliModId);
            this.Controls.Add(this.lblEliModId);
            this.Controls.Add(this.lblAdvertencia);
            this.Controls.Add(this.dGVVehiculos);
            this.Controls.Add(this.btnEliminacion);
            this.Controls.Add(this.btnModificacion);
            this.Controls.Add(this.lblRecordatorio);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.txtPresupuesto);
            this.Controls.Add(this.lblPresupuesto);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.txtIdDueno);
            this.Controls.Add(this.lblIdDueno);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.plContenedorBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVehiculos";
            this.Text = "Vehiculos";
            this.plContenedorBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVModificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plContenedorBase;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Label lblRequisitoModificar;
        private System.Windows.Forms.TextBox txtEliModId;
        private System.Windows.Forms.Label lblEliModId;
        private System.Windows.Forms.Label lblAdvertencia;
        private System.Windows.Forms.DataGridView dGVVehiculos;
        private System.Windows.Forms.Button btnEliminacion;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Label lblRecordatorio;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.TextBox txtPresupuesto;
        private System.Windows.Forms.Label lblPresupuesto;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtIdDueno;
        private System.Windows.Forms.Label lblIdDueno;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbCarro;
        private System.Windows.Forms.DataGridView dGVModificacion;
    }
}