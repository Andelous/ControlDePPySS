namespace ControlDePPySS
{
    partial class FrmNuevaCarta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevaCarta));
            this.lblSolicitud = new System.Windows.Forms.Label();
            this.txtSolicitud = new System.Windows.Forms.TextBox();
            this.cmdSeleccionarSolicitud = new System.Windows.Forms.Button();
            this.lblFI = new System.Windows.Forms.Label();
            this.lblFF = new System.Windows.Forms.Label();
            this.nudAnoI = new System.Windows.Forms.NumericUpDown();
            this.comboMesI = new System.Windows.Forms.ComboBox();
            this.nudAnoF = new System.Windows.Forms.NumericUpDown();
            this.comboMesF = new System.Windows.Forms.ComboBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.txtHoraI = new System.Windows.Forms.TextBox();
            this.lblDp1 = new System.Windows.Forms.Label();
            this.txtMinutoI = new System.Windows.Forms.TextBox();
            this.txtMinutoF = new System.Windows.Forms.TextBox();
            this.lblDp2 = new System.Windows.Forms.Label();
            this.txtHoraF = new System.Windows.Forms.TextBox();
            this.chkLunes = new System.Windows.Forms.CheckBox();
            this.lblLun = new System.Windows.Forms.Label();
            this.lblMar = new System.Windows.Forms.Label();
            this.chkMartes = new System.Windows.Forms.CheckBox();
            this.lblMie = new System.Windows.Forms.Label();
            this.chkMiercoles = new System.Windows.Forms.CheckBox();
            this.lblJue = new System.Windows.Forms.Label();
            this.chkJueves = new System.Windows.Forms.CheckBox();
            this.lblVie = new System.Windows.Forms.Label();
            this.chkViernes = new System.Windows.Forms.CheckBox();
            this.lblSab = new System.Windows.Forms.Label();
            this.chkSabado = new System.Windows.Forms.CheckBox();
            this.lblDom = new System.Windows.Forms.Label();
            this.chkDomingo = new System.Windows.Forms.CheckBox();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.nudDiaI = new System.Windows.Forms.NumericUpDown();
            this.nudDiaF = new System.Windows.Forms.NumericUpDown();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudHoras = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnoI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnoF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiaI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiaF)).BeginInit();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSolicitud
            // 
            this.lblSolicitud.AutoSize = true;
            this.lblSolicitud.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolicitud.Location = new System.Drawing.Point(12, 9);
            this.lblSolicitud.Name = "lblSolicitud";
            this.lblSolicitud.Size = new System.Drawing.Size(65, 18);
            this.lblSolicitud.TabIndex = 0;
            this.lblSolicitud.Text = "Solicitud";
            // 
            // txtSolicitud
            // 
            this.txtSolicitud.Location = new System.Drawing.Point(12, 30);
            this.txtSolicitud.Name = "txtSolicitud";
            this.txtSolicitud.ReadOnly = true;
            this.txtSolicitud.Size = new System.Drawing.Size(281, 25);
            this.txtSolicitud.TabIndex = 50;
            this.txtSolicitud.Text = "Ninguna";
            // 
            // cmdSeleccionarSolicitud
            // 
            this.cmdSeleccionarSolicitud.Location = new System.Drawing.Point(299, 29);
            this.cmdSeleccionarSolicitud.Name = "cmdSeleccionarSolicitud";
            this.cmdSeleccionarSolicitud.Size = new System.Drawing.Size(97, 27);
            this.cmdSeleccionarSolicitud.TabIndex = 51;
            this.cmdSeleccionarSolicitud.Text = "Seleccionar...";
            this.cmdSeleccionarSolicitud.UseVisualStyleBackColor = true;
            this.cmdSeleccionarSolicitud.Click += new System.EventHandler(this.cmdSeleccionarSolicitud_Click);
            // 
            // lblFI
            // 
            this.lblFI.AutoSize = true;
            this.lblFI.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFI.Location = new System.Drawing.Point(6, 28);
            this.lblFI.Name = "lblFI";
            this.lblFI.Size = new System.Drawing.Size(105, 18);
            this.lblFI.TabIndex = 3;
            this.lblFI.Text = "Fecha de inicio";
            // 
            // lblFF
            // 
            this.lblFF.AutoSize = true;
            this.lblFF.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFF.Location = new System.Drawing.Point(9, 81);
            this.lblFF.Name = "lblFF";
            this.lblFF.Size = new System.Drawing.Size(145, 18);
            this.lblFF.TabIndex = 4;
            this.lblFF.Text = "Fecha de finalización";
            // 
            // nudAnoI
            // 
            this.nudAnoI.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAnoI.Location = new System.Drawing.Point(165, 49);
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
            this.nudAnoI.Size = new System.Drawing.Size(51, 25);
            this.nudAnoI.TabIndex = 54;
            this.nudAnoI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAnoI.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.nudAnoI.ValueChanged += new System.EventHandler(this.nudAnoI_ValueChanged);
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
            this.comboMesI.Location = new System.Drawing.Point(57, 49);
            this.comboMesI.Name = "comboMesI";
            this.comboMesI.Size = new System.Drawing.Size(102, 26);
            this.comboMesI.TabIndex = 53;
            this.comboMesI.SelectedIndexChanged += new System.EventHandler(this.comboMesI_SelectedIndexChanged);
            // 
            // nudAnoF
            // 
            this.nudAnoF.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAnoF.Location = new System.Drawing.Point(165, 102);
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
            this.nudAnoF.Size = new System.Drawing.Size(51, 25);
            this.nudAnoF.TabIndex = 57;
            this.nudAnoF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAnoF.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.nudAnoF.ValueChanged += new System.EventHandler(this.nudAnoF_ValueChanged);
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
            this.comboMesF.Location = new System.Drawing.Point(57, 102);
            this.comboMesF.Name = "comboMesF";
            this.comboMesF.Size = new System.Drawing.Size(102, 26);
            this.comboMesF.TabIndex = 56;
            this.comboMesF.SelectedIndexChanged += new System.EventHandler(this.comboMesF_SelectedIndexChanged);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(248, 35);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(123, 18);
            this.lblHorario.TabIndex = 11;
            this.lblHorario.Text = "Horario ( HH:MM )";
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.Location = new System.Drawing.Point(236, 66);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(55, 18);
            this.lblDe.TabIndex = 12;
            this.lblDe.Text = "Entrada";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(248, 95);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(43, 18);
            this.lblA.TabIndex = 13;
            this.lblA.Text = "Salida";
            // 
            // txtHoraI
            // 
            this.txtHoraI.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraI.Location = new System.Drawing.Point(296, 61);
            this.txtHoraI.MaxLength = 2;
            this.txtHoraI.Name = "txtHoraI";
            this.txtHoraI.Size = new System.Drawing.Size(30, 25);
            this.txtHoraI.TabIndex = 58;
            this.txtHoraI.Text = "08";
            this.txtHoraI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDp1
            // 
            this.lblDp1.AutoSize = true;
            this.lblDp1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDp1.Location = new System.Drawing.Point(327, 64);
            this.lblDp1.Name = "lblDp1";
            this.lblDp1.Size = new System.Drawing.Size(11, 18);
            this.lblDp1.TabIndex = 15;
            this.lblDp1.Text = ":";
            // 
            // txtMinutoI
            // 
            this.txtMinutoI.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinutoI.Location = new System.Drawing.Point(338, 61);
            this.txtMinutoI.MaxLength = 2;
            this.txtMinutoI.Name = "txtMinutoI";
            this.txtMinutoI.Size = new System.Drawing.Size(30, 25);
            this.txtMinutoI.TabIndex = 59;
            this.txtMinutoI.Text = "30";
            this.txtMinutoI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMinutoF
            // 
            this.txtMinutoF.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinutoF.Location = new System.Drawing.Point(338, 93);
            this.txtMinutoF.MaxLength = 2;
            this.txtMinutoF.Name = "txtMinutoF";
            this.txtMinutoF.Size = new System.Drawing.Size(30, 25);
            this.txtMinutoF.TabIndex = 61;
            this.txtMinutoF.Text = "00";
            this.txtMinutoF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDp2
            // 
            this.lblDp2.AutoSize = true;
            this.lblDp2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDp2.Location = new System.Drawing.Point(327, 96);
            this.lblDp2.Name = "lblDp2";
            this.lblDp2.Size = new System.Drawing.Size(11, 18);
            this.lblDp2.TabIndex = 18;
            this.lblDp2.Text = ":";
            // 
            // txtHoraF
            // 
            this.txtHoraF.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraF.Location = new System.Drawing.Point(296, 93);
            this.txtHoraF.MaxLength = 2;
            this.txtHoraF.Name = "txtHoraF";
            this.txtHoraF.Size = new System.Drawing.Size(30, 25);
            this.txtHoraF.TabIndex = 60;
            this.txtHoraF.Text = "16";
            this.txtHoraF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkLunes
            // 
            this.chkLunes.AutoSize = true;
            this.chkLunes.Location = new System.Drawing.Point(27, 304);
            this.chkLunes.Name = "chkLunes";
            this.chkLunes.Size = new System.Drawing.Size(15, 14);
            this.chkLunes.TabIndex = 64;
            this.chkLunes.UseVisualStyleBackColor = true;
            // 
            // lblLun
            // 
            this.lblLun.AutoSize = true;
            this.lblLun.Location = new System.Drawing.Point(12, 321);
            this.lblLun.Name = "lblLun";
            this.lblLun.Size = new System.Drawing.Size(44, 18);
            this.lblLun.TabIndex = 21;
            this.lblLun.Text = "Lunes";
            // 
            // lblMar
            // 
            this.lblMar.AutoSize = true;
            this.lblMar.Location = new System.Drawing.Point(64, 321);
            this.lblMar.Name = "lblMar";
            this.lblMar.Size = new System.Drawing.Size(50, 18);
            this.lblMar.TabIndex = 23;
            this.lblMar.Text = "Martes";
            // 
            // chkMartes
            // 
            this.chkMartes.AutoSize = true;
            this.chkMartes.Location = new System.Drawing.Point(82, 304);
            this.chkMartes.Name = "chkMartes";
            this.chkMartes.Size = new System.Drawing.Size(15, 14);
            this.chkMartes.TabIndex = 65;
            this.chkMartes.UseVisualStyleBackColor = true;
            // 
            // lblMie
            // 
            this.lblMie.AutoSize = true;
            this.lblMie.Location = new System.Drawing.Point(113, 321);
            this.lblMie.Name = "lblMie";
            this.lblMie.Size = new System.Drawing.Size(65, 18);
            this.lblMie.TabIndex = 25;
            this.lblMie.Text = "Miércoles";
            // 
            // chkMiercoles
            // 
            this.chkMiercoles.AutoSize = true;
            this.chkMiercoles.Location = new System.Drawing.Point(137, 304);
            this.chkMiercoles.Name = "chkMiercoles";
            this.chkMiercoles.Size = new System.Drawing.Size(15, 14);
            this.chkMiercoles.TabIndex = 66;
            this.chkMiercoles.UseVisualStyleBackColor = true;
            // 
            // lblJue
            // 
            this.lblJue.AutoSize = true;
            this.lblJue.Location = new System.Drawing.Point(178, 321);
            this.lblJue.Name = "lblJue";
            this.lblJue.Size = new System.Drawing.Size(46, 18);
            this.lblJue.TabIndex = 27;
            this.lblJue.Text = "Jueves";
            // 
            // chkJueves
            // 
            this.chkJueves.AutoSize = true;
            this.chkJueves.Location = new System.Drawing.Point(192, 304);
            this.chkJueves.Name = "chkJueves";
            this.chkJueves.Size = new System.Drawing.Size(15, 14);
            this.chkJueves.TabIndex = 67;
            this.chkJueves.UseVisualStyleBackColor = true;
            // 
            // lblVie
            // 
            this.lblVie.AutoSize = true;
            this.lblVie.Location = new System.Drawing.Point(229, 321);
            this.lblVie.Name = "lblVie";
            this.lblVie.Size = new System.Drawing.Size(52, 18);
            this.lblVie.TabIndex = 29;
            this.lblVie.Text = "Viernes";
            // 
            // chkViernes
            // 
            this.chkViernes.AutoSize = true;
            this.chkViernes.Location = new System.Drawing.Point(247, 304);
            this.chkViernes.Name = "chkViernes";
            this.chkViernes.Size = new System.Drawing.Size(15, 14);
            this.chkViernes.TabIndex = 68;
            this.chkViernes.UseVisualStyleBackColor = true;
            // 
            // lblSab
            // 
            this.lblSab.AutoSize = true;
            this.lblSab.Location = new System.Drawing.Point(283, 321);
            this.lblSab.Name = "lblSab";
            this.lblSab.Size = new System.Drawing.Size(53, 18);
            this.lblSab.TabIndex = 31;
            this.lblSab.Text = "Sábado";
            // 
            // chkSabado
            // 
            this.chkSabado.AutoSize = true;
            this.chkSabado.Location = new System.Drawing.Point(302, 304);
            this.chkSabado.Name = "chkSabado";
            this.chkSabado.Size = new System.Drawing.Size(15, 14);
            this.chkSabado.TabIndex = 69;
            this.chkSabado.UseVisualStyleBackColor = true;
            // 
            // lblDom
            // 
            this.lblDom.AutoSize = true;
            this.lblDom.Location = new System.Drawing.Point(334, 321);
            this.lblDom.Name = "lblDom";
            this.lblDom.Size = new System.Drawing.Size(63, 18);
            this.lblDom.TabIndex = 33;
            this.lblDom.Text = "Domingo";
            // 
            // chkDomingo
            // 
            this.chkDomingo.AutoSize = true;
            this.chkDomingo.Location = new System.Drawing.Point(357, 304);
            this.chkDomingo.Name = "chkDomingo";
            this.chkDomingo.Size = new System.Drawing.Size(15, 14);
            this.chkDomingo.TabIndex = 70;
            this.chkDomingo.UseVisualStyleBackColor = true;
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrar.Location = new System.Drawing.Point(12, 347);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(200, 40);
            this.cmdRegistrar.TabIndex = 71;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(218, 347);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(178, 40);
            this.cmdCancelar.TabIndex = 72;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // nudDiaI
            // 
            this.nudDiaI.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDiaI.Location = new System.Drawing.Point(9, 49);
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
            this.nudDiaI.TabIndex = 52;
            this.nudDiaI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDiaI.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // nudDiaF
            // 
            this.nudDiaF.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDiaF.Location = new System.Drawing.Point(9, 102);
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
            this.nudDiaF.TabIndex = 55;
            this.nudDiaF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDiaF.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(12, 244);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.ReadOnly = true;
            this.txtAlumno.Size = new System.Drawing.Size(269, 25);
            this.txtAlumno.TabIndex = 62;
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumno.Location = new System.Drawing.Point(12, 223);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(60, 18);
            this.lblAlumno.TabIndex = 39;
            this.lblAlumno.Text = "Alumno";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lblFI);
            this.gbDatos.Controls.Add(this.lblFF);
            this.gbDatos.Controls.Add(this.comboMesI);
            this.gbDatos.Controls.Add(this.nudDiaF);
            this.gbDatos.Controls.Add(this.nudAnoI);
            this.gbDatos.Controls.Add(this.nudDiaI);
            this.gbDatos.Controls.Add(this.comboMesF);
            this.gbDatos.Controls.Add(this.nudAnoF);
            this.gbDatos.Controls.Add(this.lblHorario);
            this.gbDatos.Controls.Add(this.lblDe);
            this.gbDatos.Controls.Add(this.lblA);
            this.gbDatos.Controls.Add(this.txtHoraI);
            this.gbDatos.Controls.Add(this.lblDp1);
            this.gbDatos.Controls.Add(this.txtMinutoI);
            this.gbDatos.Controls.Add(this.txtHoraF);
            this.gbDatos.Controls.Add(this.lblDp2);
            this.gbDatos.Controls.Add(this.txtMinutoF);
            this.gbDatos.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.Location = new System.Drawing.Point(12, 62);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(384, 155);
            this.gbDatos.TabIndex = 40;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.Location = new System.Drawing.Point(12, 280);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(36, 18);
            this.lblDias.TabIndex = 41;
            this.lblDias.Text = "Días";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 43;
            this.label1.Text = "Horas a liberar";
            // 
            // nudHoras
            // 
            this.nudHoras.Location = new System.Drawing.Point(286, 244);
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
            this.nudHoras.Size = new System.Drawing.Size(110, 25);
            this.nudHoras.TabIndex = 63;
            this.nudHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHoras.Value = new decimal(new int[] {
            280,
            0,
            0,
            0});
            // 
            // FrmNuevaCarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 399);
            this.Controls.Add(this.nudHoras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.lblDom);
            this.Controls.Add(this.chkDomingo);
            this.Controls.Add(this.lblSab);
            this.Controls.Add(this.chkSabado);
            this.Controls.Add(this.lblVie);
            this.Controls.Add(this.chkViernes);
            this.Controls.Add(this.lblJue);
            this.Controls.Add(this.chkJueves);
            this.Controls.Add(this.lblMie);
            this.Controls.Add(this.chkMiercoles);
            this.Controls.Add(this.lblMar);
            this.Controls.Add(this.chkMartes);
            this.Controls.Add(this.lblLun);
            this.Controls.Add(this.chkLunes);
            this.Controls.Add(this.cmdSeleccionarSolicitud);
            this.Controls.Add(this.txtSolicitud);
            this.Controls.Add(this.lblSolicitud);
            this.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevaCarta";
            this.Text = "Nueva carta";
            this.Load += new System.EventHandler(this.FrmNuevaCarta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAnoI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnoF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiaI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiaF)).EndInit();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSolicitud;
        private System.Windows.Forms.TextBox txtSolicitud;
        private System.Windows.Forms.Button cmdSeleccionarSolicitud;
        private System.Windows.Forms.Label lblFI;
        private System.Windows.Forms.Label lblFF;
        private System.Windows.Forms.NumericUpDown nudAnoI;
        private System.Windows.Forms.ComboBox comboMesI;
        private System.Windows.Forms.NumericUpDown nudAnoF;
        private System.Windows.Forms.ComboBox comboMesF;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtHoraI;
        private System.Windows.Forms.Label lblDp1;
        private System.Windows.Forms.TextBox txtMinutoI;
        private System.Windows.Forms.TextBox txtMinutoF;
        private System.Windows.Forms.Label lblDp2;
        private System.Windows.Forms.TextBox txtHoraF;
        private System.Windows.Forms.CheckBox chkLunes;
        private System.Windows.Forms.Label lblLun;
        private System.Windows.Forms.Label lblMar;
        private System.Windows.Forms.CheckBox chkMartes;
        private System.Windows.Forms.Label lblMie;
        private System.Windows.Forms.CheckBox chkMiercoles;
        private System.Windows.Forms.Label lblJue;
        private System.Windows.Forms.CheckBox chkJueves;
        private System.Windows.Forms.Label lblVie;
        private System.Windows.Forms.CheckBox chkViernes;
        private System.Windows.Forms.Label lblSab;
        private System.Windows.Forms.CheckBox chkSabado;
        private System.Windows.Forms.Label lblDom;
        private System.Windows.Forms.CheckBox chkDomingo;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.NumericUpDown nudDiaI;
        private System.Windows.Forms.NumericUpDown nudDiaF;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudHoras;
    }
}