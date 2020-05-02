namespace SimulacroSaberPro
{
    partial class frmEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstudiante));
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.pnIzquierdo = new System.Windows.Forms.Panel();
            this.pbCerrarSesion = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pbContexto = new System.Windows.Forms.PictureBox();
            this.pbEditarPerfil = new System.Windows.Forms.PictureBox();
            this.pbResultados = new System.Windows.Forms.PictureBox();
            this.btnContexto = new System.Windows.Forms.Button();
            this.btnEditarPerfil = new System.Windows.Forms.Button();
            this.btnResultados = new System.Windows.Forms.Button();
            this.pbPresentarPrueba = new System.Windows.Forms.PictureBox();
            this.btnPresentarPrueba = new System.Windows.Forms.Button();
            this.pnNombre = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pbEstudiante = new System.Windows.Forms.PictureBox();
            this.pnInferior = new System.Windows.Forms.Panel();
            this.pbLogoUdi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnPrincipal.SuspendLayout();
            this.pnIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbContexto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPresentarPrueba)).BeginInit();
            this.pnNombre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstudiante)).BeginInit();
            this.pnInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoUdi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::SimulacroSaberPro.Properties.Resources.minimizar1;
            this.btnMinimizar.Location = new System.Drawing.Point(1042, 15);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(16, 16);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::SimulacroSaberPro.Properties.Resources.cerrar1;
            this.btnCerrar.Location = new System.Drawing.Point(1066, 15);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 16);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.pnPrincipal.Controls.Add(this.lblEstudiante);
            this.pnPrincipal.Controls.Add(this.btnMinimizar);
            this.pnPrincipal.Controls.Add(this.btnCerrar);
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(1094, 44);
            this.pnPrincipal.TabIndex = 5;
            this.pnPrincipal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnPrincipal_MouseDown);
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante.ForeColor = System.Drawing.Color.White;
            this.lblEstudiante.Location = new System.Drawing.Point(15, 9);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(114, 24);
            this.lblEstudiante.TabIndex = 1;
            this.lblEstudiante.Text = "Estudiante";
            this.lblEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnIzquierdo
            // 
            this.pnIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.pnIzquierdo.Controls.Add(this.pbCerrarSesion);
            this.pnIzquierdo.Controls.Add(this.btnCerrarSesion);
            this.pnIzquierdo.Controls.Add(this.pbContexto);
            this.pnIzquierdo.Controls.Add(this.pbEditarPerfil);
            this.pnIzquierdo.Controls.Add(this.pbResultados);
            this.pnIzquierdo.Controls.Add(this.btnContexto);
            this.pnIzquierdo.Controls.Add(this.btnEditarPerfil);
            this.pnIzquierdo.Controls.Add(this.btnResultados);
            this.pnIzquierdo.Controls.Add(this.pbPresentarPrueba);
            this.pnIzquierdo.Controls.Add(this.btnPresentarPrueba);
            this.pnIzquierdo.Controls.Add(this.pnNombre);
            this.pnIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnIzquierdo.Location = new System.Drawing.Point(0, 44);
            this.pnIzquierdo.Name = "pnIzquierdo";
            this.pnIzquierdo.Size = new System.Drawing.Size(250, 481);
            this.pnIzquierdo.TabIndex = 7;
            this.pnIzquierdo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnIzquierdo_MouseDown);
            // 
            // pbCerrarSesion
            // 
            this.pbCerrarSesion.Image = global::SimulacroSaberPro.Properties.Resources.cerrarsesion;
            this.pbCerrarSesion.Location = new System.Drawing.Point(19, 404);
            this.pbCerrarSesion.Name = "pbCerrarSesion";
            this.pbCerrarSesion.Size = new System.Drawing.Size(32, 32);
            this.pbCerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCerrarSesion.TabIndex = 71;
            this.pbCerrarSesion.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 395);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(250, 54);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.Text = "      Cerrar sesion\r\n";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pbContexto
            // 
            this.pbContexto.Image = global::SimulacroSaberPro.Properties.Resources.contexto;
            this.pbContexto.Location = new System.Drawing.Point(19, 351);
            this.pbContexto.Name = "pbContexto";
            this.pbContexto.Size = new System.Drawing.Size(32, 32);
            this.pbContexto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbContexto.TabIndex = 69;
            this.pbContexto.TabStop = false;
            // 
            // pbEditarPerfil
            // 
            this.pbEditarPerfil.Image = global::SimulacroSaberPro.Properties.Resources.editar;
            this.pbEditarPerfil.Location = new System.Drawing.Point(19, 299);
            this.pbEditarPerfil.Name = "pbEditarPerfil";
            this.pbEditarPerfil.Size = new System.Drawing.Size(32, 32);
            this.pbEditarPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbEditarPerfil.TabIndex = 68;
            this.pbEditarPerfil.TabStop = false;
            // 
            // pbResultados
            // 
            this.pbResultados.Image = global::SimulacroSaberPro.Properties.Resources.resultados;
            this.pbResultados.Location = new System.Drawing.Point(19, 244);
            this.pbResultados.Name = "pbResultados";
            this.pbResultados.Size = new System.Drawing.Size(32, 32);
            this.pbResultados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbResultados.TabIndex = 67;
            this.pbResultados.TabStop = false;
            // 
            // btnContexto
            // 
            this.btnContexto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContexto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContexto.FlatAppearance.BorderSize = 0;
            this.btnContexto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnContexto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContexto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContexto.ForeColor = System.Drawing.Color.White;
            this.btnContexto.Location = new System.Drawing.Point(0, 341);
            this.btnContexto.Name = "btnContexto";
            this.btnContexto.Size = new System.Drawing.Size(250, 54);
            this.btnContexto.TabIndex = 5;
            this.btnContexto.Text = "      Contexto\r\n";
            this.btnContexto.UseVisualStyleBackColor = true;
            this.btnContexto.Click += new System.EventHandler(this.btnContexto_Click);
            // 
            // btnEditarPerfil
            // 
            this.btnEditarPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditarPerfil.FlatAppearance.BorderSize = 0;
            this.btnEditarPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEditarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPerfil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPerfil.ForeColor = System.Drawing.Color.White;
            this.btnEditarPerfil.Location = new System.Drawing.Point(0, 287);
            this.btnEditarPerfil.Name = "btnEditarPerfil";
            this.btnEditarPerfil.Size = new System.Drawing.Size(250, 54);
            this.btnEditarPerfil.TabIndex = 4;
            this.btnEditarPerfil.Text = "      Editar Perfil\r\n";
            this.btnEditarPerfil.UseVisualStyleBackColor = true;
            this.btnEditarPerfil.Click += new System.EventHandler(this.btnEditarPerfil_Click);
            // 
            // btnResultados
            // 
            this.btnResultados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResultados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResultados.FlatAppearance.BorderSize = 0;
            this.btnResultados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultados.ForeColor = System.Drawing.Color.White;
            this.btnResultados.Location = new System.Drawing.Point(0, 233);
            this.btnResultados.Name = "btnResultados";
            this.btnResultados.Size = new System.Drawing.Size(250, 54);
            this.btnResultados.TabIndex = 3;
            this.btnResultados.Text = "      Resultados\r\n";
            this.btnResultados.UseVisualStyleBackColor = true;
            this.btnResultados.Click += new System.EventHandler(this.btnResultados_Click);
            // 
            // pbPresentarPrueba
            // 
            this.pbPresentarPrueba.Enabled = false;
            this.pbPresentarPrueba.Image = global::SimulacroSaberPro.Properties.Resources.prueba;
            this.pbPresentarPrueba.Location = new System.Drawing.Point(19, 191);
            this.pbPresentarPrueba.Name = "pbPresentarPrueba";
            this.pbPresentarPrueba.Size = new System.Drawing.Size(32, 32);
            this.pbPresentarPrueba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPresentarPrueba.TabIndex = 63;
            this.pbPresentarPrueba.TabStop = false;
            // 
            // btnPresentarPrueba
            // 
            this.btnPresentarPrueba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPresentarPrueba.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPresentarPrueba.FlatAppearance.BorderSize = 0;
            this.btnPresentarPrueba.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPresentarPrueba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresentarPrueba.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresentarPrueba.ForeColor = System.Drawing.Color.White;
            this.btnPresentarPrueba.Location = new System.Drawing.Point(0, 179);
            this.btnPresentarPrueba.Name = "btnPresentarPrueba";
            this.btnPresentarPrueba.Size = new System.Drawing.Size(250, 54);
            this.btnPresentarPrueba.TabIndex = 2;
            this.btnPresentarPrueba.Text = "      Presentar Prueba";
            this.btnPresentarPrueba.UseVisualStyleBackColor = true;
            this.btnPresentarPrueba.Click += new System.EventHandler(this.btnPresentarPrueba_Click);
            // 
            // pnNombre
            // 
            this.pnNombre.Controls.Add(this.lblNombre);
            this.pnNombre.Controls.Add(this.pbEstudiante);
            this.pnNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNombre.Location = new System.Drawing.Point(0, 0);
            this.pnNombre.Name = "pnNombre";
            this.pnNombre.Size = new System.Drawing.Size(250, 179);
            this.pnNombre.TabIndex = 0;
            this.pnNombre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnNombre_MouseDown);
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(90, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(157, 72);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Estudiante";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // pbEstudiante
            // 
            this.pbEstudiante.Image = global::SimulacroSaberPro.Properties.Resources.estudiantePostLogin;
            this.pbEstudiante.Location = new System.Drawing.Point(15, 50);
            this.pbEstudiante.Name = "pbEstudiante";
            this.pbEstudiante.Size = new System.Drawing.Size(75, 72);
            this.pbEstudiante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEstudiante.TabIndex = 0;
            this.pbEstudiante.TabStop = false;
            // 
            // pnInferior
            // 
            this.pnInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.pnInferior.Controls.Add(this.pbLogoUdi);
            this.pnInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnInferior.Location = new System.Drawing.Point(250, 482);
            this.pnInferior.Name = "pnInferior";
            this.pnInferior.Size = new System.Drawing.Size(844, 43);
            this.pnInferior.TabIndex = 8;
            this.pnInferior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnInferior_MouseDown);
            // 
            // pbLogoUdi
            // 
            this.pbLogoUdi.Image = global::SimulacroSaberPro.Properties.Resources.udi__2_;
            this.pbLogoUdi.Location = new System.Drawing.Point(653, 0);
            this.pbLogoUdi.Name = "pbLogoUdi";
            this.pbLogoUdi.Size = new System.Drawing.Size(191, 43);
            this.pbLogoUdi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoUdi.TabIndex = 2;
            this.pbLogoUdi.TabStop = false;
            // 
            // frmEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.BackgroundImage = global::SimulacroSaberPro.Properties.Resources.universidad;
            this.ClientSize = new System.Drawing.Size(1094, 525);
            this.Controls.Add(this.pnInferior);
            this.Controls.Add(this.pnIzquierdo);
            this.Controls.Add(this.pnPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudiante";
            this.Load += new System.EventHandler(this.frmEstudiante_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmEstudiante_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnPrincipal.ResumeLayout(false);
            this.pnPrincipal.PerformLayout();
            this.pnIzquierdo.ResumeLayout(false);
            this.pnIzquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrarSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbContexto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditarPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPresentarPrueba)).EndInit();
            this.pnNombre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEstudiante)).EndInit();
            this.pnInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoUdi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.Panel pnIzquierdo;
        private System.Windows.Forms.PictureBox pbCerrarSesion;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.PictureBox pbContexto;
        private System.Windows.Forms.PictureBox pbEditarPerfil;
        private System.Windows.Forms.PictureBox pbResultados;
        private System.Windows.Forms.Button btnContexto;
        private System.Windows.Forms.Button btnEditarPerfil;
        private System.Windows.Forms.Button btnResultados;
        private System.Windows.Forms.PictureBox pbPresentarPrueba;
        private System.Windows.Forms.Button btnPresentarPrueba;
        private System.Windows.Forms.Panel pnNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pbEstudiante;
        private System.Windows.Forms.Panel pnInferior;
        private System.Windows.Forms.PictureBox pbLogoUdi;
    }
}