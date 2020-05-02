namespace SimulacroSaberPro
{
    partial class frmIniciarSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIniciarSesion));
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblOlvidoClave = new System.Windows.Forms.LinkLabel();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.lblMensajeError = new System.Windows.Forms.Label();
            this.pbCandado = new System.Windows.Forms.PictureBox();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.pbLogoUdi = new System.Windows.Forms.PictureBox();
            this.pbSocial = new System.Windows.Forms.PictureBox();
            this.lblSeparador1 = new System.Windows.Forms.Label();
            this.lblSeparador2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCandado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoUdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSocial)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.AutoSize = true;
            this.lblIniciarSesion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.lblIniciarSesion.Location = new System.Drawing.Point(138, 202);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(122, 22);
            this.lblIniciarSesion.TabIndex = 1;
            this.lblIniciarSesion.Text = "Iniciar sesión";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(108, 266);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(268, 20);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Text = "usuario@udi.edu.co";
            this.txtUsuario.Enter += new System.EventHandler(this.TxtUsuario_Enter);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            this.txtUsuario.Leave += new System.EventHandler(this.TxtUsuario_Leave);
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.ForeColor = System.Drawing.Color.White;
            this.txtClave.Location = new System.Drawing.Point(109, 335);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(267, 20);
            this.txtClave.TabIndex = 3;
            this.txtClave.Text = "contraseña";
            this.txtClave.Enter += new System.EventHandler(this.TxtClave_Enter);
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            this.txtClave.Leave += new System.EventHandler(this.TxtClave_Leave);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(21)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(35, 400);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(350, 56);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // lblOlvidoClave
            // 
            this.lblOlvidoClave.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(21)))));
            this.lblOlvidoClave.AutoSize = true;
            this.lblOlvidoClave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOlvidoClave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOlvidoClave.LinkColor = System.Drawing.Color.White;
            this.lblOlvidoClave.Location = new System.Drawing.Point(119, 477);
            this.lblOlvidoClave.Name = "lblOlvidoClave";
            this.lblOlvidoClave.Size = new System.Drawing.Size(179, 17);
            this.lblOlvidoClave.TabIndex = 1;
            this.lblOlvidoClave.TabStop = true;
            this.lblOlvidoClave.Text = "¿Olvidaste tu contraseña?";
            this.lblOlvidoClave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblOlvidoClave_LinkClicked);
            // 
            // picMinimize
            // 
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimize.Image = global::SimulacroSaberPro.Properties.Resources.minimizar1;
            this.picMinimize.Location = new System.Drawing.Point(358, 12);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(16, 16);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMinimize.TabIndex = 36;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.PicMinimize_Click);
            // 
            // picCerrar
            // 
            this.picCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCerrar.Image = global::SimulacroSaberPro.Properties.Resources.cerrar1;
            this.picCerrar.Location = new System.Drawing.Point(380, 12);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(16, 16);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCerrar.TabIndex = 35;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.PicCerrar_Click);
            // 
            // lblMensajeError
            // 
            this.lblMensajeError.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeError.ForeColor = System.Drawing.Color.White;
            this.lblMensajeError.Image = global::SimulacroSaberPro.Properties.Resources.advertencia;
            this.lblMensajeError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMensajeError.Location = new System.Drawing.Point(86, 368);
            this.lblMensajeError.Name = "lblMensajeError";
            this.lblMensajeError.Size = new System.Drawing.Size(274, 38);
            this.lblMensajeError.TabIndex = 32;
            this.lblMensajeError.Text = "Error";
            this.lblMensajeError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensajeError.Visible = false;
            // 
            // pbCandado
            // 
            this.pbCandado.Image = global::SimulacroSaberPro.Properties.Resources.candado;
            this.pbCandado.Location = new System.Drawing.Point(78, 334);
            this.pbCandado.Name = "pbCandado";
            this.pbCandado.Size = new System.Drawing.Size(24, 24);
            this.pbCandado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCandado.TabIndex = 31;
            this.pbCandado.TabStop = false;
            // 
            // pbUsuario
            // 
            this.pbUsuario.Image = global::SimulacroSaberPro.Properties.Resources.usuario;
            this.pbUsuario.Location = new System.Drawing.Point(76, 263);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(24, 24);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbUsuario.TabIndex = 29;
            this.pbUsuario.TabStop = false;
            // 
            // pbLogoUdi
            // 
            this.pbLogoUdi.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pbLogoUdi.Image = global::SimulacroSaberPro.Properties.Resources.textoUdi;
            this.pbLogoUdi.Location = new System.Drawing.Point(142, 121);
            this.pbLogoUdi.Name = "pbLogoUdi";
            this.pbLogoUdi.Size = new System.Drawing.Size(117, 52);
            this.pbLogoUdi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoUdi.TabIndex = 25;
            this.pbLogoUdi.TabStop = false;
            this.pbLogoUdi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbLogoUdi_MouseDown);
            // 
            // pbSocial
            // 
            this.pbSocial.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pbSocial.Image = global::SimulacroSaberPro.Properties.Resources.social;
            this.pbSocial.Location = new System.Drawing.Point(126, 22);
            this.pbSocial.Name = "pbSocial";
            this.pbSocial.Size = new System.Drawing.Size(149, 103);
            this.pbSocial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSocial.TabIndex = 24;
            this.pbSocial.TabStop = false;
            this.pbSocial.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbSocial_MouseDown);
            // 
            // lblSeparador1
            // 
            this.lblSeparador1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparador1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSeparador1.Location = new System.Drawing.Point(106, 271);
            this.lblSeparador1.Name = "lblSeparador1";
            this.lblSeparador1.Size = new System.Drawing.Size(279, 28);
            this.lblSeparador1.TabIndex = 62;
            this.lblSeparador1.Text = "____________________________________";
            // 
            // lblSeparador2
            // 
            this.lblSeparador2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparador2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSeparador2.Location = new System.Drawing.Point(102, 340);
            this.lblSeparador2.Name = "lblSeparador2";
            this.lblSeparador2.Size = new System.Drawing.Size(283, 28);
            this.lblSeparador2.TabIndex = 63;
            this.lblSeparador2.Text = "____________________________________";
            // 
            // frmIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(408, 517);
            this.Controls.Add(this.pbCandado);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblSeparador2);
            this.Controls.Add(this.pbUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblSeparador1);
            this.Controls.Add(this.picMinimize);
            this.Controls.Add(this.picCerrar);
            this.Controls.Add(this.lblOlvidoClave);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblMensajeError);
            this.Controls.Add(this.lblIniciarSesion);
            this.Controls.Add(this.pbLogoUdi);
            this.Controls.Add(this.pbSocial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCandado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoUdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSocial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogoUdi;
        private System.Windows.Forms.PictureBox pbSocial;
        private System.Windows.Forms.Label lblIniciarSesion;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox pbCandado;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblMensajeError;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.LinkLabel lblOlvidoClave;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.Label lblSeparador1;
        private System.Windows.Forms.Label lblSeparador2;
    }
}

