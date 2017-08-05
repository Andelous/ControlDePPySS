namespace ControlDePPySS
{
    partial class FrmSolicitudes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSolicitudes));
            this.panelSolicitudes = new System.Windows.Forms.Panel();
            this.comboTipoSolicitud = new System.Windows.Forms.ComboBox();
            this.lblConsultaSolicitudes = new System.Windows.Forms.Label();
            this.cmdEliminarSolicitud = new System.Windows.Forms.Button();
            this.cmdModificarSolicitud = new System.Windows.Forms.Button();
            this.cmdNuevaSolicitud = new System.Windows.Forms.Button();
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.panelSolicitud = new System.Windows.Forms.Panel();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.lblJefeInmediato = new System.Windows.Forms.Label();
            this.lblNumeroDeContacto = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.lblJI = new System.Windows.Forms.Label();
            this.lblOrganizacion = new System.Windows.Forms.Label();
            this.lblSolicitud = new System.Windows.Forms.Label();
            this.panelAlumno = new System.Windows.Forms.Panel();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.lblLicenciatura = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.panelSolicitudes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            this.gbDatos.SuspendLayout();
            this.panelSolicitud.SuspendLayout();
            this.panelAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSolicitudes
            // 
            this.panelSolicitudes.BackColor = System.Drawing.SystemColors.Control;
            this.panelSolicitudes.Controls.Add(this.comboTipoSolicitud);
            this.panelSolicitudes.Controls.Add(this.lblConsultaSolicitudes);
            this.panelSolicitudes.Controls.Add(this.cmdEliminarSolicitud);
            this.panelSolicitudes.Controls.Add(this.cmdModificarSolicitud);
            this.panelSolicitudes.Controls.Add(this.cmdNuevaSolicitud);
            this.panelSolicitudes.Controls.Add(this.dgvSolicitudes);
            this.panelSolicitudes.Location = new System.Drawing.Point(0, 0);
            this.panelSolicitudes.Name = "panelSolicitudes";
            this.panelSolicitudes.Size = new System.Drawing.Size(516, 535);
            this.panelSolicitudes.TabIndex = 1;
            // 
            // comboTipoSolicitud
            // 
            this.comboTipoSolicitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoSolicitud.FormattingEnabled = true;
            this.comboTipoSolicitud.Location = new System.Drawing.Point(287, 19);
            this.comboTipoSolicitud.Name = "comboTipoSolicitud";
            this.comboTipoSolicitud.Size = new System.Drawing.Size(205, 30);
            this.comboTipoSolicitud.TabIndex = 30;
            this.comboTipoSolicitud.SelectedIndexChanged += new System.EventHandler(this.comboTipoSolicitud_SelectedIndexChanged);
            // 
            // lblConsultaSolicitudes
            // 
            this.lblConsultaSolicitudes.AutoSize = true;
            this.lblConsultaSolicitudes.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaSolicitudes.Location = new System.Drawing.Point(12, 19);
            this.lblConsultaSolicitudes.Name = "lblConsultaSolicitudes";
            this.lblConsultaSolicitudes.Size = new System.Drawing.Size(249, 28);
            this.lblConsultaSolicitudes.TabIndex = 11;
            this.lblConsultaSolicitudes.Text = "Consulta de solicitudes";
            // 
            // cmdEliminarSolicitud
            // 
            this.cmdEliminarSolicitud.Enabled = false;
            this.cmdEliminarSolicitud.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminarSolicitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmdEliminarSolicitud.Location = new System.Drawing.Point(335, 492);
            this.cmdEliminarSolicitud.Name = "cmdEliminarSolicitud";
            this.cmdEliminarSolicitud.Size = new System.Drawing.Size(150, 30);
            this.cmdEliminarSolicitud.TabIndex = 34;
            this.cmdEliminarSolicitud.Text = "Eliminar selección";
            this.cmdEliminarSolicitud.UseVisualStyleBackColor = true;
            this.cmdEliminarSolicitud.Click += new System.EventHandler(this.cmdEliminarSolicitud_Click);
            // 
            // cmdModificarSolicitud
            // 
            this.cmdModificarSolicitud.Enabled = false;
            this.cmdModificarSolicitud.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificarSolicitud.Location = new System.Drawing.Point(179, 492);
            this.cmdModificarSolicitud.Name = "cmdModificarSolicitud";
            this.cmdModificarSolicitud.Size = new System.Drawing.Size(150, 30);
            this.cmdModificarSolicitud.TabIndex = 33;
            this.cmdModificarSolicitud.Text = "Modificar selección...";
            this.cmdModificarSolicitud.UseVisualStyleBackColor = true;
            this.cmdModificarSolicitud.Click += new System.EventHandler(this.cmdModificarSolicitud_Click);
            // 
            // cmdNuevaSolicitud
            // 
            this.cmdNuevaSolicitud.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevaSolicitud.Location = new System.Drawing.Point(23, 492);
            this.cmdNuevaSolicitud.Name = "cmdNuevaSolicitud";
            this.cmdNuevaSolicitud.Size = new System.Drawing.Size(150, 30);
            this.cmdNuevaSolicitud.TabIndex = 32;
            this.cmdNuevaSolicitud.Text = "Registrar solicitud...";
            this.cmdNuevaSolicitud.UseVisualStyleBackColor = true;
            this.cmdNuevaSolicitud.Click += new System.EventHandler(this.cmdNuevaSolicitud_Click);
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.AllowUserToAddRows = false;
            this.dgvSolicitudes.AllowUserToDeleteRows = false;
            this.dgvSolicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudes.Location = new System.Drawing.Point(6, 68);
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.ReadOnly = true;
            this.dgvSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolicitudes.Size = new System.Drawing.Size(504, 412);
            this.dgvSolicitudes.TabIndex = 31;
            this.dgvSolicitudes.SelectionChanged += new System.EventHandler(this.dgvSolicitudes_SelectionChanged);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.panelSolicitud);
            this.gbDatos.Controls.Add(this.panelAlumno);
            this.gbDatos.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.Location = new System.Drawing.Point(522, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(250, 511);
            this.gbDatos.TabIndex = 2;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // panelSolicitud
            // 
            this.panelSolicitud.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSolicitud.Controls.Add(this.comboEstado);
            this.panelSolicitud.Controls.Add(this.lblJefeInmediato);
            this.panelSolicitud.Controls.Add(this.lblNumeroDeContacto);
            this.panelSolicitud.Controls.Add(this.lblEstado);
            this.panelSolicitud.Controls.Add(this.lblE);
            this.panelSolicitud.Controls.Add(this.lblJI);
            this.panelSolicitud.Controls.Add(this.lblOrganizacion);
            this.panelSolicitud.Controls.Add(this.lblSolicitud);
            this.panelSolicitud.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSolicitud.Location = new System.Drawing.Point(1, 274);
            this.panelSolicitud.Name = "panelSolicitud";
            this.panelSolicitud.Size = new System.Drawing.Size(248, 217);
            this.panelSolicitud.TabIndex = 1;
            this.panelSolicitud.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSolicitud_Paint);
            // 
            // comboEstado
            // 
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.Enabled = false;
            this.comboEstado.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Items.AddRange(new object[] {
            "En revisión",
            "Aceptada",
            "Cancelada"});
            this.comboEstado.Location = new System.Drawing.Point(73, 173);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(170, 28);
            this.comboEstado.TabIndex = 35;
            this.comboEstado.SelectedIndexChanged += new System.EventHandler(this.comboEstado_SelectedIndexChanged);
            // 
            // lblJefeInmediato
            // 
            this.lblJefeInmediato.AutoSize = true;
            this.lblJefeInmediato.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJefeInmediato.Location = new System.Drawing.Point(7, 113);
            this.lblJefeInmediato.Name = "lblJefeInmediato";
            this.lblJefeInmediato.Size = new System.Drawing.Size(20, 22);
            this.lblJefeInmediato.TabIndex = 10;
            this.lblJefeInmediato.Text = "--";
            // 
            // lblNumeroDeContacto
            // 
            this.lblNumeroDeContacto.AutoSize = true;
            this.lblNumeroDeContacto.Font = new System.Drawing.Font("Open Sans Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDeContacto.Location = new System.Drawing.Point(6, 135);
            this.lblNumeroDeContacto.Name = "lblNumeroDeContacto";
            this.lblNumeroDeContacto.Size = new System.Drawing.Size(19, 20);
            this.lblNumeroDeContacto.TabIndex = 9;
            this.lblNumeroDeContacto.Text = "--";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.Teal;
            this.lblEstado.Location = new System.Drawing.Point(69, 178);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(19, 19);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "--";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblE.ForeColor = System.Drawing.Color.Teal;
            this.lblE.Location = new System.Drawing.Point(7, 178);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(60, 19);
            this.lblE.TabIndex = 7;
            this.lblE.Text = "Estado:";
            // 
            // lblJI
            // 
            this.lblJI.AutoSize = true;
            this.lblJI.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJI.Location = new System.Drawing.Point(7, 93);
            this.lblJI.Name = "lblJI";
            this.lblJI.Size = new System.Drawing.Size(120, 20);
            this.lblJI.TabIndex = 6;
            this.lblJI.Text = "Jefe inmediato";
            // 
            // lblOrganizacion
            // 
            this.lblOrganizacion.AutoSize = true;
            this.lblOrganizacion.Location = new System.Drawing.Point(6, 56);
            this.lblOrganizacion.Name = "lblOrganizacion";
            this.lblOrganizacion.Size = new System.Drawing.Size(126, 26);
            this.lblOrganizacion.TabIndex = 5;
            this.lblOrganizacion.Text = "Sin selección";
            // 
            // lblSolicitud
            // 
            this.lblSolicitud.AutoSize = true;
            this.lblSolicitud.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblSolicitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSolicitud.Location = new System.Drawing.Point(6, 7);
            this.lblSolicitud.Name = "lblSolicitud";
            this.lblSolicitud.Size = new System.Drawing.Size(94, 26);
            this.lblSolicitud.TabIndex = 4;
            this.lblSolicitud.Text = "Solicitud";
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
            // FrmSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 535);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.panelSolicitudes);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 574);
            this.Name = "FrmSolicitudes";
            this.Text = "Solicitudes";
            this.Load += new System.EventHandler(this.FrmSolicitudes_Load);
            this.Resize += new System.EventHandler(this.FrmSolicitudes_Resize);
            this.panelSolicitudes.ResumeLayout(false);
            this.panelSolicitudes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            this.gbDatos.ResumeLayout(false);
            this.panelSolicitud.ResumeLayout(false);
            this.panelSolicitud.PerformLayout();
            this.panelAlumno.ResumeLayout(false);
            this.panelAlumno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSolicitudes;
        private System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.Button cmdEliminarSolicitud;
        private System.Windows.Forms.Button cmdModificarSolicitud;
        private System.Windows.Forms.Button cmdNuevaSolicitud;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblConsultaSolicitudes;
        private System.Windows.Forms.ComboBox comboTipoSolicitud;
        private System.Windows.Forms.Panel panelAlumno;
        private System.Windows.Forms.Panel panelSolicitud;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblJI;
        private System.Windows.Forms.Label lblOrganizacion;
        private System.Windows.Forms.Label lblSolicitud;
        private System.Windows.Forms.Label lblLicenciatura;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNumeroDeContacto;
        private System.Windows.Forms.Label lblJefeInmediato;
        private System.Windows.Forms.ComboBox comboEstado;
    }
}