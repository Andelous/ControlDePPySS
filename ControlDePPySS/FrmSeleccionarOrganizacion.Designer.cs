namespace ControlDePPySS
{
    partial class FrmSeleccionarOrganizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeleccionarOrganizacion));
            this.dgvOrganizaciones = new System.Windows.Forms.DataGridView();
            this.cmdSeleccionar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.lblOrganizaciones = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdNuevaOrganizacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrganizaciones
            // 
            this.dgvOrganizaciones.AllowUserToAddRows = false;
            this.dgvOrganizaciones.AllowUserToDeleteRows = false;
            this.dgvOrganizaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrganizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrganizaciones.Location = new System.Drawing.Point(12, 91);
            this.dgvOrganizaciones.Name = "dgvOrganizaciones";
            this.dgvOrganizaciones.ReadOnly = true;
            this.dgvOrganizaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrganizaciones.Size = new System.Drawing.Size(381, 409);
            this.dgvOrganizaciones.TabIndex = 13;
            this.dgvOrganizaciones.SelectionChanged += new System.EventHandler(this.dgvOrganizaciones_SelectionChanged);
            // 
            // cmdSeleccionar
            // 
            this.cmdSeleccionar.Enabled = false;
            this.cmdSeleccionar.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSeleccionar.Location = new System.Drawing.Point(12, 514);
            this.cmdSeleccionar.Name = "cmdSeleccionar";
            this.cmdSeleccionar.Size = new System.Drawing.Size(211, 35);
            this.cmdSeleccionar.TabIndex = 14;
            this.cmdSeleccionar.Text = "Seleccionar";
            this.cmdSeleccionar.UseVisualStyleBackColor = true;
            this.cmdSeleccionar.Click += new System.EventHandler(this.cmdSeleccionar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(229, 514);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(143, 35);
            this.cmdCancelar.TabIndex = 15;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // lblOrganizaciones
            // 
            this.lblOrganizaciones.AutoSize = true;
            this.lblOrganizaciones.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrganizaciones.Location = new System.Drawing.Point(12, 10);
            this.lblOrganizaciones.Name = "lblOrganizaciones";
            this.lblOrganizaciones.Size = new System.Drawing.Size(272, 28);
            this.lblOrganizaciones.TabIndex = 12;
            this.lblOrganizaciones.Text = "Seleccionar organización";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(265, 25);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(283, 50);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(110, 27);
            this.cmdBuscar.TabIndex = 12;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdNuevaOrganizacion
            // 
            this.cmdNuevaOrganizacion.Location = new System.Drawing.Point(283, 12);
            this.cmdNuevaOrganizacion.Name = "cmdNuevaOrganizacion";
            this.cmdNuevaOrganizacion.Size = new System.Drawing.Size(110, 27);
            this.cmdNuevaOrganizacion.TabIndex = 11;
            this.cmdNuevaOrganizacion.Text = "Nueva...";
            this.cmdNuevaOrganizacion.UseVisualStyleBackColor = true;
            this.cmdNuevaOrganizacion.Click += new System.EventHandler(this.cmdNuevaOrganizacion_Click);
            // 
            // FrmSeleccionarOrganizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 561);
            this.Controls.Add(this.cmdNuevaOrganizacion);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblOrganizaciones);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdSeleccionar);
            this.Controls.Add(this.dgvOrganizaciones);
            this.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSeleccionarOrganizacion";
            this.Text = "Seleccionar organización";
            this.Load += new System.EventHandler(this.FrmSeleccionarOrganizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrganizaciones;
        private System.Windows.Forms.Button cmdSeleccionar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Label lblOrganizaciones;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Button cmdNuevaOrganizacion;
    }
}