namespace ControlDePPySS
{
    partial class FrmSeleccionarCarta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeleccionarCarta));
            this.lblOrganizaciones = new System.Windows.Forms.Label();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdSeleccionar = new System.Windows.Forms.Button();
            this.dgvCartas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrganizaciones
            // 
            this.lblOrganizaciones.AutoSize = true;
            this.lblOrganizaciones.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrganizaciones.Location = new System.Drawing.Point(12, 18);
            this.lblOrganizaciones.Name = "lblOrganizaciones";
            this.lblOrganizaciones.Size = new System.Drawing.Size(343, 28);
            this.lblOrganizaciones.TabIndex = 17;
            this.lblOrganizaciones.Text = "Seleccionar carta de aceptación";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(527, 263);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(145, 35);
            this.cmdCancelar.TabIndex = 11;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdSeleccionar
            // 
            this.cmdSeleccionar.Enabled = false;
            this.cmdSeleccionar.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSeleccionar.Location = new System.Drawing.Point(12, 263);
            this.cmdSeleccionar.Name = "cmdSeleccionar";
            this.cmdSeleccionar.Size = new System.Drawing.Size(327, 35);
            this.cmdSeleccionar.TabIndex = 10;
            this.cmdSeleccionar.Text = "Seleccionar";
            this.cmdSeleccionar.UseVisualStyleBackColor = true;
            this.cmdSeleccionar.Click += new System.EventHandler(this.cmdSeleccionar_Click);
            // 
            // dgvCartas
            // 
            this.dgvCartas.AllowUserToAddRows = false;
            this.dgvCartas.AllowUserToDeleteRows = false;
            this.dgvCartas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCartas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCartas.Location = new System.Drawing.Point(12, 50);
            this.dgvCartas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCartas.Name = "dgvCartas";
            this.dgvCartas.ReadOnly = true;
            this.dgvCartas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCartas.Size = new System.Drawing.Size(660, 206);
            this.dgvCartas.TabIndex = 12;
            this.dgvCartas.SelectionChanged += new System.EventHandler(this.dgvCartas_SelectionChanged);
            // 
            // FrmSeleccionarCarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 310);
            this.Controls.Add(this.lblOrganizaciones);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdSeleccionar);
            this.Controls.Add(this.dgvCartas);
            this.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSeleccionarCarta";
            this.Text = "Seleccionar carta de aceptación";
            this.Load += new System.EventHandler(this.FrmSeleccionarCarta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrganizaciones;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdSeleccionar;
        private System.Windows.Forms.DataGridView dgvCartas;
    }
}