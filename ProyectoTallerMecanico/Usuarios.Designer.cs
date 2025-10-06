namespace ProyectoTallerMecanico
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.plContenedorBase = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.lblRequisitoModificar = new System.Windows.Forms.Label();
            this.txtEliModId = new System.Windows.Forms.TextBox();
            this.lblEliModId = new System.Windows.Forms.Label();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.dGVUsuarios = new System.Windows.Forms.DataGridView();
            this.btnEliminacion = new System.Windows.Forms.Button();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.lblRecordatorio = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dGVModificacion = new System.Windows.Forms.DataGridView();
            this.plContenedorBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUsuarios)).BeginInit();
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
            this.plContenedorBase.TabIndex = 22;
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
            this.lblRequisitoModificar.Location = new System.Drawing.Point(404, 401);
            this.lblRequisitoModificar.Name = "lblRequisitoModificar";
            this.lblRequisitoModificar.Size = new System.Drawing.Size(437, 66);
            this.lblRequisitoModificar.TabIndex = 120;
            this.lblRequisitoModificar.Text = "*Para modificar los datos es obligatorio rellenar el Id del usuario";
            this.lblRequisitoModificar.Visible = false;
            // 
            // txtEliModId
            // 
            this.txtEliModId.BackColor = System.Drawing.Color.CadetBlue;
            this.txtEliModId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEliModId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEliModId.ForeColor = System.Drawing.Color.Black;
            this.txtEliModId.Location = new System.Drawing.Point(42, 354);
            this.txtEliModId.MaxLength = 40;
            this.txtEliModId.Name = "txtEliModId";
            this.txtEliModId.Size = new System.Drawing.Size(233, 22);
            this.txtEliModId.TabIndex = 118;
            this.txtEliModId.Visible = false;
            // 
            // lblEliModId
            // 
            this.lblEliModId.AutoSize = true;
            this.lblEliModId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliModId.ForeColor = System.Drawing.Color.Black;
            this.lblEliModId.Location = new System.Drawing.Point(38, 327);
            this.lblEliModId.Name = "lblEliModId";
            this.lblEliModId.Size = new System.Drawing.Size(123, 24);
            this.lblEliModId.TabIndex = 119;
            this.lblEliModId.Text = "Id del usuario";
            this.lblEliModId.Visible = false;
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblAdvertencia.ForeColor = System.Drawing.Color.Black;
            this.lblAdvertencia.Location = new System.Drawing.Point(38, 120);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(834, 89);
            this.lblAdvertencia.TabIndex = 117;
            this.lblAdvertencia.Text = "¿Esta seguro de que desea borrar registro de esta plataforma? Una vez eliminada n" +
    "o podrá recuperar la información que esta tenga. Para confirmar la acción, favor" +
    " de ingresar el Id.";
            this.lblAdvertencia.Visible = false;
            // 
            // dGVUsuarios
            // 
            this.dGVUsuarios.AllowUserToAddRows = false;
            this.dGVUsuarios.AllowUserToDeleteRows = false;
            this.dGVUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dGVUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dGVUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVUsuarios.GridColor = System.Drawing.Color.BlueViolet;
            this.dGVUsuarios.Location = new System.Drawing.Point(39, 120);
            this.dGVUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dGVUsuarios.Name = "dGVUsuarios";
            this.dGVUsuarios.ReadOnly = true;
            this.dGVUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dGVUsuarios.RowTemplate.Height = 24;
            this.dGVUsuarios.Size = new System.Drawing.Size(833, 450);
            this.dGVUsuarios.TabIndex = 116;
            this.dGVUsuarios.Visible = false;
            this.dGVUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVUsuarios_CellContentClick);
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
            this.btnEliminacion.Location = new System.Drawing.Point(314, 505);
            this.btnEliminacion.Name = "btnEliminacion";
            this.btnEliminacion.Size = new System.Drawing.Size(370, 52);
            this.btnEliminacion.TabIndex = 115;
            this.btnEliminacion.Text = "Borrar usuario";
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
            this.btnModificacion.Location = new System.Drawing.Point(314, 505);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(370, 52);
            this.btnModificacion.TabIndex = 114;
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
            this.lblRecordatorio.Location = new System.Drawing.Point(565, 223);
            this.lblRecordatorio.Name = "lblRecordatorio";
            this.lblRecordatorio.Size = new System.Drawing.Size(164, 31);
            this.lblRecordatorio.TabIndex = 108;
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
            this.btnIngresar.Location = new System.Drawing.Point(314, 505);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(370, 52);
            this.btnIngresar.TabIndex = 112;
            this.btnIngresar.Text = "Registrar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Visible = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota1.ForeColor = System.Drawing.Color.Black;
            this.lblNota1.Location = new System.Drawing.Point(404, 261);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(343, 24);
            this.lblNota1.TabIndex = 109;
            this.lblNota1.Text = "*Todos los campos son obligatorios";
            this.lblNota1.Visible = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.CadetBlue;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.Black;
            this.txtCorreo.Location = new System.Drawing.Point(38, 277);
            this.txtCorreo.MaxLength = 40;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(233, 22);
            this.txtCorreo.TabIndex = 103;
            this.txtCorreo.Visible = false;
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNota3.ForeColor = System.Drawing.Color.Black;
            this.lblNota3.Location = new System.Drawing.Point(404, 350);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(437, 24);
            this.lblNota3.TabIndex = 111;
            this.lblNota3.Text = "*No más de 50 caracteres al escribir el correo";
            this.lblNota3.Visible = false;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.Black;
            this.lblCorreo.Location = new System.Drawing.Point(34, 250);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(167, 24);
            this.lblCorreo.TabIndex = 107;
            this.lblCorreo.Text = "Dirección de email";
            this.lblCorreo.Visible = false;
            // 
            // txtContra
            // 
            this.txtContra.BackColor = System.Drawing.Color.CadetBlue;
            this.txtContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.ForeColor = System.Drawing.Color.Black;
            this.txtContra.Location = new System.Drawing.Point(38, 212);
            this.txtContra.MaxLength = 20;
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(233, 22);
            this.txtContra.TabIndex = 101;
            this.txtContra.Visible = false;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.BackColor = System.Drawing.Color.Transparent;
            this.lblContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.ForeColor = System.Drawing.Color.Black;
            this.lblContra.Location = new System.Drawing.Point(35, 185);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(106, 24);
            this.lblContra.TabIndex = 105;
            this.lblContra.Text = "Contraseña";
            this.lblContra.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.CadetBlue;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(39, 147);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(236, 22);
            this.txtNombre.TabIndex = 100;
            this.txtNombre.Visible = false;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNota2.ForeColor = System.Drawing.Color.Black;
            this.lblNota2.Location = new System.Drawing.Point(404, 304);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(448, 24);
            this.lblNota2.TabIndex = 110;
            this.lblNota2.Text = "*No más de 50 caracteres al escribir el nombre";
            this.lblNota2.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(35, 120);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(177, 24);
            this.lblNombre.TabIndex = 104;
            this.lblNombre.Text = "Nombre del usuario";
            this.lblNombre.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(262, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(422, 50);
            this.lblTitulo.TabIndex = 113;
            this.lblTitulo.Text = "Registrar un usuario";
            this.lblTitulo.Visible = false;
            // 
            // dGVModificacion
            // 
            this.dGVModificacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dGVModificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVModificacion.Location = new System.Drawing.Point(326, 120);
            this.dGVModificacion.Name = "dGVModificacion";
            this.dGVModificacion.ReadOnly = true;
            this.dGVModificacion.Size = new System.Drawing.Size(546, 89);
            this.dGVModificacion.TabIndex = 121;
            this.dGVModificacion.Visible = false;
            this.dGVModificacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVModificacion_CellContentClick);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.dGVModificacion);
            this.Controls.Add(this.lblRequisitoModificar);
            this.Controls.Add(this.txtEliModId);
            this.Controls.Add(this.lblEliModId);
            this.Controls.Add(this.lblAdvertencia);
            this.Controls.Add(this.dGVUsuarios);
            this.Controls.Add(this.btnEliminacion);
            this.Controls.Add(this.btnModificacion);
            this.Controls.Add(this.lblRecordatorio);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.plContenedorBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsuarios";
            this.Text = "Usuarios";
            this.plContenedorBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVUsuarios)).EndInit();
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
        private System.Windows.Forms.DataGridView dGVUsuarios;
        private System.Windows.Forms.Button btnEliminacion;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Label lblRecordatorio;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dGVModificacion;
    }
}