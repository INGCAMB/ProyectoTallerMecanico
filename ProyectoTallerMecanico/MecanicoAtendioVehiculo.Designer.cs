namespace ProyectoTallerMecanico
{
    partial class frmMecanicoAtendioVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMecanicoAtendioVehiculo));
            this.plContenedorBase = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.lblRequisitoModificar = new System.Windows.Forms.Label();
            this.txtEliModId = new System.Windows.Forms.TextBox();
            this.lblEliModId = new System.Windows.Forms.Label();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.dGVMecanico = new System.Windows.Forms.DataGridView();
            this.btnEliminacion = new System.Windows.Forms.Button();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.lblRecordatorio = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIdVehiculo = new System.Windows.Forms.TextBox();
            this.lblIdVehiculo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dGVModificacion = new System.Windows.Forms.DataGridView();
            this.plContenedorBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMecanico)).BeginInit();
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
            this.lblRequisitoModificar.Location = new System.Drawing.Point(42, 403);
            this.lblRequisitoModificar.Name = "lblRequisitoModificar";
            this.lblRequisitoModificar.Size = new System.Drawing.Size(205, 103);
            this.lblRequisitoModificar.TabIndex = 126;
            this.lblRequisitoModificar.Text = "*Para modificar los datos es obligatorio rellenar el Id del mecanico";
            this.lblRequisitoModificar.Visible = false;
            // 
            // txtEliModId
            // 
            this.txtEliModId.BackColor = System.Drawing.Color.CadetBlue;
            this.txtEliModId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEliModId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEliModId.ForeColor = System.Drawing.Color.Black;
            this.txtEliModId.Location = new System.Drawing.Point(384, 250);
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
            this.lblEliModId.Location = new System.Drawing.Point(380, 223);
            this.lblEliModId.Name = "lblEliModId";
            this.lblEliModId.Size = new System.Drawing.Size(144, 24);
            this.lblEliModId.TabIndex = 125;
            this.lblEliModId.Text = "Id del mecanico";
            this.lblEliModId.Visible = false;
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblAdvertencia.ForeColor = System.Drawing.Color.Black;
            this.lblAdvertencia.Location = new System.Drawing.Point(56, 121);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(820, 77);
            this.lblAdvertencia.TabIndex = 123;
            this.lblAdvertencia.Text = "¿Esta seguro de que desea borrar registro de esta plataforma? Una vez eliminada n" +
    "o podrá recuperar la información que esta tenga. Para confirmar la acción, favor" +
    " de ingresar el Id.";
            this.lblAdvertencia.Visible = false;
            // 
            // dGVMecanico
            // 
            this.dGVMecanico.AllowUserToAddRows = false;
            this.dGVMecanico.AllowUserToDeleteRows = false;
            this.dGVMecanico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dGVMecanico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVMecanico.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dGVMecanico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dGVMecanico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMecanico.GridColor = System.Drawing.Color.BlueViolet;
            this.dGVMecanico.Location = new System.Drawing.Point(60, 121);
            this.dGVMecanico.Margin = new System.Windows.Forms.Padding(2);
            this.dGVMecanico.Name = "dGVMecanico";
            this.dGVMecanico.ReadOnly = true;
            this.dGVMecanico.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dGVMecanico.RowTemplate.Height = 24;
            this.dGVMecanico.Size = new System.Drawing.Size(816, 437);
            this.dGVMecanico.TabIndex = 122;
            this.dGVMecanico.Visible = false;
            this.dGVMecanico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVMecanico_CellContentClick);
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
            this.btnEliminacion.Location = new System.Drawing.Point(318, 355);
            this.btnEliminacion.Name = "btnEliminacion";
            this.btnEliminacion.Size = new System.Drawing.Size(361, 52);
            this.btnEliminacion.TabIndex = 121;
            this.btnEliminacion.Text = "Borrar mecanico";
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
            this.btnModificacion.Location = new System.Drawing.Point(318, 506);
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
            this.lblRecordatorio.Location = new System.Drawing.Point(83, 216);
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
            this.btnIngresar.Location = new System.Drawing.Point(318, 506);
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
            this.lblNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota1.ForeColor = System.Drawing.Color.Black;
            this.lblNota1.Location = new System.Drawing.Point(42, 265);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(236, 52);
            this.lblNota1.TabIndex = 115;
            this.lblNota1.Text = "*Todos los campos son obligatorios";
            this.lblNota1.Visible = false;
            // 
            // lblNota3
            // 
            this.lblNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNota3.ForeColor = System.Drawing.Color.Black;
            this.lblNota3.Location = new System.Drawing.Point(42, 338);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(236, 51);
            this.lblNota3.TabIndex = 117;
            this.lblNota3.Text = "*Escribir identificador del vehiculo ";
            this.lblNota3.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.CadetBlue;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(383, 385);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(233, 22);
            this.txtNombre.TabIndex = 105;
            this.txtNombre.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(380, 358);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 24);
            this.lblNombre.TabIndex = 110;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Visible = false;
            // 
            // txtIdVehiculo
            // 
            this.txtIdVehiculo.BackColor = System.Drawing.Color.CadetBlue;
            this.txtIdVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdVehiculo.ForeColor = System.Drawing.Color.Black;
            this.txtIdVehiculo.Location = new System.Drawing.Point(384, 320);
            this.txtIdVehiculo.MaxLength = 30;
            this.txtIdVehiculo.Name = "txtIdVehiculo";
            this.txtIdVehiculo.Size = new System.Drawing.Size(236, 22);
            this.txtIdVehiculo.TabIndex = 104;
            this.txtIdVehiculo.Visible = false;
            // 
            // lblIdVehiculo
            // 
            this.lblIdVehiculo.AutoSize = true;
            this.lblIdVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdVehiculo.ForeColor = System.Drawing.Color.Black;
            this.lblIdVehiculo.Location = new System.Drawing.Point(380, 293);
            this.lblIdVehiculo.Name = "lblIdVehiculo";
            this.lblIdVehiculo.Size = new System.Drawing.Size(101, 24);
            this.lblIdVehiculo.TabIndex = 109;
            this.lblIdVehiculo.Text = "Id vehiculo";
            this.lblIdVehiculo.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(233, 47);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(455, 50);
            this.lblTitulo.TabIndex = 119;
            this.lblTitulo.Text = "Registrar un mecanico";
            this.lblTitulo.Visible = false;
            // 
            // dGVModificacion
            // 
            this.dGVModificacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dGVModificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVModificacion.Location = new System.Drawing.Point(656, 216);
            this.dGVModificacion.Name = "dGVModificacion";
            this.dGVModificacion.ReadOnly = true;
            this.dGVModificacion.Size = new System.Drawing.Size(258, 261);
            this.dGVModificacion.TabIndex = 127;
            this.dGVModificacion.Visible = false;
            this.dGVModificacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVModificacion_CellContentClick);
            // 
            // frmMecanicoAtendioVehiculo
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
            this.Controls.Add(this.dGVMecanico);
            this.Controls.Add(this.btnEliminacion);
            this.Controls.Add(this.btnModificacion);
            this.Controls.Add(this.lblRecordatorio);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtIdVehiculo);
            this.Controls.Add(this.lblIdVehiculo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.plContenedorBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMecanicoAtendioVehiculo";
            this.Text = "MecanicoAtendioVehiculo";
            this.plContenedorBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVMecanico)).EndInit();
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
        private System.Windows.Forms.DataGridView dGVMecanico;
        private System.Windows.Forms.Button btnEliminacion;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Label lblRecordatorio;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtIdVehiculo;
        private System.Windows.Forms.Label lblIdVehiculo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dGVModificacion;
    }
}