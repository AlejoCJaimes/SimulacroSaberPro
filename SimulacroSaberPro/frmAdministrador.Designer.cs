namespace SimulacroSaberPro
{
    partial class frmAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrador));
            this.panelDocente = new System.Windows.Forms.Panel();
            this.pbDocente = new System.Windows.Forms.PictureBox();
            this.btnDocente = new System.Windows.Forms.Button();
            this.panelEstudiante = new System.Windows.Forms.Panel();
            this.pbEstudiante = new System.Windows.Forms.PictureBox();
            this.btnEstudiante = new System.Windows.Forms.Button();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.pbAdministrador = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.PictureBox();
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.panelDocente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDocente)).BeginInit();
            this.panelEstudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEstudiante)).BeginInit();
            this.panelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdministrador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDocente
            // 
            this.panelDocente.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelDocente.Controls.Add(this.pbDocente);
            this.panelDocente.Controls.Add(this.btnDocente);
            this.panelDocente.Location = new System.Drawing.Point(-3, 205);
            this.panelDocente.Name = "panelDocente";
            this.panelDocente.Size = new System.Drawing.Size(778, 93);
            this.panelDocente.TabIndex = 9;
            this.panelDocente.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDocente_MouseDown);
            // 
            // pbDocente
            // 
            this.pbDocente.Image = global::SimulacroSaberPro.Properties.Resources.profesora;
            this.pbDocente.Location = new System.Drawing.Point(468, 0);
            this.pbDocente.Name = "pbDocente";
            this.pbDocente.Size = new System.Drawing.Size(186, 99);
            this.pbDocente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDocente.TabIndex = 55;
            this.pbDocente.TabStop = false;
            // 
            // btnDocente
            // 
            this.btnDocente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDocente.FlatAppearance.BorderSize = 0;
            this.btnDocente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(21)))));
            this.btnDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocente.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocente.ForeColor = System.Drawing.Color.White;
            this.btnDocente.Location = new System.Drawing.Point(123, 18);
            this.btnDocente.Name = "btnDocente";
            this.btnDocente.Size = new System.Drawing.Size(240, 54);
            this.btnDocente.TabIndex = 3;
            this.btnDocente.Text = "Docente";
            this.btnDocente.UseVisualStyleBackColor = true;
            this.btnDocente.Click += new System.EventHandler(this.BtnDocente_Click);
            // 
            // panelEstudiante
            // 
            this.panelEstudiante.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelEstudiante.Controls.Add(this.pbEstudiante);
            this.panelEstudiante.Controls.Add(this.btnEstudiante);
            this.panelEstudiante.Location = new System.Drawing.Point(-3, 100);
            this.panelEstudiante.Name = "panelEstudiante";
            this.panelEstudiante.Size = new System.Drawing.Size(778, 107);
            this.panelEstudiante.TabIndex = 8;
            this.panelEstudiante.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelEstudiante_MouseDown);
            // 
            // pbEstudiante
            // 
            this.pbEstudiante.Image = global::SimulacroSaberPro.Properties.Resources.estudiante;
            this.pbEstudiante.Location = new System.Drawing.Point(468, 0);
            this.pbEstudiante.Name = "pbEstudiante";
            this.pbEstudiante.Size = new System.Drawing.Size(186, 107);
            this.pbEstudiante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEstudiante.TabIndex = 56;
            this.pbEstudiante.TabStop = false;
            // 
            // btnEstudiante
            // 
            this.btnEstudiante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstudiante.FlatAppearance.BorderSize = 0;
            this.btnEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(21)))));
            this.btnEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstudiante.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiante.ForeColor = System.Drawing.Color.White;
            this.btnEstudiante.Location = new System.Drawing.Point(123, 26);
            this.btnEstudiante.Name = "btnEstudiante";
            this.btnEstudiante.Size = new System.Drawing.Size(265, 54);
            this.btnEstudiante.TabIndex = 2;
            this.btnEstudiante.Text = "Estudiante";
            this.btnEstudiante.UseVisualStyleBackColor = true;
            this.btnEstudiante.Click += new System.EventHandler(this.BtnEstudiante_Click);
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelAdmin.Controls.Add(this.picMinimize);
            this.panelAdmin.Controls.Add(this.pbAdministrador);
            this.panelAdmin.Controls.Add(this.btnCerrarSesion);
            this.panelAdmin.Controls.Add(this.btnAdministrador);
            this.panelAdmin.Location = new System.Drawing.Point(-3, -1);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(778, 103);
            this.panelAdmin.TabIndex = 7;
            this.panelAdmin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAdmin_MouseDown);
            // 
            // picMinimize
            // 
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimize.Image = global::SimulacroSaberPro.Properties.Resources.minimizar1;
            this.picMinimize.Location = new System.Drawing.Point(712, 13);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(24, 24);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimize.TabIndex = 58;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // pbAdministrador
            // 
            this.pbAdministrador.Image = global::SimulacroSaberPro.Properties.Resources.administrador;
            this.pbAdministrador.Location = new System.Drawing.Point(468, 0);
            this.pbAdministrador.Name = "pbAdministrador";
            this.pbAdministrador.Size = new System.Drawing.Size(186, 103);
            this.pbAdministrador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdministrador.TabIndex = 57;
            this.pbAdministrador.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Image = global::SimulacroSaberPro.Properties.Resources.apagar;
            this.btnCerrarSesion.Location = new System.Drawing.Point(742, 13);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(24, 24);
            this.btnCerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCerrarSesion.TabIndex = 51;
            this.btnCerrarSesion.TabStop = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdministrador.FlatAppearance.BorderSize = 0;
            this.btnAdministrador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(21)))));
            this.btnAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrador.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrador.ForeColor = System.Drawing.Color.White;
            this.btnAdministrador.Location = new System.Drawing.Point(123, 27);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(311, 54);
            this.btnAdministrador.TabIndex = 1;
            this.btnAdministrador.Text = "Administrador";
            this.btnAdministrador.UseVisualStyleBackColor = true;
            this.btnAdministrador.Click += new System.EventHandler(this.BtnAdministrador_Click);
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 298);
            this.Controls.Add(this.panelEstudiante);
            this.Controls.Add(this.panelDocente);
            this.Controls.Add(this.panelAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.FrmAdministrador_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmAdministrador_MouseDown);
            this.panelDocente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDocente)).EndInit();
            this.panelEstudiante.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEstudiante)).EndInit();
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdministrador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDocente;
        private System.Windows.Forms.PictureBox pbDocente;
        private System.Windows.Forms.Button btnDocente;
        private System.Windows.Forms.Panel panelEstudiante;
        private System.Windows.Forms.PictureBox pbEstudiante;
        private System.Windows.Forms.Button btnEstudiante;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.PictureBox pbAdministrador;
        private System.Windows.Forms.PictureBox btnCerrarSesion;
        private System.Windows.Forms.Button btnAdministrador;
        private System.Windows.Forms.PictureBox picMinimize;
    }
}