namespace SimulacroSaberPro
{
    partial class frmRegistrarPregunta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarPregunta));
            this.gbPregunta = new System.Windows.Forms.GroupBox();
            this.pbPregunta = new System.Windows.Forms.Panel();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.gbCompetencia = new System.Windows.Forms.GroupBox();
            this.cmbCompetencia = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbOpcionCorrecta = new System.Windows.Forms.GroupBox();
            this.rbRespuesta4 = new System.Windows.Forms.RadioButton();
            this.rbRespuesta3 = new System.Windows.Forms.RadioButton();
            this.rbRespuesta2 = new System.Windows.Forms.RadioButton();
            this.rbRespuesta1 = new System.Windows.Forms.RadioButton();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.txtOpcion4 = new System.Windows.Forms.TextBox();
            this.txtOpcion3 = new System.Windows.Forms.TextBox();
            this.txtOpcion2 = new System.Windows.Forms.TextBox();
            this.txtOpcion1 = new System.Windows.Forms.TextBox();
            this.lblOpcion4 = new System.Windows.Forms.Label();
            this.lblOpcion3 = new System.Windows.Forms.Label();
            this.lblOpcion2 = new System.Windows.Forms.Label();
            this.lblOpcion1 = new System.Windows.Forms.Label();
            this.gbImagen = new System.Windows.Forms.GroupBox();
            this.rbImageNo = new System.Windows.Forms.RadioButton();
            this.rbImageSi = new System.Windows.Forms.RadioButton();
            this.gbEnunciado = new System.Windows.Forms.GroupBox();
            this.flpEnunciado = new System.Windows.Forms.FlowLayoutPanel();
            this.txtEnunciado = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.PictureBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPrueba = new System.Windows.Forms.Label();
            this.cmbPrueba = new System.Windows.Forms.ComboBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.btnCloseSesion = new System.Windows.Forms.PictureBox();
            this.openFileDialogSeleccionarImagen = new System.Windows.Forms.OpenFileDialog();
            this.gbPregunta.SuspendLayout();
            this.pbPregunta.SuspendLayout();
            this.gbCompetencia.SuspendLayout();
            this.gbOpcionCorrecta.SuspendLayout();
            this.gbOpciones.SuspendLayout();
            this.gbImagen.SuspendLayout();
            this.gbEnunciado.SuspendLayout();
            this.flpEnunciado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseSesion)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPregunta
            // 
            this.gbPregunta.Controls.Add(this.pbPregunta);
            this.gbPregunta.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gbPregunta.ForeColor = System.Drawing.Color.White;
            this.gbPregunta.Location = new System.Drawing.Point(45, 292);
            this.gbPregunta.Name = "gbPregunta";
            this.gbPregunta.Size = new System.Drawing.Size(477, 138);
            this.gbPregunta.TabIndex = 100;
            this.gbPregunta.TabStop = false;
            this.gbPregunta.Text = "Pregunta *";
            // 
            // pbPregunta
            // 
            this.pbPregunta.BackColor = System.Drawing.Color.Gray;
            this.pbPregunta.Controls.Add(this.txtPregunta);
            this.pbPregunta.Location = new System.Drawing.Point(8, 21);
            this.pbPregunta.Name = "pbPregunta";
            this.pbPregunta.Size = new System.Drawing.Size(463, 111);
            this.pbPregunta.TabIndex = 0;
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(3, 3);
            this.txtPregunta.Multiline = true;
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(458, 105);
            this.txtPregunta.TabIndex = 5;
            // 
            // gbCompetencia
            // 
            this.gbCompetencia.Controls.Add(this.cmbCompetencia);
            this.gbCompetencia.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gbCompetencia.ForeColor = System.Drawing.Color.White;
            this.gbCompetencia.Location = new System.Drawing.Point(922, 436);
            this.gbCompetencia.Name = "gbCompetencia";
            this.gbCompetencia.Size = new System.Drawing.Size(208, 195);
            this.gbCompetencia.TabIndex = 95;
            this.gbCompetencia.TabStop = false;
            this.gbCompetencia.Text = "Competencia *";
            // 
            // cmbCompetencia
            // 
            this.cmbCompetencia.FormattingEnabled = true;
            this.cmbCompetencia.Location = new System.Drawing.Point(23, 52);
            this.cmbCompetencia.Name = "cmbCompetencia";
            this.cmbCompetencia.Size = new System.Drawing.Size(169, 25);
            this.cmbCompetencia.TabIndex = 14;
            this.cmbCompetencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCompetencia_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(176)))), ((int)(((byte)(83)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(999, 660);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 36);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // gbOpcionCorrecta
            // 
            this.gbOpcionCorrecta.Controls.Add(this.rbRespuesta4);
            this.gbOpcionCorrecta.Controls.Add(this.rbRespuesta3);
            this.gbOpcionCorrecta.Controls.Add(this.rbRespuesta2);
            this.gbOpcionCorrecta.Controls.Add(this.rbRespuesta1);
            this.gbOpcionCorrecta.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gbOpcionCorrecta.ForeColor = System.Drawing.Color.White;
            this.gbOpcionCorrecta.Location = new System.Drawing.Point(546, 436);
            this.gbOpcionCorrecta.Name = "gbOpcionCorrecta";
            this.gbOpcionCorrecta.Size = new System.Drawing.Size(362, 195);
            this.gbOpcionCorrecta.TabIndex = 94;
            this.gbOpcionCorrecta.TabStop = false;
            this.gbOpcionCorrecta.Text = "Opcion Correcta *";
            // 
            // rbRespuesta4
            // 
            this.rbRespuesta4.AutoSize = true;
            this.rbRespuesta4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.rbRespuesta4.Location = new System.Drawing.Point(42, 151);
            this.rbRespuesta4.Name = "rbRespuesta4";
            this.rbRespuesta4.Size = new System.Drawing.Size(42, 24);
            this.rbRespuesta4.TabIndex = 13;
            this.rbRespuesta4.TabStop = true;
            this.rbRespuesta4.Text = "d)";
            this.rbRespuesta4.UseVisualStyleBackColor = true;
            // 
            // rbRespuesta3
            // 
            this.rbRespuesta3.AutoSize = true;
            this.rbRespuesta3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.rbRespuesta3.Location = new System.Drawing.Point(42, 115);
            this.rbRespuesta3.Name = "rbRespuesta3";
            this.rbRespuesta3.Size = new System.Drawing.Size(42, 24);
            this.rbRespuesta3.TabIndex = 12;
            this.rbRespuesta3.TabStop = true;
            this.rbRespuesta3.Text = "c)";
            this.rbRespuesta3.UseVisualStyleBackColor = true;
            // 
            // rbRespuesta2
            // 
            this.rbRespuesta2.AutoSize = true;
            this.rbRespuesta2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.rbRespuesta2.Location = new System.Drawing.Point(42, 75);
            this.rbRespuesta2.Name = "rbRespuesta2";
            this.rbRespuesta2.Size = new System.Drawing.Size(42, 24);
            this.rbRespuesta2.TabIndex = 11;
            this.rbRespuesta2.Text = "b)";
            this.rbRespuesta2.UseVisualStyleBackColor = true;
            // 
            // rbRespuesta1
            // 
            this.rbRespuesta1.AutoSize = true;
            this.rbRespuesta1.Checked = true;
            this.rbRespuesta1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.rbRespuesta1.Location = new System.Drawing.Point(42, 35);
            this.rbRespuesta1.Name = "rbRespuesta1";
            this.rbRespuesta1.Size = new System.Drawing.Size(42, 24);
            this.rbRespuesta1.TabIndex = 10;
            this.rbRespuesta1.TabStop = true;
            this.rbRespuesta1.Text = "a)";
            this.rbRespuesta1.UseVisualStyleBackColor = true;
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.txtOpcion4);
            this.gbOpciones.Controls.Add(this.txtOpcion3);
            this.gbOpciones.Controls.Add(this.txtOpcion2);
            this.gbOpciones.Controls.Add(this.txtOpcion1);
            this.gbOpciones.Controls.Add(this.lblOpcion4);
            this.gbOpciones.Controls.Add(this.lblOpcion3);
            this.gbOpciones.Controls.Add(this.lblOpcion2);
            this.gbOpciones.Controls.Add(this.lblOpcion1);
            this.gbOpciones.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gbOpciones.ForeColor = System.Drawing.Color.White;
            this.gbOpciones.Location = new System.Drawing.Point(48, 436);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(474, 195);
            this.gbOpciones.TabIndex = 93;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones *";
            // 
            // txtOpcion4
            // 
            this.txtOpcion4.Location = new System.Drawing.Point(44, 153);
            this.txtOpcion4.Name = "txtOpcion4";
            this.txtOpcion4.Size = new System.Drawing.Size(410, 22);
            this.txtOpcion4.TabIndex = 9;
            // 
            // txtOpcion3
            // 
            this.txtOpcion3.Location = new System.Drawing.Point(44, 115);
            this.txtOpcion3.Name = "txtOpcion3";
            this.txtOpcion3.Size = new System.Drawing.Size(410, 22);
            this.txtOpcion3.TabIndex = 8;
            // 
            // txtOpcion2
            // 
            this.txtOpcion2.Location = new System.Drawing.Point(44, 75);
            this.txtOpcion2.Name = "txtOpcion2";
            this.txtOpcion2.Size = new System.Drawing.Size(410, 22);
            this.txtOpcion2.TabIndex = 7;
            // 
            // txtOpcion1
            // 
            this.txtOpcion1.Location = new System.Drawing.Point(44, 39);
            this.txtOpcion1.Name = "txtOpcion1";
            this.txtOpcion1.Size = new System.Drawing.Size(410, 22);
            this.txtOpcion1.TabIndex = 6;
            // 
            // lblOpcion4
            // 
            this.lblOpcion4.AutoSize = true;
            this.lblOpcion4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcion4.Location = new System.Drawing.Point(14, 153);
            this.lblOpcion4.Name = "lblOpcion4";
            this.lblOpcion4.Size = new System.Drawing.Size(24, 20);
            this.lblOpcion4.TabIndex = 3;
            this.lblOpcion4.Text = "d)";
            // 
            // lblOpcion3
            // 
            this.lblOpcion3.AutoSize = true;
            this.lblOpcion3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcion3.Location = new System.Drawing.Point(14, 117);
            this.lblOpcion3.Name = "lblOpcion3";
            this.lblOpcion3.Size = new System.Drawing.Size(24, 20);
            this.lblOpcion3.TabIndex = 2;
            this.lblOpcion3.Text = "c)";
            // 
            // lblOpcion2
            // 
            this.lblOpcion2.AutoSize = true;
            this.lblOpcion2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcion2.Location = new System.Drawing.Point(14, 75);
            this.lblOpcion2.Name = "lblOpcion2";
            this.lblOpcion2.Size = new System.Drawing.Size(24, 20);
            this.lblOpcion2.TabIndex = 1;
            this.lblOpcion2.Text = "b)";
            // 
            // lblOpcion1
            // 
            this.lblOpcion1.AutoSize = true;
            this.lblOpcion1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcion1.Location = new System.Drawing.Point(14, 39);
            this.lblOpcion1.Name = "lblOpcion1";
            this.lblOpcion1.Size = new System.Drawing.Size(24, 20);
            this.lblOpcion1.TabIndex = 0;
            this.lblOpcion1.Text = "a)";
            // 
            // gbImagen
            // 
            this.gbImagen.Controls.Add(this.rbImageNo);
            this.gbImagen.Controls.Add(this.rbImageSi);
            this.gbImagen.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gbImagen.ForeColor = System.Drawing.Color.White;
            this.gbImagen.Location = new System.Drawing.Point(546, 145);
            this.gbImagen.Name = "gbImagen";
            this.gbImagen.Size = new System.Drawing.Size(508, 266);
            this.gbImagen.TabIndex = 92;
            this.gbImagen.TabStop = false;
            this.gbImagen.Text = "Imagen";
            // 
            // rbImageNo
            // 
            this.rbImageNo.AutoSize = true;
            this.rbImageNo.Location = new System.Drawing.Point(296, 21);
            this.rbImageNo.Name = "rbImageNo";
            this.rbImageNo.Size = new System.Drawing.Size(43, 21);
            this.rbImageNo.TabIndex = 1;
            this.rbImageNo.TabStop = true;
            this.rbImageNo.Text = "No";
            this.rbImageNo.UseVisualStyleBackColor = true;
            // 
            // rbImageSi
            // 
            this.rbImageSi.AutoSize = true;
            this.rbImageSi.Location = new System.Drawing.Point(199, 21);
            this.rbImageSi.Name = "rbImageSi";
            this.rbImageSi.Size = new System.Drawing.Size(36, 21);
            this.rbImageSi.TabIndex = 0;
            this.rbImageSi.TabStop = true;
            this.rbImageSi.Text = "Si";
            this.rbImageSi.UseVisualStyleBackColor = true;
            // 
            // gbEnunciado
            // 
            this.gbEnunciado.Controls.Add(this.flpEnunciado);
            this.gbEnunciado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEnunciado.ForeColor = System.Drawing.Color.White;
            this.gbEnunciado.Location = new System.Drawing.Point(45, 45);
            this.gbEnunciado.Name = "gbEnunciado";
            this.gbEnunciado.Size = new System.Drawing.Size(480, 233);
            this.gbEnunciado.TabIndex = 91;
            this.gbEnunciado.TabStop = false;
            this.gbEnunciado.Text = "Enunciado *";
            // 
            // flpEnunciado
            // 
            this.flpEnunciado.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.flpEnunciado.Controls.Add(this.txtEnunciado);
            this.flpEnunciado.Location = new System.Drawing.Point(3, 18);
            this.flpEnunciado.Name = "flpEnunciado";
            this.flpEnunciado.Size = new System.Drawing.Size(474, 206);
            this.flpEnunciado.TabIndex = 0;
            // 
            // txtEnunciado
            // 
            this.txtEnunciado.Location = new System.Drawing.Point(3, 3);
            this.txtEnunciado.Multiline = true;
            this.txtEnunciado.Name = "txtEnunciado";
            this.txtEnunciado.Size = new System.Drawing.Size(468, 200);
            this.txtEnunciado.TabIndex = 4;
            // 
            // btnReturn
            // 
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Image = global::SimulacroSaberPro.Properties.Resources.atras1;
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(24, 24);
            this.btnReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnReturn.TabIndex = 99;
            this.btnReturn.TabStop = false;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(667, 90);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(410, 20);
            this.txtTitulo.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(543, 90);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(118, 17);
            this.lblTitulo.TabIndex = 102;
            this.lblTitulo.Text = "Titulo enunciado: *";
            // 
            // lblPrueba
            // 
            this.lblPrueba.AutoSize = true;
            this.lblPrueba.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblPrueba.ForeColor = System.Drawing.Color.White;
            this.lblPrueba.Location = new System.Drawing.Point(531, 45);
            this.lblPrueba.Name = "lblPrueba";
            this.lblPrueba.Size = new System.Drawing.Size(130, 17);
            this.lblPrueba.TabIndex = 1;
            this.lblPrueba.Text = "Seleccione Prueba *";
            // 
            // cmbPrueba
            // 
            this.cmbPrueba.FormattingEnabled = true;
            this.cmbPrueba.Location = new System.Drawing.Point(667, 45);
            this.cmbPrueba.Name = "cmbPrueba";
            this.cmbPrueba.Size = new System.Drawing.Size(251, 21);
            this.cmbPrueba.TabIndex = 2;
            this.cmbPrueba.SelectedIndexChanged += new System.EventHandler(this.cmbPrueba_SelectedIndexChanged);
            this.cmbPrueba.Click += new System.EventHandler(this.cmbPrueba_Click);
            this.cmbPrueba.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPrueba_KeyPress);
            // 
            // picMinimize
            // 
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimize.Image = global::SimulacroSaberPro.Properties.Resources.minimizar1;
            this.picMinimize.Location = new System.Drawing.Point(1075, 12);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(24, 24);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimize.TabIndex = 140;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // btnCloseSesion
            // 
            this.btnCloseSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseSesion.Image = global::SimulacroSaberPro.Properties.Resources.apagar;
            this.btnCloseSesion.Location = new System.Drawing.Point(1105, 12);
            this.btnCloseSesion.Name = "btnCloseSesion";
            this.btnCloseSesion.Size = new System.Drawing.Size(24, 24);
            this.btnCloseSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCloseSesion.TabIndex = 139;
            this.btnCloseSesion.TabStop = false;
            this.btnCloseSesion.Click += new System.EventHandler(this.btnCloseSesion_Click);
            // 
            // openFileDialogSeleccionarImagen
            // 
            this.openFileDialogSeleccionarImagen.FileName = "openFileDialog1";
            this.openFileDialogSeleccionarImagen.Filter = "Archivos JPEG|*.jpg";
            this.openFileDialogSeleccionarImagen.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // frmRegistrarPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1141, 719);
            this.Controls.Add(this.picMinimize);
            this.Controls.Add(this.btnCloseSesion);
            this.Controls.Add(this.lblPrueba);
            this.Controls.Add(this.cmbPrueba);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.gbPregunta);
            this.Controls.Add(this.gbCompetencia);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbOpcionCorrecta);
            this.Controls.Add(this.gbOpciones);
            this.Controls.Add(this.gbImagen);
            this.Controls.Add(this.gbEnunciado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistrarPregunta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Pregunta";
            this.Load += new System.EventHandler(this.FrmRegistrarPregunta_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmRegistrarPregunta_MouseDown);
            this.gbPregunta.ResumeLayout(false);
            this.pbPregunta.ResumeLayout(false);
            this.pbPregunta.PerformLayout();
            this.gbCompetencia.ResumeLayout(false);
            this.gbOpcionCorrecta.ResumeLayout(false);
            this.gbOpcionCorrecta.PerformLayout();
            this.gbOpciones.ResumeLayout(false);
            this.gbOpciones.PerformLayout();
            this.gbImagen.ResumeLayout(false);
            this.gbImagen.PerformLayout();
            this.gbEnunciado.ResumeLayout(false);
            this.flpEnunciado.ResumeLayout(false);
            this.flpEnunciado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseSesion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPregunta;
        private System.Windows.Forms.Panel pbPregunta;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.GroupBox gbCompetencia;
        private System.Windows.Forms.ComboBox cmbCompetencia;
        private System.Windows.Forms.PictureBox btnReturn;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbOpcionCorrecta;
        private System.Windows.Forms.RadioButton rbRespuesta4;
        private System.Windows.Forms.RadioButton rbRespuesta3;
        private System.Windows.Forms.RadioButton rbRespuesta2;
        private System.Windows.Forms.RadioButton rbRespuesta1;
        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.TextBox txtOpcion4;
        private System.Windows.Forms.TextBox txtOpcion3;
        private System.Windows.Forms.TextBox txtOpcion2;
        private System.Windows.Forms.TextBox txtOpcion1;
        private System.Windows.Forms.Label lblOpcion4;
        private System.Windows.Forms.Label lblOpcion3;
        private System.Windows.Forms.Label lblOpcion2;
        private System.Windows.Forms.Label lblOpcion1;
        private System.Windows.Forms.GroupBox gbImagen;
        private System.Windows.Forms.RadioButton rbImageNo;
        private System.Windows.Forms.RadioButton rbImageSi;
        private System.Windows.Forms.GroupBox gbEnunciado;
        private System.Windows.Forms.FlowLayoutPanel flpEnunciado;
        private System.Windows.Forms.TextBox txtEnunciado;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPrueba;
        private System.Windows.Forms.ComboBox cmbPrueba;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox btnCloseSesion;
        private System.Windows.Forms.OpenFileDialog openFileDialogSeleccionarImagen;
    }
}