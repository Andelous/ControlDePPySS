namespace ControlDePPySS
{
    partial class FrmModificarSolicitud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarSolicitud));
            this.dbDatos = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJefeInmediado = new System.Windows.Forms.TextBox();
            this.cmdSeleccionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrganizacion = new System.Windows.Forms.TextBox();
            this.dbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbDatos
            // 
            this.dbDatos.Controls.Add(this.label5);
            this.dbDatos.Controls.Add(this.label6);
            this.dbDatos.Controls.Add(this.txtTipo);
            this.dbDatos.Controls.Add(this.txtAlumno);
            this.dbDatos.Location = new System.Drawing.Point(239, 71);
            this.dbDatos.Name = "dbDatos";
            this.dbDatos.Size = new System.Drawing.Size(193, 134);
            this.dbDatos.TabIndex = 33;
            this.dbDatos.TabStop = false;
            this.dbDatos.Text = "Otros datos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tipo de solicitud";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Alumno";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(6, 94);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(181, 25);
            this.txtTipo.TabIndex = 26;
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(6, 45);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.ReadOnly = true;
            this.txtAlumno.Size = new System.Drawing.Size(181, 25);
            this.txtAlumno.TabIndex = 25;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(239, 230);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(193, 35);
            this.cmdCancelar.TabIndex = 28;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificar.Location = new System.Drawing.Point(12, 230);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(221, 35);
            this.cmdModificar.TabIndex = 27;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Área";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(12, 190);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(215, 25);
            this.txtArea.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Núm. de contacto (máx. 25 dígitos)";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(12, 141);
            this.txtNumero.MaxLength = 25;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(215, 25);
            this.txtNumero.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Jefe inmediato";
            // 
            // txtJefeInmediado
            // 
            this.txtJefeInmediado.Location = new System.Drawing.Point(12, 92);
            this.txtJefeInmediado.Name = "txtJefeInmediado";
            this.txtJefeInmediado.Size = new System.Drawing.Size(215, 25);
            this.txtJefeInmediado.TabIndex = 22;
            // 
            // cmdSeleccionar
            // 
            this.cmdSeleccionar.Location = new System.Drawing.Point(303, 29);
            this.cmdSeleccionar.Name = "cmdSeleccionar";
            this.cmdSeleccionar.Size = new System.Drawing.Size(129, 27);
            this.cmdSeleccionar.TabIndex = 21;
            this.cmdSeleccionar.Text = "Seleccionar...";
            this.cmdSeleccionar.UseVisualStyleBackColor = true;
            this.cmdSeleccionar.Click += new System.EventHandler(this.cmdSeleccionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Organización";
            // 
            // txtOrganizacion
            // 
            this.txtOrganizacion.Location = new System.Drawing.Point(12, 30);
            this.txtOrganizacion.Name = "txtOrganizacion";
            this.txtOrganizacion.ReadOnly = true;
            this.txtOrganizacion.Size = new System.Drawing.Size(285, 25);
            this.txtOrganizacion.TabIndex = 20;
            this.txtOrganizacion.Text = "Ninguna";
            // 
            // FrmModificarSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 277);
            this.Controls.Add(this.dbDatos);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtJefeInmediado);
            this.Controls.Add(this.cmdSeleccionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOrganizacion);
            this.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModificarSolicitud";
            this.Text = "Modificar solicitud";
            this.Load += new System.EventHandler(this.FrmModificarSolicitud_Load);
            this.dbDatos.ResumeLayout(false);
            this.dbDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox dbDatos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJefeInmediado;
        private System.Windows.Forms.Button cmdSeleccionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrganizacion;
    }
}