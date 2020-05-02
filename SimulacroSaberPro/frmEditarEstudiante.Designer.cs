namespace SimulacroSaberPro
{
    partial class frmEditarEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarEstudiante));
            this.cmbEditarGenero = new System.Windows.Forms.ComboBox();
            this.lblEditarGenero = new System.Windows.Forms.Label();
            this.txtEditarTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
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
            this.lblEditarValores = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.dtgvEstudiante = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            this.txtEditarBarrio = new System.Windows.Forms.TextBox();
            this.lblEditarBarrio = new System.Windows.Forms.Label();
            this.txtEditarNumeroDireccion = new System.Windows.Forms.TextBox();
            this.lblNumeroDireccion = new System.Windows.Forms.Label();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.pbInformacion = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.btnCloseSesion = new System.Windows.Forms.PictureBox();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.lblConfirmarClave = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEstudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInformacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseSesion)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEditarGenero
            // 
            this.cmbEditarGenero.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditarGenero.FormattingEnabled = true;
            this.cmbEditarGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
            this.cmbEditarGenero.Location = new System.Drawing.Point(725, 255);
            this.cmbEditarGenero.Name = "cmbEditarGenero";
            this.cmbEditarGenero.Size = new System.Drawing.Size(262, 24);
            this.cmbEditarGenero.TabIndex = 10;
            this.cmbEditarGenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEditarGenero_KeyPress);
            // 
            // lblEditarGenero
            // 
            this.lblEditarGenero.AutoSize = true;
            this.lblEditarGenero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarGenero.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEditarGenero.Location = new System.Drawing.Point(721, 233);
            this.lblEditarGenero.Name = "lblEditarGenero";
            this.lblEditarGenero.Size = new System.Drawing.Size(69, 21);
            this.lblEditarGenero.TabIndex = 158;
            this.lblEditarGenero.Text = "Género";
            // 
            // txtEditarTelefono
            // 
            this.txtEditarTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.txtEditarTelefono.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditarTelefono.ForeColor = System.Drawing.Color.White;
            this.txtEditarTelefono.Location = new System.Drawing.Point(102, 306);
            this.txtEditarTelefono.Name = "txtEditarTelefono";
            this.txtEditarTelefono.Size = new System.Drawing.Size(262, 22);
            this.txtEditarTelefono.TabIndex = 12;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTelefono.Location = new System.Drawing.Point(98, 282);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(76, 21);
            this.lblTelefono.TabIndex = 156;
            this.lblTelefono.Text = "Teléfono";
            // 
            // cmbEditarTipoDocumento
            // 
            this.cmbEditarTipoDocumento.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEditarTipoDocumento.FormattingEnabled = true;
            this.cmbEditarTipoDocumento.Items.AddRange(new object[] {
            "Cédula de Ciudadania",
            "Cédula de Extranjeria",
            "Otro"});
            this.cmbEditarTipoDocumento.Location = new System.Drawing.Point(101, 200);
            this.cmbEditarTipoDocumento.Name = "cmbEditarTipoDocumento";
            this.cmbEditarTipoDocumento.Size = new System.Drawing.Size(262, 24);
            this.cmbEditarTipoDocumento.TabIndex = 4;
            this.cmbEditarTipoDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbEditarTipoDocumento_KeyPress);
            // 
            // txtEditarClave
            // 
            this.txtEditarClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.txtEditarClave.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditarClave.ForeColor = System.Drawing.Color.White;
            this.txtEditarClave.Location = new System.Drawing.Point(413, 306);
            this.txtEditarClave.Name = "txtEditarClave";
            this.txtEditarClave.PasswordChar = '*';
            this.txtEditarClave.Size = new System.Drawing.Size(262, 22);
            this.txtEditarClave.TabIndex = 13;
            this.txtEditarClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEditarClave_KeyPress);
            // 
            // lblEditarClave
            // 
            this.lblEditarClave.AutoSize = true;
            this.lblEditarClave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarClave.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEditarClave.Location = new System.Drawing.Point(410, 282);
            this.lblEditarClave.Name = "lblEditarClave";
            this.lblEditarClave.Size = new System.Drawing.Size(113, 21);
            this.lblEditarClave.TabIndex = 153;
            this.lblEditarClave.Text = "Contraseña *";
            // 
            // txtEditarApellido
            // 
            this.txtEditarApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.txtEditarApellido.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditarApellido.ForeColor = System.Drawing.Color.White;
            this.txtEditarApellido.Location = new System.Drawing.Point(413, 257);
            this.txtEditarApellido.Name = "txtEditarApellido";
            this.txtEditarApellido.Size = new System.Drawing.Size(262, 22);
            this.txtEditarApellido.TabIndex = 9;
            // 
            // lblEditarApellido
            // 
            this.lblEditarApellido.AutoSize = true;
            this.lblEditarApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarApellido.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEditarApellido.Location = new System.Drawing.Point(410, 233);
            this.lblEditarApellido.Name = "lblEditarApellido";
            this.lblEditarApellido.Size = new System.Drawing.Size(74, 21);
            this.lblEditarApellido.TabIndex = 151;
            this.lblEditarApellido.Text = "Apellido";
            // 
            // txtEditarNombre
            // 
            this.txtEditarNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.txtEditarNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditarNombre.ForeColor = System.Drawing.Color.White;
            this.txtEditarNombre.Location = new System.Drawing.Point(101, 257);
            this.txtEditarNombre.Name = "txtEditarNombre";
            this.txtEditarNombre.Size = new System.Drawing.Size(262, 22);
            this.txtEditarNombre.TabIndex = 8;
            // 
            // lblEditarNombre
            // 
            this.lblEditarNombre.AutoSize = true;
            this.lblEditarNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEditarNombre.Location = new System.Drawing.Point(97, 233);
            this.lblEditarNombre.Name = "lblEditarNombre";
            this.lblEditarNombre.Size = new System.Drawing.Size(73, 21);
            this.lblEditarNombre.TabIndex = 149;
            this.lblEditarNombre.Text = "Nombre";
            // 
            // txtEditarCorreo
            // 
            this.txtEditarCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.txtEditarCorreo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditarCorreo.ForeColor = System.Drawing.Color.White;
            this.txtEditarCorreo.Location = new System.Drawing.Point(722, 199);
            this.txtEditarCorreo.Name = "txtEditarCorreo";
            this.txtEditarCorreo.Size = new System.Drawing.Size(262, 22);
            this.txtEditarCorreo.TabIndex = 6;
            // 
            // lblEditarCorreo
            // 
            this.lblEditarCorreo.AutoSize = true;
            this.lblEditarCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarCorreo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEditarCorreo.Location = new System.Drawing.Point(719, 175);
            this.lblEditarCorreo.Name = "lblEditarCorreo";
            this.lblEditarCorreo.Size = new System.Drawing.Size(63, 21);
            this.lblEditarCorreo.TabIndex = 147;
            this.lblEditarCorreo.Text = "Correo";
            // 
            // txtEditarNumeroDocumento
            // 
            this.txtEditarNumeroDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.txtEditarNumeroDocumento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditarNumeroDocumento.ForeColor = System.Drawing.Color.White;
            this.txtEditarNumeroDocumento.Location = new System.Drawing.Point(413, 199);
            this.txtEditarNumeroDocumento.Name = "txtEditarNumeroDocumento";
            this.txtEditarNumeroDocumento.Size = new System.Drawing.Size(262, 22);
            this.txtEditarNumeroDocumento.TabIndex = 5;
            // 
            // lblEditarNumeroDocumento
            // 
            this.lblEditarNumeroDocumento.AutoSize = true;
            this.lblEditarNumeroDocumento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarNumeroDocumento.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEditarNumeroDocumento.Location = new System.Drawing.Point(410, 175);
            this.lblEditarNumeroDocumento.Name = "lblEditarNumeroDocumento";
            this.lblEditarNumeroDocumento.Size = new System.Drawing.Size(170, 21);
            this.lblEditarNumeroDocumento.TabIndex = 145;
            this.lblEditarNumeroDocumento.Text = "Número Documento";
            // 
            // lblEditarTipoDocumento
            // 
            this.lblEditarTipoDocumento.AutoSize = true;
            this.lblEditarTipoDocumento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarTipoDocumento.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEditarTipoDocumento.Location = new System.Drawing.Point(97, 178);
            this.lblEditarTipoDocumento.Name = "lblEditarTipoDocumento";
            this.lblEditarTipoDocumento.Size = new System.Drawing.Size(140, 21);
            this.lblEditarTipoDocumento.TabIndex = 144;
            this.lblEditarTipoDocumento.Text = "Tipo Documento";
            // 
            // lblEditarValores
            // 
            this.lblEditarValores.AutoSize = true;
            this.lblEditarValores.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarValores.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEditarValores.Location = new System.Drawing.Point(30, 134);
            this.lblEditarValores.Name = "lblEditarValores";
            this.lblEditarValores.Size = new System.Drawing.Size(179, 30);
            this.lblEditarValores.TabIndex = 143;
            this.lblEditarValores.Text = "Editar valores:";
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(1236, 571);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(127, 37);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBuscar.Location = new System.Drawing.Point(26, 42);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(144, 30);
            this.lblBuscar.TabIndex = 141;
            this.lblBuscar.Text = "Buscar por:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.White;
            this.txtCorreo.Location = new System.Drawing.Point(410, 100);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(262, 22);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCorreo.Location = new System.Drawing.Point(407, 76);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(63, 21);
            this.lblCorreo.TabIndex = 139;
            this.lblCorreo.Text = "Correo";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.txtNumeroDocumento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDocumento.ForeColor = System.Drawing.Color.White;
            this.txtNumeroDocumento.Location = new System.Drawing.Point(101, 100);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(262, 22);
            this.txtNumeroDocumento.TabIndex = 2;
            this.txtNumeroDocumento.TextChanged += new System.EventHandler(this.txtNumeroDocumento_TextChanged);
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDocumento.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(98, 76);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(170, 21);
            this.lblNumeroDocumento.TabIndex = 1;
            this.lblNumeroDocumento.Text = "Número Documento";
            // 
            // dtgvEstudiante
            // 
            this.dtgvEstudiante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvEstudiante.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvEstudiante.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtgvEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvEstudiante.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvEstudiante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvEstudiante.EnableHeadersVisualStyles = false;
            this.dtgvEstudiante.GridColor = System.Drawing.SystemColors.Highlight;
            this.dtgvEstudiante.Location = new System.Drawing.Point(8, 351);
            this.dtgvEstudiante.Name = "dtgvEstudiante";
            this.dtgvEstudiante.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvEstudiante.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvEstudiante.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvEstudiante.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvEstudiante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvEstudiante.Size = new System.Drawing.Size(1361, 200);
            this.dtgvEstudiante.TabIndex = 136;
            this.dtgvEstudiante.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEstudiante_CellClick);
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Image = global::SimulacroSaberPro.Properties.Resources.atras1;
            this.btnVolver.Location = new System.Drawing.Point(15, 10);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(24, 24);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnVolver.TabIndex = 135;
            this.btnVolver.TabStop = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // txtEditarBarrio
            // 
            this.txtEditarBarrio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.txtEditarBarrio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditarBarrio.ForeColor = System.Drawing.Color.White;
            this.txtEditarBarrio.Location = new System.Drawing.Point(1010, 257);
            this.txtEditarBarrio.Name = "txtEditarBarrio";
            this.txtEditarBarrio.Size = new System.Drawing.Size(262, 22);
            this.txtEditarBarrio.TabIndex = 11;
            // 
            // lblEditarBarrio
            // 
            this.lblEditarBarrio.AutoSize = true;
            this.lblEditarBarrio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarBarrio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEditarBarrio.Location = new System.Drawing.Point(1007, 233);
            this.lblEditarBarrio.Name = "lblEditarBarrio";
            this.lblEditarBarrio.Size = new System.Drawing.Size(53, 21);
            this.lblEditarBarrio.TabIndex = 160;
            this.lblEditarBarrio.Text = "Barrio";
            // 
            // txtEditarNumeroDireccion
            // 
            this.txtEditarNumeroDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.txtEditarNumeroDireccion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditarNumeroDireccion.ForeColor = System.Drawing.Color.White;
            this.txtEditarNumeroDireccion.Location = new System.Drawing.Point(1010, 199);
            this.txtEditarNumeroDireccion.Name = "txtEditarNumeroDireccion";
            this.txtEditarNumeroDireccion.Size = new System.Drawing.Size(262, 22);
            this.txtEditarNumeroDireccion.TabIndex = 7;
            // 
            // lblNumeroDireccion
            // 
            this.lblNumeroDireccion.AutoSize = true;
            this.lblNumeroDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDireccion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumeroDireccion.Location = new System.Drawing.Point(1007, 175);
            this.lblNumeroDireccion.Name = "lblNumeroDireccion";
            this.lblNumeroDireccion.Size = new System.Drawing.Size(149, 21);
            this.lblNumeroDireccion.TabIndex = 162;
            this.lblNumeroDireccion.Text = "Número Dirección";
            // 
            // lblInformacion
            // 
            this.lblInformacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInformacion.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblInformacion.ForeColor = System.Drawing.Color.White;
            this.lblInformacion.Location = new System.Drawing.Point(1112, 100);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(251, 47);
            this.lblInformacion.TabIndex = 165;
            this.lblInformacion.Text = "Seleccione Número de Documento para editar";
            this.lblInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInformacion.Visible = false;
            // 
            // pbInformacion
            // 
            this.pbInformacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInformacion.Image = global::SimulacroSaberPro.Properties.Resources.info;
            this.pbInformacion.Location = new System.Drawing.Point(1339, 73);
            this.pbInformacion.Name = "pbInformacion";
            this.pbInformacion.Size = new System.Drawing.Size(24, 24);
            this.pbInformacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbInformacion.TabIndex = 164;
            this.pbInformacion.TabStop = false;
            this.pbInformacion.MouseLeave += new System.EventHandler(this.pbInformacion_MouseLeave);
            this.pbInformacion.MouseHover += new System.EventHandler(this.pbInformacion_MouseHover);
            // 
            // picMinimize
            // 
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimize.Image = global::SimulacroSaberPro.Properties.Resources.minimizar1;
            this.picMinimize.Location = new System.Drawing.Point(1309, 10);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(24, 24);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimize.TabIndex = 167;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // btnCloseSesion
            // 
            this.btnCloseSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseSesion.Image = global::SimulacroSaberPro.Properties.Resources.apagar;
            this.btnCloseSesion.Location = new System.Drawing.Point(1339, 10);
            this.btnCloseSesion.Name = "btnCloseSesion";
            this.btnCloseSesion.Size = new System.Drawing.Size(24, 24);
            this.btnCloseSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCloseSesion.TabIndex = 166;
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
            this.txtConfirmarClave.TabIndex = 14;
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
            this.lblConfirmarClave.TabIndex = 168;
            this.lblConfirmarClave.Text = "Confirmar Contraseña *";
            // 
            // frmEditarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1375, 623);
            this.Controls.Add(this.txtConfirmarClave);
            this.Controls.Add(this.lblConfirmarClave);
            this.Controls.Add(this.picMinimize);
            this.Controls.Add(this.btnCloseSesion);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.pbInformacion);
            this.Controls.Add(this.txtEditarNumeroDireccion);
            this.Controls.Add(this.lblNumeroDireccion);
            this.Controls.Add(this.txtEditarBarrio);
            this.Controls.Add(this.lblEditarBarrio);
            this.Controls.Add(this.cmbEditarGenero);
            this.Controls.Add(this.lblEditarGenero);
            this.Controls.Add(this.txtEditarTelefono);
            this.Controls.Add(this.lblTelefono);
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
            this.Controls.Add(this.dtgvEstudiante);
            this.Controls.Add(this.btnVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditarEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Estudiante";
            this.Load += new System.EventHandler(this.frmEditarEstudiante_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmEditarEstudiante_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEstudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInformacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseSesion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEditarGenero;
        private System.Windows.Forms.Label lblEditarGenero;
        private System.Windows.Forms.TextBox txtEditarTelefono;
        private System.Windows.Forms.Label lblTelefono;
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
        private System.Windows.Forms.Label lblEditarValores;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.DataGridView dtgvEstudiante;
        private System.Windows.Forms.PictureBox btnVolver;
        private System.Windows.Forms.TextBox txtEditarBarrio;
        private System.Windows.Forms.Label lblEditarBarrio;
        private System.Windows.Forms.TextBox txtEditarNumeroDireccion;
        private System.Windows.Forms.Label lblNumeroDireccion;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.PictureBox pbInformacion;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox btnCloseSesion;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.Label lblConfirmarClave;
    }
}