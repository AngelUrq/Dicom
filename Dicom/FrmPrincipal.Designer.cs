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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSeleccionarModalidad = new System.Windows.Forms.Button();
            this.dgvModalidades = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPacienteSeleccionado = new System.Windows.Forms.Button();
            this.dgvAgendamiento = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalidades)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamiento)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSeleccionarModalidad);
            this.tabPage3.Controls.Add(this.dgvModalidades);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1293, 648);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MODALIDADES";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionarModalidad
            // 
            this.btnSeleccionarModalidad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSeleccionarModalidad.Location = new System.Drawing.Point(457, 537);
            this.btnSeleccionarModalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeleccionarModalidad.Name = "btnSeleccionarModalidad";
            this.btnSeleccionarModalidad.Size = new System.Drawing.Size(292, 47);
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
            this.dgvModalidades.Location = new System.Drawing.Point(265, 150);
            this.dgvModalidades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvModalidades.Name = "dgvModalidades";
            this.dgvModalidades.RowTemplate.Height = 24;
            this.dgvModalidades.Size = new System.Drawing.Size(643, 343);
            this.dgvModalidades.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(370, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Seleccione la modalidad de la que desea ver la agenda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "LISTA DE MODALIDADES";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btnPacienteSeleccionado);
            this.tabPage2.Controls.Add(this.dgvAgendamiento);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.monthCalendar1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1293, 648);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AGENDA PRINCIPAL";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPacienteSeleccionado
            // 
            this.btnPacienteSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPacienteSeleccionado.Location = new System.Drawing.Point(847, 249);
            this.btnPacienteSeleccionado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPacienteSeleccionado.Name = "btnPacienteSeleccionado";
            this.btnPacienteSeleccionado.Size = new System.Drawing.Size(253, 46);
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
            this.dgvAgendamiento.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvAgendamiento.Location = new System.Drawing.Point(75, 359);
            this.dgvAgendamiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAgendamiento.Name = "dgvAgendamiento";
            this.dgvAgendamiento.RowTemplate.Height = 24;
            this.dgvAgendamiento.Size = new System.Drawing.Size(1105, 206);
            this.dgvAgendamiento.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(847, 178);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "LISTAR TODAS LAS SOLICITUDES";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(847, 110);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "SELECCIONAR FECHA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(192, 100);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seleccione la fecha que desea ver las solicitudes de agendamiento:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1301, 677);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 673);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalidades)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamiento)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSeleccionarModalidad;
        private System.Windows.Forms.DataGridView dgvModalidades;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnPacienteSeleccionado;
        private System.Windows.Forms.DataGridView dgvAgendamiento;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
    }
}