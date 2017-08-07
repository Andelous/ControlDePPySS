namespace ControlDePPySS
{
    partial class FrmPrincipal_V2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal_V2));
            this.panelAlumnos = new System.Windows.Forms.Panel();
            this.cmdActualizar = new System.Windows.Forms.Button();
            this.cmdEliminarAlumno = new System.Windows.Forms.Button();
            this.cmdModificarAlumno = new System.Windows.Forms.Button();
            this.cmdNuevoAlumno = new System.Windows.Forms.Button();
            this.cmdBuscarAlumnos = new System.Windows.Forms.Button();
            this.txtBuscarAlumnos = new System.Windows.Forms.TextBox();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.cmdOrganizaciones = new System.Windows.Forms.Button();
            this.panelAlumno = new System.Windows.Forms.Panel();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.cmdEntrega = new System.Windows.Forms.Button();
            this.cmdCartaAceptacion = new System.Windows.Forms.Button();
            this.cmdCerrarSesion = new System.Windows.Forms.Button();
            this.cmdReportes = new System.Windows.Forms.Button();
            this.cmdSolicitudes = new System.Windows.Forms.Button();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pctLaSalle = new System.Windows.Forms.PictureBox();
            this.panelAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.gbOpciones.SuspendLayout();
            this.panelAlumno.SuspendLayout();
            this.panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLaSalle)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAlumnos
            // 
            this.panelAlumnos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAlumnos.Controls.Add(this.cmdActualizar);
            this.panelAlumnos.Controls.Add(this.cmdEliminarAlumno);
            this.panelAlumnos.Controls.Add(this.cmdModificarAlumno);
            this.panelAlumnos.Controls.Add(this.cmdNuevoAlumno);
            this.panelAlumnos.Controls.Add(this.cmdBuscarAlumnos);
            this.panelAlumnos.Controls.Add(this.txtBuscarAlumnos);
            this.panelAlumnos.Controls.Add(this.dgvAlumnos);
            this.panelAlumnos.Controls.Add(this.pctLaSalle);
            this.panelAlumnos.Controls.Add(this.label3);
            this.panelAlumnos.Location = new System.Drawing.Point(-1, -1);
            this.panelAlumnos.Name = "panelAlumnos";
            this.panelAlumnos.Size = new System.Drawing.Size(694, 539);
            this.panelAlumnos.TabIndex = 0;
            // 
            // cmdActualizar
            // 
            this.cmdActualizar.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdActualizar.Location = new System.Drawing.Point(400, 56);
            this.cmdActualizar.Name = "cmdActualizar";
            this.cmdActualizar.Size = new System.Drawing.Size(94, 22);
            this.cmdActualizar.TabIndex = 32;
            this.cmdActualizar.Text = "Actualizar";
            this.cmdActualizar.UseVisualStyleBackColor = true;
            this.cmdActualizar.Click += new System.EventHandler(this.cmdActualizar_Click);
            // 
            // cmdEliminarAlumno
            // 
            this.cmdEliminarAlumno.Enabled = false;
            this.cmdEliminarAlumno.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminarAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmdEliminarAlumno.Location = new System.Drawing.Point(322, 499);
            this.cmdEliminarAlumno.Name = "cmdEliminarAlumno";
            this.cmdEliminarAlumno.Size = new System.Drawing.Size(150, 30);
            this.cmdEliminarAlumno.TabIndex = 36;
            this.cmdEliminarAlumno.Text = "Eliminar selección";
            this.cmdEliminarAlumno.UseVisualStyleBackColor = true;
            this.cmdEliminarAlumno.Click += new System.EventHandler(this.cmdEliminarAlumno_Click);
            // 
            // cmdModificarAlumno
            // 
            this.cmdModificarAlumno.Enabled = false;
            this.cmdModificarAlumno.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificarAlumno.Location = new System.Drawing.Point(166, 499);
            this.cmdModificarAlumno.Name = "cmdModificarAlumno";
            this.cmdModificarAlumno.Size = new System.Drawing.Size(150, 30);
            this.cmdModificarAlumno.TabIndex = 35;
            this.cmdModificarAlumno.Text = "Modificar selección...";
            this.cmdModificarAlumno.UseVisualStyleBackColor = true;
            this.cmdModificarAlumno.Click += new System.EventHandler(this.cmdModificarAlumno_Click);
            // 
            // cmdNuevoAlumno
            // 
            this.cmdNuevoAlumno.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevoAlumno.Location = new System.Drawing.Point(10, 499);
            this.cmdNuevoAlumno.Name = "cmdNuevoAlumno";
            this.cmdNuevoAlumno.Size = new System.Drawing.Size(150, 30);
            this.cmdNuevoAlumno.TabIndex = 34;
            this.cmdNuevoAlumno.Text = "Registrar alumno...";
            this.cmdNuevoAlumno.UseVisualStyleBackColor = true;
            this.cmdNuevoAlumno.Click += new System.EventHandler(this.cmdNuevoAlumno_Click);
            // 
            // cmdBuscarAlumnos
            // 
            this.cmdBuscarAlumnos.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscarAlumnos.Location = new System.Drawing.Point(300, 56);
            this.cmdBuscarAlumnos.Name = "cmdBuscarAlumnos";
            this.cmdBuscarAlumnos.Size = new System.Drawing.Size(94, 22);
            this.cmdBuscarAlumnos.TabIndex = 31;
            this.cmdBuscarAlumnos.Text = "Buscar";
            this.cmdBuscarAlumnos.UseVisualStyleBackColor = true;
            this.cmdBuscarAlumnos.Click += new System.EventHandler(this.cmdBuscarAlumnos_Click);
            // 
            // txtBuscarAlumnos
            // 
            this.txtBuscarAlumnos.Location = new System.Drawing.Point(10, 57);
            this.txtBuscarAlumnos.Name = "txtBuscarAlumnos";
            this.txtBuscarAlumnos.Size = new System.Drawing.Size(284, 20);
            this.txtBuscarAlumnos.TabIndex = 30;
            this.txtBuscarAlumnos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarAlumnos_KeyPress);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlumnos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlumnos.Location = new System.Drawing.Point(10, 83);
            this.dgvAlumnos.MultiSelect = false;
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(672, 406);
            this.dgvAlumnos.TabIndex = 33;
            this.dgvAlumnos.SelectionChanged += new System.EventHandler(this.dgvAlumnos_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Consulta de Alumnos";
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.cmdOrganizaciones);
            this.gbOpciones.Controls.Add(this.panelAlumno);
            this.gbOpciones.Controls.Add(this.cmdEntrega);
            this.gbOpciones.Controls.Add(this.cmdCartaAceptacion);
            this.gbOpciones.Controls.Add(this.cmdCerrarSesion);
            this.gbOpciones.Controls.Add(this.cmdReportes);
            this.gbOpciones.Controls.Add(this.cmdSolicitudes);
            this.gbOpciones.Controls.Add(this.panelUsuario);
            this.gbOpciones.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpciones.Location = new System.Drawing.Point(701, 13);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(249, 511);
            this.gbOpciones.TabIndex = 1;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones";
            // 
            // cmdOrganizaciones
            // 
            this.cmdOrganizaciones.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOrganizaciones.Location = new System.Drawing.Point(6, 339);
            this.cmdOrganizaciones.Name = "cmdOrganizaciones";
            this.cmdOrganizaciones.Size = new System.Drawing.Size(237, 40);
            this.cmdOrganizaciones.TabIndex = 41;
            this.cmdOrganizaciones.Text = "Catálogo de organizaciones";
            this.cmdOrganizaciones.UseVisualStyleBackColor = true;
            this.cmdOrganizaciones.Click += new System.EventHandler(this.cmdOrganizaciones_Click);
            // 
            // panelAlumno
            // 
            this.panelAlumno.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAlumno.Controls.Add(this.lblMatricula);
            this.panelAlumno.Controls.Add(this.label2);
            this.panelAlumno.Controls.Add(this.lblAlumno);
            this.panelAlumno.Location = new System.Drawing.Point(1, 42);
            this.panelAlumno.Name = "panelAlumno";
            this.panelAlumno.Size = new System.Drawing.Size(247, 83);
            this.panelAlumno.TabIndex = 7;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Open Sans Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblMatricula.ForeColor = System.Drawing.Color.Teal;
            this.lblMatricula.Location = new System.Drawing.Point(3, 53);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(73, 19);
            this.lblMatricula.TabIndex = 28;
            this.lblMatricula.Text = "Sin datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Alumno seleccionado";
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumno.ForeColor = System.Drawing.Color.Teal;
            this.lblAlumno.Location = new System.Drawing.Point(3, 29);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(107, 22);
            this.lblAlumno.TabIndex = 27;
            this.lblAlumno.Text = "Sin selección";
            // 
            // cmdEntrega
            // 
            this.cmdEntrega.Enabled = false;
            this.cmdEntrega.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEntrega.Location = new System.Drawing.Point(6, 293);
            this.cmdEntrega.Name = "cmdEntrega";
            this.cmdEntrega.Size = new System.Drawing.Size(237, 40);
            this.cmdEntrega.TabIndex = 40;
            this.cmdEntrega.Text = "Entrega de expedientes";
            this.cmdEntrega.UseVisualStyleBackColor = true;
            // 
            // cmdCartaAceptacion
            // 
            this.cmdCartaAceptacion.Enabled = false;
            this.cmdCartaAceptacion.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCartaAceptacion.Location = new System.Drawing.Point(6, 182);
            this.cmdCartaAceptacion.Name = "cmdCartaAceptacion";
            this.cmdCartaAceptacion.Size = new System.Drawing.Size(237, 40);
            this.cmdCartaAceptacion.TabIndex = 38;
            this.cmdCartaAceptacion.Text = "Cartas de aceptación";
            this.cmdCartaAceptacion.UseVisualStyleBackColor = true;
            this.cmdCartaAceptacion.Click += new System.EventHandler(this.cmdCartaAceptacion_Click);
            // 
            // cmdCerrarSesion
            // 
            this.cmdCerrarSesion.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrarSesion.Location = new System.Drawing.Point(6, 466);
            this.cmdCerrarSesion.Name = "cmdCerrarSesion";
            this.cmdCerrarSesion.Size = new System.Drawing.Size(237, 40);
            this.cmdCerrarSesion.TabIndex = 42;
            this.cmdCerrarSesion.Text = "Cerrar sesión";
            this.cmdCerrarSesion.UseVisualStyleBackColor = true;
            this.cmdCerrarSesion.Click += new System.EventHandler(this.cmdCerrarSesion_Click);
            // 
            // cmdReportes
            // 
            this.cmdReportes.Enabled = false;
            this.cmdReportes.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReportes.Location = new System.Drawing.Point(6, 228);
            this.cmdReportes.Name = "cmdReportes";
            this.cmdReportes.Size = new System.Drawing.Size(237, 40);
            this.cmdReportes.TabIndex = 39;
            this.cmdReportes.Text = "Reportes mensuales";
            this.cmdReportes.UseVisualStyleBackColor = true;
            this.cmdReportes.Click += new System.EventHandler(this.cmdReportes_Click);
            // 
            // cmdSolicitudes
            // 
            this.cmdSolicitudes.Enabled = false;
            this.cmdSolicitudes.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSolicitudes.Location = new System.Drawing.Point(6, 136);
            this.cmdSolicitudes.Name = "cmdSolicitudes";
            this.cmdSolicitudes.Size = new System.Drawing.Size(237, 40);
            this.cmdSolicitudes.TabIndex = 37;
            this.cmdSolicitudes.Text = "Solicitudes";
            this.cmdSolicitudes.UseVisualStyleBackColor = true;
            this.cmdSolicitudes.Click += new System.EventHandler(this.cmdSolicitudes_Click);
            // 
            // panelUsuario
            // 
            this.panelUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelUsuario.Controls.Add(this.lblUsuario);
            this.panelUsuario.Controls.Add(this.label1);
            this.panelUsuario.Location = new System.Drawing.Point(1, 395);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(247, 65);
            this.panelUsuario.TabIndex = 6;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsuario.Location = new System.Drawing.Point(6, 31);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(127, 22);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Administrador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario:";
            // 
            // pctLaSalle
            // 
            this.pctLaSalle.Image = global::ControlDePPySS.Properties.Resources.Logo_login1;
            this.pctLaSalle.Location = new System.Drawing.Point(629, 14);
            this.pctLaSalle.Name = "pctLaSalle";
            this.pctLaSalle.Size = new System.Drawing.Size(50, 59);
            this.pctLaSalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLaSalle.TabIndex = 2;
            this.pctLaSalle.TabStop = false;
            // 
            // FrmPrincipal_V2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 535);
            this.Controls.Add(this.gbOpciones);
            this.Controls.Add(this.panelAlumnos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(974, 574);
            this.Name = "FrmPrincipal_V2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.Resize += new System.EventHandler(this.FrmPrincipal_Resize);
            this.panelAlumnos.ResumeLayout(false);
            this.panelAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.gbOpciones.ResumeLayout(false);
            this.panelAlumno.ResumeLayout(false);
            this.panelAlumno.PerformLayout();
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLaSalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAlumnos;
        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.Button cmdSolicitudes;
        private System.Windows.Forms.Button cmdReportes;
        private System.Windows.Forms.Button cmdCerrarSesion;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.Button cmdEntrega;
        private System.Windows.Forms.Button cmdCartaAceptacion;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.PictureBox pctLaSalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdBuscarAlumnos;
        private System.Windows.Forms.TextBox txtBuscarAlumnos;
        private System.Windows.Forms.Button cmdModificarAlumno;
        private System.Windows.Forms.Button cmdNuevoAlumno;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelAlumno;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Button cmdEliminarAlumno;
        private System.Windows.Forms.Button cmdActualizar;
        private System.Windows.Forms.Button cmdOrganizaciones;
    }
}