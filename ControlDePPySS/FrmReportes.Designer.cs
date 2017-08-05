namespace ControlDePPySS
{
    partial class FrmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.panelReporte = new System.Windows.Forms.Panel();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblHorasLiberadas = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblHL = new System.Windows.Forms.Label();
            this.lblOrganizacion = new System.Windows.Forms.Label();
            this.lblReporte = new System.Windows.Forms.Label();
            this.panelAlumno = new System.Windows.Forms.Panel();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.lblLicenciatura = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.panelReportes = new System.Windows.Forms.Panel();
            this.lblConsultaReportes = new System.Windows.Forms.Label();
            this.cmdEliminarReporte = new System.Windows.Forms.Button();
            this.cmdModificarReporte = new System.Windows.Forms.Button();
            this.cmdNuevoReporte = new System.Windows.Forms.Button();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.gbDatos.SuspendLayout();
            this.panelReporte.SuspendLayout();
            this.panelAlumno.SuspendLayout();
            this.panelReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.panelReporte);
            this.gbDatos.Controls.Add(this.panelAlumno);
            this.gbDatos.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.Location = new System.Drawing.Point(522, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(250, 511);
            this.gbDatos.TabIndex = 6;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // panelReporte
            // 
            this.panelReporte.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelReporte.Controls.Add(this.lblHasta);
            this.panelReporte.Controls.Add(this.lblDesde);
            this.panelReporte.Controls.Add(this.lblH);
            this.panelReporte.Controls.Add(this.lblHorasLiberadas);
            this.panelReporte.Controls.Add(this.lblD);
            this.panelReporte.Controls.Add(this.lblHL);
            this.panelReporte.Controls.Add(this.lblOrganizacion);
            this.panelReporte.Controls.Add(this.lblReporte);
            this.panelReporte.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelReporte.Location = new System.Drawing.Point(1, 274);
            this.panelReporte.Name = "panelReporte";
            this.panelReporte.Size = new System.Drawing.Size(248, 217);
            this.panelReporte.TabIndex = 1;
            this.panelReporte.Paint += new System.Windows.Forms.PaintEventHandler(this.panelReporte_Paint);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblHasta.ForeColor = System.Drawing.Color.Black;
            this.lblHasta.Location = new System.Drawing.Point(69, 121);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(19, 19);
            this.lblHasta.TabIndex = 14;
            this.lblHasta.Text = "--";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDesde.ForeColor = System.Drawing.Color.Black;
            this.lblDesde.Location = new System.Drawing.Point(69, 98);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(19, 19);
            this.lblDesde.TabIndex = 13;
            this.lblDesde.Text = "--";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblH.ForeColor = System.Drawing.Color.Black;
            this.lblH.Location = new System.Drawing.Point(8, 121);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(53, 19);
            this.lblH.TabIndex = 12;
            this.lblH.Text = "Hasta:";
            // 
            // lblHorasLiberadas
            // 
            this.lblHorasLiberadas.AutoSize = true;
            this.lblHorasLiberadas.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasLiberadas.Location = new System.Drawing.Point(8, 182);
            this.lblHorasLiberadas.Name = "lblHorasLiberadas";
            this.lblHorasLiberadas.Size = new System.Drawing.Size(68, 22);
            this.lblHorasLiberadas.TabIndex = 10;
            this.lblHorasLiberadas.Text = "-- horas";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblD.ForeColor = System.Drawing.Color.Black;
            this.lblD.Location = new System.Drawing.Point(8, 98);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(55, 19);
            this.lblD.TabIndex = 8;
            this.lblD.Text = "Desde:";
            // 
            // lblHL
            // 
            this.lblHL.AutoSize = true;
            this.lblHL.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHL.Location = new System.Drawing.Point(6, 158);
            this.lblHL.Name = "lblHL";
            this.lblHL.Size = new System.Drawing.Size(125, 20);
            this.lblHL.TabIndex = 6;
            this.lblHL.Text = "Horas liberadas";
            // 
            // lblOrganizacion
            // 
            this.lblOrganizacion.AutoSize = true;
            this.lblOrganizacion.Location = new System.Drawing.Point(5, 55);
            this.lblOrganizacion.Name = "lblOrganizacion";
            this.lblOrganizacion.Size = new System.Drawing.Size(126, 26);
            this.lblOrganizacion.TabIndex = 5;
            this.lblOrganizacion.Text = "Sin selección";
            // 
            // lblReporte
            // 
            this.lblReporte.AutoSize = true;
            this.lblReporte.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblReporte.Location = new System.Drawing.Point(6, 7);
            this.lblReporte.Name = "lblReporte";
            this.lblReporte.Size = new System.Drawing.Size(88, 26);
            this.lblReporte.TabIndex = 4;
            this.lblReporte.Text = "Reporte";
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
            // panelReportes
            // 
            this.panelReportes.BackColor = System.Drawing.SystemColors.Control;
            this.panelReportes.Controls.Add(this.lblConsultaReportes);
            this.panelReportes.Controls.Add(this.cmdEliminarReporte);
            this.panelReportes.Controls.Add(this.cmdModificarReporte);
            this.panelReportes.Controls.Add(this.cmdNuevoReporte);
            this.panelReportes.Controls.Add(this.dgvReportes);
            this.panelReportes.Location = new System.Drawing.Point(0, 0);
            this.panelReportes.Name = "panelReportes";
            this.panelReportes.Size = new System.Drawing.Size(516, 535);
            this.panelReportes.TabIndex = 5;
            // 
            // lblConsultaReportes
            // 
            this.lblConsultaReportes.AutoSize = true;
            this.lblConsultaReportes.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaReportes.Location = new System.Drawing.Point(12, 19);
            this.lblConsultaReportes.Name = "lblConsultaReportes";
            this.lblConsultaReportes.Size = new System.Drawing.Size(228, 28);
            this.lblConsultaReportes.TabIndex = 11;
            this.lblConsultaReportes.Text = "Consulta de reportes";
            // 
            // cmdEliminarReporte
            // 
            this.cmdEliminarReporte.Enabled = false;
            this.cmdEliminarReporte.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminarReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmdEliminarReporte.Location = new System.Drawing.Point(335, 492);
            this.cmdEliminarReporte.Name = "cmdEliminarReporte";
            this.cmdEliminarReporte.Size = new System.Drawing.Size(150, 30);
            this.cmdEliminarReporte.TabIndex = 32;
            this.cmdEliminarReporte.Text = "Eliminar selección";
            this.cmdEliminarReporte.UseVisualStyleBackColor = true;
            this.cmdEliminarReporte.Click += new System.EventHandler(this.cmdEliminarReporte_Click);
            // 
            // cmdModificarReporte
            // 
            this.cmdModificarReporte.Enabled = false;
            this.cmdModificarReporte.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificarReporte.Location = new System.Drawing.Point(179, 492);
            this.cmdModificarReporte.Name = "cmdModificarReporte";
            this.cmdModificarReporte.Size = new System.Drawing.Size(150, 30);
            this.cmdModificarReporte.TabIndex = 31;
            this.cmdModificarReporte.Text = "Modificar selección...";
            this.cmdModificarReporte.UseVisualStyleBackColor = true;
            this.cmdModificarReporte.Click += new System.EventHandler(this.cmdModificarReporte_Click);
            // 
            // cmdNuevoReporte
            // 
            this.cmdNuevoReporte.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevoReporte.Location = new System.Drawing.Point(23, 492);
            this.cmdNuevoReporte.Name = "cmdNuevoReporte";
            this.cmdNuevoReporte.Size = new System.Drawing.Size(150, 30);
            this.cmdNuevoReporte.TabIndex = 30;
            this.cmdNuevoReporte.Text = "Registrar reporte...";
            this.cmdNuevoReporte.UseVisualStyleBackColor = true;
            this.cmdNuevoReporte.Click += new System.EventHandler(this.cmdNuevoReporte_Click);
            // 
            // dgvReportes
            // 
            this.dgvReportes.AllowUserToAddRows = false;
            this.dgvReportes.AllowUserToDeleteRows = false;
            this.dgvReportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportes.Location = new System.Drawing.Point(6, 68);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.ReadOnly = true;
            this.dgvReportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportes.Size = new System.Drawing.Size(504, 412);
            this.dgvReportes.TabIndex = 33;
            this.dgvReportes.SelectionChanged += new System.EventHandler(this.dgvReportes_SelectionChanged);
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 535);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.panelReportes);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(800, 574);
            this.Name = "FrmReportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            this.Resize += new System.EventHandler(this.FrmReportes_Resize);
            this.gbDatos.ResumeLayout(false);
            this.panelReporte.ResumeLayout(false);
            this.panelReporte.PerformLayout();
            this.panelAlumno.ResumeLayout(false);
            this.panelAlumno.PerformLayout();
            this.panelReportes.ResumeLayout(false);
            this.panelReportes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Panel panelReporte;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblHorasLiberadas;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblHL;
        private System.Windows.Forms.Label lblOrganizacion;
        private System.Windows.Forms.Label lblReporte;
        private System.Windows.Forms.Panel panelAlumno;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.Label lblLicenciatura;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Panel panelReportes;
        private System.Windows.Forms.Label lblConsultaReportes;
        private System.Windows.Forms.Button cmdEliminarReporte;
        private System.Windows.Forms.Button cmdModificarReporte;
        private System.Windows.Forms.Button cmdNuevoReporte;
        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
    }
}