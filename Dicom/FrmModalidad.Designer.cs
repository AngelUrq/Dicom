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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAgendamiento
            // 
            this.dgvAgendamiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAgendamiento.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAgendamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendamiento.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvAgendamiento.Location = new System.Drawing.Point(14, 13);
            this.dgvAgendamiento.Name = "dgvAgendamiento";
            this.dgvAgendamiento.RowTemplate.Height = 24;
            this.dgvAgendamiento.Size = new System.Drawing.Size(1060, 213);
            this.dgvAgendamiento.TabIndex = 10;
            // 
            // btnListarSolicitudes
            // 
            this.btnListarSolicitudes.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnListarSolicitudes.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnListarSolicitudes.FlatAppearance.BorderSize = 2;
            this.btnListarSolicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListarSolicitudes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListarSolicitudes.Location = new System.Drawing.Point(177, 325);
            this.btnListarSolicitudes.Name = "btnListarSolicitudes";
            this.btnListarSolicitudes.Size = new System.Drawing.Size(319, 47);
            this.btnListarSolicitudes.TabIndex = 9;
            this.btnListarSolicitudes.Text = "LISTAR TODAS LAS SOLICITUDES";
            this.btnListarSolicitudes.UseVisualStyleBackColor = false;
            this.btnListarSolicitudes.Click += new System.EventHandler(this.btnListarSolicitudes_Click);
            // 
            // btnSeleccionarFechaModalidad
            // 
            this.btnSeleccionarFechaModalidad.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSeleccionarFechaModalidad.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnSeleccionarFechaModalidad.FlatAppearance.BorderSize = 2;
            this.btnSeleccionarFechaModalidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeleccionarFechaModalidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeleccionarFechaModalidad.Location = new System.Drawing.Point(177, 265);
            this.btnSeleccionarFechaModalidad.Name = "btnSeleccionarFechaModalidad";
            this.btnSeleccionarFechaModalidad.Size = new System.Drawing.Size(319, 47);
            this.btnSeleccionarFechaModalidad.TabIndex = 8;
            this.btnSeleccionarFechaModalidad.Text = "SELECCIONAR FECHA";
            this.btnSeleccionarFechaModalidad.UseVisualStyleBackColor = false;
            this.btnSeleccionarFechaModalidad.Click += new System.EventHandler(this.btnSeleccionarFechaModalidad_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(536, 165);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.TrailingForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccione la fecha que desea ver las solicitudes de agendamiento:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(252, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 83);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 86);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1112, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 76);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.dgvAgendamiento);
            this.panel2.Location = new System.Drawing.Point(77, 420);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1088, 238);
            this.panel2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(827, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "AGENDAMIENTO MODALIDAD";
            // 
            // FrmModalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 698);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}