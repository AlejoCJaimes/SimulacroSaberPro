namespace SimulacroSaberPro
{
    partial class frmEditarAdministrador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarAdministrador));
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.dtgvAdministrador = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblEditarValores = new System.Windows.Forms.Label();
            this.cmbEditarTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtEditarClave = new System.Windows.Forms.TextBox();
            this.lblEditarClave = new System.Windows.Forms.Label();
            this.txtEditarApellido = new System.Windows.Forms.TextBox();
            this.lblEditarApellido = new System.Windows.Forms.Label();
            this.txtEditarNombre = new System.Windows.Forms.TextBox();
            this.lblEditarNombre = new System.Windows.Forms.Label();
            this.txtEditarCorreo = new System.Windows.Forms.TextBox();
            this.lblEditarCorreo = new System.Windows.Forms.Label();
            this.txtEditarNumeroDocumento = new System.Windows.Forms.TextBox();
            this.lblEditarNumeroDocumento = new System.Windows.Forms.Label();
            this.lblEditarTipoDocumento = new System.Windows.Forms.Label();
            this.txtEditarTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbEditarEstado = new System.Windows.Forms.ComboBox();
            this.lblEditarEstado = new System.Windows.Forms.Label();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.pbInformacion = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.btnCloseSesion = new System.Windows.Forms.PictureBox();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.lblConfirmarClave = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAdministrador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInformacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseSesion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBuscar.Location = new System.Drawing.Point(27, 42);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(144, 30);
            this.lblBuscar.TabIndex = 109;
            this.lblBuscar.Text = "Buscar por:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.White;
            this.txtCorreo.Location = new System.Drawing.Point(411, 100);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(262, 22);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.TextChanged += new System.EventHandler(this.TxtCorreo_TextChanged);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCorreo.Location = new System.Drawing.Point(408, 76);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(63, 21);
            this.lblCorreo.TabIndex = 107;
            this.lblCorreo.Text = "Correo";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.txtNumeroDocumento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDocumento.ForeColor = System.Drawing.Color.White;
            this.txtNumeroDocumento.Location = new System.Drawing.Point(102, 100);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(262, 22);
            this.txtNumeroDocumento.TabIndex = 2;
            this.txtNumeroDocumento.TextChanged += new System.EventHandler(this.TxtNumeroDocumento_TextChanged);
            this.txtNumeroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeroDocumento_KeyPress);
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDocumento.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(99, 76);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(170, 21);
            this.lblNumeroDocumento.TabIndex = 1;
            this.lblNumeroDocumento.Text = "Número Documento";
            // 
            // dtgvAdministrador
            // 
            this.dtgvAdministrador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAdministrador.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvAdministrador.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtgvAdministrador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvAdministrador.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAdministrador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvAdministrador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvAdministrador.EnableHeadersVisualStyles = false;
            this.dtgvAdministrador.GridColor = System.Drawing.SystemColors.Highlight;
            this.dtgvAdministrador.Location = new System.Drawing.Point(74, 350);
            this.dtgvAdministrador.Name = "dtgvAdministrador";
            this.dtgvAdministrador.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvAdministrador.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvAdministrador.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvAdministrador.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvAdministrador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAdministrador.Size = new System.Drawing.Size(929, 200);
            this.dtgvAdministrador.TabIndex = 102;
            this.dtgvAdministrador.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvAdministrador_CellClick);
            this.dtgvAdministrador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAdministrador_CellContentClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(876, 565);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(127, 37);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // lblEditarValores
            // 
            this.lblEditarValores.AutoSize = true;
            this.lblEditarValores.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarValores.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEditarValores.Location = new System.Drawing.Point(31, 134);
            this.lblEditarValores.Name = "lblEditarValores";
            this.lblEditarValores.Size = new System.Drawing.Size(179, 30);
            this.lblEditarValores.TabIndex = 118;
            this.lblEditarValores.Text = "Editar valores:";
            // 
            // cmbEditarTipoDocumento
            // 
            this.cmbEditarTipoDocumento.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditarTipoDocumento.FormattingEnabled = true;
            this.cmbEditarTipoDocumento.Items.AddRange(new object[] {
            "Cédula de Ciudadania",
            "Cédula de Extranjeria",
            "Otro"});
            this.cmbEditarTipoDocumento.Location = new System.Drawing.Point(102, 200);
            this.cmbEditarTipoDocumento.Name = "cmbEditarTipoDocumento";
            this.cmbEditarTipoDocumento.Size = new System.Drawing.Size(262, 24);
            this.cmbEditarTipoDocumento.TabIndex = 4;
            this.cmbEditarTipoDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbEditarTipoDocumento_KeyPress);
            // 
            // txtEditarClave
            // 
            this.txtEditarClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.txtEditarClave.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditarClave.ForeColor = System.Drawing.Color.White;
            this.txtEditarClave.Location = new System.Drawing.Point(411, 306);
            this.txtEditarClave.Name = "txtEditarClave";
            this.txtEditarClave.PasswordChar = '*';
            this.txtEditarClave.Size = new System.Drawing.Size(262, 22);
            this.txtEditarClave.TabIndex = 11;
            this.txtEditarClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEditarClave_KeyPress);
            // 
            // lblEditarClave
            // 
            this.lblEditarClave.AutoSize = true;
            this.lblEditarClave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarClave.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEditarClave.Location = new System.Drawing.Point(408, 282);
            this.lblEditarClave.Name = "lblEditarClave";
            this.lblEditarClave.Size = new System.Drawing.Size(113, 21);
            this.lblEditarClave.TabIndex = 128;
            this.lblEditarClave.Text = "Contraseña *";
            // 
            // txtEditarApellido
            // 
            this.txtEditarApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.txtEditarApellido.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditarApellido.ForeColor = System.Drawing.Color.White;
            this.txtEditarApellido.Location = new System.Drawing.Point(414, 257);
            this.txtEditarApellido.Name = "txtEditarApellido";
            this.txtEditarApellido.Size = new System.Drawing.Size(262, 22);
            this.txtEditarApellido.TabIndex = 8;
            this.txtEditarApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEditarApellido_KeyPress);
            // 
            // lblEditarApellido
            // 
            this.lblEditarApellido.AutoSize = true;
            this.lblEditarApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarApellido.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEditarApellido.Location = new System.Drawing.Point(411, 233);
            this.lblEditarApellido.Name = "lblEditarApellido";
            this.lblEditarApellido.Size = new System.Drawing.Size(74, 21);
            this.lblEditarApellido.TabIndex = 126;
            this.lblEditarApellido.Text = "Apellido";
            // 
            // txtEditarNombre
            // 
            this.txtEditarNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.txtEditarNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditarNombre.ForeColor = System.Drawing.Color.White;
            this.txtEditarNombre.Location = new System.Drawing.Point(102, 257);
            this.txtEditarNombre.Name = "txtEditarNombre";
            this.txtEditarNombre.Size = new System.Drawing.Size(262, 22);
            this.txtEditarNombre.TabIndex = 7;
            this.txtEditarNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEditarNombre_KeyPress);
            // 
            // lblEditarNombre
            // 
            this.lblEditarNombre.AutoSize = true;
            this.lblEditarNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEditarNombre.Location = new System.Drawing.Point(98, 233);
            this.lblEditarNombre.Name = "lblEditarNombre";
            this.lblEditarNombre.Size = new System.Drawing.Size(73, 21);
            this.lblEditarNombre.TabIndex = 124;
            this.lblEditarNombre.Text = "Nombre";
            // 
            // txtEditarCorreo
            // 
            this.txtEditarCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.txtEditarCorreo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditarCorreo.ForeColor = System.Drawing.Color.White;
            this.txtEditarCorreo.Location = new System.Drawing.Point(723, 199);
            this.txtEditarCorreo.Name = "txtEditarCorreo";
            this.txtEditarCorreo.Size = new System.Drawing.Size(262, 22);
            this.txtEditarCorreo.TabIndex = 6;
            // 
            // lblEditarCorreo
            // 
            this.lblEditarCorreo.AutoSize = true;
            this.lblEditarCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarCorreo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEditarCorreo.Location = new System.Drawing.Point(720, 175);
            this.lblEditarCorreo.Name = "lblEditarCorreo";
            this.lblEditarCorreo.Size = new System.Drawing.Size(63, 21);
            this.lblEditarCorreo.TabIndex = 122;
            this.lblEditarCorreo.Text = "Correo";
            // 
            // txtEditarNumeroDocumento
            // 
            this.txtEditarNumeroDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.txtEditarNumeroDocumento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditarNumeroDocumento.ForeColor = System.Drawing.Color.White;
            this.txtEditarNumeroDocumento.Location = new System.Drawing.Point(414, 199);
            this.txtEditarNumeroDocumento.Name = "txtEditarNumeroDocumento";
            this.txtEditarNumeroDocumento.Size = new System.Drawing.Size(262, 22);
            this.txtEditarNumeroDocumento.TabIndex = 5;
            this.txtEditarNumeroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEditarNumeroDocumento_KeyPress);
            // 
            // lblEditarNumeroDocumento
            // 
            this.lblEditarNumeroDocumento.AutoSize = true;
            this.lblEditarNumeroDocumento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarNumeroDocumento.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEditarNumeroDocumento.Location = new System.Drawing.Point(411, 175);
            this.lblEditarNumeroDocumento.Name = "lblEditarNumeroDocumento";
            this.lblEditarNumeroDocumento.Size = new System.Drawing.Size(170, 21);
            this.lblEditarNumeroDocumento.TabIndex = 120;
            this.lblEditarNumeroDocumento.Text = "Número Documento";
            // 
            // lblEditarTipoDocumento
            // 
            this.lblEditarTipoDocumento.AutoSize = true;
            this.lblEditarTipoDocumento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarTipoDocumento.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEditarTipoDocumento.Location = new System.Drawing.Point(98, 178);
            this.lblEditarTipoDocumento.Name = "lblEditarTipoDocumento";
            this.lblEditarTipoDocumento.Size = new System.Drawing.Size(140, 21);
            this.lblEditarTipoDocumento.TabIndex = 119;
            this.lblEditarTipoDocumento.Text = "Tipo Documento";
            // 
            // txtEditarTitulo
            // 
            this.txtEditarTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.txtEditarTitulo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditarTitulo.ForeColor = System.Drawing.Color.White;
            this.txtEditarTitulo.Location = new System.Drawing.Point(103, 306);
            this.txtEditarTitulo.Name = "txtEditarTitulo";
            this.txtEditarTitulo.Size = new System.Drawing.Size(262, 22);
            this.txtEditarTitulo.TabIndex = 10;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(99, 282);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(51, 21);
            this.lblTitulo.TabIndex = 131;
            this.lblTitulo.Text = "Título";
            // 
            // cmbEditarEstado
            // 
            this.cmbEditarEstado.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditarEstado.FormattingEnabled = true;
            this.cmbEditarEstado.Items.AddRange(new object[] {
            "Inactivo",
            "Activo"});
            this.cmbEditarEstado.Location = new System.Drawing.Point(723, 255);
            this.cmbEditarEstado.Name = "cmbEditarEstado";
            this.cmbEditarEstado.Size = new System.Drawing.Size(167, 24);
            this.cmbEditarEstado.TabIndex = 9;
            this.cmbEditarEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEditarEstado_KeyPress);
            // 
            // lblEditarEstado
            // 
            this.lblEditarEstado.AutoSize = true;
            this.lblEditarEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarEstado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEditarEstado.Location = new System.Drawing.Point(719, 233);
            this.lblEditarEstado.Name = "lblEditarEstado";
            this.lblEditarEstado.Size = new System.Drawing.Size(68, 21);
            this.lblEditarEstado.TabIndex = 133;
            this.lblEditarEstado.Text = "Estado:";
            // 
            // lblInformacion
            // 
            this.lblInformacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInformacion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblInformacion.ForeColor = System.Drawing.Color.White;
            this.lblInformacion.Location = new System.Drawing.Point(774, 94);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(251, 47);
            this.lblInformacion.TabIndex = 136;
            this.lblInformacion.Text = "Seleccione Número de Documento para editar";
            this.lblInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInformacion.Visible = false;
            // 
            // pbInformacion
            // 
            this.pbInformacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInformacion.Image = global::SimulacroSaberPro.Properties.Resources.info;
            this.pbInformacion.Location = new System.Drawing.Point(1001, 67);
            this.pbInformacion.Name = "pbInformacion";
            this.pbInformacion.Size = new System.Drawing.Size(24, 24);
            this.pbInformacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbInformacion.TabIndex = 135;
            this.pbInformacion.TabStop = false;
            this.pbInformacion.MouseLeave += new System.EventHandler(this.pbInformacion_MouseLeave);
            this.pbInformacion.MouseHover += new System.EventHandler(this.pbInformacion_MouseHover);
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Image = global::SimulacroSaberPro.Properties.Resources.atras1;
            this.btnVolver.Location = new System.Drawing.Point(16, 10);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(24, 24);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnVolver.TabIndex = 101;
            this.btnVolver.TabStop = false;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // picMinimize
            // 
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimize.Image = global::SimulacroSaberPro.Properties.Resources.minimizar1;
            this.picMinimize.Location = new System.Drawing.Point(985, 10);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(24, 24);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimize.TabIndex = 138;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // btnCloseSesion
            // 
            this.btnCloseSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseSesion.Image = global::SimulacroSaberPro.Properties.Resources.apagar;
            this.btnCloseSesion.Location = new System.Drawing.Point(1015, 10);
            this.btnCloseSesion.Name = "btnCloseSesion";
            this.btnCloseSesion.Size = new System.Drawing.Size(24, 24);
            this.btnCloseSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCloseSesion.TabIndex = 137;
            this.btnCloseSesion.TabStop = false;
            this.btnCloseSesion.Click += new System.EventHandler(this.btnCloseSesion_Click);
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.txtConfirmarClave.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarClave.ForeColor = System.Drawing.Color.White;
            this.txtConfirmarClave.Location = new System.Drawing.Point(723, 306);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.PasswordChar = '*';
            this.txtConfirmarClave.Size = new System.Drawing.Size(262, 22);
            this.txtConfirmarClave.TabIndex = 12;
            this.txtConfirmarClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmarClave_KeyPress);
            // 
            // lblConfirmarClave
            // 
            this.lblConfirmarClave.AutoSize = true;
            this.lblConfirmarClave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarClave.ForeColor = System.Drawing.SystemColors.Control;
            this.lblConfirmarClave.Location = new System.Drawing.Point(720, 282);
            this.lblConfirmarClave.Name = "lblConfirmarClave";
            this.lblConfirmarClave.Size = new System.Drawing.Size(194, 21);
            this.lblConfirmarClave.TabIndex = 139;
            this.lblConfirmarClave.Text = "Confirmar Contraseña *";
            // 
            // frmEditarAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1050, 623);
            this.Controls.Add(this.txtConfirmarClave);
            this.Controls.Add(this.lblConfirmarClave);
            this.Controls.Add(this.picMinimize);
            this.Controls.Add(this.btnCloseSesion);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.pbInformacion);
            this.Controls.Add(this.cmbEditarEstado);
            this.Controls.Add(this.lblEditarEstado);
            this.Controls.Add(this.txtEditarTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cmbEditarTipoDocumento);
            this.Controls.Add(this.txtEditarClave);
            this.Controls.Add(this.lblEditarClave);
            this.Controls.Add(this.txtEditarApellido);
            this.Controls.Add(this.lblEditarApellido);
            this.Controls.Add(this.txtEditarNombre);
            this.Controls.Add(this.lblEditarNombre);
            this.Controls.Add(this.txtEditarCorreo);
            this.Controls.Add(this.lblEditarCorreo);
            this.Controls.Add(this.txtEditarNumeroDocumento);
            this.Controls.Add(this.lblEditarNumeroDocumento);
            this.Controls.Add(this.lblEditarTipoDocumento);
            this.Controls.Add(this.lblEditarValores);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtNumeroDocumento);
            this.Controls.Add(this.lblNumeroDocumento);
            this.Controls.Add(this.dtgvAdministrador);
            this.Controls.Add(this.btnVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditarAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Administrador";
            this.Load += new System.EventHandler(this.FrmEditarAdministrador_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmEditarAdministrador_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAdministrador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInformacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseSesion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.DataGridView dtgvAdministrador;
        private System.Windows.Forms.PictureBox btnVolver;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblEditarValores;
        private System.Windows.Forms.ComboBox cmbEditarTipoDocumento;
        private System.Windows.Forms.TextBox txtEditarClave;
        private System.Windows.Forms.Label lblEditarClave;
        private System.Windows.Forms.TextBox txtEditarApellido;
        private System.Windows.Forms.Label lblEditarApellido;
        private System.Windows.Forms.TextBox txtEditarNombre;
        private System.Windows.Forms.Label lblEditarNombre;
        private System.Windows.Forms.TextBox txtEditarCorreo;
        private System.Windows.Forms.Label lblEditarCorreo;
        private System.Windows.Forms.TextBox txtEditarNumeroDocumento;
        private System.Windows.Forms.Label lblEditarNumeroDocumento;
        private System.Windows.Forms.Label lblEditarTipoDocumento;
        private System.Windows.Forms.TextBox txtEditarTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbEditarEstado;
        private System.Windows.Forms.Label lblEditarEstado;
        private System.Windows.Forms.PictureBox pbInformacion;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox btnCloseSesion;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.Label lblConfirmarClave;
    }
}