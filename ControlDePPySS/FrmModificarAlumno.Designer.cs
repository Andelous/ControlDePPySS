namespace ControlDePPySS
{
    partial class FrmModificarAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarAlumno));
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboLicenciatura = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudAno_Ingreso = new System.Windows.Forms.NumericUpDown();
            this.txtApe_Mat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApe_Pat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAno_Ingreso)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(188, 219);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(133, 35);
            this.cmdCancelar.TabIndex = 31;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Licenciatura";
            // 
            // comboLicenciatura
            // 
            this.comboLicenciatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLicenciatura.FormattingEnabled = true;
            this.comboLicenciatura.Location = new System.Drawing.Point(12, 179);
            this.comboLicenciatura.Name = "comboLicenciatura";
            this.comboLicenciatura.Size = new System.Drawing.Size(309, 23);
            this.comboLicenciatura.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Año de ingreso";
            // 
            // nudAno_Ingreso
            // 
            this.nudAno_Ingreso.Location = new System.Drawing.Point(171, 33);
            this.nudAno_Ingreso.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.nudAno_Ingreso.Minimum = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.nudAno_Ingreso.Name = "nudAno_Ingreso";
            this.nudAno_Ingreso.Size = new System.Drawing.Size(150, 22);
            this.nudAno_Ingreso.TabIndex = 25;
            this.nudAno_Ingreso.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            // 
            // txtApe_Mat
            // 
            this.txtApe_Mat.Location = new System.Drawing.Point(171, 130);
            this.txtApe_Mat.Name = "txtApe_Mat";
            this.txtApe_Mat.Size = new System.Drawing.Size(150, 22);
            this.txtApe_Mat.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Apellido materno";
            // 
            // txtApe_Pat
            // 
            this.txtApe_Pat.Location = new System.Drawing.Point(12, 130);
            this.txtApe_Pat.Name = "txtApe_Pat";
            this.txtApe_Pat.Size = new System.Drawing.Size(150, 22);
            this.txtApe_Pat.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Apellido paterno";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(12, 82);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(309, 22);
            this.txtNombres.TabIndex = 26;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Enabled = false;
            this.txtMatricula.Location = new System.Drawing.Point(12, 33);
            this.txtMatricula.MaxLength = 9;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(150, 22);
            this.txtMatricula.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre(s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Matrícula (9 dígitos)";
            // 
            // cmdModificar
            // 
            this.cmdModificar.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificar.Location = new System.Drawing.Point(12, 219);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(170, 35);
            this.cmdModificar.TabIndex = 30;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // FrmModificarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 267);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboLicenciatura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudAno_Ingreso);
            this.Controls.Add(this.txtApe_Mat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApe_Pat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdModificar);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModificarAlumno";
            this.Text = "Modificar alumno";
            this.Load += new System.EventHandler(this.FrmModificarAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAno_Ingreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboLicenciatura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudAno_Ingreso;
        private System.Windows.Forms.TextBox txtApe_Mat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApe_Pat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdModificar;
    }
}