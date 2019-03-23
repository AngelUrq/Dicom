namespace Dicom
{
    partial class FrmModalidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModalidad));
            this.dgvAgendamiento = new System.Windows.Forms.DataGridView();
            this.btnListarSolicitudes = new System.Windows.Forms.Button();
            this.btnSeleccionarFechaModalidad = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAgendamiento
            // 
            this.dgvAgendamiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAgendamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendamiento.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvAgendamiento.Location = new System.Drawing.Point(90, 350);
            this.dgvAgendamiento.Name = "dgvAgendamiento";
            this.dgvAgendamiento.RowTemplate.Height = 24;
            this.dgvAgendamiento.Size = new System.Drawing.Size(1043, 218);
            this.dgvAgendamiento.TabIndex = 10;
            // 
            // btnListarSolicitudes
            // 
            this.btnListarSolicitudes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListarSolicitudes.Location = new System.Drawing.Point(823, 245);
            this.btnListarSolicitudes.Name = "btnListarSolicitudes";
            this.btnListarSolicitudes.Size = new System.Drawing.Size(254, 45);
            this.btnListarSolicitudes.TabIndex = 9;
            this.btnListarSolicitudes.Text = "LISTAR TODAS LAS SOLICITUDES";
            this.btnListarSolicitudes.UseVisualStyleBackColor = true;
            this.btnListarSolicitudes.Click += new System.EventHandler(this.btnListarSolicitudes_Click);
            // 
            // btnSeleccionarFechaModalidad
            // 
            this.btnSeleccionarFechaModalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionarFechaModalidad.Location = new System.Drawing.Point(823, 185);
            this.btnSeleccionarFechaModalidad.Name = "btnSeleccionarFechaModalidad";
            this.btnSeleccionarFechaModalidad.Size = new System.Drawing.Size(254, 45);
            this.btnSeleccionarFechaModalidad.TabIndex = 8;
            this.btnSeleccionarFechaModalidad.Text = "SELECCIONAR FECHA";
            this.btnSeleccionarFechaModalidad.UseVisualStyleBackColor = true;
            this.btnSeleccionarFechaModalidad.Click += new System.EventHandler(this.btnSeleccionarFechaModalidad_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(167, 101);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccione la fecha que desea ver las solicitudes de agendamiento:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(868, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 102);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FrmModalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 612);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvAgendamiento);
            this.Controls.Add(this.btnListarSolicitudes);
            this.Controls.Add(this.btnSeleccionarFechaModalidad);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmModalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modalidad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAgendamiento;
        private System.Windows.Forms.Button btnListarSolicitudes;
        private System.Windows.Forms.Button btnSeleccionarFechaModalidad;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}