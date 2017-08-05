namespace ControlDePPySS
{
    partial class FrmOrganizaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrganizaciones));
            this.panelOrganizaciones = new System.Windows.Forms.Panel();
            this.lblConsultaOrganizaciones = new System.Windows.Forms.Label();
            this.cmdEliminarOrganizacion = new System.Windows.Forms.Button();
            this.cmdModificarOrganizacion = new System.Windows.Forms.Button();
            this.cmdNuevaOrganizacion = new System.Windows.Forms.Button();
            this.dgvOrganizaciones = new System.Windows.Forms.DataGridView();
            this.panelOrganizaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOrganizaciones
            // 
            this.panelOrganizaciones.BackColor = System.Drawing.SystemColors.Control;
            this.panelOrganizaciones.Controls.Add(this.lblConsultaOrganizaciones);
            this.panelOrganizaciones.Controls.Add(this.cmdEliminarOrganizacion);
            this.panelOrganizaciones.Controls.Add(this.cmdModificarOrganizacion);
            this.panelOrganizaciones.Controls.Add(this.cmdNuevaOrganizacion);
            this.panelOrganizaciones.Controls.Add(this.dgvOrganizaciones);
            this.panelOrganizaciones.Location = new System.Drawing.Point(0, 0);
            this.panelOrganizaciones.Name = "panelOrganizaciones";
            this.panelOrganizaciones.Size = new System.Drawing.Size(516, 535);
            this.panelOrganizaciones.TabIndex = 3;
            // 
            // lblConsultaOrganizaciones
            // 
            this.lblConsultaOrganizaciones.AutoSize = true;
            this.lblConsultaOrganizaciones.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaOrganizaciones.Location = new System.Drawing.Point(12, 19);
            this.lblConsultaOrganizaciones.Name = "lblConsultaOrganizaciones";
            this.lblConsultaOrganizaciones.Size = new System.Drawing.Size(300, 28);
            this.lblConsultaOrganizaciones.TabIndex = 11;
            this.lblConsultaOrganizaciones.Text = "Consulta de Organizaciones";
            // 
            // cmdEliminarOrganizacion
            // 
            this.cmdEliminarOrganizacion.Enabled = false;
            this.cmdEliminarOrganizacion.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminarOrganizacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmdEliminarOrganizacion.Location = new System.Drawing.Point(360, 493);
            this.cmdEliminarOrganizacion.Name = "cmdEliminarOrganizacion";
            this.cmdEliminarOrganizacion.Size = new System.Drawing.Size(150, 30);
            this.cmdEliminarOrganizacion.TabIndex = 12;
            this.cmdEliminarOrganizacion.Text = "Eliminar selección";
            this.cmdEliminarOrganizacion.UseVisualStyleBackColor = true;
            this.cmdEliminarOrganizacion.Click += new System.EventHandler(this.cmdEliminarOrganizacion_Click);
            // 
            // cmdModificarOrganizacion
            // 
            this.cmdModificarOrganizacion.Enabled = false;
            this.cmdModificarOrganizacion.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificarOrganizacion.Location = new System.Drawing.Point(204, 492);
            this.cmdModificarOrganizacion.Name = "cmdModificarOrganizacion";
            this.cmdModificarOrganizacion.Size = new System.Drawing.Size(150, 30);
            this.cmdModificarOrganizacion.TabIndex = 11;
            this.cmdModificarOrganizacion.Text = "Modificar selección...";
            this.cmdModificarOrganizacion.UseVisualStyleBackColor = true;
            this.cmdModificarOrganizacion.Click += new System.EventHandler(this.cmdModificarOrganizacion_Click);
            // 
            // cmdNuevaOrganizacion
            // 
            this.cmdNuevaOrganizacion.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevaOrganizacion.Location = new System.Drawing.Point(6, 492);
            this.cmdNuevaOrganizacion.Name = "cmdNuevaOrganizacion";
            this.cmdNuevaOrganizacion.Size = new System.Drawing.Size(192, 30);
            this.cmdNuevaOrganizacion.TabIndex = 10;
            this.cmdNuevaOrganizacion.Text = "Registrar organización...";
            this.cmdNuevaOrganizacion.UseVisualStyleBackColor = true;
            this.cmdNuevaOrganizacion.Click += new System.EventHandler(this.cmdNuevaOrganizacion_Click);
            // 
            // dgvOrganizaciones
            // 
            this.dgvOrganizaciones.AllowUserToAddRows = false;
            this.dgvOrganizaciones.AllowUserToDeleteRows = false;
            this.dgvOrganizaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrganizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrganizaciones.Location = new System.Drawing.Point(6, 68);
            this.dgvOrganizaciones.Name = "dgvOrganizaciones";
            this.dgvOrganizaciones.ReadOnly = true;
            this.dgvOrganizaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrganizaciones.Size = new System.Drawing.Size(504, 412);
            this.dgvOrganizaciones.TabIndex = 13;
            this.dgvOrganizaciones.SelectionChanged += new System.EventHandler(this.dgvOrganizaciones_SelectionChanged);
            // 
            // FrmOrganizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(516, 535);
            this.Controls.Add(this.panelOrganizaciones);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrganizaciones";
            this.Text = "Catálogo de organizaciones";
            this.Load += new System.EventHandler(this.FrmOrganizaciones_Load);
            this.panelOrganizaciones.ResumeLayout(false);
            this.panelOrganizaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOrganizaciones;
        private System.Windows.Forms.Label lblConsultaOrganizaciones;
        private System.Windows.Forms.Button cmdEliminarOrganizacion;
        private System.Windows.Forms.Button cmdModificarOrganizacion;
        private System.Windows.Forms.Button cmdNuevaOrganizacion;
        private System.Windows.Forms.DataGridView dgvOrganizaciones;
    }
}