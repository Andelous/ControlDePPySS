namespace ControlDePPySS
{
    partial class FrmCartasAceptacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCartasAceptacion));
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.panelCarta = new System.Windows.Forms.Panel();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblDom = new System.Windows.Forms.Label();
            this.lblSab = new System.Windows.Forms.Label();
            this.lblVie = new System.Windows.Forms.Label();
            this.lblJue = new System.Windows.Forms.Label();
            this.lblMie = new System.Windows.Forms.Label();
            this.lblMar = new System.Windows.Forms.Label();
            this.lblLun = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblHas = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblHor = new System.Windows.Forms.Label();
            this.lblOrganizacion = new System.Windows.Forms.Label();
            this.lblCarta = new System.Windows.Forms.Label();
            this.panelAlumno = new System.Windows.Forms.Panel();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.lblLicenciatura = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.panelCartas = new System.Windows.Forms.Panel();
            this.lblConsultaCartas = new System.Windows.Forms.Label();
            this.cmdEliminarCarta = new System.Windows.Forms.Button();
            this.cmdModificarCarta = new System.Windows.Forms.Button();
            this.cmdNuevaCarta = new System.Windows.Forms.Button();
            this.dgvCartas = new System.Windows.Forms.DataGridView();
            this.gbDatos.SuspendLayout();
            this.panelCarta.SuspendLayout();
            this.panelAlumno.SuspendLayout();
            this.panelCartas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.panelCarta);
            this.gbDatos.Controls.Add(this.panelAlumno);
            this.gbDatos.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.Location = new System.Drawing.Point(522, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(250, 511);
            this.gbDatos.TabIndex = 4;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // panelCarta
            // 
            this.panelCarta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCarta.Controls.Add(this.lblDesde);
            this.panelCarta.Controls.Add(this.lblDom);
            this.panelCarta.Controls.Add(this.lblSab);
            this.panelCarta.Controls.Add(this.lblVie);
            this.panelCarta.Controls.Add(this.lblJue);
            this.panelCarta.Controls.Add(this.lblMie);
            this.panelCarta.Controls.Add(this.lblMar);
            this.panelCarta.Controls.Add(this.lblLun);
            this.panelCarta.Controls.Add(this.lblHasta);
            this.panelCarta.Controls.Add(this.lblHas);
            this.panelCarta.Controls.Add(this.lblHorario);
            this.panelCarta.Controls.Add(this.lblD);
            this.panelCarta.Controls.Add(this.lblHor);
            this.panelCarta.Controls.Add(this.lblOrganizacion);
            this.panelCarta.Controls.Add(this.lblCarta);
            this.panelCarta.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCarta.Location = new System.Drawing.Point(1, 274);
            this.panelCarta.Name = "panelCarta";
            this.panelCarta.Size = new System.Drawing.Size(248, 217);
            this.panelCarta.TabIndex = 2;
            this.panelCarta.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCarta_Paint);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDesde.ForeColor = System.Drawing.Color.Black;
            this.lblDesde.Location = new System.Drawing.Point(67, 82);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(19, 19);
            this.lblDesde.TabIndex = 20;
            this.lblDesde.Text = "--";
            // 
            // lblDom
            // 
            this.lblDom.AutoSize = true;
            this.lblDom.Location = new System.Drawing.Point(202, 182);
            this.lblDom.Name = "lblDom";
            this.lblDom.Size = new System.Drawing.Size(26, 26);
            this.lblDom.TabIndex = 19;
            this.lblDom.Text = "D";
            // 
            // lblSab
            // 
            this.lblSab.AutoSize = true;
            this.lblSab.Location = new System.Drawing.Point(174, 182);
            this.lblSab.Name = "lblSab";
            this.lblSab.Size = new System.Drawing.Size(22, 26);
            this.lblSab.TabIndex = 18;
            this.lblSab.Text = "S";
            // 
            // lblVie
            // 
            this.lblVie.AutoSize = true;
            this.lblVie.ForeColor = System.Drawing.Color.Black;
            this.lblVie.Location = new System.Drawing.Point(145, 182);
            this.lblVie.Name = "lblVie";
            this.lblVie.Size = new System.Drawing.Size(23, 26);
            this.lblVie.TabIndex = 17;
            this.lblVie.Text = "V";
            // 
            // lblJue
            // 
            this.lblJue.AutoSize = true;
            this.lblJue.ForeColor = System.Drawing.Color.Black;
            this.lblJue.Location = new System.Drawing.Point(122, 182);
            this.lblJue.Name = "lblJue";
            this.lblJue.Size = new System.Drawing.Size(17, 26);
            this.lblJue.TabIndex = 16;
            this.lblJue.Text = "J";
            // 
            // lblMie
            // 
            this.lblMie.AutoSize = true;
            this.lblMie.ForeColor = System.Drawing.Color.Black;
            this.lblMie.Location = new System.Drawing.Point(87, 182);
            this.lblMie.Name = "lblMie";
            this.lblMie.Size = new System.Drawing.Size(29, 26);
            this.lblMie.TabIndex = 15;
            this.lblMie.Text = "M";
            // 
            // lblMar
            // 
            this.lblMar.AutoSize = true;
            this.lblMar.ForeColor = System.Drawing.Color.Black;
            this.lblMar.Location = new System.Drawing.Point(52, 182);
            this.lblMar.Name = "lblMar";
            this.lblMar.Size = new System.Drawing.Size(29, 26);
            this.lblMar.TabIndex = 14;
            this.lblMar.Text = "M";
            // 
            // lblLun
            // 
            this.lblLun.AutoSize = true;
            this.lblLun.ForeColor = System.Drawing.Color.Black;
            this.lblLun.Location = new System.Drawing.Point(24, 182);
            this.lblLun.Name = "lblLun";
            this.lblLun.Size = new System.Drawing.Size(22, 26);
            this.lblLun.TabIndex = 13;
            this.lblLun.Text = "L";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblHasta.ForeColor = System.Drawing.Color.Black;
            this.lblHasta.Location = new System.Drawing.Point(67, 105);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(19, 19);
            this.lblHasta.TabIndex = 12;
            this.lblHasta.Text = "--";
            // 
            // lblHas
            // 
            this.lblHas.AutoSize = true;
            this.lblHas.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblHas.ForeColor = System.Drawing.Color.Black;
            this.lblHas.Location = new System.Drawing.Point(8, 105);
            this.lblHas.Name = "lblHas";
            this.lblHas.Size = new System.Drawing.Size(53, 19);
            this.lblHas.TabIndex = 12;
            this.lblHas.Text = "Hasta:";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(7, 153);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(120, 22);
            this.lblHorario.TabIndex = 10;
            this.lblHorario.Text = "..:.. am - ..:.. pm";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblD.ForeColor = System.Drawing.Color.Black;
            this.lblD.Location = new System.Drawing.Point(8, 82);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(55, 19);
            this.lblD.TabIndex = 8;
            this.lblD.Text = "Desde:";
            // 
            // lblHor
            // 
            this.lblHor.AutoSize = true;
            this.lblHor.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHor.Location = new System.Drawing.Point(6, 133);
            this.lblHor.Name = "lblHor";
            this.lblHor.Size = new System.Drawing.Size(66, 20);
            this.lblHor.TabIndex = 6;
            this.lblHor.Text = "Horario";
            // 
            // lblOrganizacion
            // 
            this.lblOrganizacion.AutoSize = true;
            this.lblOrganizacion.Location = new System.Drawing.Point(5, 49);
            this.lblOrganizacion.Name = "lblOrganizacion";
            this.lblOrganizacion.Size = new System.Drawing.Size(126, 26);
            this.lblOrganizacion.TabIndex = 5;
            this.lblOrganizacion.Text = "Sin selección";
            // 
            // lblCarta
            // 
            this.lblCarta.AutoSize = true;
            this.lblCarta.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCarta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCarta.Location = new System.Drawing.Point(6, 7);
            this.lblCarta.Name = "lblCarta";
            this.lblCarta.Size = new System.Drawing.Size(63, 26);
            this.lblCarta.TabIndex = 4;
            this.lblCarta.Text = "Carta";
            // 
            // panelAlumno
            // 
            this.panelAlumno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAlumno.Controls.Add(this.lblApellidos);
            this.panelAlumno.Controls.Add(this.lblSemestre);
            this.panelAlumno.Controls.Add(this.lblLicenciatura);
            this.panelAlumno.Controls.Add(this.lblMatricula);
            this.panelAlumno.Controls.Add(this.lblNombre);
            this.panelAlumno.Controls.Add(this.lblAlumno);
            this.panelAlumno.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAlumno.Location = new System.Drawing.Point(1, 35);
            this.panelAlumno.Name = "panelAlumno";
            this.panelAlumno.Size = new System.Drawing.Size(248, 217);
            this.panelAlumno.TabIndex = 0;
            this.panelAlumno.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAlumno_Paint);
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(6, 81);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(94, 26);
            this.lblApellidos.TabIndex = 5;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSemestre.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblSemestre.ForeColor = System.Drawing.Color.Teal;
            this.lblSemestre.Location = new System.Drawing.Point(7, 178);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(73, 19);
            this.lblSemestre.TabIndex = 4;
            this.lblSemestre.Text = "Semestre";
            // 
            // lblLicenciatura
            // 
            this.lblLicenciatura.AutoSize = true;
            this.lblLicenciatura.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLicenciatura.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblLicenciatura.ForeColor = System.Drawing.Color.Teal;
            this.lblLicenciatura.Location = new System.Drawing.Point(7, 154);
            this.lblLicenciatura.Name = "lblLicenciatura";
            this.lblLicenciatura.Size = new System.Drawing.Size(93, 19);
            this.lblLicenciatura.TabIndex = 3;
            this.lblLicenciatura.Text = "Licenciatura";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(7, 119);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(82, 22);
            this.lblMatricula.TabIndex = 2;
            this.lblMatricula.Text = "Matrícula";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(86, 26);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAlumno.Location = new System.Drawing.Point(6, 7);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(86, 26);
            this.lblAlumno.TabIndex = 0;
            this.lblAlumno.Text = "Alumno";
            // 
            // panelCartas
            // 
            this.panelCartas.BackColor = System.Drawing.SystemColors.Control;
            this.panelCartas.Controls.Add(this.lblConsultaCartas);
            this.panelCartas.Controls.Add(this.cmdEliminarCarta);
            this.panelCartas.Controls.Add(this.cmdModificarCarta);
            this.panelCartas.Controls.Add(this.cmdNuevaCarta);
            this.panelCartas.Controls.Add(this.dgvCartas);
            this.panelCartas.Location = new System.Drawing.Point(0, 0);
            this.panelCartas.Name = "panelCartas";
            this.panelCartas.Size = new System.Drawing.Size(516, 535);
            this.panelCartas.TabIndex = 3;
            // 
            // lblConsultaCartas
            // 
            this.lblConsultaCartas.AutoSize = true;
            this.lblConsultaCartas.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaCartas.Location = new System.Drawing.Point(12, 19);
            this.lblConsultaCartas.Name = "lblConsultaCartas";
            this.lblConsultaCartas.Size = new System.Drawing.Size(205, 28);
            this.lblConsultaCartas.TabIndex = 11;
            this.lblConsultaCartas.Text = "Consulta de cartas";
            // 
            // cmdEliminarCarta
            // 
            this.cmdEliminarCarta.Enabled = false;
            this.cmdEliminarCarta.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminarCarta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmdEliminarCarta.Location = new System.Drawing.Point(335, 492);
            this.cmdEliminarCarta.Name = "cmdEliminarCarta";
            this.cmdEliminarCarta.Size = new System.Drawing.Size(150, 30);
            this.cmdEliminarCarta.TabIndex = 42;
            this.cmdEliminarCarta.Text = "Eliminar selección";
            this.cmdEliminarCarta.UseVisualStyleBackColor = true;
            this.cmdEliminarCarta.Click += new System.EventHandler(this.cmdEliminarCarta_Click);
            // 
            // cmdModificarCarta
            // 
            this.cmdModificarCarta.Enabled = false;
            this.cmdModificarCarta.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificarCarta.Location = new System.Drawing.Point(179, 492);
            this.cmdModificarCarta.Name = "cmdModificarCarta";
            this.cmdModificarCarta.Size = new System.Drawing.Size(150, 30);
            this.cmdModificarCarta.TabIndex = 41;
            this.cmdModificarCarta.Text = "Modificar selección...";
            this.cmdModificarCarta.UseVisualStyleBackColor = true;
            this.cmdModificarCarta.Click += new System.EventHandler(this.cmdModificarCarta_Click);
            // 
            // cmdNuevaCarta
            // 
            this.cmdNuevaCarta.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevaCarta.Location = new System.Drawing.Point(23, 492);
            this.cmdNuevaCarta.Name = "cmdNuevaCarta";
            this.cmdNuevaCarta.Size = new System.Drawing.Size(150, 30);
            this.cmdNuevaCarta.TabIndex = 40;
            this.cmdNuevaCarta.Text = "Registrar carta...";
            this.cmdNuevaCarta.UseVisualStyleBackColor = true;
            this.cmdNuevaCarta.Click += new System.EventHandler(this.cmdNuevaCarta_Click);
            // 
            // dgvCartas
            // 
            this.dgvCartas.AllowUserToAddRows = false;
            this.dgvCartas.AllowUserToDeleteRows = false;
            this.dgvCartas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCartas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCartas.Location = new System.Drawing.Point(6, 68);
            this.dgvCartas.Name = "dgvCartas";
            this.dgvCartas.ReadOnly = true;
            this.dgvCartas.RowHeadersWidth = 43;
            this.dgvCartas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCartas.Size = new System.Drawing.Size(504, 412);
            this.dgvCartas.TabIndex = 0;
            this.dgvCartas.SelectionChanged += new System.EventHandler(this.dgvCartas_SelectionChanged);
            // 
            // FrmCartasAceptacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 535);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.panelCartas);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(800, 574);
            this.Name = "FrmCartasAceptacion";
            this.Text = "Cartas de aceptación";
            this.Load += new System.EventHandler(this.FrmCartasAceptacion_Load);
            this.Resize += new System.EventHandler(this.FrmCartasAceptacion_Resize);
            this.gbDatos.ResumeLayout(false);
            this.panelCarta.ResumeLayout(false);
            this.panelCarta.PerformLayout();
            this.panelAlumno.ResumeLayout(false);
            this.panelAlumno.PerformLayout();
            this.panelCartas.ResumeLayout(false);
            this.panelCartas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Panel panelAlumno;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.Label lblLicenciatura;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Panel panelCartas;
        private System.Windows.Forms.Label lblConsultaCartas;
        private System.Windows.Forms.Button cmdEliminarCarta;
        private System.Windows.Forms.Button cmdModificarCarta;
        private System.Windows.Forms.Button cmdNuevaCarta;
        private System.Windows.Forms.DataGridView dgvCartas;
        private System.Windows.Forms.Panel panelCarta;
        private System.Windows.Forms.Label lblDom;
        private System.Windows.Forms.Label lblSab;
        private System.Windows.Forms.Label lblVie;
        private System.Windows.Forms.Label lblJue;
        private System.Windows.Forms.Label lblMie;
        private System.Windows.Forms.Label lblMar;
        private System.Windows.Forms.Label lblLun;
        private System.Windows.Forms.Label lblHas;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblHor;
        private System.Windows.Forms.Label lblOrganizacion;
        private System.Windows.Forms.Label lblCarta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
    }
}