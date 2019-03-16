namespace Dicom
{
    partial class FrmPrincipal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnEnviarSolicitud = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCargarArchivo = new System.Windows.Forms.Button();
			this.btnLeerArchivo = new System.Windows.Forms.Button();
			this.txtMensaje = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnPacienteSeleccionado = new System.Windows.Forms.Button();
			this.dgvAgendamiento = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombresPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.btnSeleccionarModalidad = new System.Windows.Forms.Button();
			this.dgvModalidades = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAgendamiento)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvModalidades)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(1, 2);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(976, 550);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Controls.Add(this.txtMensaje);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage1.Size = new System.Drawing.Size(968, 524);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "INICIO";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.LightBlue;
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.btnEnviarSolicitud);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnCargarArchivo);
			this.panel1.Controls.Add(this.btnLeerArchivo);
			this.panel1.Location = new System.Drawing.Point(733, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(237, 530);
			this.panel1.TabIndex = 1;
			// 
			// btnEnviarSolicitud
			// 
			this.btnEnviarSolicitud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEnviarSolicitud.Location = new System.Drawing.Point(43, 232);
			this.btnEnviarSolicitud.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnEnviarSolicitud.Name = "btnEnviarSolicitud";
			this.btnEnviarSolicitud.Size = new System.Drawing.Size(163, 39);
			this.btnEnviarSolicitud.TabIndex = 4;
			this.btnEnviarSolicitud.Text = "Enviar solicitud";
			this.btnEnviarSolicitud.UseVisualStyleBackColor = true;
			this.btnEnviarSolicitud.Click += new System.EventHandler(this.btnEnviarSolicitud_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(101, 440);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(46, 49);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(87, 69);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "Opciones:";
			// 
			// btnCargarArchivo
			// 
			this.btnCargarArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCargarArchivo.Location = new System.Drawing.Point(43, 177);
			this.btnCargarArchivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnCargarArchivo.Name = "btnCargarArchivo";
			this.btnCargarArchivo.Size = new System.Drawing.Size(163, 39);
			this.btnCargarArchivo.TabIndex = 1;
			this.btnCargarArchivo.Text = "Cargar archivo";
			this.btnCargarArchivo.UseVisualStyleBackColor = true;
			this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
			// 
			// btnLeerArchivo
			// 
			this.btnLeerArchivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLeerArchivo.Location = new System.Drawing.Point(43, 119);
			this.btnLeerArchivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnLeerArchivo.Name = "btnLeerArchivo";
			this.btnLeerArchivo.Size = new System.Drawing.Size(163, 39);
			this.btnLeerArchivo.TabIndex = 0;
			this.btnLeerArchivo.Text = "Leer archivo";
			this.btnLeerArchivo.UseVisualStyleBackColor = true;
			this.btnLeerArchivo.Click += new System.EventHandler(this.btnLeerArchivo_Click);
			// 
			// txtMensaje
			// 
			this.txtMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtMensaje.Location = new System.Drawing.Point(20, 19);
			this.txtMensaje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtMensaje.Multiline = true;
			this.txtMensaje.Name = "txtMensaje";
			this.txtMensaje.Size = new System.Drawing.Size(689, 485);
			this.txtMensaje.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btnPacienteSeleccionado);
			this.tabPage2.Controls.Add(this.dgvAgendamiento);
			this.tabPage2.Controls.Add(this.button2);
			this.tabPage2.Controls.Add(this.button1);
			this.tabPage2.Controls.Add(this.monthCalendar1);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage2.Size = new System.Drawing.Size(968, 524);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "AGENDA PRINCIPAL";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btnPacienteSeleccionado
			// 
			this.btnPacienteSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPacienteSeleccionado.Location = new System.Drawing.Point(635, 202);
			this.btnPacienteSeleccionado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnPacienteSeleccionado.Name = "btnPacienteSeleccionado";
			this.btnPacienteSeleccionado.Size = new System.Drawing.Size(190, 37);
			this.btnPacienteSeleccionado.TabIndex = 5;
			this.btnPacienteSeleccionado.Text = "SELECCIONAR PACIENTE";
			this.btnPacienteSeleccionado.UseVisualStyleBackColor = true;
			this.btnPacienteSeleccionado.Click += new System.EventHandler(this.btnPacienteSeleccionado_Click);
			// 
			// dgvAgendamiento
			// 
			this.dgvAgendamiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvAgendamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAgendamiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nombresPaciente,
            this.apellidos,
            this.fecha,
            this.descripcion});
			this.dgvAgendamiento.GridColor = System.Drawing.SystemColors.ControlText;
			this.dgvAgendamiento.Location = new System.Drawing.Point(56, 292);
			this.dgvAgendamiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dgvAgendamiento.Name = "dgvAgendamiento";
			this.dgvAgendamiento.RowTemplate.Height = 24;
			this.dgvAgendamiento.Size = new System.Drawing.Size(782, 167);
			this.dgvAgendamiento.TabIndex = 4;
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			// 
			// nombresPaciente
			// 
			this.nombresPaciente.HeaderText = "Nombre paciente";
			this.nombresPaciente.Name = "nombresPaciente";
			this.nombresPaciente.Width = 200;
			// 
			// apellidos
			// 
			this.apellidos.HeaderText = "Apellidos paciente";
			this.apellidos.Name = "apellidos";
			this.apellidos.Width = 200;
			// 
			// fecha
			// 
			this.fecha.HeaderText = "Fecha de estudio";
			this.fecha.Name = "fecha";
			this.fecha.Width = 200;
			// 
			// descripcion
			// 
			this.descripcion.HeaderText = "Descripción";
			this.descripcion.Name = "descripcion";
			this.descripcion.Width = 300;
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Location = new System.Drawing.Point(635, 145);
			this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(190, 37);
			this.button2.TabIndex = 3;
			this.button2.Text = "LISTAR TODAS LAS SOLICITUDES";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(635, 89);
			this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(190, 37);
			this.button1.TabIndex = 2;
			this.button1.Text = "SELECCIONAR FECHA";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.monthCalendar1.Location = new System.Drawing.Point(144, 81);
			this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(54, 44);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(377, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "Seleccione la fecha que desea ver las solicitudes de agendamiento:";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.btnSeleccionarModalidad);
			this.tabPage3.Controls.Add(this.dgvModalidades);
			this.tabPage3.Controls.Add(this.label4);
			this.tabPage3.Controls.Add(this.label3);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(968, 524);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "MODALIDADES";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// btnSeleccionarModalidad
			// 
			this.btnSeleccionarModalidad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnSeleccionarModalidad.Location = new System.Drawing.Point(343, 436);
			this.btnSeleccionarModalidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnSeleccionarModalidad.Name = "btnSeleccionarModalidad";
			this.btnSeleccionarModalidad.Size = new System.Drawing.Size(219, 38);
			this.btnSeleccionarModalidad.TabIndex = 3;
			this.btnSeleccionarModalidad.Text = "SELECCIONAR";
			this.btnSeleccionarModalidad.UseVisualStyleBackColor = true;
			this.btnSeleccionarModalidad.Click += new System.EventHandler(this.btnSeleccionarModalidad_Click);
			// 
			// dgvModalidades
			// 
			this.dgvModalidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvModalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvModalidades.Location = new System.Drawing.Point(199, 122);
			this.dgvModalidades.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dgvModalidades.Name = "dgvModalidades";
			this.dgvModalidades.RowTemplate.Height = 24;
			this.dgvModalidades.Size = new System.Drawing.Size(482, 279);
			this.dgvModalidades.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(160, 78);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(314, 15);
			this.label4.TabIndex = 1;
			this.label4.Text = "Seleccione la modalidad de la que desea ver la agenda:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(160, 37);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(183, 18);
			this.label3.TabIndex = 0;
			this.label3.Text = "LISTA DE MODALIDADES";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(43, 315);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(163, 55);
			this.button3.TabIndex = 5;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// FrmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(975, 547);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FrmPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bienvenido";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAgendamiento)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvModalidades)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargarArchivo;
        private System.Windows.Forms.Button btnLeerArchivo;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEnviarSolicitud;
        private System.Windows.Forms.DataGridView dgvAgendamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSeleccionarModalidad;
        private System.Windows.Forms.DataGridView dgvModalidades;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPacienteSeleccionado;
		private System.Windows.Forms.Button button3;
	}
}