namespace ProyectoTallerMecanico
{
    partial class frmReparaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReparaciones));
            this.plContenedorBase = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.lblRequisitoModificar = new System.Windows.Forms.Label();
            this.txtEliModId = new System.Windows.Forms.TextBox();
            this.lblEliModId = new System.Windows.Forms.Label();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.dGVReparacion = new System.Windows.Forms.DataGridView();
            this.btnEliminacion = new System.Windows.Forms.Button();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.lblRecordatorio = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtTipoReparacion = new System.Windows.Forms.TextBox();
            this.lblTipoReparacion = new System.Windows.Forms.Label();
            this.txtIdMecanico = new System.Windows.Forms.TextBox();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblIdMecanico = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dGVModificacion = new System.Windows.Forms.DataGridView();
            this.plContenedorBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVReparacion)).BeginInit();
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
            this.lblRequisitoModificar.Location = new System.Drawing.Point(400, 412);
            this.lblRequisitoModificar.Name = "lblRequisitoModificar";
            this.lblRequisitoModificar.Size = new System.Drawing.Size(437, 66);
            this.lblRequisitoModificar.TabIndex = 126;
            this.lblRequisitoModificar.Text = "*Para modificar los datos es obligatorio rellenar el Id de la reparacion";
            this.lblRequisitoModificar.Visible = false;
            // 
            // txtEliModId
            // 
            this.txtEliModId.BackColor = System.Drawing.Color.CadetBlue;
            this.txtEliModId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEliModId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEliModId.ForeColor = System.Drawing.Color.Black;
            this.txtEliModId.Location = new System.Drawing.Point(57, 437);
            this.txtEliModId.MaxLength = 40;
            this.txtEliModId.Name = "txtEliModId";
            this.txtEliModId.Size = new System.Drawing.Size(233, 22);
            this.txtEliModId.TabIndex = 124;
            this.txtEliModId.Visible = false;
            // 
            // lblEliModId
            // 
            this.lblEliModId.AutoSize = true;
            this.lblEliModId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliModId.ForeColor = System.Drawing.Color.Black;
            this.lblEliModId.Location = new System.Drawing.Point(53, 410);
            this.lblEliModId.Name = "lblEliModId";
            this.lblEliModId.Size = new System.Drawing.Size(166, 24);
            this.lblEliModId.TabIndex = 125;
            this.lblEliModId.Text = "Id de la reparacion";
            this.lblEliModId.Visible = false;
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblAdvertencia.ForeColor = System.Drawing.Color.Black;
            this.lblAdvertencia.Location = new System.Drawing.Point(52, 119);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(823, 74);
            this.lblAdvertencia.TabIndex = 123;
            this.lblAdvertencia.Text = "¿Esta seguro de que desea borrar registro de esta plataforma? Una vez eliminada n" +
    "o podrá recuperar la información que esta tenga. Para confirmar la acción, favor" +
    " de ingresar el Id.";
            this.lblAdvertencia.Visible = false;
            // 
            // dGVReparacion
            // 
            this.dGVReparacion.AllowUserToAddRows = false;
            this.dGVReparacion.AllowUserToDeleteRows = false;
            this.dGVReparacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dGVReparacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVReparacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dGVReparacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dGVReparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVReparacion.GridColor = System.Drawing.Color.BlueViolet;
            this.dGVReparacion.Location = new System.Drawing.Point(57, 119);
            this.dGVReparacion.Margin = new System.Windows.Forms.Padding(2);
            this.dGVReparacion.Name = "dGVReparacion";
            this.dGVReparacion.ReadOnly = true;
            this.dGVReparacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dGVReparacion.RowTemplate.Height = 24;
            this.dGVReparacion.Size = new System.Drawing.Size(807, 437);
            this.dGVReparacion.TabIndex = 122;
            this.dGVReparacion.Visible = false;
            this.dGVReparacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVReparacion_CellContentClick);
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
            this.btnEliminacion.Location = new System.Drawing.Point(317, 504);
            this.btnEliminacion.Name = "btnEliminacion";
            this.btnEliminacion.Size = new System.Drawing.Size(370, 52);
            this.btnEliminacion.TabIndex = 121;
            this.btnEliminacion.Text = "Borrar reparacion";
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
            this.btnModificacion.Location = new System.Drawing.Point(317, 504);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(370, 52);
            this.btnModificacion.TabIndex = 120;
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
            this.lblRecordatorio.Location = new System.Drawing.Point(540, 233);
            this.lblRecordatorio.Name = "lblRecordatorio";
            this.lblRecordatorio.Size = new System.Drawing.Size(164, 31);
            this.lblRecordatorio.TabIndex = 114;
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
            this.btnIngresar.Location = new System.Drawing.Point(317, 504);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(370, 52);
            this.btnIngresar.TabIndex = 118;
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
            this.lblNota1.Location = new System.Drawing.Point(400, 271);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(343, 24);
            this.lblNota1.TabIndex = 115;
            this.lblNota1.Text = "*Todos los campos son obligatorios";
            this.lblNota1.Visible = false;
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNota3.ForeColor = System.Drawing.Color.Black;
            this.lblNota3.Location = new System.Drawing.Point(400, 360);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(483, 24);
            this.lblNota3.TabIndex = 117;
            this.lblNota3.Text = "*No más de 60 caracteres al escribir el tipo de rep.";
            this.lblNota3.Visible = false;
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.CadetBlue;
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.ForeColor = System.Drawing.Color.Black;
            this.txtFecha.Location = new System.Drawing.Point(53, 364);
            this.txtFecha.MaxLength = 20;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(233, 22);
            this.txtFecha.TabIndex = 106;
            this.txtFecha.Visible = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(48, 337);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(186, 24);
            this.lblFecha.TabIndex = 111;
            this.lblFecha.Text = "Fecha de reparacion";
            this.lblFecha.Visible = false;
            // 
            // txtTipoReparacion
            // 
            this.txtTipoReparacion.BackColor = System.Drawing.Color.CadetBlue;
            this.txtTipoReparacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipoReparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoReparacion.ForeColor = System.Drawing.Color.Black;
            this.txtTipoReparacion.Location = new System.Drawing.Point(52, 296);
            this.txtTipoReparacion.MaxLength = 20;
            this.txtTipoReparacion.Name = "txtTipoReparacion";
            this.txtTipoReparacion.Size = new System.Drawing.Size(233, 22);
            this.txtTipoReparacion.TabIndex = 105;
            this.txtTipoReparacion.Visible = false;
            // 
            // lblTipoReparacion
            // 
            this.lblTipoReparacion.AutoSize = true;
            this.lblTipoReparacion.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoReparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoReparacion.ForeColor = System.Drawing.Color.Black;
            this.lblTipoReparacion.Location = new System.Drawing.Point(49, 269);
            this.lblTipoReparacion.Name = "lblTipoReparacion";
            this.lblTipoReparacion.Size = new System.Drawing.Size(170, 24);
            this.lblTipoReparacion.TabIndex = 110;
            this.lblTipoReparacion.Text = "Tipo de reparacion";
            this.lblTipoReparacion.Visible = false;
            // 
            // txtIdMecanico
            // 
            this.txtIdMecanico.BackColor = System.Drawing.Color.CadetBlue;
            this.txtIdMecanico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdMecanico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMecanico.ForeColor = System.Drawing.Color.Black;
            this.txtIdMecanico.Location = new System.Drawing.Point(53, 231);
            this.txtIdMecanico.MaxLength = 30;
            this.txtIdMecanico.Name = "txtIdMecanico";
            this.txtIdMecanico.Size = new System.Drawing.Size(236, 22);
            this.txtIdMecanico.TabIndex = 104;
            this.txtIdMecanico.Visible = false;
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNota2.ForeColor = System.Drawing.Color.Black;
            this.lblNota2.Location = new System.Drawing.Point(400, 314);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(327, 24);
            this.lblNota2.TabIndex = 116;
            this.lblNota2.Text = "*Utilizar identificador de mecanico";
            this.lblNota2.Visible = false;
            // 
            // lblIdMecanico
            // 
            this.lblIdMecanico.AutoSize = true;
            this.lblIdMecanico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMecanico.ForeColor = System.Drawing.Color.Black;
            this.lblIdMecanico.Location = new System.Drawing.Point(49, 204);
            this.lblIdMecanico.Name = "lblIdMecanico";
            this.lblIdMecanico.Size = new System.Drawing.Size(113, 24);
            this.lblIdMecanico.TabIndex = 109;
            this.lblIdMecanico.Text = "Id mecanico";
            this.lblIdMecanico.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(233, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(505, 50);
            this.lblTitulo.TabIndex = 119;
            this.lblTitulo.Text = "Registrar una reparacion";
            this.lblTitulo.Visible = false;
            // 
            // dGVModificacion
            // 
            this.dGVModificacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dGVModificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVModificacion.Location = new System.Drawing.Point(327, 119);
            this.dGVModificacion.Name = "dGVModificacion";
            this.dGVModificacion.ReadOnly = true;
            this.dGVModificacion.Size = new System.Drawing.Size(537, 111);
            this.dGVModificacion.TabIndex = 128;
            this.dGVModificacion.Visible = false;
            this.dGVModificacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVModificacion_CellContentClick);
            // 
            // frmReparaciones
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
            this.Controls.Add(this.dGVReparacion);
            this.Controls.Add(this.btnEliminacion);
            this.Controls.Add(this.btnModificacion);
            this.Controls.Add(this.lblRecordatorio);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtTipoReparacion);
            this.Controls.Add(this.lblTipoReparacion);
            this.Controls.Add(this.txtIdMecanico);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblIdMecanico);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.plContenedorBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReparaciones";
            this.Text = "Reparaciones";
            this.plContenedorBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVReparacion)).EndInit();
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
        private System.Windows.Forms.DataGridView dGVReparacion;
        private System.Windows.Forms.Button btnEliminacion;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Label lblRecordatorio;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtTipoReparacion;
        private System.Windows.Forms.Label lblTipoReparacion;
        private System.Windows.Forms.TextBox txtIdMecanico;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblIdMecanico;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dGVModificacion;
    }
}