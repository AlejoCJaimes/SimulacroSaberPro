namespace SimulacroSaberPro
{
    partial class frmEditarPregunta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarPregunta));
            this.gbPregunta = new System.Windows.Forms.GroupBox();
            this.pnPregunta = new System.Windows.Forms.Panel();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.gbCompetencia = new System.Windows.Forms.GroupBox();
            this.cmbCompetencia = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
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
            this.gbEnunciado = new System.Windows.Forms.GroupBox();
            this.flpEnunciado = new System.Windows.Forms.FlowLayoutPanel();
            this.txtEnunciado = new System.Windows.Forms.TextBox();
            this.cmbPrueba = new System.Windows.Forms.ComboBox();
            this.cmbPregunta = new System.Windows.Forms.ComboBox();
            this.lblPrueba = new System.Windows.Forms.Label();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.btnCloseSesion = new System.Windows.Forms.PictureBox();
            this.gbPregunta.SuspendLayout();
            this.pnPregunta.SuspendLayout();
            this.gbCompetencia.SuspendLayout();
            this.gbOpcionCorrecta.SuspendLayout();
            this.gbOpciones.SuspendLayout();
            this.gbEnunciado.SuspendLayout();
            this.flpEnunciado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseSesion)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPregunta
            // 
            this.gbPregunta.Controls.Add(this.pnPregunta);
            this.gbPregunta.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gbPregunta.ForeColor = System.Drawing.Color.White;
            this.gbPregunta.Location = new System.Drawing.Point(633, 340);
            this.gbPregunta.Name = "gbPregunta";
            this.gbPregunta.Size = new System.Drawing.Size(477, 138);
            this.gbPregunta.TabIndex = 109;
            this.gbPregunta.TabStop = false;
            this.gbPregunta.Text = "Pregunta *";
            // 
            // pnPregunta
            // 
            this.pnPregunta.BackColor = System.Drawing.Color.Gray;
            this.pnPregunta.Controls.Add(this.txtPregunta);
            this.pnPregunta.Location = new System.Drawing.Point(8, 21);
            this.pnPregunta.Name = "pnPregunta";
            this.pnPregunta.Size = new System.Drawing.Size(463, 111);
            this.pnPregunta.TabIndex = 0;
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(3, 3);
            this.txtPregunta.Multiline = true;
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(458, 105);
            this.txtPregunta.TabIndex = 6;
            // 
            // gbCompetencia
            // 
            this.gbCompetencia.Controls.Add(this.cmbCompetencia);
            this.gbCompetencia.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gbCompetencia.ForeColor = System.Drawing.Color.White;
            this.gbCompetencia.Location = new System.Drawing.Point(905, 501);
            this.gbCompetencia.Name = "gbCompetencia";
            this.gbCompetencia.Size = new System.Drawing.Size(208, 195);
            this.gbCompetencia.TabIndex = 105;
            this.gbCompetencia.TabStop = false;
            this.gbCompetencia.Text = "Competencia *";
            // 
            // cmbCompetencia
            // 
            this.cmbCompetencia.FormattingEnabled = true;
            this.cmbCompetencia.Location = new System.Drawing.Point(23, 52);
            this.cmbCompetencia.Name = "cmbCompetencia";
            this.cmbCompetencia.Size = new System.Drawing.Size(169, 25);
            this.cmbCompetencia.TabIndex = 15;
            this.cmbCompetencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCompetencia_KeyPress);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(995, 715);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(115, 36);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // gbOpcionCorrecta
            // 
            this.gbOpcionCorrecta.Controls.Add(this.rbRespuesta4);
            this.gbOpcionCorrecta.Controls.Add(this.rbRespuesta3);
            this.gbOpcionCorrecta.Controls.Add(this.rbRespuesta2);
            this.gbOpcionCorrecta.Controls.Add(this.rbRespuesta1);
            this.gbOpcionCorrecta.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.gbOpcionCorrecta.ForeColor = System.Drawing.Color.White;
            this.gbOpcionCorrecta.Location = new System.Drawing.Point(529, 501);
            this.gbOpcionCorrecta.Name = "gbOpcionCorrecta";
            this.gbOpcionCorrecta.Size = new System.Drawing.Size(362, 195);
            this.gbOpcionCorrecta.TabIndex = 104;
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
            this.rbRespuesta4.TabIndex = 14;
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
            this.rbRespuesta3.TabIndex = 13;
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
            this.rbRespuesta2.TabIndex = 12;
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
            this.rbRespuesta1.TabIndex = 11;
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
            this.gbOpciones.Location = new System.Drawing.Point(31, 501);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(474, 195);
            this.gbOpciones.TabIndex = 103;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones *";
            // 
            // txtOpcion4
            // 
            this.txtOpcion4.Location = new System.Drawing.Point(44, 153);
            this.txtOpcion4.Name = "txtOpcion4";
            this.txtOpcion4.Size = new System.Drawing.Size(410, 22);
            this.txtOpcion4.TabIndex = 10;
            // 
            // txtOpcion3
            // 
            this.txtOpcion3.Location = new System.Drawing.Point(44, 115);
            this.txtOpcion3.Name = "txtOpcion3";
            this.txtOpcion3.Size = new System.Drawing.Size(410, 22);
            this.txtOpcion3.TabIndex = 9;
            // 
            // txtOpcion2
            // 
            this.txtOpcion2.Location = new System.Drawing.Point(44, 75);
            this.txtOpcion2.Name = "txtOpcion2";
            this.txtOpcion2.Size = new System.Drawing.Size(410, 22);
            this.txtOpcion2.TabIndex = 8;
            // 
            // txtOpcion1
            // 
            this.txtOpcion1.Location = new System.Drawing.Point(44, 39);
            this.txtOpcion1.Name = "txtOpcion1";
            this.txtOpcion1.Size = new System.Drawing.Size(410, 22);
            this.txtOpcion1.TabIndex = 7;
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
            // gbEnunciado
            // 
            this.gbEnunciado.Controls.Add(this.flpEnunciado);
            this.gbEnunciado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEnunciado.ForeColor = System.Drawing.Color.White;
            this.gbEnunciado.Location = new System.Drawing.Point(630, 89);
            this.gbEnunciado.Name = "gbEnunciado";
            this.gbEnunciado.Size = new System.Drawing.Size(480, 233);
            this.gbEnunciado.TabIndex = 101;
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
            this.txtEnunciado.TabIndex = 5;
            // 
            // cmbPrueba
            // 
            this.cmbPrueba.FormattingEnabled = true;
            this.cmbPrueba.Location = new System.Drawing.Point(75, 171);
            this.cmbPrueba.Name = "cmbPrueba";
            this.cmbPrueba.Size = new System.Drawing.Size(251, 21);
            this.cmbPrueba.TabIndex = 2;
            this.cmbPrueba.SelectedIndexChanged += new System.EventHandler(this.cmbPrueba_SelectedIndexChanged);
            this.cmbPrueba.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPrueba_KeyPress);
            // 
            // cmbPregunta
            // 
            this.cmbPregunta.FormattingEnabled = true;
            this.cmbPregunta.Location = new System.Drawing.Point(75, 242);
            this.cmbPregunta.Name = "cmbPregunta";
            this.cmbPregunta.Size = new System.Drawing.Size(251, 21);
            this.cmbPregunta.TabIndex = 3;
            this.cmbPregunta.SelectedIndexChanged += new System.EventHandler(this.cmbPregunta_SelectedIndexChanged);
            this.cmbPregunta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPregunta_KeyPress);
            // 
            // lblPrueba
            // 
            this.lblPrueba.AutoSize = true;
            this.lblPrueba.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblPrueba.ForeColor = System.Drawing.Color.White;
            this.lblPrueba.Location = new System.Drawing.Point(72, 153);
            this.lblPrueba.Name = "lblPrueba";
            this.lblPrueba.Size = new System.Drawing.Size(130, 17);
            this.lblPrueba.TabIndex = 1;
            this.lblPrueba.Text = "Seleccione Prueba *";
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblPregunta.ForeColor = System.Drawing.Color.White;
            this.lblPregunta.Location = new System.Drawing.Point(72, 223);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(142, 17);
            this.lblPregunta.TabIndex = 113;
            this.lblPregunta.Text = "Seleccione Pregunta *";
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Image = global::SimulacroSaberPro.Properties.Resources.atras1;
            this.btnVolver.Location = new System.Drawing.Point(12, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(24, 24);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnVolver.TabIndex = 114;
            this.btnVolver.TabStop = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(576, 60);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(118, 17);
            this.lblTitulo.TabIndex = 116;
            this.lblTitulo.Text = "Titulo enunciado: *";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(700, 60);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(410, 20);
            this.txtTitulo.TabIndex = 4;
            // 
            // picMinimize
            // 
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimize.Image = global::SimulacroSaberPro.Properties.Resources.minimizar1;
            this.picMinimize.Location = new System.Drawing.Point(1073, 12);
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
            this.btnCloseSesion.Location = new System.Drawing.Point(1103, 12);
            this.btnCloseSesion.Name = "btnCloseSesion";
            this.btnCloseSesion.Size = new System.Drawing.Size(24, 24);
            this.btnCloseSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCloseSesion.TabIndex = 139;
            this.btnCloseSesion.TabStop = false;
            this.btnCloseSesion.Click += new System.EventHandler(this.btnCloseSesion_Click);
            // 
            // frmEditarPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1141, 763);
            this.Controls.Add(this.picMinimize);
            this.Controls.Add(this.btnCloseSesion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.lblPrueba);
            this.Controls.Add(this.cmbPregunta);
            this.Controls.Add(this.cmbPrueba);
            this.Controls.Add(this.gbPregunta);
            this.Controls.Add(this.gbCompetencia);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gbOpcionCorrecta);
            this.Controls.Add(this.gbOpciones);
            this.Controls.Add(this.gbEnunciado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditarPregunta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Pregunta";
            this.Load += new System.EventHandler(this.frmEditarPregunta_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmEditarPregunta_MouseDown);
            this.gbPregunta.ResumeLayout(false);
            this.pnPregunta.ResumeLayout(false);
            this.pnPregunta.PerformLayout();
            this.gbCompetencia.ResumeLayout(false);
            this.gbOpcionCorrecta.ResumeLayout(false);
            this.gbOpcionCorrecta.PerformLayout();
            this.gbOpciones.ResumeLayout(false);
            this.gbOpciones.PerformLayout();
            this.gbEnunciado.ResumeLayout(false);
            this.flpEnunciado.ResumeLayout(false);
            this.flpEnunciado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseSesion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPregunta;
        private System.Windows.Forms.Panel pnPregunta;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.GroupBox gbCompetencia;
        private System.Windows.Forms.ComboBox cmbCompetencia;
        private System.Windows.Forms.Button btnEditar;
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
        private System.Windows.Forms.GroupBox gbEnunciado;
        private System.Windows.Forms.FlowLayoutPanel flpEnunciado;
        private System.Windows.Forms.TextBox txtEnunciado;
        private System.Windows.Forms.ComboBox cmbPrueba;
        private System.Windows.Forms.ComboBox cmbPregunta;
        private System.Windows.Forms.Label lblPrueba;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.PictureBox btnVolver;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox btnCloseSesion;
    }
}