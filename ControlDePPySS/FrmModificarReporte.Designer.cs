namespace ControlDePPySS
{
    partial class FrmModificarReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarReporte));
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.lblFI = new System.Windows.Forms.Label();
            this.lblFF = new System.Windows.Forms.Label();
            this.comboMesI = new System.Windows.Forms.ComboBox();
            this.nudDiaF = new System.Windows.Forms.NumericUpDown();
            this.nudAnoI = new System.Windows.Forms.NumericUpDown();
            this.nudDiaI = new System.Windows.Forms.NumericUpDown();
            this.comboMesF = new System.Windows.Forms.ComboBox();
            this.nudAnoF = new System.Windows.Forms.NumericUpDown();
            this.nudHoras = new System.Windows.Forms.NumericUpDown();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdActualizar = new System.Windows.Forms.Button();
            this.lblHoras = new System.Windows.Forms.Label();
            this.cmdSeleccionarCarta = new System.Windows.Forms.Button();
            this.txtCarta = new System.Windows.Forms.TextBox();
            this.lblSolicitud = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiaF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnoI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiaI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnoF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(12, 117);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.ReadOnly = true;
            this.txtAlumno.Size = new System.Drawing.Size(259, 25);
            this.txtAlumno.TabIndex = 22;
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumno.Location = new System.Drawing.Point(12, 96);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(60, 18);
            this.lblAlumno.TabIndex = 65;
            this.lblAlumno.Text = "Alumno";
            // 
            // lblFI
            // 
            this.lblFI.AutoSize = true;
            this.lblFI.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFI.Location = new System.Drawing.Point(12, 215);
            this.lblFI.Name = "lblFI";
            this.lblFI.Size = new System.Drawing.Size(105, 18);
            this.lblFI.TabIndex = 57;
            this.lblFI.Text = "Fecha de inicio";
            // 
            // lblFF
            // 
            this.lblFF.AutoSize = true;
            this.lblFF.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFF.Location = new System.Drawing.Point(15, 268);
            this.lblFF.Name = "lblFF";
            this.lblFF.Size = new System.Drawing.Size(145, 18);
            this.lblFF.TabIndex = 58;
            this.lblFF.Text = "Fecha de finalización";
            // 
            // comboMesI
            // 
            this.comboMesI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMesI.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMesI.FormattingEnabled = true;
            this.comboMesI.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.comboMesI.Location = new System.Drawing.Point(63, 236);
            this.comboMesI.Name = "comboMesI";
            this.comboMesI.Size = new System.Drawing.Size(136, 26);
            this.comboMesI.TabIndex = 25;
            this.comboMesI.SelectedIndexChanged += new System.EventHandler(this.comboMesI_SelectedIndexChanged);
            // 
            // nudDiaF
            // 
            this.nudDiaF.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDiaF.Location = new System.Drawing.Point(15, 289);
            this.nudDiaF.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudDiaF.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDiaF.Name = "nudDiaF";
            this.nudDiaF.Size = new System.Drawing.Size(42, 25);
            this.nudDiaF.TabIndex = 27;
            this.nudDiaF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDiaF.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // nudAnoI
            // 
            this.nudAnoI.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAnoI.Location = new System.Drawing.Point(205, 236);
            this.nudAnoI.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudAnoI.Minimum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.nudAnoI.Name = "nudAnoI";
            this.nudAnoI.Size = new System.Drawing.Size(66, 25);
            this.nudAnoI.TabIndex = 26;
            this.nudAnoI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAnoI.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.nudAnoI.ValueChanged += new System.EventHandler(this.nudAnoI_ValueChanged);
            // 
            // nudDiaI
            // 
            this.nudDiaI.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDiaI.Location = new System.Drawing.Point(15, 236);
            this.nudDiaI.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudDiaI.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDiaI.Name = "nudDiaI";
            this.nudDiaI.Size = new System.Drawing.Size(42, 25);
            this.nudDiaI.TabIndex = 24;
            this.nudDiaI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDiaI.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // comboMesF
            // 
            this.comboMesF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMesF.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMesF.FormattingEnabled = true;
            this.comboMesF.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.comboMesF.Location = new System.Drawing.Point(63, 289);
            this.comboMesF.Name = "comboMesF";
            this.comboMesF.Size = new System.Drawing.Size(136, 26);
            this.comboMesF.TabIndex = 28;
            this.comboMesF.SelectedIndexChanged += new System.EventHandler(this.comboMesF_SelectedIndexChanged);
            // 
            // nudAnoF
            // 
            this.nudAnoF.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAnoF.Location = new System.Drawing.Point(205, 289);
            this.nudAnoF.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudAnoF.Minimum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.nudAnoF.Name = "nudAnoF";
            this.nudAnoF.Size = new System.Drawing.Size(66, 25);
            this.nudAnoF.TabIndex = 29;
            this.nudAnoF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAnoF.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.nudAnoF.ValueChanged += new System.EventHandler(this.nudAnoF_ValueChanged);
            // 
            // nudHoras
            // 
            this.nudHoras.Location = new System.Drawing.Point(12, 179);
            this.nudHoras.Maximum = new decimal(new int[] {
            560,
            0,
            0,
            0});
            this.nudHoras.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.Size = new System.Drawing.Size(259, 25);
            this.nudHoras.TabIndex = 23;
            this.nudHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHoras.Value = new decimal(new int[] {
            280,
            0,
            0,
            0});
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(184, 327);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(89, 42);
            this.cmdCancelar.TabIndex = 31;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdActualizar
            // 
            this.cmdActualizar.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdActualizar.Location = new System.Drawing.Point(12, 327);
            this.cmdActualizar.Name = "cmdActualizar";
            this.cmdActualizar.Size = new System.Drawing.Size(166, 42);
            this.cmdActualizar.TabIndex = 30;
            this.cmdActualizar.Text = "Actualizar";
            this.cmdActualizar.UseVisualStyleBackColor = true;
            this.cmdActualizar.Click += new System.EventHandler(this.cmdActualizar_Click);
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.Location = new System.Drawing.Point(12, 158);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(109, 18);
            this.lblHoras.TabIndex = 53;
            this.lblHoras.Text = "Horas liberadas";
            // 
            // cmdSeleccionarCarta
            // 
            this.cmdSeleccionarCarta.Location = new System.Drawing.Point(12, 61);
            this.cmdSeleccionarCarta.Name = "cmdSeleccionarCarta";
            this.cmdSeleccionarCarta.Size = new System.Drawing.Size(259, 27);
            this.cmdSeleccionarCarta.TabIndex = 21;
            this.cmdSeleccionarCarta.Text = "Seleccionar...";
            this.cmdSeleccionarCarta.UseVisualStyleBackColor = true;
            this.cmdSeleccionarCarta.Click += new System.EventHandler(this.cmdSeleccionarCarta_Click);
            // 
            // txtCarta
            // 
            this.txtCarta.Location = new System.Drawing.Point(12, 30);
            this.txtCarta.Name = "txtCarta";
            this.txtCarta.ReadOnly = true;
            this.txtCarta.Size = new System.Drawing.Size(259, 25);
            this.txtCarta.TabIndex = 20;
            // 
            // lblSolicitud
            // 
            this.lblSolicitud.AutoSize = true;
            this.lblSolicitud.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitud.Location = new System.Drawing.Point(12, 9);
            this.lblSolicitud.Name = "lblSolicitud";
            this.lblSolicitud.Size = new System.Drawing.Size(139, 18);
            this.lblSolicitud.TabIndex = 50;
            this.lblSolicitud.Text = "Carta de aceptación";
            // 
            // FrmModificarReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 381);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.lblFI);
            this.Controls.Add(this.lblFF);
            this.Controls.Add(this.comboMesI);
            this.Controls.Add(this.nudDiaF);
            this.Controls.Add(this.nudAnoI);
            this.Controls.Add(this.nudDiaI);
            this.Controls.Add(this.comboMesF);
            this.Controls.Add(this.nudAnoF);
            this.Controls.Add(this.nudHoras);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdActualizar);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.cmdSeleccionarCarta);
            this.Controls.Add(this.txtCarta);
            this.Controls.Add(this.lblSolicitud);
            this.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModificarReporte";
            this.Text = "Modificar reporte";
            this.Load += new System.EventHandler(this.FrmModificarReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDiaF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnoI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiaI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnoF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Label lblFI;
        private System.Windows.Forms.Label lblFF;
        private System.Windows.Forms.ComboBox comboMesI;
        private System.Windows.Forms.NumericUpDown nudDiaF;
        private System.Windows.Forms.NumericUpDown nudAnoI;
        private System.Windows.Forms.NumericUpDown nudDiaI;
        private System.Windows.Forms.ComboBox comboMesF;
        private System.Windows.Forms.NumericUpDown nudAnoF;
        private System.Windows.Forms.NumericUpDown nudHoras;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdActualizar;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Button cmdSeleccionarCarta;
        private System.Windows.Forms.TextBox txtCarta;
        private System.Windows.Forms.Label lblSolicitud;
    }
}