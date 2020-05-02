namespace SimulacroSaberPro
{
    partial class frmRegistrarPrueba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarPrueba));
            this.lblCont = new System.Windows.Forms.Label();
            this.lblPrueba = new System.Windows.Forms.Label();
            this.lblElaborada = new System.Windows.Forms.Label();
            this.btnCrearPregunta = new System.Windows.Forms.Button();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.cbmMes = new System.Windows.Forms.ComboBox();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.lblFechaPresentacion = new System.Windows.Forms.Label();
            this.pbPrueba = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.txtNumeroPrueba = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCloseSesion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrueba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseSesion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCont
            // 
            this.lblCont.AutoSize = true;
            this.lblCont.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCont.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCont.Location = new System.Drawing.Point(205, 60);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(0, 36);
            this.lblCont.TabIndex = 81;
            // 
            // lblPrueba
            // 
            this.lblPrueba.AutoSize = true;
            this.lblPrueba.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrueba.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrueba.Location = new System.Drawing.Point(52, 62);
            this.lblPrueba.Name = "lblPrueba";
            this.lblPrueba.Size = new System.Drawing.Size(118, 36);
            this.lblPrueba.TabIndex = 1;
            this.lblPrueba.Text = "Prueba";
            // 
            // lblElaborada
            // 
            this.lblElaborada.AutoSize = true;
            this.lblElaborada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElaborada.ForeColor = System.Drawing.SystemColors.Control;
            this.lblElaborada.Location = new System.Drawing.Point(46, 134);
            this.lblElaborada.Name = "lblElaborada";
            this.lblElaborada.Size = new System.Drawing.Size(142, 21);
            this.lblElaborada.TabIndex = 77;
            this.lblElaborada.Text = "Número Prueba *";
            // 
            // btnCrearPregunta
            // 
            this.btnCrearPregunta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearPregunta.FlatAppearance.BorderSize = 0;
            this.btnCrearPregunta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(176)))), ((int)(((byte)(83)))));
            this.btnCrearPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearPregunta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPregunta.ForeColor = System.Drawing.Color.White;
            this.btnCrearPregunta.Location = new System.Drawing.Point(108, 313);
            this.btnCrearPregunta.Name = "btnCrearPregunta";
            this.btnCrearPregunta.Size = new System.Drawing.Size(217, 54);
            this.btnCrearPregunta.TabIndex = 7;
            this.btnCrearPregunta.Text = "Crear Prueba";
            this.btnCrearPregunta.UseVisualStyleBackColor = true;
            this.btnCrearPregunta.Click += new System.EventHandler(this.BtnCrearPregunta_Click_1);
            // 
            // cmbAno
            // 
            this.cmbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Location = new System.Drawing.Point(183, 268);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(93, 21);
            this.cmbAno.TabIndex = 6;
            // 
            // cbmMes
            // 
            this.cbmMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmMes.FormattingEnabled = true;
            this.cbmMes.Items.AddRange(new object[] {
            "Ene",
            "Feb",
            "Mar",
            "Abr",
            "May",
            "Jun",
            "Jul",
            "Ago",
            "Sep",
            "Oct",
            "Nov",
            "Dic"});
            this.cbmMes.Location = new System.Drawing.Point(110, 268);
            this.cbmMes.Name = "cbmMes";
            this.cbmMes.Size = new System.Drawing.Size(67, 21);
            this.cbmMes.TabIndex = 5;
            // 
            // cmbDia
            // 
            this.cmbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbDia.Location = new System.Drawing.Point(48, 268);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(49, 21);
            this.cmbDia.TabIndex = 4;
            // 
            // lblFechaPresentacion
            // 
            this.lblFechaPresentacion.AutoSize = true;
            this.lblFechaPresentacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPresentacion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFechaPresentacion.Location = new System.Drawing.Point(45, 242);
            this.lblFechaPresentacion.Name = "lblFechaPresentacion";
            this.lblFechaPresentacion.Size = new System.Drawing.Size(149, 21);
            this.lblFechaPresentacion.TabIndex = 72;
            this.lblFechaPresentacion.Text = "Fecha Creacion  *";
            // 
            // pbPrueba
            // 
            this.pbPrueba.Image = global::SimulacroSaberPro.Properties.Resources.lista;
            this.pbPrueba.Location = new System.Drawing.Point(284, 51);
            this.pbPrueba.Name = "pbPrueba";
            this.pbPrueba.Size = new System.Drawing.Size(108, 104);
            this.pbPrueba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPrueba.TabIndex = 79;
            this.pbPrueba.TabStop = false;
            this.pbPrueba.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbPrueba_MouseDown);
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Image = global::SimulacroSaberPro.Properties.Resources.atras1;
            this.btnVolver.Location = new System.Drawing.Point(13, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(24, 24);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnVolver.TabIndex = 71;
            this.btnVolver.TabStop = false;
            this.btnVolver.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::SimulacroSaberPro.Properties.Resources.minimizar1;
            this.btnMinimizar.Location = new System.Drawing.Point(369, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(24, 24);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 70;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // txtNumeroPrueba
            // 
            this.txtNumeroPrueba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.txtNumeroPrueba.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroPrueba.ForeColor = System.Drawing.Color.White;
            this.txtNumeroPrueba.Location = new System.Drawing.Point(49, 158);
            this.txtNumeroPrueba.Name = "txtNumeroPrueba";
            this.txtNumeroPrueba.Size = new System.Drawing.Size(49, 22);
            this.txtNumeroPrueba.TabIndex = 2;
            this.txtNumeroPrueba.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeroPrueba_KeyPress);
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(245)))));
            this.txtTitulo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.White;
            this.txtTitulo.Location = new System.Drawing.Point(49, 217);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(227, 22);
            this.txtTitulo.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.Location = new System.Drawing.Point(46, 193);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(61, 21);
            this.lblTitulo.TabIndex = 128;
            this.lblTitulo.Text = "Título *";
            // 
            // btnCloseSesion
            // 
            this.btnCloseSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseSesion.Image = global::SimulacroSaberPro.Properties.Resources.apagar;
            this.btnCloseSesion.Location = new System.Drawing.Point(399, 4);
            this.btnCloseSesion.Name = "btnCloseSesion";
            this.btnCloseSesion.Size = new System.Drawing.Size(24, 24);
            this.btnCloseSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnCloseSesion.TabIndex = 139;
            this.btnCloseSesion.TabStop = false;
            this.btnCloseSesion.Click += new System.EventHandler(this.btnCloseSesion_Click);
            // 
            // frmRegistrarPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(435, 396);
            this.Controls.Add(this.btnCloseSesion);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtNumeroPrueba);
            this.Controls.Add(this.lblCont);
            this.Controls.Add(this.lblPrueba);
            this.Controls.Add(this.pbPrueba);
            this.Controls.Add(this.lblElaborada);
            this.Controls.Add(this.btnCrearPregunta);
            this.Controls.Add(this.cmbAno);
            this.Controls.Add(this.cbmMes);
            this.Controls.Add(this.cmbDia);
            this.Controls.Add(this.lblFechaPresentacion);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnMinimizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistrarPrueba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Prueba";
            this.Load += new System.EventHandler(this.FrmPrueba_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmPrueba_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbPrueba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseSesion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCont;
        private System.Windows.Forms.Label lblPrueba;
        private System.Windows.Forms.PictureBox pbPrueba;
        private System.Windows.Forms.Label lblElaborada;
        private System.Windows.Forms.Button btnCrearPregunta;
        private System.Windows.Forms.ComboBox cmbAno;
        private System.Windows.Forms.ComboBox cbmMes;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.Label lblFechaPresentacion;
        private System.Windows.Forms.PictureBox btnVolver;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.TextBox txtNumeroPrueba;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox btnCloseSesion;
    }
}